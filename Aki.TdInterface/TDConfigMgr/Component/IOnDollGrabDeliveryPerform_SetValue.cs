using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000612 RID: 1554
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnDollGrabDeliveryPerform_SetValue
	{
		// Token: 0x04001737 RID: 5943
		public string EventMontage;

		// Token: 0x04001738 RID: 5944
		public string StandByMontage;

		// Token: 0x04001739 RID: 5945
		public PlayFlow Flow;

		// Token: 0x0400173A RID: 5946
		public float? PerformDuration;
	}
}
