using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200055E RID: 1374
[NullableContext(2)]
public interface IActivityRewardDataPage
{
	// Token: 0x1700095F RID: 2399
	// (get) Token: 0x0600429D RID: 17053
	// (set) Token: 0x0600429E RID: 17054
	string TabName { get; set; }

	// Token: 0x17000960 RID: 2400
	// (get) Token: 0x0600429F RID: 17055
	// (set) Token: 0x060042A0 RID: 17056
	[Nullable(1)]
	List<IActivityRewardData> DataList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000961 RID: 2401
	// (get) Token: 0x060042A1 RID: 17057
	// (set) Token: 0x060042A2 RID: 17058
	string TabTips { get; set; }

	// Token: 0x17000962 RID: 2402
	// (get) Token: 0x060042A3 RID: 17059
	// (set) Token: 0x060042A4 RID: 17060
	Action<int> TabExtraFunction { get; set; }
}
