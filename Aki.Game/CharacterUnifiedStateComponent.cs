using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x02002EEA RID: 12010
[NullableContext(1)]
[Nullable(0)]
public class CharacterUnifiedStateComponent : BaseUnifiedStateComponent, IComponentDependency
{
	// Token: 0x06019A87 RID: 105095 RVA: 0x006ABC40 File Offset: 0x006A9E40
	static CharacterUnifiedStateComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterUnifiedStateComponent.CreateStaticDefaultValue), new Action(CharacterUnifiedStateComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700237F RID: 9087
	// (get) Token: 0x06019A88 RID: 105096 RVA: 0x006ABCFF File Offset: 0x006A9EFF
	[Nullable(2)]
	protected new CharacterActorComponent ActorComponent
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComponent as CharacterActorComponent;
		}
	}

	// Token: 0x17002380 RID: 9088
	// (get) Token: 0x06019A89 RID: 105097 RVA: 0x006ABD0C File Offset: 0x006A9F0C
	public static Type[] Dependencies
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

	// Token: 0x06019A8A RID: 105098 RVA: 0x006ABD2E File Offset: 0x006A9F2E
	protected override bool OnInit()
	{
		CharacterUnifiedStateComponent.Load();
		return true;
	}

	// Token: 0x06019A8B RID: 105099 RVA: 0x006ABD38 File Offset: 0x006A9F38
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

	// Token: 0x06019A8C RID: 105100 RVA: 0x006ABE98 File Offset: 0x006AA098
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

	// Token: 0x06019A8D RID: 105101 RVA: 0x006ABF92 File Offset: 0x006AA192
	protected override void OnEnable()
	{
		base.OnEnable();
		this.PreprocessChangeRole(true);
	}

	// Token: 0x06019A8E RID: 105102 RVA: 0x006ABFA1 File Offset: 0x006AA1A1
	protected override void OnDisable(string reason)
	{
		base.OnDisable(reason);
		this.PreprocessChangeRole(false);
	}

	// Token: 0x06019A8F RID: 105103 RVA: 0x006ABFB4 File Offset: 0x006AA1B4
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

	// Token: 0x06019A90 RID: 105104 RVA: 0x006AC1F4 File Offset: 0x006AA3F4
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

	// Token: 0x17002381 RID: 9089
	// (get) Token: 0x06019A91 RID: 105105 RVA: 0x006AC3A7 File Offset: 0x006AA5A7
	// (set) Token: 0x06019A92 RID: 105106 RVA: 0x006AC3AF File Offset: 0x006AA5AF
	protected override global::ECharPositionState CachedPositionState { get; set; }

	// Token: 0x06019A93 RID: 105107 RVA: 0x006AC3B8 File Offset: 0x006AA5B8
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

	// Token: 0x06019A94 RID: 105108 RVA: 0x006AC45B File Offset: 0x006AA65B
	public void SetPositionStateHandle(global::ECharPositionState newPositionState)
	{
		if (this.ActorComponent.IsMoveAutonomousProxy)
		{
			return;
		}
		this.SetPositionStateInternal(newPositionState);
	}

	// Token: 0x06019A95 RID: 105109 RVA: 0x006AC474 File Offset: 0x006AA674
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

	// Token: 0x17002382 RID: 9090
	// (get) Token: 0x06019A96 RID: 105110 RVA: 0x006AC562 File Offset: 0x006AA762
	public override global::ECharPositionState PositionState
	{
		get
		{
			return this.CachedPositionState;
		}
	}

	// Token: 0x06019A97 RID: 105111 RVA: 0x006AC56C File Offset: 0x006AA76C
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

	// Token: 0x06019A98 RID: 105112 RVA: 0x006AC5EE File Offset: 0x006AA7EE
	protected override void OnPositionStateChange(global::ECharPositionState oldState, global::ECharPositionState newState)
	{
		if (newState == global::ECharPositionState.Ground)
		{
			this.OnLand();
		}
		EventSystem.Instance.EmitWithTarget<global::ECharPositionState, global::ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, oldState, newState);
	}

	// Token: 0x17002383 RID: 9091
	// (get) Token: 0x06019A99 RID: 105113 RVA: 0x006AC611 File Offset: 0x006AA811
	// (set) Token: 0x06019A9A RID: 105114 RVA: 0x006AC619 File Offset: 0x006AA819
	protected override global::ECharMoveState CachedMoveState { get; set; } = global::ECharMoveState.Stand;

	// Token: 0x06019A9B RID: 105115 RVA: 0x006AC624 File Offset: 0x006AA824
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

	// Token: 0x06019A9C RID: 105116 RVA: 0x006AC6CE File Offset: 0x006AA8CE
	public void SetMoveStateHandle(global::ECharMoveState newMoveState)
	{
		if (this.ActorComponent.IsMoveAutonomousProxy)
		{
			return;
		}
		this.SetMoveStateInternal(newMoveState);
	}

	// Token: 0x06019A9D RID: 105117 RVA: 0x006AC6E8 File Offset: 0x006AA8E8
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

	// Token: 0x17002384 RID: 9092
	// (get) Token: 0x06019A9E RID: 105118 RVA: 0x006AC8B0 File Offset: 0x006AAAB0
	public override global::ECharMoveState MoveState
	{
		get
		{
			return this.CachedMoveState;
		}
	}

	// Token: 0x17002385 RID: 9093
	// (get) Token: 0x06019A9F RID: 105119 RVA: 0x006AC8B8 File Offset: 0x006AAAB8
	// (set) Token: 0x06019AA0 RID: 105120 RVA: 0x006AC8C0 File Offset: 0x006AAAC0
	protected override ECharDirectionState CachedDirectionState { get; set; } = ECharDirectionState.FaceDirection;

	// Token: 0x06019AA1 RID: 105121 RVA: 0x006AC8CC File Offset: 0x006AAACC
	private void OnDirectionStateChange(ECharDirectionState oldDirectionState, ECharDirectionState newDirectionState)
	{
		if (oldDirectionState == ECharDirectionState.AimDirection)
		{
			this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.瞄准键进入"]));
			this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.长按攻击进入"]));
		}
	}

	// Token: 0x06019AA2 RID: 105122 RVA: 0x006AC91D File Offset: 0x006AAB1D
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

	// Token: 0x06019AA3 RID: 105123 RVA: 0x006AC950 File Offset: 0x006AAB50
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

	// Token: 0x06019AA4 RID: 105124 RVA: 0x006AC9AA File Offset: 0x006AABAA
	public void SetDirectionStateHandle(ECharDirectionState newDirectionState)
	{
		base.SetDirectionStateInternal(newDirectionState);
	}

	// Token: 0x17002386 RID: 9094
	// (get) Token: 0x06019AA5 RID: 105125 RVA: 0x006AC9B4 File Offset: 0x006AABB4
	public override ECharDirectionState DirectionState
	{
		get
		{
			return this.CachedDirectionState;
		}
	}

	// Token: 0x06019AA6 RID: 105126 RVA: 0x006AC9BC File Offset: 0x006AABBC
	protected override void ClearDirectionTag(ECharDirectionState oldDirectionState)
	{
		if (oldDirectionState == ECharDirectionState.AimDirection)
		{
			this.ExitAimState();
		}
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.方向状态"]));
	}

	// Token: 0x06019AA7 RID: 105127 RVA: 0x006AC9E8 File Offset: 0x006AABE8
	protected override void AddDirectionTag(ECharDirectionState charDirectionState)
	{
		if (charDirectionState == ECharDirectionState.AimDirection)
		{
			this.EnterAimState();
		}
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.DirectionEnumToTag[charDirectionState]));
	}

	// Token: 0x06019AA8 RID: 105128 RVA: 0x006ACA10 File Offset: 0x006AAC10
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

	// Token: 0x06019AA9 RID: 105129 RVA: 0x006ACBA0 File Offset: 0x006AADA0
	protected void ExitAimState()
	{
		this.CurrentAimType = EAimViewState.EAimViewState_MAX;
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走.瞄准"]));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身通用融合"]));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"]));
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头"]));
	}

	// Token: 0x06019AAA RID: 105130 RVA: 0x006ACC34 File Offset: 0x006AAE34
	public override void InitCharState()
	{
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionEnumToTag[global::ECharPositionState.Ground]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.MoveEnumToTag[global::ECharMoveState.Stand]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.DirectionEnumToTag[ECharDirectionState.FaceDirection]));
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionSubStateEnumToTag[global::ECharPositionSubState.None]));
	}

	// Token: 0x06019AAB RID: 105131 RVA: 0x006ACCAD File Offset: 0x006AAEAD
	public override void ResetCharState()
	{
		this.SetPositionSubState(global::ECharPositionSubState.None, false);
	}

	// Token: 0x06019AAC RID: 105132 RVA: 0x006ACCB7 File Offset: 0x006AAEB7
	private void OnCharPositionSubStateChanged(global::ECharPositionSubState oldSubState, global::ECharPositionSubState newSubState)
	{
		EventSystem.Instance.EmitWithTarget<global::ECharPositionSubState, global::ECharPositionSubState>(base.Entity, EEventName.CharOnPositionSubStateChanged, oldSubState, newSubState);
	}

	// Token: 0x06019AAD RID: 105133 RVA: 0x006ACCD1 File Offset: 0x006AAED1
	private void UpdatePositionSubTag(global::ECharPositionSubState oldSubState, global::ECharPositionSubState newSubState)
	{
		this.ClearPositionSubTag(oldSubState);
		this.AddPositionSubTag(newSubState);
	}

	// Token: 0x06019AAE RID: 105134 RVA: 0x006ACCE1 File Offset: 0x006AAEE1
	private void ClearPositionSubTag(global::ECharPositionSubState oldSubState)
	{
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.次状态"]));
	}

	// Token: 0x06019AAF RID: 105135 RVA: 0x006ACD03 File Offset: 0x006AAF03
	private void AddPositionSubTag(global::ECharPositionSubState charSubState)
	{
		this.TagComponent.AddTag(new int?(CharacterUnifiedStateComponent.PositionSubStateEnumToTag[charSubState]));
	}

	// Token: 0x06019AB0 RID: 105136 RVA: 0x006ACD20 File Offset: 0x006AAF20
	public void SetPositionSubStateHandle(global::ECharPositionSubState newCharPositionSubState)
	{
		this.SetPositionSubStateInternal(newCharPositionSubState, true);
	}

	// Token: 0x06019AB1 RID: 105137 RVA: 0x006ACD2C File Offset: 0x006AAF2C
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

	// Token: 0x06019AB2 RID: 105138 RVA: 0x006ACD64 File Offset: 0x006AAF64
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

	// Token: 0x17002387 RID: 9095
	// (get) Token: 0x06019AB3 RID: 105139 RVA: 0x006ACD99 File Offset: 0x006AAF99
	public global::ECharPositionSubState PositionSubState
	{
		get
		{
			return this.PositionSubStateInternal;
		}
	}

	// Token: 0x06019AB4 RID: 105140 RVA: 0x006ACDA1 File Offset: 0x006AAFA1
	private void EnterSprintRetain()
	{
		if (!this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]))
		{
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]));
		}
	}

	// Token: 0x06019AB5 RID: 105141 RVA: 0x006ACDDE File Offset: 0x006AAFDE
	private void ExitSprintRetain()
	{
		this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]));
	}

	// Token: 0x06019AB6 RID: 105142 RVA: 0x006ACE00 File Offset: 0x006AB000
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

	// Token: 0x06019AB7 RID: 105143 RVA: 0x006ACEF5 File Offset: 0x006AB0F5
	public void SprintRelease()
	{
		this.ExitSprintRetain();
	}

	// Token: 0x06019AB8 RID: 105144 RVA: 0x006ACEFD File Offset: 0x006AB0FD
	public void WalkPress()
	{
		this.WalkPressInternal();
	}

	// Token: 0x06019AB9 RID: 105145 RVA: 0x006ACF05 File Offset: 0x006AB105
	public void SwingPress()
	{
		this.SetMoveState(global::ECharMoveState.Swing);
	}

	// Token: 0x06019ABA RID: 105146 RVA: 0x006ACF0F File Offset: 0x006AB10F
	public void SwingRelease()
	{
		this.SetMoveState(global::ECharMoveState.Other);
	}

	// Token: 0x06019ABB RID: 105147 RVA: 0x006ACF18 File Offset: 0x006AB118
	public void SwitchFastSwim(bool fastSwim)
	{
		this.SetMoveState(fastSwim ? global::ECharMoveState.FastSwim : global::ECharMoveState.NormalSwim);
		if (fastSwim)
		{
			this.EnterSprintRetain();
		}
	}

	// Token: 0x06019ABC RID: 105148 RVA: 0x006ACF34 File Offset: 0x006AB134
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

	// Token: 0x06019ABD RID: 105149 RVA: 0x006AD07C File Offset: 0x006AB27C
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

	// Token: 0x06019ABE RID: 105150 RVA: 0x006AD17C File Offset: 0x006AB37C
	private void WalkPressInternal()
	{
		if (this.MoveComponent != null && this.MoveComponent.CanWalkPress() && this.MarkWalkOrRun(!this.IsWalkModeInternal, true, null))
		{
			this.SetWalkOrRunInternal(this.IsWalkMode);
		}
	}

	// Token: 0x06019ABF RID: 105151 RVA: 0x006AD1C8 File Offset: 0x006AB3C8
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

	// Token: 0x06019AC0 RID: 105152 RVA: 0x006AD230 File Offset: 0x006AB430
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

	// Token: 0x06019AC1 RID: 105153 RVA: 0x006AD331 File Offset: 0x006AB531
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

	// Token: 0x06019AC2 RID: 105154 RVA: 0x006AD34E File Offset: 0x006AB54E
	public bool IsInFightState()
	{
		return this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
	}

	// Token: 0x06019AC3 RID: 105155 RVA: 0x006AD36C File Offset: 0x006AB56C
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

	// Token: 0x06019AC4 RID: 105156 RVA: 0x006AD3F0 File Offset: 0x006AB5F0
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

	// Token: 0x06019AC5 RID: 105157 RVA: 0x006AD44C File Offset: 0x006AB64C
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

	// Token: 0x06019AC6 RID: 105158 RVA: 0x006AD4A8 File Offset: 0x006AB6A8
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

	// Token: 0x06019AC7 RID: 105159 RVA: 0x006AD558 File Offset: 0x006AB758
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

	// Token: 0x06019AC8 RID: 105160 RVA: 0x006AD658 File Offset: 0x006AB858
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

	// Token: 0x06019AC9 RID: 105161 RVA: 0x006AD6CA File Offset: 0x006AB8CA
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

	// Token: 0x06019ACA RID: 105162 RVA: 0x006AD6F8 File Offset: 0x006AB8F8
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

	// Token: 0x17002388 RID: 9096
	// (get) Token: 0x06019ACB RID: 105163 RVA: 0x006AD761 File Offset: 0x006AB961
	public bool WalkModeLocked
	{
		get
		{
			return !this.RoleGaitComponent.EnableRoleGaitState(ERoleGaitEnableType.Run);
		}
	}

	// Token: 0x17002389 RID: 9097
	// (get) Token: 0x06019ACC RID: 105164 RVA: 0x006AD772 File Offset: 0x006AB972
	public bool IsWalkBaseMode
	{
		get
		{
			return this.IsWalkModeInternal;
		}
	}

	// Token: 0x1700238A RID: 9098
	// (get) Token: 0x06019ACD RID: 105165 RVA: 0x006AD77A File Offset: 0x006AB97A
	public bool IsWalkMode
	{
		get
		{
			return this.WalkModeLocked || this.IsWalkModeInternal;
		}
	}

	// Token: 0x06019ACE RID: 105166 RVA: 0x006AD78C File Offset: 0x006AB98C
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
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.悬浮"]
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
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.常规移动"]
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

	// Token: 0x06019ACF RID: 105167 RVA: 0x006ADD98 File Offset: 0x006ABF98
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

	// Token: 0x06019AD0 RID: 105168 RVA: 0x006ADE09 File Offset: 0x006AC009
	public HashSet<int> GetAggroSet()
	{
		return this.AggroSet;
	}

	// Token: 0x06019AD1 RID: 105169 RVA: 0x006ADE11 File Offset: 0x006AC011
	public new static void CreateStaticDefaultValue()
	{
		CharacterUnifiedStateComponent.NeedLoad = true;
	}

	// Token: 0x06019AD2 RID: 105170 RVA: 0x006ADE1C File Offset: 0x006AC01C
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

	// Token: 0x06019AD3 RID: 105171 RVA: 0x006ADE78 File Offset: 0x006AC078
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterUnifiedStateComponent characterUnifiedStateComponent = (CharacterUnifiedStateComponent)componentTemplate;
		if (base.CanResetComponentProperty("AbilityComponent"))
		{
			if (characterUnifiedStateComponent.AbilityComponent == null)
			{
				this.AbilityComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAbilityComponent>(this.AbilityComponent), "AbilityComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CueComponent"))
		{
			if (characterUnifiedStateComponent.CueComponent == null)
			{
				this.CueComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterGameplayCueComponent>(this.CueComponent), "CueComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RoleGaitComponent"))
		{
			if (characterUnifiedStateComponent.RoleGaitComponent == null)
			{
				this.RoleGaitComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RoleGaitComponent>(this.RoleGaitComponent), "RoleGaitComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FloatingComponent"))
		{
			if (characterUnifiedStateComponent.FloatingComponent == null)
			{
				this.FloatingComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterFloatingComponent>(this.FloatingComponent), "FloatingComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComponent"))
		{
			if (characterUnifiedStateComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LockWalkRunState"))
		{
			this.LockWalkRunState = characterUnifiedStateComponent.LockWalkRunState;
		}
		if (base.CanResetComponentProperty("<CachedPositionState>k__BackingField"))
		{
			this.CachedPositionState = characterUnifiedStateComponent.CachedPositionState;
		}
		if (base.CanResetComponentProperty("<CachedMoveState>k__BackingField"))
		{
			this.CachedMoveState = characterUnifiedStateComponent.CachedMoveState;
		}
		if (base.CanResetComponentProperty("<CachedDirectionState>k__BackingField"))
		{
			this.CachedDirectionState = characterUnifiedStateComponent.CachedDirectionState;
		}
		if (base.CanResetComponentProperty("CurrentAimType"))
		{
			this.CurrentAimType = characterUnifiedStateComponent.CurrentAimType;
		}
		if (base.CanResetComponentProperty("PositionSubStateInternal"))
		{
			this.PositionSubStateInternal = characterUnifiedStateComponent.PositionSubStateInternal;
		}
		if (base.CanResetComponentProperty("InFightCueHandle"))
		{
			this.InFightCueHandle = characterUnifiedStateComponent.InFightCueHandle;
		}
		if (base.CanResetComponentProperty("AggroSet") && characterUnifiedStateComponent.AggroSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.AggroSet), "AggroSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsWalkModeInternal"))
		{
			this.IsWalkModeInternal = characterUnifiedStateComponent.IsWalkModeInternal;
		}
		return true;
	}

	// Token: 0x0400C03C RID: 49212
	[StaticVariableRuleIgnore]
	public static readonly int[] outGameRoleTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被取对象"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被子弹命中"]
	};

	// Token: 0x0400C03D RID: 49213
	[StaticVariableRuleIgnore]
	private static HashSet<global::ECharMoveState> notInheritMoveStateSet = new HashSet<global::ECharMoveState>
	{
		global::ECharMoveState.Flying,
		global::ECharMoveState.Roll,
		global::ECharMoveState.WalkOnAir,
		global::ECharMoveState.Glide
	};

	// Token: 0x0400C03E RID: 49214
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComponent;

	// Token: 0x0400C03F RID: 49215
	[Nullable(2)]
	private CharacterGameplayCueComponent CueComponent;

	// Token: 0x0400C040 RID: 49216
	[Nullable(2)]
	private RoleGaitComponent RoleGaitComponent;

	// Token: 0x0400C041 RID: 49217
	[Nullable(2)]
	private CharacterFloatingComponent FloatingComponent;

	// Token: 0x0400C042 RID: 49218
	[Nullable(2)]
	private CharacterMoveComponent MoveComponent;

	// Token: 0x0400C043 RID: 49219
	private bool LockWalkRunState;

	// Token: 0x0400C047 RID: 49223
	protected EAimViewState CurrentAimType = EAimViewState.EAimViewState_MAX;

	// Token: 0x0400C048 RID: 49224
	protected global::ECharPositionSubState PositionSubStateInternal;

	// Token: 0x0400C049 RID: 49225
	protected int InFightCueHandle;

	// Token: 0x0400C04A RID: 49226
	private readonly HashSet<int> AggroSet = new HashSet<int>();

	// Token: 0x0400C04B RID: 49227
	[StaticVariableRuleIgnore]
	private static readonly Stat RefreshFightStateStat = Stat.Create("OnAggroChanged.RefreshFightState", "", "");

	// Token: 0x0400C04C RID: 49228
	[StaticVariableRuleIgnore]
	private static readonly Stat FightBuffStat = Stat.Create("OnAggroChanged.FightBuff", "", "");

	// Token: 0x0400C04D RID: 49229
	protected static int[] PositionTagList;

	// Token: 0x0400C04E RID: 49230
	protected static int[] MoveTagList;

	// Token: 0x0400C04F RID: 49231
	protected static int[] SubStateTagList;

	// Token: 0x0400C050 RID: 49232
	protected static int[] DirectionTagList;

	// Token: 0x0400C051 RID: 49233
	protected static int[] PositionSubStateTagList;

	// Token: 0x0400C052 RID: 49234
	protected static Dictionary<global::ECharMoveState, int> MoveEnumToTag;

	// Token: 0x0400C053 RID: 49235
	protected static Dictionary<int, global::ECharMoveState> MoveEnumToTagInverse;

	// Token: 0x0400C054 RID: 49236
	protected static Dictionary<global::ECharPositionState, int> PositionEnumToTag;

	// Token: 0x0400C055 RID: 49237
	protected static Dictionary<int, global::ECharPositionState> PositionEnumToTagInverse;

	// Token: 0x0400C056 RID: 49238
	protected static Dictionary<ECharDirectionState, int> DirectionEnumToTag;

	// Token: 0x0400C057 RID: 49239
	protected static Dictionary<int, ECharDirectionState> DirectionEnumToTagInverse;

	// Token: 0x0400C058 RID: 49240
	protected static Dictionary<global::ECharPositionSubState, int> PositionSubStateEnumToTag;

	// Token: 0x0400C059 RID: 49241
	private bool IsWalkModeInternal;

	// Token: 0x0400C05A RID: 49242
	private static bool NeedLoad = false;
}
