using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000055 RID: 85
	public class DollGrabShowcaseComponent_SetValue
	{
		// Token: 0x040001DA RID: 474
		public bool? Disabled;

		// Token: 0x040001DB RID: 475
		public bool? EdIsLocked;

		// Token: 0x040001DC RID: 476
		public EDollGrabShowcaseBelongType BelongType;

		// Token: 0x040001DD RID: 477
		public int? BindInfiniteModeDollGrabEntityId;

		// Token: 0x040001DE RID: 478
		[Nullable(2)]
		public IDollGrabShowcaseDollCameraConfig CameraConfig;

		// Token: 0x040001DF RID: 479
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IShowcaseDeliveryReward> DeliveryRewards;
	}
}
