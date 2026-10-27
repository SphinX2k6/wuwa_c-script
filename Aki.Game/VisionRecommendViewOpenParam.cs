using System;
using System.Runtime.CompilerServices;

// Token: 0x020024ED RID: 9453
[NullableContext(2)]
[Nullable(0)]
public class VisionRecommendViewOpenParam : IVisionRecommendViewOpenParam
{
	// Token: 0x170018BD RID: 6333
	// (get) Token: 0x0601302F RID: 77871 RVA: 0x004B5351 File Offset: 0x004B3551
	// (set) Token: 0x06013030 RID: 77872 RVA: 0x004B5359 File Offset: 0x004B3559
	public int RoleId { get; set; }

	// Token: 0x170018BE RID: 6334
	// (get) Token: 0x06013031 RID: 77873 RVA: 0x004B5362 File Offset: 0x004B3562
	// (set) Token: 0x06013032 RID: 77874 RVA: 0x004B536A File Offset: 0x004B356A
	public bool IsFromRoleDev { get; set; }

	// Token: 0x170018BF RID: 6335
	// (get) Token: 0x06013033 RID: 77875 RVA: 0x004B5373 File Offset: 0x004B3573
	// (set) Token: 0x06013034 RID: 77876 RVA: 0x004B537B File Offset: 0x004B357B
	public Action<int, int, int?> SuccessCallBack { get; set; }

	// Token: 0x170018C0 RID: 6336
	// (get) Token: 0x06013035 RID: 77877 RVA: 0x004B5384 File Offset: 0x004B3584
	// (set) Token: 0x06013036 RID: 77878 RVA: 0x004B538C File Offset: 0x004B358C
	public Func<int, int> GetSelectedPlanIdCallBack { get; set; }

	// Token: 0x170018C1 RID: 6337
	// (get) Token: 0x06013037 RID: 77879 RVA: 0x004B5395 File Offset: 0x004B3595
	// (set) Token: 0x06013038 RID: 77880 RVA: 0x004B539D File Offset: 0x004B359D
	public Func<int, int> GetSelectedFirstVisionMonsterIdCallBack { get; set; }
}
