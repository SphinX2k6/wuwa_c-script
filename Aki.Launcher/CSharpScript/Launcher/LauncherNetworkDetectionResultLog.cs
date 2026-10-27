using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000057 RID: 87
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNetworkDetectionResultLog : LauncherNetworkDetectionBaseLog
	{
		// Token: 0x04000162 RID: 354
		public new string event_id = "1066";

		// Token: 0x04000163 RID: 355
		public float f_avg_ping;

		// Token: 0x04000164 RID: 356
		public int i_cost_time;

		// Token: 0x04000165 RID: 357
		public int i_pocket_lossrt;

		// Token: 0x04000166 RID: 358
		public int i_result_id;

		// Token: 0x04000167 RID: 359
		public int i_type;

		// Token: 0x04000168 RID: 360
		public string s_trace_id = "";
	}
}
