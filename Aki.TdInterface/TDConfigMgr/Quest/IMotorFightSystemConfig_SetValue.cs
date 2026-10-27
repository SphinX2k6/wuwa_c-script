using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200101E RID: 4126
	public class IMotorFightSystemConfig_SetValue
	{
		// Token: 0x04003768 RID: 14184
		public EEnableSystemType Type;

		// Token: 0x04003769 RID: 14185
		[Nullable(1)]
		public List<IMotorFightSystemVar> Vars;
	}
}
