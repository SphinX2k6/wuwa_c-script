using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165D RID: 5725
	public class ClientPreEnableSubLevels_SetValue
	{
		// Token: 0x04004A75 RID: 19061
		public List<string> EnableLevels;

		// Token: 0x04004A76 RID: 19062
		public List<string> DisableLevels;

		// Token: 0x04004A77 RID: 19063
		[Nullable(2)]
		public IEnableSubLevelTransitionWithSceneCapture TransitionOption;

		// Token: 0x04004A78 RID: 19064
		public bool? IsWaitForEnableComplete;
	}
}
