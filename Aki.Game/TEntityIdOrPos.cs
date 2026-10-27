using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D5A RID: 7514
[NullableContext(1)]
[Nullable(0)]
public abstract class TEntityIdOrPos
{
	// Token: 0x0600E480 RID: 58496 RVA: 0x0035B46F File Offset: 0x0035966F
	public static implicit operator TEntityIdOrPos(TrackVision value)
	{
		return new TEntityIdOrPos_TrackVision(value);
	}

	// Token: 0x0600E481 RID: 58497 RVA: 0x0035B477 File Offset: 0x00359677
	public static implicit operator TEntityIdOrPos(Vector value)
	{
		return new TEntityIdOrPos_Vector(value);
	}

	// Token: 0x0600E482 RID: 58498 RVA: 0x0035B47F File Offset: 0x0035967F
	public static implicit operator TEntityIdOrPos(int value)
	{
		return new TEntityIdOrPos_Int(value);
	}
}
