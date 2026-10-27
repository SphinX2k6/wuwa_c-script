using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001492 RID: 5266
	public class AddFlowInteractOption_SetValue
	{
		// Token: 0x040045A5 RID: 17829
		[Nullable(1)]
		public IInteractOption Option;

		// Token: 0x040045A6 RID: 17830
		public int EntityId;

		// Token: 0x040045A7 RID: 17831
		public bool? DelayRemoveByQuestEnd;

		// Token: 0x040045A8 RID: 17832
		[Nullable(2)]
		public string InteractToken;
	}
}
