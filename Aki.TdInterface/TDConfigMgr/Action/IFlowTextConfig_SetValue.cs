using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA4 RID: 6820
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTextConfig_SetValue
	{
		// Token: 0x04005A13 RID: 23059
		public string Text;

		// Token: 0x04005A14 RID: 23060
		[Nullable(2)]
		public string PlotLineKey;

		// Token: 0x04005A15 RID: 23061
		public string StringKey;

		// Token: 0x04005A16 RID: 23062
		public int FlowListId;

		// Token: 0x04005A17 RID: 23063
		public bool? IsNoPlotText;
	}
}
