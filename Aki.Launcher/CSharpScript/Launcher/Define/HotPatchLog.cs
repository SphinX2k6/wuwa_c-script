using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000244 RID: 580
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchLog
	{
		// Token: 0x0400098D RID: 2445
		public string event_id = "2";

		// Token: 0x0400098E RID: 2446
		public string s_client_version = "";

		// Token: 0x0400098F RID: 2447
		public string event_time = "";

		// Token: 0x04000990 RID: 2448
		public string s_step_id = "";

		// Token: 0x04000991 RID: 2449
		[Nullable(2)]
		public string s_url_prefix;

		// Token: 0x04000992 RID: 2450
		[Nullable(2)]
		public string s_file_name;

		// Token: 0x04000993 RID: 2451
		[Nullable(2)]
		public string i_try_count;

		// Token: 0x04000994 RID: 2452
		[Nullable(2)]
		public string i_download_state;

		// Token: 0x04000995 RID: 2453
		[Nullable(2)]
		public string s_update_type;

		// Token: 0x04000996 RID: 2454
		[Nullable(2)]
		public string s_step_result;

		// Token: 0x04000997 RID: 2455
		public int? i_latest_time;

		// Token: 0x04000998 RID: 2456
		public int? i_out_date_time;

		// Token: 0x04000999 RID: 2457
		[Nullable(2)]
		public string s_download_speed;

		// Token: 0x0400099A RID: 2458
		public int? i_download_size;

		// Token: 0x0400099B RID: 2459
		public float? f_download_spend;

		// Token: 0x0400099C RID: 2460
		[Nullable(2)]
		public string device_id;

		// Token: 0x0400099D RID: 2461
		public string client_platform = "";

		// Token: 0x0400099E RID: 2462
		public string net_status = "";

		// Token: 0x0400099F RID: 2463
		public string s_version = "";

		// Token: 0x040009A0 RID: 2464
		public string s_device_id = "";

		// Token: 0x040009A1 RID: 2465
		public long? l_trigger_time;

		// Token: 0x040009A2 RID: 2466
		public string unique_id = "";

		// Token: 0x040009A3 RID: 2467
		public string player_id = "";

		// Token: 0x040009A4 RID: 2468
		public int? i_need_update;

		// Token: 0x040009A5 RID: 2469
		public int? i_type = new int?(0);

		// Token: 0x040009A6 RID: 2470
		public int? i_download_time = new int?(0);

		// Token: 0x040009A7 RID: 2471
		public int? i_download_type = new int?(0);

		// Token: 0x040009A8 RID: 2472
		public int? i_avg_speed = new int?(0);

		// Token: 0x040009A9 RID: 2473
		public int? i_resource_size = new int?(0);
	}
}
