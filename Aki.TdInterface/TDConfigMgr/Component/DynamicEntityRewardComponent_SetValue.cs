using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005D RID: 93
	public class DynamicEntityRewardComponent_SetValue
	{
		// Token: 0x040001F7 RID: 503
		public bool? Disabled;

		// Token: 0x040001F8 RID: 504
		public bool? EdIsLocked;

		// Token: 0x040001F9 RID: 505
		public IDynamicTrafficReward RewardType;

		// Token: 0x040001FA RID: 506
		[Nullable(2)]
		public List<EClaimDynamicEntityRewardType> ClaimTypes;

		// Token: 0x040001FB RID: 507
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> RewardActions;
	}
}
