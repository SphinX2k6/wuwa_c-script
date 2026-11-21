using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A6 RID: 9126
	public class RemoveBuffFromEntity_SetValue
	{
		// Token: 0x04007651 RID: 30289
		public int? EntityId;

		// Token: 0x04007652 RID: 30290
		[Nullable(2)]
		public List<int> EntityIds;

		// Token: 0x04007653 RID: 30291
		public List<long> BuffIds;
	}
}
