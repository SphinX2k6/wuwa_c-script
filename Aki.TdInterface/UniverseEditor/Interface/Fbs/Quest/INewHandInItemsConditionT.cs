using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004395 RID: 17301
	public class INewHandInItemsConditionT
	{
		// Token: 0x170076B1 RID: 30385
		// (get) Token: 0x06018752 RID: 100178 RVA: 0x0037C521 File Offset: 0x0037A721
		// (set) Token: 0x06018753 RID: 100179 RVA: 0x0037C529 File Offset: 0x0037A729
		public EChildQuest Type { get; set; }

		// Token: 0x170076B2 RID: 30386
		// (get) Token: 0x06018754 RID: 100180 RVA: 0x0037C532 File Offset: 0x0037A732
		// (set) Token: 0x06018755 RID: 100181 RVA: 0x0037C53A File Offset: 0x0037A73A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170076B3 RID: 30387
		// (get) Token: 0x06018756 RID: 100182 RVA: 0x0037C543 File Offset: 0x0037A743
		// (set) Token: 0x06018757 RID: 100183 RVA: 0x0037C54B File Offset: 0x0037A74B
		public INewHandInItemsProjectionMachineT HandIn { get; set; }

		// Token: 0x06018758 RID: 100184 RVA: 0x0037C554 File Offset: 0x0037A754
		public INewHandInItemsConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.HandIn = null;
		}
	}
}
