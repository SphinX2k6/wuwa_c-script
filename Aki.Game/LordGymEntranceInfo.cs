using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001675 RID: 5749
public class LordGymEntranceInfo
{
	// Token: 0x0600DFEB RID: 57323 RVA: 0x0041BEA0 File Offset: 0x0041A0A0
	[NullableContext(1)]
	public void Phrase(Aki.Protocol.LordGymEntranceInfo info)
	{
		this.Id = info.Id;
		this.EffectBeginTime = (double)MathUtils.Instance.LongToNumber(info.EffectBeginTime) / 1000.0;
		this.EffectEndTime = (double)MathUtils.Instance.LongToNumber(info.EffectEndTime) / 1000.0;
	}

	// Token: 0x04008089 RID: 32905
	public int Id;

	// Token: 0x0400808A RID: 32906
	public double EffectBeginTime;

	// Token: 0x0400808B RID: 32907
	public double EffectEndTime;
}
