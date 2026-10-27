using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004275 RID: 17013
	public class IVisionSystemQuestConditionT
	{
		// Token: 0x170078C2 RID: 30914
		// (get) Token: 0x060192EC RID: 103148 RVA: 0x0039E671 File Offset: 0x0039C871
		// (set) Token: 0x060192ED RID: 103149 RVA: 0x0039E679 File Offset: 0x0039C879
		public EChildQuest Type { get; set; }

		// Token: 0x170078C3 RID: 30915
		// (get) Token: 0x060192EE RID: 103150 RVA: 0x0039E682 File Offset: 0x0039C882
		// (set) Token: 0x060192EF RID: 103151 RVA: 0x0039E68A File Offset: 0x0039C88A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170078C4 RID: 30916
		// (get) Token: 0x060192F0 RID: 103152 RVA: 0x0039E693 File Offset: 0x0039C893
		// (set) Token: 0x060192F1 RID: 103153 RVA: 0x0039E69B File Offset: 0x0039C89B
		public TVisionSystemQuestUnion Quest { get; set; }

		// Token: 0x060192F2 RID: 103154 RVA: 0x0039E6A4 File Offset: 0x0039C8A4
		public IVisionSystemQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Quest = null;
		}
	}
}
