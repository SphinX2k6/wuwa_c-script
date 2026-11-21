using System;
using System.Runtime.CompilerServices;

// Token: 0x02002673 RID: 9843
[NullableContext(1)]
[Nullable(0)]
public class IStartMoveParams : PatrolParamsImpl, IActionParamMap
{
	// Token: 0x17002710 RID: 10000
	// (get) Token: 0x06018A91 RID: 101009 RVA: 0x0077AF02 File Offset: 0x00779102
	// (set) Token: 0x06018A92 RID: 101010 RVA: 0x0077AF0A File Offset: 0x0077910A
	public int SplineId { get; set; }

	// Token: 0x17002711 RID: 10001
	// (get) Token: 0x06018A93 RID: 101011 RVA: 0x0077AF13 File Offset: 0x00779113
	// (set) Token: 0x06018A94 RID: 101012 RVA: 0x0077AF1B File Offset: 0x0077911B
	public string Context { get; set; }
}
