using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000447 RID: 1095
	public class IHookSpaceStationEnergyCore_SetValue
	{
		// Token: 0x040010F3 RID: 4339
		public EHookInteractType Type;

		// Token: 0x040010F4 RID: 4340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040010F5 RID: 4341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040010F6 RID: 4342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040010F7 RID: 4343
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040010F8 RID: 4344
		public int? HookSpeed;
	}
}
