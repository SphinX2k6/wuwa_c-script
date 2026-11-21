using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F8 RID: 1528
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnShop_SetValue
	{
		// Token: 0x04001668 RID: 5736
		public ENpcUiInteractType Type;

		// Token: 0x04001669 RID: 5737
		[Nullable(0)]
		public string EnterMontage;

		// Token: 0x0400166A RID: 5738
		[Nullable(0)]
		public string StandByMontage;

		// Token: 0x0400166B RID: 5739
		[Nullable(0)]
		public string ShopSuccessMontage;

		// Token: 0x0400166C RID: 5740
		public PlayFlow EnterFlow;

		// Token: 0x0400166D RID: 5741
		public PlayFlow ShopSuccessFlow;

		// Token: 0x0400166E RID: 5742
		public PlayFlow ShopFailedFlow;

		// Token: 0x0400166F RID: 5743
		public PlayFlow WorkingFlow;

		// Token: 0x04001670 RID: 5744
		public IMontageConfig ExitMontage;

		// Token: 0x04001671 RID: 5745
		public PlayFlow ExitFlow;
	}
}
