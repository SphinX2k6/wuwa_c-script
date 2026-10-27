using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FDB RID: 16347
	public class IQuestFailedConditionEntityAlertT
	{
		// Token: 0x170072BD RID: 29373
		// (get) Token: 0x06017867 RID: 96359 RVA: 0x00364C2D File Offset: 0x00362E2D
		// (set) Token: 0x06017868 RID: 96360 RVA: 0x00364C35 File Offset: 0x00362E35
		public List<int> EntityIds { get; set; }

		// Token: 0x06017869 RID: 96361 RVA: 0x00364C3E File Offset: 0x00362E3E
		public IQuestFailedConditionEntityAlertT()
		{
			this.EntityIds = null;
		}
	}
}
