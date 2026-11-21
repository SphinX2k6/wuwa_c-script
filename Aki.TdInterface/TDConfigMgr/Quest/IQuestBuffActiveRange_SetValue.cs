using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200119A RID: 4506
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestBuffActiveRange_SetValue
	{
		// Token: 0x04003C47 RID: 15431
		public IQuestBuffActiveCenterRange QuestBuffActiveCenterRange;

		// Token: 0x04003C48 RID: 15432
		public List<int> QuestBuffActiveRangeEntities;

		// Token: 0x04003C49 RID: 15433
		public List<int> QuestBuffActiveRangeAreaIds;
	}
}
