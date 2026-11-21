using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A2 RID: 1442
	public class IMovementPointHook_SetValue
	{
		// Token: 0x04001525 RID: 5413
		public EHookInteractType Type;

		// Token: 0x04001526 RID: 5414
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001527 RID: 5415
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001528 RID: 5416
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001529 RID: 5417
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
