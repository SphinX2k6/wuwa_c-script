using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010FB RID: 4347
	public class IRogueTowerTrialSystemConfig_SetValue
	{
		// Token: 0x04003B13 RID: 15123
		public EEnableSystemType Type;

		// Token: 0x04003B14 RID: 15124
		[Nullable(1)]
		public List<IRogueTowerTrialSystemVar> Vars;
	}
}
