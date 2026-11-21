using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000057 RID: 87
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNetworkDetectionResultLog : LauncherNetworkDetectionBaseLog
	{
		// Token: 0x04000169 RID: 361
		public new string event_id = "1066";

		// Token: 0x0400016A RID: 362
		public float f_avg_ping;

		// Token: 0x0400016B RID: 363
		public int i_cost_time;

		// Token: 0x0400016C RID: 364
		public int i_pocket_lossrt;

		// Token: 0x0400016D RID: 365
		public int i_result_id;

		// Token: 0x0400016E RID: 366
		public int i_type;

		// Token: 0x0400016F RID: 367
		public string s_trace_id = "";
	}
}
