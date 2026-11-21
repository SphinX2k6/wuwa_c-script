using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093F RID: 2367
	public class SlidePerformComponent_SetValue
	{
		// Token: 0x0400226D RID: 8813
		public bool? Disabled;

		// Token: 0x0400226E RID: 8814
		public int? SlideSpeed;

		// Token: 0x0400226F RID: 8815
		public int? UpSpeed;

		// Token: 0x04002270 RID: 8816
		public int? DownSpeed;

		// Token: 0x04002271 RID: 8817
		public int RailSplineEntityId;

		// Token: 0x04002272 RID: 8818
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IExchangeSlideRailConfig> ExchangeRailConfigs;

		// Token: 0x04002273 RID: 8819
		public bool? EdIsLocked;

		// Token: 0x04002274 RID: 8820
		public ISlopeSlidePerform SlidePerformConfig;
	}
}
