using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007C3 RID: 1987
	public class IStaticPortal_SetValue
	{
		// Token: 0x04001C9B RID: 7323
		public EPortalType Type;

		// Token: 0x04001C9C RID: 7324
		public EPortalModel PortalModel;

		// Token: 0x04001C9D RID: 7325
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;

		// Token: 0x04001C9E RID: 7326
		public int LinkPortalEntityId;

		// Token: 0x04001C9F RID: 7327
		public bool? IsStreamSource;
	}
}
