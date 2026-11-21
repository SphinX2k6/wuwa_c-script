using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5B RID: 7259
	public class IFoxPushBox_SetValue
	{
		// Token: 0x04005EC9 RID: 24265
		public ELeisureInteract Type;

		// Token: 0x04005ECA RID: 24266
		public int EntityId;

		// Token: 0x04005ECB RID: 24267
		public int CollisionRadius;

		// Token: 0x04005ECC RID: 24268
		public int SplineEntityId;

		// Token: 0x04005ECD RID: 24269
		[Nullable(2)]
		public string SendEntityEventOnSplineFinish;
	}
}
