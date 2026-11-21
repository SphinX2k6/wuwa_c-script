using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FC RID: 1532
	public class INpcUiInteractOnSoundBox3_SetValue
	{
		// Token: 0x04001694 RID: 5780
		public ENpcUiInteractType Type;

		// Token: 0x04001695 RID: 5781
		public string EnterMontage;

		// Token: 0x04001696 RID: 5782
		public string StandByMontage;

		// Token: 0x04001697 RID: 5783
		public string ShopSuccessMontage;

		// Token: 0x04001698 RID: 5784
		public PlayFlow EnterFlow;

		// Token: 0x04001699 RID: 5785
		public PlayFlow ShopSuccessFlow;

		// Token: 0x0400169A RID: 5786
		public PlayFlow ShopFailedFlow;

		// Token: 0x0400169B RID: 5787
		[Nullable(2)]
		public string UpgradeSequence;

		// Token: 0x0400169C RID: 5788
		[Nullable(2)]
		public PlayFlow UpgradeFlow;

		// Token: 0x0400169D RID: 5789
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x0400169E RID: 5790
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
