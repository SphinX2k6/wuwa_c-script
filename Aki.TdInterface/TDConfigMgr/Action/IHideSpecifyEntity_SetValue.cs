using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B06 RID: 6918
	public class IHideSpecifyEntity_SetValue
	{
		// Token: 0x04005AE1 RID: 23265
		public EHideType Type;

		// Token: 0x04005AE2 RID: 23266
		[Nullable(1)]
		public List<int> EntityIds;
	}
}
