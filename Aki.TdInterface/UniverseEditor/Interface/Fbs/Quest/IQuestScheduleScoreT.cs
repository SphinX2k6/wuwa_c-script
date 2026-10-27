using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004038 RID: 16440
	public class IQuestScheduleScoreT
	{
		// Token: 0x170073A9 RID: 29609
		// (get) Token: 0x06017C8B RID: 97419 RVA: 0x0036E4FA File Offset: 0x0036C6FA
		// (set) Token: 0x06017C8C RID: 97420 RVA: 0x0036E502 File Offset: 0x0036C702
		public EQuestScheduleType Type { get; set; }

		// Token: 0x06017C8D RID: 97421 RVA: 0x0036E50B File Offset: 0x0036C70B
		public IQuestScheduleScoreT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
