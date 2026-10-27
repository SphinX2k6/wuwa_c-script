using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE1 RID: 16353
	public class IQuestFailedConditionEntityStateT
	{
		// Token: 0x170072C3 RID: 29379
		// (get) Token: 0x06017899 RID: 96409 RVA: 0x003651D5 File Offset: 0x003633D5
		// (set) Token: 0x0601789A RID: 96410 RVA: 0x003651DD File Offset: 0x003633DD
		public List<IEntityStateConditionT> Conditions { get; set; }

		// Token: 0x0601789B RID: 96411 RVA: 0x003651E6 File Offset: 0x003633E6
		public IQuestFailedConditionEntityStateT()
		{
			this.Conditions = null;
		}
	}
}
