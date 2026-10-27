using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000049 RID: 73
	public class ConditionListenerComponent_SetValue
	{
		// Token: 0x04000185 RID: 389
		public bool? Disabled;

		// Token: 0x04000186 RID: 390
		public bool? EdIsLocked;

		// Token: 0x04000187 RID: 391
		[Nullable(1)]
		public List<ICondtionListener> Listeners;
	}
}
