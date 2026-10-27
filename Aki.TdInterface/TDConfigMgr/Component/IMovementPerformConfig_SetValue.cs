using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000537 RID: 1335
	public class IMovementPerformConfig_SetValue
	{
		// Token: 0x040013AB RID: 5035
		[Nullable(1)]
		public List<IVehicleMontagePlayConfig> VehicleMontagePlayConfigs;

		// Token: 0x040013AC RID: 5036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISpeedEffectConfig> PlayerSpeedEffectConfigs;
	}
}
