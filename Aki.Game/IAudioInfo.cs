using System;
using System.Runtime.CompilerServices;

// Token: 0x0200025F RID: 607
[NullableContext(2)]
public interface IAudioInfo
{
	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x06002545 RID: 9541
	// (set) Token: 0x06002546 RID: 9542
	bool Start { get; set; }

	// Token: 0x06002547 RID: 9543
	[NullableContext(1)]
	object GetCompare();

	// Token: 0x06002548 RID: 9544
	string GetName();

	// Token: 0x06002549 RID: 9545
	string GetAudioEvent();

	// Token: 0x0600254A RID: 9546
	bool IsValid();

	// Token: 0x0600254B RID: 9547
	bool IsAudioEventValid();
}
