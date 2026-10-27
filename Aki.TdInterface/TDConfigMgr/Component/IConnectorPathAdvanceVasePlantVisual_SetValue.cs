using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027A RID: 634
	public class IConnectorPathAdvanceVasePlantVisual_SetValue
	{
		// Token: 0x04000B2A RID: 2858
		public EConnectorPathAdvanceVisualType Type;

		// Token: 0x04000B2B RID: 2859
		public float? ScatterWidth;

		// Token: 0x04000B2C RID: 2860
		public float? ScatterDensity;

		// Token: 0x04000B2D RID: 2861
		public float? Scale;

		// Token: 0x04000B2E RID: 2862
		public bool? SnapToSurface;

		// Token: 0x04000B2F RID: 2863
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> PathRtList;
	}
}
