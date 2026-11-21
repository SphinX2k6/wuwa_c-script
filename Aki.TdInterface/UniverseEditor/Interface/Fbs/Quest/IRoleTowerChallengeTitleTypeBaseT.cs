using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004509 RID: 17673
	public class IRoleTowerChallengeTitleTypeBaseT
	{
		// Token: 0x17007B05 RID: 31493
		// (get) Token: 0x06019941 RID: 104769 RVA: 0x003A5512 File Offset: 0x003A3712
		// (set) Token: 0x06019942 RID: 104770 RVA: 0x003A551A File Offset: 0x003A371A
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x06019943 RID: 104771 RVA: 0x003A5523 File Offset: 0x003A3723
		public IRoleTowerChallengeTitleTypeBaseT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
