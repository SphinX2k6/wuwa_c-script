using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EC RID: 748
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalCreateMode_SetValue
	{
		// Token: 0x04000CBC RID: 3260
		public EDynamicPortalCreateType Type;

		// Token: 0x04000CBD RID: 3261
		public IDynamicPortalConfig PortalA;

		// Token: 0x04000CBE RID: 3262
		public IDynamicPortalConfig PortalB;

		// Token: 0x04000CBF RID: 3263
		public EPortalModel? InitOpenPortal;

		// Token: 0x04000CC0 RID: 3264
		[Nullable(2)]
		public IPortalRenderConfig RenderConfig;
	}
}
