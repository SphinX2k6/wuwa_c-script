using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087A RID: 2170
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadNetworkNavigationComponent_SetValue
	{
		// Token: 0x04001FBC RID: 8124
		public bool? Disabled;

		// Token: 0x04001FBD RID: 8125
		public bool? EdIsLocked;

		// Token: 0x04001FBE RID: 8126
		public bool? KeepSelf;

		// Token: 0x04001FBF RID: 8127
		public ITrafficNavigationConfig BasicConfig;

		// Token: 0x04001FC0 RID: 8128
		public IObstacleDetectionConfig ObstacleConfig;
	}
}
