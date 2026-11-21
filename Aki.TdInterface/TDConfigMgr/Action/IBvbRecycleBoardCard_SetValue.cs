using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BC RID: 6588
	public class IBvbRecycleBoardCard_SetValue
	{
		// Token: 0x04005852 RID: 22610
		public EBvbPlayerOperationType Type;

		// Token: 0x04005853 RID: 22611
		public int? BoardPosIndex;

		// Token: 0x04005854 RID: 22612
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
