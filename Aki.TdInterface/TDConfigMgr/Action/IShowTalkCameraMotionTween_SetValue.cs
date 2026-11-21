using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002098 RID: 8344
	public class IShowTalkCameraMotionTween_SetValue
	{
		// Token: 0x04006956 RID: 26966
		public EShowTalkCameraMotionType Type;

		// Token: 0x04006957 RID: 26967
		public ICameraParams Start;

		// Token: 0x04006958 RID: 26968
		public ICameraParams End;

		// Token: 0x04006959 RID: 26969
		public float Duration;

		// Token: 0x0400695A RID: 26970
		public EEaseType? EaseType;

		// Token: 0x0400695B RID: 26971
		[Nullable(2)]
		public IFlowCameraShake CamShake;
	}
}
