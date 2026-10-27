using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF7 RID: 16119
	public class ILeaveDungeonConditionT
	{
		// Token: 0x17006FD1 RID: 28625
		// (get) Token: 0x06016CF4 RID: 93428 RVA: 0x0034A453 File Offset: 0x00348653
		// (set) Token: 0x06016CF5 RID: 93429 RVA: 0x0034A45B File Offset: 0x0034865B
		public EChildQuest Type { get; set; }

		// Token: 0x17006FD2 RID: 28626
		// (get) Token: 0x06016CF6 RID: 93430 RVA: 0x0034A464 File Offset: 0x00348664
		// (set) Token: 0x06016CF7 RID: 93431 RVA: 0x0034A46C File Offset: 0x0034866C
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x06016CF8 RID: 93432 RVA: 0x0034A475 File Offset: 0x00348675
		public ILeaveDungeonConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
		}
	}
}
