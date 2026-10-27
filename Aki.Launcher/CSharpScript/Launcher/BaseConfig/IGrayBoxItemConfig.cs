using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000267 RID: 615
	[NullableContext(1)]
	[Nullable(0)]
	public class IGrayBoxItemConfig
	{
		// Token: 0x040009F2 RID: 2546
		public string Name;

		// Token: 0x040009F3 RID: 2547
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int? Divisor;

		// Token: 0x040009F4 RID: 2548
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int? Left;

		// Token: 0x040009F5 RID: 2549
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int? Right;

		// Token: 0x040009F6 RID: 2550
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> Ids;
	}
}
