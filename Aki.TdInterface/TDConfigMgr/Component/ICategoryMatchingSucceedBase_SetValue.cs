using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024F RID: 591
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceedBase_SetValue
	{
		// Token: 0x04000A6F RID: 2671
		public bool? IsSilent;

		// Token: 0x04000A70 RID: 2672
		public bool? IsDestroy;

		// Token: 0x04000A71 RID: 2673
		public bool? SyncAdsorbatePerformance;

		// Token: 0x04000A72 RID: 2674
		public string ChangeSelfState;

		// Token: 0x04000A73 RID: 2675
		public IEntityState ChangeItemState;

		// Token: 0x04000A74 RID: 2676
		public int? DelayDischarge;

		// Token: 0x04000A75 RID: 2677
		public IEntityState ChangeItemStateAfterDischarged;

		// Token: 0x04000A76 RID: 2678
		public string ChangeSelfStateAfterDischarged;
	}
}
