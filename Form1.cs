using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao_Click(object sender, EventArgs e)
        {
            double altura1 = double.Parse(altura.Text);
            double peso1 = double.Parse(peso.Text);
            double r = Math.Pow(altura1, 2);
            double imc = peso1/r;
            string result = "";
            
            label3.Text = imc.ToString("F");
            if(imc <= 18.4) { 
                result = "voce esta abaixo do peso ideal";



            }else if(imc >= 18.5 && imc <= 24.9) {
                result = "voce esta com peso normal";
            }else
            {
                result = "voce esta acima do peso ideal";
            }
            label4.Text= result;

        }

        private void peso_TextChanged(object sender, EventArgs e)
        {


        }

        private void altura_TextChanged(object sender,EventArgs e)
        {

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
