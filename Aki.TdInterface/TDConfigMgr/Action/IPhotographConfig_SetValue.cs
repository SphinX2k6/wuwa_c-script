using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CED RID: 7405
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographConfig_SetValue
	{
		// Token: 0x04005FFE RID: 24574
		public List<int> PhotoTargets;

		// Token: 0x04005FFF RID: 24575
		public IPhotographPlayerPerform PlayerPerform;

		// Token: 0x04006000 RID: 24576
		public IPhotographCameraParams CameraParams;
	}
}
