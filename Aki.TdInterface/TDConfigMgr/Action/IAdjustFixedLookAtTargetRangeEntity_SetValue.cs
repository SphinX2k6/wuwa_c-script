using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001944 RID: 6468
	[NullableContext(2)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetRangeEntity_SetValue
	{
		// Token: 0x040056B2 RID: 22194
		public EFixedLookAtTargetType Type;

		// Token: 0x040056B3 RID: 22195
		public int EntityId;

		// Token: 0x040056B4 RID: 22196
		public IMovingCameraTimeParams MovingTimeParams;

		// Token: 0x040056B5 RID: 22197
		public PlayFlow MovingFlow;

		// Token: 0x040056B6 RID: 22198
		public ICutCameraConfig CutCameraConfig;
	}
}
