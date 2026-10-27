using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003182 RID: 12674
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhejiashi_Air : CodeSkillBase
{
	// Token: 0x0601B423 RID: 111651 RVA: 0x0076F85F File Offset: 0x0076DA5F
	public CodeSkill_Feixue_Jvhejiashi_Air(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B424 RID: 111652 RVA: 0x0076F88C File Offset: 0x0076DA8C
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

	// Token: 0x0601B425 RID: 111653 RVA: 0x0076F928 File Offset: 0x0076DB28
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

	// Token: 0x0601B426 RID: 111654 RVA: 0x0076F9BF File Offset: 0x0076DBBF
	public override void OnEnd(Skill skill)
	{
		this.StanceActive = false;
		this.ClearForegroundLostTask();
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0601B427 RID: 111655 RVA: 0x0076F9D4 File Offset: 0x0076DBD4
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

	// Token: 0x0601B428 RID: 111656 RVA: 0x0076FA4C File Offset: 0x0076DC4C
	private bool ShouldBackStepToTarget()
	{
		if (this.GetForwardInputValue() < 0.75f)
		{
			return false;
		}
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		return skillTarget != null && skillTarget.Valid && this.GetSkillTargetDistance() <= 1500.0;
	}

	// Token: 0x0601B429 RID: 111657 RVA: 0x0076FA9C File Offset: 0x0076DC9C
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

	// Token: 0x0601B42A RID: 111658 RVA: 0x0076FAD8 File Offset: 0x0076DCD8
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

	// Token: 0x0601B42B RID: 111659 RVA: 0x0076FB38 File Offset: 0x0076DD38
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

	// Token: 0x0601B42C RID: 111660 RVA: 0x0076FBB0 File Offset: 0x0076DDB0
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

	// Token: 0x0601B42D RID: 111661 RVA: 0x0076FC10 File Offset: 0x0076DE10
	private void ClearForegroundLostTask()
	{
		ITagTask foregroundLostTask = this.ForegroundLostTask;
		if (foregroundLostTask != null)
		{
			foregroundLostTask.EndTask();
		}
		this.ForegroundLostTask = null;
	}

	// Token: 0x0601B42E RID: 111662 RVA: 0x0076FC2C File Offset: 0x0076DE2C
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

	// Token: 0x0601B42F RID: 111663 RVA: 0x0076FC7C File Offset: 0x0076DE7C
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

	// Token: 0x0601B430 RID: 111664 RVA: 0x0076FCC9 File Offset: 0x0076DEC9
	private void OnCanLandEvent(int tagId, FGameplayEventData payload)
	{
		this.CanLand = true;
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0601B431 RID: 111665 RVA: 0x0076FCD8 File Offset: 0x0076DED8
	private static SSkillBehaviorAction CreateBackStepLocationAction()
	{
		return new SSkillBehaviorAction
		{
			LocationType = ESkillBehaviorLocationType.技能施法者,
			LocationForwardType = ESkillBehaviorLocationForwardType.位置基准目标正方向,
			LocationOffset = new FVector(-500f, 0f, 0f)
		};
	}

	// Token: 0x0400D4BF RID: 54463
	private const int STANCE_MONTAGE_INDEX = 0;

	// Token: 0x0400D4C0 RID: 54464
	private const float MAX_TARGET_DISTANCE = 1500f;

	// Token: 0x0400D4C1 RID: 54465
	private const float FORWARD_INPUT_THRESHOLD = 0.75f;

	// Token: 0x0400D4C2 RID: 54466
	private const float BACK_STEP_OFFSET = -500f;

	// Token: 0x0400D4C3 RID: 54467
	private const long AIR_JVHE_BUFF_ID = 1101004005L;

	// Token: 0x0400D4C4 RID: 54468
	private const string JVHE_STAGE_BLACKBOARD_KEY = "居合段数";

	// Token: 0x0400D4C5 RID: 54469
	[Nullable(2)]
	private ITagTask ForegroundLostTask;

	// Token: 0x0400D4C6 RID: 54470
	private bool CanLand;

	// Token: 0x0400D4C7 RID: 54471
	private bool LandCheckDone;

	// Token: 0x0400D4C8 RID: 54472
	private bool StanceActive;

	// Token: 0x0400D4C9 RID: 54473
	private bool EventListenerActive;

	// Token: 0x0400D4CA RID: 54474
	private readonly Vector MoveVector = Vector.Create();

	// Token: 0x0400D4CB RID: 54475
	private readonly SSkillBehaviorAction LocationAction = CodeSkill_Feixue_Jvhejiashi_Air.CreateBackStepLocationAction();

	// Token: 0x0400D4CC RID: 54476
	private readonly SSkillBehaviorAction RotationAction = new SSkillBehaviorAction();
}
