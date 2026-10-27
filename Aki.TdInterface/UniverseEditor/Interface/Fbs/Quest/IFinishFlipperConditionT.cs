using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E37 RID: 15927
	public class IFinishFlipperConditionT
	{
		// Token: 0x17006E25 RID: 28197
		// (get) Token: 0x0601654B RID: 91467 RVA: 0x00339515 File Offset: 0x00337715
		// (set) Token: 0x0601654C RID: 91468 RVA: 0x0033951D File Offset: 0x0033771D
		public EChildQuest Type { get; set; }

		// Token: 0x17006E26 RID: 28198
		// (get) Token: 0x0601654D RID: 91469 RVA: 0x00339526 File Offset: 0x00337726
		// (set) Token: 0x0601654E RID: 91470 RVA: 0x0033952E File Offset: 0x0033772E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E27 RID: 28199
		// (get) Token: 0x0601654F RID: 91471 RVA: 0x00339537 File Offset: 0x00337737
		// (set) Token: 0x06016550 RID: 91472 RVA: 0x0033953F File Offset: 0x0033773F
		public IFlipperConditionStepFightT Step { get; set; }

		// Token: 0x06016551 RID: 91473 RVA: 0x00339548 File Offset: 0x00337748
		public IFinishFlipperConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
		}
	}
}
