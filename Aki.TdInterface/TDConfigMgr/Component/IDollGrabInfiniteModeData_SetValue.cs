using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C0 RID: 704
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabInfiniteModeData_SetValue
	{
		// Token: 0x04000C13 RID: 3091
		public List<IDollGrabStandbyPoolItem> StandbyItemPool;

		// Token: 0x04000C14 RID: 3092
		public string RefreshIntervalCurve;

		// Token: 0x04000C15 RID: 3093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDollGrabInfiniteStageConfig> StageConfigs;

		// Token: 0x04000C16 RID: 3094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDollGrabInfiniteScoreReward> ScoreRewards;

		// Token: 0x04000C17 RID: 3095
		[Nullable(2)]
		public IDollGrabInfiniteScoreReward ScoreReward;

		// Token: 0x04000C18 RID: 3096
		public int? UnlockConditionGroupId;
	}
}
