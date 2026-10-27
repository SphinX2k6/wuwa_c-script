using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E99 RID: 3737
public interface IBuffGateDesc
{
	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06005BAE RID: 23470
	// (set) Token: 0x06005BAF RID: 23471
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	ValueTuple<string, List<string>> Desc { [return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] set; }

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x06005BB0 RID: 23472
	// (set) Token: 0x06005BB1 RID: 23473
	int BuffGateId { get; set; }

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x06005BB2 RID: 23474
	// (set) Token: 0x06005BB3 RID: 23475
	bool IsDropBuffGate { get; set; }
}
