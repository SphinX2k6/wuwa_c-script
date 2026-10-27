using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B78 RID: 19320
	public class IChildQuestConditionT
	{
		// Token: 0x17008C37 RID: 35895
		// (get) Token: 0x0601E72B RID: 124715 RVA: 0x004437DC File Offset: 0x004419DC
		// (set) Token: 0x0601E72C RID: 124716 RVA: 0x004437E4 File Offset: 0x004419E4
		public int QuestId { get; set; }

		// Token: 0x17008C38 RID: 35896
		// (get) Token: 0x0601E72D RID: 124717 RVA: 0x004437ED File Offset: 0x004419ED
		// (set) Token: 0x0601E72E RID: 124718 RVA: 0x004437F5 File Offset: 0x004419F5
		public int ChildQuestId { get; set; }

		// Token: 0x0601E72F RID: 124719 RVA: 0x004437FE File Offset: 0x004419FE
		public IChildQuestConditionT()
		{
			this.QuestId = 0;
			this.ChildQuestId = 0;
		}
	}
}
