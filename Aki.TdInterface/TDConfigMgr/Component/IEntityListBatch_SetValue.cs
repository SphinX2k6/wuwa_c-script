using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000322 RID: 802
	public class IEntityListBatch_SetValue
	{
		// Token: 0x04000D6A RID: 3434
		public EEntityBatchType Type;

		// Token: 0x04000D6B RID: 3435
		[Nullable(1)]
		public List<int> EntityIds;
	}
}
