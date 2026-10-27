using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200317F RID: 12671
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_ExitSkill : CodeSkillBase
{
	// Token: 0x0601B408 RID: 111624 RVA: 0x0076EFF4 File Offset: 0x0076D1F4
	public CodeSkill_Feixue_ExitSkill(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B409 RID: 111625 RVA: 0x0076EFFD File Offset: 0x0076D1FD
	public override void OnBegin(Skill skill)
	{
		this.AddExitSkillBuff(skill);
		base.EndSelf(skill);
	}

	// Token: 0x0601B40A RID: 111626 RVA: 0x0076F010 File Offset: 0x0076D210
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

	// Token: 0x0400D4AE RID: 54446
	private const long EXIT_SKILL_BUFF_ID = 2002204701L;
}
