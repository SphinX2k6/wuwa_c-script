using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x0200243D RID: 9277
[NullableContext(1)]
[Nullable(0)]
public class CharacterUnifiedStateComponent : BaseUnifiedStateComponent
{
	// Token: 0x0601738C RID: 95116 RVA: 0x006D1F0C File Offset: 0x006D010C
	static CharacterUnifiedStateComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterUnifiedStateComponent.CreateStaticDefaultValue), new Action(CharacterUnifiedStateComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700243B RID: 9275
	// (get) Token: 0x0601738D RID: 95117 RVA: 0x006D1FCB File Offset: 0x006D01CB
	[Nullable(2)]
	protected new CharacterActorComponent ActorComponent
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComponent as CharacterActorComponent;
		}
	}

	// Token: 0x1700243C RID: 9276
	// (get) Token: 0x0601738E RID: 95118 RVA: 0x006D1FD8 File Offset: 0x006D01D8
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterAbilityComponent)
			};
		}
	}

	// Token: 0x0601738F RID: 95119 RVA: 0x006D1FFA File Offset: 0x006D01FA
	protected override bool OnInit()
	{
		CharacterUnifiedStateComponent.Load();
		return true;
	}

	// Token: 0x06017390 RID: 95120 RVA: 0x006D2004 File Offset: 0x006D0204
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.CueComponent = base.Entity.GetComponent<CharacterGameplayCueComponent>();
		this.AbilityComponent = base.Entity.CheckGetComponent<CharacterAbilityComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.MoveComponent = base.Entity.CheckGetComponent<CharacterMoveComponent>();
		this.RoleGaitComponent = base.Entity.GetComponent<RoleGaitComponent>();
		this.FloatingComponent = base.Entity.GetComponent<CharacterFloatingComponent>();
		this.IsInGameInternal = new bool?(false);
		this.InitCharState();
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.StateInheritHandle));
		EventSystem.Instance.AddWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		EventSystem.Instance.AddWithTarget<ECharDirectionState, ECharDirectionState>(base.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.OnDirectionStateChange));
		EventSystem.Instance.AddWithTarget<bool, AiController>(base.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAggroChanged));
		EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.AiInFight, new Action<bool>(this.OnInFight));
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		return true;
	}

	// Token: 0x06017391 RID: 95121 RVA: 0x006D2164 File Offset: 0x006D0364
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.StateInheritHandle));
		EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		EventSystem.Instance.RemoveWithTarget<ECharDirectionState, ECharDirectionState>(base.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.OnDirectionStateChange));
		EventSystem.Instance.RemoveWithTarget<bool, AiController>(base.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.OnAggroChanged));
		EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.AiInFight, new Action<bool>(this.OnInFight));
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component != null && component.GetEntityType() == EEntityType.Player)
		{
			FormationDataController.Instance.MarkAggroDirty();
		}
		return true;
	}

	// Token: 0x06017392 RID: 95122 RVA: 0x006D225E File Offset: 0x006D045E
	protected override void OnEnable()
	{
		base.OnEnable();
		this.PreprocessChangeRole(true);
	}

	// Token: 0x06017393 RID: 95123 RVA: 0x006D226D File Offset: 0x006D046D
	protected override void OnDisable(string reason)
	{
		base.OnDisable(reason);
		this.PreprocessChangeRole(false);
	}

	// Token: 0x06017394 RID: 95124 RVA: 0x006D2280 File Offset: 0x006D0480
	private void StateInheritHandle(Entity oldEntity, bool notInheritMoveAndAnim)
	{
		FormationDataController.Instance.MarkAggroDirty();
		CharacterUnifiedStateComponent characterUnifiedStateComponent = oldEntity.CheckGetComponent<CharacterUnifiedStateComponent>();
		this.IsWalkModeInternal = characterUnifiedStateComponent.IsWalkModeInternal;
		if (notInheritMoveAndAnim)
		{
			if (!CharacterUnifiedStateComponent.notInheritMoveStateSet.Contains(characterUnifiedStateComponent.MoveState) && CharacterUnifiedStateTypes.LegalMoveStates[this.PositionState].Contains(characterUnifiedStateComponent.MoveState))
			{
				this.SetMoveState(characterUnifiedStateComponent.MoveState);
			}
		}
		else if (this.RoleGaitComponent != null)
		{
			global::ECharMoveState moveState = characterUnifiedStateComponent.MoveState;
			if (moveState <= global::ECharMoveState.Captured)
			{
				switch (moveState)
				{
				case global::ECharMoveState.Walk:
				{
					this.SetPositionState(characterUnifiedStateComponent.PositionState);
					if (this.RoleGaitComponent.EnableRoleGaitState(ERoleGaitEnableType.Walk))
					{
						this.SetMoveState(characterUnifiedStateComponent.MoveState);
						goto IL_1DA;
					}
					global::ECharMoveState? echarMoveState = this.RoleGaitComponent.FindEnableCharMoveState();
					if (echarMoveState != null)
					{
						this.SetMoveState(echarMoveState.Value);
						goto IL_1DA;
					}
					goto IL_1DA;
				}
				case global::ECharMoveState.WalkStop:
				case global::ECharMoveState.RunStop:
					break;
				case global::ECharMoveState.Run:
				{
					this.SetPositionState(characterUnifiedStateComponent.PositionState);
					if (this.RoleGaitComponent.EnableRoleGaitState(ERoleGaitEnableType.Run))
					{
						this.SetMoveState(characterUnifiedStateComponent.MoveState);
						goto IL_1DA;
					}
					global::ECharMoveState? echarMoveState2 = this.RoleGaitComponent.FindEnableCharMoveState();
					if (echarMoveState2 != null)
					{
						this.SetMoveState(echarMoveState2.Value);
						goto IL_1DA;
					}
					goto IL_1DA;
				}
				case global::ECharMoveState.Sprint:
				{
					this.SetPositionState(characterUnifiedStateComponent.PositionState);
					if (this.RoleGaitComponent.EnableRoleGaitState(ERoleGaitEnableType.Sprint))
					{
						this.SetMoveState(characterUnifiedStateComponent.MoveState);
						goto IL_1DA;
					}
					global::ECharMoveState? echarMoveState3 = this.RoleGaitComponent.FindEnableCharMoveState();
					if (echarMoveState3 != null)
					{
						this.SetMoveState(echarMoveState3.Value);
						goto IL_1DA;
					}
					goto IL_1DA;
				}
				default:
					if (moveState == global::ECharMoveState.Captured)
					{
						goto IL_1DA;
					}
					break;
				}
			}
			else if (moveState == global::ECharMoveState.Flying || moveState == global::ECharMoveState.Roll)
			{
				goto IL_1DA;
			}
			if (characterUnifiedStateComponent.PositionState != global::ECharPositionState.Ride && characterUnifiedStateComponent.PositionState != global::ECharPositionState.Floating)
			{
				this.SetPositionState(characterUnifiedStateComponent.PositionState);
				this.SetMoveState(characterUnifiedStateComponent.MoveState);
			}
		}
		IL_1DA:
		ECharDirectionState directionState = characterUnifiedStateComponent.DirectionState;
		if (directionState != ECharDirectionState.AimDirection)
		{
			this.SetDirectionState(directionState);
		}
		else
		{
			this.SetDirectionState(ECharDirectionState.FaceDirection);
		}
		if (characterUnifiedStateComponent.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]))
		{
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]));
		}
	}

	// Token: 0x06017395 RID: 95125 RVA: 0x006D24C0 File Offset: 0x006D06C0
	private void OnCharacterMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		switch (newMovementMode)
		{
		case EMovementMode.MOVE_None:
			this.SetPositionState(global::ECharPositionState.Ground);
			this.SetMoveState(global::ECharMoveState.Other);
			return;
		case EMovementMode.MOVE_Walking:
		case EMovementMode.MOVE_NavWalking:
			this.SetPositionState(global::ECharPositionState.Ground);
			return;
		case EMovementMode.MOVE_Falling:
			this.SetPositionState(global::ECharPositionState.Air);
			if (this.MoveState != global::ECharMoveState.KnockUp && this.MoveState != global::ECharMoveState.Captured)
			{
				this.SetMoveState(global::ECharMoveState.Other);
				return;
			}
			break;
		case EMovementMode.MOVE_Swimming:
			break;
		case EMovementMode.MOVE_Flying:
			this.SetPositionState(global::ECharPositionState.Air);
			if (this.MoveState != global::ECharMoveState.Captured)
			{
				this.SetMoveState(global::ECharMoveState.Flying);
				return;
			}
			break;
		case EMovementMode.MOVE_Custom:
			switch (newCustomMode)
			{
			case 0:
				this.SetPositionState(global::ECharPositionState.Climb);
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]))
				{
					this.SwitchFastClimb(true, false);
					return;
				}
				return;
			case 1:
				this.SetPositionState(global::ECharPositionState.Water);
				return;
			case 2:
				this.SetPositionState(global::ECharPositionState.Air);
				this.SetMoveState(global::ECharMoveState.Glide);
				return;
			case 4:
				this.SetPositionState(global::ECharPositionState.Air);
				return;
			case 5:
				this.SetPositionState(global::ECharPositionState.Ground);
				return;
			case 6:
				this.SetPositionState(global::ECharPositionState.Air);
				return;
			case 7:
				this.SetPositionState(global::ECharPositionState.Air);
				this.SetMoveState(global::ECharMoveState.Soar);
				return;
			case 8:
				this.SetPositionState(global::ECharPositionState.Ski);
				return;
			case 9:
				this.SetPositionState(global::ECharPositionState.Air);
				this.SetMoveState(global::ECharMoveState.Roll);
				return;
			case 10:
				this.SetPositionState(global::ECharPositionState.Air);
				this.SetMoveState(global::ECharMoveState.Kite);
				return;
			case 11:
				this.SetPositionState(global::ECharPositionState.Ride);
				return;
			case 12:
				this.SetPositionState(global::ECharPositionState.RailSlide);
				return;
			case 13:
				this.SetPositionState(global::ECharPositionState.Climb);
				return;
			case 15:
				this.SetPositionState(global::ECharPositionState.Floating);
				this.SetMoveState(global::ECharMoveState.Floating);
				return;
			case 19:
				this.SetPositionState(global::ECharPositionState.FlowerAllTerrain);
				this.SetMoveState(global::ECharMoveState.FlowerFlying);
				return;
			}
			this.SetPositionState(global::ECharPositionState.Air);
			break;
		case EMovementMode.MOVE_WalkingOnAir:
			this.SetPositionState(global::ECharPositionState.Air);
			this.SetMoveState(global::ECharMoveState.WalkOnAir);
			return;
		default:
			return;
		}
	}

	// Token: 0x1700243D RID: 9277
	// (get) Token: 0x06017396 RID: 95126 RVA: 0x006D2694 File Offset: 0x006D0894
	// (set) Token: 0x06017397 RID: 95127 RVA: 0x006D269C File Offset: 0x006D089C
	protected override global::ECharPositionState CachedPositionState { get; set; }

	// Token: 0x06017398 RID: 95128 RVA: 0x006D26A8 File Offset: 0x006D08A8
	public unsafe override void SetPositionState(global::ECharPositionState newPositionState)
	{
		global::ECharPositionState positionState = this.PositionState;
		if (!this.ActorComponent.IsMoveAutonomousProxy)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.UnifiedState;
			Entity entity = base.Entity;
			string message = "非主控端尝试修改位置状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old", positionState.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", newPositionState.ToString());
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (!this.SetPositionStateInternal(newPositionState))
		{
			return;
		}
		this.OnPositionStateChange(positionState, newPositionState);
	}

	// Token: 0x06017399 RID: 95129 RVA: 0x006D274B File Offset: 0x006D094B
	public void SetPositionStateHandle(global::ECharPositionState newPositionState)
	{
		if (this.ActorComponent.IsMoveAutonomousProxy)
		{
			return;
		}
		this.SetPositionStateInternal(newPositionState);
	}

	// Token: 0x0601739A RID: 95130 RVA: 0x006D2764 File Offset: 0x006D0964
	private unsafe bool SetPositionStateInternal(global::ECharPositionState newPositionState)
	{
		global::ECharPositionState positionState = this.PositionState;
		if (positionState == newPositionState)
		{
			return false;
		}
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态"]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionEnumToTag[newPositionState]));
		this.SetPositionSubState(global::ECharPositionSubState.None, true);
		this.CachedPositionState = newPositionState;
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.UnifiedState;
		Entity entity = base.Entity;
		string message = "设置位置状态";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old", positionState.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", newPositionState.ToString());
		instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (base.Entity != null)
		{
			UKuroJsModelFunctionLibrary.SetCharacterUnifiedStateComponentPositionState(base.Entity.Id, (byte)newPositionState);
		}
		return true;
	}

	// Token: 0x1700243E RID: 9278
	// (get) Token: 0x0601739B RID: 95131 RVA: 0x006D2852 File Offset: 0x006D0A52
	public override global::ECharPositionState PositionState
	{
		get
		{
			return this.CachedPositionState;
		}
	}

	// Token: 0x0601739C RID: 95132 RVA: 0x006D285C File Offset: 0x006D0A5C
	protected override void OnLand()
	{
		FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.落地"]);
		this.AbilityComponent.SendGameplayEventToActor(gameplayTagById.Value, null);
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnLand);
		if (this.MoveState == global::ECharMoveState.KnockUp)
		{
			this.SetMoveState(global::ECharMoveState.StandUp);
			return;
		}
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"]))
		{
			return;
		}
		this.SetMoveState(global::ECharMoveState.Other);
	}

	// Token: 0x0601739D RID: 95133 RVA: 0x006D28DE File Offset: 0x006D0ADE
	protected override void OnPositionStateChange(global::ECharPositionState oldState, global::ECharPositionState newState)
	{
		if (newState == global::ECharPositionState.Ground)
		{
			this.OnLand();
		}
		EventSystem.Instance.EmitWithTarget<global::ECharPositionState, global::ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, oldState, newState);
	}

	// Token: 0x1700243F RID: 9279
	// (get) Token: 0x0601739E RID: 95134 RVA: 0x006D2901 File Offset: 0x006D0B01
	// (set) Token: 0x0601739F RID: 95135 RVA: 0x006D2909 File Offset: 0x006D0B09
	protected override global::ECharMoveState CachedMoveState { get; set; } = global::ECharMoveState.Stand;

	// Token: 0x060173A0 RID: 95136 RVA: 0x006D2914 File Offset: 0x006D0B14
	public unsafe override void SetMoveState(global::ECharMoveState newMoveState)
	{
		RoleAudioController.Instance.OnMoveStateChange(newMoveState, base.Entity);
		if (!this.ActorComponent.IsMoveAutonomousProxy)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.UnifiedState;
			Entity entity = base.Entity;
			string message = "非主控端尝试修改移动状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old", this.MoveState.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", newMoveState.ToString());
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.SetMoveStateInternal(newMoveState);
	}

	// Token: 0x060173A1 RID: 95137 RVA: 0x006D29BE File Offset: 0x006D0BBE
	public void SetMoveStateHandle(global::ECharMoveState newMoveState)
	{
		if (this.ActorComponent.IsMoveAutonomousProxy)
		{
			return;
		}
		this.SetMoveStateInternal(newMoveState);
	}

	// Token: 0x060173A2 RID: 95138 RVA: 0x006D29D8 File Offset: 0x006D0BD8
	private unsafe bool SetMoveStateInternal(global::ECharMoveState newMoveState)
	{
		global::ECharMoveState moveState = this.MoveState;
		if (moveState == newMoveState)
		{
			return false;
		}
		if (this.ActorComponent.IsRoleAndCtrlByMe && !CharacterUnifiedStateTypes.LegalMoveStates[this.PositionState].Contains(newMoveState))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Error Move State";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Actor";
			CharacterActorComponent actorComponent = this.ActorComponent;
			object item2;
			if (actorComponent == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = actorComponent.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PositionState", this.PositionState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MoveState", newMoveState);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		CombatLog instance2 = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.UnifiedState;
		Entity entity = base.Entity;
		string message2 = "修改移动状态";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("position", this.PositionState.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("state", newMoveState.ToString());
		instance2.Info(flag, entity, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态"]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.MoveEnumToTag[newMoveState]));
		this.CachedMoveState = newMoveState;
		if (base.Entity != null)
		{
			UKuroJsModelFunctionLibrary.SetCharacterUnifiedStateComponentMoveState(base.Entity.Id, (byte)newMoveState);
		}
		EventSystem.Instance.EmitWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, moveState, newMoveState);
		return true;
	}

	// Token: 0x17002440 RID: 9280
	// (get) Token: 0x060173A3 RID: 95139 RVA: 0x006D2BA0 File Offset: 0x006D0DA0
	public override global::ECharMoveState MoveState
	{
		get
		{
			return this.CachedMoveState;
		}
	}

	// Token: 0x17002441 RID: 9281
	// (get) Token: 0x060173A4 RID: 95140 RVA: 0x006D2BA8 File Offset: 0x006D0DA8
	// (set) Token: 0x060173A5 RID: 95141 RVA: 0x006D2BB0 File Offset: 0x006D0DB0
	protected override ECharDirectionState CachedDirectionState { get; set; } = ECharDirectionState.FaceDirection;

	// Token: 0x060173A6 RID: 95142 RVA: 0x006D2BBC File Offset: 0x006D0DBC
	private void OnDirectionStateChange(ECharDirectionState oldDirectionState, ECharDirectionState newDirectionState)
	{
		if (oldDirectionState == ECharDirectionState.AimDirection)
		{
			this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.瞄准键进入"]));
			this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.长按攻击进入"]));
		}
	}

	// Token: 0x060173A7 RID: 95143 RVA: 0x006D2C0D File Offset: 0x006D0E0D
	public void EnterAimStatus(EAimViewState aimViewState)
	{
		this.CurrentAimType = aimViewState;
		this.ActorComponent.UseControllerRotation = true;
		this.SetDirectionState(ECharDirectionState.AimDirection);
		CharacterLevelShootComponent component = base.Entity.GetComponent<CharacterLevelShootComponent>();
		if (component == null)
		{
			return;
		}
		component.OnEnterAimShoot();
	}

	// Token: 0x060173A8 RID: 95144 RVA: 0x006D2C40 File Offset: 0x006D0E40
	public void ExitAimStatus()
	{
		this.ActorComponent.UseControllerRotation = false;
		if (this.DirectionState == ECharDirectionState.AimDirection)
		{
			CharacterLockOnComponent component = base.Entity.GetComponent<CharacterLockOnComponent>();
			if (component == null || !component.TryRestoreLookAt())
			{
				this.SetDirectionState(ECharDirectionState.FaceDirection);
			}
		}
		CharacterLevelShootComponent component2 = base.Entity.GetComponent<CharacterLevelShootComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.OnExitAimShoot();
	}

	// Token: 0x060173A9 RID: 95145 RVA: 0x006D2C9A File Offset: 0x006D0E9A
	public void SetDirectionStateHandle(ECharDirectionState newDirectionState)
	{
		base.SetDirectionStateInternal(newDirectionState);
	}

	// Token: 0x17002442 RID: 9282
	// (get) Token: 0x060173AA RID: 95146 RVA: 0x006D2CA4 File Offset: 0x006D0EA4
	public override ECharDirectionState DirectionState
	{
		get
		{
			return this.CachedDirectionState;
		}
	}

	// Token: 0x060173AB RID: 95147 RVA: 0x006D2CAC File Offset: 0x006D0EAC
	protected override void ClearDirectionTag(ECharDirectionState oldDirectionState)
	{
		if (oldDirectionState == ECharDirectionState.AimDirection)
		{
			this.ExitAimState();
		}
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.方向状态"]));
	}

	// Token: 0x060173AC RID: 95148 RVA: 0x006D2CD8 File Offset: 0x006D0ED8
	protected override void AddDirectionTag(ECharDirectionState charDirectionState)
	{
		if (charDirectionState == ECharDirectionState.AimDirection)
		{
			this.EnterAimState();
		}
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.DirectionEnumToTag[charDirectionState]));
	}

	// Token: 0x060173AD RID: 95149 RVA: 0x006D2D00 File Offset: 0x006D0F00
	protected void EnterAimState()
	{
		this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走.瞄准"]));
		switch (this.CurrentAimType)
		{
		case EAimViewState.瞄准154身高:
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.154身高"]));
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"]));
			return;
		case EAimViewState.瞄准180身高:
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.180身高"]));
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"]));
			return;
		case EAimViewState.寂寞小姐身高:
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.寂寞小姐瞄准镜头"]));
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"]));
			return;
		case EAimViewState.露帕瞄准:
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.露帕瞄准"]));
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"]));
			return;
		case EAimViewState.Rebecca瞄准:
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.Rebecca瞄准"]));
			return;
		default:
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身通用融合"]));
			return;
		}
	}

	// Token: 0x060173AE RID: 95150 RVA: 0x006D2E90 File Offset: 0x006D1090
	protected void ExitAimState()
	{
		this.CurrentAimType = EAimViewState.EAimViewState_MAX;
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走.瞄准"]));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身通用融合"]));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"]));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头"]));
	}

	// Token: 0x060173AF RID: 95151 RVA: 0x006D2F24 File Offset: 0x006D1124
	public override void InitCharState()
	{
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionEnumToTag[global::ECharPositionState.Ground]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.MoveEnumToTag[global::ECharMoveState.Stand]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.DirectionEnumToTag[ECharDirectionState.FaceDirection]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionSubStateEnumToTag[global::ECharPositionSubState.None]));
	}

	// Token: 0x060173B0 RID: 95152 RVA: 0x006D2F9D File Offset: 0x006D119D
	public override void ResetCharState()
	{
		this.SetPositionSubState(global::ECharPositionSubState.None, false);
	}

	// Token: 0x060173B1 RID: 95153 RVA: 0x006D2FA7 File Offset: 0x006D11A7
	private void OnCharPositionSubStateChanged(global::ECharPositionSubState oldSubState, global::ECharPositionSubState newSubState)
	{
		EventSystem.Instance.EmitWithTarget<global::ECharPositionSubState, global::ECharPositionSubState>(base.Entity, EEventName.CharOnPositionSubStateChanged, oldSubState, newSubState);
	}

	// Token: 0x060173B2 RID: 95154 RVA: 0x006D2FC1 File Offset: 0x006D11C1
	private void UpdatePositionSubTag(global::ECharPositionSubState oldSubState, global::ECharPositionSubState newSubState)
	{
		this.ClearPositionSubTag(oldSubState);
		this.AddPositionSubTag(newSubState);
	}

	// Token: 0x060173B3 RID: 95155 RVA: 0x006D2FD1 File Offset: 0x006D11D1
	private void ClearPositionSubTag(global::ECharPositionSubState oldSubState)
	{
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态"]));
	}

	// Token: 0x060173B4 RID: 95156 RVA: 0x006D2FF3 File Offset: 0x006D11F3
	private void AddPositionSubTag(global::ECharPositionSubState charSubState)
	{
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionSubStateEnumToTag[charSubState]));
	}

	// Token: 0x060173B5 RID: 95157 RVA: 0x006D3010 File Offset: 0x006D1210
	public void SetPositionSubStateHandle(global::ECharPositionSubState newCharPositionSubState)
	{
		this.SetPositionSubStateInternal(newCharPositionSubState, true);
	}

	// Token: 0x060173B6 RID: 95158 RVA: 0x006D301C File Offset: 0x006D121C
	public bool SetPositionSubStateInternal(global::ECharPositionSubState newCharPositionSubState, bool forceAddTag = false)
	{
		global::ECharPositionSubState positionSubState = this.PositionSubState;
		if (positionSubState == newCharPositionSubState)
		{
			if (forceAddTag)
			{
				this.UpdatePositionSubTag(positionSubState, newCharPositionSubState);
			}
			return false;
		}
		this.PositionSubStateInternal = newCharPositionSubState;
		this.UpdatePositionSubTag(positionSubState, newCharPositionSubState);
		return true;
	}

	// Token: 0x060173B7 RID: 95159 RVA: 0x006D3054 File Offset: 0x006D1254
	public void SetPositionSubState(global::ECharPositionSubState newCharPositionSubState, bool forceAddTag = false)
	{
		if (!this.ActorComponent.IsAutonomousProxy)
		{
			return;
		}
		global::ECharPositionSubState positionSubState = this.PositionSubState;
		if (!this.SetPositionSubStateInternal(newCharPositionSubState, forceAddTag))
		{
			return;
		}
		this.OnCharPositionSubStateChanged(positionSubState, newCharPositionSubState);
	}

	// Token: 0x17002443 RID: 9283
	// (get) Token: 0x060173B8 RID: 95160 RVA: 0x006D3089 File Offset: 0x006D1289
	public global::ECharPositionSubState PositionSubState
	{
		get
		{
			return this.PositionSubStateInternal;
		}
	}

	// Token: 0x060173B9 RID: 95161 RVA: 0x006D3091 File Offset: 0x006D1291
	private void EnterSprintRetain()
	{
		if (!this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]))
		{
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]));
		}
	}

	// Token: 0x060173BA RID: 95162 RVA: 0x006D30CE File Offset: 0x006D12CE
	private void ExitSprintRetain()
	{
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]));
	}

	// Token: 0x060173BB RID: 95163 RVA: 0x006D30F0 File Offset: 0x006D12F0
	public void SprintPress()
	{
		if (this.RoleGaitComponent == null || !this.RoleGaitComponent.EnableRoleGaitState(ERoleGaitEnableType.Sprint))
		{
			return;
		}
		this.EnterSprintRetain();
		RoleAudioController instance = RoleAudioController.Instance;
		Entity entity = base.Entity;
		global::ECharMoveState moveState = this.MoveState;
		global::ECharPositionState positionState = this.PositionState;
		CharacterMoveComponent moveComponent = this.MoveComponent;
		TEnumAsByte<EMovementMode>? tenumAsByte;
		if (moveComponent == null)
		{
			tenumAsByte = null;
		}
		else
		{
			UCharacterMovementComponent characterMovement = moveComponent.CharacterMovement;
			tenumAsByte = ((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null);
		}
		TEnumAsByte<EMovementMode>? tenumAsByte2 = tenumAsByte;
		int? movementMode = (tenumAsByte2 != null) ? new int?((int)tenumAsByte2.GetValueOrDefault()) : null;
		CharacterMoveComponent moveComponent2 = this.MoveComponent;
		byte? b;
		if (moveComponent2 == null)
		{
			b = null;
		}
		else
		{
			UCharacterMovementComponent characterMovement2 = moveComponent2.CharacterMovement;
			b = ((characterMovement2 != null) ? new byte?(characterMovement2.CustomMovementMode) : null);
		}
		byte? b2 = b;
		instance.OnPlayAccelerateAudio(entity, moveState, positionState, movementMode, (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null);
	}

	// Token: 0x060173BC RID: 95164 RVA: 0x006D31E5 File Offset: 0x006D13E5
	public void SprintRelease()
	{
		this.ExitSprintRetain();
	}

	// Token: 0x060173BD RID: 95165 RVA: 0x006D31ED File Offset: 0x006D13ED
	public void WalkPress()
	{
		this.WalkPressInternal();
	}

	// Token: 0x060173BE RID: 95166 RVA: 0x006D31F5 File Offset: 0x006D13F5
	public void SwingPress()
	{
		this.SetMoveState(global::ECharMoveState.Swing);
	}

	// Token: 0x060173BF RID: 95167 RVA: 0x006D31FF File Offset: 0x006D13FF
	public void SwingRelease()
	{
		this.SetMoveState(global::ECharMoveState.Other);
	}

	// Token: 0x060173C0 RID: 95168 RVA: 0x006D3208 File Offset: 0x006D1408
	public void SwitchFastSwim(bool fastSwim)
	{
		this.SetMoveState(fastSwim ? global::ECharMoveState.FastSwim : global::ECharMoveState.NormalSwim);
		if (fastSwim)
		{
			this.EnterSprintRetain();
		}
	}

	// Token: 0x060173C1 RID: 95169 RVA: 0x006D3224 File Offset: 0x006D1424
	public void SwitchFastClimb(bool fastClimb, bool noMatterEnterExit = false)
	{
		bool flag = (fastClimb && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止"])) || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制快速攀爬"]);
		if (noMatterEnterExit || (this.MoveState != global::ECharMoveState.EnterClimb && this.MoveState != global::ECharMoveState.ExitClimb))
		{
			this.SetMoveState(flag ? global::ECharMoveState.FastClimb : global::ECharMoveState.NormalClimb);
		}
		if (flag)
		{
			this.EnterSprintRetain();
			RoleAudioController instance = RoleAudioController.Instance;
			Entity entity = base.Entity;
			global::ECharMoveState moveState = this.MoveState;
			global::ECharPositionState positionState = this.PositionState;
			CharacterMoveComponent moveComponent = this.MoveComponent;
			TEnumAsByte<EMovementMode>? tenumAsByte;
			if (moveComponent == null)
			{
				tenumAsByte = null;
			}
			else
			{
				UCharacterMovementComponent characterMovement = moveComponent.CharacterMovement;
				tenumAsByte = ((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null);
			}
			TEnumAsByte<EMovementMode>? tenumAsByte2 = tenumAsByte;
			int? movementMode = (tenumAsByte2 != null) ? new int?((int)tenumAsByte2.GetValueOrDefault()) : null;
			CharacterMoveComponent moveComponent2 = this.MoveComponent;
			byte? b;
			if (moveComponent2 == null)
			{
				b = null;
			}
			else
			{
				UCharacterMovementComponent characterMovement2 = moveComponent2.CharacterMovement;
				b = ((characterMovement2 != null) ? new byte?(characterMovement2.CustomMovementMode) : null);
			}
			byte? b2 = b;
			instance.OnPlayAccelerateAudio(entity, moveState, positionState, movementMode, (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null);
		}
	}

	// Token: 0x060173C2 RID: 95170 RVA: 0x006D336C File Offset: 0x006D156C
	public void ExitHitState(string reason = "")
	{
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"]) && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"]))
		{
			if (this.FloatingComponent != null && this.FloatingComponent.IsFloating)
			{
				this.FloatingComponent.ExitHitState();
			}
			else
			{
				this.SetMoveState(global::ECharMoveState.Other);
			}
		}
		base.Entity.GetComponent<CharacterHitComponent>().DeActiveStiff(reason);
		if (GameModeModel.Instance.IsMulti)
		{
			base.Entity.GetComponent<CharacterMovementSyncComponent>().CollectSampleAndSend(false);
		}
		if (this.ActorComponent.IsMoveAutonomousProxy)
		{
			BaseHitComponent.HitEndRequest(base.Entity);
		}
		CharacterFightStateComponent component = base.Entity.GetComponent<CharacterFightStateComponent>();
		if (component != null && (component.CurrentState == ECharacterFightState.BeHit || component.CurrentState == ECharacterFightState.CounterattackBeHit || component.CurrentState == ECharacterFightState.BeBrokeWeakness))
		{
			base.Entity.GetComponent<CharacterFightStateComponent>().ResetState();
			this.ActorComponent.ResetMoveControlled("退出受击");
		}
	}

	// Token: 0x060173C3 RID: 95171 RVA: 0x006D346C File Offset: 0x006D166C
	private void WalkPressInternal()
	{
		if (this.MoveComponent != null && this.MoveComponent.CanWalkPress() && this.MarkWalkOrRun(!this.IsWalkModeInternal, true, null))
		{
			this.SetWalkOrRunInternal(this.IsWalkMode);
		}
	}

	// Token: 0x060173C4 RID: 95172 RVA: 0x006D34B8 File Offset: 0x006D16B8
	public bool CustomSetWalkOrRun(bool isWalk)
	{
		bool flag;
		if (isWalk)
		{
			flag = (this.MoveState != global::ECharMoveState.Walk);
		}
		else
		{
			flag = (this.MoveState != global::ECharMoveState.Run);
		}
		if (!flag)
		{
			return true;
		}
		if (this.MoveComponent != null && this.MoveComponent.CanWalkPress())
		{
			if (this.MarkWalkOrRun(isWalk, true, null))
			{
				this.SetWalkOrRunInternal(isWalk);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060173C5 RID: 95173 RVA: 0x006D3520 File Offset: 0x006D1720
	public bool MarkWalkOrRun(bool isWalk, bool showUi = true, bool? lockValue = null)
	{
		bool? flag = lockValue;
		bool flag2 = false;
		if (flag.GetValueOrDefault() == flag2 & flag != null)
		{
			this.LockWalkRunState = false;
		}
		if (isWalk == this.IsWalkModeInternal || this.LockWalkRunState || (this.TagComponent != null && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.屏蔽切换走跑功能"])))
		{
			this.LockWalkRunState = (lockValue ?? this.LockWalkRunState);
			return false;
		}
		this.LockWalkRunState = (lockValue ?? this.LockWalkRunState);
		bool isWalkModeInternal = this.IsWalkModeInternal;
		this.IsWalkModeInternal = isWalk;
		if (!showUi || (this.TagComponent != null && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.屏蔽切换行走提示"])))
		{
			EventSystem.Instance.Emit<bool, bool, bool>(EEventName.OnChangeWalkOrRun, isWalkModeInternal, isWalk, false);
		}
		else
		{
			EventSystem.Instance.Emit<bool, bool, bool>(EEventName.OnChangeWalkOrRun, isWalkModeInternal, isWalk, true);
		}
		return false;
	}

	// Token: 0x060173C6 RID: 95174 RVA: 0x006D3621 File Offset: 0x006D1821
	private void SetWalkOrRunInternal(bool isWalk)
	{
		if (this.PositionState != global::ECharPositionState.Ground)
		{
			return;
		}
		if (isWalk)
		{
			this.SetMoveState(global::ECharMoveState.Walk);
			return;
		}
		this.SetMoveState(global::ECharMoveState.Run);
	}

	// Token: 0x060173C7 RID: 95175 RVA: 0x006D363E File Offset: 0x006D183E
	public bool IsInFightState()
	{
		return this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
	}

	// Token: 0x060173C8 RID: 95176 RVA: 0x006D365C File Offset: 0x006D185C
	public void RefreshFightState(bool? inFight = null)
	{
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		int valueOrDefault = ((instance != null) ? instance.GetId() : null).GetValueOrDefault();
		if (!SceneTeamModel.Instance.GetAllGroupEntities(valueOrDefault).Exists((EntityHandle role) => role.Id == base.Entity.Id))
		{
			return;
		}
		if (inFight ?? (this.AggroSet.Count > 0))
		{
			this.TryAddInFightTags();
			return;
		}
		this.TryClearInFightTags();
	}

	// Token: 0x060173C9 RID: 95177 RVA: 0x006D36E0 File Offset: 0x006D18E0
	private bool TryAddInFightTags()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]));
		}
		if (this.InFightCueHandle == 0)
		{
			this.InFightCueHandle = this.CueComponent.AddCue(1101005001L, null);
		}
		return true;
	}

	// Token: 0x060173CA RID: 95178 RVA: 0x006D373C File Offset: 0x006D193C
	public bool TryClearInFightTags()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]));
		}
		if (this.InFightCueHandle != 0)
		{
			CharacterGameplayCueComponent cueComponent = this.CueComponent;
			if (cueComponent != null)
			{
				cueComponent.RemoveCueByHandle((long)this.InFightCueHandle);
			}
		}
		this.InFightCueHandle = 0;
		return true;
	}

	// Token: 0x060173CB RID: 95179 RVA: 0x006D3798 File Offset: 0x006D1998
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.PlayerBattleStateChangeNotify, false, false)]
	public static void OnPlayerBattleStateChangeNotify(Entity entity, [Nullable(1)] PlayerBattleStateChangeNotify data, CombatCommon combatCommon = null)
	{
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetAllGroupEntities(data.PlayerId))
		{
			WorldEntity entity2 = entityHandle.Entity;
			CharacterUnifiedStateComponent characterUnifiedStateComponent = (entity2 != null) ? entity2.GetComponent<CharacterUnifiedStateComponent>() : null;
			if (characterUnifiedStateComponent != null)
			{
				characterUnifiedStateComponent.RefreshFightState(new bool?(data.InBattle));
			}
			if (characterUnifiedStateComponent != null)
			{
				characterUnifiedStateComponent.OnInFight(data.InBattle);
			}
		}
		if (data.PlayerId == CreatureModel.Instance.GetPlayerId())
		{
			FormationDataController.Instance.NotifyInFight(data.InBattle);
		}
	}

	// Token: 0x060173CC RID: 95180 RVA: 0x006D3848 File Offset: 0x006D1A48
	public void OnAggroChanged(bool addOrRemove, AiController from)
	{
		int id = from.CharActorComp.Entity.Id;
		CharacterActorComponent actorComponent = this.ActorComponent;
		bool flag = actorComponent != null && actorComponent.CreatureData.GetEntityType() == EEntityType.Player;
		if (addOrRemove)
		{
			this.AggroSet.Add(id);
		}
		else
		{
			this.AggroSet.Remove(id);
		}
		int id2 = base.Entity.Id;
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
		if (id2 == num.GetValueOrDefault() & num != null)
		{
			FormationDataController.Instance.MarkAggroDirty();
		}
		if (flag)
		{
			FormationDataController.Instance.RefreshFightState();
		}
		if (!this.IsInFighting && !FormationDataController.Instance.GlobalIsInFight && addOrRemove && flag)
		{
			float num2 = (float)global::Vector.Dist(this.ActorComponent.ActorLocationProxy, from.CharActorComp.ActorLocationProxy);
			RoleAudioController.Instance.OnPlayerEnterFight(base.Entity, (double)num2);
		}
	}

	// Token: 0x060173CD RID: 95181 RVA: 0x006D3948 File Offset: 0x006D1B48
	private void MarkActorInFighting(bool isInFighting)
	{
		this.IsInFighting = isInFighting;
		if (base.Entity != null && base.Entity.GameBudgetManagedToken != 0U)
		{
			UKuroGameBudgetAllocatorCSharpInterface.MarkActorInFighting(base.Entity.GameBudgetConfig.GroupName, base.Entity.GameBudgetManagedToken, isInFighting);
			CharacterActorComponent actorComponent = this.ActorComponent;
			TsBaseCharacter tsBaseCharacter = (actorComponent != null) ? actorComponent.Actor : null;
			if (tsBaseCharacter != null)
			{
				EventSystem.Instance.EmitWithTarget<bool>(tsBaseCharacter, EEventName.OnMarkActorInFighting, isInFighting);
			}
		}
	}

	// Token: 0x060173CE RID: 95182 RVA: 0x006D39BA File Offset: 0x006D1BBA
	public void OnInFight(bool inFight)
	{
		this.MarkActorInFighting(inFight);
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (component != null)
		{
			component.SetAnimParamsInFight(inFight);
		}
		CombatMessageModel.Instance.AnyHateChange = true;
	}

	// Token: 0x060173CF RID: 95183 RVA: 0x006D39E8 File Offset: 0x006D1BE8
	public void OnUpdateSceneTeam()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component != null && component.IsRole())
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int playerId = component.GetPlayerId();
			if ((id.GetValueOrDefault() == playerId & id != null) && FormationDataController.Instance.GlobalIsInFight)
			{
				this.RefreshFightState(new bool?(true));
				this.OnInFight(true);
			}
		}
	}

	// Token: 0x17002444 RID: 9284
	// (get) Token: 0x060173D0 RID: 95184 RVA: 0x006D3A51 File Offset: 0x006D1C51
	public bool WalkModeLocked
	{
		get
		{
			return !this.RoleGaitComponent.EnableRoleGaitState(ERoleGaitEnableType.Run);
		}
	}

	// Token: 0x17002445 RID: 9285
	// (get) Token: 0x060173D1 RID: 95185 RVA: 0x006D3A62 File Offset: 0x006D1C62
	public bool IsWalkBaseMode
	{
		get
		{
			return this.IsWalkModeInternal;
		}
	}

	// Token: 0x17002446 RID: 9286
	// (get) Token: 0x060173D2 RID: 95186 RVA: 0x006D3A6A File Offset: 0x006D1C6A
	public bool IsWalkMode
	{
		get
		{
			return this.WalkModeLocked || this.IsWalkModeInternal;
		}
	}

	// Token: 0x060173D3 RID: 95187 RVA: 0x006D3A7C File Offset: 0x006D1C7C
	public new unsafe static void Load()
	{
		if (CharacterUnifiedStateComponent.NeedLoad)
		{
			CharacterUnifiedStateComponent.PositionTagList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.滑雪"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.载具"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.滑轨"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.悬浮"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.机甲全天候"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.花瓣飞行"]
			};
			CharacterUnifiedStateComponent.MoveTagList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.其他"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.站立"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走停止"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.跑步"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.跑步停止"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺停止"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.闪避"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.落地翻滚"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击倒"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被弹反"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.轻击"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.重击"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.正常攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.快速攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑翔"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击飞"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.加速游泳"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.正常游泳"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.摇荡"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑坡.普通滑坡"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.特殊飞行"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.攀爬.进入攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.攀爬.退出攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑雪.正常滑雪"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.倒地起身"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.特殊滚动"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.风筝"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.贡多拉"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.NPC载具"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.空中步行"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被破弱"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.上升"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.下降"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.常规移动"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.机甲悬浮"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.机甲喷射飞行"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.机甲喷射飞行"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.花瓣飞行"]
			};
			CharacterUnifiedStateComponent.DirectionTagList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.注视方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.瞄准方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.面朝方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.看向方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.相机方向"]
			};
			CharacterUnifiedStateComponent.PositionSubStateTagList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态.无次状态"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态.水面"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态.空中行走"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态.空中悬浮"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态.地面悬浮"]
			};
			CharacterUnifiedStateComponent.PositionEnumToTag = new Dictionary<global::ECharPositionState, int>();
			CharacterUnifiedStateComponent.PositionEnumToTagInverse = new Dictionary<int, global::ECharPositionState>();
			Array enumValuesAsUnderlyingType = typeof(global::ECharPositionState).GetEnumValuesAsUnderlyingType();
			foreach (global::ECharPositionState echarPositionState in *Unsafe.As<Array, global::ECharPositionState[]>(ref enumValuesAsUnderlyingType))
			{
				CharacterUnifiedStateComponent.PositionEnumToTag[echarPositionState] = CharacterUnifiedStateComponent.PositionTagList[(int)echarPositionState];
				CharacterUnifiedStateComponent.PositionEnumToTagInverse[CharacterUnifiedStateComponent.PositionTagList[(int)echarPositionState]] = echarPositionState;
			}
			CharacterUnifiedStateComponent.MoveEnumToTag = new Dictionary<global::ECharMoveState, int>();
			CharacterUnifiedStateComponent.MoveEnumToTagInverse = new Dictionary<int, global::ECharMoveState>();
			Array enumValuesAsUnderlyingType2 = typeof(global::ECharMoveState).GetEnumValuesAsUnderlyingType();
			foreach (global::ECharMoveState echarMoveState in *Unsafe.As<Array, global::ECharMoveState[]>(ref enumValuesAsUnderlyingType2))
			{
				CharacterUnifiedStateComponent.MoveEnumToTag[echarMoveState] = CharacterUnifiedStateComponent.MoveTagList[(int)echarMoveState];
				CharacterUnifiedStateComponent.MoveEnumToTagInverse[CharacterUnifiedStateComponent.MoveTagList[(int)echarMoveState]] = echarMoveState;
			}
			CharacterUnifiedStateComponent.DirectionEnumToTag = new Dictionary<ECharDirectionState, int>();
			CharacterUnifiedStateComponent.DirectionEnumToTagInverse = new Dictionary<int, ECharDirectionState>();
			Array enumValuesAsUnderlyingType3 = typeof(ECharDirectionState).GetEnumValuesAsUnderlyingType();
			foreach (ECharDirectionState echarDirectionState in *Unsafe.As<Array, ECharDirectionState[]>(ref enumValuesAsUnderlyingType3))
			{
				CharacterUnifiedStateComponent.DirectionEnumToTag[echarDirectionState] = CharacterUnifiedStateComponent.DirectionTagList[(int)echarDirectionState];
				CharacterUnifiedStateComponent.DirectionEnumToTagInverse[CharacterUnifiedStateComponent.DirectionTagList[(int)echarDirectionState]] = echarDirectionState;
			}
			CharacterUnifiedStateComponent.PositionSubStateEnumToTag = new Dictionary<global::ECharPositionSubState, int>();
			Array enumValuesAsUnderlyingType4 = typeof(global::ECharPositionSubState).GetEnumValuesAsUnderlyingType();
			foreach (global::ECharPositionSubState echarPositionSubState in *Unsafe.As<Array, global::ECharPositionSubState[]>(ref enumValuesAsUnderlyingType4))
			{
				CharacterUnifiedStateComponent.PositionSubStateEnumToTag[echarPositionSubState] = CharacterUnifiedStateComponent.PositionSubStateTagList[(int)echarPositionSubState];
			}
			CharacterUnifiedStateComponent.NeedLoad = false;
		}
	}

	// Token: 0x060173D4 RID: 95188 RVA: 0x006D40FC File Offset: 0x006D22FC
	public void PreprocessChangeRole(bool inGame)
	{
		foreach (int num in CharacterUnifiedStateComponent.outGameRoleTags)
		{
			if (inGame)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.RemoveTag(new int?(num));
				}
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null || !tagComponent2.HasTag(num))
				{
					BaseTagComponent tagComponent3 = this.TagComponent;
					if (tagComponent3 != null)
					{
						tagComponent3.AddTag(new int?(num));
					}
				}
			}
		}
	}

	// Token: 0x060173D5 RID: 95189 RVA: 0x006D416D File Offset: 0x006D236D
	public HashSet<int> GetAggroSet()
	{
		return this.AggroSet;
	}

	// Token: 0x060173D6 RID: 95190 RVA: 0x006D4175 File Offset: 0x006D2375
	public new static void CreateStaticDefaultValue()
	{
		CharacterUnifiedStateComponent.NeedLoad = true;
	}

	// Token: 0x060173D7 RID: 95191 RVA: 0x006D4180 File Offset: 0x006D2380
	public new static void ResetStaticDefaultValue()
	{
		CharacterUnifiedStateComponent.NeedLoad = false;
		CharacterUnifiedStateComponent.PositionTagList = null;
		CharacterUnifiedStateComponent.MoveTagList = null;
		CharacterUnifiedStateComponent.SubStateTagList = null;
		CharacterUnifiedStateComponent.DirectionTagList = null;
		CharacterUnifiedStateComponent.PositionSubStateTagList = null;
		CharacterUnifiedStateComponent.MoveEnumToTag = null;
		CharacterUnifiedStateComponent.MoveEnumToTagInverse = null;
		CharacterUnifiedStateComponent.PositionEnumToTag = null;
		CharacterUnifiedStateComponent.PositionEnumToTagInverse = null;
		CharacterUnifiedStateComponent.DirectionEnumToTag = null;
		CharacterUnifiedStateComponent.DirectionEnumToTagInverse = null;
		CharacterUnifiedStateComponent.PositionSubStateEnumToTag = null;
	}

	// Token: 0x060173D8 RID: 95192 RVA: 0x006D41DC File Offset: 0x006D23DC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterUnifiedStateComponent characterUnifiedStateComponent = (CharacterUnifiedStateComponent)componentTemplate;
		if (characterUnifiedStateComponent.AbilityComponent == null)
		{
			this.AbilityComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AbilityComponent), "AbilityComponent"))
		{
			return false;
		}
		if (characterUnifiedStateComponent.CueComponent == null)
		{
			this.CueComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CueComponent), "CueComponent"))
		{
			return false;
		}
		if (characterUnifiedStateComponent.RoleGaitComponent == null)
		{
			this.RoleGaitComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoleGaitComponent), "RoleGaitComponent"))
		{
			return false;
		}
		if (characterUnifiedStateComponent.FloatingComponent == null)
		{
			this.FloatingComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingComponent), "FloatingComponent"))
		{
			return false;
		}
		if (characterUnifiedStateComponent.MoveComponent == null)
		{
			this.MoveComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
		{
			return false;
		}
		this.LockWalkRunState = characterUnifiedStateComponent.LockWalkRunState;
		this.CachedPositionState = characterUnifiedStateComponent.CachedPositionState;
		this.CachedMoveState = characterUnifiedStateComponent.CachedMoveState;
		this.CachedDirectionState = characterUnifiedStateComponent.CachedDirectionState;
		this.CurrentAimType = characterUnifiedStateComponent.CurrentAimType;
		this.PositionSubStateInternal = characterUnifiedStateComponent.PositionSubStateInternal;
		this.InFightCueHandle = characterUnifiedStateComponent.InFightCueHandle;
		if (characterUnifiedStateComponent.AggroSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.AggroSet), "AggroSet"))
		{
			return false;
		}
		this.IsWalkModeInternal = characterUnifiedStateComponent.IsWalkModeInternal;
		return true;
	}

	// Token: 0x17002447 RID: 9287
	// (get) Token: 0x060173D9 RID: 95193 RVA: 0x006D4355 File Offset: 0x006D2555
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002448 RID: 9288
	// (get) Token: 0x060173DA RID: 95194 RVA: 0x006D4358 File Offset: 0x006D2558
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002449 RID: 9289
	// (get) Token: 0x060173DB RID: 95195 RVA: 0x006D435B File Offset: 0x006D255B
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700244A RID: 9290
	// (get) Token: 0x060173DC RID: 95196 RVA: 0x006D435E File Offset: 0x006D255E
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700244B RID: 9291
	// (get) Token: 0x060173DD RID: 95197 RVA: 0x006D4361 File Offset: 0x006D2561
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700244C RID: 9292
	// (get) Token: 0x060173DE RID: 95198 RVA: 0x006D4364 File Offset: 0x006D2564
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C3D7 RID: 50135
	[StaticVariableRuleIgnore]
	public static readonly int[] outGameRoleTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被取对象"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被子弹命中"]
	};

	// Token: 0x0400C3D8 RID: 50136
	[StaticVariableRuleIgnore]
	private static HashSet<global::ECharMoveState> notInheritMoveStateSet = new HashSet<global::ECharMoveState>
	{
		global::ECharMoveState.Flying,
		global::ECharMoveState.Roll,
		global::ECharMoveState.WalkOnAir,
		global::ECharMoveState.Glide
	};

	// Token: 0x0400C3D9 RID: 50137
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComponent;

	// Token: 0x0400C3DA RID: 50138
	[Nullable(2)]
	private CharacterGameplayCueComponent CueComponent;

	// Token: 0x0400C3DB RID: 50139
	[Nullable(2)]
	private RoleGaitComponent RoleGaitComponent;

	// Token: 0x0400C3DC RID: 50140
	[Nullable(2)]
	private CharacterFloatingComponent FloatingComponent;

	// Token: 0x0400C3DD RID: 50141
	[Nullable(2)]
	private CharacterMoveComponent MoveComponent;

	// Token: 0x0400C3DE RID: 50142
	private bool LockWalkRunState;

	// Token: 0x0400C3E2 RID: 50146
	protected EAimViewState CurrentAimType = EAimViewState.EAimViewState_MAX;

	// Token: 0x0400C3E3 RID: 50147
	protected global::ECharPositionSubState PositionSubStateInternal;

	// Token: 0x0400C3E4 RID: 50148
	protected int InFightCueHandle;

	// Token: 0x0400C3E5 RID: 50149
	private readonly HashSet<int> AggroSet = new HashSet<int>();

	// Token: 0x0400C3E6 RID: 50150
	[StaticVariableRuleIgnore]
	private static readonly Stat RefreshFightStateStat = Stat.Create("OnAggroChanged.RefreshFightState", "", "");

	// Token: 0x0400C3E7 RID: 50151
	[StaticVariableRuleIgnore]
	private static readonly Stat FightBuffStat = Stat.Create("OnAggroChanged.FightBuff", "", "");

	// Token: 0x0400C3E8 RID: 50152
	protected static int[] PositionTagList;

	// Token: 0x0400C3E9 RID: 50153
	protected static int[] MoveTagList;

	// Token: 0x0400C3EA RID: 50154
	protected static int[] SubStateTagList;

	// Token: 0x0400C3EB RID: 50155
	protected static int[] DirectionTagList;

	// Token: 0x0400C3EC RID: 50156
	protected static int[] PositionSubStateTagList;

	// Token: 0x0400C3ED RID: 50157
	protected static Dictionary<global::ECharMoveState, int> MoveEnumToTag;

	// Token: 0x0400C3EE RID: 50158
	protected static Dictionary<int, global::ECharMoveState> MoveEnumToTagInverse;

	// Token: 0x0400C3EF RID: 50159
	protected static Dictionary<global::ECharPositionState, int> PositionEnumToTag;

	// Token: 0x0400C3F0 RID: 50160
	protected static Dictionary<int, global::ECharPositionState> PositionEnumToTagInverse;

	// Token: 0x0400C3F1 RID: 50161
	protected static Dictionary<ECharDirectionState, int> DirectionEnumToTag;

	// Token: 0x0400C3F2 RID: 50162
	protected static Dictionary<int, ECharDirectionState> DirectionEnumToTagInverse;

	// Token: 0x0400C3F3 RID: 50163
	protected static Dictionary<global::ECharPositionSubState, int> PositionSubStateEnumToTag;

	// Token: 0x0400C3F4 RID: 50164
	private bool IsWalkModeInternal;

	// Token: 0x0400C3F5 RID: 50165
	private static bool NeedLoad = false;
}
