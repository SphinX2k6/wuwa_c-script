using System;
using System.Runtime.CompilerServices;

// Token: 0x02000263 RID: 611
[NullableContext(2)]
public interface IAudioInfo
{
	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x060025FC RID: 9724
	// (set) Token: 0x060025FD RID: 9725
	bool Start { get; set; }

	// Token: 0x060025FE RID: 9726
	[NullableContext(1)]
	object GetCompare();

	// Token: 0x060025FF RID: 9727
	string GetName();

	// Token: 0x06002600 RID: 9728
	string GetAudioEvent();

	// Token: 0x06002601 RID: 9729
	bool IsValid();

	// Token: 0x06002602 RID: 9730
	bool IsAudioEventValid();
}
