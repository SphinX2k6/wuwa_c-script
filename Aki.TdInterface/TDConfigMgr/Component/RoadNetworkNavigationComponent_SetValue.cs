using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091D RID: 2333
	public class RoadNetworkNavigationComponent_SetValue
	{
		// Token: 0x040021CE RID: 8654
		public bool? Disabled;

		// Token: 0x040021CF RID: 8655
		public bool? EdIsLocked;

		// Token: 0x040021D0 RID: 8656
		public bool? KeepSelf;

		// Token: 0x040021D1 RID: 8657
		public ITrafficNavigationConfig BasicConfig;

		// Token: 0x040021D2 RID: 8658
		public IObstacleDetectionConfig ObstacleConfig;
	}
}
