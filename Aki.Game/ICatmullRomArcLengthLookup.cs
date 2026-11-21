using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A0C RID: 10764
[NullableContext(1)]
public interface ICatmullRomArcLengthLookup
{
	// Token: 0x17002C44 RID: 11332
	// (get) Token: 0x0601B1E3 RID: 111075
	IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x17002C45 RID: 11333
	// (get) Token: 0x0601B1E4 RID: 111076
	IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x17002C46 RID: 11334
	// (get) Token: 0x0601B1E5 RID: 111077
	double TotalLength { get; }
}
