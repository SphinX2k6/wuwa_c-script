using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000850 RID: 2128
	public class PerformanceOptimizationComponent_SetValue
	{
		// Token: 0x04001F01 RID: 7937
		public bool? Disabled;

		// Token: 0x04001F02 RID: 7938
		public bool? EdIsLocked;

		// Token: 0x04001F03 RID: 7939
		[Nullable(1)]
		public List<IPerformanceOptimization> PerformanceOptimizationList;
	}
}
