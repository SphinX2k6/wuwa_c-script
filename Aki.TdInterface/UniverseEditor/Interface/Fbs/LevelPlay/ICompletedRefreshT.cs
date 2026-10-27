using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200444A RID: 17482
	public class ICompletedRefreshT
	{
		// Token: 0x17007B2F RID: 31535
		// (get) Token: 0x0601A03A RID: 106554 RVA: 0x003B7D4E File Offset: 0x003B5F4E
		// (set) Token: 0x0601A03B RID: 106555 RVA: 0x003B7D56 File Offset: 0x003B5F56
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17007B30 RID: 31536
		// (get) Token: 0x0601A03C RID: 106556 RVA: 0x003B7D5F File Offset: 0x003B5F5F
		// (set) Token: 0x0601A03D RID: 106557 RVA: 0x003B7D67 File Offset: 0x003B5F67
		public int MinRefreshCd { get; set; }

		// Token: 0x17007B31 RID: 31537
		// (get) Token: 0x0601A03E RID: 106558 RVA: 0x003B7D70 File Offset: 0x003B5F70
		// (set) Token: 0x0601A03F RID: 106559 RVA: 0x003B7D78 File Offset: 0x003B5F78
		public int MaxRefreshCd { get; set; }

		// Token: 0x0601A040 RID: 106560 RVA: 0x003B7D81 File Offset: 0x003B5F81
		public ICompletedRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.MinRefreshCd = 0;
			this.MaxRefreshCd = 0;
		}
	}
}
