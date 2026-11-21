using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025F RID: 607
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdnScoreStep
	{
		// Token: 0x04000A1A RID: 2586
		public string Let = string.Empty;

		// Token: 0x04000A1B RID: 2587
		public string Op = string.Empty;

		// Token: 0x04000A1C RID: 2588
		public JsonElement A;

		// Token: 0x04000A1D RID: 2589
		public JsonElement? B;

		// Token: 0x04000A1E RID: 2590
		[Nullable(2)]
		public string Note;
	}
}
