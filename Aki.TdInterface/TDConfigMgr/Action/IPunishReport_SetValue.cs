using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D69 RID: 7529
	[NullableContext(1)]
	[Nullable(0)]
	public class IPunishReport_SetValue
	{
		// Token: 0x04006123 RID: 24867
		public ECommonTipType Type;

		// Token: 0x04006124 RID: 24868
		public string MainText;

		// Token: 0x04006125 RID: 24869
		public string SubText;

		// Token: 0x04006126 RID: 24870
		public EPunishReportShowType? ShowType;
	}
}
