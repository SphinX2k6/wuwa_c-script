using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E92 RID: 11922
[NullableContext(2)]
[Nullable(0)]
public class TBuffAction
{
	// Token: 0x17002329 RID: 9001
	// (get) Token: 0x060197BE RID: 104382 RVA: 0x0069421F File Offset: 0x0069241F
	// (set) Token: 0x060197BF RID: 104383 RVA: 0x00694227 File Offset: 0x00692427
	public EBuffActionType Type { get; set; }

	// Token: 0x1700232A RID: 9002
	// (get) Token: 0x060197C0 RID: 104384 RVA: 0x00694230 File Offset: 0x00692430
	// (set) Token: 0x060197C1 RID: 104385 RVA: 0x00694238 File Offset: 0x00692438
	public long[] Buffs { get; set; }

	// Token: 0x1700232B RID: 9003
	// (get) Token: 0x060197C2 RID: 104386 RVA: 0x00694241 File Offset: 0x00692441
	// (set) Token: 0x060197C3 RID: 104387 RVA: 0x00694249 File Offset: 0x00692449
	public int[] Tags { get; set; }

	// Token: 0x1700232C RID: 9004
	// (get) Token: 0x060197C4 RID: 104388 RVA: 0x00694252 File Offset: 0x00692452
	// (set) Token: 0x060197C5 RID: 104389 RVA: 0x0069425A File Offset: 0x0069245A
	public int[] CustomParams { get; set; }
}
