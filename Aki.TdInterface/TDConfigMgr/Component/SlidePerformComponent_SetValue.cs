using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089C RID: 2204
	public class SlidePerformComponent_SetValue
	{
		// Token: 0x0400205B RID: 8283
		public bool? Disabled;

		// Token: 0x0400205C RID: 8284
		public int? SlideSpeed;

		// Token: 0x0400205D RID: 8285
		public int? UpSpeed;

		// Token: 0x0400205E RID: 8286
		public int? DownSpeed;

		// Token: 0x0400205F RID: 8287
		public int RailSplineEntityId;

		// Token: 0x04002060 RID: 8288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IExchangeSlideRailConfig> ExchangeRailConfigs;

		// Token: 0x04002061 RID: 8289
		public bool? EdIsLocked;

		// Token: 0x04002062 RID: 8290
		[Nullable(1)]
		public ISlopeSlidePerform SlidePerformConfig;
	}
}
