using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001632 RID: 5682
	public class ChangeLiftTarget_SetValue
	{
		// Token: 0x04004A1A RID: 18970
		public bool IsSelf;

		// Token: 0x04004A1B RID: 18971
		[Nullable(2)]
		public ILiftMoveType MoveType;

		// Token: 0x04004A1C RID: 18972
		public int? EntityId;

		// Token: 0x04004A1D RID: 18973
		public int Location;
	}
}
