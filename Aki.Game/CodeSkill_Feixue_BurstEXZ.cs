using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026EA RID: 9962
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_BurstEXZ : CodeSkillBase
{
	// Token: 0x06018EF6 RID: 102134 RVA: 0x00796311 File Offset: 0x00794511
	public CodeSkill_Feixue_BurstEXZ(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EF7 RID: 102135 RVA: 0x00796328 File Offset: 0x00794528
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

	// Token: 0x06018EF8 RID: 102136 RVA: 0x007963A0 File Offset: 0x007945A0
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

	// Token: 0x06018EF9 RID: 102137 RVA: 0x00796448 File Offset: 0x00794648
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

	// Token: 0x06018EFA RID: 102138 RVA: 0x007964A0 File Offset: 0x007946A0
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

	// Token: 0x06018EFB RID: 102139 RVA: 0x00796504 File Offset: 0x00794704
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

	// Token: 0x06018EFC RID: 102140 RVA: 0x00796568 File Offset: 0x00794768
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

	// Token: 0x06018EFD RID: 102141 RVA: 0x00796586 File Offset: 0x00794786
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

	// Token: 0x06018EFE RID: 102142 RVA: 0x007965A4 File Offset: 0x007947A4
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

	// Token: 0x06018EFF RID: 102143 RVA: 0x0079660F File Offset: 0x0079480F
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

	// Token: 0x06018F00 RID: 102144 RVA: 0x0079662B File Offset: 0x0079482B
	private void OnAirAttackMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (!this.LandAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x06018F01 RID: 102145 RVA: 0x0079663C File Offset: 0x0079483C
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

	// Token: 0x06018F02 RID: 102146 RVA: 0x007966A0 File Offset: 0x007948A0
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

	// Token: 0x06018F03 RID: 102147 RVA: 0x007966BF File Offset: 0x007948BF
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

	// Token: 0x06018F04 RID: 102148 RVA: 0x007966E0 File Offset: 0x007948E0
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

	// Token: 0x06018F05 RID: 102149 RVA: 0x00796750 File Offset: 0x00794950
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

	// Token: 0x0400D901 RID: 55553
	private const int GROUND_ATTACK_MONTAGE_INDEX = 0;

	// Token: 0x0400D902 RID: 55554
	private const int AIR_RISE_MONTAGE_INDEX = 1;

	// Token: 0x0400D903 RID: 55555
	private const int AIR_ATTACK_MONTAGE_INDEX = 2;

	// Token: 0x0400D904 RID: 55556
	private const int LAND_ATTACK_MONTAGE_INDEX = 3;

	// Token: 0x0400D905 RID: 55557
	private const int INTERRUPT_PRIORITY = 10;

	// Token: 0x0400D906 RID: 55558
	private const float SLAM_DOWN_SPEED = -5000f;

	// Token: 0x0400D907 RID: 55559
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D908 RID: 55560
	private CodeSkill_Feixue_BurstEXZ.EBurstExzPhase Phase;

	// Token: 0x0400D909 RID: 55561
	private bool LandAttack;

	// Token: 0x0400D90A RID: 55562
	private float BlockTime;

	// Token: 0x0400D90B RID: 55563
	private bool LandCheckDone;

	// Token: 0x0400D90C RID: 55564
	private readonly Vector SlamVelocity = Vector.Create();

	// Token: 0x020088ED RID: 35053
	[NullableContext(0)]
	private enum EBurstExzPhase
	{
		// Token: 0x0402BBB0 RID: 179120
		None,
		// Token: 0x0402BBB1 RID: 179121
		GroundAttack,
		// Token: 0x0402BBB2 RID: 179122
		AirRise,
		// Token: 0x0402BBB3 RID: 179123
		AirAttack,
		// Token: 0x0402BBB4 RID: 179124
		LandAttack,
		// Token: 0x0402BBB5 RID: 179125
		LandGroundAttack
	}
}
