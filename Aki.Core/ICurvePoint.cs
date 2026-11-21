using System;
using System.Runtime.CompilerServices;

// Token: 0x020000E8 RID: 232
[NullableContext(1)]
[Nullable(0)]
public abstract class ICurvePoint<[Nullable(2)] T> where T : new()
{
	// Token: 0x040005A8 RID: 1448
	public float InVal;

	// Token: 0x040005A9 RID: 1449
	public T OutVal = Activator.CreateInstance<T>();

	// Token: 0x040005AA RID: 1450
	public T ArriveTangent = Activator.CreateInstance<T>();

	// Token: 0x040005AB RID: 1451
	public T LeaveTangent = Activator.CreateInstance<T>();
}
