using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000705 RID: 1797
public class DangoMonopolyTaskViewParam
{
	// Token: 0x04003A96 RID: 14998
	public int? TaskId;

	// Token: 0x04003A97 RID: 14999
	[Nullable(1)]
	public List<IDangoMonopolyTaskTabData> TaskList = new List<IDangoMonopolyTaskTabData>();
}
