using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000738 RID: 1848
	public class ISuiGuangHook_SetValue
	{
		// Token: 0x04001ADD RID: 6877
		public EHookInteractType Type;

		// Token: 0x04001ADE RID: 6878
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001ADF RID: 6879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001AE0 RID: 6880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001AE1 RID: 6881
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
