using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058F RID: 1423
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShop_SetValue
	{
		// Token: 0x040014FA RID: 5370
		public ENpcUiInteractType Type;

		// Token: 0x040014FB RID: 5371
		[Nullable(1)]
		public string EnterMontage;

		// Token: 0x040014FC RID: 5372
		[Nullable(1)]
		public string StandByMontage;

		// Token: 0x040014FD RID: 5373
		[Nullable(1)]
		public string ShopSuccessMontage;

		// Token: 0x040014FE RID: 5374
		public PlayFlow EnterFlow;

		// Token: 0x040014FF RID: 5375
		public PlayFlow ShopSuccessFlow;

		// Token: 0x04001500 RID: 5376
		public PlayFlow ShopFailedFlow;

		// Token: 0x04001501 RID: 5377
		public PlayFlow WorkingFlow;

		// Token: 0x04001502 RID: 5378
		public IMontageConfig ExitMontage;

		// Token: 0x04001503 RID: 5379
		public PlayFlow ExitFlow;
	}
}
