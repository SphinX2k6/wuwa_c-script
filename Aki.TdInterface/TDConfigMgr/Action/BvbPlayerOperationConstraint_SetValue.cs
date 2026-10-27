using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014B3 RID: 5299
	[NullableContext(1)]
	[Nullable(0)]
	public class BvbPlayerOperationConstraint_SetValue
	{
		// Token: 0x04004616 RID: 17942
		public IBvbPlayerOperationType EnableOperation;

		// Token: 0x04004617 RID: 17943
		public bool? IsTheLast;

		// Token: 0x04004618 RID: 17944
		public string TidPromptTxt;

		// Token: 0x04004619 RID: 17945
		[Nullable(2)]
		public string EdTidPromptTxt;
	}
}
