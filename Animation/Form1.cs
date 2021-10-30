using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateGraphics();
            DoubleBuffered = true;
        }
        int n = 0;
        Point[] a = new Point[100];
        SolidBrush[] abrush = new SolidBrush[100];
        private Color RandomColor()
        {
            timer1.Start();
            Random random = new Random();
            int color = random.Next(1, 7);
            switch(color)
            {
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Orange;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Green;
                case 5:
                    return Color.Blue;
                case 6:
                    return Color.Indigo;
                case 7:
                    return Color.Violet;
            }
            return Color.White;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            a[n].X = e.X;
            a[n].Y = e.Y;
            SolidBrush mybrush = new SolidBrush(RandomColor());
            abrush[n] = mybrush;         
            n = n + 1;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                a[i].Y = a[i].Y + 5;
                Rectangle shape = new Rectangle(a[i].X, a[i].Y, 50, 50);
                e.Graphics.FillEllipse(abrush[i], shape);
            }        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
