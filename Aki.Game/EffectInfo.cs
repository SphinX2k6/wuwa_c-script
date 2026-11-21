using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;

// Token: 0x02002A04 RID: 10756
[NullableContext(1)]
[Nullable(0)]
public class EffectInfo
{
	// Token: 0x0601B04B RID: 110667 RVA: 0x00848DDC File Offset: 0x00846FDC
	public EffectInfo(BP_EffectActor_C effect, bool isInheritTimeDilation)
	{
		this.Effect = effect;
		this.IsInheritTimeDilation = isInheritTimeDilation;
	}

	// Token: 0x0400EB0C RID: 60172
	public BP_EffectActor_C Effect;

	// Token: 0x0400EB0D RID: 60173
	public int EffectId;

	// Token: 0x0400EB0E RID: 60174
	public bool IsPlaying;

	// Token: 0x0400EB0F RID: 60175
	public bool IsInheritTimeDilation;
}
