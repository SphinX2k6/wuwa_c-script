using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E6 RID: 742
	public class IDynamicPortal_SetValue
	{
		// Token: 0x04000C9A RID: 3226
		public EPortalType Type;

		// Token: 0x04000C9B RID: 3227
		public EPortalModel PortalModel;

		// Token: 0x04000C9C RID: 3228
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;
	}
}
