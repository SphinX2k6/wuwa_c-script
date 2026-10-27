using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003496 RID: 13462
[NullableContext(1)]
[Nullable(0)]
public class BezierArcLengthLookup : IBezierArcLengthLookup
{
	// Token: 0x170028A9 RID: 10409
	// (get) Token: 0x0601D4DA RID: 120026 RVA: 0x0082B06D File Offset: 0x0082926D
	public IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x170028AA RID: 10410
	// (get) Token: 0x0601D4DB RID: 120027 RVA: 0x0082B075 File Offset: 0x00829275
	public IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x170028AB RID: 10411
	// (get) Token: 0x0601D4DC RID: 120028 RVA: 0x0082B07D File Offset: 0x0082927D
	public double TotalLength { get; }

	// Token: 0x0601D4DD RID: 120029 RVA: 0x0082B085 File Offset: 0x00829285
	public BezierArcLengthLookup(double[] paramSamples, double[] cumulativeArcLengths, double totalLength)
	{
		this.ParamSamples = paramSamples;
		this.CumulativeArcLengths = cumulativeArcLengths;
		this.TotalLength = totalLength;
	}
}
