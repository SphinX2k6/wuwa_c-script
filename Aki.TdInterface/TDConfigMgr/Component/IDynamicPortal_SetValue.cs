using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032D RID: 813
	public class IDynamicPortal_SetValue
	{
		// Token: 0x04000D84 RID: 3460
		public EPortalType Type;

		// Token: 0x04000D85 RID: 3461
		public EPortalModel PortalModel;

		// Token: 0x04000D86 RID: 3462
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;
	}
}
