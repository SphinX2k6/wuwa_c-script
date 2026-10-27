using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000340 RID: 832
	[NullableContext(1)]
	[Nullable(0)]
	public class IEventRotator_SetValue
	{
		// Token: 0x04000DD3 RID: 3539
		public List<ActionInfo> StartActions;

		// Token: 0x04000DD4 RID: 3540
		public List<ActionInfo> EndActions;
	}
}
