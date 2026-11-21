using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000287 RID: 647
	public class IClientHookActionConfig_SetValue
	{
		// Token: 0x04000B4C RID: 2892
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000B4D RID: 2893
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000B4E RID: 2894
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;
	}
}
