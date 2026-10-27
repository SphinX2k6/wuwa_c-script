using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FA RID: 22522
	public class IRangeByTagT
	{
		// Token: 0x1700A83F RID: 43071
		// (get) Token: 0x06025DB8 RID: 155064 RVA: 0x00538950 File Offset: 0x00536B50
		// (set) Token: 0x06025DB9 RID: 155065 RVA: 0x00538958 File Offset: 0x00536B58
		public int Tag { get; set; }

		// Token: 0x1700A840 RID: 43072
		// (get) Token: 0x06025DBA RID: 155066 RVA: 0x00538961 File Offset: 0x00536B61
		// (set) Token: 0x06025DBB RID: 155067 RVA: 0x00538969 File Offset: 0x00536B69
		public float Range { get; set; }

		// Token: 0x1700A841 RID: 43073
		// (get) Token: 0x06025DBC RID: 155068 RVA: 0x00538972 File Offset: 0x00536B72
		// (set) Token: 0x06025DBD RID: 155069 RVA: 0x0053897A File Offset: 0x00536B7A
		public float ExitRange { get; set; }

		// Token: 0x1700A842 RID: 43074
		// (get) Token: 0x06025DBE RID: 155070 RVA: 0x00538983 File Offset: 0x00536B83
		// (set) Token: 0x06025DBF RID: 155071 RVA: 0x0053898B File Offset: 0x00536B8B
		public byte NullMask { get; set; }

		// Token: 0x06025DC0 RID: 155072 RVA: 0x00538994 File Offset: 0x00536B94
		public IRangeByTagT()
		{
			this.Tag = 0;
			this.Range = 0f;
			this.ExitRange = 0f;
			this.NullMask = 0;
		}
	}
}
