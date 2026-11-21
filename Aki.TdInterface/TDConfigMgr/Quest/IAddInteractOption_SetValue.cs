using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FCF RID: 4047
	public class IAddInteractOption_SetValue
	{
		// Token: 0x0400356D RID: 13677
		public IInteractOption Option;

		// Token: 0x0400356E RID: 13678
		public int EntityId;

		// Token: 0x0400356F RID: 13679
		public bool? IsManualFinish;

		// Token: 0x04003570 RID: 13680
		public bool? IsManualDelete;

		// Token: 0x04003571 RID: 13681
		[Nullable(2)]
		public string InteractToken;
	}
}
