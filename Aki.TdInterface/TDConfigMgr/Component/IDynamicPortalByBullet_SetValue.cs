using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032F RID: 815
	public class IDynamicPortalByBullet_SetValue
	{
		// Token: 0x04000D93 RID: 3475
		public EDynamicPortalCreateType Type;

		// Token: 0x04000D94 RID: 3476
		public IDynamicPortalConfig PortalA;

		// Token: 0x04000D95 RID: 3477
		public IDynamicPortalConfig PortalB;

		// Token: 0x04000D96 RID: 3478
		public EPortalModel? InitOpenPortal;

		// Token: 0x04000D97 RID: 3479
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;

		// Token: 0x04000D98 RID: 3480
		public IDynamicBulletConfig TypeA;

		// Token: 0x04000D99 RID: 3481
		public IDynamicBulletConfig TypeB;
	}
}
