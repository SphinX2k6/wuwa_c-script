using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200503E RID: 20542
	[NullableContext(1)]
	[Nullable(0)]
	public class ChatItemData
	{
		// Token: 0x0401C03F RID: 114751
		public string Icon = "";

		// Token: 0x0401C040 RID: 114752
		public string Name = "";

		// Token: 0x0401C041 RID: 114753
		public string Message = "";

		// Token: 0x0401C042 RID: 114754
		public string Time = "";

		// Token: 0x0401C043 RID: 114755
		[Nullable(2)]
		public string TidTalk;

		// Token: 0x0401C044 RID: 114756
		public bool IsCompleted;

		// Token: 0x0401C045 RID: 114757
		public ChatItemDisplayMode? DisplayMode;
	}
}
