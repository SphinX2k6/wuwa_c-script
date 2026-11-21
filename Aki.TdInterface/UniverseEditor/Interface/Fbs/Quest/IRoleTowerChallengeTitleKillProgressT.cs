using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004503 RID: 17667
	public class IRoleTowerChallengeTitleKillProgressT
	{
		// Token: 0x17007AFF RID: 31487
		// (get) Token: 0x0601991D RID: 104733 RVA: 0x003A5222 File Offset: 0x003A3422
		// (set) Token: 0x0601991E RID: 104734 RVA: 0x003A522A File Offset: 0x003A342A
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x0601991F RID: 104735 RVA: 0x003A5233 File Offset: 0x003A3433
		public IRoleTowerChallengeTitleKillProgressT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
