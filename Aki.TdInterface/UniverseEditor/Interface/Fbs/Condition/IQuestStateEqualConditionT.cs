using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CAA RID: 19626
	public class IQuestStateEqualConditionT
	{
		// Token: 0x17008E7C RID: 36476
		// (get) Token: 0x0601F223 RID: 127523 RVA: 0x00459378 File Offset: 0x00457578
		// (set) Token: 0x0601F224 RID: 127524 RVA: 0x00459380 File Offset: 0x00457580
		public ECondition Type { get; set; }

		// Token: 0x17008E7D RID: 36477
		// (get) Token: 0x0601F225 RID: 127525 RVA: 0x00459389 File Offset: 0x00457589
		// (set) Token: 0x0601F226 RID: 127526 RVA: 0x00459391 File Offset: 0x00457591
		public int QuestId { get; set; }

		// Token: 0x17008E7E RID: 36478
		// (get) Token: 0x0601F227 RID: 127527 RVA: 0x0045939A File Offset: 0x0045759A
		// (set) Token: 0x0601F228 RID: 127528 RVA: 0x004593A2 File Offset: 0x004575A2
		public EQuestState State { get; set; }

		// Token: 0x17008E7F RID: 36479
		// (get) Token: 0x0601F229 RID: 127529 RVA: 0x004593AB File Offset: 0x004575AB
		// (set) Token: 0x0601F22A RID: 127530 RVA: 0x004593B3 File Offset: 0x004575B3
		public ECompare Compare { get; set; }

		// Token: 0x0601F22B RID: 127531 RVA: 0x004593BC File Offset: 0x004575BC
		public IQuestStateEqualConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.QuestId = 0;
			this.State = EQuestState.InActive;
			this.Compare = ECompare.Eq;
		}
	}
}
