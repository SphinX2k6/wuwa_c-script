using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000844 RID: 2116
	public class NearbyTrackingComponent_SetValue
	{
		// Token: 0x04001EA1 RID: 7841
		public bool? Disabled;

		// Token: 0x04001EA2 RID: 7842
		public bool? EdIsLocked;

		// Token: 0x04001EA3 RID: 7843
		public bool IsEnable;

		// Token: 0x04001EA4 RID: 7844
		public bool? IsEnableWhileUnlock;

		// Token: 0x04001EA5 RID: 7845
		public bool? IsEnbaleWhileHoming;

		// Token: 0x04001EA6 RID: 7846
		[Nullable(1)]
		public INearbyTracking TrackingType;
	}
}
