using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F4 RID: 17652
	public class IRogueRandomEventT
	{
		// Token: 0x17007AEC RID: 31468
		// (get) Token: 0x060198AE RID: 104622 RVA: 0x003A4582 File Offset: 0x003A2782
		// (set) Token: 0x060198AF RID: 104623 RVA: 0x003A458A File Offset: 0x003A278A
		public EShowUiType Type { get; set; }

		// Token: 0x060198B0 RID: 104624 RVA: 0x003A4593 File Offset: 0x003A2793
		public IRogueRandomEventT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
