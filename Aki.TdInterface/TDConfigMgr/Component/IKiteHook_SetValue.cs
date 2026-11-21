using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000506 RID: 1286
	[NullableContext(2)]
	[Nullable(0)]
	public class IKiteHook_SetValue
	{
		// Token: 0x0400131B RID: 4891
		public EHookInteractType Type;

		// Token: 0x0400131C RID: 4892
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x0400131D RID: 4893
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x0400131E RID: 4894
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x0400131F RID: 4895
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04001320 RID: 4896
		public string HookDataAssetOverride;

		// Token: 0x04001321 RID: 4897
		public bool? SupportSwitchHookMidway;
	}
}
