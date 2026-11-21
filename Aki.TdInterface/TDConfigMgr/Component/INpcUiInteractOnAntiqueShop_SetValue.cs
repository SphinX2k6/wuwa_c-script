using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EE RID: 1518
	public class INpcUiInteractOnAntiqueShop_SetValue
	{
		// Token: 0x04001615 RID: 5653
		public ENpcUiInteractType Type;

		// Token: 0x04001616 RID: 5654
		public string EnterMontage;

		// Token: 0x04001617 RID: 5655
		public string StandByMontage;

		// Token: 0x04001618 RID: 5656
		public string ShopSuccessMontage;

		// Token: 0x04001619 RID: 5657
		public PlayFlow EnterFlow;

		// Token: 0x0400161A RID: 5658
		public PlayFlow ShopSuccessFlow;

		// Token: 0x0400161B RID: 5659
		public PlayFlow ShopFailedFlow;

		// Token: 0x0400161C RID: 5660
		public string UpgradeSequence;

		// Token: 0x0400161D RID: 5661
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x0400161E RID: 5662
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
