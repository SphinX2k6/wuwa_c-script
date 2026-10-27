using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F6A RID: 3946
	public class IFastReturnGravityEntityPos_SetValue
	{
		// Token: 0x04003501 RID: 13569
		public EFastReturnPosType Type;

		// Token: 0x04003502 RID: 13570
		public int EntityId;

		// Token: 0x04003503 RID: 13571
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;
	}
}
