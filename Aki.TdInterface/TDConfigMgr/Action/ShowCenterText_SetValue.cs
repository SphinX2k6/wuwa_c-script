using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246C RID: 9324
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowCenterText_SetValue
	{
		// Token: 0x0400783A RID: 30778
		public int TextId;

		// Token: 0x0400783B RID: 30779
		public string TidCenterText;

		// Token: 0x0400783C RID: 30780
		public string PlotLineKey;

		// Token: 0x0400783D RID: 30781
		public float? TotalTime;

		// Token: 0x0400783E RID: 30782
		public ITextStyle TextStyle;

		// Token: 0x0400783F RID: 30783
		public string BgImageId;

		// Token: 0x04007840 RID: 30784
		public bool? IsMulLine;

		// Token: 0x04007841 RID: 30785
		public bool? IsManualNext;

		// Token: 0x04007842 RID: 30786
		public bool? IsCancelAutoLine;
	}
}
