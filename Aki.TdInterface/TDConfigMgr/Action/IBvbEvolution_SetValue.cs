using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200182D RID: 6189
	public class IBvbEvolution_SetValue
	{
		// Token: 0x040053FD RID: 21501
		public EBvbPlayerOperationType Type;

		// Token: 0x040053FE RID: 21502
		public int? HandCardIndex;

		// Token: 0x040053FF RID: 21503
		public int? BoardPosIndex;

		// Token: 0x04005400 RID: 21504
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
