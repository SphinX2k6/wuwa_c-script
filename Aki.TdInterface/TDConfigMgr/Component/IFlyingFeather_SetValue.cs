using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A3 RID: 931
	public class IFlyingFeather_SetValue
	{
		// Token: 0x04000EED RID: 3821
		public EHookInteractType Type;

		// Token: 0x04000EEE RID: 3822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000EEF RID: 3823
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000EF0 RID: 3824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000EF1 RID: 3825
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04000EF2 RID: 3826
		public int? EntityId;
	}
}
