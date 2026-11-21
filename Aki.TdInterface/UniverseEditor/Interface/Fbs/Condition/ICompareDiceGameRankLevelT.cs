using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200507A RID: 20602
	public class ICompareDiceGameRankLevelT
	{
		// Token: 0x17009376 RID: 37750
		// (get) Token: 0x06020384 RID: 131972 RVA: 0x00477510 File Offset: 0x00475710
		// (set) Token: 0x06020385 RID: 131973 RVA: 0x00477518 File Offset: 0x00475718
		public ECondition Type { get; set; }

		// Token: 0x17009377 RID: 37751
		// (get) Token: 0x06020386 RID: 131974 RVA: 0x00477521 File Offset: 0x00475721
		// (set) Token: 0x06020387 RID: 131975 RVA: 0x00477529 File Offset: 0x00475729
		public int ActivityId { get; set; }

		// Token: 0x17009378 RID: 37752
		// (get) Token: 0x06020388 RID: 131976 RVA: 0x00477532 File Offset: 0x00475732
		// (set) Token: 0x06020389 RID: 131977 RVA: 0x0047753A File Offset: 0x0047573A
		public ECompare Compare { get; set; }

		// Token: 0x17009379 RID: 37753
		// (get) Token: 0x0602038A RID: 131978 RVA: 0x00477543 File Offset: 0x00475743
		// (set) Token: 0x0602038B RID: 131979 RVA: 0x0047754B File Offset: 0x0047574B
		public int Rank { get; set; }

		// Token: 0x0602038C RID: 131980 RVA: 0x00477554 File Offset: 0x00475754
		public ICompareDiceGameRankLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.ActivityId = 0;
			this.Compare = ECompare.Eq;
			this.Rank = 0;
		}
	}
}
