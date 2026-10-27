using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200186D RID: 6253
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeEntityStateBatchDirectly_SetValue
	{
		// Token: 0x040054BD RID: 21693
		public EChangeEntityState Type;

		// Token: 0x040054BE RID: 21694
		public int EntityId;

		// Token: 0x040054BF RID: 21695
		public List<int> EntityIds;

		// Token: 0x040054C0 RID: 21696
		public string State;

		// Token: 0x040054C1 RID: 21697
		public bool? DelayChange;
	}
}
