using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000365 RID: 869
	public class IExtraAiAlert_SetValue
	{
		// Token: 0x04000E42 RID: 3650
		public int? MoveAlert;

		// Token: 0x04000E43 RID: 3651
		public int? StopAlert;

		// Token: 0x04000E44 RID: 3652
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IStateAlert> SelfStateAlert;
	}
}
