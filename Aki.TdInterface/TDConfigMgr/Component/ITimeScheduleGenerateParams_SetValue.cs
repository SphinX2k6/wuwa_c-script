using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078C RID: 1932
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleGenerateParams_SetValue
	{
		// Token: 0x04001C13 RID: 7187
		public ITimeScheduleGameDailyRefresh RefreshType;

		// Token: 0x04001C14 RID: 7188
		public int MaxCount;

		// Token: 0x04001C15 RID: 7189
		public int MinCount;

		// Token: 0x04001C16 RID: 7190
		public ITimeScheduleRandomSchedulePositionDistribution DistributionType;
	}
}
