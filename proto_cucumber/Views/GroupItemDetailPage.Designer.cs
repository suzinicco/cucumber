namespace proto_cucumber
{
    partial class GroupItemDetailPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.winLayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.imageControl = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.winLayoutControl1)).BeginInit();
            this.winLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // winLayoutControl1
            // 
            this.winLayoutControl1.Controls.Add(this.treeList2);
            this.winLayoutControl1.Controls.Add(this.imageControl);
            this.winLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.winLayoutControl1.Name = "winLayoutControl1";
            this.winLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1004, 159, 450, 350);
            this.winLayoutControl1.Root = this.layoutControlGroup1;
            this.winLayoutControl1.Size = new System.Drawing.Size(835, 192);
            this.winLayoutControl1.TabIndex = 0;
            this.winLayoutControl1.Text = "winLayoutControl1";
       
       
            // 
            // imageControl
            // 
            this.imageControl.Location = new System.Drawing.Point(12, 12);
            this.imageControl.Name = "imageControl";
            this.imageControl.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imageControl.Size = new System.Drawing.Size(178, 132);
            this.imageControl.StyleController = this.winLayoutControl1;
            this.imageControl.TabIndex = 4;
            this.imageControl.Click += new System.EventHandler(this.imageControlClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(818, 206);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.imageControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(182, 136);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(182, 136);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(798, 136);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 136);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(121, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(798, 26);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.treeList2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(798, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // GroupItemDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.winLayoutControl1);
            this.Name = "GroupItemDetailPage";
            this.Size = new System.Drawing.Size(835, 192);
            ((System.ComponentModel.ISupportInitialize)(this.winLayoutControl1)).EndInit();
            this.winLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl winLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PictureEdit imageControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraTreeList.TreeList treeList2;

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
