using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB1 RID: 16305
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotFlow
	{
		// Token: 0x06029427 RID: 168999 RVA: 0x00B97814 File Offset: 0x00B95A14
		public PlotFlow(string flowListName, int? flowId, int? stateId)
		{
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
		}

		// Token: 0x0401675E RID: 91998
		public string FlowListName;

		// Token: 0x0401675F RID: 91999
		public int? FlowId;

		// Token: 0x04016760 RID: 92000
		public int? StateId;
	}
}
