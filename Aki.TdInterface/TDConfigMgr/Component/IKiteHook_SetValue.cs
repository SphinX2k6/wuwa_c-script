using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004AD RID: 1197
	[NullableContext(2)]
	[Nullable(0)]
	public class IKiteHook_SetValue
	{
		// Token: 0x040011F9 RID: 4601
		public EHookInteractType Type;

		// Token: 0x040011FA RID: 4602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040011FB RID: 4603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040011FC RID: 4604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040011FD RID: 4605
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040011FE RID: 4606
		public string HookDataAssetOverride;

		// Token: 0x040011FF RID: 4607
		public bool? SupportSwitchHookMidway;
	}
}
