using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FAF RID: 16303
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotFlowStateItem
	{
		// Token: 0x06029424 RID: 168996 RVA: 0x00B97758 File Offset: 0x00B95958
		public PlotFlowStateItem(int pbDataId, string flowListName, int flowId, int stateId)
		{
			this.PbDataId = pbDataId;
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
		}

		// Token: 0x04016752 RID: 91986
		public int PbDataId;

		// Token: 0x04016753 RID: 91987
		public string FlowListName;

		// Token: 0x04016754 RID: 91988
		public int FlowId;

		// Token: 0x04016755 RID: 91989
		public int StateId;
	}
}
