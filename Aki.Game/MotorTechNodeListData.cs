using System;
using System.Runtime.CompilerServices;

// Token: 0x02001745 RID: 5957
[NullableContext(1)]
[Nullable(0)]
public class MotorTechNodeListData : IMotorTechNodeListData
{
	// Token: 0x17001623 RID: 5667
	// (get) Token: 0x0600E72B RID: 59179 RVA: 0x0043AFB1 File Offset: 0x004391B1
	// (set) Token: 0x0600E72C RID: 59180 RVA: 0x0043AFB9 File Offset: 0x004391B9
	public int[] TopIds { get; set; }

	// Token: 0x17001624 RID: 5668
	// (get) Token: 0x0600E72D RID: 59181 RVA: 0x0043AFC2 File Offset: 0x004391C2
	// (set) Token: 0x0600E72E RID: 59182 RVA: 0x0043AFCA File Offset: 0x004391CA
	public int[] BottomIds { get; set; }

	// Token: 0x17001625 RID: 5669
	// (get) Token: 0x0600E72F RID: 59183 RVA: 0x0043AFD3 File Offset: 0x004391D3
	// (set) Token: 0x0600E730 RID: 59184 RVA: 0x0043AFDB File Offset: 0x004391DB
	public int MiddleId { get; set; }
}
