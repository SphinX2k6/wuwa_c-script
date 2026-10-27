using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200106C RID: 4204
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestBuffActiveRange_SetValue
	{
		// Token: 0x040038FC RID: 14588
		public IQuestBuffActiveCenterRange QuestBuffActiveCenterRange;

		// Token: 0x040038FD RID: 14589
		public List<int> QuestBuffActiveRangeEntities;

		// Token: 0x040038FE RID: 14590
		public List<int> QuestBuffActiveRangeAreaIds;
	}
}
