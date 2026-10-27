using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001795 RID: 6037
	public class IActorTurnTo_SetValue
	{
		// Token: 0x0400512E RID: 20782
		public int ActorIndex;

		// Token: 0x0400512F RID: 20783
		[Nullable(1)]
		public IActorTurnToData Target;

		// Token: 0x04005130 RID: 20784
		public float? DelayTime;

		// Token: 0x04005131 RID: 20785
		public bool? UseLookAtForSmallAngle;

		// Token: 0x04005132 RID: 20786
		public bool? UpdatePosCache;
	}
}
