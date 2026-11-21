using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005188 RID: 20872
	public class IPreChildQuestT
	{
		// Token: 0x1700957D RID: 38269
		// (get) Token: 0x06020D83 RID: 134531 RVA: 0x0048BC2D File Offset: 0x00489E2D
		// (set) Token: 0x06020D84 RID: 134532 RVA: 0x0048BC35 File Offset: 0x00489E35
		public EVisibleCondition Type { get; set; }

		// Token: 0x1700957E RID: 38270
		// (get) Token: 0x06020D85 RID: 134533 RVA: 0x0048BC3E File Offset: 0x00489E3E
		// (set) Token: 0x06020D86 RID: 134534 RVA: 0x0048BC46 File Offset: 0x00489E46
		public ECompare Compare { get; set; }

		// Token: 0x1700957F RID: 38271
		// (get) Token: 0x06020D87 RID: 134535 RVA: 0x0048BC4F File Offset: 0x00489E4F
		// (set) Token: 0x06020D88 RID: 134536 RVA: 0x0048BC57 File Offset: 0x00489E57
		public IChildQuestConditionT PreChildQuest { get; set; }

		// Token: 0x06020D89 RID: 134537 RVA: 0x0048BC60 File Offset: 0x00489E60
		public IPreChildQuestT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.PreChildQuest = null;
		}
	}
}
