using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E6 RID: 17382
	public class IPlayFlowQuestConditionT
	{
		// Token: 0x170077C1 RID: 30657
		// (get) Token: 0x06018B17 RID: 101143 RVA: 0x00385341 File Offset: 0x00383541
		// (set) Token: 0x06018B18 RID: 101144 RVA: 0x00385349 File Offset: 0x00383549
		public EChildQuest Type { get; set; }

		// Token: 0x170077C2 RID: 30658
		// (get) Token: 0x06018B19 RID: 101145 RVA: 0x00385352 File Offset: 0x00383552
		// (set) Token: 0x06018B1A RID: 101146 RVA: 0x0038535A File Offset: 0x0038355A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170077C3 RID: 30659
		// (get) Token: 0x06018B1B RID: 101147 RVA: 0x00385363 File Offset: 0x00383563
		// (set) Token: 0x06018B1C RID: 101148 RVA: 0x0038536B File Offset: 0x0038356B
		public IPlayFlowT Flow { get; set; }

		// Token: 0x06018B1D RID: 101149 RVA: 0x00385374 File Offset: 0x00383574
		public IPlayFlowQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Flow = null;
		}
	}
}
