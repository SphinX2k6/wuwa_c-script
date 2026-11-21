using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA1 RID: 19617
	public class ICommitLogT
	{
		// Token: 0x17008AF8 RID: 35576
		// (get) Token: 0x0601E14E RID: 123214 RVA: 0x004370FE File Offset: 0x004352FE
		// (set) Token: 0x0601E14F RID: 123215 RVA: 0x00437106 File Offset: 0x00435306
		public string Date { get; set; }

		// Token: 0x17008AF9 RID: 35577
		// (get) Token: 0x0601E150 RID: 123216 RVA: 0x0043710F File Offset: 0x0043530F
		// (set) Token: 0x0601E151 RID: 123217 RVA: 0x00437117 File Offset: 0x00435317
		public string Log { get; set; }

		// Token: 0x0601E152 RID: 123218 RVA: 0x00437120 File Offset: 0x00435320
		public ICommitLogT()
		{
			this.Date = null;
			this.Log = null;
		}
	}
}
