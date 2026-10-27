using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200131E RID: 4894
[NullableContext(1)]
public interface IRoleResultData
{
	// Token: 0x17000B90 RID: 2960
	// (get) Token: 0x060087CF RID: 34767
	// (set) Token: 0x060087D0 RID: 34768
	RoleSettleResult SuccessResult { get; set; }

	// Token: 0x17000B91 RID: 2961
	// (get) Token: 0x060087D1 RID: 34769
	// (set) Token: 0x060087D2 RID: 34770
	List<int> CharacterValueList { get; set; }
}
