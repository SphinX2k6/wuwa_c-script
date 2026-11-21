using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F9 RID: 249
[NullableContext(1)]
public interface IPlane : IVector, IVector2D
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000873 RID: 2163
	// (set) Token: 0x06000874 RID: 2164
	double W { get; set; }

	// Token: 0x06000875 RID: 2165
	IPlane MultiplyEqual(double inB);

	// Token: 0x06000876 RID: 2166
	IPlane MultiplyEqual(IPlane inB);

	// Token: 0x06000877 RID: 2167
	IPlane MultiplyEqual(Vector inB, Vector outV);

	// Token: 0x06000878 RID: 2168
	Vector Multiply(Vector inB, Vector outV);

	// Token: 0x06000879 RID: 2169
	Vector Multiply(double inB, Vector outV);

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x0600087A RID: 2170
	// (set) Token: 0x0600087B RID: 2171
	double[] Tuple { get; set; }
}
