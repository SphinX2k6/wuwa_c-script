using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E5 RID: 9957
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Common_AirAttack : CodeSkillBase
{
	// Token: 0x06018EC7 RID: 102087 RVA: 0x0079551C File Offset: 0x0079371C
	public CodeSkill_Common_AirAttack(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EC8 RID: 102088 RVA: 0x00795530 File Offset: 0x00793730
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

	// Token: 0x06018EC9 RID: 102089 RVA: 0x007955B4 File Offset: 0x007937B4
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

	// Token: 0x06018ECA RID: 102090 RVA: 0x0079565C File Offset: 0x0079385C
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

	// Token: 0x06018ECB RID: 102091 RVA: 0x007956B1 File Offset: 0x007938B1
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

	// Token: 0x06018ECC RID: 102092 RVA: 0x007956CF File Offset: 0x007938CF
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

	// Token: 0x06018ECD RID: 102093 RVA: 0x007956F0 File Offset: 0x007938F0
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

	// Token: 0x06018ECE RID: 102094 RVA: 0x00795750 File Offset: 0x00793950
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

	// Token: 0x06018ECF RID: 102095 RVA: 0x00795770 File Offset: 0x00793970
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

	// Token: 0x06018ED0 RID: 102096 RVA: 0x007957CC File Offset: 0x007939CC
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

	// Token: 0x06018ED1 RID: 102097 RVA: 0x0079583C File Offset: 0x00793A3C
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

	// Token: 0x0400D8DA RID: 55514
	private const int RISE_MONTAGE_INDEX = 0;

	// Token: 0x0400D8DB RID: 55515
	private const int AIR_ATTACK_MONTAGE_INDEX = 1;

	// Token: 0x0400D8DC RID: 55516
	private const int LAND_ATTACK_MONTAGE_INDEX = 2;

	// Token: 0x0400D8DD RID: 55517
	private const float SLAM_DOWN_SPEED = -5000f;

	// Token: 0x0400D8DE RID: 55518
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D8DF RID: 55519
	private CodeSkill_Common_AirAttack.EAirAttackPhase Phase;

	// Token: 0x0400D8E0 RID: 55520
	private bool LandAttack;

	// Token: 0x0400D8E1 RID: 55521
	private float BlockTime;

	// Token: 0x0400D8E2 RID: 55522
	private bool LandCheckDone;

	// Token: 0x0400D8E3 RID: 55523
	private readonly Vector SlamVelocity = Vector.Create();

	// Token: 0x020088E2 RID: 35042
	[NullableContext(0)]
	private enum EAirAttackPhase
	{
		// Token: 0x0402BB93 RID: 179091
		None,
		// Token: 0x0402BB94 RID: 179092
		Rise,
		// Token: 0x0402BB95 RID: 179093
		AirAttack,
		// Token: 0x0402BB96 RID: 179094
		LandAttack
	}
}
