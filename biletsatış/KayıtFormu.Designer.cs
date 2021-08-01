
namespace biletsatış
{
    partial class KayıtFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdBay = new System.Windows.Forms.RadioButton();
            this.rdBayan = new System.Windows.Forms.RadioButton();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(149, 24);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(125, 27);
            this.txtİsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(149, 86);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(125, 27);
            this.txtSoyisim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYİSİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TELEFON";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(149, 151);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(125, 27);
            this.mskTelefon.TabIndex = 5;
            // 
            // rdBay
            // 
            this.rdBay.AutoSize = true;
            this.rdBay.Checked = true;
            this.rdBay.Location = new System.Drawing.Point(76, 268);
            this.rdBay.Name = "rdBay";
            this.rdBay.Size = new System.Drawing.Size(56, 24);
            this.rdBay.TabIndex = 6;
            this.rdBay.TabStop = true;
            this.rdBay.Text = "BAY";
            this.rdBay.UseVisualStyleBackColor = true;
            // 
            // rdBayan
            // 
            this.rdBayan.AutoSize = true;
            this.rdBayan.Location = new System.Drawing.Point(291, 268);
            this.rdBayan.Name = "rdBayan";
            this.rdBayan.Size = new System.Drawing.Size(76, 24);
            this.rdBayan.TabIndex = 7;
            this.rdBayan.Text = "BAYAN";
            this.rdBayan.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(76, 308);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(117, 29);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(291, 308);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(117, 29);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.rdBayan);
            this.Controls.Add(this.rdBay);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayıtFormu";
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtİsim;
        public System.Windows.Forms.TextBox txtSoyisim;
        public System.Windows.Forms.MaskedTextBox mskTelefon;
        public System.Windows.Forms.RadioButton rdBay;
        public System.Windows.Forms.RadioButton rdBayan;
        public System.Windows.Forms.Button btnİptal;
        public System.Windows.Forms.Button btnTamam;
    }
}