using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F5F RID: 12127
[NullableContext(1)]
[Nullable(0)]
public class ModifyPassiveSkillProbability : BuffEffect
{
	// Token: 0x06019CD8 RID: 105688 RVA: 0x006BABE0 File Offset: 0x006B8DE0
	public ModifyPassiveSkillProbability(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CD9 RID: 105689 RVA: 0x006BABF8 File Offset: 0x006B8DF8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.PassiveSkillId = int.Parse(extraEffectParameters_[0]);
		this.ModifyType = (EPassiveProbabilityModifyType)int.Parse(extraEffectParameters_[1]);
		this.ProbabilityValues = parameters.ExtraEffectGrowParameters1;
	}

	// Token: 0x06019CDA RID: 105690 RVA: 0x006BAC34 File Offset: 0x006B8E34
	public override void OnCreated()
	{
		this.Probability = AbilityUtils.GetLevelValue<float>(this.ProbabilityValues, this.Level, 0f);
	}

	// Token: 0x06019CDB RID: 105691 RVA: 0x006BAC52 File Offset: 0x006B8E52
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CDC RID: 105692 RVA: 0x006BAC55 File Offset: 0x006B8E55
	public override void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06019CDD RID: 105693 RVA: 0x006BAC58 File Offset: 0x006B8E58
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

	// Token: 0x06019CDE RID: 105694 RVA: 0x006BACFC File Offset: 0x006B8EFC
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

	// Token: 0x0400C282 RID: 49794
	public int PassiveSkillId;

	// Token: 0x0400C283 RID: 49795
	public EPassiveProbabilityModifyType ModifyType = EPassiveProbabilityModifyType.Add;

	// Token: 0x0400C284 RID: 49796
	public float Probability;

	// Token: 0x0400C285 RID: 49797
	[Nullable(2)]
	private float[] ProbabilityValues;
}
