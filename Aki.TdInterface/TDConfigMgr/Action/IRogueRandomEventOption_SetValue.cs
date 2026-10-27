using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC7 RID: 7623
	public class IRogueRandomEventOption_SetValue
	{
		// Token: 0x040061EB RID: 25067
		public ESystemOptionType Type;

		// Token: 0x040061EC RID: 25068
		[Nullable(1)]
		public List<ISystemOption> SystemOptions;

		// Token: 0x040061ED RID: 25069
		public bool? KeepPreTalkItem;

		// Token: 0x040061EE RID: 25070
		public int EventId;
	}
}
