using System;
using System.Runtime.CompilerServices;

// Token: 0x020024EC RID: 9452
[NullableContext(2)]
public interface IVisionRecommendViewOpenParam
{
	// Token: 0x170018B8 RID: 6328
	// (get) Token: 0x06013025 RID: 77861
	// (set) Token: 0x06013026 RID: 77862
	int RoleId { get; set; }

	// Token: 0x170018B9 RID: 6329
	// (get) Token: 0x06013027 RID: 77863
	// (set) Token: 0x06013028 RID: 77864
	bool IsFromRoleDev { get; set; }

	// Token: 0x170018BA RID: 6330
	// (get) Token: 0x06013029 RID: 77865
	// (set) Token: 0x0601302A RID: 77866
	Action<int, int, int?> SuccessCallBack { get; set; }

	// Token: 0x170018BB RID: 6331
	// (get) Token: 0x0601302B RID: 77867
	// (set) Token: 0x0601302C RID: 77868
	Func<int, int> GetSelectedPlanIdCallBack { get; set; }

	// Token: 0x170018BC RID: 6332
	// (get) Token: 0x0601302D RID: 77869
	// (set) Token: 0x0601302E RID: 77870
	Func<int, int> GetSelectedFirstVisionMonsterIdCallBack { get; set; }
}
