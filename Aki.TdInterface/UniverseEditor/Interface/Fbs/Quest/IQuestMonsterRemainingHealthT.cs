using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200443A RID: 17466
	public class IQuestMonsterRemainingHealthT
	{
		// Token: 0x17007913 RID: 30995
		// (get) Token: 0x06019084 RID: 102532 RVA: 0x003924C3 File Offset: 0x003906C3
		// (set) Token: 0x06019085 RID: 102533 RVA: 0x003924CB File Offset: 0x003906CB
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007914 RID: 30996
		// (get) Token: 0x06019086 RID: 102534 RVA: 0x003924D4 File Offset: 0x003906D4
		// (set) Token: 0x06019087 RID: 102535 RVA: 0x003924DC File Offset: 0x003906DC
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007915 RID: 30997
		// (get) Token: 0x06019088 RID: 102536 RVA: 0x003924E5 File Offset: 0x003906E5
		// (set) Token: 0x06019089 RID: 102537 RVA: 0x003924ED File Offset: 0x003906ED
		public int EntityId { get; set; }

		// Token: 0x17007916 RID: 30998
		// (get) Token: 0x0601908A RID: 102538 RVA: 0x003924F6 File Offset: 0x003906F6
		// (set) Token: 0x0601908B RID: 102539 RVA: 0x003924FE File Offset: 0x003906FE
		public bool IsStatisticsAdd { get; set; }

		// Token: 0x0601908C RID: 102540 RVA: 0x00392507 File Offset: 0x00390707
		public IQuestMonsterRemainingHealthT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.EntityId = 0;
			this.IsStatisticsAdd = false;
		}
	}
}
