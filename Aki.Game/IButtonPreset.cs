using System;
using System.Runtime.CompilerServices;

// Token: 0x02002193 RID: 8595
[NullableContext(1)]
public interface IButtonPreset
{
	// Token: 0x1700152C RID: 5420
	// (get) Token: 0x06010B5C RID: 68444
	string Title { get; }

	// Token: 0x1700152D RID: 5421
	// (get) Token: 0x06010B5D RID: 68445
	Action ClickFunc { get; }
}
