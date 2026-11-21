using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E30 RID: 7728
	public class IMoveToEntity_SetValue
	{
		// Token: 0x04006368 RID: 25448
		public EMoveSceneItemType Type;

		// Token: 0x04006369 RID: 25449
		public int EntityId;

		// Token: 0x0400636A RID: 25450
		[Nullable(2)]
		public ISceneItemMoveMotionType MoveMotion;
	}
}
