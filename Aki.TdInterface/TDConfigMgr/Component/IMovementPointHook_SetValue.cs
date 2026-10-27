using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053B RID: 1339
	public class IMovementPointHook_SetValue
	{
		// Token: 0x040013BB RID: 5051
		public EHookInteractType Type;

		// Token: 0x040013BC RID: 5052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040013BD RID: 5053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040013BE RID: 5054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040013BF RID: 5055
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
