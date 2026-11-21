using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000068 RID: 104
	[NullableContext(1)]
	[Nullable(0)]
	public class StartupTimingLog
	{
		// Token: 0x040001CB RID: 459
		public string event_id = "17";

		// Token: 0x040001CC RID: 460
		public string s_step_id = "";

		// Token: 0x040001CD RID: 461
		[Nullable(2)]
		public string s_step_result;

		// Token: 0x040001CE RID: 462
		public int i_cost_time;

		// Token: 0x040001CF RID: 463
		public string os = "";

		// Token: 0x040001D0 RID: 464
		public string s_device_info = "";

		// Token: 0x040001D1 RID: 465
		public string s_cpu_info = "";

		// Token: 0x040001D2 RID: 466
		public string s_trace_id = "";

		// Token: 0x040001D3 RID: 467
		public string s_user_id = "";

		// Token: 0x040001D4 RID: 468
		public string s_device_id = "";

		// Token: 0x040001D5 RID: 469
		public int i_vulkan;

		// Token: 0x040001D6 RID: 470
		public string s_appversion = "";

		// Token: 0x040001D7 RID: 471
		public string s_launcher_version = "";

		// Token: 0x040001D8 RID: 472
		public string s_resource_version = "";
	}
}
