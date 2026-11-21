using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E7 RID: 9959
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_AirAttack_Common : CodeSkillBase
{
	// Token: 0x06018ED7 RID: 102103 RVA: 0x007959BD File Offset: 0x00793BBD
	public CodeSkill_Feixue_AirAttack_Common(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018ED8 RID: 102104 RVA: 0x007959C8 File Offset: 0x00793BC8
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

	// Token: 0x06018ED9 RID: 102105 RVA: 0x00795A68 File Offset: 0x00793C68
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

	// Token: 0x06018EDA RID: 102106 RVA: 0x00795B17 File Offset: 0x00793D17
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

	// Token: 0x06018EDB RID: 102107 RVA: 0x00795B51 File Offset: 0x00793D51
	private void OnInitialMontageEnd(Skill skill)
	{
		if (this.ReceivedNotify)
		{
			return;
		}
		base.EndSelf(skill);
	}

	// Token: 0x06018EDC RID: 102108 RVA: 0x00795B64 File Offset: 0x00793D64
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

	// Token: 0x06018EDD RID: 102109 RVA: 0x00795BCC File Offset: 0x00793DCC
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

	// Token: 0x06018EDE RID: 102110 RVA: 0x00795C40 File Offset: 0x00793E40
	private void OnSlopeAttackEvent(int tagId, FGameplayEventData payload)
	{
		this.OnFallAttackEventReceived(CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.SlopeAttack, 1);
	}

	// Token: 0x06018EDF RID: 102111 RVA: 0x00795C4A File Offset: 0x00793E4A
	private void OnVerticalAttackEvent(int tagId, FGameplayEventData payload)
	{
		this.OnFallAttackEventReceived(CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase.VerticalAttack, 2);
	}

	// Token: 0x06018EE0 RID: 102112 RVA: 0x00795C54 File Offset: 0x00793E54
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

	// Token: 0x06018EE1 RID: 102113 RVA: 0x00795CDC File Offset: 0x00793EDC
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

	// Token: 0x06018EE2 RID: 102114 RVA: 0x00795CF9 File Offset: 0x00793EF9
	private void OnFallMontageBlendOut(Skill skill)
	{
		if (this.LandAttack)
		{
			return;
		}
		base.EndSelf(skill);
	}

	// Token: 0x06018EE3 RID: 102115 RVA: 0x00795D0C File Offset: 0x00793F0C
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

	// Token: 0x06018EE4 RID: 102116 RVA: 0x00795D70 File Offset: 0x00793F70
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

	// Token: 0x0400D8E6 RID: 55526
	private const int INITIAL_MONTAGE_INDEX = 0;

	// Token: 0x0400D8E7 RID: 55527
	private const int SLOPE_MONTAGE_INDEX = 1;

	// Token: 0x0400D8E8 RID: 55528
	private const int VERTICAL_MONTAGE_INDEX = 2;

	// Token: 0x0400D8E9 RID: 55529
	private const int LAND_ATTACK_MONTAGE_INDEX = 3;

	// Token: 0x0400D8EA RID: 55530
	private const float MAX_BLOCK_TIME = 1f;

	// Token: 0x0400D8EB RID: 55531
	private CodeSkill_Feixue_AirAttack_Common.EAirAttackPhase Phase;

	// Token: 0x0400D8EC RID: 55532
	private bool ReceivedNotify;

	// Token: 0x0400D8ED RID: 55533
	private bool LandAttack;

	// Token: 0x0400D8EE RID: 55534
	private float BlockTime;

	// Token: 0x0400D8EF RID: 55535
	private bool LandCheckDone;

	// Token: 0x0400D8F0 RID: 55536
	private bool ListenersActive;

	// Token: 0x0400D8F1 RID: 55537
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x020088E7 RID: 35047
	[NullableContext(0)]
	private enum EAirAttackPhase
	{
		// Token: 0x0402BBA0 RID: 179104
		None,
		// Token: 0x0402BBA1 RID: 179105
		Initial,
		// Token: 0x0402BBA2 RID: 179106
		SlopeAttack,
		// Token: 0x0402BBA3 RID: 179107
		VerticalAttack,
		// Token: 0x0402BBA4 RID: 179108
		LandAttack
	}
}
