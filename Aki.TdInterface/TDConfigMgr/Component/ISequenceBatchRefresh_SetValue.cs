using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006BF RID: 1727
	public class ISequenceBatchRefresh_SetValue
	{
		// Token: 0x04001966 RID: 6502
		public EEntityBatchRefreshMode Type;

		// Token: 0x04001967 RID: 6503
		[Nullable(1)]
		public List<IEntityListBatch> EntityBatches;

		// Token: 0x04001968 RID: 6504
		public bool? IsRestartAfterAllBatchesFinished;
	}
}
