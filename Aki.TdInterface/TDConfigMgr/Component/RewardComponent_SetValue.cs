using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000878 RID: 2168
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardComponent_SetValue
	{
		// Token: 0x04001FAF RID: 8111
		public bool? Disabled;

		// Token: 0x04001FB0 RID: 8112
		public bool? EdIsLocked;

		// Token: 0x04001FB1 RID: 8113
		public int RewardId;

		// Token: 0x04001FB2 RID: 8114
		public ERewardType RewardType;

		// Token: 0x04001FB3 RID: 8115
		public EDropEvent? DropOnEvent;

		// Token: 0x04001FB4 RID: 8116
		public IRewardRefreshConfig RefreshConfig;

		// Token: 0x04001FB5 RID: 8117
		public List<int> RewardIdList;
	}
}
