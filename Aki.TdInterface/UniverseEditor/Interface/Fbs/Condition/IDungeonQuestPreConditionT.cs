using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BFC RID: 19452
	public class IDungeonQuestPreConditionT
	{
		// Token: 0x17008D4E RID: 36174
		// (get) Token: 0x0601ECD5 RID: 126165 RVA: 0x004507BB File Offset: 0x0044E9BB
		// (set) Token: 0x0601ECD6 RID: 126166 RVA: 0x004507C3 File Offset: 0x0044E9C3
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008D4F RID: 36175
		// (get) Token: 0x0601ECD7 RID: 126167 RVA: 0x004507CC File Offset: 0x0044E9CC
		// (set) Token: 0x0601ECD8 RID: 126168 RVA: 0x004507D4 File Offset: 0x0044E9D4
		public IQuestPreConditionDungeonIdT Dungeon { get; set; }

		// Token: 0x0601ECD9 RID: 126169 RVA: 0x004507DD File Offset: 0x0044E9DD
		public IDungeonQuestPreConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Dungeon = null;
		}
	}
}
