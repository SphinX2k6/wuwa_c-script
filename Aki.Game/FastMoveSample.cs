using System;
using System.Runtime.CompilerServices;

// Token: 0x0200307A RID: 12410
[NullableContext(1)]
[Nullable(0)]
public class FastMoveSample : IClear
{
	// Token: 0x0601A811 RID: 108561 RVA: 0x00716A39 File Offset: 0x00714C39
	public bool ClearObject()
	{
		return true;
	}

	// Token: 0x0400CB5A RID: 52058
	public Vector Location = Vector.Create();

	// Token: 0x0400CB5B RID: 52059
	public Rotator Rotation = Rotator.Create();

	// Token: 0x0400CB5C RID: 52060
	public Vector LinearVelocity = Vector.Create();

	// Token: 0x0400CB5D RID: 52061
	public int MovementMode;
}
