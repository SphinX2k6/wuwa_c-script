using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD9 RID: 7385
	public class IPermanentRogueRandomEvent_SetValue
	{
		// Token: 0x04005FCE RID: 24526
		public ESystemOptionType Type;

		// Token: 0x04005FCF RID: 24527
		[Nullable(1)]
		public List<ISystemOption> SystemOptions;

		// Token: 0x04005FD0 RID: 24528
		public bool? KeepPreTalkItem;

		// Token: 0x04005FD1 RID: 24529
		public int EventId;
	}
}
