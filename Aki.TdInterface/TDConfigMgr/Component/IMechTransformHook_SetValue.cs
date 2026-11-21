using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000552 RID: 1362
	public class IMechTransformHook_SetValue
	{
		// Token: 0x0400143A RID: 5178
		public EHookInteractType Type;

		// Token: 0x0400143B RID: 5179
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x0400143C RID: 5180
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x0400143D RID: 5181
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x0400143E RID: 5182
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
