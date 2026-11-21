using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000406 RID: 1030
	public class IFoxJumpingPoint_SetValue
	{
		// Token: 0x04001039 RID: 4153
		public EHookInteractType Type;

		// Token: 0x0400103A RID: 4154
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x0400103B RID: 4155
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x0400103C RID: 4156
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x0400103D RID: 4157
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
