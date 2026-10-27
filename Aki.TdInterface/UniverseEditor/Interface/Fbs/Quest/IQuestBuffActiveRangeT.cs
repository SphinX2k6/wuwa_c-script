using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FCC RID: 16332
	public class IQuestBuffActiveRangeT
	{
		// Token: 0x17007268 RID: 29288
		// (get) Token: 0x060176EB RID: 95979 RVA: 0x003612BA File Offset: 0x0035F4BA
		// (set) Token: 0x060176EC RID: 95980 RVA: 0x003612C2 File Offset: 0x0035F4C2
		public IQuestBuffActiveCenterRangeT QuestBuffActiveCenterRange { get; set; }

		// Token: 0x17007269 RID: 29289
		// (get) Token: 0x060176ED RID: 95981 RVA: 0x003612CB File Offset: 0x0035F4CB
		// (set) Token: 0x060176EE RID: 95982 RVA: 0x003612D3 File Offset: 0x0035F4D3
		public List<int> QuestBuffActiveRangeEntities { get; set; }

		// Token: 0x1700726A RID: 29290
		// (get) Token: 0x060176EF RID: 95983 RVA: 0x003612DC File Offset: 0x0035F4DC
		// (set) Token: 0x060176F0 RID: 95984 RVA: 0x003612E4 File Offset: 0x0035F4E4
		public List<int> QuestBuffActiveRangeAreaIds { get; set; }

		// Token: 0x1700726B RID: 29291
		// (get) Token: 0x060176F1 RID: 95985 RVA: 0x003612ED File Offset: 0x0035F4ED
		// (set) Token: 0x060176F2 RID: 95986 RVA: 0x003612F5 File Offset: 0x0035F4F5
		public byte NullMask { get; set; }

		// Token: 0x060176F3 RID: 95987 RVA: 0x003612FE File Offset: 0x0035F4FE
		public IQuestBuffActiveRangeT()
		{
			this.QuestBuffActiveCenterRange = null;
			this.QuestBuffActiveRangeEntities = null;
			this.QuestBuffActiveRangeAreaIds = null;
			this.NullMask = 0;
		}
	}
}
