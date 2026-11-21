using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020007D2 RID: 2002
[NullableContext(1)]
public interface IRoleResultData
{
	// Token: 0x17000BB0 RID: 2992
	// (get) Token: 0x06005B6A RID: 23402
	// (set) Token: 0x06005B6B RID: 23403
	RoleSettleResult SuccessResult { get; set; }

	// Token: 0x17000BB1 RID: 2993
	// (get) Token: 0x06005B6C RID: 23404
	// (set) Token: 0x06005B6D RID: 23405
	List<int> CharacterValueList { get; set; }
}
