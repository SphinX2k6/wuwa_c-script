using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FEA RID: 4074
	public class IKurotatoSystemConfig_SetValue
	{
		// Token: 0x04003693 RID: 13971
		public EEnableSystemType Type;

		// Token: 0x04003694 RID: 13972
		[Nullable(1)]
		public List<IKurotatoSystemVar> Vars;
	}
}
