using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003499 RID: 13465
[NullableContext(1)]
[Nullable(0)]
public class CatmullRomArcLengthLookup : ICatmullRomArcLengthLookup
{
	// Token: 0x170028AF RID: 10415
	// (get) Token: 0x0601D4EA RID: 120042 RVA: 0x0082B5BC File Offset: 0x008297BC
	public IReadOnlyList<double> ParamSamples { get; }

	// Token: 0x170028B0 RID: 10416
	// (get) Token: 0x0601D4EB RID: 120043 RVA: 0x0082B5C4 File Offset: 0x008297C4
	public IReadOnlyList<double> CumulativeArcLengths { get; }

	// Token: 0x170028B1 RID: 10417
	// (get) Token: 0x0601D4EC RID: 120044 RVA: 0x0082B5CC File Offset: 0x008297CC
	public double TotalLength { get; }

	// Token: 0x0601D4ED RID: 120045 RVA: 0x0082B5D4 File Offset: 0x008297D4
	public CatmullRomArcLengthLookup(double[] paramSamples, double[] cumulativeArcLengths, double totalLength)
	{
		this.ParamSamples = paramSamples;
		this.CumulativeArcLengths = cumulativeArcLengths;
		this.TotalLength = totalLength;
	}
}
