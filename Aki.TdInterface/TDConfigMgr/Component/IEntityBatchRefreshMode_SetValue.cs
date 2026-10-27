using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000310 RID: 784
	public class IEntityBatchRefreshMode_SetValue
	{
		// Token: 0x04000D29 RID: 3369
		public EEntityBatchRefreshMode Type;

		// Token: 0x04000D2A RID: 3370
		[Nullable(1)]
		public List<IEntityListBatch> EntityBatches;
	}
}
