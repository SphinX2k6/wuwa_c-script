using System;
using System.Runtime.CompilerServices;

// Token: 0x020019D3 RID: 6611
[NullableContext(2)]
public interface IVisionRecommendViewOpenParam
{
	// Token: 0x170018F2 RID: 6386
	// (get) Token: 0x060104E4 RID: 66788
	// (set) Token: 0x060104E5 RID: 66789
	int RoleId { get; set; }

	// Token: 0x170018F3 RID: 6387
	// (get) Token: 0x060104E6 RID: 66790
	// (set) Token: 0x060104E7 RID: 66791
	bool IsFromRoleDev { get; set; }

	// Token: 0x170018F4 RID: 6388
	// (get) Token: 0x060104E8 RID: 66792
	// (set) Token: 0x060104E9 RID: 66793
	Action<int, int, int?> SuccessCallBack { get; set; }

	// Token: 0x170018F5 RID: 6389
	// (get) Token: 0x060104EA RID: 66794
	// (set) Token: 0x060104EB RID: 66795
	Func<int, int> GetSelectedPlanIdCallBack { get; set; }

	// Token: 0x170018F6 RID: 6390
	// (get) Token: 0x060104EC RID: 66796
	// (set) Token: 0x060104ED RID: 66797
	Func<int, int> GetSelectedFirstVisionMonsterIdCallBack { get; set; }
}
