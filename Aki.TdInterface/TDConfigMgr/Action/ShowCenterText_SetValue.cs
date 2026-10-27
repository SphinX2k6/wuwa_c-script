using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002201 RID: 8705
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowCenterText_SetValue
	{
		// Token: 0x040071F1 RID: 29169
		public int TextId;

		// Token: 0x040071F2 RID: 29170
		public string TidCenterText;

		// Token: 0x040071F3 RID: 29171
		public string PlotLineKey;

		// Token: 0x040071F4 RID: 29172
		public float? TotalTime;

		// Token: 0x040071F5 RID: 29173
		public ITextStyle TextStyle;

		// Token: 0x040071F6 RID: 29174
		public string BgImageId;

		// Token: 0x040071F7 RID: 29175
		public bool? IsMulLine;

		// Token: 0x040071F8 RID: 29176
		public bool? IsManualNext;

		// Token: 0x040071F9 RID: 29177
		public bool? IsCancelAutoLine;
	}
}
