using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C39 RID: 7225
	public class IMoveToEntity_SetValue
	{
		// Token: 0x04005E31 RID: 24113
		public EMoveSceneItemType Type;

		// Token: 0x04005E32 RID: 24114
		public int EntityId;

		// Token: 0x04005E33 RID: 24115
		[Nullable(2)]
		public ISceneItemMoveMotionType MoveMotion;
	}
}
