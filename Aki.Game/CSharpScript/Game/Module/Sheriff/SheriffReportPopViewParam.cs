using System;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BFB RID: 15355
	public class SheriffReportPopViewParam : ISheriffReportPopViewParam
	{
		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x060275AF RID: 161199 RVA: 0x00B07FCE File Offset: 0x00B061CE
		// (set) Token: 0x060275B0 RID: 161200 RVA: 0x00B07FD6 File Offset: 0x00B061D6
		public int CriminalId { get; set; }

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x060275B1 RID: 161201 RVA: 0x00B07FDF File Offset: 0x00B061DF
		// (set) Token: 0x060275B2 RID: 161202 RVA: 0x00B07FE7 File Offset: 0x00B061E7
		public bool BothPage { get; set; }
	}
}
