using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FA6 RID: 4006
	public class IGradingSystemConfig_SetValue
	{
		// Token: 0x040035E2 RID: 13794
		public EEnableSystemType Type;

		// Token: 0x040035E3 RID: 13795
		public int GradingSystemId;

		// Token: 0x040035E4 RID: 13796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IGradingSystemVar> Vars;
	}
}
