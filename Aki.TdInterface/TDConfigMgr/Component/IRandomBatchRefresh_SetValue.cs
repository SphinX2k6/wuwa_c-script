using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064D RID: 1613
	public class IRandomBatchRefresh_SetValue
	{
		// Token: 0x040017FE RID: 6142
		public EEntityBatchRefreshMode Type;

		// Token: 0x040017FF RID: 6143
		[Nullable(1)]
		public List<IEntityListBatch> EntityBatches;
	}
}
