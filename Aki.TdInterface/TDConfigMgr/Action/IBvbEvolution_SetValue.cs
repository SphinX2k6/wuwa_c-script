using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B8 RID: 6584
	public class IBvbEvolution_SetValue
	{
		// Token: 0x04005849 RID: 22601
		public EBvbPlayerOperationType Type;

		// Token: 0x0400584A RID: 22602
		public int? HandCardIndex;

		// Token: 0x0400584B RID: 22603
		public int? BoardPosIndex;

		// Token: 0x0400584C RID: 22604
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
