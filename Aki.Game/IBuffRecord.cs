using System;
using System.Runtime.CompilerServices;

// Token: 0x0200282F RID: 10287
[NullableContext(2)]
public interface IBuffRecord
{
	// Token: 0x17002A02 RID: 10754
	// (get) Token: 0x06019F43 RID: 106307
	// (set) Token: 0x06019F44 RID: 106308
	long BuffId { get; set; }

	// Token: 0x17002A03 RID: 10755
	// (get) Token: 0x06019F45 RID: 106309
	// (set) Token: 0x06019F46 RID: 106310
	float TimeStamp { get; set; }

	// Token: 0x17002A04 RID: 10756
	// (get) Token: 0x06019F47 RID: 106311
	// (set) Token: 0x06019F48 RID: 106312
	int AreaId { get; set; }

	// Token: 0x17002A05 RID: 10757
	// (get) Token: 0x06019F49 RID: 106313
	// (set) Token: 0x06019F4A RID: 106314
	Vector Location { get; set; }

	// Token: 0x17002A06 RID: 10758
	// (get) Token: 0x06019F4B RID: 106315
	// (set) Token: 0x06019F4C RID: 106316
	float Damage { get; set; }
}
