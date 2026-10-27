using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000689 RID: 1673
	public class IRewardRefreshConfig_SetValue
	{
		// Token: 0x040018B4 RID: 6324
		[Nullable(2)]
		public IRefreshConditionBase RefreshCondition;

		// Token: 0x040018B5 RID: 6325
		[Nullable(1)]
		public IRefreshRule RefreshType;

		// Token: 0x040018B6 RID: 6326
		public int? MaxCount;
	}
}
