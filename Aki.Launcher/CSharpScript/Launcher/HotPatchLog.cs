using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000049 RID: 73
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchLog
	{
		// Token: 0x04000112 RID: 274
		public string event_id = "2";

		// Token: 0x04000113 RID: 275
		public string s_client_version = "";

		// Token: 0x04000114 RID: 276
		public string event_time = "";

		// Token: 0x04000115 RID: 277
		public string s_step_id = "";

		// Token: 0x04000116 RID: 278
		[Nullable(2)]
		public string s_url_prefix;

		// Token: 0x04000117 RID: 279
		[Nullable(2)]
		public string s_file_name;

		// Token: 0x04000118 RID: 280
		[Nullable(2)]
		public string i_try_count;

		// Token: 0x04000119 RID: 281
		[Nullable(2)]
		public string i_download_state;

		// Token: 0x0400011A RID: 282
		[Nullable(2)]
		public string s_update_type;

		// Token: 0x0400011B RID: 283
		[Nullable(2)]
		public string s_step_result;

		// Token: 0x0400011C RID: 284
		public long? i_latest_time;

		// Token: 0x0400011D RID: 285
		public long? i_out_date_time;

		// Token: 0x0400011E RID: 286
		public long? l_trigger_time;

		// Token: 0x0400011F RID: 287
		[Nullable(2)]
		public string s_download_speed;

		// Token: 0x04000120 RID: 288
		public int? i_download_size;

		// Token: 0x04000121 RID: 289
		public float? f_download_spend;

		// Token: 0x04000122 RID: 290
		[Nullable(2)]
		public string device_id;

		// Token: 0x04000123 RID: 291
		public string client_platform = "";

		// Token: 0x04000124 RID: 292
		public string net_status = "";

		// Token: 0x04000125 RID: 293
		public string s_version = "";

		// Token: 0x04000126 RID: 294
		public string s_device_id = "";

		// Token: 0x04000127 RID: 295
		public string unique_id = "";

		// Token: 0x04000128 RID: 296
		public string player_id = "";
	}
}
