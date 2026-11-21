using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200400D RID: 16397
	[NullableContext(1)]
	[Nullable(0)]
	public class ChatItemData
	{
		// Token: 0x04016A62 RID: 92770
		public string Icon = "";

		// Token: 0x04016A63 RID: 92771
		public string Name = "";

		// Token: 0x04016A64 RID: 92772
		public string Message = "";

		// Token: 0x04016A65 RID: 92773
		public string Time = "";

		// Token: 0x04016A66 RID: 92774
		[Nullable(2)]
		public string TidTalk;

		// Token: 0x04016A67 RID: 92775
		public bool IsCompleted;

		// Token: 0x04016A68 RID: 92776
		public ChatItemDisplayMode? DisplayMode;
	}
}
