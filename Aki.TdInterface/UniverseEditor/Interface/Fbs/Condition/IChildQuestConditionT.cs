using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200505F RID: 20575
	public class IChildQuestConditionT
	{
		// Token: 0x17009347 RID: 37703
		// (get) Token: 0x060202B9 RID: 131769 RVA: 0x00476028 File Offset: 0x00474228
		// (set) Token: 0x060202BA RID: 131770 RVA: 0x00476030 File Offset: 0x00474230
		public int QuestId { get; set; }

		// Token: 0x17009348 RID: 37704
		// (get) Token: 0x060202BB RID: 131771 RVA: 0x00476039 File Offset: 0x00474239
		// (set) Token: 0x060202BC RID: 131772 RVA: 0x00476041 File Offset: 0x00474241
		public int ChildQuestId { get; set; }

		// Token: 0x060202BD RID: 131773 RVA: 0x0047604A File Offset: 0x0047424A
		public IChildQuestConditionT()
		{
			this.QuestId = 0;
			this.ChildQuestId = 0;
		}
	}
}
