using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BE RID: 446
	public class IAllRefreshContent_SetValue
	{
		// Token: 0x0400086C RID: 2156
		public ERefreshContent Type;

		// Token: 0x0400086D RID: 2157
		[Nullable(1)]
		public List<int> EntityIds;

		// Token: 0x0400086E RID: 2158
		public bool? EdEnableSyncCamp;
	}
}
