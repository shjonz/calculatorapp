using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        private List<string> math_symbols = new List<string>(); //to keep track of what math operation we are gonna undergo
        public MainPage()
        {
            InitializeComponent();
        }


        //functions for clear and equals
        private void clear(object sender, EventArgs e)
        {
            DisplayLabel.Text = "0"; //set displaylabel back to 0
            math_symbols.Clear();
        }

        private void equal(object sender, EventArgs args)
        {
            if (DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "+" || DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "-"
                || DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "*" || DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "/") 
            {
                //check for error if math symbol is last on the label like "8+"
                //then this will remove the last symbol to become "8"

                DisplayLabel.Text = DisplayLabel.Text.Substring(0,DisplayLabel.Text.Length - 1); 
                math_symbols.RemoveAt(math_symbols.Count-1);
            }
            else
            {
                var first = math_symbols[0];
                if (first == "+")
                {
                    var numbers = DisplayLabel.Text; //grab data from label
                    var numbersArray = numbers.Split('+'); //split data into 2 since it will be a string of "1+2" 
                    var final = Convert.ToDecimal(numbersArray[0]) + Convert.ToDecimal(numbersArray[1]); //calculate
                    var result = final.ToString(); //convert final to string
                    DisplayLabel.Text = result; //change label to result
                    math_symbols.Clear();
                } //repeat for next 4 symbols

                if (first == "-")
                {
                    var numbersArray = DisplayLabel.Text.Split('-'); //split data into 2 since it will be a string of "1+2"
                    var final = Convert.ToDecimal(numbersArray[0]) - Convert.ToDecimal(numbersArray[1]);
                    DisplayLabel.Text = final.ToString(); //convert final to string
                    math_symbols.Clear();
                }

                if (first == "/")
                {
                    var numbersArray = DisplayLabel.Text.Split('/'); //split data into 2 since it will be a string of "1+2"
                    var final = Convert.ToDecimal(numbersArray[0]) / Convert.ToDecimal(numbersArray[1]);
                    DisplayLabel.Text = final.ToString(); //convert final to string
                    math_symbols.Clear();
                }

                if (first == "*")
                {
                    var numbersArray = DisplayLabel.Text.Split('*'); //split data into 2 since it will be a string of "1+2"
                    var final = Convert.ToDecimal(numbersArray[0]) * Convert.ToDecimal(numbersArray[1]);
                    DisplayLabel.Text = final.ToString(); //convert final to string
                    math_symbols.Clear();
                }
            }
            

       
        }




        //math functions, del, add, mutl, sub and div

        private void del(object sender, EventArgs args)
        {
            if (DisplayLabel.Text.Length == 1) //base case: if the length is 1, it can never be less than 1
            {
                DisplayLabel.Text = "0";
            }

            if (DisplayLabel.Text.Length > 1) //if there is more than 1 remove latest.
            {
                if (DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "+")
                {
                    math_symbols.Remove("+");
                }
                if (DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "-")
                {
                    math_symbols.Remove("-");
                }

                if (DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "*")
                {
                    math_symbols.Remove("*");
                }

                if (DisplayLabel.Text[DisplayLabel.Text.Length - 1].ToString() == "/")
                {
                    math_symbols.Remove("/");
                }

                DisplayLabel.Text = DisplayLabel.Text.Substring(0, DisplayLabel.Text.Length - 1);
            }

        }

        private void div(object sender, EventArgs args)
        {
            DisplayLabel.Text += "/"; //add the arithmetic operator to the label
            math_symbols.Add("/"); //add the arithmetic operator to the list
        }

        private void add(object sender, EventArgs args)
        {
            DisplayLabel.Text += "+";
            math_symbols.Add("+");
        }
        private void sub(object sender, EventArgs args)
        {
            DisplayLabel.Text += "-";
            math_symbols.Add("-");
        }

        private void mult(object sender, EventArgs args)
        {
            DisplayLabel.Text += "*";
            math_symbols.Add("*");
        }

        

        //numbers function
        private void dot(object sender, EventArgs args) 
        {
            if (DisplayLabel.Text == "0") //check if the display text has no prior number, then putting a dot doesnt make sense since u dont need 0.0
                DisplayLabel.Text = "0";
            else
                DisplayLabel.Text += "."; //if there is a number alr, then put a dot to have decimal number
        }
        private void number0(object sender, EventArgs args) 
        {
            if (DisplayLabel.Text == "0") 
                DisplayLabel.Text = "0";
            else
                DisplayLabel.Text += "0";
        }

        private void number1(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0") //if text is currently 0, change the number to 1 since its the first number
                DisplayLabel.Text = "1";
            else
                DisplayLabel.Text += "1"; //otherwise there is some other number like 4 or 4.3 or 4. so just add 1 to it
        }

        private void number2(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "2";
            else
                DisplayLabel.Text += "2";
        }

        private void number3(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "3";
            else
                DisplayLabel.Text += "3";
        }

        private void number4(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "4";
            else
                DisplayLabel.Text += "4";
        }

        private void number5(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "5";
            else
                DisplayLabel.Text += "5";
        }

        private void number6(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "6";
            else
                DisplayLabel.Text += "6";
        }

        private void number7(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "7";
            else
                DisplayLabel.Text += "7";
        }

        private void number8(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "8";
            else
                DisplayLabel.Text += "8";
        }

        private void number9(object sender, EventArgs args)
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = "9";
            else
                DisplayLabel.Text += "9";
        }
    }
}
