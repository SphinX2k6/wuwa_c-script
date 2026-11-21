using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B2 RID: 1458
	public class InhaledItemComponent_SetValue
	{
		// Token: 0x04001552 RID: 5458
		public bool? Disabled;

		// Token: 0x04001553 RID: 5459
		public bool? EdIsLocked;

		// Token: 0x04001554 RID: 5460
		public int InhaledStrength;

		// Token: 0x04001555 RID: 5461
		public int? InhaledInterruptionRecoveryTime;

		// Token: 0x04001556 RID: 5462
		public IInhaledPerformance InhaledPerformance;

		// Token: 0x04001557 RID: 5463
		public IInhaledPerResultType InhaledPerResult;
	}
}
