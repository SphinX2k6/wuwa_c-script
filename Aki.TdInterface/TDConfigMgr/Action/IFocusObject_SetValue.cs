using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA8 RID: 6824
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusObject_SetValue
	{
		// Token: 0x04005A22 RID: 23074
		public IFocusObjectRotationConfig RotationConfig;

		// Token: 0x04005A23 RID: 23075
		public IFocusObjectCameraConfig CameraConfig;

		// Token: 0x04005A24 RID: 23076
		public int? LeaveIndex;
	}
}
