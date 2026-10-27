using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB9 RID: 15801
	public class IConditionTextT
	{
		// Token: 0x17006D11 RID: 27921
		// (get) Token: 0x060160B3 RID: 90291 RVA: 0x0033027E File Offset: 0x0032E47E
		// (set) Token: 0x060160B4 RID: 90292 RVA: 0x00330286 File Offset: 0x0032E486
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17006D12 RID: 27922
		// (get) Token: 0x060160B5 RID: 90293 RVA: 0x0033028F File Offset: 0x0032E48F
		// (set) Token: 0x060160B6 RID: 90294 RVA: 0x00330297 File Offset: 0x0032E497
		public string TidTitle { get; set; }

		// Token: 0x17006D13 RID: 27923
		// (get) Token: 0x060160B7 RID: 90295 RVA: 0x003302A0 File Offset: 0x0032E4A0
		// (set) Token: 0x060160B8 RID: 90296 RVA: 0x003302A8 File Offset: 0x0032E4A8
		public TQuestScheduleUnion QuestScheduleType { get; set; }

		// Token: 0x17006D14 RID: 27924
		// (get) Token: 0x060160B9 RID: 90297 RVA: 0x003302B1 File Offset: 0x0032E4B1
		// (set) Token: 0x060160BA RID: 90298 RVA: 0x003302B9 File Offset: 0x0032E4B9
		public IProgressBarT ProgressBar { get; set; }

		// Token: 0x060160BB RID: 90299 RVA: 0x003302C2 File Offset: 0x0032E4C2
		public IConditionTextT()
		{
			this.Condition = null;
			this.TidTitle = null;
			this.QuestScheduleType = null;
			this.ProgressBar = null;
		}
	}
}
