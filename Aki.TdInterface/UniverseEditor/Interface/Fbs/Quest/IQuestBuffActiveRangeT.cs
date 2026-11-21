using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200440D RID: 17421
	public class IQuestBuffActiveRangeT
	{
		// Token: 0x17007868 RID: 30824
		// (get) Token: 0x06018D7E RID: 101758 RVA: 0x0038AFE2 File Offset: 0x003891E2
		// (set) Token: 0x06018D7F RID: 101759 RVA: 0x0038AFEA File Offset: 0x003891EA
		public IQuestBuffActiveCenterRangeT QuestBuffActiveCenterRange { get; set; }

		// Token: 0x17007869 RID: 30825
		// (get) Token: 0x06018D80 RID: 101760 RVA: 0x0038AFF3 File Offset: 0x003891F3
		// (set) Token: 0x06018D81 RID: 101761 RVA: 0x0038AFFB File Offset: 0x003891FB
		public List<int> QuestBuffActiveRangeEntities { get; set; }

		// Token: 0x1700786A RID: 30826
		// (get) Token: 0x06018D82 RID: 101762 RVA: 0x0038B004 File Offset: 0x00389204
		// (set) Token: 0x06018D83 RID: 101763 RVA: 0x0038B00C File Offset: 0x0038920C
		public List<int> QuestBuffActiveRangeAreaIds { get; set; }

		// Token: 0x1700786B RID: 30827
		// (get) Token: 0x06018D84 RID: 101764 RVA: 0x0038B015 File Offset: 0x00389215
		// (set) Token: 0x06018D85 RID: 101765 RVA: 0x0038B01D File Offset: 0x0038921D
		public byte NullMask { get; set; }

		// Token: 0x06018D86 RID: 101766 RVA: 0x0038B026 File Offset: 0x00389226
		public IQuestBuffActiveRangeT()
		{
			this.QuestBuffActiveCenterRange = null;
			this.QuestBuffActiveRangeEntities = null;
			this.QuestBuffActiveRangeAreaIds = null;
			this.NullMask = 0;
		}
	}
}
