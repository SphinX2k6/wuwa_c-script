using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200043D RID: 1085
	public class IHookInteractType_SetValue
	{
		// Token: 0x040010D8 RID: 4312
		public EHookInteractType Type;

		// Token: 0x040010D9 RID: 4313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040010DA RID: 4314
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040010DB RID: 4315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040010DC RID: 4316
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
