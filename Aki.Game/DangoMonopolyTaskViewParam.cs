using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001251 RID: 4689
public class DangoMonopolyTaskViewParam
{
	// Token: 0x040039FE RID: 14846
	public int? TaskId;

	// Token: 0x040039FF RID: 14847
	[Nullable(1)]
	public List<IDangoMonopolyTaskTabData> TaskList = new List<IDangoMonopolyTaskTabData>();
}
