using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001916 RID: 6422
	public class IActorTurnTo_SetValue
	{
		// Token: 0x04005564 RID: 21860
		public int ActorIndex;

		// Token: 0x04005565 RID: 21861
		public IActorTurnToData Target;

		// Token: 0x04005566 RID: 21862
		public float? DelayTime;

		// Token: 0x04005567 RID: 21863
		public bool? UseLookAtForSmallAngle;

		// Token: 0x04005568 RID: 21864
		public bool? UpdatePosCache;
	}
}
