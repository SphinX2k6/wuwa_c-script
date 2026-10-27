using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000585 RID: 1413
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnAntiqueShop_SetValue
	{
		// Token: 0x040014A7 RID: 5287
		public ENpcUiInteractType Type;

		// Token: 0x040014A8 RID: 5288
		public string EnterMontage;

		// Token: 0x040014A9 RID: 5289
		public string StandByMontage;

		// Token: 0x040014AA RID: 5290
		public string ShopSuccessMontage;

		// Token: 0x040014AB RID: 5291
		public PlayFlow EnterFlow;

		// Token: 0x040014AC RID: 5292
		public PlayFlow ShopSuccessFlow;

		// Token: 0x040014AD RID: 5293
		public PlayFlow ShopFailedFlow;

		// Token: 0x040014AE RID: 5294
		public string UpgradeSequence;

		// Token: 0x040014AF RID: 5295
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x040014B0 RID: 5296
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
