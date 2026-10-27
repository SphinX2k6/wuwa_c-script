using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DE RID: 478
	public class IAudioVehicleFeature_SetValue
	{
		// Token: 0x040008BE RID: 2238
		public EVehicleFeatureFlag Type;

		// Token: 0x040008BF RID: 2239
		[Nullable(1)]
		public IVehicleAudioConfig AudioConfigs;
	}
}
