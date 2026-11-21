using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000239 RID: 569
	public class ICableWay_SetValue
	{
		// Token: 0x040009F6 RID: 2550
		public EHookInteractType Type;

		// Token: 0x040009F7 RID: 2551
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040009F8 RID: 2552
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040009F9 RID: 2553
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040009FA RID: 2554
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040009FB RID: 2555
		public int SplineEntityId;
	}
}
