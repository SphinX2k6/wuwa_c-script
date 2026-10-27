using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011DB RID: 4571
	public class ITrapDefenseSystemConfig_SetValue
	{
		// Token: 0x04003E44 RID: 15940
		public EEnableSystemType Type;

		// Token: 0x04003E45 RID: 15941
		public int TrapDefenseId;

		// Token: 0x04003E46 RID: 15942
		[Nullable(1)]
		public List<ITrapDefenseSystemVar> Vars;
	}
}
