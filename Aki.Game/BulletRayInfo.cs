using System;
using System.Runtime.CompilerServices;

// Token: 0x02002376 RID: 9078
[NullableContext(1)]
[Nullable(0)]
public class BulletRayInfo
{
	// Token: 0x0400BDF0 RID: 48624
	public double Length;

	// Token: 0x0400BDF1 RID: 48625
	public Vector StartPoint = Vector.Create();

	// Token: 0x0400BDF2 RID: 48626
	public Vector EndPoint = Vector.Create();

	// Token: 0x0400BDF3 RID: 48627
	public bool IsBlock;

	// Token: 0x0400BDF4 RID: 48628
	public bool BlockByCharacter;

	// Token: 0x0400BDF5 RID: 48629
	public double Speed;
}
