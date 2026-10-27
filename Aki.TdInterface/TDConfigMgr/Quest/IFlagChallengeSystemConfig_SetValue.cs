using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F8E RID: 3982
	public class IFlagChallengeSystemConfig_SetValue
	{
		// Token: 0x040035A0 RID: 13728
		public EEnableSystemType Type;

		// Token: 0x040035A1 RID: 13729
		[Nullable(1)]
		public List<IFlagChallengeSystemVar> Vars;
	}
}
