using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F8 RID: 6648
	public class IChangeEntityStateBatchDirectly_SetValue
	{
		// Token: 0x0400590A RID: 22794
		public EChangeEntityState Type;

		// Token: 0x0400590B RID: 22795
		public int EntityId;

		// Token: 0x0400590C RID: 22796
		public List<int> EntityIds;

		// Token: 0x0400590D RID: 22797
		public string State;

		// Token: 0x0400590E RID: 22798
		public bool? DelayChange;
	}
}
