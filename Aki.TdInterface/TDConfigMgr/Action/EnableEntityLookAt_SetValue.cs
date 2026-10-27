using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001639 RID: 5689
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableEntityLookAt_SetValue
	{
		// Token: 0x04004C54 RID: 19540
		public string Key;

		// Token: 0x04004C55 RID: 19541
		public IDefaultLookAtType DefaultLookAtType;

		// Token: 0x04004C56 RID: 19542
		[Nullable(2)]
		public ICheckFlowLookAt OverrideLookAtType;

		// Token: 0x04004C57 RID: 19543
		public List<int> EntityIds;
	}
}
