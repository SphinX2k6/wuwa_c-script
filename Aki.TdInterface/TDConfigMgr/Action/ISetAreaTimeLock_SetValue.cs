using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E0F RID: 7695
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAreaTimeLock_SetValue
	{
		// Token: 0x0400628D RID: 25229
		public ESetAreaTime Type;

		// Token: 0x0400628E RID: 25230
		public List<int> AreaIds;

		// Token: 0x0400628F RID: 25231
		public IFixedTime LockTime;
	}
}
