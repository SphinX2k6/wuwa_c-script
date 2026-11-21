using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F0 RID: 1520
	public class INpcUiInteractOnChengXiaoShanShop_SetValue
	{
		// Token: 0x04001627 RID: 5671
		public ENpcUiInteractType Type;

		// Token: 0x04001628 RID: 5672
		public string EnterMontage;

		// Token: 0x04001629 RID: 5673
		public string StandByMontage;

		// Token: 0x0400162A RID: 5674
		public string ShopSuccessMontage;

		// Token: 0x0400162B RID: 5675
		public PlayFlow EnterFlow;

		// Token: 0x0400162C RID: 5676
		public PlayFlow ShopSuccessFlow;

		// Token: 0x0400162D RID: 5677
		public PlayFlow ShopFailedFlow;

		// Token: 0x0400162E RID: 5678
		public string UpgradeSequence;

		// Token: 0x0400162F RID: 5679
		public string FinishDeliverySequence;

		// Token: 0x04001630 RID: 5680
		public bool? ShowNpcWhilePlayingSequence;
	}
}
