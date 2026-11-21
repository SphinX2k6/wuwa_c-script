using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E2 RID: 994
	public class IFixedPointHook_SetValue
	{
		// Token: 0x04000FC2 RID: 4034
		public EHookInteractType Type;

		// Token: 0x04000FC3 RID: 4035
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000FC4 RID: 4036
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000FC5 RID: 4037
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000FC6 RID: 4038
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04000FC7 RID: 4039
		public float? ExitDistance;
	}
}
