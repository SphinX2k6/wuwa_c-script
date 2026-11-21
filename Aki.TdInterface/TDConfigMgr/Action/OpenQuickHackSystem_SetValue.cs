using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234E RID: 9038
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenQuickHackSystem_SetValue
	{
		// Token: 0x04007524 RID: 29988
		public int DeviceId;

		// Token: 0x04007525 RID: 29989
		public List<int> Entities;

		// Token: 0x04007526 RID: 29990
		public IOpenQuickHackCameraConfig CameraConfig;
	}
}
