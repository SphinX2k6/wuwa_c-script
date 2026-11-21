using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D0 RID: 4304
	public class IGradingSystemConfig_SetValue
	{
		// Token: 0x04003914 RID: 14612
		public EEnableSystemType Type;

		// Token: 0x04003915 RID: 14613
		public int GradingSystemId;

		// Token: 0x04003916 RID: 14614
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IGradingSystemVar> Vars;
	}
}
