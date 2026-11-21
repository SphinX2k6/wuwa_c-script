using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000955 RID: 2389
	public class SwitcherComponent_SetValue
	{
		// Token: 0x040022CB RID: 8907
		public bool? Disabled;

		// Token: 0x040022CC RID: 8908
		public string Content;

		// Token: 0x040022CD RID: 8909
		public string Icon;

		// Token: 0x040022CE RID: 8910
		public bool? EdIsLocked;

		// Token: 0x040022CF RID: 8911
		public List<ActionInfo> OnActions;

		// Token: 0x040022D0 RID: 8912
		public List<ActionInfo> OffActions;
	}
}
