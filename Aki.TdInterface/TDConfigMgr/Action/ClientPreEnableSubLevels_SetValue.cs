using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001502 RID: 5378
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientPreEnableSubLevels_SetValue
	{
		// Token: 0x040046D6 RID: 18134
		public List<string> EnableLevels;

		// Token: 0x040046D7 RID: 18135
		public List<string> DisableLevels;

		// Token: 0x040046D8 RID: 18136
		[Nullable(2)]
		public IEnableSubLevelTransitionWithSceneCapture TransitionOption;

		// Token: 0x040046D9 RID: 18137
		public bool? IsWaitForEnableComplete;
	}
}
