using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001094 RID: 4244
	public class IFastReturnGravityEntityPos_SetValue
	{
		// Token: 0x04003832 RID: 14386
		public EFastReturnPosType Type;

		// Token: 0x04003833 RID: 14387
		public int EntityId;

		// Token: 0x04003834 RID: 14388
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;
	}
}
