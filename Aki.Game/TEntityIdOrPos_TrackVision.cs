using System;
using System.Runtime.CompilerServices;

// Token: 0x0200121D RID: 4637
[NullableContext(1)]
[Nullable(0)]
public class TEntityIdOrPos_TrackVision : TEntityIdOrPos
{
	// Token: 0x0600B8A1 RID: 47265 RVA: 0x0036703F File Offset: 0x0036523F
	public TEntityIdOrPos_TrackVision(TrackVision value)
	{
	}

	// Token: 0x0600B8A2 RID: 47266 RVA: 0x0036704E File Offset: 0x0036524E
	public static implicit operator TrackVision(TEntityIdOrPos_TrackVision target)
	{
		return target.Value;
	}

	// Token: 0x0600B8A3 RID: 47267 RVA: 0x00367056 File Offset: 0x00365256
	public new static implicit operator TEntityIdOrPos_TrackVision(TrackVision value)
	{
		return new TEntityIdOrPos_TrackVision(value);
	}

	// Token: 0x04006A3B RID: 27195
	public TrackVision Value = value;
}
