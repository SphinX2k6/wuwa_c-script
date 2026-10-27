using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054B RID: 1355
	[NullableContext(1)]
	[Nullable(0)]
	public class InhaledItemComponent_SetValue
	{
		// Token: 0x040013E8 RID: 5096
		public bool? Disabled;

		// Token: 0x040013E9 RID: 5097
		public bool? EdIsLocked;

		// Token: 0x040013EA RID: 5098
		public int InhaledStrength;

		// Token: 0x040013EB RID: 5099
		public int? InhaledInterruptionRecoveryTime;

		// Token: 0x040013EC RID: 5100
		public IInhaledPerformance InhaledPerformance;

		// Token: 0x040013ED RID: 5101
		public IInhaledPerResultType InhaledPerResult;
	}
}
