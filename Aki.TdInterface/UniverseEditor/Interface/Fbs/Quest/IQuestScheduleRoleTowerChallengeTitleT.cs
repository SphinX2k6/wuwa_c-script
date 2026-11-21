using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004476 RID: 17526
	public class IQuestScheduleRoleTowerChallengeTitleT
	{
		// Token: 0x170079A7 RID: 31143
		// (get) Token: 0x06019310 RID: 103184 RVA: 0x0039811F File Offset: 0x0039631F
		// (set) Token: 0x06019311 RID: 103185 RVA: 0x00398127 File Offset: 0x00396327
		public EQuestScheduleType Type { get; set; }

		// Token: 0x170079A8 RID: 31144
		// (get) Token: 0x06019312 RID: 103186 RVA: 0x00398130 File Offset: 0x00396330
		// (set) Token: 0x06019313 RID: 103187 RVA: 0x00398138 File Offset: 0x00396338
		public TRoleTowerChallengeTitleTypeUnion TitleType { get; set; }

		// Token: 0x06019314 RID: 103188 RVA: 0x00398141 File Offset: 0x00396341
		public IQuestScheduleRoleTowerChallengeTitleT()
		{
			this.Type = EQuestScheduleType.None;
			this.TitleType = null;
		}
	}
}
