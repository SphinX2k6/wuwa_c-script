using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CB4 RID: 11444
[NullableContext(1)]
public interface IActiveMaterialEntry
{
	// Token: 0x1700203A RID: 8250
	// (get) Token: 0x06017E8B RID: 97931
	// (set) Token: 0x06017E8C RID: 97932
	UObject Data { get; set; }

	// Token: 0x1700203B RID: 8251
	// (get) Token: 0x06017E8D RID: 97933
	// (set) Token: 0x06017E8E RID: 97934
	bool IsGroup { get; set; }

	// Token: 0x1700203C RID: 8252
	// (get) Token: 0x06017E8F RID: 97935
	// (set) Token: 0x06017E90 RID: 97936
	bool WithAnimObject { get; set; }
}
