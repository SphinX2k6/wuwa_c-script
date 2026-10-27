using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001133 RID: 4403
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDeTermSelectItemInfo : IBabelTowerDeTermSelectItemInfo
{
	// Token: 0x170009DF RID: 2527
	// (get) Token: 0x06007392 RID: 29586 RVA: 0x0017BA60 File Offset: 0x00179C60
	// (set) Token: 0x06007393 RID: 29587 RVA: 0x0017BA68 File Offset: 0x00179C68
	public bool IsNecessary { get; set; }

	// Token: 0x170009E0 RID: 2528
	// (get) Token: 0x06007394 RID: 29588 RVA: 0x0017BA71 File Offset: 0x00179C71
	// (set) Token: 0x06007395 RID: 29589 RVA: 0x0017BA79 File Offset: 0x00179C79
	public List<int> AllDeTerm { get; set; }

	// Token: 0x170009E1 RID: 2529
	// (get) Token: 0x06007396 RID: 29590 RVA: 0x0017BA82 File Offset: 0x00179C82
	// (set) Token: 0x06007397 RID: 29591 RVA: 0x0017BA8A File Offset: 0x00179C8A
	public List<int> DailyDeTerm { get; set; }

	// Token: 0x170009E2 RID: 2530
	// (get) Token: 0x06007398 RID: 29592 RVA: 0x0017BA93 File Offset: 0x00179C93
	// (set) Token: 0x06007399 RID: 29593 RVA: 0x0017BA9B File Offset: 0x00179C9B
	public Action<int> OnChangeSelectDeTerm { get; set; }
}
