using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001092 RID: 4242
	public class IFastReturnEntityPos_SetValue
	{
		// Token: 0x0400382D RID: 14381
		public EFastReturnPosType Type;

		// Token: 0x0400382E RID: 14382
		public int EntityId;

		// Token: 0x0400382F RID: 14383
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;
	}
}
