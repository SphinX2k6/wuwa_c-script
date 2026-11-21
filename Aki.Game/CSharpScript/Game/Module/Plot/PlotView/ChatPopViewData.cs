using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200400E RID: 16398
	public class ChatPopViewData
	{
		// Token: 0x04016A69 RID: 92777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> FlowId;

		// Token: 0x04016A6A RID: 92778
		[Nullable(2)]
		public Action OnAllShownCallback;

		// Token: 0x04016A6B RID: 92779
		public int Condition;

		// Token: 0x04016A6C RID: 92780
		public int? ParentViewId;
	}
}
