using System;
using System.Runtime.CompilerServices;

// Token: 0x02003118 RID: 12568
[NullableContext(1)]
[Nullable(0)]
public class IStartMoveParams : PatrolParamsImpl, IActionParamMap
{
	// Token: 0x17002565 RID: 9573
	// (get) Token: 0x0601B036 RID: 110646 RVA: 0x00754E96 File Offset: 0x00753096
	// (set) Token: 0x0601B037 RID: 110647 RVA: 0x00754E9E File Offset: 0x0075309E
	public int SplineId { get; set; }

	// Token: 0x17002566 RID: 9574
	// (get) Token: 0x0601B038 RID: 110648 RVA: 0x00754EA7 File Offset: 0x007530A7
	// (set) Token: 0x0601B039 RID: 110649 RVA: 0x00754EAF File Offset: 0x007530AF
	public string Context { get; set; }
}
