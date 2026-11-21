using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091B RID: 2331
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardComponent_SetValue
	{
		// Token: 0x040021C1 RID: 8641
		public bool? Disabled;

		// Token: 0x040021C2 RID: 8642
		public bool? EdIsLocked;

		// Token: 0x040021C3 RID: 8643
		public int RewardId;

		// Token: 0x040021C4 RID: 8644
		public ERewardType RewardType;

		// Token: 0x040021C5 RID: 8645
		public EDropEvent? DropOnEvent;

		// Token: 0x040021C6 RID: 8646
		public IRewardRefreshConfig RefreshConfig;

		// Token: 0x040021C7 RID: 8647
		public List<int> RewardIdList;
	}
}
