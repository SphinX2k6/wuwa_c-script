using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABC RID: 6844
	public class IFoxPushBox_SetValue
	{
		// Token: 0x04005A50 RID: 23120
		public ELeisureInteract Type;

		// Token: 0x04005A51 RID: 23121
		public int EntityId;

		// Token: 0x04005A52 RID: 23122
		public int CollisionRadius;

		// Token: 0x04005A53 RID: 23123
		public int SplineEntityId;

		// Token: 0x04005A54 RID: 23124
		[Nullable(2)]
		public string SendEntityEventOnSplineFinish;
	}
}
