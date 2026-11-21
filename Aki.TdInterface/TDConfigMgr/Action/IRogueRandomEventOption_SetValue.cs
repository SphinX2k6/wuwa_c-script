using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FDE RID: 8158
	public class IRogueRandomEventOption_SetValue
	{
		// Token: 0x04006773 RID: 26483
		public ESystemOptionType Type;

		// Token: 0x04006774 RID: 26484
		public List<ISystemOption> SystemOptions;

		// Token: 0x04006775 RID: 26485
		public bool? KeepPreTalkItem;

		// Token: 0x04006776 RID: 26486
		public int EventId;
	}
}
