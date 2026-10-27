using System;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C4A RID: 19530
	public class SheriffReportPopViewParam : ISheriffReportPopViewParam
	{
		// Token: 0x17007CC4 RID: 31940
		// (get) Token: 0x060327FC RID: 206844 RVA: 0x00BC33B6 File Offset: 0x00BC15B6
		// (set) Token: 0x060327FD RID: 206845 RVA: 0x00BC33BE File Offset: 0x00BC15BE
		public int CriminalId { get; set; }

		// Token: 0x17007CC5 RID: 31941
		// (get) Token: 0x060327FE RID: 206846 RVA: 0x00BC33C7 File Offset: 0x00BC15C7
		// (set) Token: 0x060327FF RID: 206847 RVA: 0x00BC33CF File Offset: 0x00BC15CF
		public bool BothPage { get; set; }
	}
}
