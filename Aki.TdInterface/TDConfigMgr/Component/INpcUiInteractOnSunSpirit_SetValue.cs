using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000600 RID: 1536
	public class INpcUiInteractOnSunSpirit_SetValue
	{
		// Token: 0x040016C2 RID: 5826
		public ENpcUiInteractType Type;

		// Token: 0x040016C3 RID: 5827
		public string EnterMontage;

		// Token: 0x040016C4 RID: 5828
		public string StandByMontage;

		// Token: 0x040016C5 RID: 5829
		public string ShopSuccessMontage;

		// Token: 0x040016C6 RID: 5830
		public PlayFlow EnterFlow;

		// Token: 0x040016C7 RID: 5831
		public PlayFlow ShopSuccessFlow;

		// Token: 0x040016C8 RID: 5832
		public PlayFlow ShopFailedFlow;

		// Token: 0x040016C9 RID: 5833
		[Nullable(2)]
		public string UpgradeSequence;

		// Token: 0x040016CA RID: 5834
		[Nullable(2)]
		public PlayFlow UpgradeFlow;

		// Token: 0x040016CB RID: 5835
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x040016CC RID: 5836
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
