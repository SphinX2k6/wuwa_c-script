using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000760 RID: 1888
	public class ISequenceBatchRefresh_SetValue
	{
		// Token: 0x04001B65 RID: 7013
		public EEntityBatchRefreshMode Type;

		// Token: 0x04001B66 RID: 7014
		public List<IEntityListBatch> EntityBatches;

		// Token: 0x04001B67 RID: 7015
		public bool? IsRestartAfterAllBatchesFinished;
	}
}
