using System;
using System.Runtime.CompilerServices;

// Token: 0x020019D4 RID: 6612
[NullableContext(2)]
[Nullable(0)]
public class VisionRecommendViewOpenParam : IVisionRecommendViewOpenParam
{
	// Token: 0x170018F7 RID: 6391
	// (get) Token: 0x060104EE RID: 66798 RVA: 0x004C2FFD File Offset: 0x004C11FD
	// (set) Token: 0x060104EF RID: 66799 RVA: 0x004C3005 File Offset: 0x004C1205
	public int RoleId { get; set; }

	// Token: 0x170018F8 RID: 6392
	// (get) Token: 0x060104F0 RID: 66800 RVA: 0x004C300E File Offset: 0x004C120E
	// (set) Token: 0x060104F1 RID: 66801 RVA: 0x004C3016 File Offset: 0x004C1216
	public bool IsFromRoleDev { get; set; }

	// Token: 0x170018F9 RID: 6393
	// (get) Token: 0x060104F2 RID: 66802 RVA: 0x004C301F File Offset: 0x004C121F
	// (set) Token: 0x060104F3 RID: 66803 RVA: 0x004C3027 File Offset: 0x004C1227
	public Action<int, int, int?> SuccessCallBack { get; set; }

	// Token: 0x170018FA RID: 6394
	// (get) Token: 0x060104F4 RID: 66804 RVA: 0x004C3030 File Offset: 0x004C1230
	// (set) Token: 0x060104F5 RID: 66805 RVA: 0x004C3038 File Offset: 0x004C1238
	public Func<int, int> GetSelectedPlanIdCallBack { get; set; }

	// Token: 0x170018FB RID: 6395
	// (get) Token: 0x060104F6 RID: 66806 RVA: 0x004C3041 File Offset: 0x004C1241
	// (set) Token: 0x060104F7 RID: 66807 RVA: 0x004C3049 File Offset: 0x004C1249
	public Func<int, int> GetSelectedFirstVisionMonsterIdCallBack { get; set; }
}
