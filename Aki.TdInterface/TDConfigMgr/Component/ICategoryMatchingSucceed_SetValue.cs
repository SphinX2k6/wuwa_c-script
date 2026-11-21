using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024D RID: 589
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceed_SetValue
	{
		// Token: 0x04000A5F RID: 2655
		public bool? IsSilent;

		// Token: 0x04000A60 RID: 2656
		public bool? IsDestroy;

		// Token: 0x04000A61 RID: 2657
		public bool? SyncAdsorbatePerformance;

		// Token: 0x04000A62 RID: 2658
		public string ChangeSelfState;

		// Token: 0x04000A63 RID: 2659
		public IEntityState ChangeItemState;

		// Token: 0x04000A64 RID: 2660
		public int? DelayDischarge;

		// Token: 0x04000A65 RID: 2661
		public IEntityState ChangeItemStateAfterDischarged;

		// Token: 0x04000A66 RID: 2662
		public string ChangeSelfStateAfterDischarged;

		// Token: 0x04000A67 RID: 2663
		public IItemChangeAdsorbateState ChangeAdsorbateState;

		// Token: 0x04000A68 RID: 2664
		public string DischargeSequence;
	}
}
