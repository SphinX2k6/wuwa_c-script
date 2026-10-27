using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025A RID: 602
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdnScoreStep
	{
		// Token: 0x040009CE RID: 2510
		public string Let = string.Empty;

		// Token: 0x040009CF RID: 2511
		public string Op = string.Empty;

		// Token: 0x040009D0 RID: 2512
		public JsonElement A;

		// Token: 0x040009D1 RID: 2513
		public JsonElement? B;

		// Token: 0x040009D2 RID: 2514
		[Nullable(2)]
		public string Note;
	}
}
