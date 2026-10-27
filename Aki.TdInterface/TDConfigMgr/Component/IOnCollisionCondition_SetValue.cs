using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A7 RID: 1447
	public class IOnCollisionCondition_SetValue
	{
		// Token: 0x040015C2 RID: 5570
		public EBulletCreateCondition Type;

		// Token: 0x040015C3 RID: 5571
		public long BulletId;

		// Token: 0x040015C4 RID: 5572
		[Nullable(2)]
		public ITriggerCountConfig TriggerCount;
	}
}
