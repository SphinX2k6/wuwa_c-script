using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002F58 RID: 12120
[NullableContext(1)]
[Nullable(0)]
public class AddSkillLevelEffect : BuffEffect
{
	// Token: 0x06019CB6 RID: 105654 RVA: 0x006BA189 File Offset: 0x006B8389
	public AddSkillLevelEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CB7 RID: 105655 RVA: 0x006BA1A4 File Offset: 0x006B83A4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.AddLevelMap.Clear();
		if (extraEffectParameters_ == null)
		{
			return;
		}
		string[] array = extraEffectParameters_;
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('#', StringSplitOptions.None);
			if (array2.Length >= 2)
			{
				int key = int.Parse(array2[0]);
				int value = int.Parse(array2[1]);
				this.AddLevelMap[key] = value;
			}
		}
	}

	// Token: 0x06019CB8 RID: 105656 RVA: 0x006BA20C File Offset: 0x006B840C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length == 0)
		{
			return 0;
		}
		int key = (int)parameters[0];
		return this.AddLevelMap.GetValueOrDefault(key, 0);
	}

	// Token: 0x06019CB9 RID: 105657 RVA: 0x006BA240 File Offset: 0x006B8440
	public static int ApplyEffects(Entity ownerEntity, Aki.Config.Skill skill, int skillLevel)
	{
		BaseBuffComponent component = ownerEntity.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return skillLevel;
		}
		ExtraEffectManager buffEffectManager = component.BuffEffectManager;
		if (buffEffectManager == null)
		{
			return skillLevel;
		}
		int num = skillLevel;
		int skillType = skill.SkillType;
		foreach (AddSkillLevelEffect addSkillLevelEffect in buffEffectManager.FilterById<AddSkillLevelEffect>(EExtraEffectId.AddSkillLevel, null))
		{
			if (addSkillLevelEffect.Check(new Partial_RequirementPayload(), component))
			{
				num += (int)(addSkillLevelEffect.Execute(new object[]
				{
					skillType
				}) ?? 0);
			}
		}
		if (component.IsRoleBuffComponent())
		{
			RoleBuffComponent roleBuffComponent = component as RoleBuffComponent;
			if (roleBuffComponent != null && roleBuffComponent.HasBuffAuthority())
			{
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (((formationBuffComp != null) ? formationBuffComp.BuffEffectManager : null) != null)
				{
					foreach (AddSkillLevelEffect addSkillLevelEffect2 in formationBuffComp.BuffEffectManager.FilterById<AddSkillLevelEffect>(EExtraEffectId.AddSkillLevel, null))
					{
						num += (int)(addSkillLevelEffect2.Execute(new object[]
						{
							skillType
						}) ?? 0);
					}
				}
			}
		}
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("MaxSkillCalcLvl").GetValueOrDefault(int.MaxValue);
		return Math.Min(num, valueOrDefault);
	}

	// Token: 0x06019CBA RID: 105658 RVA: 0x006BA3B4 File Offset: 0x006B85B4
	public override string GetDebugEffectString()
	{
		string text = "";
		foreach (KeyValuePair<int, int> keyValuePair in this.AddLevelMap)
		{
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("技能类型:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
			defaultInterpolatedStringHandler.AppendLiteral("增加技能等级");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	// Token: 0x0400C26F RID: 49775
	public Dictionary<int, int> AddLevelMap = new Dictionary<int, int>();
}
