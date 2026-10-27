using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C36 RID: 7222
[NullableContext(1)]
public interface IPlayerData
{
	// Token: 0x170011CF RID: 4559
	// (get) Token: 0x0600D971 RID: 55665
	int PlayerId { get; }

	// Token: 0x170011D0 RID: 4560
	// (get) Token: 0x0600D972 RID: 55666
	string PlayerName { get; }

	// Token: 0x170011D1 RID: 4561
	// (get) Token: 0x0600D973 RID: 55667
	string Signature { get; }
}
