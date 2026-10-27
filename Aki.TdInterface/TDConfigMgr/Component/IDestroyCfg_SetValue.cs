using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B4 RID: 692
	public class IDestroyCfg_SetValue
	{
		// Token: 0x04000BE7 RID: 3047
		[Nullable(1)]
		public List<ITeleControlDestroyCondition> Conditions;

		// Token: 0x04000BE8 RID: 3048
		public bool? StopPhysicAfterDestroyed;
	}
}
