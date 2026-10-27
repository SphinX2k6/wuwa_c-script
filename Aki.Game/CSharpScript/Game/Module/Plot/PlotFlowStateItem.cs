using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE5 RID: 20453
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotFlowStateItem
	{
		// Token: 0x0603459B RID: 214427 RVA: 0x00C4D710 File Offset: 0x00C4B910
		public PlotFlowStateItem(int pbDataId, string flowListName, int flowId, int stateId)
		{
			this.PbDataId = pbDataId;
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
		}

		// Token: 0x0401BD77 RID: 114039
		public int PbDataId;

		// Token: 0x0401BD78 RID: 114040
		public string FlowListName;

		// Token: 0x0401BD79 RID: 114041
		public int FlowId;

		// Token: 0x0401BD7A RID: 114042
		public int StateId;
	}
}
