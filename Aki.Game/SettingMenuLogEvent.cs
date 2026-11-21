using System;
using System.Runtime.CompilerServices;

// Token: 0x020015A6 RID: 5542
[NullableContext(1)]
[Nullable(0)]
public class SettingMenuLogEvent : PlayerCommonLogData
{
	// Token: 0x170014A5 RID: 5285
	// (get) Token: 0x0600DD1C RID: 56604 RVA: 0x00417038 File Offset: 0x00415238
	// (set) Token: 0x0600DD1D RID: 56605 RVA: 0x00417040 File Offset: 0x00415240
	public override string event_id { get; set; } = "1017";

	// Token: 0x04007C61 RID: 31841
	private const int SettingLogDefaultValue = 99999;

	// Token: 0x04007C63 RID: 31843
	public int i_image_quality;

	// Token: 0x04007C64 RID: 31844
	public int i_display_mode;

	// Token: 0x04007C65 RID: 31845
	public string s_resolution = "";

	// Token: 0x04007C66 RID: 31846
	public int i_brightness;

	// Token: 0x04007C67 RID: 31847
	public int i_highest_fps;

	// Token: 0x04007C68 RID: 31848
	public int i_shadow_quality;

	// Token: 0x04007C69 RID: 31849
	public int i_niagara_quality;

	// Token: 0x04007C6A RID: 31850
	public int i_fsr;

	// Token: 0x04007C6B RID: 31851
	public int i_image_detail;

	// Token: 0x04007C6C RID: 31852
	public int i_scene_ao;

	// Token: 0x04007C6D RID: 31853
	public int i_volume_Fog;

	// Token: 0x04007C6E RID: 31854
	public int i_volume_light;

	// Token: 0x04007C6F RID: 31855
	public int i_motion_blur;

	// Token: 0x04007C70 RID: 31856
	public int i_anti_aliasing;

	// Token: 0x04007C71 RID: 31857
	public int i_pcv_sync;

	// Token: 0x04007C72 RID: 31858
	public int i_horizontal_view_sensitivity;

	// Token: 0x04007C73 RID: 31859
	public int i_vertical_view_sensitivity;

	// Token: 0x04007C74 RID: 31860
	public int i_aim_horizontal_view_sensitivity;

	// Token: 0x04007C75 RID: 31861
	public int i_aim_vertical_view_sensitivity;

	// Token: 0x04007C76 RID: 31862
	public float f_camera_shake_strength;

	// Token: 0x04007C77 RID: 31863
	public int i_common_spring_arm_length;

	// Token: 0x04007C78 RID: 31864
	public int i_fight_spring_arm_length;

	// Token: 0x04007C79 RID: 31865
	public int i_reset_focus_enable;

	// Token: 0x04007C7A RID: 31866
	public int i_side_step_camera_enable;

	// Token: 0x04007C7B RID: 31867
	public int i_soft_lock_camera_enable;

	// Token: 0x04007C7C RID: 31868
	public int i_joystick_shake_strength;

	// Token: 0x04007C7D RID: 31869
	public int i_joystick_shake_type;

	// Token: 0x04007C7E RID: 31870
	public float f_walk_or_run_rate;

	// Token: 0x04007C7F RID: 31871
	public int i_advice_setting;

	// Token: 0x04007C80 RID: 31872
	public int i_enemy_id;

	// Token: 0x04007C81 RID: 31873
	public string i_filter_list = "";

	// Token: 0x04007C82 RID: 31874
	public int i_image_mode;

	// Token: 0x04007C83 RID: 31875
	public int eyeprotect_mode;

	// Token: 0x04007C84 RID: 31876
	public string eyeprotect_list = "";

	// Token: 0x04007C85 RID: 31877
	public int i_crowd_density;

	// Token: 0x04007C86 RID: 31878
	public int i_hit_material_effects;

	// Token: 0x04007C87 RID: 31879
	public int i_auto_adjust;

	// Token: 0x04007C88 RID: 31880
	public int i_damage_numbers;

	// Token: 0x04007C89 RID: 31881
	public int i_fluttering_animation;

	// Token: 0x04007C8A RID: 31882
	public int i_cinematic_quality;

	// Token: 0x04007C8B RID: 31883
	public int i_teammate_effects;

	// Token: 0x04007C8C RID: 31884
	public int i_injury_effects;

	// Token: 0x04007C8D RID: 31885
	public int i_environment_interaction;

	// Token: 0x04007C8E RID: 31886
	public int i_foliage_blur;

	// Token: 0x04007C8F RID: 31887
	public int i_auto_exposure;

	// Token: 0x04007C90 RID: 31888
	public int i_hdr;

	// Token: 0x04007C91 RID: 31889
	public int i_ui_Brightness;

	// Token: 0x04007C92 RID: 31890
	public int i_peak_Brightness;

	// Token: 0x04007C93 RID: 31891
	public int i_recommend_config;

	// Token: 0x04007C94 RID: 31892
	public int anisotropic_sampling = 99999;

	// Token: 0x04007C95 RID: 31893
	public int render_distance = 99999;

	// Token: 0x04007C96 RID: 31894
	public int dlss = 99999;

	// Token: 0x04007C97 RID: 31895
	public int fsr = 99999;

	// Token: 0x04007C98 RID: 31896
	public int xess = 99999;

	// Token: 0x04007C99 RID: 31897
	public int super_resolution = 99999;

	// Token: 0x04007C9A RID: 31898
	public int ray_tracing = 99999;

	// Token: 0x04007C9B RID: 31899
	public int rt_reflection = 99999;

	// Token: 0x04007C9C RID: 31900
	public int rt_global_illumination = 99999;

	// Token: 0x04007C9D RID: 31901
	public int rt_shadow = 99999;

	// Token: 0x04007C9E RID: 31902
	public int vulkan = 99999;

	// Token: 0x04007C9F RID: 31903
	public int pc_frame_interpolation = 99999;

	// Token: 0x04007CA0 RID: 31904
	public int mob_frame_interpolation = 99999;

	// Token: 0x04007CA1 RID: 31905
	public int self_dev_interpolation = 99999;

	// Token: 0x04007CA2 RID: 31906
	public int game_language = 99999;

	// Token: 0x04007CA3 RID: 31907
	public int game_voice = 99999;

	// Token: 0x04007CA4 RID: 31908
	public int i_asset_grade;

	// Token: 0x04007CA5 RID: 31909
	public float f_wp_loadingRangeScale = 99999f;
}
