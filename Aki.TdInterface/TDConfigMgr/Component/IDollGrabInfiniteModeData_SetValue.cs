using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000307 RID: 775
	public class IDollGrabInfiniteModeData_SetValue
	{
		// Token: 0x04000CFD RID: 3325
		public List<IDollGrabStandbyPoolItem> StandbyItemPool;

		// Token: 0x04000CFE RID: 3326
		public string RefreshIntervalCurve;

		// Token: 0x04000CFF RID: 3327
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDollGrabInfiniteStageConfig> StageConfigs;

		// Token: 0x04000D00 RID: 3328
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDollGrabInfiniteScoreReward> ScoreRewards;

		// Token: 0x04000D01 RID: 3329
		[Nullable(2)]
		public IDollGrabInfiniteScoreReward ScoreReward;

		// Token: 0x04000D02 RID: 3330
		public int? UnlockConditionGroupId;
	}
}
