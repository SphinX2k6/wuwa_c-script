using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000051 RID: 81
	[NullableContext(1)]
	[Nullable(0)]
	public class InitialMobileResCleanUpViewStateLog : HotPatchLogData
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0000C633 File Offset: 0x0000A833
		public InitialMobileResCleanUpViewStateLog(int canCleanUpSpace, string uniqueId, string traceId, int chooseByUser, [Nullable(2)] string playerId = null) : base("1712", uniqueId, playerId)
		{
			this.i_remaining_space = canCleanUpSpace;
			this.s_trace_id = traceId;
			this.i_type = chooseByUser;
		}

		// Token: 0x0400014F RID: 335
		public int i_remaining_space;

		// Token: 0x04000150 RID: 336
		public int i_type;

		// Token: 0x04000151 RID: 337
		public string s_trace_id = "";
	}
}
