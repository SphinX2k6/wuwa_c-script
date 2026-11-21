using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004470 RID: 17520
	public class IQuestScheduleNoneT
	{
		// Token: 0x1700799E RID: 31134
		// (get) Token: 0x060192E1 RID: 103137 RVA: 0x00397B9A File Offset: 0x00395D9A
		// (set) Token: 0x060192E2 RID: 103138 RVA: 0x00397BA2 File Offset: 0x00395DA2
		public EQuestScheduleType Type { get; set; }

		// Token: 0x060192E3 RID: 103139 RVA: 0x00397BAB File Offset: 0x00395DAB
		public IQuestScheduleNoneT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
