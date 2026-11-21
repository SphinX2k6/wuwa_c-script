using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020007D3 RID: 2003
[NullableContext(1)]
[Nullable(0)]
public class RoleResultData : IRoleResultData
{
	// Token: 0x17000BB2 RID: 2994
	// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001D8A04 File Offset: 0x001D6C04
	// (set) Token: 0x06005B6F RID: 23407 RVA: 0x001D8A0C File Offset: 0x001D6C0C
	public RoleSettleResult SuccessResult { get; set; }

	// Token: 0x17000BB3 RID: 2995
	// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001D8A15 File Offset: 0x001D6C15
	// (set) Token: 0x06005B71 RID: 23409 RVA: 0x001D8A1D File Offset: 0x001D6C1D
	public List<int> CharacterValueList { get; set; } = new List<int>();
}
