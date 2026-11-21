using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200160C RID: 5644
	public class BvbPlayerOperationConstraint_SetValue
	{
		// Token: 0x040049B1 RID: 18865
		public IBvbPlayerOperationType EnableOperation;

		// Token: 0x040049B2 RID: 18866
		public bool? IsTheLast;

		// Token: 0x040049B3 RID: 18867
		public string TidPromptTxt;

		// Token: 0x040049B4 RID: 18868
		[Nullable(2)]
		public string EdTidPromptTxt;
	}
}
