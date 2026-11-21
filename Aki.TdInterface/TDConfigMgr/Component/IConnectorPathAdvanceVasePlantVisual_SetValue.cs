using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BD RID: 701
	public class IConnectorPathAdvanceVasePlantVisual_SetValue
	{
		// Token: 0x04000C0B RID: 3083
		public EConnectorPathAdvanceVisualType Type;

		// Token: 0x04000C0C RID: 3084
		public float? ScatterWidth;

		// Token: 0x04000C0D RID: 3085
		public float? ScatterDensity;

		// Token: 0x04000C0E RID: 3086
		public float? Scale;

		// Token: 0x04000C0F RID: 3087
		public bool? SnapToSurface;

		// Token: 0x04000C10 RID: 3088
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> PathRtList;
	}
}
