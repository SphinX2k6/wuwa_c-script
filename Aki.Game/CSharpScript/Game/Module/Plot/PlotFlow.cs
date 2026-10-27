using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE7 RID: 20455
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotFlow
	{
		// Token: 0x0603459E RID: 214430 RVA: 0x00C4D7CC File Offset: 0x00C4B9CC
		public PlotFlow(string flowListName, int? flowId, int? stateId)
		{
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
		}

		// Token: 0x0401BD83 RID: 114051
		public string FlowListName;

		// Token: 0x0401BD84 RID: 114052
		public int? FlowId;

		// Token: 0x0401BD85 RID: 114053
		public int? StateId;
	}
}
