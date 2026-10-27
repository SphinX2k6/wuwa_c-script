using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DD RID: 4317
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByTemplate_SetValue
	{
		// Token: 0x04003ABE RID: 15038
		public ERecallConditionType Type;

		// Token: 0x04003ABF RID: 15039
		public ERecallOperation Operation;

		// Token: 0x04003AC0 RID: 15040
		public List<string> Templates;

		// Token: 0x04003AC1 RID: 15041
		public List<int> AreaIds;
	}
}
