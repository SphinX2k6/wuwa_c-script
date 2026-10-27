using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003541 RID: 13633
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeInfo
{
	// Token: 0x1700297D RID: 10621
	// (get) Token: 0x0601DF1A RID: 122650 RVA: 0x0086407D File Offset: 0x0086227D
	// (set) Token: 0x0601DF1B RID: 122651 RVA: 0x00864085 File Offset: 0x00862285
	public List<string> Parents { get; set; } = new List<string>();

	// Token: 0x1700297E RID: 10622
	// (get) Token: 0x0601DF1C RID: 122652 RVA: 0x0086408E File Offset: 0x0086228E
	// (set) Token: 0x0601DF1D RID: 122653 RVA: 0x00864096 File Offset: 0x00862296
	public List<string> Children { get; set; } = new List<string>();
}
