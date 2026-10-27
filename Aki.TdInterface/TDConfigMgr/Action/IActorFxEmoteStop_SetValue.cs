using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200176D RID: 5997
	public class IActorFxEmoteStop_SetValue
	{
		// Token: 0x040050CE RID: 20686
		public EActorFxEmoteType Type;

		// Token: 0x040050CF RID: 20687
		[Nullable(1)]
		public IActorFxEmoteStopSubType StopType;

		// Token: 0x040050D0 RID: 20688
		public float? DelayTime;
	}
}
