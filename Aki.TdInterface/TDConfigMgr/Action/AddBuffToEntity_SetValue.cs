using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200148A RID: 5258
	[NullableContext(2)]
	[Nullable(0)]
	public class AddBuffToEntity_SetValue
	{
		// Token: 0x04004592 RID: 17810
		public int? EntityId;

		// Token: 0x04004593 RID: 17811
		public List<int> EntityIds;

		// Token: 0x04004594 RID: 17812
		[Nullable(1)]
		public List<long> BuffIds;

		// Token: 0x04004595 RID: 17813
		public List<long> PersistOnOfflineBuffIds;
	}
}
