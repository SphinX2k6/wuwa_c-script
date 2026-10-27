using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A9 RID: 937
	public class IFollowerShoot_SetValue
	{
		// Token: 0x04000F05 RID: 3845
		public EHookInteractType Type;

		// Token: 0x04000F06 RID: 3846
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000F07 RID: 3847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000F08 RID: 3848
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000F09 RID: 3849
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
