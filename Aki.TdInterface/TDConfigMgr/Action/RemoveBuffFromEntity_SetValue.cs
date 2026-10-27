using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002145 RID: 8517
	public class RemoveBuffFromEntity_SetValue
	{
		// Token: 0x0400701C RID: 28700
		public int? EntityId;

		// Token: 0x0400701D RID: 28701
		[Nullable(2)]
		public List<int> EntityIds;

		// Token: 0x0400701E RID: 28702
		[Nullable(1)]
		public List<long> BuffIds;
	}
}
