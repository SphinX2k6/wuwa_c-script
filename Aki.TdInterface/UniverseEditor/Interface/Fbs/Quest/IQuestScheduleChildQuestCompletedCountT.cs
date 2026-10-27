using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200401A RID: 16410
	public class IQuestScheduleChildQuestCompletedCountT
	{
		// Token: 0x17007364 RID: 29540
		// (get) Token: 0x06017B51 RID: 97105 RVA: 0x0036B703 File Offset: 0x00369903
		// (set) Token: 0x06017B52 RID: 97106 RVA: 0x0036B70B File Offset: 0x0036990B
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007365 RID: 29541
		// (get) Token: 0x06017B53 RID: 97107 RVA: 0x0036B714 File Offset: 0x00369914
		// (set) Token: 0x06017B54 RID: 97108 RVA: 0x0036B71C File Offset: 0x0036991C
		public List<int> AssociatedChildQuestIds { get; set; }

		// Token: 0x06017B55 RID: 97109 RVA: 0x0036B725 File Offset: 0x00369925
		public IQuestScheduleChildQuestCompletedCountT()
		{
			this.Type = EQuestScheduleType.None;
			this.AssociatedChildQuestIds = null;
		}
	}
}
