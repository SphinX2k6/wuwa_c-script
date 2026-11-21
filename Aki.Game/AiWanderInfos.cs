using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020000F9 RID: 249
public class AiWanderInfos
{
	// Token: 0x06000E18 RID: 3608 RVA: 0x00050FC7 File Offset: 0x0004F1C7
	public void SetOverrideBattleWanderTime(float min, float max)
	{
		this.OverrideBattleWanderTimeMin = new float?(min);
		this.OverrideBattleWanderTimeMax = new float?(max);
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00050FE1 File Offset: 0x0004F1E1
	public AiBattleWanderGroup GetCurrentBattleWander()
	{
		return this.AiBattleWanderGroups[this.CurrentBattleWanderIndex];
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00050FF4 File Offset: 0x0004F1F4
	public double RandomBattleWanderEndTime()
	{
		if (this.OverrideBattleWanderTimeMin != null)
		{
			float? overrideBattleWanderTimeMin = this.OverrideBattleWanderTimeMin;
			float? overrideBattleWanderTimeMax = this.OverrideBattleWanderTimeMax;
			if (overrideBattleWanderTimeMin.GetValueOrDefault() <= overrideBattleWanderTimeMax.GetValueOrDefault() & (overrideBattleWanderTimeMin != null & overrideBattleWanderTimeMax != null))
			{
				return MathUtils.Instance.GetRandomRange((double)this.OverrideBattleWanderTimeMin.Value, (double)this.OverrideBattleWanderTimeMax.Value);
			}
		}
		FloatRange? sumWanderTime = this.GetCurrentBattleWander().SumWanderTime;
		return MathUtils.Instance.GetRandomRange((double)sumWanderTime.Value.Min, (double)sumWanderTime.Value.Max);
	}

	// Token: 0x04000B79 RID: 2937
	public AiWander? AiWander;

	// Token: 0x04000B7A RID: 2938
	[Nullable(2)]
	public List<AiBattleWanderGroup> AiBattleWanderGroups;

	// Token: 0x04000B7B RID: 2939
	public int CurrentBattleWanderIndex;

	// Token: 0x04000B7C RID: 2940
	private float? OverrideBattleWanderTimeMin;

	// Token: 0x04000B7D RID: 2941
	private float? OverrideBattleWanderTimeMax;

	// Token: 0x04000B7E RID: 2942
	public float BattleWanderAddTime;
}
