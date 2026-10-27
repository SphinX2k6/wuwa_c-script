using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004107 RID: 16647
	public class IScheduleTimeConditionT
	{
		// Token: 0x17007559 RID: 30041
		// (get) Token: 0x06018469 RID: 99433 RVA: 0x0037E7DC File Offset: 0x0037C9DC
		// (set) Token: 0x0601846A RID: 99434 RVA: 0x0037E7E4 File Offset: 0x0037C9E4
		public EChildQuest Type { get; set; }

		// Token: 0x1700755A RID: 30042
		// (get) Token: 0x0601846B RID: 99435 RVA: 0x0037E7ED File Offset: 0x0037C9ED
		// (set) Token: 0x0601846C RID: 99436 RVA: 0x0037E7F5 File Offset: 0x0037C9F5
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700755B RID: 30043
		// (get) Token: 0x0601846D RID: 99437 RVA: 0x0037E7FE File Offset: 0x0037C9FE
		// (set) Token: 0x0601846E RID: 99438 RVA: 0x0037E806 File Offset: 0x0037CA06
		public IBaseTimeT StartTime { get; set; }

		// Token: 0x1700755C RID: 30044
		// (get) Token: 0x0601846F RID: 99439 RVA: 0x0037E80F File Offset: 0x0037CA0F
		// (set) Token: 0x06018470 RID: 99440 RVA: 0x0037E817 File Offset: 0x0037CA17
		public IBaseTimeT EndTime { get; set; }

		// Token: 0x1700755D RID: 30045
		// (get) Token: 0x06018471 RID: 99441 RVA: 0x0037E820 File Offset: 0x0037CA20
		// (set) Token: 0x06018472 RID: 99442 RVA: 0x0037E828 File Offset: 0x0037CA28
		public int Day { get; set; }

		// Token: 0x1700755E RID: 30046
		// (get) Token: 0x06018473 RID: 99443 RVA: 0x0037E831 File Offset: 0x0037CA31
		// (set) Token: 0x06018474 RID: 99444 RVA: 0x0037E839 File Offset: 0x0037CA39
		public byte NullMask { get; set; }

		// Token: 0x06018475 RID: 99445 RVA: 0x0037E842 File Offset: 0x0037CA42
		public IScheduleTimeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.StartTime = null;
			this.EndTime = null;
			this.Day = 0;
			this.NullMask = 0;
		}
	}
}
