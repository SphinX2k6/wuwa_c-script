using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200016E RID: 366
	public class ExtraRangeComponent_SetValue
	{
		// Token: 0x040006F0 RID: 1776
		public bool? Disabled;

		// Token: 0x040006F1 RID: 1777
		public bool? EdIsLocked;

		// Token: 0x040006F2 RID: 1778
		[Nullable(1)]
		public List<ISunSpiritBlockExtraRange> ExtraRangeConfigs;
	}
}
