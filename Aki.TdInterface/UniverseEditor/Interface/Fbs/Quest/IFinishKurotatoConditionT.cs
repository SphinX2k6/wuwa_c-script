using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E40 RID: 15936
	public class IFinishKurotatoConditionT
	{
		// Token: 0x17006E47 RID: 28231
		// (get) Token: 0x060165C8 RID: 91592 RVA: 0x0033A8A9 File Offset: 0x00338AA9
		// (set) Token: 0x060165C9 RID: 91593 RVA: 0x0033A8B1 File Offset: 0x00338AB1
		public EChildQuest Type { get; set; }

		// Token: 0x17006E48 RID: 28232
		// (get) Token: 0x060165CA RID: 91594 RVA: 0x0033A8BA File Offset: 0x00338ABA
		// (set) Token: 0x060165CB RID: 91595 RVA: 0x0033A8C2 File Offset: 0x00338AC2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E49 RID: 28233
		// (get) Token: 0x060165CC RID: 91596 RVA: 0x0033A8CB File Offset: 0x00338ACB
		// (set) Token: 0x060165CD RID: 91597 RVA: 0x0033A8D3 File Offset: 0x00338AD3
		public TKurotatoConditionStepUnion Step { get; set; }

		// Token: 0x17006E4A RID: 28234
		// (get) Token: 0x060165CE RID: 91598 RVA: 0x0033A8DC File Offset: 0x00338ADC
		// (set) Token: 0x060165CF RID: 91599 RVA: 0x0033A8E4 File Offset: 0x00338AE4
		public TVarRefUnion Batch { get; set; }

		// Token: 0x060165D0 RID: 91600 RVA: 0x0033A8ED File Offset: 0x00338AED
		public IFinishKurotatoConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
		}
	}
}
