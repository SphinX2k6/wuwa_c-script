using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A0 RID: 1184
	public class IHookSpaceStationEnergyCore_SetValue
	{
		// Token: 0x04001215 RID: 4629
		public EHookInteractType Type;

		// Token: 0x04001216 RID: 4630
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001217 RID: 4631
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001218 RID: 4632
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001219 RID: 4633
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x0400121A RID: 4634
		public int? HookSpeed;
	}
}
