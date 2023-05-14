using System;
using System.Data;
using System.Windows.Forms;

namespace MojBroj
{
    public partial class Form1 : Form
    {

        public int Rezultat, PrviBroj, DrugiBroj, TreciBroj, CetvrtiBroj, PetiBroj, SestiBroj;
        int i;


        private void btn_PrviBroj_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_PrviBroj.Text;
            btn_PrviBroj.Enabled = false;
        }

        private void btn_DrugiBroj_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_DrugiBroj.Text;
            btn_DrugiBroj.Enabled = false;
        }

        private void btn_TreciBroj_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_TreciBroj.Text;
            btn_TreciBroj.Enabled = false;
        }

        private void btn_CetvrtiBroj_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_CetvrtiBroj.Text;
            btn_CetvrtiBroj.Enabled = false;
        }

        private void btn_PetiBroj_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_PetiBroj.Text;
            btn_PetiBroj.Enabled = false;
        }

        private void btn_SestiBroj_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_SestiBroj.Text;
            btn_SestiBroj.Enabled = false;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_Plus.Text;
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_Minus.Text;
        }

        private void btn_Mnozenje_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_Mnozenje.Text;
        }

        private void btn_Deljenje_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_Deljenje.Text;
        }

        private void btn_OtvorenaZagrada_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_OtvorenaZagrada.Text;
        }

        private void btn_ZatvorenaZagrada_Click(object sender, EventArgs e)
        {
            tb_FormulaIgraca.Text += btn_ZatvorenaZagrada.Text;
        }

        private void btn_Brisanje_Click(object sender, EventArgs e)
        {
            if (tb_FormulaIgraca.Text == "")
            {
                MessageBox.Show("Morate uneti barem jedan broj da bi izraz mogli obrisati!");
            }
            else
            {
                tb_FormulaIgraca.Text = "";
                tb_RezultatIgraca.Text = "";
                PrekidacZaDugmad(true);
            }
        }

        private void btn_Potvrda_Click(object sender, EventArgs e)
        {
            if (tb_FormulaIgraca.Text == "")
            {
                MessageBox.Show("Morate uneti matematicki izraz za racunanje!");
            }
            else
            {
                try
                {
                    string Formula = tb_FormulaIgraca.Text;
                    DataTable Tabela = new DataTable();
                    double Izracunato = Convert.ToDouble(Tabela.Compute(Formula, ""));
                    tb_RezultatIgraca.Text = Convert.ToString(Izracunato);
                    btn_Racunar.Enabled = true;
                    //btn_Brisanje.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Nije bilo moguce izracunati ovaj matematicki izraz!");
                }
            }
        }



        private void btn_Stop_Click(object sender, EventArgs e)
        {
            PozivanjeBrojeva();



        }


        private void btn_CentralnoDugme_Click(object sender, EventArgs e)
        {
            btn_CentralnoDugme.Visible = false;
            btn_Stop.Visible = true;
            i = 0;
            tb_FormulaIgraca.Text = "";
            tb_FormulaRacunara.Text = "";
            tb_RezultatIgraca.Text = "";
            tb_RezultatRacunara.Text = "";
            //Postavljanje Crnog Kvadrata tamo gde jos nema broja;
            tb_Rezultat.Text = "▮▮▮";
            btn_PrviBroj.Text = "▮";
            btn_DrugiBroj.Text = "▮";
            btn_TreciBroj.Text = "▮";
            btn_CetvrtiBroj.Text = "▮";
            btn_PetiBroj.Text = "▮";
            btn_SestiBroj.Text = "▮";
            btn_Brisanje.Enabled = true;
            btn_Racunar.Enabled = false;
            PrekidacZaDugmad(false);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Stop.Visible = false;
        }

        public void PozivanjeBrojeva()
        {

            int ovajBroj;
            Random randomBroj = new Random();





            switch (i)
            {
                case 0:
                    ovajBroj = randomBroj.Next(1, 10);
                    tb_Rezultat.Text = Convert.ToString(ovajBroj);
                    i++;
                    break;
                case 1:
                    ovajBroj = randomBroj.Next(1, 10);
                    tb_Rezultat.Text += Convert.ToString(ovajBroj);
                    i++;
                    break;
                case 2:
                    ovajBroj = randomBroj.Next(1, 10);
                    tb_Rezultat.Text += Convert.ToString(ovajBroj);
                    i++;
                    Rezultat = Convert.ToInt32(tb_Rezultat.Text);
                    break;
                case 3:
                    ovajBroj = randomBroj.Next(1, 10);
                    btn_PrviBroj.Text = Convert.ToString(ovajBroj);
                    i++;
                    PrviBroj = ovajBroj;
                    break;
                case 4:
                    ovajBroj = randomBroj.Next(1, 10);
                    btn_DrugiBroj.Text = Convert.ToString(ovajBroj);
                    DrugiBroj = ovajBroj;
                    i++;
                    break;
                case 5:
                    ovajBroj = randomBroj.Next(1, 10);
                    btn_TreciBroj.Text = Convert.ToString(ovajBroj);
                    TreciBroj = ovajBroj;
                    i++;
                    break;
                case 6:
                    ovajBroj = randomBroj.Next(1, 10);
                    btn_CetvrtiBroj.Text = Convert.ToString(ovajBroj);
                    CetvrtiBroj = ovajBroj;
                    i++;
                    break;
                case 7:
                    ovajBroj = randomBroj.Next(3);
                    if (ovajBroj == 0)
                    {
                        btn_PetiBroj.Text = "10";
                    }
                    else if (ovajBroj == 1)
                    {
                        btn_PetiBroj.Text = "15";
                    }
                    else if (ovajBroj == 2)
                    {
                        btn_PetiBroj.Text = "20";
                    }
                    PetiBroj = Convert.ToInt32(btn_PetiBroj.Text);
                    i++;
                    break;
                case 8:
                    ovajBroj = randomBroj.Next(4);
                    if (ovajBroj == 0)
                    {
                        btn_SestiBroj.Text = "25";
                    }
                    else if (ovajBroj == 1)
                    {
                        btn_SestiBroj.Text = "50";
                    }
                    else if (ovajBroj == 2)
                    {
                        btn_SestiBroj.Text = "75";
                    }
                    else if (ovajBroj == 3)
                    {
                        btn_SestiBroj.Text = "100";
                    }
                    SestiBroj = Convert.ToInt32(btn_SestiBroj.Text);
                    btn_Stop.Visible = false;
                    btn_CentralnoDugme.Visible = true;
                    PrekidacZaDugmad(true);
                    break;

            }

        }

        public void PrekidacZaDugmad(bool Stanje)
        {
            
            btn_PrviBroj.Enabled = Stanje;
            btn_DrugiBroj.Enabled = Stanje;
            btn_TreciBroj.Enabled = Stanje;
            btn_CetvrtiBroj.Enabled = Stanje;
            btn_PetiBroj.Enabled = Stanje;
            btn_SestiBroj.Enabled = Stanje;
            btn_Plus.Enabled = Stanje;
            btn_Minus.Enabled = Stanje;
            btn_Mnozenje.Enabled = Stanje;
            btn_Deljenje.Enabled = Stanje;
            btn_OtvorenaZagrada.Enabled = Stanje;
            btn_ZatvorenaZagrada.Enabled = Stanje;
        }
        
        ///////////////////////////////////////////////////////////////////////////////////
        ///Racunar racuna rezultat
        private void btn_Racunar_Click(object sender, EventArgs e)
        {
            btn_Brisanje.Enabled = false;
            int value = Rezultat;
            int[] numbers = { PrviBroj, DrugiBroj, TreciBroj, CetvrtiBroj, PetiBroj, SestiBroj }; // Brojevi 
            //int desiredNumber = Rezultat; // zeljeni rezultat

            //string closestExpression = FindClosestExpression(numbers, desiredNumber);
            //tb_FormulaRacunara.Text = closestExpression;

            /////Racunanje rezultata na osnovu izraza racunara
            /////
            //string Formula = tb_FormulaRacunara.Text;
            //DataTable Tabela = new DataTable();
            //double Izracunato = Convert.ToDouble(Tabela.Compute(Formula, ""));
            //tb_RezultatRacunara.Text = Convert.ToString(Izracunato);
            
            

            SolveAndPrint(numbers, value);



        }


        public void SolveAndPrint(int[] numbers, int targetValue)
        {
            
            int targetKey = (targetValue << numbers.Length) + (1 << numbers.Length) - 1;
            // (value << numbers.Length) represents expression value
            // (1 << numbers.Length) - 1 represents mask with all bits set to 1,
            // i.e. mask in which each input number has been used exactly once
            // to build the expression.

            System.Collections.Generic.HashSet<int> solvedKeys =
                new System.Collections.Generic.HashSet<int>();
            // Each number in the collection indicates that corresponding value + mask
            // has been reached using arithmetical operations.

            System.Collections.Generic.Dictionary<int, int> keyToLeftParent =
                new System.Collections.Generic.Dictionary<int, int>();
            // For each solved key (value + mask), there is an entry indicating
            // result of the expression on the left side of the arithmetic
            // operator. Missing value indicates that key represents the
            // raw number (taken from the input list), rather than
            // the result of a calculation.

            System.Collections.Generic.Dictionary<int, int> keyToRightParent =
                new System.Collections.Generic.Dictionary<int, int>();
            // Same as keyToLeftParent, only indicating the right parent
            // used to build the expression.

            System.Collections.Generic.Dictionary<int, char> keyToOperator =
                new System.Collections.Generic.Dictionary<int, char>();
            // Indicates arithmetic operator used to build this node
            // from left and right parent nodes. Missing value for a given key
            // indicates that key is a raw value taken from input array,
            // rather than result of an arithmetic operation.

            System.Collections.Generic.Queue<int> queue =
                new System.Collections.Generic.Queue<int>();
            // Keys (value + mask pairs) that have not been processed yet

            // First step is to initialize the structures:
            // Add all input values into corresponding array entries and
            // add them to the queue so that the operation can begin

            for (int i = 0; i < numbers.Length; i++)
            {

                int key = (numbers[i] << numbers.Length) + (1 << i);

                solvedKeys.Add(key);
                queue.Enqueue(key);

            }

            // Now expand entries one at the time until queue is empty,
            // i.e. until there are no new entries populated.
            // Additional stopping condition is that target key has been generated,
            // which indicates that problem has been solved and there is no need to
            // expand nodes any further.

            while (queue.Count > 0 && !solvedKeys.Contains(targetKey))
            {

                int curKey = queue.Dequeue();

                int curMask = curKey & ((1 << numbers.Length) - 1);
                int curValue = curKey >> numbers.Length;

                // Now first take a snapshot of all keys that
                // have been reached because this collection is going to
                // change during the following operation

                int[] keys = new int[solvedKeys.Count];
                solvedKeys.CopyTo(keys);

                for (int i = 0; i < keys.Length; i++)
                {

                    int mask = keys[i] & ((1 << numbers.Length) - 1);
                    int value = keys[i] >> numbers.Length;

                    if ((mask & curMask) == 0)
                    { // Masks are disjoint, i.e. two entries do not use
                      // the same input number twice.
                      // This is sufficient condition to combine the two entries

                        for (int op = 0; op < 6; op++)
                        {

                            char opSign = '\0';
                            int newValue = 0;

                            switch (op)
                            {
                                case 0: // Addition
                                    newValue = curValue + value;
                                    opSign = '+';
                                    break;
                                case 1: // Subtraction - another value subtracted from current
                                    newValue = curValue - value;
                                    opSign = '-';
                                    break;
                                case 2: // Subtraction - current value subtracted from another
                                    newValue = value - curValue;
                                    opSign = '-';
                                    break;
                                case 3: // Multiplication
                                    newValue = curValue * value;
                                    opSign = '*';
                                    break;
                                case 4: // Division - current divided by another
                                    newValue = -1;  // Indicates failure to divide
                                    if (value != 0 && curValue % value == 0)
                                        newValue = curValue;
                                    opSign = '/';
                                    break;
                                case 5: // Division - other value divided by current
                                    newValue = -1;  // Indicates failure to divide
                                    if (curValue != 0 && value % curValue == 0)
                                        newValue = value;
                                    opSign = '/';
                                    break;
                            }

                            if (newValue >= 0)
                            {   // Ignore negative values - they can always be created
                                // the other way around, by subtracting them
                                // from a larger value so that positive value is reached.

                                int newMask = (curMask | mask);
                                // Combine the masks to indicate that all input numbers
                                // from both operands have been used to produce
                                // the resulting expression

                                int newKey = (newValue << numbers.Length) + newMask;

                                if (!solvedKeys.Contains(newKey))
                                {   // We have reached a new entry.
                                    // This expression should now be added
                                    // to data structures and processed further
                                    // in the following steps.

                                    // Populate entries that describe newly created expression
                                    solvedKeys.Add(newKey);

                                    if (op == 2 || op == 5)
                                    {   // Special cases - antireflexive operations
                                        // with interchanged operands
                                        keyToLeftParent.Add(newKey, keys[i]);
                                        keyToRightParent.Add(newKey, curKey);
                                    }
                                    else
                                    {
                                        keyToLeftParent.Add(newKey, curKey);
                                        keyToRightParent.Add(newKey, keys[i]);
                                    }

                                    keyToOperator.Add(newKey, opSign);

                                    // Add expression to list of reachable expressions
                                    solvedKeys.Add(newKey);

                                    // Add expression to the queue for further expansion
                                    queue.Enqueue(newKey);

                                }

                            }

                        }
                    }
                }

            }

            // Now print the solution if it has been found

            if (!solvedKeys.Contains(targetKey))
            {
                //tb_FormulaRacunara.Text = Convert.ToString("Solution has not been found.");
                FindClosestExpression();

            }

            else
            {
                PrintExpression(keyToLeftParent, keyToRightParent, keyToOperator, targetKey, numbers.Length);
                tb_RezultatRacunara.Text = Convert.ToString(targetValue);

            }
        }

        public void PrintExpression(System.Collections.Generic.Dictionary<int, int> keyToLeftParent,
                                    System.Collections.Generic.Dictionary<int, int> keyToRightParent,
                                    System.Collections.Generic.Dictionary<int, char> keyToOperator,
                                    int key, int numbersCount)
        {

            if (!keyToOperator.ContainsKey(key))
            {
                tb_FormulaRacunara.Text+=Convert.ToString(key >> numbersCount);
            }
            else
            {

                tb_FormulaRacunara.Text += Convert.ToString("(");

                // Recursively print the left operand
                PrintExpression(keyToLeftParent, keyToRightParent, keyToOperator,
                                keyToLeftParent[key], numbersCount);

                // Then print the operation sign
                tb_FormulaRacunara.Text += Convert.ToString(keyToOperator[key]);

                // Finally, print the right operand
                PrintExpression(keyToLeftParent, keyToRightParent, keyToOperator,
                                keyToRightParent[key], numbersCount);

                tb_FormulaRacunara.Text += Convert.ToString(")");

            }

        }

        //////////////////////////////////////////////////
        ///Ukoliko nije pronadjena tacna vrednost, trazi se priblizna!



        public string FindClosestExpression()
        {
            try
            {
                int desiredNumber = Rezultat;
                int[] numbers = { PrviBroj, DrugiBroj, TreciBroj, CetvrtiBroj, PetiBroj, SestiBroj };

                int closestDifference = int.MaxValue;
                string closestExpression = "";

                // Pronalazenje svih mogucih izraza
                int totalExpressions = (int)Math.Pow(4, numbers.Length - 1); // 4 funkcije: +, -, *, /
                for (int i = 0; i < totalExpressions; i++)
                {
                    string expression = GenerateExpression(numbers, i);
                    double result = EvaluateExpression(expression);

                    // Calculate the difference between the result and the desired number
                    int difference = Math.Abs(Convert.ToInt32(result) - desiredNumber);

                    // Update the closest expression if the current difference is smaller
                    if (difference < closestDifference)
                    {
                        closestDifference = difference;
                        closestExpression = expression;
                    }
                }

                return closestExpression;
            }catch{
                MessageBox.Show("Greska!");
                return "";
            }
        }

        static string GenerateExpression(int[] numbers, int expressionIndex)
        {
            try
            {
                string expression = numbers[0].ToString();
                int numberIndex = 1;

                // Generate the expression by replacing each placeholder with a number and an operator
                while (expressionIndex > 0)
                {
                    int operatorIndex = expressionIndex % 4;
                    expressionIndex /= 4;

                    string op;
                    switch (operatorIndex)
                    {
                        case 0:
                            op = " + ";
                            break;
                        case 1:
                            op = " - ";
                            break;
                        case 2:
                            op = " * ";
                            break;
                        case 3:
                            op = " / ";
                            break;
                        default:
                            op = "";
                            break;
                    }

                    expression += op + numbers[numberIndex++];
                }

                return expression;
            }catch{
                MessageBox.Show("Greska!");
                return "";
            }
}

        static double EvaluateExpression(string expression)
        {
            try { 
            // Use a DataTable to evaluate the expression
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("expression", typeof(string), expression);
            System.Data.DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
            return Convert.ToDouble(row["expression"]);
            }
            catch
            {
                MessageBox.Show("Greska!");
                return 0;
            }
        }

    }
}

