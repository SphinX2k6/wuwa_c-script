using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B7 RID: 25783
	public class ICompleteChildQuestT
	{
		// Token: 0x1700BFD7 RID: 49111
		// (get) Token: 0x0602CB4A RID: 183114 RVA: 0x00622B18 File Offset: 0x00620D18
		// (set) Token: 0x0602CB4B RID: 183115 RVA: 0x00622B20 File Offset: 0x00620D20
		public int QuestId { get; set; }

		// Token: 0x1700BFD8 RID: 49112
		// (get) Token: 0x0602CB4C RID: 183116 RVA: 0x00622B29 File Offset: 0x00620D29
		// (set) Token: 0x0602CB4D RID: 183117 RVA: 0x00622B31 File Offset: 0x00620D31
		public int NodeId { get; set; }

		// Token: 0x0602CB4E RID: 183118 RVA: 0x00622B3A File Offset: 0x00620D3A
		public ICompleteChildQuestT()
		{
			this.QuestId = 0;
			this.NodeId = 0;
		}
	}
}
