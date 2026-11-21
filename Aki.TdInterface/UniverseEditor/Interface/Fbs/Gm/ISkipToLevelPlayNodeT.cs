using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B0B RID: 19211
	public class ISkipToLevelPlayNodeT
	{
		// Token: 0x170086AF RID: 34479
		// (get) Token: 0x0601CF5C RID: 118620 RVA: 0x00412BF0 File Offset: 0x00410DF0
		// (set) Token: 0x0601CF5D RID: 118621 RVA: 0x00412BF8 File Offset: 0x00410DF8
		public EGmCommand Type { get; set; }

		// Token: 0x170086B0 RID: 34480
		// (get) Token: 0x0601CF5E RID: 118622 RVA: 0x00412C01 File Offset: 0x00410E01
		// (set) Token: 0x0601CF5F RID: 118623 RVA: 0x00412C09 File Offset: 0x00410E09
		public int LevelPlayId { get; set; }

		// Token: 0x170086B1 RID: 34481
		// (get) Token: 0x0601CF60 RID: 118624 RVA: 0x00412C12 File Offset: 0x00410E12
		// (set) Token: 0x0601CF61 RID: 118625 RVA: 0x00412C1A File Offset: 0x00410E1A
		public int ChildQuestId { get; set; }

		// Token: 0x170086B2 RID: 34482
		// (get) Token: 0x0601CF62 RID: 118626 RVA: 0x00412C23 File Offset: 0x00410E23
		// (set) Token: 0x0601CF63 RID: 118627 RVA: 0x00412C2B File Offset: 0x00410E2B
		public bool IsTeleport { get; set; }

		// Token: 0x0601CF64 RID: 118628 RVA: 0x00412C34 File Offset: 0x00410E34
		public ISkipToLevelPlayNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.ChildQuestId = 0;
			this.IsTeleport = false;
		}
	}
}
