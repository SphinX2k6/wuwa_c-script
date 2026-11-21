using System;
using System.Runtime.CompilerServices;

// Token: 0x0200158D RID: 5517
public class MonsterInfoLogData
{
	// Token: 0x0600DCD9 RID: 56537 RVA: 0x00416778 File Offset: 0x00414978
	[NullableContext(1)]
	public MonsterInfoLogData(MonsterInfoLogData data = null)
	{
		if (data != null)
		{
			this.pbdata_id = data.pbdata_id;
			this.config_type = data.config_type;
		}
	}

	// Token: 0x04007B3B RID: 31547
	public int pbdata_id;

	// Token: 0x04007B3C RID: 31548
	public int config_type;
}
