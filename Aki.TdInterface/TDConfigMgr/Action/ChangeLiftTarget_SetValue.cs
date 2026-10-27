using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D9 RID: 5337
	public class ChangeLiftTarget_SetValue
	{
		// Token: 0x0400467F RID: 18047
		public bool IsSelf;

		// Token: 0x04004680 RID: 18048
		[Nullable(2)]
		public ILiftMoveType MoveType;

		// Token: 0x04004681 RID: 18049
		public int? EntityId;

		// Token: 0x04004682 RID: 18050
		public int Location;
	}
}
