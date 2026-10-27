using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B4 RID: 8628
	public class SetEntityVisible_SetValue
	{
		// Token: 0x04007106 RID: 28934
		[Nullable(1)]
		public List<int> EntityIds;

		// Token: 0x04007107 RID: 28935
		public bool Visible;

		// Token: 0x04007108 RID: 28936
		public bool? PerformDestroy;
	}
}
