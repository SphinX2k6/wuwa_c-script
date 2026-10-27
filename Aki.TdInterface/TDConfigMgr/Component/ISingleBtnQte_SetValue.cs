using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CF RID: 1743
	[NullableContext(1)]
	[Nullable(0)]
	public class ISingleBtnQte_SetValue
	{
		// Token: 0x04001992 RID: 6546
		public EQteType Type;

		// Token: 0x04001993 RID: 6547
		public int QteId;

		// Token: 0x04001994 RID: 6548
		public IQteCallback SuccessCallback;

		// Token: 0x04001995 RID: 6549
		public IQteCallback FailureCallback;
	}
}
