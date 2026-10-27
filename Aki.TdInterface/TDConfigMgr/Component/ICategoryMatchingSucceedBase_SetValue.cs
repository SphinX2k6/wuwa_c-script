using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000228 RID: 552
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceedBase_SetValue
	{
		// Token: 0x040009E5 RID: 2533
		public bool? IsSilent;

		// Token: 0x040009E6 RID: 2534
		public bool? IsDestroy;

		// Token: 0x040009E7 RID: 2535
		public bool? SyncAdsorbatePerformance;

		// Token: 0x040009E8 RID: 2536
		public string ChangeSelfState;

		// Token: 0x040009E9 RID: 2537
		public IEntityState ChangeItemState;

		// Token: 0x040009EA RID: 2538
		public int? DelayDischarge;

		// Token: 0x040009EB RID: 2539
		public IEntityState ChangeItemStateAfterDischarged;

		// Token: 0x040009EC RID: 2540
		public string ChangeSelfStateAfterDischarged;
	}
}
