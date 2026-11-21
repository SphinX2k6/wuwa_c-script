using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208E RID: 8334
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowCenterTextParams_SetValue
	{
		// Token: 0x04006932 RID: 26930
		public float? TotalTime;

		// Token: 0x04006933 RID: 26931
		public ITextStyle TextStyle;

		// Token: 0x04006934 RID: 26932
		public string BgImageId;

		// Token: 0x04006935 RID: 26933
		public bool? IsMulLine;

		// Token: 0x04006936 RID: 26934
		public bool? IsManualNext;

		// Token: 0x04006937 RID: 26935
		public bool? IsCancelAutoLine;
	}
}
