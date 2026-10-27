using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005D RID: 93
	public class DynamicEntityRewardComponent_SetValue
	{
		// Token: 0x040001F2 RID: 498
		public bool? Disabled;

		// Token: 0x040001F3 RID: 499
		public bool? EdIsLocked;

		// Token: 0x040001F4 RID: 500
		[Nullable(1)]
		public IDynamicTrafficReward RewardType;

		// Token: 0x040001F5 RID: 501
		[Nullable(2)]
		public List<EClaimDynamicEntityRewardType> ClaimTypes;

		// Token: 0x040001F6 RID: 502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> RewardActions;
	}
}
