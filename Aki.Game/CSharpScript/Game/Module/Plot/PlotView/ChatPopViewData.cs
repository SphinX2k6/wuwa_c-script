using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200503F RID: 20543
	public class ChatPopViewData
	{
		// Token: 0x0401C046 RID: 114758
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> FlowId;

		// Token: 0x0401C047 RID: 114759
		[Nullable(2)]
		public Action OnAllShownCallback;

		// Token: 0x0401C048 RID: 114760
		public int Condition;

		// Token: 0x0401C049 RID: 114761
		public int? ParentViewId;
	}
}
