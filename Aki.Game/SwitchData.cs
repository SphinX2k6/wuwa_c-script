using System;
using System.Runtime.CompilerServices;

// Token: 0x02002401 RID: 9217
[NullableContext(1)]
[Nullable(0)]
public class SwitchData : ISwitchData
{
	// Token: 0x170017DC RID: 6108
	// (get) Token: 0x06012704 RID: 75524 RVA: 0x0048C954 File Offset: 0x0048AB54
	// (set) Token: 0x06012705 RID: 75525 RVA: 0x0048C95C File Offset: 0x0048AB5C
	public string TextId { get; set; }

	// Token: 0x170017DD RID: 6109
	// (get) Token: 0x06012706 RID: 75526 RVA: 0x0048C965 File Offset: 0x0048AB65
	// (set) Token: 0x06012707 RID: 75527 RVA: 0x0048C96D File Offset: 0x0048AB6D
	public bool IsEnable { get; set; }
}
