using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B5D RID: 19293
	public class ICheckTetrisEndlessScoreT
	{
		// Token: 0x17008BFC RID: 35836
		// (get) Token: 0x0601E63D RID: 124477 RVA: 0x00441D00 File Offset: 0x0043FF00
		// (set) Token: 0x0601E63E RID: 124478 RVA: 0x00441D08 File Offset: 0x0043FF08
		public ECondition Type { get; set; }

		// Token: 0x17008BFD RID: 35837
		// (get) Token: 0x0601E63F RID: 124479 RVA: 0x00441D11 File Offset: 0x0043FF11
		// (set) Token: 0x0601E640 RID: 124480 RVA: 0x00441D19 File Offset: 0x0043FF19
		public int DungeonId { get; set; }

		// Token: 0x17008BFE RID: 35838
		// (get) Token: 0x0601E641 RID: 124481 RVA: 0x00441D22 File Offset: 0x0043FF22
		// (set) Token: 0x0601E642 RID: 124482 RVA: 0x00441D2A File Offset: 0x0043FF2A
		public ECompare Compare { get; set; }

		// Token: 0x17008BFF RID: 35839
		// (get) Token: 0x0601E643 RID: 124483 RVA: 0x00441D33 File Offset: 0x0043FF33
		// (set) Token: 0x0601E644 RID: 124484 RVA: 0x00441D3B File Offset: 0x0043FF3B
		public int TargetScore { get; set; }

		// Token: 0x0601E645 RID: 124485 RVA: 0x00441D44 File Offset: 0x0043FF44
		public ICheckTetrisEndlessScoreT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.Compare = ECompare.Eq;
			this.TargetScore = 0;
		}
	}
}
