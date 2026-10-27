using System;
using System.Runtime.CompilerServices;

// Token: 0x02002260 RID: 8800
[NullableContext(1)]
public interface IMotorTechNodeListData
{
	// Token: 0x170015E9 RID: 5609
	// (get) Token: 0x0601128F RID: 70287
	// (set) Token: 0x06011290 RID: 70288
	int[] TopIds { get; set; }

	// Token: 0x170015EA RID: 5610
	// (get) Token: 0x06011291 RID: 70289
	// (set) Token: 0x06011292 RID: 70290
	int[] BottomIds { get; set; }

	// Token: 0x170015EB RID: 5611
	// (get) Token: 0x06011293 RID: 70291
	// (set) Token: 0x06011294 RID: 70292
	int MiddleId { get; set; }
}
