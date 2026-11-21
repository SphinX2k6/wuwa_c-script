using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086F RID: 2159
	public class IWaterBoxBigWeaponHook_SetValue
	{
		// Token: 0x04001EC8 RID: 7880
		public EHookInteractType Type;

		// Token: 0x04001EC9 RID: 7881
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001ECA RID: 7882
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001ECB RID: 7883
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001ECC RID: 7884
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
