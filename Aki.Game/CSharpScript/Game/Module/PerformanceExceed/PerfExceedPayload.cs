using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x02004324 RID: 17188
	[NullableContext(1)]
	[Nullable(0)]
	public class PerfExceedPayload
	{
		// Token: 0x0401777D RID: 96125
		public string EventName = "";

		// Token: 0x0401777E RID: 96126
		public Dictionary<string, object> Fields = new Dictionary<string, object>();
	}
}
