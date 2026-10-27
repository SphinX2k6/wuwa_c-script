using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E6 RID: 230
[NullableContext(1)]
[Nullable(0)]
public abstract class ICurvePoint<[Nullable(2)] T> where T : new()
{
	// Token: 0x04000599 RID: 1433
	public float InVal;

	// Token: 0x0400059A RID: 1434
	public T OutVal = Activator.CreateInstance<T>();

	// Token: 0x0400059B RID: 1435
	public T ArriveTangent = Activator.CreateInstance<T>();

	// Token: 0x0400059C RID: 1436
	public T LeaveTangent = Activator.CreateInstance<T>();
}
