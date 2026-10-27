using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F99 RID: 8089
	public class ITeleportDungeonFunction_SetValue
	{
		// Token: 0x04006B7A RID: 27514
		public EEnableFunctionType Type;

		// Token: 0x04006B7B RID: 27515
		public bool Enable;

		// Token: 0x04006B7C RID: 27516
		[Nullable(2)]
		public List<int> DungeonList;
	}
}
