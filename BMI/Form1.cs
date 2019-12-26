using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtht.Text);
            double w = double.Parse(txtwt.Text);
            double bmi = w / (h * h);
            Result.Text = "당신의 BMI는 "+bmi+"입니다.";
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
