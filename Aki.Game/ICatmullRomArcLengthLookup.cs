using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003498 RID: 13464
[NullableContext(1)]
public interface ICatmullRomArcLengthLookup
{
	// Token: 0x170028AC RID: 10412
	// (get) Token: 0x0601D4E7 RID: 120039
	IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x170028AD RID: 10413
	// (get) Token: 0x0601D4E8 RID: 120040
	IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x170028AE RID: 10414
	// (get) Token: 0x0601D4E9 RID: 120041
	double TotalLength { get; }
}
