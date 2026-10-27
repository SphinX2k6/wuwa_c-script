using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003184 RID: 12676
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_SkillBurst02 : CodeSkillBase
{
	// Token: 0x0601B443 RID: 111683 RVA: 0x007702FC File Offset: 0x0076E4FC
	public CodeSkill_Feixue_SkillBurst02(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B444 RID: 111684 RVA: 0x00770310 File Offset: 0x0076E510
	public override void OnBegin(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.None;
		this.LandAttack = false;
		this.BlockTime = 0f;
		this.LandCheckDone = false;
		this.Phase = CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.Start;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.OnStartMontageEnd(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnStartMontageBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B445 RID: 111685 RVA: 0x00770394 File Offset: 0x0076E594
	public override void OnTick(float delta, Skill skill)
	{
		if (this.Phase != CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.AirAttack)
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

	// Token: 0x0601B446 RID: 111686 RVA: 0x0077043C File Offset: 0x0076E63C
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

	// Token: 0x0601B447 RID: 111687 RVA: 0x00770491 File Offset: 0x0076E691
	private void OnStartMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.Start)
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

	// Token: 0x0601B448 RID: 111688 RVA: 0x007704AF File Offset: 0x0076E6AF
	private void OnStartMontageEnd(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.Start)
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

	// Token: 0x0601B449 RID: 111689 RVA: 0x007704D0 File Offset: 0x0076E6D0
	private void StartAirAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.AirAttack;
		if (!base.SkillComp.PlaySkillMontage(1, "", 0f, delegate(bool isInterrupted)
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

	// Token: 0x0601B44A RID: 111690 RVA: 0x0077053B File Offset: 0x0076E73B
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

	// Token: 0x0601B44B RID: 111691 RVA: 0x00770557 File Offset: 0x0076E757
	private void OnAirAttackMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (!this.LandAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B44C RID: 111692 RVA: 0x00770568 File Offset: 0x0076E768
	private void StartLandAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase.LandAttack;
		if (!base.SkillComp.PlaySkillMontage(2, "", 0f, delegate(bool isInterrupted)
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

	// Token: 0x0601B44D RID: 111693 RVA: 0x007705CC File Offset: 0x0076E7CC
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

	// Token: 0x0601B44E RID: 111694 RVA: 0x0077063C File Offset: 0x0076E83C
	private void ApplySlamDownVelocity()
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component == null)
		{
			return;
		}
		this.SlamVelocity.DeepCopy(component.GravityUp);
		this.SlamVelocity.MultiplyEqual(-3500.0);
		component.SetForceSpeed(this.SlamVelocity);
	}

	// Token: 0x0400D4D9 RID: 54489
	private const int START_MONTAGE_INDEX = 0;

	// Token: 0x0400D4DA RID: 54490
	private const int AIR_ATTACK_MONTAGE_INDEX = 1;

	// Token: 0x0400D4DB RID: 54491
	private const int LAND_ATTACK_MONTAGE_INDEX = 2;

	// Token: 0x0400D4DC RID: 54492
	private const float SLAM_DOWN_SPEED = -3500f;

	// Token: 0x0400D4DD RID: 54493
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D4DE RID: 54494
	private CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase Phase;

	// Token: 0x0400D4DF RID: 54495
	private bool LandAttack;

	// Token: 0x0400D4E0 RID: 54496
	private float BlockTime;

	// Token: 0x0400D4E1 RID: 54497
	private bool LandCheckDone;

	// Token: 0x0400D4E2 RID: 54498
	private readonly Vector SlamVelocity = Vector.Create();

	// Token: 0x020096D3 RID: 38611
	[NullableContext(0)]
	private enum ESkillBurst02Phase
	{
		// Token: 0x04030538 RID: 197944
		None,
		// Token: 0x04030539 RID: 197945
		Start,
		// Token: 0x0403053A RID: 197946
		AirAttack,
		// Token: 0x0403053B RID: 197947
		LandAttack
	}
}
