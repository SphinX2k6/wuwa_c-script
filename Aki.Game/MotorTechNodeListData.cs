using System;
using System.Runtime.CompilerServices;

// Token: 0x02002261 RID: 8801
[NullableContext(1)]
[Nullable(0)]
public class MotorTechNodeListData : IMotorTechNodeListData
{
	// Token: 0x170015EC RID: 5612
	// (get) Token: 0x06011295 RID: 70293 RVA: 0x0042E411 File Offset: 0x0042C611
	// (set) Token: 0x06011296 RID: 70294 RVA: 0x0042E419 File Offset: 0x0042C619
	public int[] TopIds { get; set; }

	// Token: 0x170015ED RID: 5613
	// (get) Token: 0x06011297 RID: 70295 RVA: 0x0042E422 File Offset: 0x0042C622
	// (set) Token: 0x06011298 RID: 70296 RVA: 0x0042E42A File Offset: 0x0042C62A
	public int[] BottomIds { get; set; }

	// Token: 0x170015EE RID: 5614
	// (get) Token: 0x06011299 RID: 70297 RVA: 0x0042E433 File Offset: 0x0042C633
	// (set) Token: 0x0601129A RID: 70298 RVA: 0x0042E43B File Offset: 0x0042C63B
	public int MiddleId { get; set; }
}
