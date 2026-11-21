using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004482 RID: 17538
	public class IQuestScheduleTowerChallengeTitleT
	{
		// Token: 0x170079CE RID: 31182
		// (get) Token: 0x060193AB RID: 103339 RVA: 0x003998BE File Offset: 0x00397ABE
		// (set) Token: 0x060193AC RID: 103340 RVA: 0x003998C6 File Offset: 0x00397AC6
		public EQuestScheduleType Type { get; set; }

		// Token: 0x060193AD RID: 103341 RVA: 0x003998CF File Offset: 0x00397ACF
		public IQuestScheduleTowerChallengeTitleT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
