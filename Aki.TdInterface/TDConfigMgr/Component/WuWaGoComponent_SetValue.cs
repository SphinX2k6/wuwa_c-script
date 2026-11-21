using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000990 RID: 2448
	public class WuWaGoComponent_SetValue
	{
		// Token: 0x040023FF RID: 9215
		public bool? Disabled;

		// Token: 0x04002400 RID: 9216
		public bool? EdIsLocked;

		// Token: 0x04002401 RID: 9217
		public IWuWaGoEntityBase WuWaGoEntity;

		// Token: 0x04002402 RID: 9218
		[Nullable(2)]
		public List<int> OpenAddClientTags;
	}
}
