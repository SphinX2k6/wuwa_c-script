using System;
using UnrealEngine;

// Token: 0x020000F5 RID: 245
public class FastUeFloatRange
{
	// Token: 0x06000777 RID: 1911 RVA: 0x0002888C File Offset: 0x00026A8C
	public FastUeFloatRange(FFloatRange range)
	{
		this.LowerBoundValue = (double)range.LowerBound.Value;
		this.UpperBoundValue = (double)range.UpperBound.Value;
		this.LowerBoundType = range.LowerBound.Type;
		this.UpperBoundType = range.UpperBound.Type;
	}

	// Token: 0x040005D1 RID: 1489
	public double LowerBoundValue;

	// Token: 0x040005D2 RID: 1490
	public double UpperBoundValue;

	// Token: 0x040005D3 RID: 1491
	public ERangeBoundTypes LowerBoundType;

	// Token: 0x040005D4 RID: 1492
	public ERangeBoundTypes UpperBoundType;
}
