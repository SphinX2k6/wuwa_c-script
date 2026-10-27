using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008F RID: 143
	[NullableContext(1)]
	[Nullable(0)]
	public class PakKeyLog
	{
		// Token: 0x040002F9 RID: 761
		public string event_id = "15";

		// Token: 0x040002FA RID: 762
		public string s_client_version = "";

		// Token: 0x040002FB RID: 763
		public string event_time = "";

		// Token: 0x040002FC RID: 764
		public string s_step_id = "";

		// Token: 0x040002FD RID: 765
		[Nullable(2)]
		public string s_step_result;

		// Token: 0x040002FE RID: 766
		[Nullable(2)]
		public string s_url_prefix;

		// Token: 0x040002FF RID: 767
		[Nullable(2)]
		public string s_file_name;

		// Token: 0x04000300 RID: 768
		[Nullable(2)]
		public string i_try_count;

		// Token: 0x04000301 RID: 769
		public long? l_trigger_time;

		// Token: 0x04000302 RID: 770
		public string device_id = "";

		// Token: 0x04000303 RID: 771
		public string s_version = "";

		// Token: 0x04000304 RID: 772
		public string net_status = "";

		// Token: 0x04000305 RID: 773
		public string client_platform = "";

		// Token: 0x04000306 RID: 774
		[Nullable(2)]
		public string s_hash;
	}
}
