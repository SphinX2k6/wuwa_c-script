using System;
using System.Runtime.CompilerServices;

// Token: 0x020023B0 RID: 9136
[NullableContext(1)]
[Nullable(0)]
public class EntityPerformanceResult
{
	// Token: 0x170017BA RID: 6074
	// (get) Token: 0x06012466 RID: 74854 RVA: 0x0048033C File Offset: 0x0047E53C
	// (set) Token: 0x06012467 RID: 74855 RVA: 0x00480344 File Offset: 0x0047E544
	public string BlueprintType { get; set; } = "";

	// Token: 0x170017BB RID: 6075
	// (get) Token: 0x06012468 RID: 74856 RVA: 0x0048034D File Offset: 0x0047E54D
	// (set) Token: 0x06012469 RID: 74857 RVA: 0x00480355 File Offset: 0x0047E555
	public string EntityName { get; set; } = "";

	// Token: 0x170017BC RID: 6076
	// (get) Token: 0x0601246A RID: 74858 RVA: 0x0048035E File Offset: 0x0047E55E
	// (set) Token: 0x0601246B RID: 74859 RVA: 0x00480366 File Offset: 0x0047E566
	public double Score { get; set; }
}
