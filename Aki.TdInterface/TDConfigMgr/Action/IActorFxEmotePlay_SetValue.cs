using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200176B RID: 5995
	public class IActorFxEmotePlay_SetValue
	{
		// Token: 0x040050C6 RID: 20678
		public EActorFxEmoteType Type;

		// Token: 0x040050C7 RID: 20679
		public long FxEmoteId;

		// Token: 0x040050C8 RID: 20680
		[Nullable(2)]
		public IActorFxEmoteOverrideConfig OverrideConfig;

		// Token: 0x040050C9 RID: 20681
		public float? DelayTime;

		// Token: 0x040050CA RID: 20682
		public bool? LoopPlay;

		// Token: 0x040050CB RID: 20683
		public bool? KeepPlay;
	}
}
