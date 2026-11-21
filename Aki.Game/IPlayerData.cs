using System;
using System.Runtime.CompilerServices;

// Token: 0x020010F5 RID: 4341
[NullableContext(1)]
public interface IPlayerData
{
	// Token: 0x170011F5 RID: 4597
	// (get) Token: 0x0600AD87 RID: 44423
	int PlayerId { get; }

	// Token: 0x170011F6 RID: 4598
	// (get) Token: 0x0600AD88 RID: 44424
	string PlayerName { get; }

	// Token: 0x170011F7 RID: 4599
	// (get) Token: 0x0600AD89 RID: 44425
	string Signature { get; }
}
