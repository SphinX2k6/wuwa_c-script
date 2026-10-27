using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006FB RID: 1787
	public class ISpeedEffectConfig_SetValue
	{
		// Token: 0x04001A16 RID: 6678
		public float MinVehicleSpeed;

		// Token: 0x04001A17 RID: 6679
		public float MaxVehicleSpeed;

		// Token: 0x04001A18 RID: 6680
		[Nullable(1)]
		public List<long> GameplayCueIds;
	}
}
