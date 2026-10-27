using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200317C RID: 12668
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Burst02Alter : CodeSkillBase
{
	// Token: 0x0601B3ED RID: 111597 RVA: 0x0076E7FA File Offset: 0x0076C9FA
	public CodeSkill_Feixue_Burst02Alter(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3EE RID: 111598 RVA: 0x0076E804 File Offset: 0x0076CA04
	public override void OnBegin(Skill skill)
	{
		BaseBuffComponent component = base.Entity.GetComponent<BaseBuffComponent>();
		if (((component != null) ? component.GetBuffTotalStackById(1108101301L, false) : 0) >= 3)
		{
			this.AddBuff(skill, 1108101302L, 1);
			this.AddBuff(skill, 1108101304L, 3);
		}
		this.PlayBurstMontage(skill);
	}

	// Token: 0x0601B3EF RID: 111599 RVA: 0x0076E858 File Offset: 0x0076CA58
	private void AddBuff(Skill skill, long buffId, int stackCount = 1)
	{
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component2 != null) ? new long?(component2.GetCreatureDataId()) : null;
		if (component != null && num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				BaseBuffComponent baseBuffComponent = component;
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = num.Value;
				addBuffParam.OuterStackCount = new int?(stackCount);
				addBuffParam.PreMessageId = skill.CombatMessageId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(skill.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("GA");
				UClass abilityClass = skill.AbilityClass;
				defaultInterpolatedStringHandler.AppendFormatted((abilityClass != null) ? abilityClass.GetName() : null);
				defaultInterpolatedStringHandler.AppendLiteral("的buff添加");
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				baseBuffComponent.AddBuff(buffId, addBuffParam);
				return;
			}
		}
	}

	// Token: 0x0601B3F0 RID: 111600 RVA: 0x0076E950 File Offset: 0x0076CB50
	private void PlayBurstMontage(Skill skill)
	{
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0400D499 RID: 54425
	private const long STACK_BUFF_ID = 1108101301L;

	// Token: 0x0400D49A RID: 54426
	private const long CLEAR_STACK_BUFF_ID = 1108101302L;

	// Token: 0x0400D49B RID: 54427
	private const long FULL_STACK_DAMAGE_BUFF_ID = 1108101304L;

	// Token: 0x0400D49C RID: 54428
	private const int BURST_MONTAGE_INDEX = 0;

	// Token: 0x0400D49D RID: 54429
	private const int FULL_STACK_COUNT = 3;
}
