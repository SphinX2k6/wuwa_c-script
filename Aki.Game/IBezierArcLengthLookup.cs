using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003495 RID: 13461
[NullableContext(1)]
public interface IBezierArcLengthLookup
{
	// Token: 0x170028A6 RID: 10406
	// (get) Token: 0x0601D4D7 RID: 120023
	IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x170028A7 RID: 10407
	// (get) Token: 0x0601D4D8 RID: 120024
	IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x170028A8 RID: 10408
	// (get) Token: 0x0601D4D9 RID: 120025
	double TotalLength { get; }
}
