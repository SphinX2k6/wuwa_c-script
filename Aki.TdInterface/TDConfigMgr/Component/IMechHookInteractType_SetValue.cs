using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054E RID: 1358
	public class IMechHookInteractType_SetValue
	{
		// Token: 0x04001417 RID: 5143
		public EMechHookInteractType Type;

		// Token: 0x04001418 RID: 5144
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001419 RID: 5145
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x0400141A RID: 5146
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x0400141B RID: 5147
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
