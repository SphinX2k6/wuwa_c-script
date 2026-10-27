using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003253 RID: 12883
[NullableContext(2)]
[Nullable(0)]
public class RoleStrengthComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601BCAF RID: 113839 RVA: 0x007AC10B File Offset: 0x007AA30B
	static RoleStrengthComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleStrengthComponent.CreateStaticDefaultValue), new Action(RoleStrengthComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601BCB0 RID: 113840 RVA: 0x007AC12C File Offset: 0x007AA32C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.BuffComp = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.UnifiedStateComponent = base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>();
		this.CreatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.StrengthForbiddenGe = -1;
		this.InitStartingGameplayEffect();
		EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.MoveStateChangeHandler));
		EventSystem.Instance.AddWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.PositionStateChangeHandler));
		EventSystem.Instance.AddWithTarget<long>(base.Entity, EEventName.CharSwimStrengthChanged, new Action<long>(this.SwimStrengthChangeHandler));
		FormationAttributeController.Instance.AddThresholdListener(EFormationAttributeId.Strength, new TThresholdListener(this.StrengthEmptyCallback), 0f, 0f, "Strength.RoleStrengthComponent");
		FormationAttributeController.Instance.AddThresholdListener(EFormationAttributeId.SoarStrength, new TThresholdListener(this.SoarStrengthEmptyCallback), 0f, 0f, "Strength.RoleStrengthComponent");
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.钩锁"], new BaseTagComponent.TTagSwitchedCallback(this.CheckDrowning), null);
		}
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.StateInheritHandle));
		return true;
	}

	// Token: 0x0601BCB1 RID: 113841 RVA: 0x007AC2A0 File Offset: 0x007AA4A0
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.MoveStateChangeHandler));
		EventSystem.Instance.RemoveWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.PositionStateChangeHandler));
		FormationAttributeController.Instance.RemoveThresholdListener(EFormationAttributeId.Strength, new TThresholdListener(this.StrengthEmptyCallback));
		FormationAttributeController.Instance.RemoveThresholdListener(EFormationAttributeId.SoarStrength, new TThresholdListener(this.SoarStrengthEmptyCallback));
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.钩锁"], new BaseTagComponent.TTagSwitchedCallback(this.CheckDrowning));
		}
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.StateInheritHandle));
		EventSystem.Instance.RemoveWithTarget<long>(base.Entity, EEventName.CharSwimStrengthChanged, new Action<long>(this.SwimStrengthChangeHandler));
		return true;
	}

	// Token: 0x0601BCB2 RID: 113842 RVA: 0x007AC391 File Offset: 0x007AA591
	private void InitStartingGameplayEffect()
	{
	}

	// Token: 0x0601BCB3 RID: 113843 RVA: 0x007AC394 File Offset: 0x007AA594
	private void StrengthEmptyCallback(EFormationAttributeId attrId, bool inInterval, float currentRatio)
	{
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (!(num.GetValueOrDefault() == playerId & num != null))
		{
			return;
		}
		if (inInterval)
		{
			switch (this.UnifiedStateComponent.PositionState)
			{
			case ECharPositionState.Ground:
				if (this.UnifiedStateComponent.MoveState == ECharMoveState.Sprint)
				{
					this.UnifiedStateComponent.SetMoveState(ECharMoveState.Run);
				}
				this.EmptyStrengthPunish();
				return;
			case ECharPositionState.Climb:
			case ECharPositionState.Floating:
				this.EmptyStrengthPunish();
				return;
			case ECharPositionState.Air:
				if (this.UnifiedStateComponent.MoveState == ECharMoveState.Glide)
				{
					CharacterGlideComponent component = base.Entity.GetComponent<CharacterGlideComponent>();
					if (component.Valid)
					{
						component.ExitGlideState("Strength");
					}
				}
				this.EmptyStrengthPunish();
				return;
			case ECharPositionState.Water:
				this.CheckDrowning();
				break;
			case ECharPositionState.Ski:
			case ECharPositionState.Ride:
			case ECharPositionState.RailSlide:
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0601BCB4 RID: 113844 RVA: 0x007AC480 File Offset: 0x007AA680
	private void CheckDrowning()
	{
		if (this.UnifiedStateComponent.PositionState == ECharPositionState.Water)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.钩锁"]))
			{
				SceneTeamModel instance = SceneTeamModel.Instance;
				int? num;
				if (instance == null)
				{
					num = null;
				}
				else
				{
					EntityHandle getCurrentEntity = instance.GetCurrentEntity;
					num = ((getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null);
				}
				int? num2 = num;
				int id = base.Entity.Id;
				if (num2.GetValueOrDefault() == id & num2 != null)
				{
					if (FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) < 0.01f)
					{
						RoleDeathComponent roleDeathComponent = base.Entity.CheckGetComponent<RoleDeathComponent>();
						if (roleDeathComponent == null)
						{
							return;
						}
						roleDeathComponent.Drowning();
					}
					return;
				}
			}
		}
	}

	// Token: 0x0601BCB5 RID: 113845 RVA: 0x007AC539 File Offset: 0x007AA739
	private void CheckDrowning(int tagId, bool tagExist)
	{
		this.CheckDrowning();
	}

	// Token: 0x0601BCB6 RID: 113846 RVA: 0x007AC544 File Offset: 0x007AA744
	private void SoarStrengthEmptyCallback(EFormationAttributeId attrId, bool inInterval, float currentRatio)
	{
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (!(num.GetValueOrDefault() == playerId & num != null))
		{
			return;
		}
		if (inInterval)
		{
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.MoveState == ECharMoveState.Soar)
			{
				CharacterGlideComponent component = base.Entity.GetComponent<CharacterGlideComponent>();
				if (component == null)
				{
					return;
				}
				component.ExitSoarState(EMovementMode.MOVE_Falling, "Strength");
			}
		}
	}

	// Token: 0x0601BCB7 RID: 113847 RVA: 0x007AC5C7 File Offset: 0x007AA7C7
	private void MoveStateChangeHandler(ECharMoveState oldState, ECharMoveState newState)
	{
		if (this.UnifiedStateComponent.PositionState == ECharPositionState.Water || !this.ActorComp.IsMoveAutonomousProxy)
		{
			return;
		}
		this.NewMoveStateStrengthDecrease(newState);
	}

	// Token: 0x0601BCB8 RID: 113848 RVA: 0x007AC5EC File Offset: 0x007AA7EC
	private void SwimStrengthChangeHandler(long newBuff)
	{
		this.BuffComp.RemoveBuffByHandle(this.StrengthDecreaseGe, -1, null, null, null, null);
		if (newBuff != 0L)
		{
			this.UpdateStrengthDecrease(newBuff);
		}
	}

	// Token: 0x0601BCB9 RID: 113849 RVA: 0x007AC634 File Offset: 0x007AA834
	private void PositionStateChangeHandler(ECharPositionState oldState, ECharPositionState newState)
	{
		float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength);
		if (oldState == ECharPositionState.Water)
		{
			this.BuffComp.RemoveBuffByHandle(this.StrengthDecreaseGe, -1, null, null, null, null);
		}
		if (newState == ECharPositionState.Water && value < 0.01f)
		{
			this.CheckDrowning();
		}
		this.ClearStrengthForbiddenGe();
		switch (newState)
		{
		case ECharPositionState.Ground:
			this.ClearStrengthForbiddenGe();
			return;
		case ECharPositionState.Climb:
			this.AddStrengthForbiddenGe(3011L);
			return;
		case ECharPositionState.Air:
		{
			CharacterBuffComponent buffComp = this.BuffComp;
			if (buffComp != null && buffComp.HasBuffAuthority())
			{
				this.BuffComp.AddBuff(3009L, new AddBuffParam
				{
					InstigatorId = this.BuffComp.CreatureDataId,
					Reason = "进入空中状态"
				});
			}
			this.AddStrengthForbiddenGe(3010L);
			return;
		}
		case ECharPositionState.Water:
			this.AddStrengthForbiddenGe(3011L);
			return;
		default:
			return;
		}
	}

	// Token: 0x0601BCBA RID: 113850 RVA: 0x007AC722 File Offset: 0x007AA922
	[NullableContext(1)]
	private void StateInheritHandle(Entity oldEntity, bool notInheritMoveAndAnim)
	{
	}

	// Token: 0x0601BCBB RID: 113851 RVA: 0x007AC724 File Offset: 0x007AA924
	public void EmptyStrengthPunish()
	{
		if (this.BuffComp.HasBuffAuthority() && this.BuffComp.GetBuffTotalStackById(3023L, false) < 1)
		{
			this.BuffComp.AddBuff(3023L, new AddBuffParam
			{
				InstigatorId = this.BuffComp.CreatureDataId,
				Reason = "体力耗尽"
			});
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]));
	}

	// Token: 0x0601BCBC RID: 113852 RVA: 0x007AC7AA File Offset: 0x007AA9AA
	public void UpdateStrengthDecrease(long decreaseBuffId)
	{
		this.StrengthDecreaseGe = this.BuffComp.AddBuffLocal(decreaseBuffId, new AddBuffParam
		{
			InstigatorId = this.BuffComp.CreatureDataId,
			Reason = "RoleStrengthComponent.UpdateStrengthDecrease"
		});
	}

	// Token: 0x0601BCBD RID: 113853 RVA: 0x007AC7DF File Offset: 0x007AA9DF
	private void AddStrengthForbiddenGe(long buffId)
	{
		this.StrengthForbiddenGe = this.BuffComp.AddBuffLocal(buffId, new AddBuffParam
		{
			InstigatorId = this.BuffComp.CreatureDataId,
			Reason = "RoleStrengthComponent.ToggleStrengthForbiddenGe"
		});
	}

	// Token: 0x0601BCBE RID: 113854 RVA: 0x007AC814 File Offset: 0x007AAA14
	private void ClearStrengthForbiddenGe()
	{
		this.BuffComp.RemoveBuffByHandle(this.StrengthForbiddenGe, -1, null, null, null, null);
	}

	// Token: 0x0601BCBF RID: 113855 RVA: 0x007AC850 File Offset: 0x007AAA50
	public void NewMoveStateStrengthDecrease(ECharMoveState newState)
	{
		this.BuffComp.RemoveBuffByHandle(this.StrengthDecreaseGe, -1, null, null, null, null);
		if (newState == ECharMoveState.Sprint)
		{
			this.UpdateStrengthDecrease(1201L);
			return;
		}
		if (newState == ECharMoveState.FastClimb)
		{
			this.UpdateStrengthDecrease(1205L);
			return;
		}
		if (newState != ECharMoveState.Glide)
		{
			return;
		}
		this.BuffComp.AddBuff(1212L, new AddBuffParam
		{
			InstigatorId = this.BuffComp.CreatureDataId,
			Reason = "进入滑翔状态"
		});
		this.UpdateStrengthDecrease(1206L);
	}

	// Token: 0x0601BCC0 RID: 113856 RVA: 0x007AC8F3 File Offset: 0x007AAAF3
	public static void CreateStaticDefaultValue()
	{
		RoleStrengthComponent.ForbidStrengthRecoveryTimeExtra = 0.5f;
	}

	// Token: 0x0601BCC1 RID: 113857 RVA: 0x007AC8FF File Offset: 0x007AAAFF
	public static void ResetStaticDefaultValue()
	{
		RoleStrengthComponent.ForbidStrengthRecoveryTimeExtra = 0.5f;
	}

	// Token: 0x0601BCC2 RID: 113858 RVA: 0x007AC90C File Offset: 0x007AAB0C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleStrengthComponent roleStrengthComponent = (RoleStrengthComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (roleStrengthComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComp"))
		{
			if (roleStrengthComponent.BuffComp == null)
			{
				this.BuffComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComp), "BuffComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (roleStrengthComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComponent"))
		{
			if (roleStrengthComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CreatureDataComponent"))
		{
			if (roleStrengthComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StrengthDecreaseGe"))
		{
			this.StrengthDecreaseGe = roleStrengthComponent.StrengthDecreaseGe;
		}
		if (base.CanResetComponentProperty("StrengthForbiddenGe"))
		{
			this.StrengthForbiddenGe = roleStrengthComponent.StrengthForbiddenGe;
		}
		return true;
	}

	// Token: 0x0400DB27 RID: 56103
	public const float STRENGTH_TOLERANCE = 0.01f;

	// Token: 0x0400DB28 RID: 56104
	public static float ForbidStrengthRecoveryTimeExtra;

	// Token: 0x0400DB29 RID: 56105
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DB2A RID: 56106
	private CharacterBuffComponent BuffComp;

	// Token: 0x0400DB2B RID: 56107
	private BaseTagComponent TagComponent;

	// Token: 0x0400DB2C RID: 56108
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400DB2D RID: 56109
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400DB2E RID: 56110
	private int StrengthDecreaseGe;

	// Token: 0x0400DB2F RID: 56111
	private int StrengthForbiddenGe;
}
