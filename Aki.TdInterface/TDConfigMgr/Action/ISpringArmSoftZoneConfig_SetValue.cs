using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB0 RID: 7856
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpringArmSoftZoneConfig_SetValue
	{
		// Token: 0x04006429 RID: 25641
		public ISingleAxisSpringArmSoftZoneConfig LeftRightConfig;

		// Token: 0x0400642A RID: 25642
		public ISingleAxisSpringArmSoftZoneConfig ForwardBackConfig;

		// Token: 0x0400642B RID: 25643
		public ISingleAxisSpringArmSoftZoneConfig UpDownConfig;
	}
}
