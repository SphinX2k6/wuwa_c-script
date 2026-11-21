using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004473 RID: 17523
	public class IQuestScheduleProgressValueT
	{
		// Token: 0x170079A2 RID: 31138
		// (get) Token: 0x060192F5 RID: 103157 RVA: 0x00397D74 File Offset: 0x00395F74
		// (set) Token: 0x060192F6 RID: 103158 RVA: 0x00397D7C File Offset: 0x00395F7C
		public EQuestScheduleType Type { get; set; }

		// Token: 0x170079A3 RID: 31139
		// (get) Token: 0x060192F7 RID: 103159 RVA: 0x00397D85 File Offset: 0x00395F85
		// (set) Token: 0x060192F8 RID: 103160 RVA: 0x00397D8D File Offset: 0x00395F8D
		public int TargetProgressEntity { get; set; }

		// Token: 0x060192F9 RID: 103161 RVA: 0x00397D96 File Offset: 0x00395F96
		public IQuestScheduleProgressValueT()
		{
			this.Type = EQuestScheduleType.None;
			this.TargetProgressEntity = 0;
		}
	}
}
