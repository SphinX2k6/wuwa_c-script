using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E1A RID: 11802
[NullableContext(1)]
[Nullable(0)]
public class BulletRayInfo
{
	// Token: 0x0400BA62 RID: 47714
	public double Length;

	// Token: 0x0400BA63 RID: 47715
	public Vector StartPoint = Vector.Create();

	// Token: 0x0400BA64 RID: 47716
	public Vector EndPoint = Vector.Create();

	// Token: 0x0400BA65 RID: 47717
	public bool IsBlock;

	// Token: 0x0400BA66 RID: 47718
	public bool BlockByCharacter;

	// Token: 0x0400BA67 RID: 47719
	public double Speed;
}
