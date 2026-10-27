using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A3 RID: 6051
	public class IActorVisibility_SetValue
	{
		// Token: 0x0400514D RID: 20813
		public int ActorIndex;

		// Token: 0x0400514E RID: 20814
		public EActorVisibilityPlayMode PlayMode;

		// Token: 0x0400514F RID: 20815
		[Nullable(1)]
		public IActorVisibilityEffectDefault Effect;

		// Token: 0x04005150 RID: 20816
		public float? FadeDuration;

		// Token: 0x04005151 RID: 20817
		public float? DelayTime;
	}
}
