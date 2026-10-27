using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020B4 RID: 8372
[NullableContext(1)]
[Nullable(0)]
public class BattleStartLogData : PlayerCommonLogData
{
	// Token: 0x17001463 RID: 5219
	// (get) Token: 0x06010866 RID: 67686 RVA: 0x0040A04E File Offset: 0x0040824E
	public override string event_id
	{
		get
		{
			return "102704";
		}
	}

	// Token: 0x04007A36 RID: 31286
	public int i_area_id;

	// Token: 0x04007A37 RID: 31287
	public double f_x;

	// Token: 0x04007A38 RID: 31288
	public double f_y;

	// Token: 0x04007A39 RID: 31289
	public double f_z;

	// Token: 0x04007A3A RID: 31290
	public string s_battle_id = "";

	// Token: 0x04007A3B RID: 31291
	public List<int> s_team_character;

	// Token: 0x04007A3C RID: 31292
	public List<int> s_team_hp_per;
}
