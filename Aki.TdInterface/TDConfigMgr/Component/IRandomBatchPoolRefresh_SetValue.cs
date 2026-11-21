using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E8 RID: 1768
	public class IRandomBatchPoolRefresh_SetValue
	{
		// Token: 0x040019E9 RID: 6633
		public EEntityBatchRefreshMode Type;

		// Token: 0x040019EA RID: 6634
		public List<IEntityListBatch> EntityBatches;

		// Token: 0x040019EB RID: 6635
		public bool? IsRestartAfterAllBatchesFinished;
	}
}
