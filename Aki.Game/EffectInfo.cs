using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;

// Token: 0x02003490 RID: 13456
[NullableContext(1)]
[Nullable(0)]
public class EffectInfo
{
	// Token: 0x0601D345 RID: 119621 RVA: 0x00821B40 File Offset: 0x0081FD40
	public EffectInfo(BP_EffectActor_C effect, bool isInheritTimeDilation)
	{
		this.Effect = effect;
		this.IsInheritTimeDilation = isInheritTimeDilation;
	}

	// Token: 0x0400E656 RID: 58966
	public BP_EffectActor_C Effect;

	// Token: 0x0400E657 RID: 58967
	public int EffectId;

	// Token: 0x0400E658 RID: 58968
	public bool IsPlaying;

	// Token: 0x0400E659 RID: 58969
	public bool IsInheritTimeDilation;
}
