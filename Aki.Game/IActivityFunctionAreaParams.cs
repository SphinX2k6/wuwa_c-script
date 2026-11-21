using System;
using System.Runtime.CompilerServices;

// Token: 0x02000565 RID: 1381
[NullableContext(1)]
public interface IActivityFunctionAreaParams
{
	// Token: 0x17000971 RID: 2417
	// (get) Token: 0x060042CC RID: 17100
	// (set) Token: 0x060042CD RID: 17101
	string UnlockBtnTextId { get; set; }

	// Token: 0x17000972 RID: 2418
	// (get) Token: 0x060042CE RID: 17102
	// (set) Token: 0x060042CF RID: 17103
	string[] UnlockBtnTextArgs { get; set; }

	// Token: 0x17000973 RID: 2419
	// (get) Token: 0x060042D0 RID: 17104
	// (set) Token: 0x060042D1 RID: 17105
	Action UnlockBtnFunction { get; set; }

	// Token: 0x17000974 RID: 2420
	// (get) Token: 0x060042D2 RID: 17106
	// (set) Token: 0x060042D3 RID: 17107
	Func<bool> BeforePreOpenCheck { get; set; }
}
