using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090F RID: 2319
	public class RefreshGroupComponent_SetValue
	{
		// Token: 0x0400218E RID: 8590
		public bool? Disabled;

		// Token: 0x0400218F RID: 8591
		public bool? EdIsLocked;

		// Token: 0x04002190 RID: 8592
		public List<int> EntityIds;

		// Token: 0x04002191 RID: 8593
		public IRefreshContent RefreshContent;

		// Token: 0x04002192 RID: 8594
		public IRefreshRule RefreshRule;

		// Token: 0x04002193 RID: 8595
		[Nullable(2)]
		public IStateChangeConfig StateChangeConfig;
	}
}
