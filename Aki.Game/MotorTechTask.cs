using System;
using System.Runtime.CompilerServices;

// Token: 0x02002257 RID: 8791
[NullableContext(1)]
[Nullable(0)]
public class MotorTechTask
{
	// Token: 0x170015CF RID: 5583
	// (get) Token: 0x06011255 RID: 70229 RVA: 0x0042E26B File Offset: 0x0042C46B
	// (set) Token: 0x06011256 RID: 70230 RVA: 0x0042E273 File Offset: 0x0042C473
	public MotorTechTaskNode[] TaskList { get; set; } = new MotorTechTaskNode[0];

	// Token: 0x170015D0 RID: 5584
	// (get) Token: 0x06011257 RID: 70231 RVA: 0x0042E27C File Offset: 0x0042C47C
	// (set) Token: 0x06011258 RID: 70232 RVA: 0x0042E284 File Offset: 0x0042C484
	public int RewardedCount { get; set; }
}
