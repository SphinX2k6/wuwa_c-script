using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003181 RID: 12673
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhejiashi : CodeSkillBase
{
	// Token: 0x0601B418 RID: 111640 RVA: 0x0076F589 File Offset: 0x0076D789
	public CodeSkill_Feixue_Jvhejiashi(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B419 RID: 111641 RVA: 0x0076F5B3 File Offset: 0x0076D7B3
	public override void OnBegin(Skill skill)
	{
		this.ClearForegroundLostTask();
		if (this.ShouldBackStepToTarget())
		{
			this.ApplyBackStepAndRotation(skill);
		}
		this.PlayStanceMontage(skill);
	}

	// Token: 0x0601B41A RID: 111642 RVA: 0x0076F5D1 File Offset: 0x0076D7D1
	public override void OnEnd(Skill skill)
	{
		this.ClearForegroundLostTask();
	}

	// Token: 0x0601B41B RID: 111643 RVA: 0x0076F5DC File Offset: 0x0076D7DC
	private void PlayStanceMontage(Skill skill)
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
			return;
		}
		this.RegisterForegroundLostListener(skill);
	}

	// Token: 0x0601B41C RID: 111644 RVA: 0x0076F648 File Offset: 0x0076D848
	private bool ShouldBackStepToTarget()
	{
		if (this.GetForwardInputValue() < 0.75f)
		{
			return false;
		}
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		return skillTarget != null && skillTarget.Valid && this.GetSkillTargetDistance() <= 1500.0;
	}

	// Token: 0x0601B41D RID: 111645 RVA: 0x0076F698 File Offset: 0x0076D898
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

	// Token: 0x0601B41E RID: 111646 RVA: 0x0076F6D4 File Offset: 0x0076D8D4
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

	// Token: 0x0601B41F RID: 111647 RVA: 0x0076F734 File Offset: 0x0076D934
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
		component.SetActorLocation(value, "CodeSkill_Feixue_Jvhejiashi.LocationAction", false);
		FRotator value2 = SkillBehaviorAction.CalculateRotation(this.RotationAction, param);
		component.SetActorRotation(value2, "CodeSkill_Feixue_Jvhejiashi.RotationAction", false);
	}

	// Token: 0x0601B420 RID: 111648 RVA: 0x0076F7AC File Offset: 0x0076D9AC
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

	// Token: 0x0601B421 RID: 111649 RVA: 0x0076F80C File Offset: 0x0076DA0C
	private void ClearForegroundLostTask()
	{
		ITagTask foregroundLostTask = this.ForegroundLostTask;
		if (foregroundLostTask != null)
		{
			foregroundLostTask.EndTask();
		}
		this.ForegroundLostTask = null;
	}

	// Token: 0x0601B422 RID: 111650 RVA: 0x0076F826 File Offset: 0x0076DA26
	private static SSkillBehaviorAction CreateBackStepLocationAction()
	{
		return new SSkillBehaviorAction
		{
			LocationType = ESkillBehaviorLocationType.技能施法者,
			LocationForwardType = ESkillBehaviorLocationForwardType.位置基准目标正方向,
			LocationOffset = new FVector(-500f, 0f, 0f)
		};
	}

	// Token: 0x0400D4B7 RID: 54455
	private const int STANCE_MONTAGE_INDEX = 0;

	// Token: 0x0400D4B8 RID: 54456
	private const float MAX_TARGET_DISTANCE = 1500f;

	// Token: 0x0400D4B9 RID: 54457
	private const float FORWARD_INPUT_THRESHOLD = 0.75f;

	// Token: 0x0400D4BA RID: 54458
	private const float BACK_STEP_OFFSET = -500f;

	// Token: 0x0400D4BB RID: 54459
	[Nullable(2)]
	private ITagTask ForegroundLostTask;

	// Token: 0x0400D4BC RID: 54460
	private readonly Vector MoveVector = Vector.Create();

	// Token: 0x0400D4BD RID: 54461
	private readonly SSkillBehaviorAction LocationAction = CodeSkill_Feixue_Jvhejiashi.CreateBackStepLocationAction();

	// Token: 0x0400D4BE RID: 54462
	private readonly SSkillBehaviorAction RotationAction = new SSkillBehaviorAction();
}
