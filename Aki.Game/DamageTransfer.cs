using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E6B RID: 11883
[NullableContext(2)]
[Nullable(0)]
public class DamageTransfer
{
	// Token: 0x170022D3 RID: 8915
	// (get) Token: 0x06019643 RID: 104003 RVA: 0x0068CBB6 File Offset: 0x0068ADB6
	// (set) Token: 0x06019644 RID: 104004 RVA: 0x0068CBBE File Offset: 0x0068ADBE
	public BaseDamageComponent TransferTarget { get; set; }

	// Token: 0x170022D4 RID: 8916
	// (get) Token: 0x06019645 RID: 104005 RVA: 0x0068CBC7 File Offset: 0x0068ADC7
	// (set) Token: 0x06019646 RID: 104006 RVA: 0x0068CBCF File Offset: 0x0068ADCF
	public float ToughRecoverDelayTime { get; set; }

	// Token: 0x170022D5 RID: 8917
	// (get) Token: 0x06019647 RID: 104007 RVA: 0x0068CBD8 File Offset: 0x0068ADD8
	// (set) Token: 0x06019648 RID: 104008 RVA: 0x0068CBE0 File Offset: 0x0068ADE0
	public float WeakTime { get; set; }
}
