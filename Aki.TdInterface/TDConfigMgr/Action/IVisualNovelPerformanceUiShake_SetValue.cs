using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209C RID: 8348
	public class IVisualNovelPerformanceUiShake_SetValue
	{
		// Token: 0x04006E31 RID: 28209
		public EVisualNovelPerformanceType Type;

		// Token: 0x04006E32 RID: 28210
		public float? StartTime;

		// Token: 0x04006E33 RID: 28211
		public EVisualNovelUiShakeType ShakeType;

		// Token: 0x04006E34 RID: 28212
		public EVisualNovelShakeIntensity Intensity;

		// Token: 0x04006E35 RID: 28213
		public float? Duration;

		// Token: 0x04006E36 RID: 28214
		[Nullable(2)]
		public string ScreenEffectDa;
	}
}
