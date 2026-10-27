using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017C1 RID: 6081
	[NullableContext(2)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetRangeEntity_SetValue
	{
		// Token: 0x04005278 RID: 21112
		public EFixedLookAtTargetType Type;

		// Token: 0x04005279 RID: 21113
		public int EntityId;

		// Token: 0x0400527A RID: 21114
		public IMovingCameraTimeParams MovingTimeParams;

		// Token: 0x0400527B RID: 21115
		public PlayFlow MovingFlow;

		// Token: 0x0400527C RID: 21116
		public ICutCameraConfig CutCameraConfig;
	}
}
