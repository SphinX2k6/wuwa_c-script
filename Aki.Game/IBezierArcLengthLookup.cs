using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A09 RID: 10761
[NullableContext(1)]
public interface IBezierArcLengthLookup
{
	// Token: 0x17002C3E RID: 11326
	// (get) Token: 0x0601B1D3 RID: 111059
	IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x17002C3F RID: 11327
	// (get) Token: 0x0601B1D4 RID: 111060
	IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x17002C40 RID: 11328
	// (get) Token: 0x0601B1D5 RID: 111061
	double TotalLength { get; }
}
