using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000ECB RID: 3787
	public class IAreaQuestTracking_SetValue
	{
		// Token: 0x040032A3 RID: 12963
		public int QuestId;

		// Token: 0x040032A4 RID: 12964
		public int NodeId;

		// Token: 0x040032A5 RID: 12965
		[Nullable(1)]
		public List<int> AreaIds;
	}
}
