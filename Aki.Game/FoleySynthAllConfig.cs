using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200301F RID: 12319
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthAllConfig
{
	// Token: 0x0601A178 RID: 106872 RVA: 0x006D7894 File Offset: 0x006D5A94
	public bool IsLoadSuccess()
	{
		return this.CurLoadCount == 0;
	}

	// Token: 0x0400C5D7 RID: 50647
	public List<FoleySynthModel1Config> FoleySynthModel1Configs = new List<FoleySynthModel1Config>();

	// Token: 0x0400C5D8 RID: 50648
	public List<FoleySynthModel2Config> FoleySynthModel2Configs = new List<FoleySynthModel2Config>();

	// Token: 0x0400C5D9 RID: 50649
	public int Model2AccelerationMaxCount;

	// Token: 0x0400C5DA RID: 50650
	public int Model2VelocityMaxCount;

	// Token: 0x0400C5DB RID: 50651
	public int CurLoadCount;
}
