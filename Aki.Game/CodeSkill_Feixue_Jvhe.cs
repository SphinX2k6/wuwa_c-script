using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003180 RID: 12672
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhe : CodeSkillBase
{
	// Token: 0x0601B40B RID: 111627 RVA: 0x0076F122 File Offset: 0x0076D322
	public CodeSkill_Feixue_Jvhe(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B40C RID: 111628 RVA: 0x0076F12B File Offset: 0x0076D32B
	public override void OnBegin(Skill skill)
	{
		this.ClearParryWeakTask();
		this.ApplyStartBranch(skill);
		if (this.GetJvheStage() == 0)
		{
			this.PlayJvheMontage(skill, 0, 1);
			return;
		}
		this.PlayJvheMontage(skill, 1, 0);
	}

	// Token: 0x0601B40D RID: 111629 RVA: 0x0076F155 File Offset: 0x0076D355
	public override void OnEnd(Skill skill)
	{
		this.ClearParryWeakTask();
	}

	// Token: 0x0601B40E RID: 111630 RVA: 0x0076F160 File Offset: 0x0076D360
	private void ApplyStartBranch(Skill skill)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.居合叠层"]))
		{
			this.AddBuffs(skill, new long[]
			{
				1108409000L
			});
			this.CreateSkillBullet(skill, "1108122003");
			return;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.3层印记"]))
		{
			this.AddBuffs(skill, new long[]
			{
				1108409000L,
				1108101702L
			});
		}
		else if (component.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.2层印记"]))
		{
			this.AddBuffs(skill, new long[]
			{
				1108201005L,
				1108401003L,
				1108409003L,
				1108101702L
			});
		}
		else if (component.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.1层印记"]))
		{
			this.AddBuffs(skill, new long[]
			{
				1108201004L,
				1108401002L,
				1108409002L,
				1108101702L
			});
		}
		else
		{
			this.AddBuffs(skill, new long[]
			{
				1108201003L,
				1108401001L,
				1108409001L,
				1108101702L
			});
		}
		this.CreateSkillBullet(skill, "1108122001");
	}

	// Token: 0x0601B40F RID: 111631 RVA: 0x0076F27C File Offset: 0x0076D47C
	private void AddBuffs(Skill skill, long[] buffIds)
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
				foreach (long num4 in buffIds)
				{
					BaseBuffComponent baseBuffComponent = component;
					long buffId = num4;
					AddBuffParam addBuffParam = new AddBuffParam();
					addBuffParam.InstigatorId = num.Value;
					addBuffParam.OuterStackCount = new int?(1);
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
				}
				return;
			}
		}
	}

	// Token: 0x0601B410 RID: 111632 RVA: 0x0076F398 File Offset: 0x0076D598
	private void CreateSkillBullet(Skill skill, string bulletId)
	{
		long? skillContextId = BulletUtil.GetSkillContextId(base.Entity, skill.SkillId);
		BulletController.Instance.CreateBulletCustomTarget(base.Entity, bulletId, null, new BulletController.BulletCreateParams
		{
			SkillId = skill.SkillId,
			SkillContextId = skillContextId,
			SyncType = EBulletSyncType.SyncCreate,
			BattleContext = skill.BattleContext
		}, skillContextId, EBulletCreateSource.Skill);
	}

	// Token: 0x0601B411 RID: 111633 RVA: 0x0076F400 File Offset: 0x0076D600
	private int GetJvheStage()
	{
		return BlackboardController.Instance.GetIntValueByEntity(base.Entity.Id, "居合段数").GetValueOrDefault();
	}

	// Token: 0x0601B412 RID: 111634 RVA: 0x0076F42F File Offset: 0x0076D62F
	private void SetJvheStage(int value)
	{
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "居合段数", value);
	}

	// Token: 0x0601B413 RID: 111635 RVA: 0x0076F44C File Offset: 0x0076D64C
	private void PlayJvheMontage(Skill skill, int montageIndex, int nextStage)
	{
		if (!base.SkillComp.PlaySkillMontage(montageIndex, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}))
		{
			base.EndSelf(skill);
			return;
		}
		this.SetJvheStage(nextStage);
		this.RegisterParryWeakListener();
	}

	// Token: 0x0601B414 RID: 111636 RVA: 0x0076F4B8 File Offset: 0x0076D6B8
	private void RegisterParryWeakListener()
	{
		this.ClearParryWeakTask();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ParryWeakTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.弹反成功弱"]), new BaseTagComponent.TTagSwitchedCallback(this.OnParryWeak), null) : null);
	}

	// Token: 0x0601B415 RID: 111637 RVA: 0x0076F50A File Offset: 0x0076D70A
	private void ClearParryWeakTask()
	{
		ITagTask parryWeakTask = this.ParryWeakTask;
		if (parryWeakTask != null)
		{
			parryWeakTask.EndTask();
		}
		this.ParryWeakTask = null;
	}

	// Token: 0x0601B416 RID: 111638 RVA: 0x0076F524 File Offset: 0x0076D724
	private void OnParryWeak(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		this.ClearParryWeakTask();
		this.DestroyGpBullets();
	}

	// Token: 0x0601B417 RID: 111639 RVA: 0x0076F538 File Offset: 0x0076D738
	private void DestroyGpBullets()
	{
		int id = base.Entity.Id;
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-地面居合-GP子弹（无伤害）"), false, 0, 0f);
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-地面居合-GP拼刀子弹（无伤害）"), false, 0, 0f);
	}

	// Token: 0x0400D4AF RID: 54447
	private const int JVHE_MONTAGE_INDEX = 0;

	// Token: 0x0400D4B0 RID: 54448
	private const int JVHE_SECOND_MONTAGE_INDEX = 1;

	// Token: 0x0400D4B1 RID: 54449
	private const string JVHE_STAGE_BLACKBOARD_KEY = "居合段数";

	// Token: 0x0400D4B2 RID: 54450
	private const string JVHE_BULLET_ID = "1108122001";

	// Token: 0x0400D4B3 RID: 54451
	private const string JVHE_NO_STACK_BULLET_ID = "1108122003";

	// Token: 0x0400D4B4 RID: 54452
	private const string GP_BULLET_NAME = "绯雪二形态-地面居合-GP子弹（无伤害）";

	// Token: 0x0400D4B5 RID: 54453
	private const string GP_PARRY_BULLET_NAME = "绯雪二形态-地面居合-GP拼刀子弹（无伤害）";

	// Token: 0x0400D4B6 RID: 54454
	[Nullable(2)]
	private ITagTask ParryWeakTask;
}
