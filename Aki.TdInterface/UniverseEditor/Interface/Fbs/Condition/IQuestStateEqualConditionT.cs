using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A3 RID: 20899
	public class IQuestStateEqualConditionT
	{
		// Token: 0x170095AA RID: 38314
		// (get) Token: 0x06020E45 RID: 134725 RVA: 0x0048CEC8 File Offset: 0x0048B0C8
		// (set) Token: 0x06020E46 RID: 134726 RVA: 0x0048CED0 File Offset: 0x0048B0D0
		public ECondition Type { get; set; }

		// Token: 0x170095AB RID: 38315
		// (get) Token: 0x06020E47 RID: 134727 RVA: 0x0048CED9 File Offset: 0x0048B0D9
		// (set) Token: 0x06020E48 RID: 134728 RVA: 0x0048CEE1 File Offset: 0x0048B0E1
		public int QuestId { get; set; }

		// Token: 0x170095AC RID: 38316
		// (get) Token: 0x06020E49 RID: 134729 RVA: 0x0048CEEA File Offset: 0x0048B0EA
		// (set) Token: 0x06020E4A RID: 134730 RVA: 0x0048CEF2 File Offset: 0x0048B0F2
		public EQuestState State { get; set; }

		// Token: 0x170095AD RID: 38317
		// (get) Token: 0x06020E4B RID: 134731 RVA: 0x0048CEFB File Offset: 0x0048B0FB
		// (set) Token: 0x06020E4C RID: 134732 RVA: 0x0048CF03 File Offset: 0x0048B103
		public ECompare Compare { get; set; }

		// Token: 0x06020E4D RID: 134733 RVA: 0x0048CF0C File Offset: 0x0048B10C
		public IQuestStateEqualConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.QuestId = 0;
			this.State = EQuestState.InActive;
			this.Compare = ECompare.Eq;
		}
	}
}
