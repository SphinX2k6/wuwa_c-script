using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200023C RID: 572
public class SetMovementModeInfo
{
	// Token: 0x040017CD RID: 6093
	public EMovementMode Mode;

	// Token: 0x040017CE RID: 6094
	public byte CustomMode;

	// Token: 0x040017CF RID: 6095
	[Nullable(1)]
	public Action Callback;

	// Token: 0x040017D0 RID: 6096
	public long? Uid;

	// Token: 0x040017D1 RID: 6097
	[Nullable(2)]
	public string Context;
}
