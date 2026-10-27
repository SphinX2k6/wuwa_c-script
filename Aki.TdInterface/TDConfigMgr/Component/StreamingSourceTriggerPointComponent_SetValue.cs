using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AA RID: 2218
	public class StreamingSourceTriggerPointComponent_SetValue
	{
		// Token: 0x0400209A RID: 8346
		public bool? Disabled;

		// Token: 0x0400209B RID: 8347
		public bool? EdIsLocked;

		// Token: 0x0400209C RID: 8348
		public int? Radius;

		// Token: 0x0400209D RID: 8349
		[Nullable(1)]
		public IStreamingSourceConfigBase StreamingSource;
	}
}
