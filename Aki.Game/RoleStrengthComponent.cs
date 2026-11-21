using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020027C2 RID: 10178
[NullableContext(2)]
[Nullable(0)]
public class RoleStrengthComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601986C RID: 104556 RVA: 0x007D461B File Offset: 0x007D281B
	static RoleStrengthComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleStrengthComponent.CreateStaticDefaultValue), new Action(RoleStrengthComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601986D RID: 104557 RVA: 0x007D463C File Offset: 0x007D283C
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

	// Token: 0x0601986E RID: 104558 RVA: 0x007D47B0 File Offset: 0x007D29B0
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

	// Token: 0x0601986F RID: 104559 RVA: 0x007D48A1 File Offset: 0x007D2AA1
	private void InitStartingGameplayEffect()
	{
	}

	// Token: 0x06019870 RID: 104560 RVA: 0x007D48A4 File Offset: 0x007D2AA4
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

	// Token: 0x06019871 RID: 104561 RVA: 0x007D4990 File Offset: 0x007D2B90
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

	// Token: 0x06019872 RID: 104562 RVA: 0x007D4A49 File Offset: 0x007D2C49
	private void CheckDrowning(int tagId, bool tagExist)
	{
		this.CheckDrowning();
	}

	// Token: 0x06019873 RID: 104563 RVA: 0x007D4A54 File Offset: 0x007D2C54
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

	// Token: 0x06019874 RID: 104564 RVA: 0x007D4AD7 File Offset: 0x007D2CD7
	private void MoveStateChangeHandler(ECharMoveState oldState, ECharMoveState newState)
	{
		if (this.UnifiedStateComponent.PositionState == ECharPositionState.Water || !this.ActorComp.IsMoveAutonomousProxy)
		{
			return;
		}
		this.NewMoveStateStrengthDecrease(newState);
	}

	// Token: 0x06019875 RID: 104565 RVA: 0x007D4AFC File Offset: 0x007D2CFC
	private void SwimStrengthChangeHandler(long newBuff)
	{
		this.BuffComp.RemoveBuffByHandle(this.StrengthDecreaseGe, -1, null, null, null, null);
		if (newBuff != 0L)
		{
			this.UpdateStrengthDecrease(newBuff);
		}
	}

	// Token: 0x06019876 RID: 104566 RVA: 0x007D4B44 File Offset: 0x007D2D44
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

	// Token: 0x06019877 RID: 104567 RVA: 0x007D4C32 File Offset: 0x007D2E32
	[NullableContext(1)]
	private void StateInheritHandle(Entity oldEntity, bool notInheritMoveAndAnim)
	{
	}

	// Token: 0x06019878 RID: 104568 RVA: 0x007D4C34 File Offset: 0x007D2E34
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

	// Token: 0x06019879 RID: 104569 RVA: 0x007D4CBA File Offset: 0x007D2EBA
	public void UpdateStrengthDecrease(long decreaseBuffId)
	{
		this.StrengthDecreaseGe = this.BuffComp.AddBuffLocal(decreaseBuffId, new AddBuffParam
		{
			InstigatorId = this.BuffComp.CreatureDataId,
			Reason = "RoleStrengthComponent.UpdateStrengthDecrease"
		});
	}

	// Token: 0x0601987A RID: 104570 RVA: 0x007D4CEF File Offset: 0x007D2EEF
	private void AddStrengthForbiddenGe(long buffId)
	{
		this.StrengthForbiddenGe = this.BuffComp.AddBuffLocal(buffId, new AddBuffParam
		{
			InstigatorId = this.BuffComp.CreatureDataId,
			Reason = "RoleStrengthComponent.ToggleStrengthForbiddenGe"
		});
	}

	// Token: 0x0601987B RID: 104571 RVA: 0x007D4D24 File Offset: 0x007D2F24
	private void ClearStrengthForbiddenGe()
	{
		this.BuffComp.RemoveBuffByHandle(this.StrengthForbiddenGe, -1, null, null, null, null);
	}

	// Token: 0x0601987C RID: 104572 RVA: 0x007D4D60 File Offset: 0x007D2F60
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

	// Token: 0x0601987D RID: 104573 RVA: 0x007D4E03 File Offset: 0x007D3003
	public static void CreateStaticDefaultValue()
	{
		RoleStrengthComponent.ForbidStrengthRecoveryTimeExtra = 0.5f;
	}

	// Token: 0x0601987E RID: 104574 RVA: 0x007D4E0F File Offset: 0x007D300F
	public static void ResetStaticDefaultValue()
	{
		RoleStrengthComponent.ForbidStrengthRecoveryTimeExtra = 0.5f;
	}

	// Token: 0x0601987F RID: 104575 RVA: 0x007D4E1C File Offset: 0x007D301C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleStrengthComponent roleStrengthComponent = (RoleStrengthComponent)componentTemplate;
		if (roleStrengthComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (roleStrengthComponent.BuffComp == null)
		{
			this.BuffComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComp), "BuffComp"))
		{
			return false;
		}
		if (roleStrengthComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (roleStrengthComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		if (roleStrengthComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		this.StrengthDecreaseGe = roleStrengthComponent.StrengthDecreaseGe;
		this.StrengthForbiddenGe = roleStrengthComponent.StrengthForbiddenGe;
		return true;
	}

	// Token: 0x170028BE RID: 10430
	// (get) Token: 0x06019880 RID: 104576 RVA: 0x007D4F2B File Offset: 0x007D312B
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028BF RID: 10431
	// (get) Token: 0x06019881 RID: 104577 RVA: 0x007D4F2E File Offset: 0x007D312E
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DFC6 RID: 57286
	public const float STRENGTH_TOLERANCE = 0.01f;

	// Token: 0x0400DFC7 RID: 57287
	public static float ForbidStrengthRecoveryTimeExtra;

	// Token: 0x0400DFC8 RID: 57288
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DFC9 RID: 57289
	private CharacterBuffComponent BuffComp;

	// Token: 0x0400DFCA RID: 57290
	private BaseTagComponent TagComponent;

	// Token: 0x0400DFCB RID: 57291
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400DFCC RID: 57292
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400DFCD RID: 57293
	private int StrengthDecreaseGe;

	// Token: 0x0400DFCE RID: 57294
	private int StrengthForbiddenGe;
}
