using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BB RID: 955
	public class IFoxJumpingPoint_SetValue
	{
		// Token: 0x04000F38 RID: 3896
		public EHookInteractType Type;

		// Token: 0x04000F39 RID: 3897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000F3A RID: 3898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000F3B RID: 3899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000F3C RID: 3900
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
