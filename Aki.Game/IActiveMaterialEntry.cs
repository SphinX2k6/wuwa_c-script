using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200220D RID: 8717
[NullableContext(1)]
public interface IActiveMaterialEntry
{
	// Token: 0x1700208B RID: 8331
	// (get) Token: 0x060156FF RID: 87807
	// (set) Token: 0x06015700 RID: 87808
	UObject Data { get; set; }

	// Token: 0x1700208C RID: 8332
	// (get) Token: 0x06015701 RID: 87809
	// (set) Token: 0x06015702 RID: 87810
	bool IsGroup { get; set; }

	// Token: 0x1700208D RID: 8333
	// (get) Token: 0x06015703 RID: 87811
	// (set) Token: 0x06015704 RID: 87812
	bool WithAnimObject { get; set; }
}
