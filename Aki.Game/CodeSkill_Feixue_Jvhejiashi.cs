using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020026EE RID: 9966
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Jvhejiashi : CodeSkillBase
{
	// Token: 0x06018F1D RID: 102173 RVA: 0x00796EED File Offset: 0x007950ED
	public CodeSkill_Feixue_Jvhejiashi(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F1E RID: 102174 RVA: 0x00796F17 File Offset: 0x00795117
	public override void OnBegin(Skill skill)
	{
		this.ClearForegroundLostTask();
		if (this.ShouldBackStepToTarget())
		{
			this.ApplyBackStepAndRotation(skill);
		}
		this.PlayStanceMontage(skill);
	}

	// Token: 0x06018F1F RID: 102175 RVA: 0x00796F35 File Offset: 0x00795135
	public override void OnEnd(Skill skill)
	{
		this.ClearForegroundLostTask();
	}

	// Token: 0x06018F20 RID: 102176 RVA: 0x00796F40 File Offset: 0x00795140
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

	// Token: 0x06018F21 RID: 102177 RVA: 0x00796FAC File Offset: 0x007951AC
	private bool ShouldBackStepToTarget()
	{
		if (this.GetForwardInputValue() < 0.75f)
		{
			return false;
		}
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		return skillTarget != null && skillTarget.Valid && this.GetSkillTargetDistance() <= 1500.0;
	}

	// Token: 0x06018F22 RID: 102178 RVA: 0x00796FFC File Offset: 0x007951FC
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

	// Token: 0x06018F23 RID: 102179 RVA: 0x00797038 File Offset: 0x00795238
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

	// Token: 0x06018F24 RID: 102180 RVA: 0x00797098 File Offset: 0x00795298
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

	// Token: 0x06018F25 RID: 102181 RVA: 0x00797110 File Offset: 0x00795310
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

	// Token: 0x06018F26 RID: 102182 RVA: 0x00797170 File Offset: 0x00795370
	private void ClearForegroundLostTask()
	{
		ITagTask foregroundLostTask = this.ForegroundLostTask;
		if (foregroundLostTask != null)
		{
			foregroundLostTask.EndTask();
		}
		this.ForegroundLostTask = null;
	}

	// Token: 0x06018F27 RID: 102183 RVA: 0x0079718A File Offset: 0x0079538A
	private static SSkillBehaviorAction CreateBackStepLocationAction()
	{
		return new SSkillBehaviorAction
		{
			LocationType = ESkillBehaviorLocationType.技能施法者,
			LocationForwardType = ESkillBehaviorLocationForwardType.位置基准目标正方向,
			LocationOffset = new FVector(-500f, 0f, 0f)
		};
	}

	// Token: 0x0400D91A RID: 55578
	private const int STANCE_MONTAGE_INDEX = 0;

	// Token: 0x0400D91B RID: 55579
	private const float MAX_TARGET_DISTANCE = 1500f;

	// Token: 0x0400D91C RID: 55580
	private const float FORWARD_INPUT_THRESHOLD = 0.75f;

	// Token: 0x0400D91D RID: 55581
	private const float BACK_STEP_OFFSET = -500f;

	// Token: 0x0400D91E RID: 55582
	[Nullable(2)]
	private ITagTask ForegroundLostTask;

	// Token: 0x0400D91F RID: 55583
	private readonly Vector MoveVector = Vector.Create();

	// Token: 0x0400D920 RID: 55584
	private readonly SSkillBehaviorAction LocationAction = CodeSkill_Feixue_Jvhejiashi.CreateBackStepLocationAction();

	// Token: 0x0400D921 RID: 55585
	private readonly SSkillBehaviorAction RotationAction = new SSkillBehaviorAction();
}
