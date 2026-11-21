using System;
using System.Runtime.CompilerServices;

// Token: 0x020011CC RID: 4556
[NullableContext(2)]
public interface IPinballBattleTipsBaseParam
{
	// Token: 0x1700123A RID: 4666
	// (get) Token: 0x0600B4DF RID: 46303
	Action CloseCallback { get; }

	// Token: 0x1700123B RID: 4667
	// (get) Token: 0x0600B4E0 RID: 46304
	bool? AddMask { get; }

	// Token: 0x1700123C RID: 4668
	// (get) Token: 0x0600B4E1 RID: 46305
	int? CloseTime { get; }

	// Token: 0x1700123D RID: 4669
	// (get) Token: 0x0600B4E2 RID: 46306
	bool? MoveToBehind { get; }
}
