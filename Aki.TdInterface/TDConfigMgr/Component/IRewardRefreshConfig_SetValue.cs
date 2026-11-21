using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072A RID: 1834
	public class IRewardRefreshConfig_SetValue
	{
		// Token: 0x04001AB1 RID: 6833
		[Nullable(2)]
		public IRefreshConditionBase RefreshCondition;

		// Token: 0x04001AB2 RID: 6834
		public IRefreshRule RefreshType;

		// Token: 0x04001AB3 RID: 6835
		public int? MaxCount;
	}
}
