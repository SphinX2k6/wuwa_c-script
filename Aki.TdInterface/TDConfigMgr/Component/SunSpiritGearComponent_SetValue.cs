using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AE RID: 2222
	public class SunSpiritGearComponent_SetValue
	{
		// Token: 0x040020A9 RID: 8361
		public bool? Disabled;

		// Token: 0x040020AA RID: 8362
		public bool? EdIsLocked;

		// Token: 0x040020AB RID: 8363
		[Nullable(1)]
		public ISunSpiritGearPerformConfig PerformConfig;
	}
}
