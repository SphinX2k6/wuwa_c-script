using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086C RID: 2156
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshGroupComponent_SetValue
	{
		// Token: 0x04001F7C RID: 8060
		public bool? Disabled;

		// Token: 0x04001F7D RID: 8061
		public bool? EdIsLocked;

		// Token: 0x04001F7E RID: 8062
		public List<int> EntityIds;

		// Token: 0x04001F7F RID: 8063
		public IRefreshContent RefreshContent;

		// Token: 0x04001F80 RID: 8064
		public IRefreshRule RefreshRule;

		// Token: 0x04001F81 RID: 8065
		[Nullable(2)]
		public IStateChangeConfig StateChangeConfig;
	}
}
