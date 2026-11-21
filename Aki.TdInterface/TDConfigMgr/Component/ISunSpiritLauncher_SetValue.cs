using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E3 RID: 2019
	public class ISunSpiritLauncher_SetValue
	{
		// Token: 0x04001D04 RID: 7428
		public EHookInteractType Type;

		// Token: 0x04001D05 RID: 7429
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001D06 RID: 7430
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001D07 RID: 7431
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001D08 RID: 7432
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
