using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FA RID: 1530
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShopNew_SetValue
	{
		// Token: 0x0400167E RID: 5758
		public ENpcUiInteractType Type;

		// Token: 0x0400167F RID: 5759
		public IMontageConfig EnterMontage;

		// Token: 0x04001680 RID: 5760
		public IMontageConfig StandByMontage;

		// Token: 0x04001681 RID: 5761
		public IMontageConfig ShopSuccessMontage;

		// Token: 0x04001682 RID: 5762
		public PlayFlow EnterFlow;

		// Token: 0x04001683 RID: 5763
		public PlayFlow ShopSuccessFlow;

		// Token: 0x04001684 RID: 5764
		public PlayFlow ShopFailedFlow;

		// Token: 0x04001685 RID: 5765
		public PlayFlow WorkingFlow;

		// Token: 0x04001686 RID: 5766
		public IMontageConfig ExitMontage;

		// Token: 0x04001687 RID: 5767
		public PlayFlow ExitFlow;
	}
}
