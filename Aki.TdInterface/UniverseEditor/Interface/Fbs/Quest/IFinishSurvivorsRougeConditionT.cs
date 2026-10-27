using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E4C RID: 15948
	public class IFinishSurvivorsRougeConditionT
	{
		// Token: 0x17006E7E RID: 28286
		// (get) Token: 0x060166BA RID: 91834 RVA: 0x0033D789 File Offset: 0x0033B989
		// (set) Token: 0x060166BB RID: 91835 RVA: 0x0033D791 File Offset: 0x0033B991
		public EChildQuest Type { get; set; }

		// Token: 0x17006E7F RID: 28287
		// (get) Token: 0x060166BC RID: 91836 RVA: 0x0033D79A File Offset: 0x0033B99A
		// (set) Token: 0x060166BD RID: 91837 RVA: 0x0033D7A2 File Offset: 0x0033B9A2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E80 RID: 28288
		// (get) Token: 0x060166BE RID: 91838 RVA: 0x0033D7AB File Offset: 0x0033B9AB
		// (set) Token: 0x060166BF RID: 91839 RVA: 0x0033D7B3 File Offset: 0x0033B9B3
		public TSurvivorsRougeConditionStepUnion Step { get; set; }

		// Token: 0x17006E81 RID: 28289
		// (get) Token: 0x060166C0 RID: 91840 RVA: 0x0033D7BC File Offset: 0x0033B9BC
		// (set) Token: 0x060166C1 RID: 91841 RVA: 0x0033D7C4 File Offset: 0x0033B9C4
		public TVarRefUnion Batch { get; set; }

		// Token: 0x060166C2 RID: 91842 RVA: 0x0033D7CD File Offset: 0x0033B9CD
		public IFinishSurvivorsRougeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
		}
	}
}
