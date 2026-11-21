using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000496 RID: 1174
	public class IHookInteractType_SetValue
	{
		// Token: 0x040011FA RID: 4602
		public EHookInteractType Type;

		// Token: 0x040011FB RID: 4603
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040011FC RID: 4604
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040011FD RID: 4605
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040011FE RID: 4606
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
