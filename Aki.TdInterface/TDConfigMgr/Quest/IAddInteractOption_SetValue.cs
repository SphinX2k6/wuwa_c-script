using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EB9 RID: 3769
	public class IAddInteractOption_SetValue
	{
		// Token: 0x04003260 RID: 12896
		[Nullable(1)]
		public IInteractOption Option;

		// Token: 0x04003261 RID: 12897
		public int EntityId;

		// Token: 0x04003262 RID: 12898
		public bool? IsManualFinish;

		// Token: 0x04003263 RID: 12899
		public bool? IsManualDelete;

		// Token: 0x04003264 RID: 12900
		[Nullable(2)]
		public string InteractToken;
	}
}
