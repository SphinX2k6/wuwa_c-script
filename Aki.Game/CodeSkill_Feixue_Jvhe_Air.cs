using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003183 RID: 12675
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhe_Air : CodeSkillBase
{
	// Token: 0x0601B432 RID: 111666 RVA: 0x0076FD11 File Offset: 0x0076DF11
	public CodeSkill_Feixue_Jvhe_Air(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B433 RID: 111667 RVA: 0x0076FD1C File Offset: 0x0076DF1C
	public override void OnBegin(Skill skill)
	{
		this.ClearParryWeakTask();
		this.RemoveCanLandEventListener();
		this.CanLand = false;
		this.LandCheckDone = false;
		this.MontageActive = false;
		this.ApplyStartBranch(skill);
		if (this.GetJvheStage() == 0)
		{
			this.PlayJvheMontage(skill, 0, 1);
			return;
		}
		this.PlayJvheMontage(skill, 1, 0);
	}

	// Token: 0x0601B434 RID: 111668 RVA: 0x0076FD6C File Offset: 0x0076DF6C
	public override void OnTick(float delta, Skill skill)
	{
		if (!this.MontageActive || !this.CanLand || this.LandCheckDone)
		{
			return;
		}
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		if (component.HasAllTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"],
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.其他"]
		}))
		{
			return;
		}
		this.LandCheckDone = true;
		if (component.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B435 RID: 111669 RVA: 0x0076FE03 File Offset: 0x0076E003
	public override void OnEnd(Skill skill)
	{
		this.MontageActive = false;
		this.ClearParryWeakTask();
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0601B436 RID: 111670 RVA: 0x0076FE18 File Offset: 0x0076E018
	private void ApplyStartBranch(Skill skill)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.居合叠层"]))
		{
			this.AddBuffs(skill, new long[]
			{
				1108409000L
			});
			this.CreateSkillBullet(skill, "1108124003");
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
		this.CreateSkillBullet(skill, "1108124001");
	}

	// Token: 0x0601B437 RID: 111671 RVA: 0x0076FF34 File Offset: 0x0076E134
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

	// Token: 0x0601B438 RID: 111672 RVA: 0x00770050 File Offset: 0x0076E250
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

	// Token: 0x0601B439 RID: 111673 RVA: 0x007700B8 File Offset: 0x0076E2B8
	private int GetJvheStage()
	{
		return BlackboardController.Instance.GetIntValueByEntity(base.Entity.Id, "居合段数").GetValueOrDefault();
	}

	// Token: 0x0601B43A RID: 111674 RVA: 0x007700E7 File Offset: 0x0076E2E7
	private void SetJvheStage(int value)
	{
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "居合段数", value);
	}

	// Token: 0x0601B43B RID: 111675 RVA: 0x00770104 File Offset: 0x0076E304
	private void PlayJvheMontage(Skill skill, int montageIndex, int nextStage)
	{
		this.MontageActive = true;
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
		this.RegisterCanLandEventListener();
	}

	// Token: 0x0601B43C RID: 111676 RVA: 0x0077017C File Offset: 0x0076E37C
	private void RegisterParryWeakListener()
	{
		this.ClearParryWeakTask();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ParryWeakTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.弹反成功弱"]), new BaseTagComponent.TTagSwitchedCallback(this.OnParryWeak), null) : null);
	}

	// Token: 0x0601B43D RID: 111677 RVA: 0x007701CE File Offset: 0x0076E3CE
	private void ClearParryWeakTask()
	{
		ITagTask parryWeakTask = this.ParryWeakTask;
		if (parryWeakTask != null)
		{
			parryWeakTask.EndTask();
		}
		this.ParryWeakTask = null;
	}

	// Token: 0x0601B43E RID: 111678 RVA: 0x007701E8 File Offset: 0x0076E3E8
	private void OnParryWeak(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		this.ClearParryWeakTask();
		this.DestroyGpBullets();
	}

	// Token: 0x0601B43F RID: 111679 RVA: 0x007701FC File Offset: 0x0076E3FC
	private void DestroyGpBullets()
	{
		int id = base.Entity.Id;
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-空中居合-GP子弹（无伤害）"), false, 0, 0f);
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-空中居合-GP拼刀子弹（无伤害）"), false, 0, 0f);
	}

	// Token: 0x0601B440 RID: 111680 RVA: 0x00770250 File Offset: 0x0076E450
	private void RegisterCanLandEventListener()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null || this.CanLandListenerActive)
		{
			return;
		}
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.可接地"], new TGameplayEventCallback(this.OnCanLandEvent));
		this.CanLandListenerActive = true;
	}

	// Token: 0x0601B441 RID: 111681 RVA: 0x007702A0 File Offset: 0x0076E4A0
	private void RemoveCanLandEventListener()
	{
		if (!this.CanLandListenerActive)
		{
			return;
		}
		this.CanLandListenerActive = false;
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.可接地"], new TGameplayEventCallback(this.OnCanLandEvent));
	}

	// Token: 0x0601B442 RID: 111682 RVA: 0x007702ED File Offset: 0x0076E4ED
	private void OnCanLandEvent(int tagId, FGameplayEventData payload)
	{
		this.CanLand = true;
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0400D4CD RID: 54477
	private const int JVHE_MONTAGE_INDEX = 0;

	// Token: 0x0400D4CE RID: 54478
	private const int JVHE_SECOND_MONTAGE_INDEX = 1;

	// Token: 0x0400D4CF RID: 54479
	private const string JVHE_STAGE_BLACKBOARD_KEY = "居合段数";

	// Token: 0x0400D4D0 RID: 54480
	private const string JVHE_BULLET_ID = "1108124001";

	// Token: 0x0400D4D1 RID: 54481
	private const string JVHE_NO_STACK_BULLET_ID = "1108124003";

	// Token: 0x0400D4D2 RID: 54482
	private const string GP_BULLET_NAME = "绯雪二形态-空中居合-GP子弹（无伤害）";

	// Token: 0x0400D4D3 RID: 54483
	private const string GP_PARRY_BULLET_NAME = "绯雪二形态-空中居合-GP拼刀子弹（无伤害）";

	// Token: 0x0400D4D4 RID: 54484
	[Nullable(2)]
	private ITagTask ParryWeakTask;

	// Token: 0x0400D4D5 RID: 54485
	private bool CanLand;

	// Token: 0x0400D4D6 RID: 54486
	private bool LandCheckDone;

	// Token: 0x0400D4D7 RID: 54487
	private bool MontageActive;

	// Token: 0x0400D4D8 RID: 54488
	private bool CanLandListenerActive;
}
