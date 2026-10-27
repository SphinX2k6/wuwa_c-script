using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000039 RID: 57
	[NullableContext(1)]
	[Nullable(0)]
	public class CalculateComponent_SetValue
	{
		// Token: 0x04000148 RID: 328
		public bool? Disabled;

		// Token: 0x04000149 RID: 329
		public bool? EdIsLocked;

		// Token: 0x0400014A RID: 330
		public List<INumberVar> Vars;

		// Token: 0x0400014B RID: 331
		public List<IFunction> Functions;
	}
}
