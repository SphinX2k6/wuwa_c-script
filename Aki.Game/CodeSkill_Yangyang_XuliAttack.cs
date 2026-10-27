using System;
using System.Runtime.CompilerServices;

// Token: 0x02003187 RID: 12679
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Yangyang_XuliAttack : CodeSkillBase
{
	// Token: 0x0601B488 RID: 111752 RVA: 0x007717E8 File Offset: 0x0076F9E8
	public CodeSkill_Yangyang_XuliAttack(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B489 RID: 111753 RVA: 0x00771808 File Offset: 0x0076FA08
	public override void OnBegin(Skill skill)
	{
		this.Lerp = 1f;
		this.Switch = false;
		this.TickActive = false;
		this.ClearTimers();
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, null))
		{
			base.EndSelf(skill);
			return;
		}
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		if (skillTarget != null && skillTarget.Valid)
		{
			this.PreDelayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.PreDelayTimer = null;
				this.StartRootMotionTask();
			}, 270f, null, null, true, 1f);
		}
	}

	// Token: 0x0601B48A RID: 111754 RVA: 0x007718BC File Offset: 0x0076FABC
	public override void OnTick(float delta, Skill skill)
	{
		if (!this.TickActive || this.Switch)
		{
			return;
		}
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
			return;
		}
		double num = Vector.Dist(component.ActorLocationProxy, baseActorComponent2.ActorLocationProxy);
		this.TmpDir.DeepCopy(baseActorComponent2.ActorLocationProxy);
		this.TmpDir.SubtractionEqual(component.ActorLocationProxy);
		this.TmpDir.Normalize(9.99999993922529E-09);
		if (GravityUtils.Instance.GetAngleOffsetInGravityAbsForActor(component, component.ActorForwardProxy, this.TmpDir) > 170f && num > 270.0)
		{
			this.Lerp = MathUtils.Instance.Clamp(this.Lerp - 0.1f, 0f, 1f);
			this.SetRootMotionScale(this.Lerp);
		}
	}

	// Token: 0x0601B48B RID: 111755 RVA: 0x007719B7 File Offset: 0x0076FBB7
	public override void OnEnd(Skill skill)
	{
		this.SetRootMotionScale(1f);
		this.ClearTimers();
	}

	// Token: 0x0601B48C RID: 111756 RVA: 0x007719CA File Offset: 0x0076FBCA
	private void StartRootMotionTask()
	{
		this.TickActive = true;
		this.ScaleResetTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ScaleResetTimer = null;
			this.SetRootMotionScale(1f);
			this.Switch = true;
		}, 430f, null, null, true, 1f);
	}

	// Token: 0x0601B48D RID: 111757 RVA: 0x007719FC File Offset: 0x0076FBFC
	private void SetRootMotionScale(float scale)
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		TsBaseCharacter actor = component.Actor;
		if (actor == null)
		{
			return;
		}
		actor.SetAnimRootMotionTranslationScale(scale);
	}

	// Token: 0x0601B48E RID: 111758 RVA: 0x00771A20 File Offset: 0x0076FC20
	private void ClearTimers()
	{
		if (this.PreDelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.PreDelayTimer);
			this.PreDelayTimer = null;
		}
		if (this.ScaleResetTimer != null)
		{
			TimerSystem.Instance.Remove(this.ScaleResetTimer);
			this.ScaleResetTimer = null;
		}
	}

	// Token: 0x0400D50C RID: 54540
	private const int CHARGE_MONTAGE_INDEX = 0;

	// Token: 0x0400D50D RID: 54541
	private const float PRE_DELAY_MS = 270f;

	// Token: 0x0400D50E RID: 54542
	private const float SCALE_RESET_DELAY_MS = 430f;

	// Token: 0x0400D50F RID: 54543
	private const float BEHIND_ANGLE_DEG = 170f;

	// Token: 0x0400D510 RID: 54544
	private const float FAR_DISTANCE = 270f;

	// Token: 0x0400D511 RID: 54545
	private const float LERP_STEP = 0.1f;

	// Token: 0x0400D512 RID: 54546
	private const float ROOT_MOTION_SCALE_MAX = 1f;

	// Token: 0x0400D513 RID: 54547
	private const float ROOT_MOTION_SCALE_MIN = 0f;

	// Token: 0x0400D514 RID: 54548
	private float Lerp = 1f;

	// Token: 0x0400D515 RID: 54549
	private bool Switch;

	// Token: 0x0400D516 RID: 54550
	private bool TickActive;

	// Token: 0x0400D517 RID: 54551
	[Nullable(2)]
	private TimerHandle PreDelayTimer;

	// Token: 0x0400D518 RID: 54552
	[Nullable(2)]
	private TimerHandle ScaleResetTimer;

	// Token: 0x0400D519 RID: 54553
	private readonly Vector TmpDir = Vector.Create();
}
