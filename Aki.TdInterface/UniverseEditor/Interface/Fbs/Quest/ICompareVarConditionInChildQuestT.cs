using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA1 RID: 15777
	public class ICompareVarConditionInChildQuestT
	{
		// Token: 0x17006C8B RID: 27787
		// (get) Token: 0x06015EDE RID: 89822 RVA: 0x0032AAF4 File Offset: 0x00328CF4
		// (set) Token: 0x06015EDF RID: 89823 RVA: 0x0032AAFC File Offset: 0x00328CFC
		public EChildQuest Type { get; set; }

		// Token: 0x17006C8C RID: 27788
		// (get) Token: 0x06015EE0 RID: 89824 RVA: 0x0032AB05 File Offset: 0x00328D05
		// (set) Token: 0x06015EE1 RID: 89825 RVA: 0x0032AB0D File Offset: 0x00328D0D
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006C8D RID: 27789
		// (get) Token: 0x06015EE2 RID: 89826 RVA: 0x0032AB16 File Offset: 0x00328D16
		// (set) Token: 0x06015EE3 RID: 89827 RVA: 0x0032AB1E File Offset: 0x00328D1E
		public EConditionCount Count { get; set; }

		// Token: 0x17006C8E RID: 27790
		// (get) Token: 0x06015EE4 RID: 89828 RVA: 0x0032AB27 File Offset: 0x00328D27
		// (set) Token: 0x06015EE5 RID: 89829 RVA: 0x0032AB2F File Offset: 0x00328D2F
		public List<ICompareVarInChildQuestT> Conditions { get; set; }

		// Token: 0x06015EE6 RID: 89830 RVA: 0x0032AB38 File Offset: 0x00328D38
		public ICompareVarConditionInChildQuestT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
