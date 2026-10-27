using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200112B RID: 4395
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerLevelInfo : IBabelTowerLevelInfo
{
	// Token: 0x170009BD RID: 2493
	// (get) Token: 0x0600734A RID: 29514 RVA: 0x0017B90E File Offset: 0x00179B0E
	// (set) Token: 0x0600734B RID: 29515 RVA: 0x0017B916 File Offset: 0x00179B16
	public int BabelTowerLevelId { get; set; }

	// Token: 0x170009BE RID: 2494
	// (get) Token: 0x0600734C RID: 29516 RVA: 0x0017B91F File Offset: 0x00179B1F
	// (set) Token: 0x0600734D RID: 29517 RVA: 0x0017B927 File Offset: 0x00179B27
	public int InstanceId { get; set; }

	// Token: 0x170009BF RID: 2495
	// (get) Token: 0x0600734E RID: 29518 RVA: 0x0017B930 File Offset: 0x00179B30
	// (set) Token: 0x0600734F RID: 29519 RVA: 0x0017B938 File Offset: 0x00179B38
	public List<int> RoleList { get; set; }

	// Token: 0x170009C0 RID: 2496
	// (get) Token: 0x06007350 RID: 29520 RVA: 0x0017B941 File Offset: 0x00179B41
	// (set) Token: 0x06007351 RID: 29521 RVA: 0x0017B949 File Offset: 0x00179B49
	public List<int> BuffList { get; set; }

	// Token: 0x170009C1 RID: 2497
	// (get) Token: 0x06007352 RID: 29522 RVA: 0x0017B952 File Offset: 0x00179B52
	// (set) Token: 0x06007353 RID: 29523 RVA: 0x0017B95A File Offset: 0x00179B5A
	public int BuffCount { get; set; }

	// Token: 0x170009C2 RID: 2498
	// (get) Token: 0x06007354 RID: 29524 RVA: 0x0017B963 File Offset: 0x00179B63
	// (set) Token: 0x06007355 RID: 29525 RVA: 0x0017B96B File Offset: 0x00179B6B
	public int StarNumber { get; set; }
}
