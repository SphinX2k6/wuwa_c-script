using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E9 RID: 20713
	public class IDungeonQuestPreConditionT
	{
		// Token: 0x17009472 RID: 38002
		// (get) Token: 0x060208BB RID: 133307 RVA: 0x00483E23 File Offset: 0x00482023
		// (set) Token: 0x060208BC RID: 133308 RVA: 0x00483E2B File Offset: 0x0048202B
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009473 RID: 38003
		// (get) Token: 0x060208BD RID: 133309 RVA: 0x00483E34 File Offset: 0x00482034
		// (set) Token: 0x060208BE RID: 133310 RVA: 0x00483E3C File Offset: 0x0048203C
		public IQuestPreConditionDungeonIdT Dungeon { get; set; }

		// Token: 0x060208BF RID: 133311 RVA: 0x00483E45 File Offset: 0x00482045
		public IDungeonQuestPreConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Dungeon = null;
		}
	}
}
