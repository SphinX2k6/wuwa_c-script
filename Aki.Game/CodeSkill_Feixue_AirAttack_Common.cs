using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200317A RID: 12666
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_AirAttack_Common : CodeSkillBase
{
	// Token: 0x0601B3D2 RID: 111570 RVA: 0x0076E059 File Offset: 0x0076C259
	public CodeSkill_Feixue_AirAttack_Common(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3D3 RID: 111571 RVA: 0x0076E064 File Offset: 0x0076C264
	public override void OnBegin(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.None;
		this.ReceivedNotify = false;
		this.LandAttack = false;
		this.BlockTime = 0f;
		this.LandCheckDone = false;
		this.ActiveSkill = skill;
		this.Phase = CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.Initial;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.OnInitialMontageEnd(skill);
		}, delegate(bool isInterrupted)
		{
			this.OnInitialMontageEnd(skill);
		}))
		{
			base.EndSelf(skill);
			return;
		}
		this.RegisterFallAttackEventListeners();
	}

	// Token: 0x0601B3D4 RID: 111572 RVA: 0x0076E104 File Offset: 0x0076C304
	public override void OnTick(float delta, Skill skill)
	{
		if (this.Phase != CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.SlopeAttack && this.Phase != CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.VerticalAttack)
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

	// Token: 0x0601B3D5 RID: 111573 RVA: 0x0076E1B3 File Offset: 0x0076C3B3
	public override void OnEnd(Skill skill)
	{
		this.RemoveFallAttackEventListeners();
		this.ActiveSkill = null;
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
		UCapsuleComponent capsuleComponent = actor.CapsuleComponent;
		if (capsuleComponent == null)
		{
			return;
		}
		capsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Block);
	}

	// Token: 0x0601B3D6 RID: 111574 RVA: 0x0076E1ED File Offset: 0x0076C3ED
	private void OnInitialMontageEnd(Skill skill)
	{
		if (this.ReceivedNotify)
		{
			return;
		}
		base.EndSelf(skill);
	}

	// Token: 0x0601B3D7 RID: 111575 RVA: 0x0076E200 File Offset: 0x0076C400
	private void RegisterFallAttackEventListeners()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.Common.下落攻击状态.斜向下落攻击"], new TGameplayEventCallback(this.OnSlopeAttackEvent));
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.Common.下落攻击状态.垂直下落攻击"], new TGameplayEventCallback(this.OnVerticalAttackEvent));
		this.ListenersActive = true;
	}

	// Token: 0x0601B3D8 RID: 111576 RVA: 0x0076E268 File Offset: 0x0076C468
	private void RemoveFallAttackEventListeners()
	{
		if (!this.ListenersActive)
		{
			return;
		}
		this.ListenersActive = false;
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component != null)
		{
			component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.Common.下落攻击状态.斜向下落攻击"], new TGameplayEventCallback(this.OnSlopeAttackEvent));
		}
		if (component == null)
		{
			return;
		}
		component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.Common.下落攻击状态.垂直下落攻击"], new TGameplayEventCallback(this.OnVerticalAttackEvent));
	}

	// Token: 0x0601B3D9 RID: 111577 RVA: 0x0076E2DC File Offset: 0x0076C4DC
	private void OnSlopeAttackEvent(int tagId, FGameplayEventData payload)
	{
		this.OnFallAttackEventReceived(CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.SlopeAttack, 1);
	}

	// Token: 0x0601B3DA RID: 111578 RVA: 0x0076E2E6 File Offset: 0x0076C4E6
	private void OnVerticalAttackEvent(int tagId, FGameplayEventData payload)
	{
		this.OnFallAttackEventReceived(CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.VerticalAttack, 2);
	}

	// Token: 0x0601B3DB RID: 111579 RVA: 0x0076E2F0 File Offset: 0x0076C4F0
	private void OnFallAttackEventReceived(CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase phase, int montageIndex)
	{
		Skill skill = this.ActiveSkill;
		if (skill == null)
		{
			return;
		}
		if (this.ReceivedNotify)
		{
			return;
		}
		this.ReceivedNotify = true;
		this.RemoveFallAttackEventListeners();
		this.Phase = phase;
		if (!base.SkillComp.PlaySkillMontage(montageIndex, "", 0f, delegate(bool isInterrupted)
		{
			this.OnFallMontageCompleted(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnFallMontageBlendOut(skill);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B3DC RID: 111580 RVA: 0x0076E378 File Offset: 0x0076C578
	private void OnFallMontageCompleted(Skill skill, bool isInterrupted)
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

	// Token: 0x0601B3DD RID: 111581 RVA: 0x0076E395 File Offset: 0x0076C595
	private void OnFallMontageBlendOut(Skill skill)
	{
		if (this.LandAttack)
		{
			return;
		}
		base.EndSelf(skill);
	}

	// Token: 0x0601B3DE RID: 111582 RVA: 0x0076E3A8 File Offset: 0x0076C5A8
	private void StartLandAttackMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.LandAttack;
		if (!base.SkillComp.PlaySkillMontage(3, "", 0f, delegate(bool isInterrupted)
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

	// Token: 0x0601B3DF RID: 111583 RVA: 0x0076E40C File Offset: 0x0076C60C
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

	// Token: 0x0400D483 RID: 54403
	private const int INITIAL_MONTAGE_INDEX = 0;

	// Token: 0x0400D484 RID: 54404
	private const int SLOPE_MONTAGE_INDEX = 1;

	// Token: 0x0400D485 RID: 54405
	private const int VERTICAL_MONTAGE_INDEX = 2;

	// Token: 0x0400D486 RID: 54406
	private const int LAND_ATTACK_MONTAGE_INDEX = 3;

	// Token: 0x0400D487 RID: 54407
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D488 RID: 54408
	private CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase Phase;

	// Token: 0x0400D489 RID: 54409
	private bool ReceivedNotify;

	// Token: 0x0400D48A RID: 54410
	private bool LandAttack;

	// Token: 0x0400D48B RID: 54411
	private float BlockTime;

	// Token: 0x0400D48C RID: 54412
	private bool LandCheckDone;

	// Token: 0x0400D48D RID: 54413
	private bool ListenersActive;

	// Token: 0x0400D48E RID: 54414
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x020096C1 RID: 38593
	[NullableContext(0)]
	private enum EAirAttackPhase
	{
		// Token: 0x0403050B RID: 197899
		None,
		// Token: 0x0403050C RID: 197900
		Initial,
		// Token: 0x0403050D RID: 197901
		SlopeAttack,
		// Token: 0x0403050E RID: 197902
		VerticalAttack,
		// Token: 0x0403050F RID: 197903
		LandAttack
	}
}
