using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A33 RID: 23091
	public class IJigsawItemT
	{
		// Token: 0x1700A7E2 RID: 42978
		// (get) Token: 0x06025BD6 RID: 154582 RVA: 0x0052C6A9 File Offset: 0x0052A8A9
		// (set) Token: 0x06025BD7 RID: 154583 RVA: 0x0052C6B1 File Offset: 0x0052A8B1
		public bool Disabled { get; set; }

		// Token: 0x1700A7E3 RID: 42979
		// (get) Token: 0x06025BD8 RID: 154584 RVA: 0x0052C6BA File Offset: 0x0052A8BA
		// (set) Token: 0x06025BD9 RID: 154585 RVA: 0x0052C6C2 File Offset: 0x0052A8C2
		public TFillConfigUnion FillCfg { get; set; }

		// Token: 0x1700A7E4 RID: 42980
		// (get) Token: 0x06025BDA RID: 154586 RVA: 0x0052C6CB File Offset: 0x0052A8CB
		// (set) Token: 0x06025BDB RID: 154587 RVA: 0x0052C6D3 File Offset: 0x0052A8D3
		public byte NullMask { get; set; }

		// Token: 0x06025BDC RID: 154588 RVA: 0x0052C6DC File Offset: 0x0052A8DC
		public IJigsawItemT()
		{
			this.Disabled = false;
			this.FillCfg = null;
			this.NullMask = 0;
		}
	}
}
