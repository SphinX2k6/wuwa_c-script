using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000226 RID: 550
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceed_SetValue
	{
		// Token: 0x040009D5 RID: 2517
		public bool? IsSilent;

		// Token: 0x040009D6 RID: 2518
		public bool? IsDestroy;

		// Token: 0x040009D7 RID: 2519
		public bool? SyncAdsorbatePerformance;

		// Token: 0x040009D8 RID: 2520
		public string ChangeSelfState;

		// Token: 0x040009D9 RID: 2521
		public IEntityState ChangeItemState;

		// Token: 0x040009DA RID: 2522
		public int? DelayDischarge;

		// Token: 0x040009DB RID: 2523
		public IEntityState ChangeItemStateAfterDischarged;

		// Token: 0x040009DC RID: 2524
		public string ChangeSelfStateAfterDischarged;

		// Token: 0x040009DD RID: 2525
		public IItemChangeAdsorbateState ChangeAdsorbateState;

		// Token: 0x040009DE RID: 2526
		public string DischargeSequence;
	}
}
