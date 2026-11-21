using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF5 RID: 19701
	public class IP4ClientInfoT
	{
		// Token: 0x17008D05 RID: 36101
		// (get) Token: 0x0601E7BF RID: 124863 RVA: 0x004450A9 File Offset: 0x004432A9
		// (set) Token: 0x0601E7C0 RID: 124864 RVA: 0x004450B1 File Offset: 0x004432B1
		public string Client { get; set; }

		// Token: 0x17008D06 RID: 36102
		// (get) Token: 0x0601E7C1 RID: 124865 RVA: 0x004450BA File Offset: 0x004432BA
		// (set) Token: 0x0601E7C2 RID: 124866 RVA: 0x004450C2 File Offset: 0x004432C2
		public string Owner { get; set; }

		// Token: 0x17008D07 RID: 36103
		// (get) Token: 0x0601E7C3 RID: 124867 RVA: 0x004450CB File Offset: 0x004432CB
		// (set) Token: 0x0601E7C4 RID: 124868 RVA: 0x004450D3 File Offset: 0x004432D3
		public string Root { get; set; }

		// Token: 0x17008D08 RID: 36104
		// (get) Token: 0x0601E7C5 RID: 124869 RVA: 0x004450DC File Offset: 0x004432DC
		// (set) Token: 0x0601E7C6 RID: 124870 RVA: 0x004450E4 File Offset: 0x004432E4
		public string Stream { get; set; }

		// Token: 0x0601E7C7 RID: 124871 RVA: 0x004450ED File Offset: 0x004432ED
		public IP4ClientInfoT()
		{
			this.Client = null;
			this.Owner = null;
			this.Root = null;
			this.Stream = null;
		}
	}
}
