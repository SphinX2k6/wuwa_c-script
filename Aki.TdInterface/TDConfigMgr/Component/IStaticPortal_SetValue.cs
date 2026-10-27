using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000722 RID: 1826
	public class IStaticPortal_SetValue
	{
		// Token: 0x04001A96 RID: 6806
		public EPortalType Type;

		// Token: 0x04001A97 RID: 6807
		public EPortalModel PortalModel;

		// Token: 0x04001A98 RID: 6808
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;

		// Token: 0x04001A99 RID: 6809
		public int LinkPortalEntityId;

		// Token: 0x04001A9A RID: 6810
		public bool? IsStreamSource;
	}
}
