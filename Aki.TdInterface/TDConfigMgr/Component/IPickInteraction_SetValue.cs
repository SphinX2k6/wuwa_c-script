using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FD RID: 1533
	public class IPickInteraction_SetValue
	{
		// Token: 0x040016DB RID: 5851
		public EPickInteraction Type;

		// Token: 0x040016DC RID: 5852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> CheckedActions;

		// Token: 0x040016DD RID: 5853
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> UncheckedActions;
	}
}
