using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000333 RID: 819
	public class IDynamicPortalCreateMode_SetValue
	{
		// Token: 0x04000DA6 RID: 3494
		public EDynamicPortalCreateType Type;

		// Token: 0x04000DA7 RID: 3495
		public IDynamicPortalConfig PortalA;

		// Token: 0x04000DA8 RID: 3496
		public IDynamicPortalConfig PortalB;

		// Token: 0x04000DA9 RID: 3497
		public EPortalModel? InitOpenPortal;

		// Token: 0x04000DAA RID: 3498
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;
	}
}
