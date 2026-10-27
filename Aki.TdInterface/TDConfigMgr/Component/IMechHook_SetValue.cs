using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004ED RID: 1261
	public class IMechHook_SetValue
	{
		// Token: 0x040012C2 RID: 4802
		public EHookInteractType Type;

		// Token: 0x040012C3 RID: 4803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040012C4 RID: 4804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040012C5 RID: 4805
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040012C6 RID: 4806
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040012C7 RID: 4807
		[Nullable(1)]
		public IMechHookConfigType HookConfig;
	}
}
