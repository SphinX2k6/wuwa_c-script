using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B2 RID: 2226
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitcherComponent_SetValue
	{
		// Token: 0x040020B9 RID: 8377
		public bool? Disabled;

		// Token: 0x040020BA RID: 8378
		public string Content;

		// Token: 0x040020BB RID: 8379
		public string Icon;

		// Token: 0x040020BC RID: 8380
		public bool? EdIsLocked;

		// Token: 0x040020BD RID: 8381
		public List<ActionInfo> OnActions;

		// Token: 0x040020BE RID: 8382
		public List<ActionInfo> OffActions;
	}
}
