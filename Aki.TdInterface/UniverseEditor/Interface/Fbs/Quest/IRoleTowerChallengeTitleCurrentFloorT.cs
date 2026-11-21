using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004500 RID: 17664
	public class IRoleTowerChallengeTitleCurrentFloorT
	{
		// Token: 0x17007AFC RID: 31484
		// (get) Token: 0x0601990B RID: 104715 RVA: 0x003A50AA File Offset: 0x003A32AA
		// (set) Token: 0x0601990C RID: 104716 RVA: 0x003A50B2 File Offset: 0x003A32B2
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x0601990D RID: 104717 RVA: 0x003A50BB File Offset: 0x003A32BB
		public IRoleTowerChallengeTitleCurrentFloorT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
