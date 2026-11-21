using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E9 RID: 8425
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpringArmSoftZoneConfig_SetValue
	{
		// Token: 0x04006A17 RID: 27159
		public ISingleAxisSpringArmSoftZoneConfig LeftRightConfig;

		// Token: 0x04006A18 RID: 27160
		public ISingleAxisSpringArmSoftZoneConfig ForwardBackConfig;

		// Token: 0x04006A19 RID: 27161
		public ISingleAxisSpringArmSoftZoneConfig UpDownConfig;
	}
}
