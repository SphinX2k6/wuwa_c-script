using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024A8 RID: 9384
[NullableContext(1)]
[Nullable(0)]
public class SpecialEnergyModifier : BuffEffect
{
	// Token: 0x060175A8 RID: 95656 RVA: 0x006DFC57 File Offset: 0x006DDE57
	public SpecialEnergyModifier(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175A9 RID: 95657 RVA: 0x006DFC68 File Offset: 0x006DDE68
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			return;
		}
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.ModifyEnergy = new HashSet<int>();
		for (int i = 0; i < array.Length; i++)
		{
			this.ModifyEnergy.Add(int.Parse(array[i]));
		}
		this.Percent = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
	}

	// Token: 0x060175AA RID: 95658 RVA: 0x006DFCD9 File Offset: 0x006DDED9
	public override void OnCreated()
	{
	}

	// Token: 0x060175AB RID: 95659 RVA: 0x006DFCDB File Offset: 0x006DDEDB
	public override void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x060175AC RID: 95660 RVA: 0x006DFCE0 File Offset: 0x006DDEE0
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length == 0)
		{
			return 0f;
		}
		int item = (int)parameters[0];
		if (this.ModifyEnergy == null || !this.ModifyEnergy.Contains(item))
		{
			return 0f;
		}
		float percent = this.Percent;
		IActiveBuff buff = base.Buff;
		return percent * (float)((buff != null) ? buff.StackCount : 1);
	}

	// Token: 0x060175AD RID: 95661 RVA: 0x006DFD48 File Offset: 0x006DDF48
	public override string GetDebugEffectString()
	{
		if (this.ModifyEnergy != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
			defaultInterpolatedStringHandler.AppendLiteral("结算特殊能量获取系数加成:生效能量ID");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", this.ModifyEnergy));
			defaultInterpolatedStringHandler.AppendLiteral(", 加成系数");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Percent);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return "";
	}

	// Token: 0x060175AE RID: 95662 RVA: 0x006DFDB0 File Offset: 0x006DDFB0
	public static float ApplyEffects([Nullable(2)] Entity attacker, BaseBuffComponent buffComp, EAttributeType attrId, RequirementPayload requirements)
	{
		CharacterBuffComponent characterBuffComponent = (attacker != null) ? attacker.GetComponent<CharacterBuffComponent>() : null;
		ExtraEffectManager extraEffectManager = (characterBuffComponent != null) ? characterBuffComponent.BuffEffectManager : null;
		if (extraEffectManager == null)
		{
			return 0f;
		}
		float num = 0f;
		foreach (SpecialEnergyModifier specialEnergyModifier in extraEffectManager.FilterById<SpecialEnergyModifier>(EExtraEffectId.SpecialEnergyModifier, null))
		{
			if (specialEnergyModifier.Check(requirements, buffComp))
			{
				num += (float)(specialEnergyModifier.Execute(new object[]
				{
					(int)attrId
				}) ?? 0f);
			}
		}
		if (characterBuffComponent != null && characterBuffComponent.IsRoleBuffComponent())
		{
			RoleBuffComponent roleBuffComponent = characterBuffComponent as RoleBuffComponent;
			if (roleBuffComponent != null && roleBuffComponent.HasBuffAuthority())
			{
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (((formationBuffComp != null) ? formationBuffComp.BuffEffectManager : null) != null)
				{
					foreach (SpecialEnergyModifier specialEnergyModifier2 in formationBuffComp.BuffEffectManager.FilterById<SpecialEnergyModifier>(EExtraEffectId.SpecialEnergyModifier, null))
					{
						if (specialEnergyModifier2.Check(requirements, buffComp))
						{
							num += (float)(specialEnergyModifier2.Execute(new object[]
							{
								(int)attrId
							}) ?? 0f);
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0400C60D RID: 50701
	[Nullable(2)]
	protected HashSet<int> ModifyEnergy;

	// Token: 0x0400C60E RID: 50702
	protected float Percent;
}
