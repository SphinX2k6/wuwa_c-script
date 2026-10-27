using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E59 RID: 7769
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowCenterTextParams_SetValue
	{
		// Token: 0x0400634E RID: 25422
		public float? TotalTime;

		// Token: 0x0400634F RID: 25423
		public ITextStyle TextStyle;

		// Token: 0x04006350 RID: 25424
		public string BgImageId;

		// Token: 0x04006351 RID: 25425
		public bool? IsMulLine;

		// Token: 0x04006352 RID: 25426
		public bool? IsManualNext;

		// Token: 0x04006353 RID: 25427
		public bool? IsCancelAutoLine;
	}
}
