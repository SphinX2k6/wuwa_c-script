using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000770 RID: 1904
	public class ISingleBtnQte_SetValue
	{
		// Token: 0x04001B91 RID: 7057
		public EQteType Type;

		// Token: 0x04001B92 RID: 7058
		public int QteId;

		// Token: 0x04001B93 RID: 7059
		public IQteCallback SuccessCallback;

		// Token: 0x04001B94 RID: 7060
		public IQteCallback FailureCallback;
	}
}
