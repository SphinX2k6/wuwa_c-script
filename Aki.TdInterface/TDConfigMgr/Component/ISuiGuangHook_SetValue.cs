using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D9 RID: 2009
	public class ISuiGuangHook_SetValue
	{
		// Token: 0x04001CE2 RID: 7394
		public EHookInteractType Type;

		// Token: 0x04001CE3 RID: 7395
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001CE4 RID: 7396
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001CE5 RID: 7397
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001CE6 RID: 7398
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
