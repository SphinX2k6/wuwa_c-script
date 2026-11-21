using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D6 RID: 16854
	public class ICrossSceneSyncKillMonsterT
	{
		// Token: 0x170072D9 RID: 29401
		// (get) Token: 0x06017620 RID: 95776 RVA: 0x00357CF3 File Offset: 0x00355EF3
		// (set) Token: 0x06017621 RID: 95777 RVA: 0x00357CFB File Offset: 0x00355EFB
		public EChildQuest Type { get; set; }

		// Token: 0x170072DA RID: 29402
		// (get) Token: 0x06017622 RID: 95778 RVA: 0x00357D04 File Offset: 0x00355F04
		// (set) Token: 0x06017623 RID: 95779 RVA: 0x00357D0C File Offset: 0x00355F0C
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170072DB RID: 29403
		// (get) Token: 0x06017624 RID: 95780 RVA: 0x00357D15 File Offset: 0x00355F15
		// (set) Token: 0x06017625 RID: 95781 RVA: 0x00357D1D File Offset: 0x00355F1D
		public int EntityBundleId { get; set; }

		// Token: 0x170072DC RID: 29404
		// (get) Token: 0x06017626 RID: 95782 RVA: 0x00357D26 File Offset: 0x00355F26
		// (set) Token: 0x06017627 RID: 95783 RVA: 0x00357D2E File Offset: 0x00355F2E
		public int PosEntityId { get; set; }

		// Token: 0x06017628 RID: 95784 RVA: 0x00357D37 File Offset: 0x00355F37
		public ICrossSceneSyncKillMonsterT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityBundleId = 0;
			this.PosEntityId = 0;
		}
	}
}
