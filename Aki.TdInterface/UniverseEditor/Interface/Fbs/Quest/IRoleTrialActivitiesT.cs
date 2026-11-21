using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200452A RID: 17706
	public class IRoleTrialActivitiesT
	{
		// Token: 0x17007B28 RID: 31528
		// (get) Token: 0x06019A1C RID: 104988 RVA: 0x003A6B2E File Offset: 0x003A4D2E
		// (set) Token: 0x06019A1D RID: 104989 RVA: 0x003A6B36 File Offset: 0x003A4D36
		public EShowUiType Type { get; set; }

		// Token: 0x06019A1E RID: 104990 RVA: 0x003A6B3F File Offset: 0x003A4D3F
		public IRoleTrialActivitiesT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
