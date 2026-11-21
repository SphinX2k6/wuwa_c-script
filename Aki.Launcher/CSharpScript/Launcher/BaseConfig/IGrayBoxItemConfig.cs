using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200026E RID: 622
	[NullableContext(1)]
	[Nullable(0)]
	public class IGrayBoxItemConfig
	{
		// Token: 0x04000A40 RID: 2624
		public string Name;

		// Token: 0x04000A41 RID: 2625
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int? Divisor;

		// Token: 0x04000A42 RID: 2626
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int? Left;

		// Token: 0x04000A43 RID: 2627
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int? Right;

		// Token: 0x04000A44 RID: 2628
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> Ids;
	}
}
