using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000039 RID: 57
	public class CalculateComponent_SetValue
	{
		// Token: 0x0400014D RID: 333
		public bool? Disabled;

		// Token: 0x0400014E RID: 334
		public bool? EdIsLocked;

		// Token: 0x0400014F RID: 335
		public List<INumberVar> Vars;

		// Token: 0x04000150 RID: 336
		public List<IFunction> Functions;
	}
}
