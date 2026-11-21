using System;
using System.Runtime.CompilerServices;

// Token: 0x02001677 RID: 5751
[NullableContext(1)]
public interface IButtonPreset
{
	// Token: 0x17001563 RID: 5475
	// (get) Token: 0x0600DFED RID: 57325
	string Title { get; }

	// Token: 0x17001564 RID: 5476
	// (get) Token: 0x0600DFEE RID: 57326
	Action ClickFunc { get; }
}
