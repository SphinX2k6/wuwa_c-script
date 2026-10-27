using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000264 RID: 612
	public class IConditionalStreamingSource_SetValue
	{
		// Token: 0x04000AD5 RID: 2773
		public EStreamingSourceMode Type;

		// Token: 0x04000AD6 RID: 2774
		[Nullable(1)]
		public List<IConditionalStreamingSourceConfig> StreamingSourceConfigs;
	}
}
