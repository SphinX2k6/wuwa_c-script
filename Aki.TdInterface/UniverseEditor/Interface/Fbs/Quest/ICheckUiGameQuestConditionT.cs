using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D86 RID: 15750
	public class ICheckUiGameQuestConditionT
	{
		// Token: 0x17006C17 RID: 27671
		// (get) Token: 0x06015D0F RID: 89359 RVA: 0x003258C1 File Offset: 0x00323AC1
		// (set) Token: 0x06015D10 RID: 89360 RVA: 0x003258C9 File Offset: 0x00323AC9
		public EChildQuest Type { get; set; }

		// Token: 0x17006C18 RID: 27672
		// (get) Token: 0x06015D11 RID: 89361 RVA: 0x003258D2 File Offset: 0x00323AD2
		// (set) Token: 0x06015D12 RID: 89362 RVA: 0x003258DA File Offset: 0x00323ADA
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006C19 RID: 27673
		// (get) Token: 0x06015D13 RID: 89363 RVA: 0x003258E3 File Offset: 0x00323AE3
		// (set) Token: 0x06015D14 RID: 89364 RVA: 0x003258EB File Offset: 0x00323AEB
		public List<TUiGameUnion> GameplayConfigs { get; set; }

		// Token: 0x06015D15 RID: 89365 RVA: 0x003258F4 File Offset: 0x00323AF4
		public ICheckUiGameQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.GameplayConfigs = null;
		}
	}
}
