using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002AB6 RID: 10934
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeInfo
{
	// Token: 0x17002D16 RID: 11542
	// (get) Token: 0x0601BC42 RID: 113730 RVA: 0x0088BCB5 File Offset: 0x00889EB5
	// (set) Token: 0x0601BC43 RID: 113731 RVA: 0x0088BCBD File Offset: 0x00889EBD
	public List<string> Parents { get; set; } = new List<string>();

	// Token: 0x17002D17 RID: 11543
	// (get) Token: 0x0601BC44 RID: 113732 RVA: 0x0088BCC6 File Offset: 0x00889EC6
	// (set) Token: 0x0601BC45 RID: 113733 RVA: 0x0088BCCE File Offset: 0x00889ECE
	public List<string> Children { get; set; } = new List<string>();
}
