using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002255 RID: 8789
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePlayerOperationConstraint_SetValue
	{
		// Token: 0x040072E8 RID: 29416
		public ITrapDefensePlayerOperationType DisableOperation;

		// Token: 0x040072E9 RID: 29417
		public bool IsConstrained;

		// Token: 0x040072EA RID: 29418
		public string TidPromptTxt;

		// Token: 0x040072EB RID: 29419
		[Nullable(2)]
		public string EdTidPromptTxt;
	}
}
