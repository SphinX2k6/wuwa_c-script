using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A38 RID: 31288
	public class ISwitchPermissionT
	{
		// Token: 0x1700E53D RID: 58685
		// (get) Token: 0x0603722E RID: 225838 RVA: 0x0075DD1D File Offset: 0x0075BF1D
		// (set) Token: 0x0603722F RID: 225839 RVA: 0x0075DD25 File Offset: 0x0075BF25
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x1700E53E RID: 58686
		// (get) Token: 0x06037230 RID: 225840 RVA: 0x0075DD2E File Offset: 0x0075BF2E
		// (set) Token: 0x06037231 RID: 225841 RVA: 0x0075DD36 File Offset: 0x0075BF36
		public bool IsAllowClientSwitch { get; set; }

		// Token: 0x1700E53F RID: 58687
		// (get) Token: 0x06037232 RID: 225842 RVA: 0x0075DD3F File Offset: 0x0075BF3F
		// (set) Token: 0x06037233 RID: 225843 RVA: 0x0075DD47 File Offset: 0x0075BF47
		public List<string> Levels { get; set; }

		// Token: 0x06037234 RID: 225844 RVA: 0x0075DD50 File Offset: 0x0075BF50
		public ISwitchPermissionT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
			this.IsAllowClientSwitch = false;
			this.Levels = null;
		}
	}
}
