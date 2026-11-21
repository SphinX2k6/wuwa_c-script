using System;
using System.Runtime.CompilerServices;

// Token: 0x020024B3 RID: 9395
[NullableContext(1)]
[Nullable(0)]
public class ModifyPassiveSkillProbability : BuffEffect
{
	// Token: 0x060175EA RID: 95722 RVA: 0x006E14CC File Offset: 0x006DF6CC
	public ModifyPassiveSkillProbability(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175EB RID: 95723 RVA: 0x006E14E4 File Offset: 0x006DF6E4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.PassiveSkillId = int.Parse(extraEffectParameters_[0]);
		this.ModifyType = (EPassiveProbabilityModifyType)int.Parse(extraEffectParameters_[1]);
		this.ProbabilityValues = parameters.ExtraEffectGrowParameters1;
	}

	// Token: 0x060175EC RID: 95724 RVA: 0x006E1520 File Offset: 0x006DF720
	public override void OnCreated()
	{
		this.Probability = AbilityUtils.GetLevelValue<float>(this.ProbabilityValues, this.Level, 0f);
	}

	// Token: 0x060175ED RID: 95725 RVA: 0x006E153E File Offset: 0x006DF73E
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175EE RID: 95726 RVA: 0x006E1541 File Offset: 0x006DF741
	public override void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x060175EF RID: 95727 RVA: 0x006E1544 File Offset: 0x006DF744
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		string text;
		if (this.PassiveSkillId != 0)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.PassiveSkillId);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			text = "(全部)";
		}
		string value = text;
		string value2 = (this.ModifyType == EPassiveProbabilityModifyType.Add) ? "+" : "*";
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 3);
		defaultInterpolatedStringHandler.AppendLiteral("修改被动技能");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("概率：");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Probability);
		defaultInterpolatedStringHandler.AppendLiteral("/10000");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060175F0 RID: 95728 RVA: 0x006E15E8 File Offset: 0x006DF7E8
	[NullableContext(2)]
	public static float CalculateFinalProbability(float baseProbability, long skillId, ExtraEffectManager buffEffectManager)
	{
		if (buffEffectManager == null)
		{
			return baseProbability;
		}
		float num = 0f;
		float num2 = 0f;
		foreach (ModifyPassiveSkillProbability modifyPassiveSkillProbability in buffEffectManager.FilterById<ModifyPassiveSkillProbability>(EExtraEffectId.ModifyPassiveSkillProbability, null))
		{
			if (modifyPassiveSkillProbability.PassiveSkillId == 0 || (long)modifyPassiveSkillProbability.PassiveSkillId == skillId)
			{
				if (modifyPassiveSkillProbability.ModifyType == EPassiveProbabilityModifyType.Add)
				{
					num += modifyPassiveSkillProbability.Probability;
				}
				else if (modifyPassiveSkillProbability.ModifyType == EPassiveProbabilityModifyType.Mul)
				{
					num2 += modifyPassiveSkillProbability.Probability;
				}
			}
		}
		return (baseProbability * (10000f + num2) + num) * 0.0001f;
	}

	// Token: 0x0400C62B RID: 50731
	public int PassiveSkillId;

	// Token: 0x0400C62C RID: 50732
	public EPassiveProbabilityModifyType ModifyType = EPassiveProbabilityModifyType.Add;

	// Token: 0x0400C62D RID: 50733
	public float Probability;

	// Token: 0x0400C62E RID: 50734
	[Nullable(2)]
	private float[] ProbabilityValues;
}
