using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015EB RID: 5611
	public class AddFlowInteractOption_SetValue
	{
		// Token: 0x04004940 RID: 18752
		public IInteractOption Option;

		// Token: 0x04004941 RID: 18753
		public int EntityId;

		// Token: 0x04004942 RID: 18754
		public bool? DelayRemoveByQuestEnd;

		// Token: 0x04004943 RID: 18755
		[Nullable(2)]
		public string InteractToken;
	}
}
