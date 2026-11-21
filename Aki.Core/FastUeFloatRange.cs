using System;
using UnrealEngine;

// Token: 0x020000F5 RID: 245
public class FastUeFloatRange
{
	// Token: 0x060007B1 RID: 1969 RVA: 0x00028BC4 File Offset: 0x00026DC4
	public FastUeFloatRange(FFloatRange range)
	{
		this.LowerBoundValue = (double)range.LowerBound.Value;
		this.UpperBoundValue = (double)range.UpperBound.Value;
		this.LowerBoundType = range.LowerBound.Type;
		this.UpperBoundType = range.UpperBound.Type;
	}

	// Token: 0x040005DC RID: 1500
	public double LowerBoundValue;

	// Token: 0x040005DD RID: 1501
	public double UpperBoundValue;

	// Token: 0x040005DE RID: 1502
	public ERangeBoundTypes LowerBoundType;

	// Token: 0x040005DF RID: 1503
	public ERangeBoundTypes UpperBoundType;
}
