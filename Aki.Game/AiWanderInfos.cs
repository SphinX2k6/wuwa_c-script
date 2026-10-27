using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020000F9 RID: 249
public class AiWanderInfos
{
	// Token: 0x06000E12 RID: 3602 RVA: 0x00050437 File Offset: 0x0004E637
	public void SetOverrideBattleWanderTime(float min, float max)
	{
		this.OverrideBattleWanderTimeMin = new float?(min);
		this.OverrideBattleWanderTimeMax = new float?(max);
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00050451 File Offset: 0x0004E651
	public AiBattleWanderGroup GetCurrentBattleWander()
	{
		return this.AiBattleWanderGroups[this.CurrentBattleWanderIndex];
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00050464 File Offset: 0x0004E664
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

	// Token: 0x04000B71 RID: 2929
	public AiWander? AiWander;

	// Token: 0x04000B72 RID: 2930
	[Nullable(2)]
	public List<AiBattleWanderGroup> AiBattleWanderGroups;

	// Token: 0x04000B73 RID: 2931
	public int CurrentBattleWanderIndex;

	// Token: 0x04000B74 RID: 2932
	private float? OverrideBattleWanderTimeMin;

	// Token: 0x04000B75 RID: 2933
	private float? OverrideBattleWanderTimeMax;

	// Token: 0x04000B76 RID: 2934
	public float BattleWanderAddTime;
}
