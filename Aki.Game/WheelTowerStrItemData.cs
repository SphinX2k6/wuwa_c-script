using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000AAA RID: 2730
[NullableContext(1)]
[Nullable(0)]
internal class WheelTowerStrItemData
{
	// Token: 0x17000DA4 RID: 3492
	// (get) Token: 0x06007271 RID: 29297 RVA: 0x00233F7C File Offset: 0x0023217C
	// (set) Token: 0x06007272 RID: 29298 RVA: 0x00233F84 File Offset: 0x00232184
	public string RoleName { get; set; } = string.Empty;

	// Token: 0x17000DA5 RID: 3493
	// (get) Token: 0x06007273 RID: 29299 RVA: 0x00233F8D File Offset: 0x0023218D
	// (set) Token: 0x06007274 RID: 29300 RVA: 0x00233F95 File Offset: 0x00232195
	public List<string> DescList { get; set; } = new List<string>();
}
