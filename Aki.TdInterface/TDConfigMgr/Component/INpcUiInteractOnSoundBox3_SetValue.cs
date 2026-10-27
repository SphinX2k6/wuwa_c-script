using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000593 RID: 1427
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnSoundBox3_SetValue
	{
		// Token: 0x04001526 RID: 5414
		public ENpcUiInteractType Type;

		// Token: 0x04001527 RID: 5415
		public string EnterMontage;

		// Token: 0x04001528 RID: 5416
		public string StandByMontage;

		// Token: 0x04001529 RID: 5417
		public string ShopSuccessMontage;

		// Token: 0x0400152A RID: 5418
		public PlayFlow EnterFlow;

		// Token: 0x0400152B RID: 5419
		public PlayFlow ShopSuccessFlow;

		// Token: 0x0400152C RID: 5420
		public PlayFlow ShopFailedFlow;

		// Token: 0x0400152D RID: 5421
		[Nullable(2)]
		public string UpgradeSequence;

		// Token: 0x0400152E RID: 5422
		[Nullable(2)]
		public PlayFlow UpgradeFlow;

		// Token: 0x0400152F RID: 5423
		[Nullable(2)]
		public IMontageConfig ExitMontage;

		// Token: 0x04001530 RID: 5424
		[Nullable(2)]
		public PlayFlow ExitFlow;
	}
}
