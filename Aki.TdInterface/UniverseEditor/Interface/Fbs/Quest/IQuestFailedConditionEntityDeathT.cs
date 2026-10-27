using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FDE RID: 16350
	public class IQuestFailedConditionEntityDeathT
	{
		// Token: 0x170072C0 RID: 29376
		// (get) Token: 0x06017881 RID: 96385 RVA: 0x00364ED1 File Offset: 0x003630D1
		// (set) Token: 0x06017882 RID: 96386 RVA: 0x00364ED9 File Offset: 0x003630D9
		public List<int> EntityIds { get; set; }

		// Token: 0x06017883 RID: 96387 RVA: 0x00364EE2 File Offset: 0x003630E2
		public IQuestFailedConditionEntityDeathT()
		{
			this.EntityIds = null;
		}
	}
}
