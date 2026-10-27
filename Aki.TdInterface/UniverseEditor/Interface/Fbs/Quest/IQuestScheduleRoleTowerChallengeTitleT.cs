using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004035 RID: 16437
	public class IQuestScheduleRoleTowerChallengeTitleT
	{
		// Token: 0x170073A5 RID: 29605
		// (get) Token: 0x06017C77 RID: 97399 RVA: 0x0036E32B File Offset: 0x0036C52B
		// (set) Token: 0x06017C78 RID: 97400 RVA: 0x0036E333 File Offset: 0x0036C533
		public EQuestScheduleType Type { get; set; }

		// Token: 0x170073A6 RID: 29606
		// (get) Token: 0x06017C79 RID: 97401 RVA: 0x0036E33C File Offset: 0x0036C53C
		// (set) Token: 0x06017C7A RID: 97402 RVA: 0x0036E344 File Offset: 0x0036C544
		public TRoleTowerChallengeTitleTypeUnion TitleType { get; set; }

		// Token: 0x06017C7B RID: 97403 RVA: 0x0036E34D File Offset: 0x0036C54D
		public IQuestScheduleRoleTowerChallengeTitleT()
		{
			this.Type = EQuestScheduleType.None;
			this.TitleType = null;
		}
	}
}
