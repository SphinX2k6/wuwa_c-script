using System;
using System.Runtime.CompilerServices;

// Token: 0x0200121C RID: 4636
[NullableContext(1)]
[Nullable(0)]
public abstract class TEntityIdOrPos
{
	// Token: 0x0600B89D RID: 47261 RVA: 0x0036701F File Offset: 0x0036521F
	public static implicit operator TEntityIdOrPos(TrackVision value)
	{
		return new TEntityIdOrPos_TrackVision(value);
	}

	// Token: 0x0600B89E RID: 47262 RVA: 0x00367027 File Offset: 0x00365227
	public static implicit operator TEntityIdOrPos(Vector value)
	{
		return new TEntityIdOrPos_Vector(value);
	}

	// Token: 0x0600B89F RID: 47263 RVA: 0x0036702F File Offset: 0x0036522F
	public static implicit operator TEntityIdOrPos(int value)
	{
		return new TEntityIdOrPos_Int(value);
	}
}
