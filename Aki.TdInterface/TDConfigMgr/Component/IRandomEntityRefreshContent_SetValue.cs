using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064F RID: 1615
	public class IRandomEntityRefreshContent_SetValue
	{
		// Token: 0x04001802 RID: 6146
		public ERefreshContent Type;

		// Token: 0x04001803 RID: 6147
		[Nullable(1)]
		public List<int> EntityIds;

		// Token: 0x04001804 RID: 6148
		public bool? EdEnableSyncCamp;
	}
}
