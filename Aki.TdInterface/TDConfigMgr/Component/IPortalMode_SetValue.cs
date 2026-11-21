using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B4 RID: 1716
	public class IPortalMode_SetValue
	{
		// Token: 0x0400192F RID: 6447
		public EPortalType Type;

		// Token: 0x04001930 RID: 6448
		public EPortalModel PortalModel;

		// Token: 0x04001931 RID: 6449
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;
	}
}
