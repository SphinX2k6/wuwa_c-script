using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007CC RID: 1996
	public class IWaterBoxBigWeaponHook_SetValue
	{
		// Token: 0x04001CBC RID: 7356
		public EHookInteractType Type;

		// Token: 0x04001CBD RID: 7357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001CBE RID: 7358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001CBF RID: 7359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001CC0 RID: 7360
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
