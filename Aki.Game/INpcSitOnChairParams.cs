using System;
using System.Runtime.CompilerServices;

// Token: 0x02002752 RID: 10066
[NullableContext(2)]
public interface INpcSitOnChairParams
{
	// Token: 0x17002841 RID: 10305
	// (get) Token: 0x0601942B RID: 103467
	// (set) Token: 0x0601942C RID: 103468
	int ChairEntityId { get; set; }

	// Token: 0x17002842 RID: 10306
	// (get) Token: 0x0601942D RID: 103469
	// (set) Token: 0x0601942E RID: 103470
	string MontagePath { get; set; }

	// Token: 0x17002843 RID: 10307
	// (get) Token: 0x0601942F RID: 103471
	// (set) Token: 0x06019430 RID: 103472
	[Nullable(1)]
	Func<bool> InterruptCondition { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17002844 RID: 10308
	// (get) Token: 0x06019431 RID: 103473
	// (set) Token: 0x06019432 RID: 103474
	Action Finish { get; set; }

	// Token: 0x17002845 RID: 10309
	// (get) Token: 0x06019433 RID: 103475
	// (set) Token: 0x06019434 RID: 103476
	Action Abort { get; set; }

	// Token: 0x17002846 RID: 10310
	// (get) Token: 0x06019435 RID: 103477
	// (set) Token: 0x06019436 RID: 103478
	int[] TeleportEffect { get; set; }
}
