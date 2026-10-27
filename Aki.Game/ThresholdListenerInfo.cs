using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F02 RID: 3842
[NullableContext(1)]
[Nullable(0)]
public class ThresholdListenerInfo : IThresholdListenerInfo
{
	// Token: 0x17000775 RID: 1909
	// (get) Token: 0x0600605E RID: 24670 RVA: 0x0012CA2F File Offset: 0x0012AC2F
	// (set) Token: 0x0600605F RID: 24671 RVA: 0x0012CA37 File Offset: 0x0012AC37
	public TThresholdListener Func { get; set; }

	// Token: 0x17000776 RID: 1910
	// (get) Token: 0x06006060 RID: 24672 RVA: 0x0012CA40 File Offset: 0x0012AC40
	// (set) Token: 0x06006061 RID: 24673 RVA: 0x0012CA48 File Offset: 0x0012AC48
	public float Max { get; set; }

	// Token: 0x17000777 RID: 1911
	// (get) Token: 0x06006062 RID: 24674 RVA: 0x0012CA51 File Offset: 0x0012AC51
	// (set) Token: 0x06006063 RID: 24675 RVA: 0x0012CA59 File Offset: 0x0012AC59
	public float Min { get; set; }

	// Token: 0x17000778 RID: 1912
	// (get) Token: 0x06006064 RID: 24676 RVA: 0x0012CA62 File Offset: 0x0012AC62
	// (set) Token: 0x06006065 RID: 24677 RVA: 0x0012CA6A File Offset: 0x0012AC6A
	public bool InInterval { get; set; }
}
