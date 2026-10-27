using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089E RID: 2206
	public class SlideRailComponent_SetValue
	{
		// Token: 0x04002067 RID: 8295
		public bool? Disabled;

		// Token: 0x04002068 RID: 8296
		public bool? EdIsLocked;

		// Token: 0x04002069 RID: 8297
		public int? SlideSpeed;

		// Token: 0x0400206A RID: 8298
		public int? UpSpeed;

		// Token: 0x0400206B RID: 8299
		public int? DownSpeed;

		// Token: 0x0400206C RID: 8300
		public int RailSplineEntityId;

		// Token: 0x0400206D RID: 8301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IExchangeSlideRailConfig> ExchangeRailConfigs;
	}
}
