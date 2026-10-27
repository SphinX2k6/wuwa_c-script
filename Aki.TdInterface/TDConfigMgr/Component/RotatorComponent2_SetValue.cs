using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000886 RID: 2182
	public class RotatorComponent2_SetValue
	{
		// Token: 0x04001FF2 RID: 8178
		public bool? Disabled;

		// Token: 0x04001FF3 RID: 8179
		public bool? EdIsLocked;

		// Token: 0x04001FF4 RID: 8180
		[Nullable(1)]
		public List<IStateRotationConfig> Config;
	}
}
