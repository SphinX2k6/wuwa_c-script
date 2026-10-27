using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000597 RID: 1431
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSunSpirit_SetValue
	{
		// Token: 0x04001554 RID: 5460
		public ENpcUiInteractType Type;

		// Token: 0x04001555 RID: 5461
		public string EnterMontage;

		// Token: 0x04001556 RID: 5462
		public string StandByMontage;

		// Token: 0x04001557 RID: 5463
		public string ShopSuccessMontage;

		// Token: 0x04001558 RID: 5464
		public PlayFlow EnterFlow;

		// Token: 0x04001559 RID: 5465
		public PlayFlow ShopSuccessFlow;

		// Token: 0x0400155A RID: 5466
		public PlayFlow ShopFailedFlow;

		// Token: 0x0400155B RID: 5467
		[Nullable(2)]
		public string UpgradeSequence;

		// Token: 0x0400155C RID: 5468
		[Nullable(2)]
		public PlayFlow UpgradeFlow;

		// Token: 0x0400155D RID: 5469
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x0400155E RID: 5470
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
