using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B2 RID: 18610
	public class ICompletedRefreshT
	{
		// Token: 0x1700816E RID: 33134
		// (get) Token: 0x0601B80B RID: 112651 RVA: 0x003E3F5A File Offset: 0x003E215A
		// (set) Token: 0x0601B80C RID: 112652 RVA: 0x003E3F62 File Offset: 0x003E2162
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x1700816F RID: 33135
		// (get) Token: 0x0601B80D RID: 112653 RVA: 0x003E3F6B File Offset: 0x003E216B
		// (set) Token: 0x0601B80E RID: 112654 RVA: 0x003E3F73 File Offset: 0x003E2173
		public int MinRefreshCd { get; set; }

		// Token: 0x17008170 RID: 33136
		// (get) Token: 0x0601B80F RID: 112655 RVA: 0x003E3F7C File Offset: 0x003E217C
		// (set) Token: 0x0601B810 RID: 112656 RVA: 0x003E3F84 File Offset: 0x003E2184
		public int MaxRefreshCd { get; set; }

		// Token: 0x0601B811 RID: 112657 RVA: 0x003E3F8D File Offset: 0x003E218D
		public ICompletedRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.MinRefreshCd = 0;
			this.MaxRefreshCd = 0;
		}
	}
}
