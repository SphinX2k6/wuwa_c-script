using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000342 RID: 834
	public class IExchangeSlideRailConfig_SetValue
	{
		// Token: 0x04000DD9 RID: 3545
		public int? MaxExchangeDistance;

		// Token: 0x04000DDA RID: 3546
		public int? MaxExchangeHigh;

		// Token: 0x04000DDB RID: 3547
		[Nullable(1)]
		public List<INextSlideRail> NextRails;
	}
}
