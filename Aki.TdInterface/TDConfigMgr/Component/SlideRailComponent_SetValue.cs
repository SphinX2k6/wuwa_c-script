using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000941 RID: 2369
	public class SlideRailComponent_SetValue
	{
		// Token: 0x04002279 RID: 8825
		public bool? Disabled;

		// Token: 0x0400227A RID: 8826
		public bool? EdIsLocked;

		// Token: 0x0400227B RID: 8827
		public int? SlideSpeed;

		// Token: 0x0400227C RID: 8828
		public int? UpSpeed;

		// Token: 0x0400227D RID: 8829
		public int? DownSpeed;

		// Token: 0x0400227E RID: 8830
		public int RailSplineEntityId;

		// Token: 0x0400227F RID: 8831
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IExchangeSlideRailConfig> ExchangeRailConfigs;
	}
}
