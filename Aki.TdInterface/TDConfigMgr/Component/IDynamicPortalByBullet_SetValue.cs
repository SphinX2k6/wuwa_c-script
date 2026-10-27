using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E8 RID: 744
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalByBullet_SetValue
	{
		// Token: 0x04000CA9 RID: 3241
		public EDynamicPortalCreateType Type;

		// Token: 0x04000CAA RID: 3242
		public IDynamicPortalConfig PortalA;

		// Token: 0x04000CAB RID: 3243
		public IDynamicPortalConfig PortalB;

		// Token: 0x04000CAC RID: 3244
		public EPortalModel? InitOpenPortal;

		// Token: 0x04000CAD RID: 3245
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;

		// Token: 0x04000CAE RID: 3246
		public IDynamicBulletConfig TypeA;

		// Token: 0x04000CAF RID: 3247
		public IDynamicBulletConfig TypeB;
	}
}
