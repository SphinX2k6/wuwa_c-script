using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F4 RID: 9972
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Yangyang_XuliAttack : CodeSkillBase
{
	// Token: 0x06018F8D RID: 102285 RVA: 0x0079914C File Offset: 0x0079734C
	public CodeSkill_Yangyang_XuliAttack(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F8E RID: 102286 RVA: 0x0079916C File Offset: 0x0079736C
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

	// Token: 0x06018F8F RID: 102287 RVA: 0x00799220 File Offset: 0x00797420
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

	// Token: 0x06018F90 RID: 102288 RVA: 0x0079931B File Offset: 0x0079751B
	public override void OnEnd(Skill skill)
	{
		this.SetRootMotionScale(1f);
		this.ClearTimers();
	}

	// Token: 0x06018F91 RID: 102289 RVA: 0x0079932E File Offset: 0x0079752E
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

	// Token: 0x06018F92 RID: 102290 RVA: 0x00799360 File Offset: 0x00797560
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

	// Token: 0x06018F93 RID: 102291 RVA: 0x00799384 File Offset: 0x00797584
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

	// Token: 0x0400D96F RID: 55663
	private const int CHARGE_MONTAGE_INDEX = 0;

	// Token: 0x0400D970 RID: 55664
	private const float PRE_DELAY_MS = 270f;

	// Token: 0x0400D971 RID: 55665
	private const float SCALE_RESET_DELAY_MS = 430f;

	// Token: 0x0400D972 RID: 55666
	private const float BEHIND_ANGLE_DEG = 170f;

	// Token: 0x0400D973 RID: 55667
	private const float FAR_DISTANCE = 270f;

	// Token: 0x0400D974 RID: 55668
	private const float LERP_STEP = 0.1f;

	// Token: 0x0400D975 RID: 55669
	private const float ROOT_MOTION_SCALE_MAX = 1f;

	// Token: 0x0400D976 RID: 55670
	private const float ROOT_MOTION_SCALE_MIN = 0f;

	// Token: 0x0400D977 RID: 55671
	private float Lerp = 1f;

	// Token: 0x0400D978 RID: 55672
	private bool Switch;

	// Token: 0x0400D979 RID: 55673
	private bool TickActive;

	// Token: 0x0400D97A RID: 55674
	[Nullable(2)]
	private TimerHandle PreDelayTimer;

	// Token: 0x0400D97B RID: 55675
	[Nullable(2)]
	private TimerHandle ScaleResetTimer;

	// Token: 0x0400D97C RID: 55676
	private readonly Vector TmpDir = Vector.Create();
}
