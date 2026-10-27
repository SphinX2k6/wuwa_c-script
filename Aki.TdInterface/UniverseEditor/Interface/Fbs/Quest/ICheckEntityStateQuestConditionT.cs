using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D4D RID: 15693
	public class ICheckEntityStateQuestConditionT
	{
		// Token: 0x17006BB1 RID: 27569
		// (get) Token: 0x06015B33 RID: 88883 RVA: 0x00321866 File Offset: 0x0031FA66
		// (set) Token: 0x06015B34 RID: 88884 RVA: 0x0032186E File Offset: 0x0031FA6E
		public EChildQuest Type { get; set; }

		// Token: 0x17006BB2 RID: 27570
		// (get) Token: 0x06015B35 RID: 88885 RVA: 0x00321877 File Offset: 0x0031FA77
		// (set) Token: 0x06015B36 RID: 88886 RVA: 0x0032187F File Offset: 0x0031FA7F
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BB3 RID: 27571
		// (get) Token: 0x06015B37 RID: 88887 RVA: 0x00321888 File Offset: 0x0031FA88
		// (set) Token: 0x06015B38 RID: 88888 RVA: 0x00321890 File Offset: 0x0031FA90
		public List<IEntityStateConditionT> Conditions { get; set; }

		// Token: 0x06015B39 RID: 88889 RVA: 0x00321899 File Offset: 0x0031FA99
		public ICheckEntityStateQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Conditions = null;
		}
	}
}
