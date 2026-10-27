using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000399 RID: 921
	public class IFixedPointHook_SetValue
	{
		// Token: 0x04000ECB RID: 3787
		public EHookInteractType Type;

		// Token: 0x04000ECC RID: 3788
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000ECD RID: 3789
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000ECE RID: 3790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000ECF RID: 3791
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
