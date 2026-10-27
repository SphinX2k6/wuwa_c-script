using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000617 RID: 1559
	public class IPortalMode_SetValue
	{
		// Token: 0x0400173D RID: 5949
		public EPortalType Type;

		// Token: 0x0400173E RID: 5950
		public EPortalModel PortalModel;

		// Token: 0x0400173F RID: 5951
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;
	}
}
