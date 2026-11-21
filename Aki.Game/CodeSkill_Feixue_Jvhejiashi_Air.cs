using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020026EF RID: 9967
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhejiashi_Air : CodeSkillBase
{
	// Token: 0x06018F28 RID: 102184 RVA: 0x007971C3 File Offset: 0x007953C3
	public CodeSkill_Feixue_Jvhejiashi_Air(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F29 RID: 102185 RVA: 0x007971F0 File Offset: 0x007953F0
	public override void OnBegin(Skill skill)
	{
		this.ClearForegroundLostTask();
		this.RemoveCanLandEventListener();
		this.CanLand = false;
		this.LandCheckDone = false;
		this.StanceActive = false;
		BaseBuffComponent component = base.Entity.GetComponent<BaseBuffComponent>();
		if (component != null)
		{
			component.RemoveBuff(1101004005L, 1, "CodeSkill_Feixue_Jvhejiashi_Air.RemoveBuffById", null, null, null);
		}
		BlackboardController.Instance.SetIntValueByEntity(base.Entity.Id, "居合段数", 0);
		if (this.ShouldBackStepToTarget())
		{
			this.ApplyBackStepAndRotation(skill);
		}
		this.PlayStanceMontage(skill);
	}

	// Token: 0x06018F2A RID: 102186 RVA: 0x0079728C File Offset: 0x0079548C
	public override void OnTick(float delta, Skill skill)
	{
		if (!this.StanceActive || !this.CanLand || this.LandCheckDone)
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

	// Token: 0x06018F2B RID: 102187 RVA: 0x00797323 File Offset: 0x00795523
	public override void OnEnd(Skill skill)
	{
		this.StanceActive = false;
		this.ClearForegroundLostTask();
		this.RemoveCanLandEventListener();
	}

	// Token: 0x06018F2C RID: 102188 RVA: 0x00797338 File Offset: 0x00795538
	private void PlayStanceMontage(Skill skill)
	{
		this.StanceActive = true;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
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
		this.RegisterForegroundLostListener(skill);
		this.RegisterCanLandEventListener();
	}

	// Token: 0x06018F2D RID: 102189 RVA: 0x007973B0 File Offset: 0x007955B0
	private bool ShouldBackStepToTarget()
	{
		if (this.GetForwardInputValue() < 0.75f)
		{
			return false;
		}
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		return skillTarget != null && skillTarget.Valid && this.GetSkillTargetDistance() <= 1500.0;
	}

	// Token: 0x06018F2E RID: 102190 RVA: 0x00797400 File Offset: 0x00795600
	private float GetForwardInputValue()
	{
		CharacterInputComponent component = base.Entity.GetComponent<CharacterInputComponent>();
		if (component == null)
		{
			return 0f;
		}
		component.GetMoveVector(this.MoveVector);
		return (float)this.MoveVector.X;
	}

	// Token: 0x06018F2F RID: 102191 RVA: 0x0079743C File Offset: 0x0079563C
	private double GetSkillTargetDistance()
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		BaseActorComponent baseActorComponent;
		if (skillTarget == null)
		{
			baseActorComponent = null;
		}
		else
		{
			WorldEntity entity = skillTarget.Entity;
			baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
		}
		BaseActorComponent baseActorComponent2 = baseActorComponent;
		if (component == null || baseActorComponent2 == null)
		{
			return double.MaxValue;
		}
		return Vector.Dist(component.ActorLocationProxy, baseActorComponent2.ActorLocationProxy);
	}

	// Token: 0x06018F30 RID: 102192 RVA: 0x0079749C File Offset: 0x0079569C
	private void ApplyBackStepAndRotation(Skill skill)
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		BeginSkillBehaviorActionParam param = new BeginSkillBehaviorActionParam
		{
			Entity = base.Entity,
			SkillComponent = base.SkillComp,
			Skill = skill
		};
		FVectorDouble value = SkillBehaviorAction.CalculateLocation(this.LocationAction, param);
		component.SetActorLocation(value, "CodeSkill_Feixue_Jvhejiashi_Air.LocationAction", false);
		FRotator value2 = SkillBehaviorAction.CalculateRotation(this.RotationAction, param);
		component.SetActorRotation(value2, "CodeSkill_Feixue_Jvhejiashi_Air.RotationAction", false);
	}

	// Token: 0x06018F31 RID: 102193 RVA: 0x00797514 File Offset: 0x00795714
	private void RegisterForegroundLostListener(Skill skill)
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ForegroundLostTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]), delegate(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				this.EndSelf(skill);
			}
		}, null) : null);
	}

	// Token: 0x06018F32 RID: 102194 RVA: 0x00797574 File Offset: 0x00795774
	private void ClearForegroundLostTask()
	{
		ITagTask foregroundLostTask = this.ForegroundLostTask;
		if (foregroundLostTask != null)
		{
			foregroundLostTask.EndTask();
		}
		this.ForegroundLostTask = null;
	}

	// Token: 0x06018F33 RID: 102195 RVA: 0x00797590 File Offset: 0x00795790
	private void RegisterCanLandEventListener()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null || this.EventListenerActive)
		{
			return;
		}
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.可接地"], new TGameplayEventCallback(this.OnCanLandEvent));
		this.EventListenerActive = true;
	}

	// Token: 0x06018F34 RID: 102196 RVA: 0x007975E0 File Offset: 0x007957E0
	private void RemoveCanLandEventListener()
	{
		if (!this.EventListenerActive)
		{
			return;
		}
		this.EventListenerActive = false;
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.可接地"], new TGameplayEventCallback(this.OnCanLandEvent));
	}

	// Token: 0x06018F35 RID: 102197 RVA: 0x0079762D File Offset: 0x0079582D
	private void OnCanLandEvent(int tagId, FGameplayEventData payload)
	{
		this.CanLand = true;
		this.RemoveCanLandEventListener();
	}

	// Token: 0x06018F36 RID: 102198 RVA: 0x0079763C File Offset: 0x0079583C
	private static SSkillBehaviorAction CreateBackStepLocationAction()
	{
		return new SSkillBehaviorAction
		{
			LocationType = ESkillBehaviorLocationType.技能施法者,
			LocationForwardType = ESkillBehaviorLocationForwardType.位置基准目标正方向,
			LocationOffset = new FVector(-500f, 0f, 0f)
		};
	}

	// Token: 0x0400D922 RID: 55586
	private const int STANCE_MONTAGE_INDEX = 0;

	// Token: 0x0400D923 RID: 55587
	private const float MAX_TARGET_DISTANCE = 1500f;

	// Token: 0x0400D924 RID: 55588
	private const float FORWARD_INPUT_THRESHOLD = 0.75f;

	// Token: 0x0400D925 RID: 55589
	private const float BACK_STEP_OFFSET = -500f;

	// Token: 0x0400D926 RID: 55590
	private const long AIR_JVHE_BUFF_ID = 1101004005L;

	// Token: 0x0400D927 RID: 55591
	private const string JVHE_STAGE_BLACKBOARD_KEY = "居合段数";

	// Token: 0x0400D928 RID: 55592
	[Nullable(2)]
	private ITagTask ForegroundLostTask;

	// Token: 0x0400D929 RID: 55593
	private bool CanLand;

	// Token: 0x0400D92A RID: 55594
	private bool LandCheckDone;

	// Token: 0x0400D92B RID: 55595
	private bool StanceActive;

	// Token: 0x0400D92C RID: 55596
	private bool EventListenerActive;

	// Token: 0x0400D92D RID: 55597
	private readonly Vector MoveVector = Vector.Create();

	// Token: 0x0400D92E RID: 55598
	private readonly SSkillBehaviorAction LocationAction = CodeSkill_Feixue_Jvhejiashi_Air.CreateBackStepLocationAction();

	// Token: 0x0400D92F RID: 55599
	private readonly SSkillBehaviorAction RotationAction = new SSkillBehaviorAction();
}
