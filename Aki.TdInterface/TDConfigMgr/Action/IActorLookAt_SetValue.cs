using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200177D RID: 6013
	public class IActorLookAt_SetValue
	{
		// Token: 0x040050F3 RID: 20723
		public int ActorIndex;

		// Token: 0x040050F4 RID: 20724
		[Nullable(1)]
		public IActorLookAtData Target;

		// Token: 0x040050F5 RID: 20725
		public float? DelayTime;

		// Token: 0x040050F6 RID: 20726
		public float? LookAtSpeedRate;
	}
}
