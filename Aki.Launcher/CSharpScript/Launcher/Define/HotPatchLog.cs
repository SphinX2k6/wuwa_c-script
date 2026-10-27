using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200023F RID: 575
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchLog
	{
		// Token: 0x0400094B RID: 2379
		public string event_id = "2";

		// Token: 0x0400094C RID: 2380
		public string s_client_version = "";

		// Token: 0x0400094D RID: 2381
		public string event_time = "";

		// Token: 0x0400094E RID: 2382
		public string s_step_id = "";

		// Token: 0x0400094F RID: 2383
		[Nullable(2)]
		public string s_url_prefix;

		// Token: 0x04000950 RID: 2384
		[Nullable(2)]
		public string s_file_name;

		// Token: 0x04000951 RID: 2385
		[Nullable(2)]
		public string i_try_count;

		// Token: 0x04000952 RID: 2386
		[Nullable(2)]
		public string i_download_state;

		// Token: 0x04000953 RID: 2387
		[Nullable(2)]
		public string s_update_type;

		// Token: 0x04000954 RID: 2388
		[Nullable(2)]
		public string s_step_result;

		// Token: 0x04000955 RID: 2389
		public int? i_latest_time;

		// Token: 0x04000956 RID: 2390
		public int? i_out_date_time;

		// Token: 0x04000957 RID: 2391
		[Nullable(2)]
		public string s_download_speed;

		// Token: 0x04000958 RID: 2392
		public int? i_download_size;

		// Token: 0x04000959 RID: 2393
		public float? f_download_spend;

		// Token: 0x0400095A RID: 2394
		[Nullable(2)]
		public string device_id;

		// Token: 0x0400095B RID: 2395
		public string client_platform = "";

		// Token: 0x0400095C RID: 2396
		public string net_status = "";

		// Token: 0x0400095D RID: 2397
		public string s_version = "";

		// Token: 0x0400095E RID: 2398
		public string s_device_id = "";

		// Token: 0x0400095F RID: 2399
		public long? l_trigger_time;

		// Token: 0x04000960 RID: 2400
		public string unique_id = "";

		// Token: 0x04000961 RID: 2401
		public string player_id = "";
	}
}
