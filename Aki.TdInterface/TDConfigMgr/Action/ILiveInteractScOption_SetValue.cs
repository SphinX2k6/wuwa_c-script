using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D62 RID: 7522
	public class ILiveInteractScOption_SetValue
	{
		// Token: 0x0400612C RID: 24876
		public ESystemOptionType Type;

		// Token: 0x0400612D RID: 24877
		public List<ISystemOption> SystemOptions;

		// Token: 0x0400612E RID: 24878
		public bool? KeepPreTalkItem;

		// Token: 0x0400612F RID: 24879
		public List<int> ScIds;
	}
}
