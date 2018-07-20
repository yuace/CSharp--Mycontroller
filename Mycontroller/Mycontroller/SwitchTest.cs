using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycontroller
{
    public partial class SwitchTest : UserControl
    {
        public SwitchTest()
        {
            InitializeComponent();
            //设置Style支持透明背景色并且双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;

            this.Cursor = Cursors.Hand;
            this.Size = new Size(87, 27);
        }

        //开关标志
        bool isSwitch = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            if (isSwitch)
            {
                g.DrawImage(Properties.Resources.switchon, rec);
            }
            else
            {
                g.DrawImage(Properties.Resources.switchoff, rec);
            }
        }
        /// <summary>
        /// 重写开关点击
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            isSwitch = !isSwitch;
            this.Invalidate();
            base.OnMouseClick(e);
        }
    }
}
