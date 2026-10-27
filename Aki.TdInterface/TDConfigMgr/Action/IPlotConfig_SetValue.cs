using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D29 RID: 7465
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotConfig_SetValue
	{
		// Token: 0x04006096 RID: 24726
		public string EdPlotNode;

		// Token: 0x04006097 RID: 24727
		public bool EdPlotHandleJump;

		// Token: 0x04006098 RID: 24728
		public string EdPlotFileId;

		// Token: 0x04006099 RID: 24729
		public EVisualNovelLayout? EdPlotLayout;
	}
}
