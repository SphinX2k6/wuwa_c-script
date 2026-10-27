using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000054 RID: 84
	[NullableContext(1)]
	[Nullable(0)]
	public class MobileResCleanUpFinishStateLog : HotPatchLogData
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public MobileResCleanUpFinishStateLog(string uniqueId, string traceId, [Nullable(2)] string playerId = null) : base("1714", uniqueId, playerId)
		{
			this.s_trace_id = traceId;
		}

		// Token: 0x04000158 RID: 344
		public string s_trace_id = "";
	}
}
