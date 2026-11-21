using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419D RID: 16797
	public class ICheckUiGameQuestConditionT
	{
		// Token: 0x170071D1 RID: 29137
		// (get) Token: 0x06017247 RID: 94791 RVA: 0x0034CBED File Offset: 0x0034ADED
		// (set) Token: 0x06017248 RID: 94792 RVA: 0x0034CBF5 File Offset: 0x0034ADF5
		public EChildQuest Type { get; set; }

		// Token: 0x170071D2 RID: 29138
		// (get) Token: 0x06017249 RID: 94793 RVA: 0x0034CBFE File Offset: 0x0034ADFE
		// (set) Token: 0x0601724A RID: 94794 RVA: 0x0034CC06 File Offset: 0x0034AE06
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170071D3 RID: 29139
		// (get) Token: 0x0601724B RID: 94795 RVA: 0x0034CC0F File Offset: 0x0034AE0F
		// (set) Token: 0x0601724C RID: 94796 RVA: 0x0034CC17 File Offset: 0x0034AE17
		public List<TUiGameUnion> GameplayConfigs { get; set; }

		// Token: 0x0601724D RID: 94797 RVA: 0x0034CC20 File Offset: 0x0034AE20
		public ICheckUiGameQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.GameplayConfigs = null;
		}
	}
}
