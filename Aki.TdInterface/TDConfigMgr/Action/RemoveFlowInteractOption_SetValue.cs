using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214D RID: 8525
	public class RemoveFlowInteractOption_SetValue
	{
		// Token: 0x0400702E RID: 28718
		[Nullable(1)]
		public IFlowIndex Flow;

		// Token: 0x0400702F RID: 28719
		public int EntityId;

		// Token: 0x04007030 RID: 28720
		[Nullable(2)]
		public string InteractToken;
	}
}
