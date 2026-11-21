using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B0 RID: 6576
	public class IBvbChangeBoardCard_SetValue
	{
		// Token: 0x04005837 RID: 22583
		public EBvbPlayerOperationType Type;

		// Token: 0x04005838 RID: 22584
		public int? BoardPosIndex;

		// Token: 0x04005839 RID: 22585
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
