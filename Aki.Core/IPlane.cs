using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F9 RID: 249
[NullableContext(1)]
public interface IPlane : IVector, IVector2D
{
	// Token: 0x170000EB RID: 235
	// (get) Token: 0x0600082D RID: 2093
	// (set) Token: 0x0600082E RID: 2094
	double W { get; set; }

	// Token: 0x0600082F RID: 2095
	IPlane MultiplyEqual(double inB);

	// Token: 0x06000830 RID: 2096
	IPlane MultiplyEqual(IPlane inB);

	// Token: 0x06000831 RID: 2097
	IPlane MultiplyEqual(Vector inB, Vector outV);

	// Token: 0x06000832 RID: 2098
	Vector Multiply(Vector inB, Vector outV);

	// Token: 0x06000833 RID: 2099
	Vector Multiply(double inB, Vector outV);

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000834 RID: 2100
	// (set) Token: 0x06000835 RID: 2101
	double[] Tuple { get; set; }
}
