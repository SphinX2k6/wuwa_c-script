using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common;
using UnrealEngine;

// Token: 0x020027B0 RID: 10160
[NullableContext(1)]
[Nullable(0)]
public class RoleFrozenComponent : BaseFrozenComponent
{
	// Token: 0x060197E5 RID: 104421 RVA: 0x007CF54B File Offset: 0x007CD74B
	public override bool IsFrozen()
	{
		return this.IsFrozenInternal;
	}

	// Token: 0x060197E6 RID: 104422 RVA: 0x007CF554 File Offset: 0x007CD754
	protected override void SetFrozen(bool bFrozen)
	{
		if (this.IsFrozenInternal == bFrozen)
		{
			return;
		}
		this.IsFrozenInternal = bFrozen;
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		UeSkeletalTickManageComponent component2 = base.Entity.GetComponent<UeSkeletalTickManageComponent>();
		CharacterAbilityComponent component3 = base.Entity.GetComponent<CharacterAbilityComponent>();
		CharacterSkillComponent component4 = base.Entity.GetComponent<CharacterSkillComponent>();
		CharacterGameplayCueComponent cueComponent = base.Entity.GetComponent<CharacterGameplayCueComponent>();
		BaseTagComponent component5 = base.Entity.GetComponent<BaseTagComponent>();
		TagContainer tagContainer = (component5 != null) ? component5.TagContainer : null;
		UeMovementTickManageComponent component6 = base.Entity.GetComponent<UeMovementTickManageComponent>();
		if (component6 != null)
		{
			component6.Frozen = bFrozen;
		}
		if (bFrozen)
		{
			int? num = this.MoveForbidHandle;
			if (num == null)
			{
				this.MoveForbidHandle = ((component != null) ? new int?(component.Disable("RoleFrozen")) : null);
			}
			num = this.AnimForbidHandle;
			if (num == null)
			{
				this.AnimForbidHandle = ((component2 != null) ? new int?(component2.Disable("RoleFrozen")) : null);
			}
			num = this.AbilityForbidHandle;
			if (num == null)
			{
				this.AbilityForbidHandle = ((component3 != null) ? new int?(component3.Disable("RoleFrozen")) : null);
			}
			num = this.SkillForbidHandle;
			if (num == null)
			{
				this.SkillForbidHandle = ((component4 != null) ? new int?(component4.Disable("RoleFrozen")) : null);
			}
			if (this.FrozenCueHandle == 0)
			{
				CharacterGameplayCueComponent cueComponent5 = cueComponent;
				this.FrozenCueHandle = ((cueComponent5 != null) ? cueComponent5.AddCue(1003L, null) : 0);
			}
			if (tagContainer != null)
			{
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["Damage.Frozen"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止交互.冰冻"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止攀爬"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止行走"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止跳跃"]);
			}
			this.ChangeMovementModeInFrozen(component);
			if (this.ActorComponent != null)
			{
				RoleFrozenComponent.TmpVector.DeepCopy(this.ActorComponent.ActorVelocityProxy);
				if (RoleFrozenComponent.TmpVector.Z > 0.0)
				{
					RoleFrozenComponent.TmpVector.Z = 0.0;
					if (component != null)
					{
						component.SetForceSpeed(RoleFrozenComponent.TmpVector);
						return;
					}
				}
			}
		}
		else
		{
			if (this.MoveForbidHandle != null)
			{
				if (component != null)
				{
					component.Enable(new int?(this.MoveForbidHandle.Value), "[RoleFrozenComponent.SetFrozen] this.MoveForbidHandle !== undefined");
				}
				this.MoveForbidHandle = null;
			}
			if (this.AnimForbidHandle != null)
			{
				if (component2 != null)
				{
					component2.Enable(new int?(this.AnimForbidHandle.Value), "[RoleFrozenComponent.SetFrozen] this.AnimForbidHandle !== undefined");
				}
				this.AnimForbidHandle = null;
			}
			if (this.AbilityForbidHandle != null)
			{
				if (component3 != null)
				{
					component3.Enable(new int?(this.AbilityForbidHandle.Value), "[RoleFrozenComponent.SetFrozen] this.AbilityForbidHandle !== undefined");
				}
				this.AbilityForbidHandle = null;
			}
			if (this.SkillForbidHandle != null)
			{
				if (component4 != null)
				{
					component4.Enable(new int?(this.SkillForbidHandle.Value), "[RoleFrozenComponent.SetFrozen] this.SkillForbidHandle !== undefined");
				}
				this.SkillForbidHandle = null;
			}
			CharacterGameplayCueComponent cueComponent2 = cueComponent;
			if (cueComponent2 != null)
			{
				cueComponent2.RemoveCueByHandle((long)this.FrozenCueHandle);
			}
			CharacterGameplayCueComponent cueComponent3 = cueComponent;
			this.FrozenCueHandle = ((cueComponent3 != null) ? cueComponent3.AddCue(100302L, new GameplayCueParam?(new GameplayCueParam
			{
				EndCallback = delegate()
				{
					CharacterGameplayCueComponent cueComponent4 = cueComponent;
					if (cueComponent4 != null)
					{
						cueComponent4.RemoveCueByHandle((long)this.FrozenCueHandle);
					}
					this.FrozenCueHandle = 0;
				}
			})) : 0);
			if (tagContainer != null)
			{
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["Damage.Frozen"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止交互.冰冻"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止攀爬"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止行走"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止跳跃"]);
			}
			CharacterAnimationComponent component7 = base.Entity.GetComponent<CharacterAnimationComponent>();
			if (component7 != null)
			{
				UAnimInstance mainAnimInstance = component7.MainAnimInstance;
				if (UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance, CharacterNameDefines.Instance.ABP_BASEROLE))
				{
					ABP_BaseRole_C abp_BaseRole_C = mainAnimInstance as ABP_BaseRole_C;
					if (abp_BaseRole_C == null)
					{
						return;
					}
					abp_BaseRole_C.冰冻结束事件();
				}
			}
		}
	}

	// Token: 0x060197E7 RID: 104423 RVA: 0x007CFA60 File Offset: 0x007CDC60
	[NullableContext(2)]
	protected void ChangeMovementModeInFrozen(CharacterMoveComponent moveComp)
	{
		if (((moveComp != null) ? moveComp.CharacterMovement : null) == null)
		{
			return;
		}
		TEnumAsByte<EMovementMode> movementMode = moveComp.CharacterMovement.MovementMode;
		byte customMovementMode = moveComp.CharacterMovement.CustomMovementMode;
		if (movementMode != EMovementMode.MOVE_Walking && movementMode != EMovementMode.MOVE_Falling && (!(movementMode == EMovementMode.MOVE_Custom) || customMovementMode != 1) && (!(movementMode == EMovementMode.MOVE_Custom) || customMovementMode != 11))
		{
			CharacterActorComponent actorComp = moveComp.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[RoleFrozenComponent.ChangeMovementModeInFrozen]"
			});
		}
	}

	// Token: 0x060197E8 RID: 104424 RVA: 0x007CFB04 File Offset: 0x007CDD04
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleFrozenComponent roleFrozenComponent = (RoleFrozenComponent)componentTemplate;
		this.MoveForbidHandle = roleFrozenComponent.MoveForbidHandle;
		this.AnimForbidHandle = roleFrozenComponent.AnimForbidHandle;
		this.AbilityForbidHandle = roleFrozenComponent.AbilityForbidHandle;
		this.SkillForbidHandle = roleFrozenComponent.SkillForbidHandle;
		this.FrozenCueHandle = roleFrozenComponent.FrozenCueHandle;
		this.IsFrozenInternal = roleFrozenComponent.IsFrozenInternal;
		return true;
	}

	// Token: 0x170028A8 RID: 10408
	// (get) Token: 0x060197E9 RID: 104425 RVA: 0x007CFB6C File Offset: 0x007CDD6C
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028A9 RID: 10409
	// (get) Token: 0x060197EA RID: 104426 RVA: 0x007CFB6F File Offset: 0x007CDD6F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028AA RID: 10410
	// (get) Token: 0x060197EB RID: 104427 RVA: 0x007CFB72 File Offset: 0x007CDD72
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF50 RID: 57168
	[StaticVariableRuleIgnore]
	protected static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400DF51 RID: 57169
	protected int? MoveForbidHandle;

	// Token: 0x0400DF52 RID: 57170
	protected int? AnimForbidHandle;

	// Token: 0x0400DF53 RID: 57171
	protected int? AbilityForbidHandle;

	// Token: 0x0400DF54 RID: 57172
	protected int? SkillForbidHandle;

	// Token: 0x0400DF55 RID: 57173
	protected int FrozenCueHandle;

	// Token: 0x0400DF56 RID: 57174
	protected bool IsFrozenInternal;
}
