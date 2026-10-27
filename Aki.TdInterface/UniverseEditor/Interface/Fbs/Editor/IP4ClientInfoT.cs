using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004890 RID: 18576
	public class IP4ClientInfoT
	{
		// Token: 0x170086BD RID: 34493
		// (get) Token: 0x0601CFD2 RID: 118738 RVA: 0x0041890D File Offset: 0x00416B0D
		// (set) Token: 0x0601CFD3 RID: 118739 RVA: 0x00418915 File Offset: 0x00416B15
		public string Client { get; set; }

		// Token: 0x170086BE RID: 34494
		// (get) Token: 0x0601CFD4 RID: 118740 RVA: 0x0041891E File Offset: 0x00416B1E
		// (set) Token: 0x0601CFD5 RID: 118741 RVA: 0x00418926 File Offset: 0x00416B26
		public string Owner { get; set; }

		// Token: 0x170086BF RID: 34495
		// (get) Token: 0x0601CFD6 RID: 118742 RVA: 0x0041892F File Offset: 0x00416B2F
		// (set) Token: 0x0601CFD7 RID: 118743 RVA: 0x00418937 File Offset: 0x00416B37
		public string Root { get; set; }

		// Token: 0x170086C0 RID: 34496
		// (get) Token: 0x0601CFD8 RID: 118744 RVA: 0x00418940 File Offset: 0x00416B40
		// (set) Token: 0x0601CFD9 RID: 118745 RVA: 0x00418948 File Offset: 0x00416B48
		public string Stream { get; set; }

		// Token: 0x0601CFDA RID: 118746 RVA: 0x00418951 File Offset: 0x00416B51
		public IP4ClientInfoT()
		{
			this.Client = null;
			this.Owner = null;
			this.Root = null;
			this.Stream = null;
		}
	}
}
