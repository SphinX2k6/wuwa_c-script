using System;
using System.Runtime.CompilerServices;

// Token: 0x020010B1 RID: 4273
[NullableContext(1)]
public interface IActivityFunctionAreaParams
{
	// Token: 0x17000951 RID: 2385
	// (get) Token: 0x06006F36 RID: 28470
	// (set) Token: 0x06006F37 RID: 28471
	string UnlockBtnTextId { get; set; }

	// Token: 0x17000952 RID: 2386
	// (get) Token: 0x06006F38 RID: 28472
	// (set) Token: 0x06006F39 RID: 28473
	string[] UnlockBtnTextArgs { get; set; }

	// Token: 0x17000953 RID: 2387
	// (get) Token: 0x06006F3A RID: 28474
	// (set) Token: 0x06006F3B RID: 28475
	Action UnlockBtnFunction { get; set; }

	// Token: 0x17000954 RID: 2388
	// (get) Token: 0x06006F3C RID: 28476
	// (set) Token: 0x06006F3D RID: 28477
	Func<bool> BeforePreOpenCheck { get; set; }
}
