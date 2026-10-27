using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064B RID: 1611
	public class IRandomBatchPoolRefresh_SetValue
	{
		// Token: 0x040017F7 RID: 6135
		public EEntityBatchRefreshMode Type;

		// Token: 0x040017F8 RID: 6136
		[Nullable(1)]
		public List<IEntityListBatch> EntityBatches;

		// Token: 0x040017F9 RID: 6137
		public bool? IsRestartAfterAllBatchesFinished;
	}
}
