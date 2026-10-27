using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200056D RID: 1389
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcPerformStateConfig_SetValue
	{
		// Token: 0x0400144F RID: 5199
		[Nullable(1)]
		public string State;

		// Token: 0x04001450 RID: 5200
		public string MaterialDa;

		// Token: 0x04001451 RID: 5201
		public List<int> BuffEffectIds;
	}
}
