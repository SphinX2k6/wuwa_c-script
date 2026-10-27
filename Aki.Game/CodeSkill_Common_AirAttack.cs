using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003178 RID: 12664
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Common_AirAttack : CodeSkillBase
{
	// Token: 0x0601B3C2 RID: 111554 RVA: 0x0076DBB8 File Offset: 0x0076BDB8
	public CodeSkill_Common_AirAttack(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3C3 RID: 111555 RVA: 0x0076DBCC File Offset: 0x0076BDCC
	public override void OnBegin(Skill skill)
	{
		this.Phase = CodeSkill_Common_AirAttack.EAirAttackPhase.None;
		this.LandAttack = false;
		this.BlockTime = 0f;
		this.LandCheckDone = false;
		this.Phase = CodeSkill_Common_AirAttack.EAirAttackPhase.Rise;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.OnRiseMontageEnd(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnRiseMontageBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3C4 RID: 111556 RVA: 0x0076DC50 File Offset: 0x0076BE50
	public override void OnTick(float delta, Skill skill)
	{
		if (this.Phase != CodeSkill_Common_AirAttack.EAirAttackPhase.AirAttack)
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
			this.UpdateBlockTime(skill);
			return;
		}
		if (!this.LandCheckDone)
		{
			this.LandCheckDone = true;
			if (component.HasAnyTag(new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]
			}))
			{
				this.LandAttack = true;
				this.StartLandAttackMontage(skill);
				return;
			}
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3C5 RID: 111557 RVA: 0x0076DCF8 File Offset: 0x0076BEF8
	public override void OnEnd(Skill skill)
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component != null)
		{
			TsBaseCharacter actor = component.Actor;
			if (actor != null)
			{
				UCapsuleComponent capsuleComponent = actor.CapsuleComponent;
				if (capsuleComponent != null)
				{
					capsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Block);
				}
			}
		}
		CharacterMoveComponent component2 = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.SetForceSpeed(Vector.ZeroVectorProxy);
	}

	// Token: 0x0601B3C6 RID: 111558 RVA: 0x0076DD4D File Offset: 0x0076BF4D
	private void OnRiseMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Common_AirAttack.EAirAttackPhase.Rise)
		{
			return;
		}
		if (isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		this.StartAirAttackMontage(skill);
	}

	// Token: 0x0601B3C7 RID: 111559 RVA: 0x0076DD6B File Offset: 0x0076BF6B
	private void OnRiseMontageEnd(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Common_AirAttack.EAirAttackPhase.Rise)
		{
			return;
		}
		if (isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		this.StartAirAttackMontage(skill);
	}

	// Token: 0x0601B3C8 RID: 111560 RVA: 0x0076DD8C File Offset: 0x0076BF8C
	private void StartAirAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Common_AirAttack.EAirAttackPhase.AirAttack;
		if (!base.SkillComp.PlaySkillMontage(1, "", 0f, delegate(bool isInterrupted)
		{
			this.OnAirMontageDone(skill, isInterrupted);
		}, null))
		{
			base.EndSelf(skill);
			return;
		}
		this.ApplySlamDownVelocity();
	}

	// Token: 0x0601B3C9 RID: 111561 RVA: 0x0076DDEC File Offset: 0x0076BFEC
	private void OnAirMontageDone(Skill skill, bool isInterrupted)
	{
		if (!isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		if (this.LandAttack)
		{
			return;
		}
		base.EndSelf(skill);
	}

	// Token: 0x0601B3CA RID: 111562 RVA: 0x0076DE0C File Offset: 0x0076C00C
	private void StartLandAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Common_AirAttack.EAirAttackPhase.LandAttack;
		if (!base.SkillComp.PlaySkillMontage(2, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, null))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3CB RID: 111563 RVA: 0x0076DE68 File Offset: 0x0076C068
	private void UpdateBlockTime(Skill skill)
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		object obj;
		if (component == null)
		{
			obj = null;
		}
		else
		{
			UCharacterMovementComponent characterMovement = component.CharacterMovement;
			obj = ((characterMovement != null) ? characterMovement.Kuro_GetBlockActorWhenMove() : null);
		}
		if (obj is AStaticMeshActor)
		{
			this.BlockTime += Time.Instance.DeltaTimeSeconds;
			if (this.BlockTime > 1f)
			{
				base.EndSelf(skill);
				return;
			}
		}
		else
		{
			this.BlockTime = 0f;
		}
	}

	// Token: 0x0601B3CC RID: 111564 RVA: 0x0076DED8 File Offset: 0x0076C0D8
	private void ApplySlamDownVelocity()
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component == null)
		{
			return;
		}
		this.SlamVelocity.DeepCopy(component.GravityUp);
		this.SlamVelocity.MultiplyEqual(-5000.0);
		component.SetForceSpeed(this.SlamVelocity);
	}

	// Token: 0x0400D477 RID: 54391
	private const int RISE_MONTAGE_INDEX = 0;

	// Token: 0x0400D478 RID: 54392
	private const int AIR_ATTACK_MONTAGE_INDEX = 1;

	// Token: 0x0400D479 RID: 54393
	private const int LAND_ATTACK_MONTAGE_INDEX = 2;

	// Token: 0x0400D47A RID: 54394
	private const float SLAM_DOWN_SPEED = -5000f;

	// Token: 0x0400D47B RID: 54395
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D47C RID: 54396
	private CodeSkill_Common_AirAttack.EAirAttackPhase Phase;

	// Token: 0x0400D47D RID: 54397
	private bool LandAttack;

	// Token: 0x0400D47E RID: 54398
	private float BlockTime;

	// Token: 0x0400D47F RID: 54399
	private bool LandCheckDone;

	// Token: 0x0400D480 RID: 54400
	private readonly Vector SlamVelocity = Vector.Create();

	// Token: 0x020096BC RID: 38588
	[NullableContext(0)]
	private enum EAirAttackPhase
	{
		// Token: 0x040304FE RID: 197886
		None,
		// Token: 0x040304FF RID: 197887
		Rise,
		// Token: 0x04030500 RID: 197888
		AirAttack,
		// Token: 0x04030501 RID: 197889
		LandAttack
	}
}
