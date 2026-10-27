using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E63 RID: 7779
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkCameraMotionTween_SetValue
	{
		// Token: 0x04006372 RID: 25458
		public EShowTalkCameraMotionType Type;

		// Token: 0x04006373 RID: 25459
		public ICameraParams Start;

		// Token: 0x04006374 RID: 25460
		public ICameraParams End;

		// Token: 0x04006375 RID: 25461
		public float Duration;

		// Token: 0x04006376 RID: 25462
		public EEaseType? EaseType;

		// Token: 0x04006377 RID: 25463
		[Nullable(2)]
		public IFlowCameraShake CamShake;
	}
}
