using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFC RID: 7932
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographConfig_SetValue
	{
		// Token: 0x04006571 RID: 25969
		public List<int> PhotoTargets;

		// Token: 0x04006572 RID: 25970
		public IPhotographPlayerPerform PlayerPerform;

		// Token: 0x04006573 RID: 25971
		public IPhotographCameraParams CameraParams;
	}
}
