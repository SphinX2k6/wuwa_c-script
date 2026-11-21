using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EC RID: 6380
	public class IActorFxEmotePlay_SetValue
	{
		// Token: 0x040054FC RID: 21756
		public EActorFxEmoteType Type;

		// Token: 0x040054FD RID: 21757
		public long FxEmoteId;

		// Token: 0x040054FE RID: 21758
		[Nullable(2)]
		public IActorFxEmoteOverrideConfig OverrideConfig;

		// Token: 0x040054FF RID: 21759
		public float? DelayTime;

		// Token: 0x04005500 RID: 21760
		public bool? LoopPlay;

		// Token: 0x04005501 RID: 21761
		public bool? KeepPlay;
	}
}
