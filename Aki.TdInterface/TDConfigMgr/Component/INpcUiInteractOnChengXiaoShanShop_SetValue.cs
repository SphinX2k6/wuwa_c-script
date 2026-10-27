using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000587 RID: 1415
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnChengXiaoShanShop_SetValue
	{
		// Token: 0x040014B9 RID: 5305
		public ENpcUiInteractType Type;

		// Token: 0x040014BA RID: 5306
		public string EnterMontage;

		// Token: 0x040014BB RID: 5307
		public string StandByMontage;

		// Token: 0x040014BC RID: 5308
		public string ShopSuccessMontage;

		// Token: 0x040014BD RID: 5309
		public PlayFlow EnterFlow;

		// Token: 0x040014BE RID: 5310
		public PlayFlow ShopSuccessFlow;

		// Token: 0x040014BF RID: 5311
		public PlayFlow ShopFailedFlow;

		// Token: 0x040014C0 RID: 5312
		public string UpgradeSequence;

		// Token: 0x040014C1 RID: 5313
		public string FinishDeliverySequence;

		// Token: 0x040014C2 RID: 5314
		public bool? ShowNpcWhilePlayingSequence;
	}
}
