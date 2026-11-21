using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200158B RID: 5515
[NullableContext(1)]
[Nullable(0)]
public class BattleStartLogData : PlayerCommonLogData
{
	// Token: 0x17001490 RID: 5264
	// (get) Token: 0x0600DCD6 RID: 56534 RVA: 0x00416756 File Offset: 0x00414956
	public override string event_id
	{
		get
		{
			return "102704";
		}
	}

	// Token: 0x04007B34 RID: 31540
	public int i_area_id;

	// Token: 0x04007B35 RID: 31541
	public double f_x;

	// Token: 0x04007B36 RID: 31542
	public double f_y;

	// Token: 0x04007B37 RID: 31543
	public double f_z;

	// Token: 0x04007B38 RID: 31544
	public string s_battle_id = "";

	// Token: 0x04007B39 RID: 31545
	public List<int> s_team_character;

	// Token: 0x04007B3A RID: 31546
	public List<int> s_team_hp_per;
}
