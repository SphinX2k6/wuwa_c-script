using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B4 RID: 6580
	public class IBvbDeploy_SetValue
	{
		// Token: 0x04005840 RID: 22592
		public EBvbPlayerOperationType Type;

		// Token: 0x04005841 RID: 22593
		public int? HandCardIndex;

		// Token: 0x04005842 RID: 22594
		public int? BoardPosIndex;

		// Token: 0x04005843 RID: 22595
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
