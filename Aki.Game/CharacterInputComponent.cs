using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.ControlMonster;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02003073 RID: 12403
[NullableContext(1)]
[Nullable(0)]
public class CharacterInputComponent : EntityComponent, IInputHandler, IStaticVariableResetter
{
	// Token: 0x0601A6BD RID: 108221 RVA: 0x0070BB54 File Offset: 0x00709D54
	static CharacterInputComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterInputComponent.CreateStaticDefaultValue), new Action(CharacterInputComponent.ResetStaticDefaultValue));
	}

	// Token: 0x17002465 RID: 9317
	// (get) Token: 0x0601A6BE RID: 108222 RVA: 0x0070BC2B File Offset: 0x00709E2B
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public new static Type[] Dependencies
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent)
			};
		}
	}

	// Token: 0x17002466 RID: 9318
	// (get) Token: 0x0601A6BF RID: 108223 RVA: 0x0070BC40 File Offset: 0x00709E40
	// (set) Token: 0x0601A6C0 RID: 108224 RVA: 0x0070BC48 File Offset: 0x00709E48
	public bool IsLocalInput
	{
		get
		{
			return this.IsLocalInputInternal;
		}
		set
		{
			this.IsLocalInputInternal = value;
		}
	}

	// Token: 0x0601A6C1 RID: 108225 RVA: 0x0070BC54 File Offset: 0x00709E54
	private void OnCharUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		bool flag = false;
		if (this.SkillComponent != null)
		{
			for (int i = 0; i < CharacterInputComponent.interruptAutoMoving.Length; i++)
			{
				if (this.SkillComponent.HasSkillGenre(skillId, CharacterInputComponent.interruptAutoMoving[i]))
				{
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			this.InterruptAutoMoving("技能类型属于0/1/2/3/4/5/7/8/9", true);
		}
	}

	// Token: 0x0601A6C2 RID: 108226 RVA: 0x0070BCA6 File Offset: 0x00709EA6
	private void OnCharPossessed(Entity entity, [Nullable(2)] AController newController)
	{
		this.SetCharacterController(newController as BP_CharacterController_C);
		InputController.Instance.AddInputHandler(this);
	}

	// Token: 0x0601A6C3 RID: 108227 RVA: 0x0070BCBF File Offset: 0x00709EBF
	private void OnCharUnpossessed(Entity entity, [Nullable(2)] AController oldController)
	{
		this.InputEvents.Clear();
		this.InputCaches.Clear();
		this.AxisValues.Clear();
		this.SetCharacterController(null);
		InputController.Instance.RemoveInputHandler(this);
	}

	// Token: 0x0601A6C4 RID: 108228 RVA: 0x0070BCF4 File Offset: 0x00709EF4
	private void OnPositionStateChanged(ECharPositionState oldPositionState, ECharPositionState newPositionState)
	{
		this.UpdateCharacterInputDirectAndFacing(0f);
	}

	// Token: 0x0601A6C5 RID: 108229 RVA: 0x0070BD01 File Offset: 0x00709F01
	private void CharOnRoleDrownInjure(bool isTargetKilled)
	{
		this.ClearInputCaches("CharOnRoleDrownInjure");
	}

	// Token: 0x0601A6C6 RID: 108230 RVA: 0x0070BD10 File Offset: 0x00709F10
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		if (this.InputLayer != null)
		{
			if (morphType != EMorphType.默认形态)
			{
				CharacterMorphComponent component = entity.GetComponent<CharacterMorphComponent>();
				BP_InputBase_C bpInputComp = (component != null) ? component.GetMorphBpInputComp(morphType) : null;
				this.InputLayer.SetBpInputComp(bpInputComp);
				ExtraInputLayer extraInputLayer = this.ExtraInputLayer;
				if (extraInputLayer == null)
				{
					return;
				}
				extraInputLayer.SetEnable(false);
				return;
			}
			else
			{
				this.InputLayer.ResetBpInputComp();
				ExtraInputLayer extraInputLayer2 = this.ExtraInputLayer;
				if (extraInputLayer2 == null)
				{
					return;
				}
				extraInputLayer2.SetEnable(true);
			}
		}
	}

	// Token: 0x0601A6C7 RID: 108231 RVA: 0x0070BD76 File Offset: 0x00709F76
	public int GetPriority()
	{
		return 0;
	}

	// Token: 0x0601A6C8 RID: 108232 RVA: 0x0070BD79 File Offset: 0x00709F79
	public InputFilter GetInputFilter()
	{
		return this.InputGroup;
	}

	// Token: 0x0601A6C9 RID: 108233 RVA: 0x0070BD81 File Offset: 0x00709F81
	public void HandlePressEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!BattleInputModel.Instance.GetInputEnable(action))
		{
			return;
		}
		this.InputEvents.Add(new InputEvent(action, EInputState.Press, time, 0f));
	}

	// Token: 0x0601A6CA RID: 108234 RVA: 0x0070BDA9 File Offset: 0x00709FA9
	public void ForcePushPressEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		this.InputEvents.Add(new InputEvent(action, EInputState.Press, time, 0f));
	}

	// Token: 0x0601A6CB RID: 108235 RVA: 0x0070BDC4 File Offset: 0x00709FC4
	public void HandleReleaseEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!BattleInputModel.Instance.GetInputEnable(action))
		{
			return;
		}
		this.InputEvents.Add(new InputEvent(action, EInputState.Release, time, 0f));
		if (CharacterInputComponent.HoldPressMap.ContainsKey(action))
		{
			CharacterInputComponent.HoldPressMap[action] = false;
		}
	}

	// Token: 0x0601A6CC RID: 108236 RVA: 0x0070BE10 File Offset: 0x0070A010
	public void HandleHoldEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!BattleInputModel.Instance.GetInputEnable(action))
		{
			return;
		}
		this.InputEvents.Add(new InputEvent(action, EInputState.Hold, time, 0f));
	}

	// Token: 0x0601A6CD RID: 108237 RVA: 0x0070BE38 File Offset: 0x0070A038
	public void HandleInputAxis(EInputAxis axis, float value)
	{
		float num = value;
		if (Info.Instance.IsInKeyBoard())
		{
			byte value2 = axis.Value;
			if (value2 - 1 <= 1 || value2 == 5)
			{
				num /= Time.Instance.DeltaTimeSeconds;
			}
		}
		this.AxisValues[axis] = num;
	}

	// Token: 0x0601A6CE RID: 108238 RVA: 0x0070BE7E File Offset: 0x0070A07E
	public void ClearInputAxis(bool nextFrame)
	{
		this.ClearInputAxis(nextFrame, false);
	}

	// Token: 0x0601A6CF RID: 108239 RVA: 0x0070BE88 File Offset: 0x0070A088
	public void ClearInputAxis(bool nextFrame, bool onlyMove = false)
	{
		if (Info.Instance.AxisInputOptimize)
		{
			if (!nextFrame)
			{
				if (onlyMove)
				{
					this.AxisValues.Remove(EInputAxis.MoveForward);
					this.AxisValues.Remove(EInputAxis.MoveRight);
				}
				else
				{
					this.AxisValues.Clear();
				}
			}
			this.NextFrameClear = nextFrame;
		}
	}

	// Token: 0x0601A6D0 RID: 108240 RVA: 0x0070BEDD File Offset: 0x0070A0DD
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
		if (Info.Instance.AxisInputOptimize)
		{
			if (!nextFrame)
			{
				if (this.AxisValues.ContainsKey(axis))
				{
					this.AxisValues[axis] = 0f;
					return;
				}
			}
			else
			{
				this.NextFrameClearAxis.Add(axis);
			}
		}
	}

	// Token: 0x0601A6D1 RID: 108241 RVA: 0x0070BF1B File Offset: 0x0070A11B
	private void OnShowMouseCursor(bool value)
	{
		if (this.LastShowMouseCursor != value)
		{
			this.LastShowMouseCursor = value;
			if (value)
			{
				this.AxisValues.Clear();
			}
		}
	}

	// Token: 0x0601A6D2 RID: 108242 RVA: 0x0070BF3C File Offset: 0x0070A13C
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
		if (!Info.Instance.AxisInputOptimize)
		{
			this.AxisValues.Clear();
			return;
		}
		if (this.NextFrameClear)
		{
			this.NextFrameClear = false;
			this.AxisValues.Clear();
		}
		if (this.NextFrameClearAxis.Count > 0)
		{
			foreach (EInputAxis key in this.NextFrameClearAxis)
			{
				if (this.AxisValues.ContainsKey(key))
				{
					this.AxisValues.Remove(key);
				}
			}
			this.NextFrameClearAxis.Clear();
		}
	}

	// Token: 0x0601A6D3 RID: 108243 RVA: 0x0070BFF0 File Offset: 0x0070A1F0
	public void PostProcessInput(float deltaTime, bool gamePaused)
	{
		this.UpdateMoveCache();
		this.UpdateMoveAxisToButton();
		List<InputCommand> list = new List<InputCommand>();
		for (int i = 0; i < this.InputEvents.Count; i++)
		{
			InputEvent inputEvent = this.InputEvents[i];
			SInputCommand command = this.GetCommand(deltaTime, inputEvent);
			if (command != null && command.CommandType != ECommandType.None)
			{
				list.Add(new InputCommand(inputEvent.Action, inputEvent.State, inputEvent.Time, command, i));
			}
		}
		if (this.TestInputEvent.Count > 0)
		{
			int num = this.InputEvents.Count;
			for (int j = 0; j < this.TestInputEvent.Count; j++)
			{
				InputEvent inputEvent2 = this.TestInputEvent[j];
				SInputCommand command2 = this.GetCommand(deltaTime, inputEvent2);
				if (command2 != null)
				{
					list.Add(new InputCommand(inputEvent2.Action, inputEvent2.State, inputEvent2.Time, command2, num));
				}
				num++;
			}
			this.TestInputEvent.Clear();
		}
		InputCommand bestInputCommand = this.GetBestInputCommand(list);
		this.ValidateInputCaches();
		this.CacheInputs(bestInputCommand);
		this.InputEvents.Clear();
		if (bestInputCommand != null && bestInputCommand.State == EInputState.Hold)
		{
			CharacterInputComponent.HoldPressMap[bestInputCommand.Action] = true;
		}
		if (bestInputCommand != null)
		{
			bool sceneCheckOn = SundryModel.Instance.SceneCheckOn;
			this.ExecuteInputCommand(bestInputCommand, "PostProcessInput");
		}
	}

	// Token: 0x0601A6D4 RID: 108244 RVA: 0x0070C164 File Offset: 0x0070A364
	public void TestActionInput(CSharpScript.Game.Input.EInputAction action, EInputState state, float time)
	{
		InputEvent item = new InputEvent(action, state, time, 0f);
		this.TestInputEvent.Add(item);
	}

	// Token: 0x0601A6D5 RID: 108245 RVA: 0x0070C18C File Offset: 0x0070A38C
	[return: Nullable(2)]
	private SInputCommand GetCommand(float deltaTime, IInputBase evt)
	{
		SInputCommand result = null;
		switch (evt.State)
		{
		case EInputState.Press:
			this.DispatchPressEvent(evt.Action, (double)evt.Time, evt.MoveInputYaw);
			result = this.HandlePress(evt.Action, evt.Time, evt.MoveInputYaw);
			break;
		case EInputState.Release:
			this.DispatchReleaseEvent(evt.Action, (double)evt.Time, evt.MoveInputYaw);
			result = this.HandleRelease(evt.Action, (double)evt.Time, evt.MoveInputYaw);
			break;
		case EInputState.Hold:
			if (!this.ShouldTriggerHoldEvent(evt.Action, (double)evt.Time, deltaTime))
			{
				evt.Action = CSharpScript.Game.Input.EInputAction.None;
				return null;
			}
			result = this.HandleHold(evt.Action, (double)evt.Time, evt.MoveInputYaw);
			break;
		}
		return result;
	}

	// Token: 0x0601A6D6 RID: 108246 RVA: 0x0070C264 File Offset: 0x0070A464
	[NullableContext(2)]
	private void CacheInputs(InputCommand bestInputCommand)
	{
		float worldTime = this.GetWorldTime();
		int num = (bestInputCommand != null) ? bestInputCommand.Index : -1;
		for (int i = 0; i < this.InputEvents.Count; i++)
		{
			InputEvent inputEvent = this.InputEvents[i];
			if (i != num && !(inputEvent.Action == CSharpScript.Game.Input.EInputAction.None) && this.GetCacheTime(inputEvent.Action, inputEvent.State) != 0f)
			{
				this.InputCaches.Add(new InputCache(inputEvent.Action, inputEvent.State, inputEvent.Time, worldTime, 0f, -1, inputEvent.MoveInputYaw));
			}
		}
	}

	// Token: 0x0601A6D7 RID: 108247 RVA: 0x0070C308 File Offset: 0x0070A508
	public void SetMoveVectorCache(global::Vector input, global::Vector worldInput)
	{
		this.MoveDirectionCache.DeepCopy(input);
		this.MoveDirectionCache.Normalize(9.99999993922529E-09);
		this.WorldMoveDirectionCache.DeepCopy(worldInput);
		this.WorldMoveDirectionCache.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601A6D8 RID: 108248 RVA: 0x0070C357 File Offset: 0x0070A557
	public void ResetMoveVectorCache()
	{
		this.MoveDirectionCache.Reset();
		this.WorldMoveDirectionCache.Reset();
	}

	// Token: 0x0601A6D9 RID: 108249 RVA: 0x0070C36F File Offset: 0x0070A56F
	[NullableContext(2)]
	public void SetCharacterController(BP_CharacterController_C controller)
	{
		this.CharacterControllerInternal = controller;
	}

	// Token: 0x17002467 RID: 9319
	// (get) Token: 0x0601A6DA RID: 108250 RVA: 0x0070C378 File Offset: 0x0070A578
	public BP_CharacterController_C CharacterController
	{
		get
		{
			return this.CharacterControllerInternal;
		}
	}

	// Token: 0x17002468 RID: 9320
	// (get) Token: 0x0601A6DB RID: 108251 RVA: 0x0070C380 File Offset: 0x0070A580
	[Nullable(2)]
	public TsBaseCharacter Character
	{
		[NullableContext(2)]
		get
		{
			return this.CharacterInternal;
		}
	}

	// Token: 0x0601A6DC RID: 108252 RVA: 0x0070C388 File Offset: 0x0070A588
	public void SetCharacter(TsBaseCharacter character)
	{
		this.CharacterInternal = character;
	}

	// Token: 0x0601A6DD RID: 108253 RVA: 0x0070C391 File Offset: 0x0070A591
	public global::Vector GetMoveVectorCache()
	{
		return this.MoveVectorCache;
	}

	// Token: 0x0601A6DE RID: 108254 RVA: 0x0070C39C File Offset: 0x0070A59C
	public void SetMoveInputOuterRingEnabled(bool enabled)
	{
		if (enabled)
		{
			this.MoveInputOuterRingEnableCount++;
		}
		else
		{
			this.MoveInputOuterRingEnableCount = Math.Max(0, this.MoveInputOuterRingEnableCount - 1);
		}
		RoleGaitComponent component = base.Entity.GetComponent<RoleGaitComponent>();
		if (component == null)
		{
			return;
		}
		component.SetMoveInputGaitSwitchEnabled(this.MoveInputOuterRingEnableCount == 0);
	}

	// Token: 0x0601A6DF RID: 108255 RVA: 0x0070C3EE File Offset: 0x0070A5EE
	public bool IsMoveInputOuterRingEnabled()
	{
		return this.MoveInputOuterRingEnableCount > 0;
	}

	// Token: 0x0601A6E0 RID: 108256 RVA: 0x0070C3F9 File Offset: 0x0070A5F9
	public global::Vector GetMoveDirectionCache()
	{
		return this.MoveDirectionCache;
	}

	// Token: 0x0601A6E1 RID: 108257 RVA: 0x0070C401 File Offset: 0x0070A601
	public global::Vector GetWorldMoveDirectionCache()
	{
		if (!this.ActorComp.IsAutonomousProxy)
		{
			return this.WorldMoveDirectionCache;
		}
		this.ConvertMoveDirectionToWorld(this.MoveDirectionCache, this.WorldMoveDirectionCache);
		return this.WorldMoveDirectionCache;
	}

	// Token: 0x0601A6E2 RID: 108258 RVA: 0x0070C430 File Offset: 0x0070A630
	public bool TryGetManualWorldMoveDirection(global::Vector @out)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsAutonomousProxy && !this.IsLocalInputInternal && !this.AutomaticFlightMode && !this.CameraDrivenAutoFlightMode)
		{
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp == null || !moveComp.MoveController.IsMoving())
			{
				if (this.MoveVectorCache.IsNearlyZero(9.999999747378752E-05))
				{
					InputContinuously autoMovingConfigInternal = this.AutoMovingConfigInternal;
					if (autoMovingConfigInternal == null || !autoMovingConfigInternal.GetAutoMovingState())
					{
						BaseTagComponent tagComp = this.TagComp;
						if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为改变.保持输入"]))
						{
							goto IL_99;
						}
					}
					return false;
				}
				IL_99:
				this.CurrentMoveDirection.DeepCopy(this.MoveVectorCache);
				if (this.CurrentMoveDirection.Normalize(9.99999993922529E-09))
				{
					CharacterMoveComponent moveComp2 = this.MoveComp;
					if (moveComp2 == null || moveComp2.CanResponseInput())
					{
						this.ConvertMoveDirectionToWorld(this.CurrentMoveDirection, @out);
						return true;
					}
				}
				@out.Reset();
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A6E3 RID: 108259 RVA: 0x0070C52C File Offset: 0x0070A72C
	private void ConvertMoveDirectionToWorld(global::Vector direction, global::Vector @out)
	{
		if (this.IsActorRelativeMove())
		{
			this.PhotoMoveInput.DeepCopy(direction);
			if (this.InvertMoveForward)
			{
				this.PhotoMoveInput.X = -this.PhotoMoveInput.X;
			}
			if (this.InvertMoveRight)
			{
				this.PhotoMoveInput.Y = -this.PhotoMoveInput.Y;
			}
			this.TempRotator.DeepCopy(this.ActorComp.ActorRotationProxy);
			GravityUtils.Instance.GetQuatFromRotatorAndGravityForActor(this.ActorComp, this.TempRotator, this.CameraInputQuat);
			this.CameraInputQuat.RotateVector(this.PhotoMoveInput, @out);
			return;
		}
		CameraController.Instance.GetCameraRotation(this.TempRotator, "MainCamera");
		GravityUtils.Instance.GetQuatFromRotatorAndGravityForActor(this.ActorComp, this.TempRotator, this.CameraInputQuat);
		CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
		if (unifiedComp != null && unifiedComp.DirectionState == ECharDirectionState.LockDirection)
		{
			CameraModel instance = CameraModel.Instance;
			FightCameraLogicComponent fightCameraLogicComponent;
			if (instance == null)
			{
				fightCameraLogicComponent = null;
			}
			else
			{
				FightCamera fightCamera = instance.MainModel.FightCamera;
				fightCameraLogicComponent = ((fightCamera != null) ? fightCamera.LogicComponent : null);
			}
			FightCameraLogicComponent fightCameraLogicComponent2 = fightCameraLogicComponent;
			EntityHandle entityHandle = (fightCameraLogicComponent2 != null) ? fightCameraLogicComponent2.TargetEntity : null;
			if (entityHandle != null)
			{
				this.GetNewQuatInLockMode(entityHandle, fightCameraLogicComponent2.TargetSocketName, this.CameraInputQuat);
			}
		}
		this.CameraInputQuat.RotateVector(direction, @out);
	}

	// Token: 0x0601A6E4 RID: 108260 RVA: 0x0070C670 File Offset: 0x0070A870
	public void GetMoveVector(global::Vector outVector)
	{
		if (this.AutomaticFlightMode)
		{
			outVector.Reset();
			return;
		}
		outVector.X = (double)this.QueryInputAxis(EInputAxis.MoveForward).GetValueOrDefault();
		outVector.Y = (double)this.QueryInputAxis(EInputAxis.MoveRight).GetValueOrDefault();
		outVector.Z = 0.0;
	}

	// Token: 0x0601A6E5 RID: 108261 RVA: 0x0070C6CF File Offset: 0x0070A8CF
	public void GetMoveDirection(global::Vector outVector)
	{
		this.GetMoveVector(outVector);
		outVector.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601A6E6 RID: 108262 RVA: 0x0070C6E8 File Offset: 0x0070A8E8
	[NullableContext(0)]
	public ValueTuple<float, float> GetCameraInput()
	{
		float num = this.QueryInputAxis(EInputAxis.Turn).GetValueOrDefault();
		float num2 = this.QueryInputAxis(EInputAxis.LookUp).GetValueOrDefault();
		if (num == 0f && num2 == 0f && Info.Instance.IsInGamepad())
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null && gamepadData.ControlCameraByMoveAxis)
			{
				num = gamepadData.GetInputAxis(EInputAxis.MoveRight);
				num2 = -gamepadData.GetInputAxis(EInputAxis.MoveForward);
			}
		}
		return new ValueTuple<float, float>(num, num2);
	}

	// Token: 0x0601A6E7 RID: 108263 RVA: 0x0070C770 File Offset: 0x0070A970
	public bool HasCameraInput(float tolerance = 0.0001f)
	{
		return !MathUtils.Instance.IsNearlyZero((double)this.QueryInputAxis(EInputAxis.Turn).GetValueOrDefault(), new double?((double)tolerance)) || !MathUtils.Instance.IsNearlyZero((double)this.QueryInputAxis(EInputAxis.LookUp).GetValueOrDefault(), new double?((double)tolerance));
	}

	// Token: 0x0601A6E8 RID: 108264 RVA: 0x0070C7D0 File Offset: 0x0070A9D0
	public float GetZoomInput()
	{
		return this.QueryInputAxis(EInputAxis.Zoom).GetValueOrDefault();
	}

	// Token: 0x0601A6E9 RID: 108265 RVA: 0x0070C7F0 File Offset: 0x0070A9F0
	public float? QueryInputAxis(EInputAxis axis)
	{
		if (this.AxisValues.ContainsKey(axis))
		{
			return new float?(this.AxisValues[axis]);
		}
		return null;
	}

	// Token: 0x0601A6EA RID: 108266 RVA: 0x0070C826 File Offset: 0x0070AA26
	public void ClearMoveVectorCache()
	{
		this.MoveVectorCache.Reset();
		this.MoveDirectionCache.Reset();
		this.WorldMoveDirectionCache.Reset();
		this.LastMovementInputTime = -1.0;
	}

	// Token: 0x0601A6EB RID: 108267 RVA: 0x0070C858 File Offset: 0x0070AA58
	public void AnimBreakPoint()
	{
		if (this.QueryInputCaches())
		{
			this.ClearInputCaches("AnimBreakPoint");
		}
	}

	// Token: 0x0601A6EC RID: 108268 RVA: 0x0070C870 File Offset: 0x0070AA70
	public void ClearInputCache(int action, EInputState state)
	{
		if (action == 0)
		{
			this.ClearInputCaches("ClearInputCache");
			return;
		}
		for (int i = this.InputCaches.Count - 1; i >= 0; i--)
		{
			InputCache inputCache = this.InputCaches[i];
			if (inputCache.Action == (CSharpScript.Game.Input.EInputAction)((byte)action) && (inputCache.State == EInputState.None || inputCache.State == state))
			{
				this.InputCaches.RemoveAt(i);
			}
		}
	}

	// Token: 0x0601A6ED RID: 108269 RVA: 0x0070C8E4 File Offset: 0x0070AAE4
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.InputGroup = new InputFilter(InputFilterManager.CharacterActions, null, InputFilterManager.CharacterAxes, null);
		this.MoveVectorCache.Reset();
		this.MoveInputOuterRingEnableCount = 0;
		this.MoveDirectionCache.Reset();
		this.WorldMoveDirectionCache.Reset();
		this.MoveDirectionDistanceMin = (float)ConfigCommonParamById.GetIntConfig("MovementDirectionDistanceMin").Value;
		this.MoveDirectionDistanceMax = (float)ConfigCommonParamById.GetIntConfig("MovementDirectionDistanceMax").Value;
		this.MovementDirectionAngleThreshold = (float)ConfigCommonParamById.GetIntConfig("MovementDirectionAngleThreshold").Value;
		this.TryGetTagDaPathMap();
		return true;
	}

	// Token: 0x0601A6EE RID: 108270 RVA: 0x0070C982 File Offset: 0x0070AB82
	protected override bool OnClear()
	{
		this.MoveInputOuterRingEnableCount = 0;
		return true;
	}

	// Token: 0x0601A6EF RID: 108271 RVA: 0x0070C98C File Offset: 0x0070AB8C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		TsBaseCharacter actor = this.ActorComp.Actor;
		this.SetCharacter(actor);
		if (this.CharacterControllerInternal != null)
		{
			InputController.Instance.AddInputHandler(this);
		}
		this.AbilityComp = base.Entity.GetComponent<CharacterAbilityComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.SkillComponent = base.Entity.GetComponent<CharacterSkillComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.UnifiedComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.AddCharacterInputLayer();
		this.AddExtraInputLayer();
		this.RefreshMoveAxisToButtonActiveCondition();
		EventSystem.Instance.Add(EEventName.CharAnimBreakPoint, new Action<int>(this.HandleAnimBreakPoint));
		EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharPossessed, new Action<Entity, AController>(this.OnCharPossessed));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharUnpossessed, new Action<Entity, AController>(this.OnCharUnpossessed));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.CameraModeChanged));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewShow));
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		EventSystem.Instance.Add(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		this.AddCameraFollowInputListener();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRoleDrownInjure, new Action<bool>(this.CharOnRoleDrownInjure));
		if (Info.Instance.AxisInputOptimize)
		{
			EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
		}
		EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		this.AddBlockEvents();
		InputModel instance = InputModel.Instance;
		if (instance != null)
		{
			instance.InitInputCommandTransformMap();
		}
		return true;
	}

	// Token: 0x0601A6F0 RID: 108272 RVA: 0x0070CC00 File Offset: 0x0070AE00
	protected override bool OnEnd()
	{
		this.RemoveCharacterInputLayer();
		this.RemoveExtraInputLayer();
		InputController.Instance.RemoveInputHandler(this);
		EventSystem.Instance.Remove(EEventName.CharAnimBreakPoint, new Action<int>(this.HandleAnimBreakPoint));
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharPossessed, new Action<Entity, AController>(this.OnCharPossessed));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharUnpossessed, new Action<Entity, AController>(this.OnCharUnpossessed));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.CameraModeChanged));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewShow));
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		EventSystem.Instance.Remove(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		this.RemoveCameraFollowInputListener();
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRoleDrownInjure, new Action<bool>(this.CharOnRoleDrownInjure));
		if (Info.Instance.AxisInputOptimize)
		{
			EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
		}
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		this.LastMovementInputTime = -1.0;
		this.InputEvents.Clear();
		this.InputCaches.Clear();
		this.AxisValues.Clear();
		this.RemoveBlockActionEvents();
		this.RemoveMoveAxisToButton();
		this.InputAngleRanges = null;
		this.ProcessedMoveInput.Reset();
		return true;
	}

	// Token: 0x0601A6F1 RID: 108273 RVA: 0x0070CE14 File Offset: 0x0070B014
	protected override void OnTick(float deltaTime)
	{
		this.AccumulateCacheInputs(deltaTime);
		this.IsLocalInputInternal = false;
		if (this.AutomaticFlightMode)
		{
			this.UpdateCharacterInputDirectAndFacingAutomaticFlightMode(deltaTime);
			this.StandInputDelayCountDown = 0f;
			this.CacheStandInputDirect.Reset();
			return;
		}
		if (this.IsOverShoulderMode)
		{
			this.UpdateCharacterInputDirectAndFacingOverShoulderMode(deltaTime);
			return;
		}
		this.UpdateCharacterInputDirectAndFacing(deltaTime);
		if (this.CameraDrivenAutoFlightMode)
		{
			this.UpdateCharacterInputDirectInCameraDrivenAutoFlightMode(deltaTime);
		}
	}

	// Token: 0x0601A6F2 RID: 108274 RVA: 0x0070CE7C File Offset: 0x0070B07C
	private void AccumulateCacheInputs(float deltaTime)
	{
		if (this.InputCaches.Count == 0)
		{
			return;
		}
		double num = (double)deltaTime * TimeUtil.Instance.Millisecond;
		CharacterModel instance = CharacterModel.Instance;
		float num2 = (instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f;
		double num3 = num * (double)num2;
		for (int i = 0; i < this.InputCaches.Count; i++)
		{
			this.InputCaches[i].AccumulateTime += num3;
		}
	}

	// Token: 0x0601A6F3 RID: 108275 RVA: 0x0070CEF0 File Offset: 0x0070B0F0
	private void AddBlockEvents()
	{
		this.TagEventJump = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止跳跃"], CSharpScript.Game.Input.EInputAction.跳跃);
		this.TagEventClimb = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攀爬"], CSharpScript.Game.Input.EInputAction.攀爬);
		this.TagEventAttack = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"], CSharpScript.Game.Input.EInputAction.攻击);
		this.TagEventDodge = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止闪避"], CSharpScript.Game.Input.EInputAction.闪避);
		this.TagEventSkill = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"], CSharpScript.Game.Input.EInputAction.技能1);
		this.TagEventVision1 = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象1"], CSharpScript.Game.Input.EInputAction.幻象1);
		this.TagEventUltimateSkill = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"], CSharpScript.Game.Input.EInputAction.大招);
		this.TagEventVision2 = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象2"], CSharpScript.Game.Input.EInputAction.幻象2);
		this.TagEventChangeRoll1 = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色1"], CSharpScript.Game.Input.EInputAction.切换角色1);
		this.TagEventChangeRoll2 = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色2"], CSharpScript.Game.Input.EInputAction.切换角色2);
		this.TagEventChangeRoll3 = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色3"], CSharpScript.Game.Input.EInputAction.切换角色3);
		this.TagEventLock = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止锁定目标"], CSharpScript.Game.Input.EInputAction.锁定目标);
		this.TagEventAim = this.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止瞄准开镜"], CSharpScript.Game.Input.EInputAction.瞄准);
		this.TagEventMove = this.AddBlockAxisEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"], new EInputAxis[]
		{
			EInputAxis.MoveForward,
			EInputAxis.MoveRight
		});
	}

	// Token: 0x0601A6F4 RID: 108276 RVA: 0x0070D0D8 File Offset: 0x0070B2D8
	private ITagTask AddBlockActionEvent(int tagNumber, CSharpScript.Game.Input.EInputAction inputAction)
	{
		return this.TagComp.ListenForTagAddOrRemove(new int?(tagNumber), delegate(int tagId, bool tagExists)
		{
			if (tagExists)
			{
				this.InputGroup.BlockActions.Add(inputAction);
				return;
			}
			this.InputGroup.BlockActions.Remove(inputAction);
		}, null);
	}

	// Token: 0x0601A6F5 RID: 108277 RVA: 0x0070D118 File Offset: 0x0070B318
	private ITagTask AddBlockAxisEvent(int tagNumber, EInputAxis[] axes)
	{
		return this.TagComp.ListenForTagAddOrRemove(new int?(tagNumber), delegate(int tagId, bool tagExists)
		{
			foreach (EInputAxis item in axes)
			{
				if (tagExists)
				{
					this.InputGroup.BlockAxes.Add(item);
				}
				else
				{
					this.InputGroup.BlockAxes.Remove(item);
				}
			}
		}, null);
	}

	// Token: 0x0601A6F6 RID: 108278 RVA: 0x0070D158 File Offset: 0x0070B358
	private void RemoveBlockActionEvents()
	{
		this.TagEventJump.EndTask();
		this.TagEventClimb.EndTask();
		this.TagEventAttack.EndTask();
		this.TagEventDodge.EndTask();
		this.TagEventSkill.EndTask();
		this.TagEventVision1.EndTask();
		this.TagEventUltimateSkill.EndTask();
		this.TagEventVision2.EndTask();
		this.TagEventChangeRoll1.EndTask();
		this.TagEventChangeRoll2.EndTask();
		this.TagEventChangeRoll3.EndTask();
		this.TagEventLock.EndTask();
		this.TagEventAim.EndTask();
		this.TagEventMove.EndTask();
	}

	// Token: 0x0601A6F7 RID: 108279 RVA: 0x0070D200 File Offset: 0x0070B400
	private bool LockInputRotator()
	{
		CharacterMoveComponent moveComp = this.MoveComp;
		byte? b;
		if (moveComp == null)
		{
			b = null;
		}
		else
		{
			UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
			b = ((characterMovement != null) ? new byte?(characterMovement.CustomMovementMode) : null);
		}
		byte? b2 = b;
		if (((b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null).GetValueOrDefault() != 6)
		{
			return false;
		}
		CharacterCatapultComponent component = base.Entity.GetComponent<CharacterCatapultComponent>();
		return component != null && component.LockRotator;
	}

	// Token: 0x0601A6F8 RID: 108280 RVA: 0x0070D284 File Offset: 0x0070B484
	[NullableContext(2)]
	public void SetInputAngleRanges(InputAngleRange[] ranges)
	{
		this.InputAngleRanges = ((ranges != null && ranges.Length != 0) ? ranges : null);
	}

	// Token: 0x0601A6F9 RID: 108281 RVA: 0x0070D297 File Offset: 0x0070B497
	public void ApplyInputAngleRanges(IVector direction, global::Vector @out)
	{
		@out.DeepCopy(direction);
		if (this.ActorComp == null || this.InputAngleRanges == null || @out.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		this.ClampInputByAngleRanges(direction, @out);
	}

	// Token: 0x0601A6FA RID: 108282 RVA: 0x0070D2CA File Offset: 0x0070B4CA
	private static bool IsAngleInRange(float angle, float start, float end)
	{
		if (start <= end)
		{
			return angle >= start && angle <= end;
		}
		return angle >= start || angle <= end;
	}

	// Token: 0x0601A6FB RID: 108283 RVA: 0x0070D2EC File Offset: 0x0070B4EC
	private static float CircularDist(float a, float b)
	{
		float num = Math.Abs(a - b);
		return Math.Min(num, 360f - num);
	}

	// Token: 0x0601A6FC RID: 108284 RVA: 0x0070D310 File Offset: 0x0070B510
	private void ClampInputByAngleRanges(IVector direction, global::Vector @out)
	{
		global::Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
		global::Vector actorUpProxy = this.ActorComp.ActorUpProxy;
		float num = ((float)MathUtils.Instance.SignedAngleOnPlaneDeg(actorForwardProxy, direction, actorUpProxy) % 360f + 360f) % 360f;
		InputAngleRange[] inputAngleRanges = this.InputAngleRanges;
		int i = 0;
		while (i < inputAngleRanges.Length)
		{
			InputAngleRange inputAngleRange = inputAngleRanges[i];
			if (CharacterInputComponent.IsAngleInRange(num, inputAngleRange.PassRangeStart, inputAngleRange.PassRangeEnd))
			{
				if (CharacterInputComponent.IsAngleInRange(num, inputAngleRange.ClampRangeStart, inputAngleRange.ClampRangeEnd))
				{
					return;
				}
				float num2 = CharacterInputComponent.CircularDist(num, inputAngleRange.ClampRangeStart);
				float num3 = CharacterInputComponent.CircularDist(num, inputAngleRange.ClampRangeEnd);
				float num4 = (num2 <= num3) ? inputAngleRange.ClampRangeStart : inputAngleRange.ClampRangeEnd;
				float num5 = (num4 <= 180f) ? num4 : (num4 - 360f);
				actorForwardProxy.RotateAngleAxis((double)num5, actorUpProxy, @out);
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x0601A6FD RID: 108285 RVA: 0x0070D405 File Offset: 0x0070B605
	private void CommitMoveInput(global::Vector direction, bool clearGravityDirect)
	{
		if (this.IsLocalInputInternal)
		{
			this.ProcessedMoveInput.DeepCopy(direction);
		}
		else
		{
			this.ApplyInputAngleRanges(direction, this.ProcessedMoveInput);
		}
		this.ActorComp.SetInputDirect(this.ProcessedMoveInput, clearGravityDirect);
	}

	// Token: 0x0601A6FE RID: 108286 RVA: 0x0070D444 File Offset: 0x0070B644
	private void UpdateCharacterInputDirectAndFacing(float delta)
	{
		global::Vector vector = global::Vector.ZeroVectorProxy;
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null || !tagComp.Valid || !this.StateComp.Valid)
		{
			vector = this.GetWorldMoveDirectionCache();
			this.CommitMoveInput(vector, true);
			this.SetInputFacingFromInputDirect(true);
			return;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]))
		{
			vector = this.GetWorldMoveDirectionCache();
			if (vector.IsNearlyZero(9.999999747378752E-05) && (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为改变.保持输入"]) || this.AutoMovingConfig.GetAutoMovingState()))
			{
				vector = this.ActorComp.InputDirectProxy;
				if (vector.IsNearlyZero(9.999999747378752E-05))
				{
					vector = this.ActorComp.ActorForwardProxy;
				}
			}
			this.CommitMoveInput(vector, true);
			if (this.LockInputRotator())
			{
				this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
				return;
			}
			this.SetInputFacingFromInputDirect(true);
			return;
		}
		else
		{
			CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
			if (unifiedComp != null && unifiedComp.PositionState == ECharPositionState.Climb)
			{
				this.IsLocalInputInternal = true;
				vector = this.GetMoveDirectionCache();
				this.UpdateAutoMovingCheck(vector, delta);
				if (this.AutoMovingConfig.GetAutoMovingState())
				{
					vector = global::Vector.ForwardVectorProxy;
				}
			}
			else
			{
				CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
				if (unifiedComp2 != null && unifiedComp2.MoveState == ECharMoveState.Soar)
				{
					this.IsLocalInputInternal = true;
					this.TempVector.DeepCopy(this.GetMoveVectorCache());
					if (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FlyControlMode, 0, true) == 0)
					{
						this.TempVector.X = -this.TempVector.X;
					}
					double num = vector.SizeSquared();
					if (num > 1.0)
					{
						this.TempVector.DivisionEqual(Math.Sqrt(num));
					}
					vector = this.TempVector;
					this.InterruptAutoMoving("翱翔状态", true);
				}
				else
				{
					vector = this.GetWorldMoveDirectionCache();
					this.UpdateAutoMovingCheck(vector, delta);
					bool autoMovingState = this.AutoMovingConfig.GetAutoMovingState();
					if (vector.IsNearlyZero(9.999999747378752E-05) && (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为改变.保持输入"]) || autoMovingState))
					{
						vector = this.ActorComp.InputDirectProxy;
						if (vector.IsNearlyZero(9.999999747378752E-05))
						{
							vector = this.ActorComp.ActorForwardProxy;
						}
						if (autoMovingState)
						{
							this.CalculateMoveDirection(this.TempVector2);
							if (!this.TempVector2.IsNearlyZero(9.999999747378752E-05))
							{
								this.TempVector2.Normalize(9.99999993922529E-09);
								vector.DeepCopy(this.TempVector2);
							}
						}
					}
					if (!vector.IsNearlyZero(9.999999747378752E-05))
					{
						if (!FormationDataController.Instance.GlobalIsInFight)
						{
							if (autoMovingState)
							{
								goto IL_2DE;
							}
							BattleUiFormationData formationData = BattleUiModel.Instance.FormationData;
							if (formationData != null && formationData.AutoSprintSettingEnable)
							{
								goto IL_2DE;
							}
						}
						if (!this.CheckAutoSprintTag())
						{
							goto IL_2E8;
						}
						IL_2DE:
						this.UpdateAutoSprint(autoMovingState, delta);
						goto IL_2F3;
					}
					IL_2E8:
					this.AutoSprintTime = 0f;
				}
			}
			IL_2F3:
			this.CacheStandInputDirect.Reset();
			this.CommitMoveInput(vector, !this.IsLocalInputInternal);
			if (this.ActorComp.UseControllerRotation)
			{
				this.ActorComp.SetInputFacing(this.ActorComp.Actor.Controller.GetActorForwardVector(), true);
				return;
			}
			ECharPositionState positionState = this.StateComp.PositionState;
			switch (positionState)
			{
			case ECharPositionState.Ground:
				this.SetInputFacingOnGround();
				return;
			case ECharPositionState.Climb:
				break;
			case ECharPositionState.Air:
				if (this.StateComp.MoveState == ECharMoveState.WalkOnAir)
				{
					this.SetInputFacingOnGround();
					return;
				}
				this.SetInputFacingFromInputDirect(true);
				return;
			case ECharPositionState.Water:
				this.SetInputFacingFromInputDirect(true);
				return;
			default:
				if (positionState != ECharPositionState.Floating)
				{
					return;
				}
				this.SetInputFacingOnGround();
				break;
			}
			return;
		}
	}

	// Token: 0x0601A6FF RID: 108287 RVA: 0x0070D7ED File Offset: 0x0070B9ED
	public bool CheckAutoSprintTag()
	{
		BaseTagComponent tagComp = this.TagComp;
		return tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.自动进入疾跑"]);
	}

	// Token: 0x0601A700 RID: 108288 RVA: 0x0070D80F File Offset: 0x0070BA0F
	public bool CheckAutoSprintTagImmediately()
	{
		BaseTagComponent tagComp = this.TagComp;
		return tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.自动进入疾跑.瞬间起步"]);
	}

	// Token: 0x0601A701 RID: 108289 RVA: 0x0070D834 File Offset: 0x0070BA34
	private void UpdateCharacterInputDirectAndFacingAutomaticFlightMode(float deltaTime)
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.Valid)
		{
			CharacterAbilityComponent abilityComp = this.AbilityComp;
			if (abilityComp != null && abilityComp.Valid)
			{
				if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"]))
				{
					return;
				}
				if (this.StateComp.PositionState != ECharPositionState.Air)
				{
					Log.Instance.Error(ELogModule.Input, ELogAuthor.CJH, "错误的位置状态", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (this.AutomaticFlightDataAsset == null)
				{
					Log.Instance.Error(ELogModule.Input, ELogAuthor.CJH, "自动飞行模式配置无效", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (this.AutomaticFlightDataAsset != null)
				{
					float? num = this.QueryInputAxis(EInputAxis.MoveForward);
					float? num2 = num;
					float? num3 = this.AutomaticFlightDataAsset.ForwardAxisResponseValue;
					if (num2.GetValueOrDefault() > num3.GetValueOrDefault() & (num2 != null & num3 != null))
					{
						this.AutomaticFlightDataAsset.CurrentState = EAutomaticFlightState.Max;
						this.AutomaticFlightDataAsset.LastFlySpeed = this.AutomaticFlightDataAsset.TargetFlySpeed;
						this.AutomaticFlightDataAsset.TargetFlySpeed = this.AutomaticFlightDataAsset.MaxFlySpeed;
						this.MoveComp.SetMaxSpeed(this.AutomaticFlightDataAsset.MaxFlySpeed.Value);
						int? num4 = this.AutomaticFlightDataAsset.ForwardSkill;
						int num5 = 0;
						if ((num4.GetValueOrDefault() > num5 & num4 != null) && this.SkillComponent.BeginSkill(this.AutomaticFlightDataAsset.ForwardSkill.Value, new SkillParam
						{
							Target = base.Entity,
							Reason = "EAutomaticFlightState.Max"
						}))
						{
							this.AutomaticFlightDataAsset.CurrentSkill = this.AutomaticFlightDataAsset.ForwardSkill;
						}
					}
					else
					{
						num3 = num;
						num2 = this.AutomaticFlightDataAsset.BackwardAxisResponseValue;
						if (num3.GetValueOrDefault() < num2.GetValueOrDefault() & (num3 != null & num2 != null))
						{
							this.AutomaticFlightDataAsset.CurrentState = EAutomaticFlightState.Min;
							this.AutomaticFlightDataAsset.LastFlySpeed = this.AutomaticFlightDataAsset.TargetFlySpeed;
							this.AutomaticFlightDataAsset.TargetFlySpeed = this.AutomaticFlightDataAsset.MinFlySpeed;
							this.MoveComp.SetMaxSpeed(this.AutomaticFlightDataAsset.MinFlySpeed.Value);
							int? num4 = this.AutomaticFlightDataAsset.BackwardSkill;
							int num5 = 0;
							if ((num4.GetValueOrDefault() > num5 & num4 != null) && this.SkillComponent.BeginSkill(this.AutomaticFlightDataAsset.BackwardSkill.Value, new SkillParam
							{
								Target = base.Entity,
								Reason = "EAutomaticFlightState.Min"
							}))
							{
								this.AutomaticFlightDataAsset.CurrentSkill = this.AutomaticFlightDataAsset.BackwardSkill;
							}
						}
						else
						{
							this.AutomaticFlightDataAsset.CurrentState = EAutomaticFlightState.Normal;
							this.AutomaticFlightDataAsset.LastFlySpeed = this.AutomaticFlightDataAsset.TargetFlySpeed;
							this.AutomaticFlightDataAsset.TargetFlySpeed = this.AutomaticFlightDataAsset.NormalFlySpeed;
							this.MoveComp.SetMaxSpeed(this.AutomaticFlightDataAsset.NormalFlySpeed.Value);
							if (this.AutomaticFlightDataAsset.CurrentSkill != null)
							{
								this.SkillComponent.EndSkill(this.AutomaticFlightDataAsset.CurrentSkill.Value, "EAutomaticFlightState.Normal");
								this.AutomaticFlightDataAsset.CurrentSkill = null;
							}
						}
					}
				}
				if (this.AutomaticFlightDataAsset.LastState != this.AutomaticFlightDataAsset.CurrentState)
				{
					this.AutomaticFlightModeTimeCache = 0f;
				}
				this.AutomaticFlightDataAsset.LastState = this.AutomaticFlightDataAsset.CurrentState;
				this.AutomaticFlightModeTimeCache += deltaTime * 0.001f;
				float x = this.AutomaticFlightDataAsset.SpeedTransitionCurve.GetVectorValue(this.AutomaticFlightModeTimeCache).X;
				this.AutomaticFlightDataAsset.FlySpeed = new float?(MathUtils.Instance.Lerp(this.AutomaticFlightDataAsset.LastFlySpeed.Value, this.AutomaticFlightDataAsset.TargetFlySpeed.Value, x));
				this.ActorComp.ActorForwardProxy.Multiply((double)this.AutomaticFlightDataAsset.FlySpeed.Value, this.TempVector);
				this.MoveComp.SetForceSpeed(this.TempVector);
				return;
			}
		}
	}

	// Token: 0x0601A702 RID: 108290 RVA: 0x0070DC74 File Offset: 0x0070BE74
	private void UpdateCharacterInputDirectInCameraDrivenAutoFlightMode(float deltaTime)
	{
		this.IsInCameraDrivenAutoFlight = false;
		if (this.CameraDrivenAutoFlightDataAsset == null)
		{
			return;
		}
		if (!this.ActorComp.InputDirectProxy.IsNearlyZero(0.0001))
		{
			this.CameraDrivenAutoFlightTime = 0f;
			this.IsStartCameraDrivenAutoFlightTick = false;
			return;
		}
		float valueOrDefault = this.QueryInputAxis(EInputAxis.Turn).GetValueOrDefault();
		if (!MathUtils.Instance.IsNearlyZero((double)valueOrDefault, new double?((double)this.CameraDrivenAutoFlightDataAsset.AutoFlightStartAngleTolerance)) && !this.IsStartCameraDrivenAutoFlightTick)
		{
			this.IsStartCameraDrivenAutoFlightTick = true;
		}
		if (!this.IsStartCameraDrivenAutoFlightTick)
		{
			return;
		}
		float yawInGravity = CameraUtility.GetYawInGravity(this.ActorComp.ActorRotationProxy);
		float yawInGravity2 = CameraUtility.GetYawInGravity(CameraController.Instance.MainModel.FightCamera.LogicComponent.DesiredCamera.ArmRotation);
		float num = MathUtils.Instance.WrapAngle(yawInGravity - yawInGravity2);
		if (MathUtils.Instance.IsNearlyZero((double)num, new double?((double)this.CameraDrivenAutoFlightDataAsset.AutoFlightFinishAngleTolerance)))
		{
			this.CameraDrivenAutoFlightTime = 0f;
			this.IsStartCameraDrivenAutoFlightTick = false;
			return;
		}
		this.CameraDrivenAutoFlightTime += deltaTime;
		if (this.CameraDrivenAutoFlightTime < this.CameraDrivenAutoFlightDataAsset.AutoFlightEnableTime)
		{
			return;
		}
		this.IsInCameraDrivenAutoFlight = true;
		float num2 = MathUtils.Instance.RangeClamp(Math.Abs(num), this.CameraDrivenAutoFlightDataAsset.AutoFlightInputAngleMin, this.CameraDrivenAutoFlightDataAsset.AutoFlightInputAngleMax, this.CameraDrivenAutoFlightDataAsset.AutoFlightInputMin, this.CameraDrivenAutoFlightDataAsset.AutoFlightInputMax);
		this.ActorComp.SetInputDirectByNumber(this.ActorComp.InputDirectProxy.X, (double)(num2 * (float)((num > 0f) ? -1 : 1)), 0.0);
	}

	// Token: 0x0601A703 RID: 108291 RVA: 0x0070DE1C File Offset: 0x0070C01C
	private void SetInputFacingOnGround()
	{
		if (this.StateComp.DirectionState != ECharDirectionState.LockDirection)
		{
			this.SetInputFacingFromInputDirect(false);
			return;
		}
		FightCameraLogicComponent component = CameraController.Instance.MainModel.FightCamera.GetComponent<FightCameraLogicComponent>();
		if (this.StateComp.MoveState == ECharMoveState.Sprint || ((component != null) ? component.TargetEntity : null) == null || !component.IsTargetLocationValid || this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不受锁定面向旋转"]))
		{
			this.SetInputFacingFromInputDirect(false);
			return;
		}
		component.TargetLocation.Subtraction(this.ActorComp.ActorLocationProxy, this.TempVector);
		if (this.UnifiedComp == null || this.UnifiedComp.MoveState != ECharMoveState.Stand)
		{
			this.ActorComp.SetInputFacing(this.TempVector, true);
			return;
		}
		if (GravityUtils.Instance.GetAngleOffsetInGravityAbsForActor(this.ActorComp, this.ActorComp.ActorForwardProxy, this.TempVector) > 60f)
		{
			this.ActorComp.SetInputFacing(this.TempVector, true);
			return;
		}
		this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, true);
	}

	// Token: 0x0601A704 RID: 108292 RVA: 0x0070DF54 File Offset: 0x0070C154
	private void SetInputFacingFromInputDirect(bool clearWhenNoInput = true)
	{
		if (this.IsActorRelativeMove())
		{
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, clearWhenNoInput);
			return;
		}
		if (this.InCameraFollowInput)
		{
			this.CameraFollowInputCompensate();
			return;
		}
		if (this.IsLocalInputInternal)
		{
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, clearWhenNoInput);
			return;
		}
		if (GravityUtils.Instance.GetPlanarSizeSquared2dForActor(this.ActorComp, this.ActorComp.InputDirectProxy) > 1E-08)
		{
			this.ActorComp.SetInputFacing(this.ActorComp.InputDirectProxy, clearWhenNoInput);
			return;
		}
		if (clearWhenNoInput)
		{
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, clearWhenNoInput);
		}
	}

	// Token: 0x0601A705 RID: 108293 RVA: 0x0070E01C File Offset: 0x0070C21C
	private bool ShouldTriggerHoldEvent(CSharpScript.Game.Input.EInputAction action, double holdTime, float deltaTime)
	{
		ValueTuple<bool, float> holdConfig = this.GetHoldConfig(action);
		bool item = holdConfig.Item1;
		float item2 = holdConfig.Item2;
		if (item2 == -1f)
		{
			return false;
		}
		if (holdTime < (double)item2)
		{
			return false;
		}
		if (item)
		{
			return true;
		}
		if (CharacterInputComponent.HoldPressMap.ContainsKey(action) && CharacterInputComponent.HoldPressMap[action])
		{
			return false;
		}
		CharacterModel instance = CharacterModel.Instance;
		float num = (instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f;
		float num2 = deltaTime * num;
		return holdTime - (double)num2 > (double)item2;
	}

	// Token: 0x0601A706 RID: 108294 RVA: 0x0070E094 File Offset: 0x0070C294
	private void UpdateMoveCache()
	{
		this.GetMoveVector(this.MoveVectorCache);
		if (this.MoveInputOuterRingEnableCount > 0 && !this.MoveVectorCache.IsNearlyZero(9.999999747378752E-05) && this.IsSmallInput(this.MoveVectorCache))
		{
			this.MoveVectorCache.Normalize(9.99999993922529E-09);
		}
		if (!this.IsSmallInput(this.MoveVectorCache))
		{
			this.MoveDirectionCache.DeepCopy(this.MoveVectorCache);
			this.MoveDirectionCache.Normalize(9.99999993922529E-09);
			this.LastMovementInputTime = Time.Instance.SystemNow;
			return;
		}
		if (Time.Instance.SystemNow - this.LastMovementInputTime > 100.0)
		{
			this.MoveDirectionCache.DeepCopy(this.MoveVectorCache);
			this.MoveDirectionCache.Normalize(9.99999993922529E-09);
			this.LastMovementInputTime = -1.0;
		}
	}

	// Token: 0x0601A707 RID: 108295 RVA: 0x0070E188 File Offset: 0x0070C388
	private void RefreshMoveAxisToButtonActiveCondition()
	{
		SInputActive moveAxisToButtonConfig = InputLayerQueryHelper.GetMoveAxisToButtonConfig(base.Entity.Id);
		if (this.CurrentMoveAxisToButtonConfig == moveAxisToButtonConfig)
		{
			return;
		}
		this.CurrentMoveAxisToButtonConfig = moveAxisToButtonConfig;
		if (moveAxisToButtonConfig == null)
		{
			InputActiveCondition moveAxisToButtonActiveCondition = this.MoveAxisToButtonActiveCondition;
			if (moveAxisToButtonActiveCondition != null)
			{
				moveAxisToButtonActiveCondition.Clear();
			}
			this.MoveAxisToButtonActiveCondition = null;
			this.IsMoveAxisToButtonEnabled = false;
			return;
		}
		if (this.MoveAxisToButtonActiveCondition == null)
		{
			this.MoveAxisToButtonActiveCondition = new InputActiveCondition(this.TagComp, base.Entity.GetComponent<BaseAttributeComponent>(), new InputActiveResultCallback(this.OnEnableMoveAxisToButton));
		}
		this.MoveAxisToButtonActiveCondition.SetActiveCondition(moveAxisToButtonConfig);
	}

	// Token: 0x0601A708 RID: 108296 RVA: 0x0070E221 File Offset: 0x0070C421
	private MoveInputSimButtonLogic GetMoveAxisToButtonLogic()
	{
		if (this.MoveAxisToButtonLogic == null)
		{
			this.MoveAxisToButtonLogic = new MoveInputSimButtonLogic();
			this.MoveAxisToButtonLogic.Init(this.InputEvents);
		}
		return this.MoveAxisToButtonLogic;
	}

	// Token: 0x0601A709 RID: 108297 RVA: 0x0070E24D File Offset: 0x0070C44D
	private void RemoveMoveAxisToButton()
	{
		if (this.MoveAxisToButtonActiveCondition != null)
		{
			this.MoveAxisToButtonActiveCondition.Clear();
			this.MoveAxisToButtonActiveCondition = null;
		}
		this.CurrentMoveAxisToButtonConfig = null;
		this.IsMoveAxisToButtonEnabled = false;
		this.MoveAxisToButtonLogic = null;
	}

	// Token: 0x0601A70A RID: 108298 RVA: 0x0070E27E File Offset: 0x0070C47E
	public void OnEnableMoveAxisToButton(bool enable)
	{
		this.IsMoveAxisToButtonEnabled = enable;
	}

	// Token: 0x0601A70B RID: 108299 RVA: 0x0070E287 File Offset: 0x0070C487
	private void UpdateMoveAxisToButton()
	{
		this.RefreshMoveAxisToButtonActiveCondition();
		if (this.IsMoveAxisToButtonEnabled)
		{
			this.GetMoveAxisToButtonLogic().EmitByAxisMap(this.AxisValues);
		}
	}

	// Token: 0x0601A70C RID: 108300 RVA: 0x0070E2A8 File Offset: 0x0070C4A8
	protected void GetNewQuatInLockMode(EntityHandle targetEntity, FName? targetSocketName, Quat inOutQuat)
	{
		CameraUtility.GetSocketLocation(null, targetSocketName, this.TempVector, targetEntity);
		this.TempVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		double planarSizeSquared2dForActor = GravityUtils.Instance.GetPlanarSizeSquared2dForActor(this.ActorComp, this.TempVector);
		if (planarSizeSquared2dForActor < (double)(this.MoveDirectionDistanceMin * this.MoveDirectionDistanceMin))
		{
			return;
		}
		inOutQuat.Inverse(this.TempQuat);
		this.TempQuat.RotateVector(this.TempVector, this.TempVector);
		double num = this.TempVector.HeadingAngle() * 57.295780181884766;
		if (Math.Abs(num) > (double)this.MovementDirectionAngleThreshold)
		{
			return;
		}
		float inYaw = (float)MathUtils.Instance.RangeClamp(Math.Sqrt(planarSizeSquared2dForActor), (double)this.MoveDirectionDistanceMin, (double)this.MoveDirectionDistanceMax, 0.0, num);
		this.TempRotator.Set(0f, inYaw, 0f);
		this.TempRotator.Quaternion(this.TempQuat);
		inOutQuat.Multiply(this.TempQuat, this.TempQuat2);
		inOutQuat.DeepCopy(this.TempQuat2);
	}

	// Token: 0x0601A70D RID: 108301 RVA: 0x0070E3BC File Offset: 0x0070C5BC
	private bool IsSmallInput(global::Vector moveVector)
	{
		if (Info.Instance.IsInKeyBoard())
		{
			return moveVector.IsNearlyZero(1E-08);
		}
		return moveVector.SizeSquared() <= MathUtils.Instance.Square((double)RoleGaitStatic.GetWalkOrRunRate());
	}

	// Token: 0x0601A70E RID: 108302 RVA: 0x0070E3F8 File Offset: 0x0070C5F8
	private void ValidateInputCaches()
	{
		for (int i = this.InputCaches.Count - 1; i >= 0; i--)
		{
			InputCache inputCache = this.InputCaches[i];
			float cacheTime = this.GetCacheTime(inputCache.Action, inputCache.State);
			if (inputCache.AccumulateTime > (double)cacheTime)
			{
				this.InputCaches.RemoveAt(i);
			}
		}
	}

	// Token: 0x0601A70F RID: 108303 RVA: 0x0070E453 File Offset: 0x0070C653
	[NullableContext(2)]
	private void ClearInputCaches(string reason = null)
	{
		this.InputCaches.Clear();
	}

	// Token: 0x0601A710 RID: 108304 RVA: 0x0070E460 File Offset: 0x0070C660
	private bool QueryInputCaches()
	{
		if (this.InputCaches.Count == 0)
		{
			return false;
		}
		List<InputCommand> list = new List<InputCommand>();
		for (int i = 0; i < this.InputCaches.Count; i++)
		{
			InputCache inputCache = this.InputCaches[i];
			SInputCommand sinputCommand = null;
			switch (inputCache.State)
			{
			case EInputState.Press:
				sinputCommand = this.HandlePress(inputCache.Action, inputCache.Time, inputCache.MoveInputYaw);
				break;
			case EInputState.Release:
				sinputCommand = this.HandleRelease(inputCache.Action, (double)inputCache.Time, inputCache.MoveInputYaw);
				break;
			case EInputState.Hold:
				sinputCommand = this.HandleHold(inputCache.Action, (double)inputCache.Time, inputCache.MoveInputYaw);
				break;
			}
			if (sinputCommand != null && sinputCommand.CommandType != ECommandType.None)
			{
				list.Add(new InputCommand(inputCache.Action, inputCache.State, inputCache.Time, sinputCommand, i));
			}
		}
		InputCommand bestInputCommand = this.GetBestInputCommand(list);
		if (bestInputCommand == null)
		{
			return false;
		}
		if (bestInputCommand != null && bestInputCommand.State == EInputState.Hold)
		{
			CharacterInputComponent.HoldPressMap[bestInputCommand.Action] = true;
		}
		this.ExecuteInputCommand(bestInputCommand, "QueryInputCaches");
		return true;
	}

	// Token: 0x0601A711 RID: 108305 RVA: 0x0070E596 File Offset: 0x0070C796
	private void HandleAnimBreakPoint(int entityId)
	{
		if (this.CharacterInternal == null || this.CharacterInternal.GetEntityIdNoBlueprint() != entityId)
		{
			return;
		}
		if (this.QueryInputCaches())
		{
			this.ClearInputCaches("HandleAnimBreakPoint");
		}
	}

	// Token: 0x0601A712 RID: 108306 RVA: 0x0070E5C4 File Offset: 0x0070C7C4
	[return: Nullable(2)]
	private InputCommand GetBestInputCommand(List<InputCommand> commands)
	{
		if (commands.Count == 0)
		{
			return null;
		}
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < commands.Count; i++)
		{
			InputCommand inputCommand = commands[i];
			int num3 = this.QueryInputPriority(inputCommand.Command);
			if (num3 > num)
			{
				num = num3;
				num2 = i;
			}
		}
		if (num2 == -1)
		{
			return null;
		}
		return commands[num2];
	}

	// Token: 0x0601A713 RID: 108307 RVA: 0x0070E620 File Offset: 0x0070C820
	private int QueryInputPriority(SInputCommand command)
	{
		int? num = null;
		ECommandType ecommandType = command.CommandType;
		if (ecommandType != ECommandType.None)
		{
			if (ecommandType == ECommandType.Skill)
			{
				num = new int?(this.QuerySkillPriority(command.IntValue));
			}
			else
			{
				num = InputController.Instance.QueryCommandPriority(command.CommandType);
			}
		}
		if (num == null)
		{
			num = new int?(-1);
		}
		return num.Value;
	}

	// Token: 0x0601A714 RID: 108308 RVA: 0x0070E68B File Offset: 0x0070C88B
	private int QuerySkillPriority(int skillId)
	{
		TsBaseCharacter characterInternal = this.CharacterInternal;
		BaseSkillComponent baseSkillComponent;
		if (characterInternal == null)
		{
			baseSkillComponent = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = characterInternal.CharacterActorComponent;
			if (characterActorComponent == null)
			{
				baseSkillComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				baseSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
		}
		return baseSkillComponent.GetPriority(skillId);
	}

	// Token: 0x0601A715 RID: 108309 RVA: 0x0070E6C0 File Offset: 0x0070C8C0
	private void ExecuteInputCommand(InputCommand inputCommand, string context)
	{
		SInputCommand command = inputCommand.Command;
		ECommandType key = command.CommandType;
		switch (key)
		{
		case ECommandType.Skill:
			if (Info.Instance.IsInGamepad() && inputCommand.Action == CSharpScript.Game.Input.EInputAction.攻击 && inputCommand.State == EInputState.Release && this.GetCommandInterval(ECommandType.Climb) < 0.25f)
			{
				this.RemoveCommandInterval(ECommandType.Climb);
				return;
			}
			this.ExecuteSkill(command.IntValue, context);
			return;
		case ECommandType.Jump:
			this.ExecuteJump(command);
			return;
		case ECommandType.Climb:
			this.ExecuteClimb(command);
			this.CommandTimeMap[key] = Time.Instance.WorldTimeSeconds;
			return;
		case ECommandType.Sprint:
			this.ExecuteSprint(command);
			return;
		case ECommandType.FastSwim:
			this.ExecuteFastSwim(command);
			return;
		case ECommandType.FastClimb:
			this.ExecuteFastClimb(command);
			return;
		case ECommandType.SwitchCharacter:
			this.ExecuteSwitchCharacter(command.IntValue);
			return;
		case ECommandType.SwitchWalk:
			this.ExecuteSwitchWalk(command);
			return;
		case ECommandType.SendGameplayEvent:
			this.AbilityComp.SendGameplayEventToActor(command.TagValue, null);
			return;
		case ECommandType.XaBoost:
			this.ExecuteXaBoost(command);
			return;
		case ECommandType.Swallow:
			break;
		case ECommandType.Drop:
			this.ExecuteDrop(command);
			break;
		default:
			return;
		}
	}

	// Token: 0x0601A716 RID: 108310 RVA: 0x0070E7DC File Offset: 0x0070C9DC
	private void ExecuteJump(SInputCommand command)
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		if (!component.Valid)
		{
			return;
		}
		if (command.IntValue == 1)
		{
			component.JumpPress();
			return;
		}
		component.JumpRelease();
	}

	// Token: 0x0601A717 RID: 108311 RVA: 0x0070E814 File Offset: 0x0070CA14
	private void ExecuteClimb(SInputCommand command)
	{
		CharacterClimbComponent component = base.Entity.GetComponent<CharacterClimbComponent>();
		if (component == null)
		{
			return;
		}
		component.ClimbPress(command.IntValue == 1);
	}

	// Token: 0x0601A718 RID: 108312 RVA: 0x0070E834 File Offset: 0x0070CA34
	private void ExecuteSprint(SInputCommand command)
	{
		if (command.IntValue == 1)
		{
			base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SprintPress();
			return;
		}
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SprintRelease();
	}

	// Token: 0x0601A719 RID: 108313 RVA: 0x0070E860 File Offset: 0x0070CA60
	private void ExecuteFastSwim(SInputCommand command)
	{
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SwitchFastSwim(command.IntValue == 1);
	}

	// Token: 0x0601A71A RID: 108314 RVA: 0x0070E87B File Offset: 0x0070CA7B
	private void ExecuteFastClimb(SInputCommand command)
	{
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SwitchFastClimb(command.IntValue == 1, false);
	}

	// Token: 0x0601A71B RID: 108315 RVA: 0x0070E897 File Offset: 0x0070CA97
	private void ExecuteSwitchWalk(SInputCommand command)
	{
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().WalkPress();
	}

	// Token: 0x0601A71C RID: 108316 RVA: 0x0070E8A9 File Offset: 0x0070CAA9
	private void ExecuteXaBoost(SInputCommand command)
	{
		CharacterGlideComponent characterGlideComponent = base.Entity.CheckGetComponent<CharacterGlideComponent>();
		if (characterGlideComponent == null)
		{
			return;
		}
		characterGlideComponent.SetSoarBoostOn(command.IntValue > 0);
	}

	// Token: 0x0601A71D RID: 108317 RVA: 0x0070E8C9 File Offset: 0x0070CAC9
	private void ExecuteDrop(SInputCommand command)
	{
		if (!this.MoveComp)
		{
			return;
		}
		if (command.IntValue == 1)
		{
			this.MoveComp.OnDropPress();
			return;
		}
		this.MoveComp.OnDropRelease();
	}

	// Token: 0x0601A71E RID: 108318 RVA: 0x0070E8F9 File Offset: 0x0070CAF9
	private void ExecuteSwitchCharacter(int index)
	{
	}

	// Token: 0x0601A71F RID: 108319 RVA: 0x0070E8FB File Offset: 0x0070CAFB
	private void ExecuteSkill(int skillId, string context)
	{
		base.Entity.GetComponent<CharacterSkillComponent>().BeginSkillAsync(skillId, new SkillParam
		{
			Reason = "CharacterInputComponent.ExecuteSkill." + context
		}).Forget<bool>();
	}

	// Token: 0x0601A720 RID: 108320 RVA: 0x0070E929 File Offset: 0x0070CB29
	private float GetWorldTime()
	{
		return UGameplayStatics.GetTimeSeconds(GlobalData.World);
	}

	// Token: 0x0601A721 RID: 108321 RVA: 0x0070E938 File Offset: 0x0070CB38
	public void SetActive(bool value)
	{
		if (value)
		{
			if (this.DisableHandle != null)
			{
				base.Enable(new int?(this.DisableHandle.Value), "[CharacterInputComponent.SetActive] this.DisableHandle=true");
				this.DisableHandle = null;
			}
		}
		else if (this.DisableHandle == null)
		{
			this.DisableHandle = new int?(base.Disable("[CharacterInputComponent.SetActive] this.DisableHandle=false"));
		}
		MoveInputSimButtonLogic moveAxisToButtonLogic = this.MoveAxisToButtonLogic;
		if (moveAxisToButtonLogic == null)
		{
			return;
		}
		moveAxisToButtonLogic.Reset();
	}

	// Token: 0x0601A722 RID: 108322 RVA: 0x0070E9B4 File Offset: 0x0070CBB4
	private unsafe void DispatchPressEvent(CSharpScript.Game.Input.EInputAction action, double time, float moveInputYaw = 0f)
	{
		if (this.ActorComp == null)
		{
			Log.Instance.Error(ELogModule.Input, ELogAuthor.LCZ, "Entity Is End", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(base.Entity.Id);
		if (inputLayers == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[CharacterInputComponent.DispatchPressEvent]输入层级为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		for (int i = 0; i < inputLayers.Count; i++)
		{
			InputLayer inputLayer = inputLayers[i];
			if (inputLayer.CheckBlockDispatchEvent(action))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Input;
				ELogAuthor author2 = ELogAuthor.JYS;
				string message2 = "[CharacterInputComponent.DispatchPressEvent]输入的事件被LayerMap屏蔽";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("layer", inputLayer.GetLayerType());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("action", action);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			inputLayer.DispatchPressEventEx(action, (float)time, moveInputYaw);
		}
	}

	// Token: 0x0601A723 RID: 108323 RVA: 0x0070EB00 File Offset: 0x0070CD00
	private void DispatchReleaseEvent(CSharpScript.Game.Input.EInputAction action, double time, float moveInputYaw = 0f)
	{
		if (this.ActorComp == null)
		{
			Log.Instance.Error(ELogModule.Input, ELogAuthor.LCZ, "Entity Is End", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(base.Entity.Id);
		if (inputLayers == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[CharacterInputComponent.DispatchReleaseEvent]输入层级为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		for (int i = 0; i < inputLayers.Count; i++)
		{
			inputLayers[i].DispatchReleaseEventEx(action, (float)time, moveInputYaw);
		}
	}

	// Token: 0x0601A724 RID: 108324 RVA: 0x0070EBA4 File Offset: 0x0070CDA4
	[NullableContext(2)]
	private SInputCommand HandlePress(CSharpScript.Game.Input.EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.ActorComp == null)
		{
			Log.Instance.Error(ELogModule.Input, ELogAuthor.LCZ, "Entity Is End", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(base.Entity.Id);
		if (inputLayers == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "[CharacterInputComponent.HandlePress]输入层级为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		InputLayerQueryResult<SInputCommand> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputCommand>(inputLayers, ([Nullable(1)] InputLayer layer) => layer.HandlePressEx(action, time, moveInputYaw), (SInputCommand command) => command != null && command.CommandType != ECommandType.None);
		if (inputLayerQueryResult != null)
		{
			return inputLayerQueryResult.Result;
		}
		return null;
	}

	// Token: 0x0601A725 RID: 108325 RVA: 0x0070EC80 File Offset: 0x0070CE80
	[NullableContext(2)]
	private SInputCommand HandleRelease(CSharpScript.Game.Input.EInputAction action, double time, float moveInputYaw = 0f)
	{
		if (this.ActorComp == null)
		{
			Log.Instance.Error(ELogModule.Input, ELogAuthor.LCZ, "Entity Is End", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(base.Entity.Id);
		if (inputLayers == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "[CharacterInputComponent.HandleRelease]输入层级为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		InputLayerQueryResult<SInputCommand> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputCommand>(inputLayers, ([Nullable(1)] InputLayer layer) => layer.HandleReleaseEx(action, (float)time, moveInputYaw), (SInputCommand command) => command != null && command.CommandType != ECommandType.None);
		if (inputLayerQueryResult != null)
		{
			return inputLayerQueryResult.Result;
		}
		return null;
	}

	// Token: 0x0601A726 RID: 108326 RVA: 0x0070ED5C File Offset: 0x0070CF5C
	[NullableContext(2)]
	private SInputCommand HandleHold(CSharpScript.Game.Input.EInputAction action, double time, float moveInputYaw = 0f)
	{
		if (this.ActorComp == null)
		{
			Log.Instance.Error(ELogModule.Input, ELogAuthor.LCZ, "Entity Is End", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(base.Entity.Id);
		if (inputLayers == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "[CharacterInputComponent.HandleHold]输入层级为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		InputLayerQueryResult<SInputCommand> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputCommand>(inputLayers, ([Nullable(1)] InputLayer layer) => layer.HandleHoldEx(action, (float)time, moveInputYaw), (SInputCommand command) => command != null && command.CommandType != ECommandType.None);
		if (inputLayerQueryResult != null)
		{
			return inputLayerQueryResult.Result;
		}
		return null;
	}

	// Token: 0x0601A727 RID: 108327 RVA: 0x0070EE38 File Offset: 0x0070D038
	private float GetCacheTime(CSharpScript.Game.Input.EInputAction action, EInputState state)
	{
		SInputCaches? cacheConfig = InputLayerQueryHelper.GetCacheConfig(base.Entity.Id, action);
		if (cacheConfig == null)
		{
			return 0f;
		}
		switch (state)
		{
		case EInputState.Press:
			return cacheConfig.Value.按下;
		case EInputState.Release:
			return cacheConfig.Value.抬起;
		case EInputState.Hold:
			return cacheConfig.Value.长按;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.WCL;
			string message = "错误的输入状态 ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0f;
		}
		}
	}

	// Token: 0x0601A728 RID: 108328 RVA: 0x0070EED4 File Offset: 0x0070D0D4
	[NullableContext(0)]
	public ValueTuple<bool, float> GetHoldConfig(CSharpScript.Game.Input.EInputAction action)
	{
		SInputHoldConfig? holdConfig = InputLayerQueryHelper.GetHoldConfig(base.Entity.Id, action);
		if (holdConfig == null)
		{
			return new ValueTuple<bool, float>(false, -1f);
		}
		return new ValueTuple<bool, float>(holdConfig.Value.连续触发, holdConfig.Value.触发时间);
	}

	// Token: 0x0601A729 RID: 108329 RVA: 0x0070EF28 File Offset: 0x0070D128
	public void TurnOnAutomaticFlightMode(ICM_AutomaticFlight_DataBase_C dataAsset)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Actor.GetName().Contains("Youyidie"))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Error TurnOnAutomaticFlightMode";
			string item = "Actor";
			CharacterActorComponent actorComp2 = this.ActorComp;
			object item2;
			if (actorComp2 == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp2.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, item2);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "TurnOnAutomaticFlightMode";
			string item3 = "Actor";
			CharacterActorComponent actorComp3 = this.ActorComp;
			object item4;
			if (actorComp3 == null)
			{
				item4 = null;
			}
			else
			{
				TsBaseCharacter actor2 = actorComp3.Actor;
				item4 = ((actor2 != null) ? actor2.GetName() : null);
			}
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item3, item4);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		this.AutomaticFlightMode = true;
		this.AutomaticFlightDataAsset = new AutomaticFlightData(dataAsset);
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp == null || !moveComp.Valid)
		{
			return;
		}
		this.AutomaticFlightDataAsset.LastFlySpeed = this.AutomaticFlightDataAsset.NormalFlySpeed;
		this.AutomaticFlightDataAsset.TargetFlySpeed = this.AutomaticFlightDataAsset.NormalFlySpeed;
		this.MoveComp.SetMaxSpeed(this.AutomaticFlightDataAsset.NormalFlySpeed.Value);
	}

	// Token: 0x0601A72A RID: 108330 RVA: 0x0070F055 File Offset: 0x0070D255
	public void TurnOffAutomaticFlightMode()
	{
		this.AutomaticFlightMode = false;
		this.AutomaticFlightDataAsset = null;
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp == null || !moveComp.Valid)
		{
			return;
		}
		this.StateComp.ResetCharState();
	}

	// Token: 0x0601A72B RID: 108331 RVA: 0x0070F088 File Offset: 0x0070D288
	public bool IsInAutomaticFlightMode()
	{
		return this.AutomaticFlightMode;
	}

	// Token: 0x0601A72C RID: 108332 RVA: 0x0070F090 File Offset: 0x0070D290
	public void TurnOnCameraDrivenAutoFlightMode(BP_CameraDrivenAutoFlightData_C dataAsset)
	{
		if (dataAsset == null)
		{
			return;
		}
		this.CameraDrivenAutoFlightMode = true;
		this.IsStartCameraDrivenAutoFlightTick = false;
		if (this.CameraDrivenAutoFlightDataAsset == null)
		{
			this.CameraDrivenAutoFlightDataAsset = new CameraDrivenAutoFlightData();
		}
		this.CameraDrivenAutoFlightDataAsset.AutoFlightEnableTime = dataAsset.自动驾驶开始时间;
		this.CameraDrivenAutoFlightDataAsset.AutoFlightStartAngleTolerance = dataAsset.自动驾驶启动输入;
		this.CameraDrivenAutoFlightDataAsset.AutoFlightFinishAngleTolerance = dataAsset.自动驾驶完成角度;
		this.CameraDrivenAutoFlightDataAsset.AutoFlightInputAngleMin = dataAsset.自动驾驶归正角度Min;
		this.CameraDrivenAutoFlightDataAsset.AutoFlightInputAngleMax = dataAsset.自动驾驶归正角度Max;
		this.CameraDrivenAutoFlightDataAsset.AutoFlightInputMin = dataAsset.自动驾驶归正角度模拟输入Min;
		this.CameraDrivenAutoFlightDataAsset.AutoFlightInputMax = dataAsset.自动驾驶归正角度模拟输入Max;
	}

	// Token: 0x0601A72D RID: 108333 RVA: 0x0070F139 File Offset: 0x0070D339
	public void TurnOffCameraDrivenAutoFlightMode()
	{
		this.CameraDrivenAutoFlightMode = false;
		this.IsStartCameraDrivenAutoFlightTick = false;
	}

	// Token: 0x0601A72E RID: 108334 RVA: 0x0070F149 File Offset: 0x0070D349
	public bool IsInCameraDrivenAutoFlightMode()
	{
		return this.CameraDrivenAutoFlightMode && this.IsInCameraDrivenAutoFlight;
	}

	// Token: 0x0601A72F RID: 108335 RVA: 0x0070F15C File Offset: 0x0070D35C
	private void AddCharacterInputLayer()
	{
		if (this.InputLayer != null)
		{
			this.RemoveCharacterInputLayer();
		}
		this.InputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.Character) as CharacterInputLayer);
		if (this.InputLayer != null)
		{
			EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
			if (handleByEntity != null)
			{
				this.InputLayer.Init(handleByEntity);
				InputController.Instance.AddInputLayer(base.Entity.Id, this.InputLayer);
			}
		}
	}

	// Token: 0x0601A730 RID: 108336 RVA: 0x0070F1D0 File Offset: 0x0070D3D0
	private void RemoveCharacterInputLayer()
	{
		if (this.InputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.InputLayer);
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x0601A731 RID: 108337 RVA: 0x0070F1FC File Offset: 0x0070D3FC
	private void AddExtraInputLayer()
	{
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
		if (handleByEntity == null)
		{
			return;
		}
		string bpInputClassPath = ExtraInputLayer.GetBpInputClassPath(handleByEntity);
		if (string.IsNullOrEmpty(bpInputClassPath))
		{
			return;
		}
		ExtraInputLayer extraInputLayer = InputController.Instance.CreateInputLayer(EInputLayer.Extra) as ExtraInputLayer;
		if (extraInputLayer == null)
		{
			return;
		}
		extraInputLayer.Init(handleByEntity, bpInputClassPath);
		if (this.ExtraInputLayer != null)
		{
			this.RemoveExtraInputLayer();
		}
		this.ExtraInputLayer = extraInputLayer;
		InputController.Instance.AddInputLayer(base.Entity.Id, this.ExtraInputLayer);
	}

	// Token: 0x0601A732 RID: 108338 RVA: 0x0070F27B File Offset: 0x0070D47B
	private void RemoveExtraInputLayer()
	{
		if (this.ExtraInputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.ExtraInputLayer);
			this.ExtraInputLayer.Clear();
			this.ExtraInputLayer = null;
		}
	}

	// Token: 0x0601A733 RID: 108339 RVA: 0x0070F2A7 File Offset: 0x0070D4A7
	[NullableContext(2)]
	public BP_InputBase_C GetBpInputComp()
	{
		return InputLayerQueryHelper.GetFirstBpInputComp(base.Entity.Id);
	}

	// Token: 0x0601A734 RID: 108340 RVA: 0x0070F2B9 File Offset: 0x0070D4B9
	public void SetBpInputComp(BP_InputBase_C bpInputComp)
	{
		CharacterInputLayer inputLayer = this.InputLayer;
		if (inputLayer == null)
		{
			return;
		}
		inputLayer.SetBpInputComp(bpInputComp);
	}

	// Token: 0x0601A735 RID: 108341 RVA: 0x0070F2CC File Offset: 0x0070D4CC
	public float GetCommandInterval(ECommandType commandType)
	{
		double num = this.CommandTimeMap.ContainsKey(commandType) ? this.CommandTimeMap[commandType] : 0.0;
		return (float)(Time.Instance.WorldTimeSeconds - num);
	}

	// Token: 0x0601A736 RID: 108342 RVA: 0x0070F30C File Offset: 0x0070D50C
	public void RemoveCommandInterval(ECommandType commandType)
	{
		this.CommandTimeMap.Remove(commandType);
	}

	// Token: 0x0601A737 RID: 108343 RVA: 0x0070F31B File Offset: 0x0070D51B
	public bool IsOnlyAllowFightInput()
	{
		return this.IsOnlyAllowFightInputInternal;
	}

	// Token: 0x0601A738 RID: 108344 RVA: 0x0070F323 File Offset: 0x0070D523
	public void SetOnlyAllowFightInput(bool isOnlyAllowFightInput)
	{
		this.IsOnlyAllowFightInputInternal = isOnlyAllowFightInput;
		EventSystem.Instance.Emit(EEventName.OnOnlyAllowFightInputStateChanged);
	}

	// Token: 0x0601A739 RID: 108345 RVA: 0x0070F33C File Offset: 0x0070D53C
	private void TryGetTagDaPathMap()
	{
		BP_FirstPersonConfigMap_C bp_FirstPersonConfigMap_C = ResourceSystem.Instance.Load<BP_FirstPersonConfigMap_C>("/Game/Aki/Character/Role/Common/Data/DA/DA_FirstPersonConfigMap.DA_FirstPersonConfigMap", "js_undefined");
		if (bp_FirstPersonConfigMap_C == null || !bp_FirstPersonConfigMap_C.IsValid())
		{
			Log.Instance.Error(ELogModule.Input, ELogAuthor.ZJL, "第一人称配置表加载失败, 无法获取TagToDaPathMap", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> tagToConfigMap = bp_FirstPersonConfigMap_C.TagToConfigMap;
		for (int i = 0; i < tagToConfigMap.Num(); i++)
		{
			int num = tagToConfigMap.GetKey(i).TagId();
			TSoftObjectPtr<BP_FirstPersonConfig_C> tsoftObjectPtr = tagToConfigMap.Get(tagToConfigMap.GetKey(i));
			string value = (tsoftObjectPtr != null) ? tsoftObjectPtr.ToAssetPathName() : null;
			if (!string.IsNullOrEmpty(value))
			{
				this.TagToDaPathMap[num] = value;
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "第一人称配置表中触发Tag的软引用为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", num);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0601A73A RID: 108346 RVA: 0x0070F420 File Offset: 0x0070D620
	private void AddCameraFollowInputListener()
	{
		foreach (KeyValuePair<int, string> keyValuePair in this.TagToDaPathMap)
		{
			int key = keyValuePair.Key;
			BaseTagComponent tagComp = this.TagComp;
			ITagTask tagTask = (tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(key), delegate(int tagId, bool tagExists)
			{
				if (tagExists)
				{
					this.ActiveCameraFollowInput(tagId);
					return;
				}
				this.ClearCameraFollowInputState();
			}, null) : null;
			if (tagTask != null)
			{
				this.CameraFollowInputTagTasks.Add(tagTask);
			}
		}
	}

	// Token: 0x0601A73B RID: 108347 RVA: 0x0070F4AC File Offset: 0x0070D6AC
	private void ActiveCameraFollowInput(int triggerTagId)
	{
		this.InCameraFollowInput = true;
		this.InitCameraFollowInputConfig(triggerTagId, delegate(CameraFollowInputConfig config)
		{
			for (int i = 0; i < config.FirstPersonTagList.Count; i++)
			{
				int value = config.FirstPersonTagList[i];
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTag(new int?(value));
				}
			}
		});
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null)
		{
			stateComp.SetDirectionState(ECharDirectionState.CameraDirection);
		}
		Entity entity = base.Entity;
		if (entity == null)
		{
			return;
		}
		BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return;
		}
		component.SetLockedRotation(true);
	}

	// Token: 0x0601A73C RID: 108348 RVA: 0x0070F500 File Offset: 0x0070D700
	private void ClearCameraFollowInputState()
	{
		this.InCameraFollowInput = false;
		CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
		if (unifiedComp != null)
		{
			unifiedComp.MarkWalkOrRun(false, false, new bool?(false));
		}
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null)
		{
			stateComp.SetDirectionState(ECharDirectionState.FaceDirection);
		}
		Entity entity = base.Entity;
		if (entity != null)
		{
			BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.SetLockedRotation(false);
			}
		}
		if (this.CameraFollowInputConfig != null)
		{
			for (int i = 0; i < this.CameraFollowInputConfig.FirstPersonTagList.Count; i++)
			{
				int value = this.CameraFollowInputConfig.FirstPersonTagList[i];
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.RemoveTag(new int?(value));
				}
			}
		}
	}

	// Token: 0x0601A73D RID: 108349 RVA: 0x0070F5AC File Offset: 0x0070D7AC
	private void RemoveCameraFollowInputListener()
	{
		this.ClearCameraFollowInputState();
		this.CameraFollowInputLockRunState = false;
		this.CameraFollowInputInSprintState = false;
		this.CameraFollowInputConfig = null;
		for (int i = 0; i < this.CameraFollowInputTagTasks.Count; i++)
		{
			this.CameraFollowInputTagTasks[i].EndTask();
		}
		this.CameraFollowInputTagTasks.Clear();
	}

	// Token: 0x0601A73E RID: 108350 RVA: 0x0070F608 File Offset: 0x0070D808
	private void InitCameraFollowInputConfig(int triggerTagId, Action<CameraFollowInputConfig> callback)
	{
		if (!this.CameraFollowInputLockRunState)
		{
			this.CameraFollowInputLockRunState = true;
			CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
			if (unifiedComp != null)
			{
				unifiedComp.MarkWalkOrRun(false, false, new bool?(true));
			}
		}
		CameraFollowInputConfig cameraFollowInputConfig = this.CameraFollowInputConfig;
		if (cameraFollowInputConfig != null && cameraFollowInputConfig.TriggerTagId == triggerTagId)
		{
			callback(this.CameraFollowInputConfig);
			return;
		}
		string configPath = this.FindFirstPersonConfigPath(triggerTagId);
		if (string.IsNullOrEmpty(configPath))
		{
			return;
		}
		Action<BP_FirstPersonConfig_C, string> <>9__1;
		ResourceSystem.Instance.LoadTypeAsync("BP_FirstPersonConfig_C", delegate
		{
			ResourceSystem instance = ResourceSystem.Instance;
			string configPath = configPath;
			Action<BP_FirstPersonConfig_C, string> callback2;
			if ((callback2 = <>9__1) == null)
			{
				callback2 = (<>9__1 = delegate([Nullable(2)] BP_FirstPersonConfig_C result, string _)
				{
					CameraFollowInputConfig cameraFollowInputConfig2 = new CameraFollowInputConfig();
					if (result != null && result.IsValid())
					{
						cameraFollowInputConfig2.Init(result, triggerTagId);
					}
					this.CameraFollowInputConfig = cameraFollowInputConfig2;
					callback(cameraFollowInputConfig2);
				});
			}
			instance.LoadAsync<BP_FirstPersonConfig_C>(configPath, callback2, 100, "js_undefined");
		}, "js_undefined");
	}

	// Token: 0x0601A73F RID: 108351 RVA: 0x0070F6C8 File Offset: 0x0070D8C8
	[NullableContext(2)]
	private string FindFirstPersonConfigPath(int triggerTagId)
	{
		if (this.TagToDaPathMap.ContainsKey(triggerTagId))
		{
			return this.TagToDaPathMap[triggerTagId];
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Input;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "第一人称配置表中未找到触发Tag对应的子DA";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("triggerTagId", triggerTagId);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0601A740 RID: 108352 RVA: 0x0070F720 File Offset: 0x0070D920
	private void SetMoveSprint(bool value)
	{
		if (value)
		{
			if (!this.CameraFollowInputInSprintState)
			{
				CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
				if (unifiedComp != null)
				{
					unifiedComp.SprintPress();
				}
				this.CameraFollowInputInSprintState = true;
				return;
			}
		}
		else if (this.CameraFollowInputInSprintState)
		{
			CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
			if (unifiedComp2 != null)
			{
				unifiedComp2.SprintRelease();
			}
			this.CameraFollowInputInSprintState = false;
		}
	}

	// Token: 0x0601A741 RID: 108353 RVA: 0x0070F774 File Offset: 0x0070D974
	private void CameraFollowInputCompensate()
	{
		CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
		if (unifiedComp == null || unifiedComp.PositionState > ECharPositionState.Ground)
		{
			CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
			if (unifiedComp2 == null || unifiedComp2.PositionState != ECharPositionState.Air)
			{
				CharacterUnifiedStateComponent unifiedComp3 = this.UnifiedComp;
				if (unifiedComp3 == null || unifiedComp3.PositionState != ECharPositionState.Water)
				{
					this.SetMoveSprint(false);
					return;
				}
			}
		}
		CharacterUnifiedStateComponent unifiedComp4 = this.UnifiedComp;
		if (unifiedComp4 == null || unifiedComp4.MoveState != ECharMoveState.Sprint)
		{
			this.SetMoveSprint(false);
		}
		if (this.StateComp.DirectionState != ECharDirectionState.CameraDirection)
		{
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp != null)
			{
				stateComp.SetDirectionState(ECharDirectionState.CameraDirection);
			}
			Entity entity = base.Entity;
			if (entity != null)
			{
				BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
				if (component != null)
				{
					component.SetLockedRotation(true);
				}
			}
		}
		CharacterUnifiedStateComponent unifiedComp5 = this.UnifiedComp;
		if (unifiedComp5 != null && unifiedComp5.PositionState == ECharPositionState.Ground && !this.TempVector2.IsNearlyZero(9.999999747378752E-05))
		{
			CharacterSkillComponent skillComponent = this.SkillComponent;
			if (((skillComponent != null) ? skillComponent.CurrentSkill : null) == null)
			{
				CameraFollowInputConfig cameraFollowInputConfig = this.CameraFollowInputConfig;
				if (cameraFollowInputConfig != null && cameraFollowInputConfig.DashInForwardAngle)
				{
					float num = Math.Abs(GravityUtils.Instance.GetAngleOffsetInGravityForActor(this.ActorComp, this.ActorComp.ActorForwardProxy, this.ActorComp.InputDirectProxy));
					CameraFollowInputConfig cameraFollowInputConfig2 = this.CameraFollowInputConfig;
					if (num < ((cameraFollowInputConfig2 != null) ? cameraFollowInputConfig2.ForwardAngle : 50f))
					{
						this.SetMoveSprint(true);
						goto IL_165;
					}
					this.SetMoveSprint(false);
					goto IL_165;
				}
			}
		}
		this.SetMoveSprint(false);
		IL_165:
		if (this.CameraFollowInputConfig != null)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null && tagComp.HasAnyTag(this.CameraFollowInputConfig.ForbidRotationTagList))
			{
				return;
			}
		}
		this.CalculateMoveDirection(this.TempVector2);
		if (!this.TempVector2.IsNearlyZero(9.999999747378752E-05))
		{
			MathUtils.Instance.LookRotationForwardFirst(this.TempVector2, this.ActorComp.ActorUpProxy, this.TempRotator);
			this.ActorComp.SetActorRotation(this.TempRotator.ToUeRotator(), "CameraFollowInput.CameraDirection", false);
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
		}
	}

	// Token: 0x0601A742 RID: 108354 RVA: 0x0070F98A File Offset: 0x0070DB8A
	public void SetUseActorRelativeMoveInput(bool value)
	{
		this.UseActorRelativeMoveInput = value;
	}

	// Token: 0x0601A743 RID: 108355 RVA: 0x0070F993 File Offset: 0x0070DB93
	public bool GetUseActorRelativeMoveInput()
	{
		return this.UseActorRelativeMoveInput;
	}

	// Token: 0x0601A744 RID: 108356 RVA: 0x0070F99B File Offset: 0x0070DB9B
	public void SetInvertMoveForward(bool value)
	{
		this.InvertMoveForward = value;
	}

	// Token: 0x0601A745 RID: 108357 RVA: 0x0070F9A4 File Offset: 0x0070DBA4
	public void SetInvertMoveRight(bool value)
	{
		this.InvertMoveRight = value;
	}

	// Token: 0x0601A746 RID: 108358 RVA: 0x0070F9AD File Offset: 0x0070DBAD
	private bool IsActorRelativeMove()
	{
		return this.UseActorRelativeMoveInput;
	}

	// Token: 0x17002469 RID: 9321
	// (get) Token: 0x0601A747 RID: 108359 RVA: 0x0070F9B8 File Offset: 0x0070DBB8
	// (set) Token: 0x0601A748 RID: 108360 RVA: 0x0070FA03 File Offset: 0x0070DC03
	private InputContinuously AutoMovingConfig
	{
		get
		{
			if (this.AutoMovingConfigInternal == null)
			{
				BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
				BaseBuffComponent component2 = base.Entity.GetComponent<BaseBuffComponent>();
				this.AutoMovingConfigInternal = new InputContinuously(component, component2);
				this.AutoMovingConfigInternal.InitConfig();
			}
			return this.AutoMovingConfigInternal;
		}
		set
		{
			this.AutoMovingConfigInternal = value;
		}
	}

	// Token: 0x0601A749 RID: 108361 RVA: 0x0070FA0C File Offset: 0x0070DC0C
	private void UpdateAutoMovingCheck(global::Vector moveDirection, float delta)
	{
		BattleUiFormationData formationData = BattleUiModel.Instance.FormationData;
		if (formationData != null && formationData.AutoMovingSettingEnable)
		{
			bool autoMovingState = this.AutoMovingConfig.GetAutoMovingState();
			bool flag = this.AutoMovingConfig.IsStartEnter();
			bool flag2 = moveDirection.IsNearlyZero(9.999999747378752E-05);
			if (autoMovingState && !flag && !flag2)
			{
				this.InterruptAutoMoving("玩家输入", true);
				return;
			}
			if (autoMovingState)
			{
				if (this.CheckOtherPositionState(delta))
				{
					return;
				}
				CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
				if (unifiedComp == null || unifiedComp.PositionState > ECharPositionState.Ground)
				{
					this.InterruptAutoMoving("处于其他移动状态", true);
					return;
				}
			}
			if (flag2)
			{
				if (!autoMovingState)
				{
					this.AutoMovingConfig.ClearTimeAccumulation();
				}
				else if (flag)
				{
					this.AutoMovingConfig.ClearStartEnter();
				}
			}
			if (!autoMovingState)
			{
				if (!flag2)
				{
					CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
					if (unifiedComp2 != null && unifiedComp2.MoveState == ECharMoveState.Sprint)
					{
						this.AutoMovingConfig.AddTimeAccumulation(delta);
						goto IL_E3;
					}
				}
				this.AutoMovingConfig.ClearTimeAccumulation();
				IL_E3:
				if (this.AutoMovingConfig.CheckTimeDuration())
				{
					this.AutoMovingConfig.SetAutoMovingState(true, true);
				}
			}
		}
	}

	// Token: 0x0601A74A RID: 108362 RVA: 0x0070FB18 File Offset: 0x0070DD18
	private bool CheckOtherPositionState(float delta)
	{
		bool flag = FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) < 2200f;
		if (flag && FormationDataController.Instance.GlobalIsInFight)
		{
			this.InterruptAutoMoving("进战下体力值太低自动结束", true);
			return true;
		}
		bool result = false;
		CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
		if (unifiedComp != null && unifiedComp.PositionState == ECharPositionState.Air)
		{
			result = true;
			this.AutoMovingConfig.InAirTime += delta;
			if (this.AutoMovingConfig.InAirTime > this.AutoMovingConfig.AutoGlideTime)
			{
				this.InterruptAutoMoving("空中太久", true);
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					moveComp.TrySetGlide();
				}
			}
		}
		else
		{
			this.AutoMovingConfig.InAirTime = 0f;
		}
		CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
		if (unifiedComp2 == null || unifiedComp2.PositionState != ECharPositionState.Water)
		{
			CharacterUnifiedStateComponent unifiedComp3 = this.UnifiedComp;
			if (unifiedComp3 == null || unifiedComp3.PositionState != ECharPositionState.Climb)
			{
				this.AutoMovingConfig.InDelayExitTime = 0f;
				return result;
			}
		}
		result = true;
		this.AutoMovingConfig.InDelayExitTime += delta;
		if (this.AutoMovingConfig.InDelayExitTime > this.AutoMovingConfig.DelayExitTime)
		{
			this.InterruptAutoMoving("处于攀爬/游泳状态太久", true);
		}
		else if (flag)
		{
			CharacterUnifiedStateComponent unifiedComp4 = this.UnifiedComp;
			if (unifiedComp4 == null || unifiedComp4.MoveState != ECharMoveState.FastClimb)
			{
				CharacterUnifiedStateComponent unifiedComp5 = this.UnifiedComp;
				if (unifiedComp5 == null || unifiedComp5.MoveState != ECharMoveState.NormalClimb)
				{
					CharacterUnifiedStateComponent unifiedComp6 = this.UnifiedComp;
					if (unifiedComp6 == null || unifiedComp6.MoveState != ECharMoveState.NormalSwim)
					{
						CharacterUnifiedStateComponent unifiedComp7 = this.UnifiedComp;
						if (unifiedComp7 == null || unifiedComp7.MoveState != ECharMoveState.FastSwim)
						{
							return result;
						}
					}
				}
			}
			this.InterruptAutoMoving("体力值太低自动结束", true);
		}
		return result;
	}

	// Token: 0x0601A74B RID: 108363 RVA: 0x0070FCC0 File Offset: 0x0070DEC0
	public bool InterruptAutoMoving(string context, bool clear = true)
	{
		if (base.Entity == null)
		{
			return true;
		}
		if (this.AutoMovingConfig.GetAutoMovingState())
		{
			this.AutoMovingConfig.ResetAutoMovingState(context);
			return true;
		}
		if (clear)
		{
			this.AutoMovingConfig.ClearTimeAccumulation();
		}
		return false;
	}

	// Token: 0x0601A74C RID: 108364 RVA: 0x0070FCF6 File Offset: 0x0070DEF6
	public void SetAutoMovingConfig(InputContinuously value)
	{
		this.AutoMovingConfig.DeepCopy(value);
	}

	// Token: 0x0601A74D RID: 108365 RVA: 0x0070FD04 File Offset: 0x0070DF04
	public InputContinuously GetAutoMovingConfig()
	{
		return this.AutoMovingConfig;
	}

	// Token: 0x0601A74E RID: 108366 RVA: 0x0070FD0C File Offset: 0x0070DF0C
	private void CalculateMoveDirection(global::Vector outVector)
	{
		FVectorDouble fvectorDouble = Global.CharacterCameraManager.GetCameraRotation().VectorDouble();
		this.TempVector.DeepCopy(fvectorDouble);
		global::Vector gravityDirect = this.MoveComp.GravityDirect;
		global::Vector.VectorPlaneProject(this.TempVector, gravityDirect, outVector);
	}

	// Token: 0x0601A74F RID: 108367 RVA: 0x0070FD54 File Offset: 0x0070DF54
	private void CalculateMoveDirectionFromFightCamera(global::Vector outVector)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraRotation.Vector(this.TempVector);
		global::Vector gravityDirect = this.MoveComp.GravityDirect;
		global::Vector.VectorPlaneProject(this.TempVector, gravityDirect, outVector);
	}

	// Token: 0x0601A750 RID: 108368 RVA: 0x0070FD9E File Offset: 0x0070DF9E
	private void OnRoleDead()
	{
		this.InterruptAutoMoving("角色死亡", true);
	}

	// Token: 0x0601A751 RID: 108369 RVA: 0x0070FDAD File Offset: 0x0070DFAD
	private void OnSequenceNetworkStart(PlotInfo plotInfo)
	{
		if (plotInfo.PlotLevel == EPlotLevel.LevelA || plotInfo.PlotLevel == EPlotLevel.LevelB || plotInfo.PlotLevel == EPlotLevel.LevelC)
		{
			this.InterruptAutoMoving("进入剧情", true);
		}
	}

	// Token: 0x0601A752 RID: 108370 RVA: 0x0070FDD6 File Offset: 0x0070DFD6
	private void AutoMovingSettingChanged(bool value)
	{
		if (!value)
		{
			this.AutoMovingConfig.ResetAutoMovingState("退出自动奔跑模式");
		}
	}

	// Token: 0x0601A753 RID: 108371 RVA: 0x0070FDEC File Offset: 0x0070DFEC
	private void OnViewShow(EUiViewName viewName, int viewId)
	{
		UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(viewName);
		if (uiShowConfig != null && !uiShowConfig.Value.AllowAutoMoving)
		{
			this.InterruptAutoMoving("打开了UI" + viewName, true);
		}
	}

	// Token: 0x0601A754 RID: 108372 RVA: 0x0070FE37 File Offset: 0x0070E037
	private void CameraModeChanged(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
	{
		if (cameraName != "MainCamera")
		{
			return;
		}
		if (newMode == ECustomCameraMode.Sequence || newMode == ECustomCameraMode.Scene || newMode == ECustomCameraMode.Orbital || newMode == ECustomCameraMode.Free)
		{
			this.InterruptAutoMoving("CameraModeChange:" + newMode.ToString(), true);
		}
	}

	// Token: 0x0601A755 RID: 108373 RVA: 0x0070FE78 File Offset: 0x0070E078
	private void UpdateAutoSprint(bool autoMoving, float delta)
	{
		if (!this.CheckAutoSprintTagImmediately())
		{
			if (this.AutoSprintConfigTime == 0f)
			{
				this.AutoSprintConfigTime = (float)ConfigCommonParamById.GetIntConfig("AutoSprintTimerCondition").Value;
			}
			this.AutoSprintTime += delta;
			if (!autoMoving && this.AutoSprintTime < this.AutoSprintConfigTime)
			{
				return;
			}
			this.AutoSprintTime = 0f;
		}
		RoleGaitComponent component = base.Entity.GetComponent<RoleGaitComponent>();
		if (component != null && component.EnableRoleGaitState(ERoleGaitEnableType.Sprint))
		{
			CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
			if (unifiedComp == null || unifiedComp.MoveState != ECharMoveState.Run)
			{
				if (!autoMoving)
				{
					return;
				}
				CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
				if (unifiedComp2 == null || unifiedComp2.MoveState != ECharMoveState.Walk)
				{
					return;
				}
			}
			this.UnifiedComp.SprintPress();
			RoleAudioController.Instance.OnPlayAccelerateAudio(base.Entity, ECharMoveState.Sprint, ECharPositionState.Ground, null, null);
		}
	}

	// Token: 0x0601A756 RID: 108374 RVA: 0x0070FF58 File Offset: 0x0070E158
	[NullableContext(2)]
	public void EnableOverShoulderMode(OverShoulderModeConfig config)
	{
		if (config != null && !this.IsOverShoulderMode)
		{
			this.IsOverShoulderMode = true;
			this.OverShoulderConfig = config;
			BaseTagComponent tagComp = this.TagComp;
			this.SetOverShoulderSprintMode(tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]), true);
			this.AddChangeOverShoulderSprintModeListener();
			return;
		}
		if (config == null && this.IsOverShoulderMode)
		{
			this.IsOverShoulderMode = false;
			this.OverShoulderConfig = null;
			this.SetOverShoulderSprintMode(false, true);
			ITagTask changeOverShoulderSprintMode = this.ChangeOverShoulderSprintMode;
			if (changeOverShoulderSprintMode != null)
			{
				changeOverShoulderSprintMode.EndTask();
			}
			this.ChangeOverShoulderSprintMode = null;
		}
	}

	// Token: 0x0601A757 RID: 108375 RVA: 0x0070FFE6 File Offset: 0x0070E1E6
	private void AddChangeOverShoulderSprintModeListener()
	{
		BaseTagComponent tagComp = this.TagComp;
		this.ChangeOverShoulderSprintMode = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"]), delegate(int tagId, bool tagExists)
		{
			if (tagExists)
			{
				this.SetOverShoulderSprintMode(true, false);
				return;
			}
			this.SetOverShoulderSprintMode(false, false);
		}, null) : null);
	}

	// Token: 0x0601A758 RID: 108376 RVA: 0x00710021 File Offset: 0x0070E221
	public void TrySwitchOverShoulderSprintMode()
	{
		if (!this.IsOverShoulderMode)
		{
			return;
		}
		if (!this.IsOverShoulderSprint && !this.CanEnterOverShoulderSprintMode())
		{
			return;
		}
		this.SetOverShoulderSprintMode(!this.IsOverShoulderSprint, false);
	}

	// Token: 0x0601A759 RID: 108377 RVA: 0x00710050 File Offset: 0x0070E250
	private bool CanEnterOverShoulderSprintMode()
	{
		if (this.OverShoulderConfig == null)
		{
			return false;
		}
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp == null || stateComp.PositionState > ECharPositionState.Ground)
		{
			return false;
		}
		CharacterSkillComponent skillComponent = this.SkillComponent;
		if (((skillComponent != null) ? skillComponent.CurrentSkill : null) != null)
		{
			return false;
		}
		global::Vector moveDirectionCache = this.GetMoveDirectionCache();
		return !moveDirectionCache.IsNearlyZero(9.999999747378752E-05) && Math.Abs(moveDirectionCache.HeadingAngle() * 57.295780181884766) <= (double)this.OverShoulderConfig.SprintExitDegAbs;
	}

	// Token: 0x0601A75A RID: 108378 RVA: 0x007100D6 File Offset: 0x0070E2D6
	private void SetOverShoulderSprintMode(bool enable, bool force = false)
	{
		if (!force && this.IsOverShoulderSprint == enable)
		{
			return;
		}
		this.IsOverShoulderSprint = enable;
		if (enable)
		{
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp == null)
			{
				return;
			}
			stateComp.SprintPress();
			return;
		}
		else
		{
			CharacterUnifiedStateComponent stateComp2 = this.StateComp;
			if (stateComp2 == null)
			{
				return;
			}
			stateComp2.SprintRelease();
			return;
		}
	}

	// Token: 0x0601A75B RID: 108379 RVA: 0x00710110 File Offset: 0x0070E310
	private void SetInputFacingFromCameraDirection(float delta)
	{
		if (this.OverShoulderConfig == null)
		{
			return;
		}
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null)
		{
			stateComp.SetDirectionState(ECharDirectionState.CameraDirection);
		}
		Entity entity = base.Entity;
		if (entity != null)
		{
			BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.SetLockedRotation(true);
			}
		}
		this.CalculateMoveDirectionFromFightCamera(this.TempVector2);
		global::Vector gravityUp = this.ActorComp.MoveComp.GravityUp;
		if (!this.TempVector2.Normalize(9.99999993922529E-09))
		{
			this.TempVector2.DeepCopy(this.LastCameraDir);
		}
		else if (Math.Abs(this.TempVector2.DotProduct(gravityUp)) > 0.9999)
		{
			this.TempVector2.DeepCopy(this.LastCameraDir);
		}
		if (this.TempVector2.IsNearlyZero(9.999999747378752E-05) || this.TempVector2.Equals(this.ActorComp.ActorForwardProxy, 9.999999747378752E-05))
		{
			return;
		}
		this.LastCameraDir.DeepCopy(this.TempVector2);
		MathUtils.Instance.LookRotationForwardFirst(this.TempVector2, gravityUp, this.TempRotator);
		this.ActorComp.ActorQuatProxy.Inverse(this.TempQuat);
		this.TempQuat.Multiply(this.TempRotator.Quaternion(null), this.TempQuat2);
		float num = Math.Abs(MathUtils.Instance.WrapAngle((float)Math.Acos(this.TempQuat2.W) * 2f * 57.29578f));
		OverShoulderModeConfig overShoulderConfig = this.OverShoulderConfig;
		float lerpDegAlpha = overShoulderConfig.GetLerpDegAlpha(MathUtils.Instance.Clamp(num / overShoulderConfig.LerpBeginDeg, 0f, 1f));
		float num2 = MathUtils.Instance.Lerp(overShoulderConfig.MinTurnSpeed, overShoulderConfig.MaxTurnSpeed, lerpDegAlpha) * delta * 0.001f;
		float slerp = MathUtils.Instance.Clamp(num2 / num, 0f, 1f);
		Quat.Slerp(this.ActorComp.ActorQuatProxy, this.TempRotator.Quaternion(null), slerp, this.TempQuat);
		this.TempQuat.Rotator(this.TempRotator);
		this.TempRotator.Vector(this.TempVector2);
		this.ActorComp.SetInputFacing(this.TempVector2, true);
		this.ActorComp.SetActorRotation(this.TempRotator.ToUeRotator(), "SetInputFacingFromCameraDirection", false);
	}

	// Token: 0x0601A75C RID: 108380 RVA: 0x00710368 File Offset: 0x0070E568
	private void UpdateCharacterInputDirectAndFacingOverShoulderMode(float delta)
	{
		global::Vector vector = global::Vector.ZeroVectorProxy;
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.Valid)
		{
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp != null && stateComp.Valid)
			{
				bool flag = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为改变.保持输入"]);
				bool flag2 = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]);
				vector = this.GetWorldMoveDirectionCache();
				if (vector.IsNearlyZero(9.999999747378752E-05) && flag)
				{
					vector = this.ActorComp.InputDirectProxy;
					if (vector.IsNearlyZero(9.999999747378752E-05))
					{
						vector = this.ActorComp.ActorForwardProxy;
					}
				}
				if (!flag2)
				{
					bool flag3 = false;
					CharacterUnifiedStateComponent unifiedComp = this.UnifiedComp;
					if (unifiedComp != null && unifiedComp.MoveState == ECharMoveState.Stand)
					{
						if (vector.IsNearlyZero(9.999999747378752E-05))
						{
							this.StandInputDelayCountDown = 200f;
							this.CacheStandInputDirect.Reset();
							flag3 = true;
						}
						else if (this.StandInputDelayCountDown > 0f)
						{
							this.StandInputDelayCountDown -= delta;
							this.CacheStandInputDirect.DeepCopy(vector);
							flag3 = true;
						}
					}
					if (!flag3)
					{
						this.CacheStandInputDirect.Reset();
						this.CommitMoveInput(vector, !this.IsLocalInputInternal);
					}
					ECharPositionState positionState = this.StateComp.PositionState;
					switch (positionState)
					{
					case ECharPositionState.Ground:
						this.SetInputFacingOnGroundFromCameraDirection(delta);
						return;
					case ECharPositionState.Climb:
						return;
					case ECharPositionState.Air:
						if (this.StateComp.MoveState == ECharMoveState.WalkOnAir)
						{
							this.SetInputFacingOnGroundFromCameraDirection(delta);
							return;
						}
						return;
					case ECharPositionState.Water:
						break;
					default:
						if (positionState != ECharPositionState.Floating)
						{
							return;
						}
						break;
					}
					this.SetInputFacingFromCameraDirection(delta);
					return;
				}
				this.CommitMoveInput(vector, true);
				if (this.LockInputRotator())
				{
					this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
					return;
				}
				this.SetInputFacingFromCameraDirection(delta);
				return;
			}
		}
		vector = this.GetWorldMoveDirectionCache();
		this.CommitMoveInput(vector, true);
		this.SetInputFacingFromCameraDirection(delta);
	}

	// Token: 0x0601A75D RID: 108381 RVA: 0x00710548 File Offset: 0x0070E748
	private void SetInputFacingOnGroundFromCameraDirection(float delta)
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]))
		{
			this.SetOverShoulderSprintMode(false, false);
			this.SetInputFacingFromCameraDirection(delta);
			return;
		}
		if (!this.CanEnterOverShoulderSprintMode())
		{
			this.SetOverShoulderSprintMode(false, false);
		}
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null)
		{
			stateComp.SetDirectionState(ECharDirectionState.FaceDirection);
		}
		Entity entity = base.Entity;
		if (entity != null)
		{
			BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.SetLockedRotation(false);
			}
		}
		this.SetInputFacingFromInputDirect(true);
	}

	// Token: 0x0601A75E RID: 108382 RVA: 0x007105CE File Offset: 0x0070E7CE
	public static void CreateStaticDefaultValue()
	{
		CharacterInputComponent.HoldPressMap = new Dictionary<CSharpScript.Game.Input.EInputAction, bool>();
	}

	// Token: 0x0601A75F RID: 108383 RVA: 0x007105DA File Offset: 0x0070E7DA
	public static void ResetStaticDefaultValue()
	{
		CharacterInputComponent.HoldPressMap = null;
	}

	// Token: 0x0601A760 RID: 108384 RVA: 0x007105E4 File Offset: 0x0070E7E4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterInputComponent characterInputComponent = (CharacterInputComponent)componentTemplate;
		if (base.CanResetComponentProperty("TempVector") && characterInputComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempVector2") && characterInputComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempRotator") && characterInputComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempQuat") && characterInputComponent.TempQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TempQuat), "TempQuat"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempQuat2") && characterInputComponent.TempQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TempQuat2), "TempQuat2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterInputComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AbilityComp"))
		{
			if (characterInputComponent.AbilityComp == null)
			{
				this.AbilityComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAbilityComponent>(this.AbilityComp), "AbilityComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterInputComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (characterInputComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComponent"))
		{
			if (characterInputComponent.SkillComponent == null)
			{
				this.SkillComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComponent), "SkillComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterInputComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedComp"))
		{
			if (characterInputComponent.UnifiedComp == null)
			{
				this.UnifiedComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedComp), "UnifiedComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CharacterInternal"))
		{
			if (characterInputComponent.CharacterInternal == null)
			{
				this.CharacterInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.CharacterInternal), "CharacterInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CharacterControllerInternal"))
		{
			if (characterInputComponent.CharacterControllerInternal == null)
			{
				this.CharacterControllerInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_CharacterController_C>(this.CharacterControllerInternal), "CharacterControllerInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputLayer"))
		{
			if (characterInputComponent.InputLayer == null)
			{
				this.InputLayer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputLayer>(this.InputLayer), "InputLayer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ExtraInputLayer"))
		{
			if (characterInputComponent.ExtraInputLayer == null)
			{
				this.ExtraInputLayer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ExtraInputLayer>(this.ExtraInputLayer), "ExtraInputLayer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputEvents") && characterInputComponent.InputEvents != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<InputEvent>>(this.InputEvents), "InputEvents"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InputCaches") && characterInputComponent.InputCaches != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<InputCache>>(this.InputCaches), "InputCaches"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AxisValues") && characterInputComponent.AxisValues != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EInputAxis, float>>(this.AxisValues), "AxisValues"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InputGroup"))
		{
			if (characterInputComponent.InputGroup == null)
			{
				this.InputGroup = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<InputFilter>(this.InputGroup), "InputGroup"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveVectorCache") && characterInputComponent.MoveVectorCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.MoveVectorCache), "MoveVectorCache"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ProcessedMoveInput") && characterInputComponent.ProcessedMoveInput != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ProcessedMoveInput), "ProcessedMoveInput"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InputAngleRanges"))
		{
			if (characterInputComponent.InputAngleRanges == null)
			{
				this.InputAngleRanges = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<InputAngleRange[]>(this.InputAngleRanges), "InputAngleRanges"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveInputOuterRingEnableCount"))
		{
			this.MoveInputOuterRingEnableCount = characterInputComponent.MoveInputOuterRingEnableCount;
		}
		if (base.CanResetComponentProperty("MoveDirectionCache") && characterInputComponent.MoveDirectionCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.MoveDirectionCache), "MoveDirectionCache"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("WorldMoveDirectionCache") && characterInputComponent.WorldMoveDirectionCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.WorldMoveDirectionCache), "WorldMoveDirectionCache"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsLocalInputInternal"))
		{
			this.IsLocalInputInternal = characterInputComponent.IsLocalInputInternal;
		}
		if (base.CanResetComponentProperty("IsOnlyAllowFightInputInternal"))
		{
			this.IsOnlyAllowFightInputInternal = characterInputComponent.IsOnlyAllowFightInputInternal;
		}
		if (base.CanResetComponentProperty("LastMovementInputTime"))
		{
			this.LastMovementInputTime = characterInputComponent.LastMovementInputTime;
		}
		if (base.CanResetComponentProperty("CommandTimeMap") && characterInputComponent.CommandTimeMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<ECommandType, double>>(this.CommandTimeMap), "CommandTimeMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DisableHandle"))
		{
			this.DisableHandle = characterInputComponent.DisableHandle;
		}
		if (base.CanResetComponentProperty("AutomaticFlightMode"))
		{
			this.AutomaticFlightMode = characterInputComponent.AutomaticFlightMode;
		}
		if (base.CanResetComponentProperty("AutomaticFlightDataAsset"))
		{
			if (characterInputComponent.AutomaticFlightDataAsset == null)
			{
				this.AutomaticFlightDataAsset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AutomaticFlightData>(this.AutomaticFlightDataAsset), "AutomaticFlightDataAsset"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AutomaticFlightModeTimeCache"))
		{
			this.AutomaticFlightModeTimeCache = characterInputComponent.AutomaticFlightModeTimeCache;
		}
		if (base.CanResetComponentProperty("CameraDrivenAutoFlightMode"))
		{
			this.CameraDrivenAutoFlightMode = characterInputComponent.CameraDrivenAutoFlightMode;
		}
		if (base.CanResetComponentProperty("CameraDrivenAutoFlightDataAsset"))
		{
			if (characterInputComponent.CameraDrivenAutoFlightDataAsset == null)
			{
				this.CameraDrivenAutoFlightDataAsset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraDrivenAutoFlightData>(this.CameraDrivenAutoFlightDataAsset), "CameraDrivenAutoFlightDataAsset"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsInCameraDrivenAutoFlight"))
		{
			this.IsInCameraDrivenAutoFlight = characterInputComponent.IsInCameraDrivenAutoFlight;
		}
		if (base.CanResetComponentProperty("IsStartCameraDrivenAutoFlightTick"))
		{
			this.IsStartCameraDrivenAutoFlightTick = characterInputComponent.IsStartCameraDrivenAutoFlightTick;
		}
		if (base.CanResetComponentProperty("CameraDrivenAutoFlightTime"))
		{
			this.CameraDrivenAutoFlightTime = characterInputComponent.CameraDrivenAutoFlightTime;
		}
		if (base.CanResetComponentProperty("MoveDirectionDistanceMin"))
		{
			this.MoveDirectionDistanceMin = characterInputComponent.MoveDirectionDistanceMin;
		}
		if (base.CanResetComponentProperty("MoveDirectionDistanceMax"))
		{
			this.MoveDirectionDistanceMax = characterInputComponent.MoveDirectionDistanceMax;
		}
		if (base.CanResetComponentProperty("MovementDirectionAngleThreshold"))
		{
			this.MovementDirectionAngleThreshold = characterInputComponent.MovementDirectionAngleThreshold;
		}
		if (base.CanResetComponentProperty("StandInputDelayCountDown"))
		{
			this.StandInputDelayCountDown = characterInputComponent.StandInputDelayCountDown;
		}
		if (base.CanResetComponentProperty("CacheStandInputDirect"))
		{
			if (characterInputComponent.CacheStandInputDirect == null)
			{
				this.CacheStandInputDirect = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheStandInputDirect), "CacheStandInputDirect"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NextFrameClear"))
		{
			this.NextFrameClear = characterInputComponent.NextFrameClear;
		}
		if (base.CanResetComponentProperty("NextFrameClearAxis") && characterInputComponent.NextFrameClearAxis != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EInputAxis>(this.NextFrameClearAxis), "NextFrameClearAxis"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("LastShowMouseCursor"))
		{
			this.LastShowMouseCursor = characterInputComponent.LastShowMouseCursor;
		}
		if (base.CanResetComponentProperty("TestInputEvent") && characterInputComponent.TestInputEvent != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<InputEvent>>(this.TestInputEvent), "TestInputEvent"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CameraInputQuat") && characterInputComponent.CameraInputQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.CameraInputQuat), "CameraInputQuat"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("PhotoMoveInput") && characterInputComponent.PhotoMoveInput != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.PhotoMoveInput), "PhotoMoveInput"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CurrentMoveDirection") && characterInputComponent.CurrentMoveDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CurrentMoveDirection), "CurrentMoveDirection"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagEventJump"))
		{
			if (characterInputComponent.TagEventJump == null)
			{
				this.TagEventJump = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventJump), "TagEventJump"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventClimb"))
		{
			if (characterInputComponent.TagEventClimb == null)
			{
				this.TagEventClimb = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventClimb), "TagEventClimb"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventAttack"))
		{
			if (characterInputComponent.TagEventAttack == null)
			{
				this.TagEventAttack = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventAttack), "TagEventAttack"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventDodge"))
		{
			if (characterInputComponent.TagEventDodge == null)
			{
				this.TagEventDodge = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventDodge), "TagEventDodge"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventSkill"))
		{
			if (characterInputComponent.TagEventSkill == null)
			{
				this.TagEventSkill = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventSkill), "TagEventSkill"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventVision1"))
		{
			if (characterInputComponent.TagEventVision1 == null)
			{
				this.TagEventVision1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventVision1), "TagEventVision1"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventUltimateSkill"))
		{
			if (characterInputComponent.TagEventUltimateSkill == null)
			{
				this.TagEventUltimateSkill = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventUltimateSkill), "TagEventUltimateSkill"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventVision2"))
		{
			if (characterInputComponent.TagEventVision2 == null)
			{
				this.TagEventVision2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventVision2), "TagEventVision2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventChangeRoll1"))
		{
			if (characterInputComponent.TagEventChangeRoll1 == null)
			{
				this.TagEventChangeRoll1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventChangeRoll1), "TagEventChangeRoll1"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventChangeRoll2"))
		{
			if (characterInputComponent.TagEventChangeRoll2 == null)
			{
				this.TagEventChangeRoll2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventChangeRoll2), "TagEventChangeRoll2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventChangeRoll3"))
		{
			if (characterInputComponent.TagEventChangeRoll3 == null)
			{
				this.TagEventChangeRoll3 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventChangeRoll3), "TagEventChangeRoll3"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventLock"))
		{
			if (characterInputComponent.TagEventLock == null)
			{
				this.TagEventLock = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventLock), "TagEventLock"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventAim"))
		{
			if (characterInputComponent.TagEventAim == null)
			{
				this.TagEventAim = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventAim), "TagEventAim"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventMove"))
		{
			if (characterInputComponent.TagEventMove == null)
			{
				this.TagEventMove = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventMove), "TagEventMove"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsMoveAxisToButtonEnabled"))
		{
			this.IsMoveAxisToButtonEnabled = characterInputComponent.IsMoveAxisToButtonEnabled;
		}
		if (base.CanResetComponentProperty("MoveAxisToButtonLogic"))
		{
			if (characterInputComponent.MoveAxisToButtonLogic == null)
			{
				this.MoveAxisToButtonLogic = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MoveInputSimButtonLogic>(this.MoveAxisToButtonLogic), "MoveAxisToButtonLogic"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentMoveAxisToButtonConfig"))
		{
			if (characterInputComponent.CurrentMoveAxisToButtonConfig == null)
			{
				this.CurrentMoveAxisToButtonConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SInputActive>(this.CurrentMoveAxisToButtonConfig), "CurrentMoveAxisToButtonConfig"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveAxisToButtonActiveCondition"))
		{
			if (characterInputComponent.MoveAxisToButtonActiveCondition == null)
			{
				this.MoveAxisToButtonActiveCondition = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<InputActiveCondition>(this.MoveAxisToButtonActiveCondition), "MoveAxisToButtonActiveCondition"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InCameraFollowInput"))
		{
			this.InCameraFollowInput = characterInputComponent.InCameraFollowInput;
		}
		if (base.CanResetComponentProperty("CameraFollowInputTagTasks") && characterInputComponent.CameraFollowInputTagTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.CameraFollowInputTagTasks), "CameraFollowInputTagTasks"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagToDaPathMap") && characterInputComponent.TagToDaPathMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, string>>(this.TagToDaPathMap), "TagToDaPathMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CameraFollowInputLockRunState"))
		{
			this.CameraFollowInputLockRunState = characterInputComponent.CameraFollowInputLockRunState;
		}
		if (base.CanResetComponentProperty("CameraFollowInputInSprintState"))
		{
			this.CameraFollowInputInSprintState = characterInputComponent.CameraFollowInputInSprintState;
		}
		if (base.CanResetComponentProperty("CameraFollowInputConfig"))
		{
			if (characterInputComponent.CameraFollowInputConfig == null)
			{
				this.CameraFollowInputConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraFollowInputConfig>(this.CameraFollowInputConfig), "CameraFollowInputConfig"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UseActorRelativeMoveInput"))
		{
			this.UseActorRelativeMoveInput = characterInputComponent.UseActorRelativeMoveInput;
		}
		if (base.CanResetComponentProperty("InvertMoveForward"))
		{
			this.InvertMoveForward = characterInputComponent.InvertMoveForward;
		}
		if (base.CanResetComponentProperty("InvertMoveRight"))
		{
			this.InvertMoveRight = characterInputComponent.InvertMoveRight;
		}
		if (base.CanResetComponentProperty("AutoMovingConfigInternal"))
		{
			if (characterInputComponent.AutoMovingConfigInternal == null)
			{
				this.AutoMovingConfigInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<InputContinuously>(this.AutoMovingConfigInternal), "AutoMovingConfigInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AutoSprintTime"))
		{
			this.AutoSprintTime = characterInputComponent.AutoSprintTime;
		}
		if (base.CanResetComponentProperty("AutoSprintConfigTime"))
		{
			this.AutoSprintConfigTime = characterInputComponent.AutoSprintConfigTime;
		}
		if (base.CanResetComponentProperty("IsOverShoulderMode"))
		{
			this.IsOverShoulderMode = characterInputComponent.IsOverShoulderMode;
		}
		if (base.CanResetComponentProperty("IsOverShoulderSprint"))
		{
			this.IsOverShoulderSprint = characterInputComponent.IsOverShoulderSprint;
		}
		if (base.CanResetComponentProperty("ChangeOverShoulderSprintMode"))
		{
			if (characterInputComponent.ChangeOverShoulderSprintMode == null)
			{
				this.ChangeOverShoulderSprintMode = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.ChangeOverShoulderSprintMode), "ChangeOverShoulderSprintMode"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OverShoulderConfig"))
		{
			if (characterInputComponent.OverShoulderConfig == null)
			{
				this.OverShoulderConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<OverShoulderModeConfig>(this.OverShoulderConfig), "OverShoulderConfig"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastCameraDir"))
		{
			if (characterInputComponent.LastCameraDir == null)
			{
				this.LastCameraDir = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastCameraDir), "LastCameraDir"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CA9E RID: 51870
	private const int ZERO_TIME = 0;

	// Token: 0x0400CA9F RID: 51871
	private const int NULL_CONFIG_TIME = -1;

	// Token: 0x0400CAA0 RID: 51872
	private const int INVALID_PRIORITY = -1;

	// Token: 0x0400CAA1 RID: 51873
	private const int INVALID_PRIORITY_INDEX = -1;

	// Token: 0x0400CAA2 RID: 51874
	private const int INVALID_INPUT_TIME = -1;

	// Token: 0x0400CAA3 RID: 51875
	private const float MOVE_VECTOR_CACHE_TIME = 100f;

	// Token: 0x0400CAA4 RID: 51876
	private const float EXIT_CLIMB_BLOCK_ATTACK_RELEASE_TIME = 0.25f;

	// Token: 0x0400CAA5 RID: 51877
	public const int CAMERA_FOLLOW_FORWARD_ANGLE = 50;

	// Token: 0x0400CAA6 RID: 51878
	private const string FIRST_PERSON_CONFIG_MAP_PATH = "/Game/Aki/Character/Role/Common/Data/DA/DA_FirstPersonConfigMap.DA_FirstPersonConfigMap";

	// Token: 0x0400CAA7 RID: 51879
	private const float LOW_STRENGTH_EXIT_VALUE = 2200f;

	// Token: 0x0400CAA8 RID: 51880
	private const float STAND_INPUT_DELAY = 200f;

	// Token: 0x0400CAA9 RID: 51881
	private const float STAND_INPUT_TURN_THRESHOLD = 0.5f;

	// Token: 0x0400CAAA RID: 51882
	private const float FACING_INPUT_THRESHOLD_IN_LOCK_MODE = 60f;

	// Token: 0x0400CAAB RID: 51883
	[StaticVariableRuleIgnore]
	private static readonly ESkillGenre[] interruptAutoMoving = new ESkillGenre[]
	{
		ESkillGenre.普攻0,
		ESkillGenre.蓄力1,
		ESkillGenre.E技能2,
		ESkillGenre.大招3,
		ESkillGenre.QTE4,
		ESkillGenre.极限闪避反击5,
		ESkillGenre.极限闪避7,
		ESkillGenre.被动技能8,
		ESkillGenre.战斗幻象技9
	};

	// Token: 0x0400CAAC RID: 51884
	[StaticVariableRuleIgnore]
	private static readonly Stat GetCommandStat = Stat.Create("CharacterInputComponent.GetCommand", "", "");

	// Token: 0x0400CAAD RID: 51885
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteCommandStat = Stat.Create("CharacterInputComponent.ExecuteCommand", "", "");

	// Token: 0x0400CAAE RID: 51886
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchPressEventStat = Stat.Create("CharacterInputComponent.DispatchPressEvent", "", "");

	// Token: 0x0400CAAF RID: 51887
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchReleaseEventStat = Stat.Create("CharacterInputComponent.DispatchReleaseEvent", "", "");

	// Token: 0x0400CAB0 RID: 51888
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressStat = Stat.Create("CharacterInputComponent.HandlePress", "", "");

	// Token: 0x0400CAB1 RID: 51889
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseStat = Stat.Create("CharacterInputComponent.HandleRelease", "", "");

	// Token: 0x0400CAB2 RID: 51890
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400CAB3 RID: 51891
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400CAB4 RID: 51892
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400CAB5 RID: 51893
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CAB6 RID: 51894
	private readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CAB7 RID: 51895
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CAB8 RID: 51896
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComp;

	// Token: 0x0400CAB9 RID: 51897
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CABA RID: 51898
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400CABB RID: 51899
	[Nullable(2)]
	private CharacterSkillComponent SkillComponent;

	// Token: 0x0400CABC RID: 51900
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CABD RID: 51901
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CABE RID: 51902
	[Nullable(2)]
	private TsBaseCharacter CharacterInternal;

	// Token: 0x0400CABF RID: 51903
	[Nullable(2)]
	private BP_CharacterController_C CharacterControllerInternal;

	// Token: 0x0400CAC0 RID: 51904
	[Nullable(2)]
	private CharacterInputLayer InputLayer;

	// Token: 0x0400CAC1 RID: 51905
	[Nullable(2)]
	private ExtraInputLayer ExtraInputLayer;

	// Token: 0x0400CAC2 RID: 51906
	private readonly List<InputEvent> InputEvents = new List<InputEvent>();

	// Token: 0x0400CAC3 RID: 51907
	private readonly List<InputCache> InputCaches = new List<InputCache>();

	// Token: 0x0400CAC4 RID: 51908
	private readonly Dictionary<EInputAxis, float> AxisValues = new Dictionary<EInputAxis, float>();

	// Token: 0x0400CAC5 RID: 51909
	[Nullable(2)]
	private InputFilter InputGroup;

	// Token: 0x0400CAC6 RID: 51910
	private readonly global::Vector MoveVectorCache = global::Vector.Create();

	// Token: 0x0400CAC7 RID: 51911
	private readonly global::Vector ProcessedMoveInput = global::Vector.Create();

	// Token: 0x0400CAC8 RID: 51912
	[Nullable(2)]
	private InputAngleRange[] InputAngleRanges;

	// Token: 0x0400CAC9 RID: 51913
	private int MoveInputOuterRingEnableCount;

	// Token: 0x0400CACA RID: 51914
	private readonly global::Vector MoveDirectionCache = global::Vector.Create();

	// Token: 0x0400CACB RID: 51915
	private readonly global::Vector WorldMoveDirectionCache = global::Vector.Create();

	// Token: 0x0400CACC RID: 51916
	private bool IsLocalInputInternal;

	// Token: 0x0400CACD RID: 51917
	private bool IsOnlyAllowFightInputInternal;

	// Token: 0x0400CACE RID: 51918
	private double LastMovementInputTime = -1.0;

	// Token: 0x0400CACF RID: 51919
	private static Dictionary<CSharpScript.Game.Input.EInputAction, bool> HoldPressMap;

	// Token: 0x0400CAD0 RID: 51920
	private readonly Dictionary<ECommandType, double> CommandTimeMap = new Dictionary<ECommandType, double>();

	// Token: 0x0400CAD1 RID: 51921
	private int? DisableHandle;

	// Token: 0x0400CAD2 RID: 51922
	private bool AutomaticFlightMode;

	// Token: 0x0400CAD3 RID: 51923
	[Nullable(2)]
	private AutomaticFlightData AutomaticFlightDataAsset;

	// Token: 0x0400CAD4 RID: 51924
	private float AutomaticFlightModeTimeCache;

	// Token: 0x0400CAD5 RID: 51925
	private bool CameraDrivenAutoFlightMode;

	// Token: 0x0400CAD6 RID: 51926
	[Nullable(2)]
	private CameraDrivenAutoFlightData CameraDrivenAutoFlightDataAsset;

	// Token: 0x0400CAD7 RID: 51927
	private bool IsInCameraDrivenAutoFlight;

	// Token: 0x0400CAD8 RID: 51928
	private bool IsStartCameraDrivenAutoFlightTick;

	// Token: 0x0400CAD9 RID: 51929
	private float CameraDrivenAutoFlightTime;

	// Token: 0x0400CADA RID: 51930
	private float MoveDirectionDistanceMin;

	// Token: 0x0400CADB RID: 51931
	private float MoveDirectionDistanceMax;

	// Token: 0x0400CADC RID: 51932
	private float MovementDirectionAngleThreshold;

	// Token: 0x0400CADD RID: 51933
	private float StandInputDelayCountDown;

	// Token: 0x0400CADE RID: 51934
	private global::Vector CacheStandInputDirect = new global::Vector();

	// Token: 0x0400CADF RID: 51935
	private bool NextFrameClear;

	// Token: 0x0400CAE0 RID: 51936
	private readonly HashSet<EInputAxis> NextFrameClearAxis = new HashSet<EInputAxis>();

	// Token: 0x0400CAE1 RID: 51937
	private bool LastShowMouseCursor;

	// Token: 0x0400CAE2 RID: 51938
	private readonly List<InputEvent> TestInputEvent = new List<InputEvent>();

	// Token: 0x0400CAE3 RID: 51939
	private readonly Quat CameraInputQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CAE4 RID: 51940
	private readonly global::Vector PhotoMoveInput = global::Vector.Create();

	// Token: 0x0400CAE5 RID: 51941
	private readonly global::Vector CurrentMoveDirection = global::Vector.Create();

	// Token: 0x0400CAE6 RID: 51942
	[Nullable(2)]
	private ITagTask TagEventJump;

	// Token: 0x0400CAE7 RID: 51943
	[Nullable(2)]
	private ITagTask TagEventClimb;

	// Token: 0x0400CAE8 RID: 51944
	[Nullable(2)]
	private ITagTask TagEventAttack;

	// Token: 0x0400CAE9 RID: 51945
	[Nullable(2)]
	private ITagTask TagEventDodge;

	// Token: 0x0400CAEA RID: 51946
	[Nullable(2)]
	private ITagTask TagEventSkill;

	// Token: 0x0400CAEB RID: 51947
	[Nullable(2)]
	private ITagTask TagEventVision1;

	// Token: 0x0400CAEC RID: 51948
	[Nullable(2)]
	private ITagTask TagEventUltimateSkill;

	// Token: 0x0400CAED RID: 51949
	[Nullable(2)]
	private ITagTask TagEventVision2;

	// Token: 0x0400CAEE RID: 51950
	[Nullable(2)]
	private ITagTask TagEventChangeRoll1;

	// Token: 0x0400CAEF RID: 51951
	[Nullable(2)]
	private ITagTask TagEventChangeRoll2;

	// Token: 0x0400CAF0 RID: 51952
	[Nullable(2)]
	private ITagTask TagEventChangeRoll3;

	// Token: 0x0400CAF1 RID: 51953
	[Nullable(2)]
	private ITagTask TagEventLock;

	// Token: 0x0400CAF2 RID: 51954
	[Nullable(2)]
	private ITagTask TagEventAim;

	// Token: 0x0400CAF3 RID: 51955
	[Nullable(2)]
	private ITagTask TagEventMove;

	// Token: 0x0400CAF4 RID: 51956
	private bool IsMoveAxisToButtonEnabled;

	// Token: 0x0400CAF5 RID: 51957
	[Nullable(2)]
	private MoveInputSimButtonLogic MoveAxisToButtonLogic;

	// Token: 0x0400CAF6 RID: 51958
	[Nullable(2)]
	private SInputActive CurrentMoveAxisToButtonConfig;

	// Token: 0x0400CAF7 RID: 51959
	[Nullable(2)]
	private InputActiveCondition MoveAxisToButtonActiveCondition;

	// Token: 0x0400CAF8 RID: 51960
	private bool InCameraFollowInput;

	// Token: 0x0400CAF9 RID: 51961
	private readonly List<ITagTask> CameraFollowInputTagTasks = new List<ITagTask>();

	// Token: 0x0400CAFA RID: 51962
	private readonly Dictionary<int, string> TagToDaPathMap = new Dictionary<int, string>();

	// Token: 0x0400CAFB RID: 51963
	private bool CameraFollowInputLockRunState;

	// Token: 0x0400CAFC RID: 51964
	private bool CameraFollowInputInSprintState;

	// Token: 0x0400CAFD RID: 51965
	[Nullable(2)]
	private CameraFollowInputConfig CameraFollowInputConfig;

	// Token: 0x0400CAFE RID: 51966
	private bool UseActorRelativeMoveInput;

	// Token: 0x0400CAFF RID: 51967
	private bool InvertMoveForward;

	// Token: 0x0400CB00 RID: 51968
	private bool InvertMoveRight;

	// Token: 0x0400CB01 RID: 51969
	[Nullable(2)]
	private InputContinuously AutoMovingConfigInternal;

	// Token: 0x0400CB02 RID: 51970
	private float AutoSprintTime;

	// Token: 0x0400CB03 RID: 51971
	private float AutoSprintConfigTime;

	// Token: 0x0400CB04 RID: 51972
	private bool IsOverShoulderMode;

	// Token: 0x0400CB05 RID: 51973
	private bool IsOverShoulderSprint;

	// Token: 0x0400CB06 RID: 51974
	[Nullable(2)]
	private ITagTask ChangeOverShoulderSprintMode;

	// Token: 0x0400CB07 RID: 51975
	[Nullable(2)]
	private OverShoulderModeConfig OverShoulderConfig;

	// Token: 0x0400CB08 RID: 51976
	private global::Vector LastCameraDir = global::Vector.Create();
}
