using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E3 RID: 5603
	public class AddBuffToEntity_SetValue
	{
		// Token: 0x0400492D RID: 18733
		public int? EntityId;

		// Token: 0x0400492E RID: 18734
		[Nullable(2)]
		public List<int> EntityIds;

		// Token: 0x0400492F RID: 18735
		public List<long> BuffIds;

		// Token: 0x04004930 RID: 18736
		[Nullable(2)]
		public List<long> PersistOnOfflineBuffIds;
	}
}
