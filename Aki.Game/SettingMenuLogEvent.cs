using System;
using System.Runtime.CompilerServices;

// Token: 0x020020CF RID: 8399
[NullableContext(1)]
[Nullable(0)]
public class SettingMenuLogEvent : PlayerCommonLogData
{
	// Token: 0x17001478 RID: 5240
	// (get) Token: 0x060108AC RID: 67756 RVA: 0x0040A930 File Offset: 0x00408B30
	// (set) Token: 0x060108AD RID: 67757 RVA: 0x0040A938 File Offset: 0x00408B38
	public override string event_id { get; set; } = "1017";

	// Token: 0x04007B63 RID: 31587
	private const int SettingLogDefaultValue = 99999;

	// Token: 0x04007B65 RID: 31589
	public int i_image_quality;

	// Token: 0x04007B66 RID: 31590
	public int i_display_mode;

	// Token: 0x04007B67 RID: 31591
	public string s_resolution = "";

	// Token: 0x04007B68 RID: 31592
	public int i_brightness;

	// Token: 0x04007B69 RID: 31593
	public int i_highest_fps;

	// Token: 0x04007B6A RID: 31594
	public int i_shadow_quality;

	// Token: 0x04007B6B RID: 31595
	public int i_niagara_quality;

	// Token: 0x04007B6C RID: 31596
	public int i_fsr;

	// Token: 0x04007B6D RID: 31597
	public int i_image_detail;

	// Token: 0x04007B6E RID: 31598
	public int i_scene_ao;

	// Token: 0x04007B6F RID: 31599
	public int i_volume_Fog;

	// Token: 0x04007B70 RID: 31600
	public int i_volume_light;

	// Token: 0x04007B71 RID: 31601
	public int i_motion_blur;

	// Token: 0x04007B72 RID: 31602
	public int i_anti_aliasing;

	// Token: 0x04007B73 RID: 31603
	public int i_pcv_sync;

	// Token: 0x04007B74 RID: 31604
	public int i_horizontal_view_sensitivity;

	// Token: 0x04007B75 RID: 31605
	public int i_vertical_view_sensitivity;

	// Token: 0x04007B76 RID: 31606
	public int i_aim_horizontal_view_sensitivity;

	// Token: 0x04007B77 RID: 31607
	public int i_aim_vertical_view_sensitivity;

	// Token: 0x04007B78 RID: 31608
	public float f_camera_shake_strength;

	// Token: 0x04007B79 RID: 31609
	public int i_common_spring_arm_length;

	// Token: 0x04007B7A RID: 31610
	public int i_fight_spring_arm_length;

	// Token: 0x04007B7B RID: 31611
	public int i_reset_focus_enable;

	// Token: 0x04007B7C RID: 31612
	public int i_side_step_camera_enable;

	// Token: 0x04007B7D RID: 31613
	public int i_soft_lock_camera_enable;

	// Token: 0x04007B7E RID: 31614
	public int i_joystick_shake_strength;

	// Token: 0x04007B7F RID: 31615
	public int i_joystick_shake_type;

	// Token: 0x04007B80 RID: 31616
	public float f_walk_or_run_rate;

	// Token: 0x04007B81 RID: 31617
	public int i_advice_setting;

	// Token: 0x04007B82 RID: 31618
	public int i_enemy_id;

	// Token: 0x04007B83 RID: 31619
	public string i_filter_list = "";

	// Token: 0x04007B84 RID: 31620
	public int i_image_mode;

	// Token: 0x04007B85 RID: 31621
	public int eyeprotect_mode;

	// Token: 0x04007B86 RID: 31622
	public string eyeprotect_list = "";

	// Token: 0x04007B87 RID: 31623
	public int i_crowd_density;

	// Token: 0x04007B88 RID: 31624
	public int i_hit_material_effects;

	// Token: 0x04007B89 RID: 31625
	public int i_auto_adjust;

	// Token: 0x04007B8A RID: 31626
	public int i_damage_numbers;

	// Token: 0x04007B8B RID: 31627
	public int i_fluttering_animation;

	// Token: 0x04007B8C RID: 31628
	public int i_cinematic_quality;

	// Token: 0x04007B8D RID: 31629
	public int i_teammate_effects;

	// Token: 0x04007B8E RID: 31630
	public int i_injury_effects;

	// Token: 0x04007B8F RID: 31631
	public int i_environment_interaction;

	// Token: 0x04007B90 RID: 31632
	public int i_foliage_blur;

	// Token: 0x04007B91 RID: 31633
	public int i_auto_exposure;

	// Token: 0x04007B92 RID: 31634
	public int i_hdr;

	// Token: 0x04007B93 RID: 31635
	public int i_ui_Brightness;

	// Token: 0x04007B94 RID: 31636
	public int i_peak_Brightness;

	// Token: 0x04007B95 RID: 31637
	public int i_recommend_config;

	// Token: 0x04007B96 RID: 31638
	public int anisotropic_sampling = 99999;

	// Token: 0x04007B97 RID: 31639
	public int render_distance = 99999;

	// Token: 0x04007B98 RID: 31640
	public int dlss = 99999;

	// Token: 0x04007B99 RID: 31641
	public int fsr = 99999;

	// Token: 0x04007B9A RID: 31642
	public int xess = 99999;

	// Token: 0x04007B9B RID: 31643
	public int super_resolution = 99999;

	// Token: 0x04007B9C RID: 31644
	public int ray_tracing = 99999;

	// Token: 0x04007B9D RID: 31645
	public int rt_reflection = 99999;

	// Token: 0x04007B9E RID: 31646
	public int rt_global_illumination = 99999;

	// Token: 0x04007B9F RID: 31647
	public int rt_shadow = 99999;

	// Token: 0x04007BA0 RID: 31648
	public int vulkan = 99999;

	// Token: 0x04007BA1 RID: 31649
	public int pc_frame_interpolation = 99999;

	// Token: 0x04007BA2 RID: 31650
	public int mob_frame_interpolation = 99999;

	// Token: 0x04007BA3 RID: 31651
	public int self_dev_interpolation = 99999;

	// Token: 0x04007BA4 RID: 31652
	public int game_language = 99999;

	// Token: 0x04007BA5 RID: 31653
	public int game_voice = 99999;

	// Token: 0x04007BA6 RID: 31654
	public int i_asset_grade;
}
