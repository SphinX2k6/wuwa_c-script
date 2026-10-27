using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D5C RID: 7516
[NullableContext(1)]
[Nullable(0)]
public class TEntityIdOrPos_Vector : TEntityIdOrPos
{
	// Token: 0x0600E487 RID: 58503 RVA: 0x0035B4AE File Offset: 0x003596AE
	public TEntityIdOrPos_Vector(Vector value)
	{
	}

	// Token: 0x0600E488 RID: 58504 RVA: 0x0035B4BD File Offset: 0x003596BD
	public static implicit operator Vector(TEntityIdOrPos_Vector target)
	{
		return target.Value;
	}

	// Token: 0x0600E489 RID: 58505 RVA: 0x0035B4C5 File Offset: 0x003596C5
	public new static implicit operator TEntityIdOrPos_Vector(Vector value)
	{
		return new TEntityIdOrPos_Vector(value);
	}

	// Token: 0x0400695C RID: 26972
	public Vector Value = value;
}
