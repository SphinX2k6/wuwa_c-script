using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002098 RID: 8344
	public class IVisualNovelPerformanceSwitchAudioState_SetValue
	{
		// Token: 0x04006E25 RID: 28197
		public EVisualNovelPerformanceType Type;

		// Token: 0x04006E26 RID: 28198
		public float? StartTime;

		// Token: 0x04006E27 RID: 28199
		[Nullable(1)]
		public IAudioState AudioState;
	}
}
