using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200317D RID: 12669
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_BurstEXZ : CodeSkillBase
{
	// Token: 0x0601B3F1 RID: 111601 RVA: 0x0076E9AD File Offset: 0x0076CBAD
	public CodeSkill_Feixue_BurstEXZ(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3F2 RID: 111602 RVA: 0x0076E9C4 File Offset: 0x0076CBC4
	public override void OnBegin(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.None;
		this.LandAttack = false;
		this.BlockTime = 0f;
		this.LandCheckDone = false;
		base.SkillComp.SetSkillPriority(skill.SkillId, 10);
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]))
		{
			this.StartGroundAttackMontage(skill, CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.GroundAttack);
			return;
		}
		this.StartAirRiseMontage(skill);
	}

	// Token: 0x0601B3F3 RID: 111603 RVA: 0x0076EA3C File Offset: 0x0076CC3C
	public override void OnTick(float delta, Skill skill)
	{
		if (this.Phase != CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.AirAttack)
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
		if (this.LandCheckDone)
		{
			return;
		}
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

	// Token: 0x0601B3F4 RID: 111604 RVA: 0x0076EAE4 File Offset: 0x0076CCE4
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

	// Token: 0x0601B3F5 RID: 111605 RVA: 0x0076EB3C File Offset: 0x0076CD3C
	private void StartGroundAttackMontage(Skill skill, CodeSkill_Feixue_BurstEXZ.EBurstExzPhase phase)
	{
		this.Phase = phase;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3F6 RID: 111606 RVA: 0x0076EBA0 File Offset: 0x0076CDA0
	private void StartAirRiseMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.AirRise;
		if (!base.SkillComp.PlaySkillMontage(1, "", 0f, delegate(bool isInterrupted)
		{
			this.OnAirRiseMontageEnd(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnAirRiseMontageBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3F7 RID: 111607 RVA: 0x0076EC04 File Offset: 0x0076CE04
	private void OnAirRiseMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.AirRise)
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

	// Token: 0x0601B3F8 RID: 111608 RVA: 0x0076EC22 File Offset: 0x0076CE22
	private void OnAirRiseMontageEnd(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.AirRise)
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

	// Token: 0x0601B3F9 RID: 111609 RVA: 0x0076EC40 File Offset: 0x0076CE40
	private void StartAirAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.AirAttack;
		if (!base.SkillComp.PlaySkillMontage(2, "", 0f, delegate(bool isInterrupted)
		{
			this.OnAirAttackMontageEnd(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnAirAttackMontageBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
			return;
		}
		this.ApplySlamDownVelocity();
	}

	// Token: 0x0601B3FA RID: 111610 RVA: 0x0076ECAB File Offset: 0x0076CEAB
	private void OnAirAttackMontageEnd(Skill skill, bool isInterrupted)
	{
		if (!isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		if (!this.LandAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3FB RID: 111611 RVA: 0x0076ECC7 File Offset: 0x0076CEC7
	private void OnAirAttackMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (!this.LandAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3FC RID: 111612 RVA: 0x0076ECD8 File Offset: 0x0076CED8
	private void StartLandAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.LandAttack;
		if (!base.SkillComp.PlaySkillMontage(3, "", 0f, delegate(bool isInterrupted)
		{
			this.OnLandAttackMontageEnd(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnLandAttackMontageBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3FD RID: 111613 RVA: 0x0076ED3C File Offset: 0x0076CF3C
	private void OnLandAttackMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.LandAttack)
		{
			return;
		}
		if (isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		this.StartGroundAttackMontage(skill, CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.LandGroundAttack);
	}

	// Token: 0x0601B3FE RID: 111614 RVA: 0x0076ED5B File Offset: 0x0076CF5B
	private void OnLandAttackMontageEnd(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.LandAttack)
		{
			return;
		}
		if (isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		this.StartGroundAttackMontage(skill, CodeSkill_Feixue_BurstEXZ.EBurstExzPhase.LandGroundAttack);
	}

	// Token: 0x0601B3FF RID: 111615 RVA: 0x0076ED7C File Offset: 0x0076CF7C
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

	// Token: 0x0601B400 RID: 111616 RVA: 0x0076EDEC File Offset: 0x0076CFEC
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

	// Token: 0x0400D49E RID: 54430
	private const int GROUND_ATTACK_MONTAGE_INDEX = 0;

	// Token: 0x0400D49F RID: 54431
	private const int AIR_RISE_MONTAGE_INDEX = 1;

	// Token: 0x0400D4A0 RID: 54432
	private const int AIR_ATTACK_MONTAGE_INDEX = 2;

	// Token: 0x0400D4A1 RID: 54433
	private const int LAND_ATTACK_MONTAGE_INDEX = 3;

	// Token: 0x0400D4A2 RID: 54434
	private const int INTERRUPT_PRIORITY = 10;

	// Token: 0x0400D4A3 RID: 54435
	private const float SLAM_DOWN_SPEED = -5000f;

	// Token: 0x0400D4A4 RID: 54436
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D4A5 RID: 54437
	private CodeSkill_Feixue_BurstEXZ.EBurstExzPhase Phase;

	// Token: 0x0400D4A6 RID: 54438
	private bool LandAttack;

	// Token: 0x0400D4A7 RID: 54439
	private float BlockTime;

	// Token: 0x0400D4A8 RID: 54440
	private bool LandCheckDone;

	// Token: 0x0400D4A9 RID: 54441
	private readonly Vector SlamVelocity = Vector.Create();

	// Token: 0x020096C7 RID: 38599
	[NullableContext(0)]
	private enum EBurstExzPhase
	{
		// Token: 0x0403051B RID: 197915
		None,
		// Token: 0x0403051C RID: 197916
		GroundAttack,
		// Token: 0x0403051D RID: 197917
		AirRise,
		// Token: 0x0403051E RID: 197918
		AirAttack,
		// Token: 0x0403051F RID: 197919
		LandAttack,
		// Token: 0x04030520 RID: 197920
		LandGroundAttack
	}
}
