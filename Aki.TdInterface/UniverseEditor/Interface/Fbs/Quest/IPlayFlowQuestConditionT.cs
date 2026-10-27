using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA5 RID: 16293
	public class IPlayFlowQuestConditionT
	{
		// Token: 0x170071C3 RID: 29123
		// (get) Token: 0x06017488 RID: 95368 RVA: 0x0035B729 File Offset: 0x00359929
		// (set) Token: 0x06017489 RID: 95369 RVA: 0x0035B731 File Offset: 0x00359931
		public EChildQuest Type { get; set; }

		// Token: 0x170071C4 RID: 29124
		// (get) Token: 0x0601748A RID: 95370 RVA: 0x0035B73A File Offset: 0x0035993A
		// (set) Token: 0x0601748B RID: 95371 RVA: 0x0035B742 File Offset: 0x00359942
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170071C5 RID: 29125
		// (get) Token: 0x0601748C RID: 95372 RVA: 0x0035B74B File Offset: 0x0035994B
		// (set) Token: 0x0601748D RID: 95373 RVA: 0x0035B753 File Offset: 0x00359953
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0601748E RID: 95374 RVA: 0x0035B75C File Offset: 0x0035995C
		public IPlayFlowQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Flow = null;
		}
	}
}
