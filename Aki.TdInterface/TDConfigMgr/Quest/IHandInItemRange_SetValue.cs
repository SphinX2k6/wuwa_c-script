using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FB0 RID: 4016
	public class IHandInItemRange_SetValue
	{
		// Token: 0x04003600 RID: 13824
		public EHandInItemType HandInType;

		// Token: 0x04003601 RID: 13825
		[Nullable(1)]
		public List<int> ItemIds;
	}
}
