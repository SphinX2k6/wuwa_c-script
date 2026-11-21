using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003EC RID: 1004
	public class IFlyingFeather_SetValue
	{
		// Token: 0x04000FE5 RID: 4069
		public EHookInteractType Type;

		// Token: 0x04000FE6 RID: 4070
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000FE7 RID: 4071
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000FE8 RID: 4072
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000FE9 RID: 4073
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04000FEA RID: 4074
		public int? EntityId;
	}
}
