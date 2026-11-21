using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F2 RID: 1522
	public class INpcUiInteractOnDollGrabDelivery_SetValue
	{
		// Token: 0x0400163B RID: 5691
		public ENpcUiInteractType Type;

		// Token: 0x0400163C RID: 5692
		public IOnDollGrabDeliveryPerform OnFirstAchievementPerform;

		// Token: 0x0400163D RID: 5693
		public IOnDollGrabDeliveryPerform OnSubsequentAchievementPerform;

		// Token: 0x0400163E RID: 5694
		public IOnDollGrabDeliveryPerform OnNeverAchievementPerform;

		// Token: 0x0400163F RID: 5695
		public IOnDollGrabDeliveryPerform OnAlreadyAchievementPerform;
	}
}
