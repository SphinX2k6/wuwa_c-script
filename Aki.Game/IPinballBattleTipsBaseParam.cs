using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D0A RID: 7434
[NullableContext(2)]
public interface IPinballBattleTipsBaseParam
{
	// Token: 0x17001210 RID: 4624
	// (get) Token: 0x0600E0C2 RID: 57538
	Action CloseCallback { get; }

	// Token: 0x17001211 RID: 4625
	// (get) Token: 0x0600E0C3 RID: 57539
	bool? AddMask { get; }

	// Token: 0x17001212 RID: 4626
	// (get) Token: 0x0600E0C4 RID: 57540
	int? CloseTime { get; }

	// Token: 0x17001213 RID: 4627
	// (get) Token: 0x0600E0C5 RID: 57541
	bool? MoveToBehind { get; }
}
