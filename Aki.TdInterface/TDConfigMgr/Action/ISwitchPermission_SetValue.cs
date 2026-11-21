using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213D RID: 8509
	public class ISwitchPermission_SetValue
	{
		// Token: 0x04006AE1 RID: 27361
		public ESwitchSubLevelsType Type;

		// Token: 0x04006AE2 RID: 27362
		public bool IsAllowClientSwitch;

		// Token: 0x04006AE3 RID: 27363
		public List<string> Levels;
	}
}
