using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A5 RID: 421
	public class GroupAiComponent_SetValue
	{
		// Token: 0x040007E0 RID: 2016
		public bool? Disabled;

		// Token: 0x040007E1 RID: 2017
		public bool? EdIsLocked;

		// Token: 0x040007E2 RID: 2018
		public List<int> Entities;

		// Token: 0x040007E3 RID: 2019
		public IGroupAiMode Option;

		// Token: 0x040007E4 RID: 2020
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> SyncTags;
	}
}
