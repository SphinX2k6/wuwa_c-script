using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000589 RID: 1417
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnDollGrabDelivery_SetValue
	{
		// Token: 0x040014CD RID: 5325
		public ENpcUiInteractType Type;

		// Token: 0x040014CE RID: 5326
		public IOnDollGrabDeliveryPerform OnFirstAchievementPerform;

		// Token: 0x040014CF RID: 5327
		public IOnDollGrabDeliveryPerform OnSubsequentAchievementPerform;

		// Token: 0x040014D0 RID: 5328
		public IOnDollGrabDeliveryPerform OnNeverAchievementPerform;

		// Token: 0x040014D1 RID: 5329
		public IOnDollGrabDeliveryPerform OnAlreadyAchievementPerform;
	}
}
