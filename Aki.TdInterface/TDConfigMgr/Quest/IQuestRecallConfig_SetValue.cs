using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001094 RID: 4244
	public class IQuestRecallConfig_SetValue
	{
		// Token: 0x040039B7 RID: 14775
		public int RecallId;

		// Token: 0x040039B8 RID: 14776
		[Nullable(1)]
		public List<IRecallEntityList> RecallEntityList;
	}
}
