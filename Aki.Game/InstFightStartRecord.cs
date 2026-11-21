using System;
using System.Runtime.CompilerServices;

// Token: 0x02001597 RID: 5527
[NullableContext(1)]
[Nullable(0)]
public class InstFightStartRecord : PlayerCommonLogData
{
	// Token: 0x17001497 RID: 5271
	// (get) Token: 0x0600DCEF RID: 56559 RVA: 0x004169A6 File Offset: 0x00414BA6
	// (set) Token: 0x0600DCF0 RID: 56560 RVA: 0x004169AE File Offset: 0x00414BAE
	public override string event_id { get; set; } = "102800";

	// Token: 0x0600DCF1 RID: 56561 RVA: 0x004169B7 File Offset: 0x00414BB7
	public void Clear()
	{
		this.i_start_time = 0.0;
		this.i_area_index = 0;
	}

	// Token: 0x04007BD2 RID: 31698
	public int i_inst_id;

	// Token: 0x04007BD3 RID: 31699
	public string s_fight_id = "";

	// Token: 0x04007BD4 RID: 31700
	public string s_fight_roles = "";

	// Token: 0x04007BD5 RID: 31701
	public double i_start_time;

	// Token: 0x04007BD6 RID: 31702
	public int i_area_index;
}
