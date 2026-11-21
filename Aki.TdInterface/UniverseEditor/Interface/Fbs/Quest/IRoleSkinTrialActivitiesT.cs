using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044FD RID: 17661
	public class IRoleSkinTrialActivitiesT
	{
		// Token: 0x17007AF9 RID: 31481
		// (get) Token: 0x060198F9 RID: 104697 RVA: 0x003A4F32 File Offset: 0x003A3132
		// (set) Token: 0x060198FA RID: 104698 RVA: 0x003A4F3A File Offset: 0x003A313A
		public EShowUiType Type { get; set; }

		// Token: 0x060198FB RID: 104699 RVA: 0x003A4F43 File Offset: 0x003A3143
		public IRoleSkinTrialActivitiesT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
