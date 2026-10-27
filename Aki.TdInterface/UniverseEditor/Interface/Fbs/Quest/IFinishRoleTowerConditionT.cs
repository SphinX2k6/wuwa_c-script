using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E46 RID: 15942
	public class IFinishRoleTowerConditionT
	{
		// Token: 0x17006E57 RID: 28247
		// (get) Token: 0x0601660E RID: 91662 RVA: 0x0033B509 File Offset: 0x00339709
		// (set) Token: 0x0601660F RID: 91663 RVA: 0x0033B511 File Offset: 0x00339711
		public EChildQuest Type { get; set; }

		// Token: 0x17006E58 RID: 28248
		// (get) Token: 0x06016610 RID: 91664 RVA: 0x0033B51A File Offset: 0x0033971A
		// (set) Token: 0x06016611 RID: 91665 RVA: 0x0033B522 File Offset: 0x00339722
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E59 RID: 28249
		// (get) Token: 0x06016612 RID: 91666 RVA: 0x0033B52B File Offset: 0x0033972B
		// (set) Token: 0x06016613 RID: 91667 RVA: 0x0033B533 File Offset: 0x00339733
		public TRoleTowerConditionStepUnion Step { get; set; }

		// Token: 0x17006E5A RID: 28250
		// (get) Token: 0x06016614 RID: 91668 RVA: 0x0033B53C File Offset: 0x0033973C
		// (set) Token: 0x06016615 RID: 91669 RVA: 0x0033B544 File Offset: 0x00339744
		public TVarRefUnion Batch { get; set; }

		// Token: 0x06016616 RID: 91670 RVA: 0x0033B54D File Offset: 0x0033974D
		public IFinishRoleTowerConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
		}
	}
}
