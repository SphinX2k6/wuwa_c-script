using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000240 RID: 576
public class SetMovementModeInfo
{
	// Token: 0x04001811 RID: 6161
	public EMovementMode Mode;

	// Token: 0x04001812 RID: 6162
	public byte CustomMode;

	// Token: 0x04001813 RID: 6163
	[Nullable(1)]
	public Action Callback;

	// Token: 0x04001814 RID: 6164
	public long? Uid;

	// Token: 0x04001815 RID: 6165
	[Nullable(2)]
	public string Context;
}
