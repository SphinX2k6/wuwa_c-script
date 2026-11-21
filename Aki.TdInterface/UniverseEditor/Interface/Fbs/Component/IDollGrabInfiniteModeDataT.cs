using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FC RID: 22012
	public class IDollGrabInfiniteModeDataT
	{
		// Token: 0x17009DC8 RID: 40392
		// (get) Token: 0x06023153 RID: 143699 RVA: 0x004D4690 File Offset: 0x004D2890
		// (set) Token: 0x06023154 RID: 143700 RVA: 0x004D4698 File Offset: 0x004D2898
		public List<IDollGrabStandbyPoolItemT> StandbyItemPool { get; set; }

		// Token: 0x17009DC9 RID: 40393
		// (get) Token: 0x06023155 RID: 143701 RVA: 0x004D46A1 File Offset: 0x004D28A1
		// (set) Token: 0x06023156 RID: 143702 RVA: 0x004D46A9 File Offset: 0x004D28A9
		public string RefreshIntervalCurve { get; set; }

		// Token: 0x17009DCA RID: 40394
		// (get) Token: 0x06023157 RID: 143703 RVA: 0x004D46B2 File Offset: 0x004D28B2
		// (set) Token: 0x06023158 RID: 143704 RVA: 0x004D46BA File Offset: 0x004D28BA
		public List<IDollGrabInfiniteStageConfigT> StageConfigs { get; set; }

		// Token: 0x17009DCB RID: 40395
		// (get) Token: 0x06023159 RID: 143705 RVA: 0x004D46C3 File Offset: 0x004D28C3
		// (set) Token: 0x0602315A RID: 143706 RVA: 0x004D46CB File Offset: 0x004D28CB
		public List<IDollGrabInfiniteScoreRewardT> ScoreRewards { get; set; }

		// Token: 0x17009DCC RID: 40396
		// (get) Token: 0x0602315B RID: 143707 RVA: 0x004D46D4 File Offset: 0x004D28D4
		// (set) Token: 0x0602315C RID: 143708 RVA: 0x004D46DC File Offset: 0x004D28DC
		public IDollGrabInfiniteScoreRewardT ScoreReward { get; set; }

		// Token: 0x17009DCD RID: 40397
		// (get) Token: 0x0602315D RID: 143709 RVA: 0x004D46E5 File Offset: 0x004D28E5
		// (set) Token: 0x0602315E RID: 143710 RVA: 0x004D46ED File Offset: 0x004D28ED
		public int UnlockConditionGroupId { get; set; }

		// Token: 0x17009DCE RID: 40398
		// (get) Token: 0x0602315F RID: 143711 RVA: 0x004D46F6 File Offset: 0x004D28F6
		// (set) Token: 0x06023160 RID: 143712 RVA: 0x004D46FE File Offset: 0x004D28FE
		public byte NullMask { get; set; }

		// Token: 0x06023161 RID: 143713 RVA: 0x004D4707 File Offset: 0x004D2907
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
