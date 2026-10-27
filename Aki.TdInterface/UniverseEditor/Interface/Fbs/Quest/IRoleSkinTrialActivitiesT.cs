using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040BC RID: 16572
	public class IRoleSkinTrialActivitiesT
	{
		// Token: 0x170074F3 RID: 29939
		// (get) Token: 0x06018258 RID: 98904 RVA: 0x0037AFE2 File Offset: 0x003791E2
		// (set) Token: 0x06018259 RID: 98905 RVA: 0x0037AFEA File Offset: 0x003791EA
		public EShowUiType Type { get; set; }

		// Token: 0x0601825A RID: 98906 RVA: 0x0037AFF3 File Offset: 0x003791F3
		public IRoleSkinTrialActivitiesT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
