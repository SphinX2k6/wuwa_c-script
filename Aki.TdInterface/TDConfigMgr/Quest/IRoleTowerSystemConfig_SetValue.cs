using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001115 RID: 4373
	public class IRoleTowerSystemConfig_SetValue
	{
		// Token: 0x04003B3E RID: 15166
		public EEnableSystemType Type;

		// Token: 0x04003B3F RID: 15167
		[Nullable(1)]
		public List<IRoleTowerSystemVar> Vars;
	}
}
