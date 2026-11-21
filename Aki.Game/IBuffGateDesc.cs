using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200034E RID: 846
public interface IBuffGateDesc
{
	// Token: 0x170006E0 RID: 1760
	// (get) Token: 0x06002F45 RID: 12101
	// (set) Token: 0x06002F46 RID: 12102
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

	// Token: 0x170006E1 RID: 1761
	// (get) Token: 0x06002F47 RID: 12103
	// (set) Token: 0x06002F48 RID: 12104
	int BuffGateId { get; set; }

	// Token: 0x170006E2 RID: 1762
	// (get) Token: 0x06002F49 RID: 12105
	// (set) Token: 0x06002F4A RID: 12106
	bool IsDropBuffGate { get; set; }
}
