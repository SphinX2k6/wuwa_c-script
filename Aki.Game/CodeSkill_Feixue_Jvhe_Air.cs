using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026F0 RID: 9968
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhe_Air : CodeSkillBase
{
	// Token: 0x06018F37 RID: 102199 RVA: 0x00797675 File Offset: 0x00795875
	public CodeSkill_Feixue_Jvhe_Air(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F38 RID: 102200 RVA: 0x00797680 File Offset: 0x00795880
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

	// Token: 0x06018F39 RID: 102201 RVA: 0x007976D0 File Offset: 0x007958D0
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

	// Token: 0x06018F3A RID: 102202 RVA: 0x00797767 File Offset: 0x00795967
	public override void OnEnd(Skill skill)
	{
		this.MontageActive = false;
		this.ClearParryWeakTask();
		this.RemoveCanLandEventListener();
	}

	// Token: 0x06018F3B RID: 102203 RVA: 0x0079777C File Offset: 0x0079597C
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

	// Token: 0x06018F3C RID: 102204 RVA: 0x00797898 File Offset: 0x00795A98
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

	// Token: 0x06018F3D RID: 102205 RVA: 0x007979B4 File Offset: 0x00795BB4
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

	// Token: 0x06018F3E RID: 102206 RVA: 0x00797A1C File Offset: 0x00795C1C
	private int GetJvheStage()
	{
		return BlackboardController.Instance.GetIntValueByEntity(base.Entity.Id, "居合段数").GetValueOrDefault();
	}

	// Token: 0x06018F3F RID: 102207 RVA: 0x00797A4B File Offset: 0x00795C4B
	private void SetJvheStage(int value)
	{
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "居合段数", value);
	}

	// Token: 0x06018F40 RID: 102208 RVA: 0x00797A68 File Offset: 0x00795C68
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

	// Token: 0x06018F41 RID: 102209 RVA: 0x00797AE0 File Offset: 0x00795CE0
	private void RegisterParryWeakListener()
	{
		this.ClearParryWeakTask();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ParryWeakTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.弹反成功弱"]), new BaseTagComponent.TTagSwitchedCallback(this.OnParryWeak), null) : null);
	}

	// Token: 0x06018F42 RID: 102210 RVA: 0x00797B32 File Offset: 0x00795D32
	private void ClearParryWeakTask()
	{
		ITagTask parryWeakTask = this.ParryWeakTask;
		if (parryWeakTask != null)
		{
			parryWeakTask.EndTask();
		}
		this.ParryWeakTask = null;
	}

	// Token: 0x06018F43 RID: 102211 RVA: 0x00797B4C File Offset: 0x00795D4C
	private void OnParryWeak(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		this.ClearParryWeakTask();
		this.DestroyGpBullets();
	}

	// Token: 0x06018F44 RID: 102212 RVA: 0x00797B60 File Offset: 0x00795D60
	private void DestroyGpBullets()
	{
		int id = base.Entity.Id;
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-空中居合-GP子弹（无伤害）"), false, 0, 0f);
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-空中居合-GP拼刀子弹（无伤害）"), false, 0, 0f);
	}

	// Token: 0x06018F45 RID: 102213 RVA: 0x00797BB4 File Offset: 0x00795DB4
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

	// Token: 0x06018F46 RID: 102214 RVA: 0x00797C04 File Offset: 0x00795E04
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

	// Token: 0x06018F47 RID: 102215 RVA: 0x00797C51 File Offset: 0x00795E51
	private void OnCanLandEvent(int tagId, FGameplayEventData payload)
	{
		this.CanLand = true;
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0400D930 RID: 55600
	private const int JVHE_MONTAGE_INDEX = 0;

	// Token: 0x0400D931 RID: 55601
	private const int JVHE_SECOND_MONTAGE_INDEX = 1;

	// Token: 0x0400D932 RID: 55602
	private const string JVHE_STAGE_BLACKBOARD_KEY = "居合段数";

	// Token: 0x0400D933 RID: 55603
	private const string JVHE_BULLET_ID = "1108124001";

	// Token: 0x0400D934 RID: 55604
	private const string JVHE_NO_STACK_BULLET_ID = "1108124003";

	// Token: 0x0400D935 RID: 55605
	private const string GP_BULLET_NAME = "绯雪二形态-空中居合-GP子弹（无伤害）";

	// Token: 0x0400D936 RID: 55606
	private const string GP_PARRY_BULLET_NAME = "绯雪二形态-空中居合-GP拼刀子弹（无伤害）";

	// Token: 0x0400D937 RID: 55607
	[Nullable(2)]
	private ITagTask ParryWeakTask;

	// Token: 0x0400D938 RID: 55608
	private bool CanLand;

	// Token: 0x0400D939 RID: 55609
	private bool LandCheckDone;

	// Token: 0x0400D93A RID: 55610
	private bool MontageActive;

	// Token: 0x0400D93B RID: 55611
	private bool CanLandListenerActive;
}
