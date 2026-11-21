using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026ED RID: 9965
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhe : CodeSkillBase
{
	// Token: 0x06018F10 RID: 102160 RVA: 0x00796A86 File Offset: 0x00794C86
	public CodeSkill_Feixue_Jvhe(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F11 RID: 102161 RVA: 0x00796A8F File Offset: 0x00794C8F
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

	// Token: 0x06018F12 RID: 102162 RVA: 0x00796AB9 File Offset: 0x00794CB9
	public override void OnEnd(Skill skill)
	{
		this.ClearParryWeakTask();
	}

	// Token: 0x06018F13 RID: 102163 RVA: 0x00796AC4 File Offset: 0x00794CC4
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

	// Token: 0x06018F14 RID: 102164 RVA: 0x00796BE0 File Offset: 0x00794DE0
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

	// Token: 0x06018F15 RID: 102165 RVA: 0x00796CFC File Offset: 0x00794EFC
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

	// Token: 0x06018F16 RID: 102166 RVA: 0x00796D64 File Offset: 0x00794F64
	private int GetJvheStage()
	{
		return BlackboardController.Instance.GetIntValueByEntity(base.Entity.Id, "居合段数").GetValueOrDefault();
	}

	// Token: 0x06018F17 RID: 102167 RVA: 0x00796D93 File Offset: 0x00794F93
	private void SetJvheStage(int value)
	{
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "居合段数", value);
	}

	// Token: 0x06018F18 RID: 102168 RVA: 0x00796DB0 File Offset: 0x00794FB0
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

	// Token: 0x06018F19 RID: 102169 RVA: 0x00796E1C File Offset: 0x0079501C
	private void RegisterParryWeakListener()
	{
		this.ClearParryWeakTask();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ParryWeakTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.弹反成功弱"]), new BaseTagComponent.TTagSwitchedCallback(this.OnParryWeak), null) : null);
	}

	// Token: 0x06018F1A RID: 102170 RVA: 0x00796E6E File Offset: 0x0079506E
	private void ClearParryWeakTask()
	{
		ITagTask parryWeakTask = this.ParryWeakTask;
		if (parryWeakTask != null)
		{
			parryWeakTask.EndTask();
		}
		this.ParryWeakTask = null;
	}

	// Token: 0x06018F1B RID: 102171 RVA: 0x00796E88 File Offset: 0x00795088
	private void OnParryWeak(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		this.ClearParryWeakTask();
		this.DestroyGpBullets();
	}

	// Token: 0x06018F1C RID: 102172 RVA: 0x00796E9C File Offset: 0x0079509C
	private void DestroyGpBullets()
	{
		int id = base.Entity.Id;
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-地面居合-GP子弹（无伤害）"), false, 0, 0f);
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪二形态-地面居合-GP拼刀子弹（无伤害）"), false, 0, 0f);
	}

	// Token: 0x0400D912 RID: 55570
	private const int JVHE_MONTAGE_INDEX = 0;

	// Token: 0x0400D913 RID: 55571
	private const int JVHE_SECOND_MONTAGE_INDEX = 1;

	// Token: 0x0400D914 RID: 55572
	private const string JVHE_STAGE_BLACKBOARD_KEY = "居合段数";

	// Token: 0x0400D915 RID: 55573
	private const string JVHE_BULLET_ID = "1108122001";

	// Token: 0x0400D916 RID: 55574
	private const string JVHE_NO_STACK_BULLET_ID = "1108122003";

	// Token: 0x0400D917 RID: 55575
	private const string GP_BULLET_NAME = "绯雪二形态-地面居合-GP子弹（无伤害）";

	// Token: 0x0400D918 RID: 55576
	private const string GP_PARRY_BULLET_NAME = "绯雪二形态-地面居合-GP拼刀子弹（无伤害）";

	// Token: 0x0400D919 RID: 55577
	[Nullable(2)]
	private ITagTask ParryWeakTask;
}
