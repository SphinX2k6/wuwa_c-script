using System;
using System.Runtime.CompilerServices;

// Token: 0x0200121E RID: 4638
[NullableContext(1)]
[Nullable(0)]
public class TEntityIdOrPos_Vector : TEntityIdOrPos
{
	// Token: 0x0600B8A4 RID: 47268 RVA: 0x0036705E File Offset: 0x0036525E
	public TEntityIdOrPos_Vector(Vector value)
	{
	}

	// Token: 0x0600B8A5 RID: 47269 RVA: 0x0036706D File Offset: 0x0036526D
	public static implicit operator Vector(TEntityIdOrPos_Vector target)
	{
		return target.Value;
	}

	// Token: 0x0600B8A6 RID: 47270 RVA: 0x00367075 File Offset: 0x00365275
	public new static implicit operator TEntityIdOrPos_Vector(Vector value)
	{
		return new TEntityIdOrPos_Vector(value);
	}

	// Token: 0x04006A3C RID: 27196
	public Vector Value = value;
}
