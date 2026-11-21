using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x02004325 RID: 17189
	[NullableContext(1)]
	[Nullable(0)]
	public class PerfExceedDataBase
	{
		// Token: 0x0401777F RID: 96127
		public string s_metric = "";

		// Token: 0x04017780 RID: 96128
		public string s_player_id = "";

		// Token: 0x04017781 RID: 96129
		public string s_unique_id = "";

		// Token: 0x04017782 RID: 96130
		public string s_world_level = "";

		// Token: 0x04017783 RID: 96131
		public string s_player_level = "";

		// Token: 0x04017784 RID: 96132
		public string s_region = "";

		// Token: 0x04017785 RID: 96133
		public string s_client_platform = "";

		// Token: 0x04017786 RID: 96134
		public string s_net_status = "";

		// Token: 0x04017787 RID: 96135
		public string s_device_id = "";

		// Token: 0x04017788 RID: 96136
		public string s_client_version = "";

		// Token: 0x04017789 RID: 96137
		public string s_platform = "";

		// Token: 0x0401778A RID: 96138
		public long i_duration_ms;

		// Token: 0x0401778B RID: 96139
		public string s_report_time = "";

		// Token: 0x0401778C RID: 96140
		public int i_role_id;

		// Token: 0x0401778D RID: 96141
		public string s_map_id = "";

		// Token: 0x0401778E RID: 96142
		public string s_map_name = "";

		// Token: 0x0401778F RID: 96143
		public string s_area_name = "";

		// Token: 0x04017790 RID: 96144
		public float f_pos_x;

		// Token: 0x04017791 RID: 96145
		public float f_pos_y;

		// Token: 0x04017792 RID: 96146
		public float f_pos_z;

		// Token: 0x04017793 RID: 96147
		public float f_cam_yaw;

		// Token: 0x04017794 RID: 96148
		public float f_cam_pitch;

		// Token: 0x04017795 RID: 96149
		public int i_total_active;

		// Token: 0x04017796 RID: 96150
		public int i_total_scalability;

		// Token: 0x04017797 RID: 96151
		public int i_total_particles;

		// Token: 0x04017798 RID: 96152
		public int i_total_emitters;

		// Token: 0x04017799 RID: 96153
		public int i_threshold;

		// Token: 0x0401779A RID: 96154
		public string s_top1_asset = "";

		// Token: 0x0401779B RID: 96155
		public int i_top1_count;

		// Token: 0x0401779C RID: 96156
		public string s_top10_json = "";
	}
}
