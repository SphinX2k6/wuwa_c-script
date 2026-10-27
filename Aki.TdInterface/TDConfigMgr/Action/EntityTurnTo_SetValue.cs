using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001663 RID: 5731
	public class EntityTurnTo_SetValue
	{
		// Token: 0x04004CC3 RID: 19651
		public int EntityId;

		// Token: 0x04004CC4 RID: 19652
		[Nullable(1)]
		public IActorTurnToData Target;

		// Token: 0x04004CC5 RID: 19653
		public bool? UseLookAtForSmallAngle;
	}
}
