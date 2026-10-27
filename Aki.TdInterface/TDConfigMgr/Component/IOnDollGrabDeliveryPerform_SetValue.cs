using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A9 RID: 1449
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnDollGrabDeliveryPerform_SetValue
	{
		// Token: 0x040015C9 RID: 5577
		public string EventMontage;

		// Token: 0x040015CA RID: 5578
		public string StandByMontage;

		// Token: 0x040015CB RID: 5579
		public PlayFlow Flow;

		// Token: 0x040015CC RID: 5580
		public float? PerformDuration;
	}
}
