using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000742 RID: 1858
	public class ISunSpiritLauncher_SetValue
	{
		// Token: 0x04001AFF RID: 6911
		public EHookInteractType Type;

		// Token: 0x04001B00 RID: 6912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001B01 RID: 6913
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001B02 RID: 6914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001B03 RID: 6915
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
