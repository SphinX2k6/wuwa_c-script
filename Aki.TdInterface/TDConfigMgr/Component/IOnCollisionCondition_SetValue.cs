using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000610 RID: 1552
	public class IOnCollisionCondition_SetValue
	{
		// Token: 0x04001730 RID: 5936
		public EBulletCreateCondition Type;

		// Token: 0x04001731 RID: 5937
		public long BulletId;

		// Token: 0x04001732 RID: 5938
		[Nullable(2)]
		public ITriggerCountConfig TriggerCount;
	}
}
