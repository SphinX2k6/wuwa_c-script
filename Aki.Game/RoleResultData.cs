using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200131F RID: 4895
[NullableContext(1)]
[Nullable(0)]
public class RoleResultData : IRoleResultData
{
	// Token: 0x17000B92 RID: 2962
	// (get) Token: 0x060087D3 RID: 34771 RVA: 0x001CFB98 File Offset: 0x001CDD98
	// (set) Token: 0x060087D4 RID: 34772 RVA: 0x001CFBA0 File Offset: 0x001CDDA0
	public RoleSettleResult SuccessResult { get; set; }

	// Token: 0x17000B93 RID: 2963
	// (get) Token: 0x060087D5 RID: 34773 RVA: 0x001CFBA9 File Offset: 0x001CDDA9
	// (set) Token: 0x060087D6 RID: 34774 RVA: 0x001CFBB1 File Offset: 0x001CDDB1
	public List<int> CharacterValueList { get; set; } = new List<int>();
}
