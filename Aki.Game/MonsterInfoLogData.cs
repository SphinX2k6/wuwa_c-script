using System;
using System.Runtime.CompilerServices;

// Token: 0x020020B6 RID: 8374
public class MonsterInfoLogData
{
	// Token: 0x06010869 RID: 67689 RVA: 0x0040A070 File Offset: 0x00408270
	[NullableContext(1)]
	public MonsterInfoLogData(MonsterInfoLogData data = null)
	{
		if (data != null)
		{
			this.pbdata_id = data.pbdata_id;
			this.config_type = data.config_type;
		}
	}

	// Token: 0x04007A3D RID: 31293
	public int pbdata_id;

	// Token: 0x04007A3E RID: 31294
	public int config_type;
}
