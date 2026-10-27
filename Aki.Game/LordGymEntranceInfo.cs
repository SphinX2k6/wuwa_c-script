using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002191 RID: 8593
public class LordGymEntranceInfo
{
	// Token: 0x06010B5A RID: 68442 RVA: 0x0040F5B8 File Offset: 0x0040D7B8
	[NullableContext(1)]
	public void Phrase(Aki.Protocol.LordGymEntranceInfo info)
	{
		this.Id = info.Id;
		this.EffectBeginTime = (double)MathUtils.Instance.LongToNumber(info.EffectBeginTime) / 1000.0;
		this.EffectEndTime = (double)MathUtils.Instance.LongToNumber(info.EffectEndTime) / 1000.0;
	}

	// Token: 0x04007F42 RID: 32578
	public int Id;

	// Token: 0x04007F43 RID: 32579
	public double EffectBeginTime;

	// Token: 0x04007F44 RID: 32580
	public double EffectEndTime;
}
