using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026EC RID: 9964
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_ExitSkill : CodeSkillBase
{
	// Token: 0x06018F0D RID: 102157 RVA: 0x00796958 File Offset: 0x00794B58
	public CodeSkill_Feixue_ExitSkill(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F0E RID: 102158 RVA: 0x00796961 File Offset: 0x00794B61
	public override void OnBegin(Skill skill)
	{
		this.AddExitSkillBuff(skill);
		base.EndSelf(skill);
	}

	// Token: 0x06018F0F RID: 102159 RVA: 0x00796974 File Offset: 0x00794B74
	private void AddExitSkillBuff(Skill skill)
	{
		RoleQteComponent component = base.Entity.GetComponent<RoleQteComponent>();
		TsBaseCharacter tsBaseCharacter = (component != null) ? component.GoBattleActor : null;
		Entity entity = (tsBaseCharacter != null) ? tsBaseCharacter.GetEntityNoBlueprint() : null;
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent == null)
		{
			return;
		}
		CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component2 != null) ? new long?(component2.GetCreatureDataId()) : null;
		if (num == null)
		{
			return;
		}
		string value = skill.SkillId.ToString();
		BaseBuffComponent baseBuffComponent = characterBuffComponent;
		long buffId = 2002204701L;
		AddBuffParam addBuffParam = new AddBuffParam();
		addBuffParam.InstigatorId = num.Value;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
		defaultInterpolatedStringHandler.AppendLiteral("技能");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("GA");
		UClass abilityClass = skill.AbilityClass;
		defaultInterpolatedStringHandler.AppendFormatted((abilityClass != null) ? abilityClass.GetName() : null);
		defaultInterpolatedStringHandler.AppendLiteral("的buff添加");
		addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
		addBuffParam.PreMessageId = skill.CombatMessageId;
		addBuffParam.OuterStackCount = new int?(1);
		baseBuffComponent.AddBuff(buffId, addBuffParam);
	}

	// Token: 0x0400D911 RID: 55569
	private const long EXIT_SKILL_BUFF_ID = 2002204701L;
}
