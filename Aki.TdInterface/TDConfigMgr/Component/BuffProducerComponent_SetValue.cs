using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000037 RID: 55
	public class BuffProducerComponent_SetValue
	{
		// Token: 0x0400013E RID: 318
		public bool? Disabled;

		// Token: 0x0400013F RID: 319
		public bool? EdIsLocked;

		// Token: 0x04000140 RID: 320
		[Nullable(1)]
		public IAddBuffMode AddBuffMode;

		// Token: 0x04000141 RID: 321
		public long BuffId;
	}
}
