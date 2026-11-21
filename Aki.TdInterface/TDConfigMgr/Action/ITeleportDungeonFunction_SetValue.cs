using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021DC RID: 8668
	public class ITeleportDungeonFunction_SetValue
	{
		// Token: 0x04007175 RID: 29045
		public EEnableFunctionType Type;

		// Token: 0x04007176 RID: 29046
		public bool Enable;

		// Token: 0x04007177 RID: 29047
		[Nullable(2)]
		public List<int> DungeonList;
	}
}
