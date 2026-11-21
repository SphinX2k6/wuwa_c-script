using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002575 RID: 9589
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthAllConfig
{
	// Token: 0x06017AC0 RID: 96960 RVA: 0x006FF79C File Offset: 0x006FD99C
	public bool IsLoadSuccess()
	{
		return this.CurLoadCount == 0;
	}

	// Token: 0x0400C9A4 RID: 51620
	public List<FoleySynthModel1Config> FoleySynthModel1Configs = new List<FoleySynthModel1Config>();

	// Token: 0x0400C9A5 RID: 51621
	public List<FoleySynthModel2Config> FoleySynthModel2Configs = new List<FoleySynthModel2Config>();

	// Token: 0x0400C9A6 RID: 51622
	public int Model2AccelerationMaxCount;

	// Token: 0x0400C9A7 RID: 51623
	public int Model2VelocityMaxCount;

	// Token: 0x0400C9A8 RID: 51624
	public int CurLoadCount;
}
