using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DE RID: 8414
	public class MoveSceneItem_SetValue
	{
		// Token: 0x04006EB8 RID: 28344
		public int EntityId;

		// Token: 0x04006EB9 RID: 28345
		public bool? StopBeforeMove;

		// Token: 0x04006EBA RID: 28346
		[Nullable(1)]
		public IMoveSceneItemType MoveConfig;

		// Token: 0x04006EBB RID: 28347
		public bool? BypassClientResponse;
	}
}
