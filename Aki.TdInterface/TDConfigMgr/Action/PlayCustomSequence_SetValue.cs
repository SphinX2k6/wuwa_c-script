using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002106 RID: 8454
	public class PlayCustomSequence_SetValue
	{
		// Token: 0x04006F5D RID: 28509
		public int CustomSeqId;

		// Token: 0x04006F5E RID: 28510
		[Nullable(1)]
		public List<int> WhoIds;

		// Token: 0x04006F5F RID: 28511
		public bool? ResetCamera;
	}
}
