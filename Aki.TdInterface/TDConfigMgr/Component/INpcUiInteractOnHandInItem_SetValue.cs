using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F6 RID: 1526
	public class INpcUiInteractOnHandInItem_SetValue
	{
		// Token: 0x04001656 RID: 5718
		public ENpcUiInteractType Type;

		// Token: 0x04001657 RID: 5719
		public string EnterMontage;

		// Token: 0x04001658 RID: 5720
		public string StandByMontage;

		// Token: 0x04001659 RID: 5721
		public string HandInFailedMontage;

		// Token: 0x0400165A RID: 5722
		[Nullable(2)]
		public PlayFlow EnterFlow;

		// Token: 0x0400165B RID: 5723
		[Nullable(2)]
		public PlayFlow HandInFailedFlow;
	}
}
