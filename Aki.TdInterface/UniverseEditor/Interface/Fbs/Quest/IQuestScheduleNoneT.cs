using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200402F RID: 16431
	public class IQuestScheduleNoneT
	{
		// Token: 0x1700739C RID: 29596
		// (get) Token: 0x06017C48 RID: 97352 RVA: 0x0036DDA6 File Offset: 0x0036BFA6
		// (set) Token: 0x06017C49 RID: 97353 RVA: 0x0036DDAE File Offset: 0x0036BFAE
		public EQuestScheduleType Type { get; set; }

		// Token: 0x06017C4A RID: 97354 RVA: 0x0036DDB7 File Offset: 0x0036BFB7
		public IQuestScheduleNoneT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
