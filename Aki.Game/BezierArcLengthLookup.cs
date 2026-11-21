using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A0A RID: 10762
[NullableContext(1)]
[Nullable(0)]
public class BezierArcLengthLookup : IBezierArcLengthLookup
{
	// Token: 0x17002C41 RID: 11329
	// (get) Token: 0x0601B1D6 RID: 111062 RVA: 0x008522D1 File Offset: 0x008504D1
	public IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x17002C42 RID: 11330
	// (get) Token: 0x0601B1D7 RID: 111063 RVA: 0x008522D9 File Offset: 0x008504D9
	public IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x17002C43 RID: 11331
	// (get) Token: 0x0601B1D8 RID: 111064 RVA: 0x008522E1 File Offset: 0x008504E1
	public double TotalLength { get; }

	// Token: 0x0601B1D9 RID: 111065 RVA: 0x008522E9 File Offset: 0x008504E9
	public BezierArcLengthLookup(double[] paramSamples, double[] cumulativeArcLengths, double totalLength)
	{
		this.ParamSamples = paramSamples;
		this.CumulativeArcLengths = cumulativeArcLengths;
		this.TotalLength = totalLength;
	}
}
