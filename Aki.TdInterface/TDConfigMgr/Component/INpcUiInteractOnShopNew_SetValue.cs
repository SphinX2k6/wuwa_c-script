using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000591 RID: 1425
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShopNew_SetValue
	{
		// Token: 0x04001510 RID: 5392
		public ENpcUiInteractType Type;

		// Token: 0x04001511 RID: 5393
		public IMontageConfig EnterMontage;

		// Token: 0x04001512 RID: 5394
		public IMontageConfig StandByMontage;

		// Token: 0x04001513 RID: 5395
		public IMontageConfig ShopSuccessMontage;

		// Token: 0x04001514 RID: 5396
		public PlayFlow EnterFlow;

		// Token: 0x04001515 RID: 5397
		public PlayFlow ShopSuccessFlow;

		// Token: 0x04001516 RID: 5398
		public PlayFlow ShopFailedFlow;

		// Token: 0x04001517 RID: 5399
		public PlayFlow WorkingFlow;

		// Token: 0x04001518 RID: 5400
		public IMontageConfig ExitMontage;

		// Token: 0x04001519 RID: 5401
		public PlayFlow ExitFlow;
	}
}
