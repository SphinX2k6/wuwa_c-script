using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;
using CSharpScript.Game.World.Model;

// Token: 0x02002F2C RID: 12076
[NullableContext(1)]
[Nullable(0)]
public class DamageFilter : BuffEffect
{
	// Token: 0x06019BAA RID: 105386 RVA: 0x006B3390 File Offset: 0x006B1590
	public DamageFilter(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BAB RID: 105387 RVA: 0x006B33A0 File Offset: 0x006B15A0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.Condition = bool.Parse((((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? extraEffectParameters_[0] : "0") == "1") ? "true" : "false");
	}

	// Token: 0x06019BAC RID: 105388 RVA: 0x006B33E8 File Offset: 0x006B15E8
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return !this.Condition;
	}

	// Token: 0x06019BAD RID: 105389 RVA: 0x006B33F8 File Offset: 0x006B15F8
	public static bool ApplyEffects(Entity attackerEntity, Entity targetEntity, string bulletId, IReadOnlyList<int> bulletTags, int skillId, long damageId, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> battleFlags)
	{
		BaseBuffComponent component = attackerEntity.GetComponent<BaseBuffComponent>();
		BaseBuffComponent component2 = targetEntity.GetComponent<BaseBuffComponent>();
		if (component == null || component2 == null)
		{
			return false;
		}
		if (!component2.BuffEffectManager.HasAnyById(DamageFilter.DamageFilterIds))
		{
			return false;
		}
		BaseSkillComponent component3 = attackerEntity.GetComponent<BaseSkillComponent>();
		RequirementPayload requirementPayload = new RequirementPayload();
		if (skillId != 0)
		{
			requirementPayload.SkillId = new int?(skillId);
			requirementPayload.SkillGenres = component3.GetSkillGenres(skillId);
		}
		DamageSnapshot damageSnapshot = (damageId != 0L) ? DamageModel.Instance.GetDamageSnapshotById(damageId) : null;
		if (damageSnapshot != null)
		{
			requirementPayload.DamageType = new int?(damageSnapshot.Type);
			requirementPayload.DamageSubTypes = damageSnapshot.SubTypes;
			requirementPayload.CalculateType = new int?(damageSnapshot.CalculateType);
			requirementPayload.SmashType = new int?(damageSnapshot.SmashType);
			requirementPayload.ElementType = new EElementType?(ModifyDamageElement.ApplyEffects(component, damageSnapshot.Id) ?? ((EElementType)damageSnapshot.Element));
		}
		requirementPayload.BulletId = new long?(long.Parse(bulletId));
		requirementPayload.BulletTags = bulletTags;
		requirementPayload.BattleFlags = (battleFlags ?? Array.Empty<string>());
		Partial_RequirementPayload partial_RequirementPayload = requirementPayload;
		RoleGrowComponent component4 = attackerEntity.GetComponent<RoleGrowComponent>();
		partial_RequirementPayload.WeaponType = new int?((component4 != null) ? component4.GetWeaponType() : -2);
		foreach (DamageFilter damageFilter in component2.BuffEffectManager.FilterById<DamageFilter>(EExtraEffectId.DamageFilter, null))
		{
			if (damageFilter.Check(requirementPayload, component) == ((bool?)damageFilter.Execute(Array.Empty<object>())).GetValueOrDefault())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0400C1EC RID: 49644
	private bool Condition;

	// Token: 0x0400C1ED RID: 49645
	[StaticVariableRuleIgnore]
	private static readonly EExtraEffectId[] DamageFilterIds = new EExtraEffectId[]
	{
		EExtraEffectId.DamageFilter
	};
}
