using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000595 RID: 1429
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSoundBox35_SetValue
	{
		// Token: 0x0400153D RID: 5437
		public ENpcUiInteractType Type;

		// Token: 0x0400153E RID: 5438
		public string EnterMontage;

		// Token: 0x0400153F RID: 5439
		public string StandByMontage;

		// Token: 0x04001540 RID: 5440
		public string ShopSuccessMontage;

		// Token: 0x04001541 RID: 5441
		public PlayFlow EnterFlow;

		// Token: 0x04001542 RID: 5442
		public PlayFlow ShopSuccessFlow;

		// Token: 0x04001543 RID: 5443
		public PlayFlow ShopFailedFlow;

		// Token: 0x04001544 RID: 5444
		[Nullable(2)]
		public string UpgradeSequence;

		// Token: 0x04001545 RID: 5445
		[Nullable(2)]
		public PlayFlow UpgradeFlow;

		// Token: 0x04001546 RID: 5446
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x04001547 RID: 5447
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
