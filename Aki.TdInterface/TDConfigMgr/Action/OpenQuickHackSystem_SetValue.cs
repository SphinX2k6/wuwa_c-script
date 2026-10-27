using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020ED RID: 8429
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenQuickHackSystem_SetValue
	{
		// Token: 0x04006EF0 RID: 28400
		public int DeviceId;

		// Token: 0x04006EF1 RID: 28401
		public List<int> Entities;

		// Token: 0x04006EF2 RID: 28402
		public IOpenQuickHackCameraConfig CameraConfig;
	}
}
