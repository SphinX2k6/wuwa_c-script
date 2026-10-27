using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F55 RID: 12117
[NullableContext(1)]
[Nullable(0)]
public class SpecialEnergyModifier : BuffEffect
{
	// Token: 0x06019C9D RID: 105629 RVA: 0x006B993B File Offset: 0x006B7B3B
	public SpecialEnergyModifier(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C9E RID: 105630 RVA: 0x006B994C File Offset: 0x006B7B4C
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

	// Token: 0x06019C9F RID: 105631 RVA: 0x006B99BD File Offset: 0x006B7BBD
	public override void OnCreated()
	{
	}

	// Token: 0x06019CA0 RID: 105632 RVA: 0x006B99BF File Offset: 0x006B7BBF
	public override void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06019CA1 RID: 105633 RVA: 0x006B99C4 File Offset: 0x006B7BC4
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

	// Token: 0x06019CA2 RID: 105634 RVA: 0x006B9A2C File Offset: 0x006B7C2C
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

	// Token: 0x06019CA3 RID: 105635 RVA: 0x006B9A94 File Offset: 0x006B7C94
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

	// Token: 0x0400C26B RID: 49771
	[Nullable(2)]
	protected HashSet<int> ModifyEnergy;

	// Token: 0x0400C26C RID: 49772
	protected float Percent;
}
