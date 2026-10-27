using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000055 RID: 85
	public class DollGrabShowcaseComponent_SetValue
	{
		// Token: 0x040001D5 RID: 469
		public bool? Disabled;

		// Token: 0x040001D6 RID: 470
		public bool? EdIsLocked;

		// Token: 0x040001D7 RID: 471
		public EDollGrabShowcaseBelongType BelongType;

		// Token: 0x040001D8 RID: 472
		public int? BindInfiniteModeDollGrabEntityId;

		// Token: 0x040001D9 RID: 473
		[Nullable(2)]
		public IDollGrabShowcaseDollCameraConfig CameraConfig;

		// Token: 0x040001DA RID: 474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IShowcaseDeliveryReward> DeliveryRewards;
	}
}
