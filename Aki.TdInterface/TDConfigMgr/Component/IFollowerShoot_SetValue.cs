using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F2 RID: 1010
	public class IFollowerShoot_SetValue
	{
		// Token: 0x04000FFD RID: 4093
		public EHookInteractType Type;

		// Token: 0x04000FFE RID: 4094
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000FFF RID: 4095
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001000 RID: 4096
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001001 RID: 4097
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
