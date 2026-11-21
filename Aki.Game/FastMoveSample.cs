using System;
using System.Runtime.CompilerServices;

// Token: 0x020025D1 RID: 9681
[NullableContext(1)]
[Nullable(0)]
public class FastMoveSample : IClear
{
	// Token: 0x060181E2 RID: 98786 RVA: 0x0073D189 File Offset: 0x0073B389
	public bool ClearObject()
	{
		return true;
	}

	// Token: 0x0400CF3D RID: 53053
	public Vector Location = Vector.Create();

	// Token: 0x0400CF3E RID: 53054
	public Rotator Rotation = Rotator.Create();

	// Token: 0x0400CF3F RID: 53055
	public Vector LinearVelocity = Vector.Create();

	// Token: 0x0400CF40 RID: 53056
	public int MovementMode;
}
