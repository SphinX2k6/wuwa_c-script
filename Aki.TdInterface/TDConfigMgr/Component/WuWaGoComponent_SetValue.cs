using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EB RID: 2283
	public class WuWaGoComponent_SetValue
	{
		// Token: 0x040021E8 RID: 8680
		public bool? Disabled;

		// Token: 0x040021E9 RID: 8681
		public bool? EdIsLocked;

		// Token: 0x040021EA RID: 8682
		[Nullable(1)]
		public IWuWaGoEntityBase WuWaGoEntity;

		// Token: 0x040021EB RID: 8683
		[Nullable(2)]
		public List<int> OpenAddClientTags;
	}
}
