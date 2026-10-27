using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D9B RID: 15771
	public class ICompareActorVarT
	{
		// Token: 0x17006C79 RID: 27769
		// (get) Token: 0x06015E93 RID: 89747 RVA: 0x00329F44 File Offset: 0x00328144
		// (set) Token: 0x06015E94 RID: 89748 RVA: 0x00329F4C File Offset: 0x0032814C
		public EChildQuest Type { get; set; }

		// Token: 0x17006C7A RID: 27770
		// (get) Token: 0x06015E95 RID: 89749 RVA: 0x00329F55 File Offset: 0x00328155
		// (set) Token: 0x06015E96 RID: 89750 RVA: 0x00329F5D File Offset: 0x0032815D
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006C7B RID: 27771
		// (get) Token: 0x06015E97 RID: 89751 RVA: 0x00329F66 File Offset: 0x00328166
		// (set) Token: 0x06015E98 RID: 89752 RVA: 0x00329F6E File Offset: 0x0032816E
		public EConditionCount Count { get; set; }

		// Token: 0x17006C7C RID: 27772
		// (get) Token: 0x06015E99 RID: 89753 RVA: 0x00329F77 File Offset: 0x00328177
		// (set) Token: 0x06015E9A RID: 89754 RVA: 0x00329F7F File Offset: 0x0032817F
		public List<ICompareActorVarInChildQuestT> Conditions { get; set; }

		// Token: 0x06015E9B RID: 89755 RVA: 0x00329F88 File Offset: 0x00328188
		public ICompareActorVarT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
