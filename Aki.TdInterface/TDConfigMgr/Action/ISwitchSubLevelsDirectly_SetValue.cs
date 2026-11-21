using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002143 RID: 8515
	public class ISwitchSubLevelsDirectly_SetValue
	{
		// Token: 0x04006AEF RID: 27375
		public ESwitchSubLevelsType Type;

		// Token: 0x04006AF0 RID: 27376
		public List<string> LoadLevels;

		// Token: 0x04006AF1 RID: 27377
		public List<string> UnloadLevels;

		// Token: 0x04006AF2 RID: 27378
		public int? TeleportEntityId;

		// Token: 0x04006AF3 RID: 27379
		public bool? IsWaitForSwitchComplete;
	}
}
