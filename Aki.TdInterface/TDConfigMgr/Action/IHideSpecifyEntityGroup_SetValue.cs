using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B08 RID: 6920
	public class IHideSpecifyEntityGroup_SetValue
	{
		// Token: 0x04005AE5 RID: 23269
		public EHideType Type;

		// Token: 0x04005AE6 RID: 23270
		[Nullable(1)]
		public List<int> EntityIds;

		// Token: 0x04005AE7 RID: 23271
		public bool? ForceClean;
	}
}
