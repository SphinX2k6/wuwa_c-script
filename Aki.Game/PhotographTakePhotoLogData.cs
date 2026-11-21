using System;
using System.Runtime.CompilerServices;

// Token: 0x02001653 RID: 5715
[NullableContext(1)]
[Nullable(0)]
public class PhotographTakePhotoLogData : PlayerCommonLogData
{
	// Token: 0x17001548 RID: 5448
	// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x00418DB1 File Offset: 0x00416FB1
	// (set) Token: 0x0600DF13 RID: 57107 RVA: 0x00418DB9 File Offset: 0x00416FB9
	public override string event_id { get; set; } = "1941";

	// Token: 0x04007FAE RID: 32686
	public int i_area_id;

	// Token: 0x04007FAF RID: 32687
	public int i_father_area_id;

	// Token: 0x04007FB0 RID: 32688
	public float f_pos_x;

	// Token: 0x04007FB1 RID: 32689
	public float f_pos_y;

	// Token: 0x04007FB2 RID: 32690
	public float f_pos_z;

	// Token: 0x04007FB3 RID: 32691
	public int i_role_id;

	// Token: 0x04007FB4 RID: 32692
	public int i_mode;

	// Token: 0x04007FB5 RID: 32693
	public int i_rotate;

	// Token: 0x04007FB6 RID: 32694
	public int i_zoom;

	// Token: 0x04007FB7 RID: 32695
	public float f_radius;

	// Token: 0x04007FB8 RID: 32696
	public float f_focus_distance;

	// Token: 0x04007FB9 RID: 32697
	public int i_line;

	// Token: 0x04007FBA RID: 32698
	public int i_hide;

	// Token: 0x04007FBB RID: 32699
	public int i_face;

	// Token: 0x04007FBC RID: 32700
	public int i_camera;

	// Token: 0x04007FBD RID: 32701
	public int i_action;

	// Token: 0x04007FBE RID: 32702
	public int i_expression;

	// Token: 0x04007FBF RID: 32703
	public int i_filter;

	// Token: 0x04007FC0 RID: 32704
	public int i_filter_intensity;

	// Token: 0x04007FC1 RID: 32705
	public int i_light;

	// Token: 0x04007FC2 RID: 32706
	public int i_light_direction;

	// Token: 0x04007FC3 RID: 32707
	public string s_time = "";

	// Token: 0x04007FC4 RID: 32708
	public int i_weather;

	// Token: 0x04007FC5 RID: 32709
	public int i_wind;

	// Token: 0x04007FC6 RID: 32710
	public int i_wind_intensity;

	// Token: 0x04007FC7 RID: 32711
	public int i_vibe;

	// Token: 0x04007FC8 RID: 32712
	public int i_frame;

	// Token: 0x04007FC9 RID: 32713
	public int i_watermark;
}
