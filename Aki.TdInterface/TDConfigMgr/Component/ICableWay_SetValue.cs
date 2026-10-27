using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000212 RID: 530
	public class ICableWay_SetValue
	{
		// Token: 0x0400096C RID: 2412
		public EHookInteractType Type;

		// Token: 0x0400096D RID: 2413
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x0400096E RID: 2414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x0400096F RID: 2415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000970 RID: 2416
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04000971 RID: 2417
		public int SplineEntityId;
	}
}
