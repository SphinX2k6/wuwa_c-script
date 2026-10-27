using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C0 RID: 8384
[NullableContext(1)]
[Nullable(0)]
public class InstFightStartRecord : PlayerCommonLogData
{
	// Token: 0x1700146A RID: 5226
	// (get) Token: 0x0601087F RID: 67711 RVA: 0x0040A29E File Offset: 0x0040849E
	// (set) Token: 0x06010880 RID: 67712 RVA: 0x0040A2A6 File Offset: 0x004084A6
	public override string event_id { get; set; } = "102800";

	// Token: 0x06010881 RID: 67713 RVA: 0x0040A2AF File Offset: 0x004084AF
	public void Clear()
	{
		this.i_start_time = 0.0;
		this.i_area_index = 0;
	}

	// Token: 0x04007AD4 RID: 31444
	public int i_inst_id;

	// Token: 0x04007AD5 RID: 31445
	public string s_fight_id = "";

	// Token: 0x04007AD6 RID: 31446
	public string s_fight_roles = "";

	// Token: 0x04007AD7 RID: 31447
	public double i_start_time;

	// Token: 0x04007AD8 RID: 31448
	public int i_area_index;
}
