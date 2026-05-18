using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtDisplay.Text == "0" || operationPressed)
            {
                txtDisplay.Clear();
            }

            operationPressed = false;
            txtDisplay.Text += button.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = button.Text;
            operationPressed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
        }
    }
}