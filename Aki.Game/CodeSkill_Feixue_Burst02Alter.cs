using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E9 RID: 9961
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Burst02Alter : CodeSkillBase
{
	// Token: 0x06018EF2 RID: 102130 RVA: 0x0079615E File Offset: 0x0079435E
	public CodeSkill_Feixue_Burst02Alter(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EF3 RID: 102131 RVA: 0x00796168 File Offset: 0x00794368
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

	// Token: 0x06018EF4 RID: 102132 RVA: 0x007961BC File Offset: 0x007943BC
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

	// Token: 0x06018EF5 RID: 102133 RVA: 0x007962B4 File Offset: 0x007944B4
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

	// Token: 0x0400D8FC RID: 55548
	private const long STACK_BUFF_ID = 1108101301L;

	// Token: 0x0400D8FD RID: 55549
	private const long CLEAR_STACK_BUFF_ID = 1108101302L;

	// Token: 0x0400D8FE RID: 55550
	private const long FULL_STACK_DAMAGE_BUFF_ID = 1108101304L;

	// Token: 0x0400D8FF RID: 55551
	private const int BURST_MONTAGE_INDEX = 0;

	// Token: 0x0400D900 RID: 55552
	private const int FULL_STACK_COUNT = 3;
}
