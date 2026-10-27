using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001963 RID: 6499
	public class IDaemonHack_SetValue
	{
		// Token: 0x040056E7 RID: 22247
		public ESimpleGameplayType Type;

		// Token: 0x040056E8 RID: 22248
		[Nullable(1)]
		public List<int> Ids;

		// Token: 0x040056E9 RID: 22249
		public bool? FinishOnClose;
	}
}
