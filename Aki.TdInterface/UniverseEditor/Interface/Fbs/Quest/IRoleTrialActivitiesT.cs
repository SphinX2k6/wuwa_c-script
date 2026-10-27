using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E9 RID: 16617
	public class IRoleTrialActivitiesT
	{
		// Token: 0x17007522 RID: 29986
		// (get) Token: 0x0601837B RID: 99195 RVA: 0x0037CBDE File Offset: 0x0037ADDE
		// (set) Token: 0x0601837C RID: 99196 RVA: 0x0037CBE6 File Offset: 0x0037ADE6
		public EShowUiType Type { get; set; }

		// Token: 0x0601837D RID: 99197 RVA: 0x0037CBEF File Offset: 0x0037ADEF
		public IRoleTrialActivitiesT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
