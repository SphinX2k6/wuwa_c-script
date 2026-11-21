using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A0D RID: 10765
[NullableContext(1)]
[Nullable(0)]
public class CatmullRomArcLengthLookup : ICatmullRomArcLengthLookup
{
	// Token: 0x17002C47 RID: 11335
	// (get) Token: 0x0601B1E6 RID: 111078 RVA: 0x00852820 File Offset: 0x00850A20
	public IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x17002C48 RID: 11336
	// (get) Token: 0x0601B1E7 RID: 111079 RVA: 0x00852828 File Offset: 0x00850A28
	public IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x17002C49 RID: 11337
	// (get) Token: 0x0601B1E8 RID: 111080 RVA: 0x00852830 File Offset: 0x00850A30
	public double TotalLength { get; }

	// Token: 0x0601B1E9 RID: 111081 RVA: 0x00852838 File Offset: 0x00850A38
	public CatmullRomArcLengthLookup(double[] paramSamples, double[] cumulativeArcLengths, double totalLength)
	{
		this.ParamSamples = paramSamples;
		this.CumulativeArcLengths = cumulativeArcLengths;
		this.TotalLength = totalLength;
	}
}
