using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026F1 RID: 9969
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_SkillBurst02 : CodeSkillBase
{
	// Token: 0x06018F48 RID: 102216 RVA: 0x00797C60 File Offset: 0x00795E60
	public CodeSkill_Feixue_SkillBurst02(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F49 RID: 102217 RVA: 0x00797C74 File Offset: 0x00795E74
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

	// Token: 0x06018F4A RID: 102218 RVA: 0x00797CF8 File Offset: 0x00795EF8
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

	// Token: 0x06018F4B RID: 102219 RVA: 0x00797DA0 File Offset: 0x00795FA0
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

	// Token: 0x06018F4C RID: 102220 RVA: 0x00797DF5 File Offset: 0x00795FF5
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

	// Token: 0x06018F4D RID: 102221 RVA: 0x00797E13 File Offset: 0x00796013
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

	// Token: 0x06018F4E RID: 102222 RVA: 0x00797E34 File Offset: 0x00796034
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

	// Token: 0x06018F4F RID: 102223 RVA: 0x00797E9F File Offset: 0x0079609F
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

	// Token: 0x06018F50 RID: 102224 RVA: 0x00797EBB File Offset: 0x007960BB
	private void OnAirAttackMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (!this.LandAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x06018F51 RID: 102225 RVA: 0x00797ECC File Offset: 0x007960CC
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

	// Token: 0x06018F52 RID: 102226 RVA: 0x00797F30 File Offset: 0x00796130
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

	// Token: 0x06018F53 RID: 102227 RVA: 0x00797FA0 File Offset: 0x007961A0
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

	// Token: 0x0400D93C RID: 55612
	private const int START_MONTAGE_INDEX = 0;

	// Token: 0x0400D93D RID: 55613
	private const int AIR_ATTACK_MONTAGE_INDEX = 1;

	// Token: 0x0400D93E RID: 55614
	private const int LAND_ATTACK_MONTAGE_INDEX = 2;

	// Token: 0x0400D93F RID: 55615
	private const float SLAM_DOWN_SPEED = -3500f;

	// Token: 0x0400D940 RID: 55616
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D941 RID: 55617
	private CodeSkill_Feixue_SkillBurst02.ESkillBurst02Phase Phase;

	// Token: 0x0400D942 RID: 55618
	private bool LandAttack;

	// Token: 0x0400D943 RID: 55619
	private float BlockTime;

	// Token: 0x0400D944 RID: 55620
	private bool LandCheckDone;

	// Token: 0x0400D945 RID: 55621
	private readonly Vector SlamVelocity = Vector.Create();

	// Token: 0x020088F9 RID: 35065
	[NullableContext(0)]
	private enum ESkillBurst02Phase
	{
		// Token: 0x0402BBCD RID: 179149
		None,
		// Token: 0x0402BBCE RID: 179150
		Start,
		// Token: 0x0402BBCF RID: 179151
		AirAttack,
		// Token: 0x0402BBD0 RID: 179152
		LandAttack
	}
}
