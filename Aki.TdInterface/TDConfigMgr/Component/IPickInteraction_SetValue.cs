using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200069A RID: 1690
	public class IPickInteraction_SetValue
	{
		// Token: 0x040018CD RID: 6349
		public EPickInteraction Type;

		// Token: 0x040018CE RID: 6350
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> CheckedActions;

		// Token: 0x040018CF RID: 6351
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> UncheckedActions;
	}
}
