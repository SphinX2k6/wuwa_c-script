using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A17 RID: 18967
	public class ISingleOnlineRefreshT
	{
		// Token: 0x1700850C RID: 34060
		// (get) Token: 0x0601C762 RID: 116578 RVA: 0x00404E2A File Offset: 0x0040302A
		// (set) Token: 0x0601C763 RID: 116579 RVA: 0x00404E32 File Offset: 0x00403032
		public int CompletedRefreshTime { get; set; }

		// Token: 0x1700850D RID: 34061
		// (get) Token: 0x0601C764 RID: 116580 RVA: 0x00404E3B File Offset: 0x0040303B
		// (set) Token: 0x0601C765 RID: 116581 RVA: 0x00404E43 File Offset: 0x00403043
		public int AwardedRefreshTime { get; set; }

		// Token: 0x1700850E RID: 34062
		// (get) Token: 0x0601C766 RID: 116582 RVA: 0x00404E4C File Offset: 0x0040304C
		// (set) Token: 0x0601C767 RID: 116583 RVA: 0x00404E54 File Offset: 0x00403054
		public byte NullMask { get; set; }

		// Token: 0x0601C768 RID: 116584 RVA: 0x00404E5D File Offset: 0x0040305D
		public ISingleOnlineRefreshT()
		{
			this.CompletedRefreshTime = 0;
			this.AwardedRefreshTime = 0;
			this.NullMask = 0;
		}
	}
}
