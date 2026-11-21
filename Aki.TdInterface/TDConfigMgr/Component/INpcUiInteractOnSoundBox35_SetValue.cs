using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FE RID: 1534
	public class INpcUiInteractOnSoundBox35_SetValue
	{
		// Token: 0x040016AB RID: 5803
		public ENpcUiInteractType Type;

		// Token: 0x040016AC RID: 5804
		public string EnterMontage;

		// Token: 0x040016AD RID: 5805
		public string StandByMontage;

		// Token: 0x040016AE RID: 5806
		public string ShopSuccessMontage;

		// Token: 0x040016AF RID: 5807
		public PlayFlow EnterFlow;

		// Token: 0x040016B0 RID: 5808
		public PlayFlow ShopSuccessFlow;

		// Token: 0x040016B1 RID: 5809
		public PlayFlow ShopFailedFlow;

		// Token: 0x040016B2 RID: 5810
		[Nullable(2)]
		public string UpgradeSequence;

		// Token: 0x040016B3 RID: 5811
		[Nullable(2)]
		public PlayFlow UpgradeFlow;

		// Token: 0x040016B4 RID: 5812
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x040016B5 RID: 5813
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
