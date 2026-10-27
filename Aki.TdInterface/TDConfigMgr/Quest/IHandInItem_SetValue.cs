using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FAE RID: 4014
	public class IHandInItem_SetValue
	{
		// Token: 0x040035FB RID: 13819
		public EHandInItemType HandInType;

		// Token: 0x040035FC RID: 13820
		[Nullable(1)]
		public List<int> ItemIds;

		// Token: 0x040035FD RID: 13821
		public int Count;
	}
}
