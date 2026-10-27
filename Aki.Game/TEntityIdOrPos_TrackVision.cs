using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D5B RID: 7515
[NullableContext(1)]
[Nullable(0)]
public class TEntityIdOrPos_TrackVision : TEntityIdOrPos
{
	// Token: 0x0600E484 RID: 58500 RVA: 0x0035B48F File Offset: 0x0035968F
	public TEntityIdOrPos_TrackVision(TrackVision value)
	{
	}

	// Token: 0x0600E485 RID: 58501 RVA: 0x0035B49E File Offset: 0x0035969E
	public static implicit operator TrackVision(TEntityIdOrPos_TrackVision target)
	{
		return target.Value;
	}

	// Token: 0x0600E486 RID: 58502 RVA: 0x0035B4A6 File Offset: 0x003596A6
	public new static implicit operator TEntityIdOrPos_TrackVision(TrackVision value)
	{
		return new TEntityIdOrPos_TrackVision(value);
	}

	// Token: 0x0400695B RID: 26971
	public TrackVision Value = value;
}
