using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005097 RID: 20631
	public class IDollGrabInfiniteModeDataT
	{
		// Token: 0x170095DB RID: 38363
		// (get) Token: 0x060211FF RID: 135679 RVA: 0x0049A704 File Offset: 0x00498904
		// (set) Token: 0x06021200 RID: 135680 RVA: 0x0049A70C File Offset: 0x0049890C
		public List<IDollGrabStandbyPoolItemT> StandbyItemPool { get; set; }

		// Token: 0x170095DC RID: 38364
		// (get) Token: 0x06021201 RID: 135681 RVA: 0x0049A715 File Offset: 0x00498915
		// (set) Token: 0x06021202 RID: 135682 RVA: 0x0049A71D File Offset: 0x0049891D
		public string RefreshIntervalCurve { get; set; }

		// Token: 0x170095DD RID: 38365
		// (get) Token: 0x06021203 RID: 135683 RVA: 0x0049A726 File Offset: 0x00498926
		// (set) Token: 0x06021204 RID: 135684 RVA: 0x0049A72E File Offset: 0x0049892E
		public List<IDollGrabInfiniteStageConfigT> StageConfigs { get; set; }

		// Token: 0x170095DE RID: 38366
		// (get) Token: 0x06021205 RID: 135685 RVA: 0x0049A737 File Offset: 0x00498937
		// (set) Token: 0x06021206 RID: 135686 RVA: 0x0049A73F File Offset: 0x0049893F
		public List<IDollGrabInfiniteScoreRewardT> ScoreRewards { get; set; }

		// Token: 0x170095DF RID: 38367
		// (get) Token: 0x06021207 RID: 135687 RVA: 0x0049A748 File Offset: 0x00498948
		// (set) Token: 0x06021208 RID: 135688 RVA: 0x0049A750 File Offset: 0x00498950
		public IDollGrabInfiniteScoreRewardT ScoreReward { get; set; }

		// Token: 0x170095E0 RID: 38368
		// (get) Token: 0x06021209 RID: 135689 RVA: 0x0049A759 File Offset: 0x00498959
		// (set) Token: 0x0602120A RID: 135690 RVA: 0x0049A761 File Offset: 0x00498961
		public int UnlockConditionGroupId { get; set; }

		// Token: 0x170095E1 RID: 38369
		// (get) Token: 0x0602120B RID: 135691 RVA: 0x0049A76A File Offset: 0x0049896A
		// (set) Token: 0x0602120C RID: 135692 RVA: 0x0049A772 File Offset: 0x00498972
		public byte NullMask { get; set; }

		// Token: 0x0602120D RID: 135693 RVA: 0x0049A77B File Offset: 0x0049897B
		public IDollGrabInfiniteModeDataT()
		{
			this.StandbyItemPool = null;
			this.RefreshIntervalCurve = null;
			this.StageConfigs = null;
			this.ScoreRewards = null;
			this.ScoreReward = null;
			this.UnlockConditionGroupId = 0;
			this.NullMask = 0;
		}
	}
}
