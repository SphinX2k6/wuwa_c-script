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

// Token: 0x020025CA RID: 9674
[NullableContext(1)]
[Nullable(0)]
public class CharacterInputComponent : EntityComponent, IInputHandler, IStaticVariableResetter
{
	// Token: 0x06018078 RID: 98424 RVA: 0x0073234C File Offset: 0x0073054C
	static CharacterInputComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterInputComponent.CreateStaticDefaultValue), new Action(CharacterInputComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700259B RID: 9627
	// (get) Token: 0x06018079 RID: 98425 RVA: 0x00732423 File Offset: 0x00730623
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent)
			};
		}
	}

	// Token: 0x1700259C RID: 9628
	// (get) Token: 0x0601807A RID: 98426 RVA: 0x00732438 File Offset: 0x00730638
	// (set) Token: 0x0601807B RID: 98427 RVA: 0x00732440 File Offset: 0x00730640
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

	// Token: 0x0601807C RID: 98428 RVA: 0x0073244C File Offset: 0x0073064C
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

	// Token: 0x0601807D RID: 98429 RVA: 0x0073249E File Offset: 0x0073069E
	private void OnCharPossessed(Entity entity, [Nullable(2)] AController newController)
	{
		this.SetCharacterController(newController as BP_CharacterController_C);
		InputController.Instance.AddInputHandler(this);
	}

	// Token: 0x0601807E RID: 98430 RVA: 0x007324B7 File Offset: 0x007306B7
	private void OnCharUnpossessed(Entity entity, [Nullable(2)] AController oldController)
	{
		this.InputEvents.Clear();
		this.InputCaches.Clear();
		this.AxisValues.Clear();
		this.SetCharacterController(null);
		InputController.Instance.RemoveInputHandler(this);
	}

	// Token: 0x0601807F RID: 98431 RVA: 0x007324EC File Offset: 0x007306EC
	private void OnPositionStateChanged(ECharPositionState oldPositionState, ECharPositionState newPositionState)
	{
		this.UpdateCharacterInputDirectAndFacing(0f);
	}

	// Token: 0x06018080 RID: 98432 RVA: 0x007324F9 File Offset: 0x007306F9
	private void CharOnRoleDrownInjure(bool isTargetKilled)
	{
		this.ClearInputCaches("CharOnRoleDrownInjure");
	}

	// Token: 0x06018081 RID: 98433 RVA: 0x00732508 File Offset: 0x00730708
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

	// Token: 0x06018082 RID: 98434 RVA: 0x0073256E File Offset: 0x0073076E
	public int GetPriority()
	{
		return 0;
	}

	// Token: 0x06018083 RID: 98435 RVA: 0x00732571 File Offset: 0x00730771
	public InputFilter GetInputFilter()
	{
		return this.InputGroup;
	}

	// Token: 0x06018084 RID: 98436 RVA: 0x0073257C File Offset: 0x0073077C
	public void HandlePressEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!BattleInputModel.Instance.GetInputEnable(action))
		{
			return;
		}
		this.InputEvents.Add(new InputEvent(action, EInputState.Press, time, 0f));
		foreach (ICharacterInputObserver characterInputObserver in this.InputObservers)
		{
			try
			{
				characterInputObserver.OnInputPress(action, time);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.LXH;
				string message = "角色输入按下观察器执行异常";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x06018085 RID: 98437 RVA: 0x00732634 File Offset: 0x00730834
	public void ForcePushPressEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		this.InputEvents.Add(new InputEvent(action, EInputState.Press, time, 0f));
	}

	// Token: 0x06018086 RID: 98438 RVA: 0x00732650 File Offset: 0x00730850
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
		foreach (ICharacterInputObserver characterInputObserver in this.InputObservers)
		{
			try
			{
				characterInputObserver.OnInputRelease(action, time);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.LXH;
				string message = "角色输入抬起观察器执行异常";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x06018087 RID: 98439 RVA: 0x00732720 File Offset: 0x00730920
	public void HandleHoldEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!BattleInputModel.Instance.GetInputEnable(action))
		{
			return;
		}
		this.InputEvents.Add(new InputEvent(action, EInputState.Hold, time, 0f));
	}

	// Token: 0x06018088 RID: 98440 RVA: 0x00732748 File Offset: 0x00730948
	public void AddInputObserver(ICharacterInputObserver observer)
	{
		this.InputObservers.Add(observer);
	}

	// Token: 0x06018089 RID: 98441 RVA: 0x00732757 File Offset: 0x00730957
	public void RemoveInputObserver(ICharacterInputObserver observer)
	{
		this.InputObservers.Remove(observer);
	}

	// Token: 0x0601808A RID: 98442 RVA: 0x00732768 File Offset: 0x00730968
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

	// Token: 0x0601808B RID: 98443 RVA: 0x007327AE File Offset: 0x007309AE
	public void ClearInputAxis(bool nextFrame)
	{
		this.ClearInputAxis(nextFrame, false);
	}

	// Token: 0x0601808C RID: 98444 RVA: 0x007327B8 File Offset: 0x007309B8
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

	// Token: 0x0601808D RID: 98445 RVA: 0x0073280D File Offset: 0x00730A0D
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

	// Token: 0x0601808E RID: 98446 RVA: 0x0073284B File Offset: 0x00730A4B
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

	// Token: 0x0601808F RID: 98447 RVA: 0x0073286C File Offset: 0x00730A6C
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

	// Token: 0x06018090 RID: 98448 RVA: 0x00732920 File Offset: 0x00730B20
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

	// Token: 0x06018091 RID: 98449 RVA: 0x00732A94 File Offset: 0x00730C94
	public void TestActionInput(CSharpScript.Game.Input.EInputAction action, EInputState state, float time)
	{
		InputEvent item = new InputEvent(action, state, time, 0f);
		this.TestInputEvent.Add(item);
	}

	// Token: 0x06018092 RID: 98450 RVA: 0x00732ABC File Offset: 0x00730CBC
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

	// Token: 0x06018093 RID: 98451 RVA: 0x00732B94 File Offset: 0x00730D94
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

	// Token: 0x06018094 RID: 98452 RVA: 0x00732C38 File Offset: 0x00730E38
	public void SetMoveVectorCache(global::Vector input, global::Vector worldInput)
	{
		this.MoveDirectionCache.DeepCopy(input);
		this.MoveDirectionCache.Normalize(9.99999993922529E-09);
		this.WorldMoveDirectionCache.DeepCopy(worldInput);
		this.WorldMoveDirectionCache.Normalize(9.99999993922529E-09);
	}

	// Token: 0x06018095 RID: 98453 RVA: 0x00732C87 File Offset: 0x00730E87
	public void ResetMoveVectorCache()
	{
		this.MoveDirectionCache.Reset();
		this.WorldMoveDirectionCache.Reset();
	}

	// Token: 0x06018096 RID: 98454 RVA: 0x00732C9F File Offset: 0x00730E9F
	[NullableContext(2)]
	public void SetCharacterController(BP_CharacterController_C controller)
	{
		this.CharacterControllerInternal = controller;
	}

	// Token: 0x1700259D RID: 9629
	// (get) Token: 0x06018097 RID: 98455 RVA: 0x00732CA8 File Offset: 0x00730EA8
	public BP_CharacterController_C CharacterController
	{
		get
		{
			return this.CharacterControllerInternal;
		}
	}

	// Token: 0x1700259E RID: 9630
	// (get) Token: 0x06018098 RID: 98456 RVA: 0x00732CB0 File Offset: 0x00730EB0
	[Nullable(2)]
	public TsBaseCharacter Character
	{
		[NullableContext(2)]
		get
		{
			return this.CharacterInternal;
		}
	}

	// Token: 0x06018099 RID: 98457 RVA: 0x00732CB8 File Offset: 0x00730EB8
	public void SetCharacter(TsBaseCharacter character)
	{
		this.CharacterInternal = character;
	}

	// Token: 0x0601809A RID: 98458 RVA: 0x00732CC1 File Offset: 0x00730EC1
	public global::Vector GetMoveVectorCache()
	{
		return this.MoveVectorCache;
	}

	// Token: 0x0601809B RID: 98459 RVA: 0x00732CCC File Offset: 0x00730ECC
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

	// Token: 0x0601809C RID: 98460 RVA: 0x00732D1E File Offset: 0x00730F1E
	public bool IsMoveInputOuterRingEnabled()
	{
		return this.MoveInputOuterRingEnableCount > 0;
	}

	// Token: 0x0601809D RID: 98461 RVA: 0x00732D29 File Offset: 0x00730F29
	public global::Vector GetMoveDirectionCache()
	{
		return this.MoveDirectionCache;
	}

	// Token: 0x0601809E RID: 98462 RVA: 0x00732D31 File Offset: 0x00730F31
	public global::Vector GetWorldMoveDirectionCache()
	{
		if (!this.ActorComp.IsAutonomousProxy)
		{
			return this.WorldMoveDirectionCache;
		}
		this.ConvertMoveDirectionToWorld(this.MoveDirectionCache, this.WorldMoveDirectionCache);
		return this.WorldMoveDirectionCache;
	}

	// Token: 0x0601809F RID: 98463 RVA: 0x00732D60 File Offset: 0x00730F60
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

	// Token: 0x060180A0 RID: 98464 RVA: 0x00732E5C File Offset: 0x0073105C
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

	// Token: 0x060180A1 RID: 98465 RVA: 0x00732FA0 File Offset: 0x007311A0
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

	// Token: 0x060180A2 RID: 98466 RVA: 0x00732FFF File Offset: 0x007311FF
	public void GetMoveDirection(global::Vector outVector)
	{
		this.GetMoveVector(outVector);
		outVector.Normalize(9.99999993922529E-09);
	}

	// Token: 0x060180A3 RID: 98467 RVA: 0x00733018 File Offset: 0x00731218
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

	// Token: 0x060180A4 RID: 98468 RVA: 0x007330A0 File Offset: 0x007312A0
	public bool HasCameraInput(float tolerance = 0.0001f)
	{
		return !MathUtils.Instance.IsNearlyZero((double)this.QueryInputAxis(EInputAxis.Turn).GetValueOrDefault(), new double?((double)tolerance)) || !MathUtils.Instance.IsNearlyZero((double)this.QueryInputAxis(EInputAxis.LookUp).GetValueOrDefault(), new double?((double)tolerance));
	}

	// Token: 0x060180A5 RID: 98469 RVA: 0x00733100 File Offset: 0x00731300
	public float GetZoomInput()
	{
		return this.QueryInputAxis(EInputAxis.Zoom).GetValueOrDefault();
	}

	// Token: 0x060180A6 RID: 98470 RVA: 0x00733120 File Offset: 0x00731320
	public float? QueryInputAxis(EInputAxis axis)
	{
		if (this.AxisValues.ContainsKey(axis))
		{
			return new float?(this.AxisValues[axis]);
		}
		return null;
	}

	// Token: 0x060180A7 RID: 98471 RVA: 0x00733156 File Offset: 0x00731356
	public void ClearMoveVectorCache()
	{
		this.MoveVectorCache.Reset();
		this.MoveDirectionCache.Reset();
		this.WorldMoveDirectionCache.Reset();
		this.LastMovementInputTime = -1.0;
	}

	// Token: 0x060180A8 RID: 98472 RVA: 0x00733188 File Offset: 0x00731388
	public void AnimBreakPoint()
	{
		if (this.QueryInputCaches())
		{
			this.ClearInputCaches("AnimBreakPoint");
		}
	}

	// Token: 0x060180A9 RID: 98473 RVA: 0x007331A0 File Offset: 0x007313A0
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

	// Token: 0x060180AA RID: 98474 RVA: 0x00733214 File Offset: 0x00731414
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

	// Token: 0x060180AB RID: 98475 RVA: 0x007332B2 File Offset: 0x007314B2
	protected override bool OnClear()
	{
		this.MoveInputOuterRingEnableCount = 0;
		return true;
	}

	// Token: 0x060180AC RID: 98476 RVA: 0x007332BC File Offset: 0x007314BC
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

	// Token: 0x060180AD RID: 98477 RVA: 0x00733530 File Offset: 0x00731730
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
		foreach (ICharacterInputObserver characterInputObserver in this.InputObservers)
		{
			characterInputObserver.OnObserverCleared();
		}
		this.InputObservers.Clear();
		this.RemoveBlockActionEvents();
		this.RemoveMoveAxisToButton();
		this.InputAngleRanges = null;
		this.ProcessedMoveInput.Reset();
		return true;
	}

	// Token: 0x060180AE RID: 98478 RVA: 0x00733790 File Offset: 0x00731990
	protected override void OnTick(float deltaTime)
	{
		this.AccumulateCacheInputs(deltaTime);
		this.IsLocalInputInternal = false;
		if (this.AutomaticFlightMode)
		{
			this.UpdateCharacterInputDirectAndFacingAutomaticFlightMode(deltaTime);
			this.StandInputDelayCountDown = 0f;
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

	// Token: 0x060180AF RID: 98479 RVA: 0x007337EC File Offset: 0x007319EC
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

	// Token: 0x060180B0 RID: 98480 RVA: 0x00733860 File Offset: 0x00731A60
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

	// Token: 0x060180B1 RID: 98481 RVA: 0x00733A48 File Offset: 0x00731C48
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

	// Token: 0x060180B2 RID: 98482 RVA: 0x00733A88 File Offset: 0x00731C88
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

	// Token: 0x060180B3 RID: 98483 RVA: 0x00733AC8 File Offset: 0x00731CC8
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

	// Token: 0x060180B4 RID: 98484 RVA: 0x00733B70 File Offset: 0x00731D70
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

	// Token: 0x060180B5 RID: 98485 RVA: 0x00733BF4 File Offset: 0x00731DF4
	[NullableContext(2)]
	public void SetInputAngleRanges(InputAngleRange[] ranges)
	{
		this.InputAngleRanges = ((ranges != null && ranges.Length != 0) ? ranges : null);
	}

	// Token: 0x060180B6 RID: 98486 RVA: 0x00733C07 File Offset: 0x00731E07
	public void ApplyInputAngleRanges(IVector direction, global::Vector @out)
	{
		@out.DeepCopy(direction);
		if (this.ActorComp == null || this.InputAngleRanges == null || @out.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		this.ClampInputByAngleRanges(direction, @out);
	}

	// Token: 0x060180B7 RID: 98487 RVA: 0x00733C3A File Offset: 0x00731E3A
	private static bool IsAngleInRange(float angle, float start, float end)
	{
		if (start <= end)
		{
			return angle >= start && angle <= end;
		}
		return angle >= start || angle <= end;
	}

	// Token: 0x060180B8 RID: 98488 RVA: 0x00733C5C File Offset: 0x00731E5C
	private static float CircularDist(float a, float b)
	{
		float num = Math.Abs(a - b);
		return Math.Min(num, 360f - num);
	}

	// Token: 0x060180B9 RID: 98489 RVA: 0x00733C80 File Offset: 0x00731E80
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

	// Token: 0x060180BA RID: 98490 RVA: 0x00733D75 File Offset: 0x00731F75
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
		this.ActorComp.SetInputDirect(this.ProcessedMoveInput, clearGravityDirect, EInputDirectSpace.World);
	}

	// Token: 0x060180BB RID: 98491 RVA: 0x00733DB4 File Offset: 0x00731FB4
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
					CharacterUnifiedStateComponent unifiedComp3 = this.UnifiedComp;
					if (unifiedComp3 != null && unifiedComp3.MoveState == ECharMoveState.FlowerFlying)
					{
						this.IsLocalInputInternal = true;
						this.TempVector.DeepCopy(this.GetMoveVectorCache());
						if (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FlyControlMode, 0, true) != 0)
						{
							this.TempVector.X = -this.TempVector.X;
						}
						double num2 = this.TempVector.SizeSquared();
						if (num2 > 1.0)
						{
							this.TempVector.DivisionEqual(Math.Sqrt(num2));
						}
						vector = this.TempVector;
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
									goto IL_36E;
								}
								BattleUiFormationData formationData = BattleUiModel.Instance.FormationData;
								if (formationData != null && formationData.AutoSprintSettingEnable)
								{
									goto IL_36E;
								}
							}
							if (!this.CheckAutoSprintTag())
							{
								goto IL_378;
							}
							IL_36E:
							this.UpdateAutoSprint(autoMovingState, delta);
							goto IL_383;
						}
						IL_378:
						this.AutoSprintTime = 0f;
					}
				}
			}
			IL_383:
			CharacterUnifiedStateComponent unifiedComp4 = this.UnifiedComp;
			if (unifiedComp4 != null && unifiedComp4.MoveState == ECharMoveState.Stand)
			{
				CharacterUnifiedStateComponent unifiedComp5 = this.UnifiedComp;
				if (unifiedComp5 != null && unifiedComp5.IsWalkMode)
				{
					if (vector.IsNearlyZero(9.999999747378752E-05))
					{
						this.StandInputDelayCountDown = 150f;
					}
					else if (this.StandInputDelayCountDown > 0f)
					{
						this.StandInputDelayCountDown -= delta;
						if (!vector.IsNearlyZero(9.999999747378752E-05) && global::Vector.DotProduct(this.ActorComp.ActorForwardProxy, vector) < 0.5)
						{
							this.ActorComp.SetInputFacing(vector, false);
							return;
						}
					}
				}
			}
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
				if (positionState != ECharPositionState.Floating && positionState != ECharPositionState.FlowerAllTerrain)
				{
					return;
				}
				this.SetInputFacingOnGround();
				break;
			}
			return;
		}
	}

	// Token: 0x060180BC RID: 98492 RVA: 0x00734292 File Offset: 0x00732492
	public bool CheckAutoSprintTag()
	{
		BaseTagComponent tagComp = this.TagComp;
		return tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.自动进入疾跑"]);
	}

	// Token: 0x060180BD RID: 98493 RVA: 0x007342B4 File Offset: 0x007324B4
	public bool CheckAutoSprintTagImmediately()
	{
		BaseTagComponent tagComp = this.TagComp;
		return tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.自动进入疾跑.瞬间起步"]);
	}

	// Token: 0x060180BE RID: 98494 RVA: 0x007342D8 File Offset: 0x007324D8
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

	// Token: 0x060180BF RID: 98495 RVA: 0x00734718 File Offset: 0x00732918
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
		this.ActorComp.SetInputDirectByNumber(this.ActorComp.InputDirectProxy.X, (double)(num2 * (float)((num > 0f) ? -1 : 1)), 0.0, EInputDirectSpace.World);
	}

	// Token: 0x060180C0 RID: 98496 RVA: 0x007348C4 File Offset: 0x00732AC4
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

	// Token: 0x060180C1 RID: 98497 RVA: 0x007349FC File Offset: 0x00732BFC
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

	// Token: 0x060180C2 RID: 98498 RVA: 0x00734AC4 File Offset: 0x00732CC4
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

	// Token: 0x060180C3 RID: 98499 RVA: 0x00734B3C File Offset: 0x00732D3C
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

	// Token: 0x060180C4 RID: 98500 RVA: 0x00734C30 File Offset: 0x00732E30
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

	// Token: 0x060180C5 RID: 98501 RVA: 0x00734CC9 File Offset: 0x00732EC9
	private MoveInputSimButtonLogic GetMoveAxisToButtonLogic()
	{
		if (this.MoveAxisToButtonLogic == null)
		{
			this.MoveAxisToButtonLogic = new MoveInputSimButtonLogic();
			this.MoveAxisToButtonLogic.Init(this.InputEvents);
		}
		return this.MoveAxisToButtonLogic;
	}

	// Token: 0x060180C6 RID: 98502 RVA: 0x00734CF5 File Offset: 0x00732EF5
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

	// Token: 0x060180C7 RID: 98503 RVA: 0x00734D26 File Offset: 0x00732F26
	public void OnEnableMoveAxisToButton(bool enable)
	{
		this.IsMoveAxisToButtonEnabled = enable;
	}

	// Token: 0x060180C8 RID: 98504 RVA: 0x00734D2F File Offset: 0x00732F2F
	private void UpdateMoveAxisToButton()
	{
		this.RefreshMoveAxisToButtonActiveCondition();
		if (this.IsMoveAxisToButtonEnabled)
		{
			this.GetMoveAxisToButtonLogic().EmitByAxisMap(this.AxisValues);
		}
	}

	// Token: 0x060180C9 RID: 98505 RVA: 0x00734D50 File Offset: 0x00732F50
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

	// Token: 0x060180CA RID: 98506 RVA: 0x00734E64 File Offset: 0x00733064
	private bool IsSmallInput(global::Vector moveVector)
	{
		if (Info.Instance.IsInKeyBoard())
		{
			return moveVector.IsNearlyZero(1E-08);
		}
		return moveVector.SizeSquared() <= MathUtils.Instance.Square((double)RoleGaitStatic.GetWalkOrRunRate());
	}

	// Token: 0x060180CB RID: 98507 RVA: 0x00734EA0 File Offset: 0x007330A0
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

	// Token: 0x060180CC RID: 98508 RVA: 0x00734EFB File Offset: 0x007330FB
	[NullableContext(2)]
	private void ClearInputCaches(string reason = null)
	{
		this.InputCaches.Clear();
	}

	// Token: 0x060180CD RID: 98509 RVA: 0x00734F08 File Offset: 0x00733108
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

	// Token: 0x060180CE RID: 98510 RVA: 0x0073503E File Offset: 0x0073323E
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

	// Token: 0x060180CF RID: 98511 RVA: 0x0073506C File Offset: 0x0073326C
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

	// Token: 0x060180D0 RID: 98512 RVA: 0x007350C8 File Offset: 0x007332C8
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

	// Token: 0x060180D1 RID: 98513 RVA: 0x00735133 File Offset: 0x00733333
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

	// Token: 0x060180D2 RID: 98514 RVA: 0x00735168 File Offset: 0x00733368
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

	// Token: 0x060180D3 RID: 98515 RVA: 0x00735284 File Offset: 0x00733484
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

	// Token: 0x060180D4 RID: 98516 RVA: 0x007352BC File Offset: 0x007334BC
	private void ExecuteClimb(SInputCommand command)
	{
		CharacterClimbComponent component = base.Entity.GetComponent<CharacterClimbComponent>();
		if (component == null)
		{
			return;
		}
		component.ClimbPress(command.IntValue == 1);
	}

	// Token: 0x060180D5 RID: 98517 RVA: 0x007352DC File Offset: 0x007334DC
	private void ExecuteSprint(SInputCommand command)
	{
		if (command.IntValue == 1)
		{
			base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SprintPress();
			return;
		}
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SprintRelease();
	}

	// Token: 0x060180D6 RID: 98518 RVA: 0x00735308 File Offset: 0x00733508
	private void ExecuteFastSwim(SInputCommand command)
	{
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SwitchFastSwim(command.IntValue == 1);
	}

	// Token: 0x060180D7 RID: 98519 RVA: 0x00735323 File Offset: 0x00733523
	private void ExecuteFastClimb(SInputCommand command)
	{
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SwitchFastClimb(command.IntValue == 1, false);
	}

	// Token: 0x060180D8 RID: 98520 RVA: 0x0073533F File Offset: 0x0073353F
	private void ExecuteSwitchWalk(SInputCommand command)
	{
		base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().WalkPress();
	}

	// Token: 0x060180D9 RID: 98521 RVA: 0x00735351 File Offset: 0x00733551
	private void ExecuteXaBoost(SInputCommand command)
	{
		CharacterGlideComponent characterGlideComponent = base.Entity.CheckGetComponent<CharacterGlideComponent>();
		if (characterGlideComponent == null)
		{
			return;
		}
		characterGlideComponent.SetSoarBoostOn(command.IntValue > 0);
	}

	// Token: 0x060180DA RID: 98522 RVA: 0x00735371 File Offset: 0x00733571
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

	// Token: 0x060180DB RID: 98523 RVA: 0x007353A1 File Offset: 0x007335A1
	private void ExecuteSwitchCharacter(int index)
	{
	}

	// Token: 0x060180DC RID: 98524 RVA: 0x007353A3 File Offset: 0x007335A3
	private void ExecuteSkill(int skillId, string context)
	{
		base.Entity.GetComponent<CharacterSkillComponent>().BeginSkillAsync(skillId, new SkillParam
		{
			Reason = "CharacterInputComponent.ExecuteSkill." + context
		}).Forget<bool>();
	}

	// Token: 0x060180DD RID: 98525 RVA: 0x007353D1 File Offset: 0x007335D1
	private float GetWorldTime()
	{
		return UGameplayStatics.GetTimeSeconds(GlobalData.World);
	}

	// Token: 0x060180DE RID: 98526 RVA: 0x007353E0 File Offset: 0x007335E0
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

	// Token: 0x060180DF RID: 98527 RVA: 0x0073545C File Offset: 0x0073365C
	private void DispatchPressEvent(CSharpScript.Game.Input.EInputAction action, double time, float moveInputYaw = 0f)
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
		int num = 0;
		while (num < inputLayers.Count && !inputLayers[num].DispatchPressEventEx(action, (float)time, moveInputYaw))
		{
			num++;
		}
	}

	// Token: 0x060180E0 RID: 98528 RVA: 0x00735500 File Offset: 0x00733700
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
		int num = 0;
		while (num < inputLayers.Count && !inputLayers[num].DispatchReleaseEventEx(action, (float)time, moveInputYaw))
		{
			num++;
		}
	}

	// Token: 0x060180E1 RID: 98529 RVA: 0x007355A4 File Offset: 0x007337A4
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

	// Token: 0x060180E2 RID: 98530 RVA: 0x00735680 File Offset: 0x00733880
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

	// Token: 0x060180E3 RID: 98531 RVA: 0x0073575C File Offset: 0x0073395C
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

	// Token: 0x060180E4 RID: 98532 RVA: 0x00735838 File Offset: 0x00733A38
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

	// Token: 0x060180E5 RID: 98533 RVA: 0x007358D4 File Offset: 0x00733AD4
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

	// Token: 0x060180E6 RID: 98534 RVA: 0x00735928 File Offset: 0x00733B28
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

	// Token: 0x060180E7 RID: 98535 RVA: 0x00735A55 File Offset: 0x00733C55
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

	// Token: 0x060180E8 RID: 98536 RVA: 0x00735A88 File Offset: 0x00733C88
	public bool IsInAutomaticFlightMode()
	{
		return this.AutomaticFlightMode;
	}

	// Token: 0x060180E9 RID: 98537 RVA: 0x00735A90 File Offset: 0x00733C90
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

	// Token: 0x060180EA RID: 98538 RVA: 0x00735B39 File Offset: 0x00733D39
	public void TurnOffCameraDrivenAutoFlightMode()
	{
		this.CameraDrivenAutoFlightMode = false;
		this.IsStartCameraDrivenAutoFlightTick = false;
	}

	// Token: 0x060180EB RID: 98539 RVA: 0x00735B49 File Offset: 0x00733D49
	public bool IsInCameraDrivenAutoFlightMode()
	{
		return this.CameraDrivenAutoFlightMode && this.IsInCameraDrivenAutoFlight;
	}

	// Token: 0x060180EC RID: 98540 RVA: 0x00735B5C File Offset: 0x00733D5C
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

	// Token: 0x060180ED RID: 98541 RVA: 0x00735BD0 File Offset: 0x00733DD0
	private void RemoveCharacterInputLayer()
	{
		if (this.InputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.InputLayer);
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x060180EE RID: 98542 RVA: 0x00735BFC File Offset: 0x00733DFC
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

	// Token: 0x060180EF RID: 98543 RVA: 0x00735C7B File Offset: 0x00733E7B
	private void RemoveExtraInputLayer()
	{
		if (this.ExtraInputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.ExtraInputLayer);
			this.ExtraInputLayer.Clear();
			this.ExtraInputLayer = null;
		}
	}

	// Token: 0x060180F0 RID: 98544 RVA: 0x00735CA7 File Offset: 0x00733EA7
	[NullableContext(2)]
	public BP_InputBase_C GetBpInputComp()
	{
		return InputLayerQueryHelper.GetFirstBpInputComp(base.Entity.Id);
	}

	// Token: 0x060180F1 RID: 98545 RVA: 0x00735CB9 File Offset: 0x00733EB9
	public void SetBpInputComp(BP_InputBase_C bpInputComp)
	{
		CharacterInputLayer inputLayer = this.InputLayer;
		if (inputLayer == null)
		{
			return;
		}
		inputLayer.SetBpInputComp(bpInputComp);
	}

	// Token: 0x060180F2 RID: 98546 RVA: 0x00735CCC File Offset: 0x00733ECC
	public float GetCommandInterval(ECommandType commandType)
	{
		double num = this.CommandTimeMap.ContainsKey(commandType) ? this.CommandTimeMap[commandType] : 0.0;
		return (float)(Time.Instance.WorldTimeSeconds - num);
	}

	// Token: 0x060180F3 RID: 98547 RVA: 0x00735D0C File Offset: 0x00733F0C
	public void RemoveCommandInterval(ECommandType commandType)
	{
		this.CommandTimeMap.Remove(commandType);
	}

	// Token: 0x060180F4 RID: 98548 RVA: 0x00735D1B File Offset: 0x00733F1B
	public bool IsOnlyAllowFightInput()
	{
		return this.IsOnlyAllowFightInputInternal;
	}

	// Token: 0x060180F5 RID: 98549 RVA: 0x00735D23 File Offset: 0x00733F23
	public void SetOnlyAllowFightInput(bool isOnlyAllowFightInput)
	{
		this.IsOnlyAllowFightInputInternal = isOnlyAllowFightInput;
		EventSystem.Instance.Emit(EEventName.OnOnlyAllowFightInputStateChanged);
	}

	// Token: 0x060180F6 RID: 98550 RVA: 0x00735D3C File Offset: 0x00733F3C
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

	// Token: 0x060180F7 RID: 98551 RVA: 0x00735E20 File Offset: 0x00734020
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

	// Token: 0x060180F8 RID: 98552 RVA: 0x00735EAC File Offset: 0x007340AC
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

	// Token: 0x060180F9 RID: 98553 RVA: 0x00735F00 File Offset: 0x00734100
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

	// Token: 0x060180FA RID: 98554 RVA: 0x00735FAC File Offset: 0x007341AC
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

	// Token: 0x060180FB RID: 98555 RVA: 0x00736008 File Offset: 0x00734208
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

	// Token: 0x060180FC RID: 98556 RVA: 0x007360C8 File Offset: 0x007342C8
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

	// Token: 0x060180FD RID: 98557 RVA: 0x00736120 File Offset: 0x00734320
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

	// Token: 0x060180FE RID: 98558 RVA: 0x00736174 File Offset: 0x00734374
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

	// Token: 0x060180FF RID: 98559 RVA: 0x0073638A File Offset: 0x0073458A
	public void SetUseActorRelativeMoveInput(bool value)
	{
		this.UseActorRelativeMoveInput = value;
	}

	// Token: 0x06018100 RID: 98560 RVA: 0x00736393 File Offset: 0x00734593
	public bool GetUseActorRelativeMoveInput()
	{
		return this.UseActorRelativeMoveInput;
	}

	// Token: 0x06018101 RID: 98561 RVA: 0x0073639B File Offset: 0x0073459B
	public void SetInvertMoveForward(bool value)
	{
		this.InvertMoveForward = value;
	}

	// Token: 0x06018102 RID: 98562 RVA: 0x007363A4 File Offset: 0x007345A4
	public void SetInvertMoveRight(bool value)
	{
		this.InvertMoveRight = value;
	}

	// Token: 0x06018103 RID: 98563 RVA: 0x007363AD File Offset: 0x007345AD
	private bool IsActorRelativeMove()
	{
		return this.UseActorRelativeMoveInput;
	}

	// Token: 0x1700259F RID: 9631
	// (get) Token: 0x06018104 RID: 98564 RVA: 0x007363B8 File Offset: 0x007345B8
	// (set) Token: 0x06018105 RID: 98565 RVA: 0x00736403 File Offset: 0x00734603
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

	// Token: 0x06018106 RID: 98566 RVA: 0x0073640C File Offset: 0x0073460C
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

	// Token: 0x06018107 RID: 98567 RVA: 0x00736518 File Offset: 0x00734718
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
				TEnumAsByte<EMovementMode>? tenumAsByte;
				if (moveComp == null)
				{
					tenumAsByte = null;
				}
				else
				{
					UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
					tenumAsByte = ((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null);
				}
				if (tenumAsByte == EMovementMode.MOVE_Falling)
				{
					CharacterUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
					if (unifiedComp2 != null && unifiedComp2.MoveState == ECharMoveState.Other)
					{
						CharacterMoveComponent moveComp2 = this.MoveComp;
						if (moveComp2 != null)
						{
							moveComp2.TrySetGlide();
						}
					}
				}
			}
		}
		else
		{
			this.AutoMovingConfig.InAirTime = 0f;
		}
		CharacterUnifiedStateComponent unifiedComp3 = this.UnifiedComp;
		if (unifiedComp3 == null || unifiedComp3.PositionState != ECharPositionState.Water)
		{
			CharacterUnifiedStateComponent unifiedComp4 = this.UnifiedComp;
			if (unifiedComp4 == null || unifiedComp4.PositionState != ECharPositionState.Climb)
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
			CharacterUnifiedStateComponent unifiedComp5 = this.UnifiedComp;
			if (unifiedComp5 == null || unifiedComp5.MoveState != ECharMoveState.FastClimb)
			{
				CharacterUnifiedStateComponent unifiedComp6 = this.UnifiedComp;
				if (unifiedComp6 == null || unifiedComp6.MoveState != ECharMoveState.NormalClimb)
				{
					CharacterUnifiedStateComponent unifiedComp7 = this.UnifiedComp;
					if (unifiedComp7 == null || unifiedComp7.MoveState != ECharMoveState.NormalSwim)
					{
						CharacterUnifiedStateComponent unifiedComp8 = this.UnifiedComp;
						if (unifiedComp8 == null || unifiedComp8.MoveState != ECharMoveState.FastSwim)
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

	// Token: 0x06018108 RID: 98568 RVA: 0x00736735 File Offset: 0x00734935
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

	// Token: 0x06018109 RID: 98569 RVA: 0x0073676B File Offset: 0x0073496B
	public void SetAutoMovingConfig(InputContinuously value)
	{
		this.AutoMovingConfig.DeepCopy(value);
	}

	// Token: 0x0601810A RID: 98570 RVA: 0x00736779 File Offset: 0x00734979
	public InputContinuously GetAutoMovingConfig()
	{
		return this.AutoMovingConfig;
	}

	// Token: 0x0601810B RID: 98571 RVA: 0x00736784 File Offset: 0x00734984
	private void CalculateMoveDirection(global::Vector outVector)
	{
		FVectorDouble fvectorDouble = Global.CharacterCameraManager.GetCameraRotation().VectorDouble();
		this.TempVector.DeepCopy(fvectorDouble);
		global::Vector gravityDirect = this.MoveComp.GravityDirect;
		global::Vector.VectorPlaneProject(this.TempVector, gravityDirect, outVector);
	}

	// Token: 0x0601810C RID: 98572 RVA: 0x007367CC File Offset: 0x007349CC
	private void CalculateMoveDirectionFromFightCamera(global::Vector outVector)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraRotation.Vector(this.TempVector);
		global::Vector gravityDirect = this.MoveComp.GravityDirect;
		global::Vector.VectorPlaneProject(this.TempVector, gravityDirect, outVector);
	}

	// Token: 0x0601810D RID: 98573 RVA: 0x00736816 File Offset: 0x00734A16
	private void OnRoleDead()
	{
		this.InterruptAutoMoving("角色死亡", true);
	}

	// Token: 0x0601810E RID: 98574 RVA: 0x00736825 File Offset: 0x00734A25
	private void OnSequenceNetworkStart(PlotInfo plotInfo)
	{
		if (plotInfo.PlotLevel == EPlotLevel.LevelA || plotInfo.PlotLevel == EPlotLevel.LevelB || plotInfo.PlotLevel == EPlotLevel.LevelC)
		{
			this.InterruptAutoMoving("进入剧情", true);
		}
	}

	// Token: 0x0601810F RID: 98575 RVA: 0x0073684E File Offset: 0x00734A4E
	private void AutoMovingSettingChanged(bool value)
	{
		if (!value)
		{
			this.AutoMovingConfig.ResetAutoMovingState("退出自动奔跑模式");
		}
	}

	// Token: 0x06018110 RID: 98576 RVA: 0x00736864 File Offset: 0x00734A64
	private void OnViewShow(EUiViewName viewName, int viewId)
	{
		UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(viewName);
		if (uiShowConfig != null && !uiShowConfig.Value.AllowAutoMoving)
		{
			this.InterruptAutoMoving("打开了UI" + viewName, true);
		}
	}

	// Token: 0x06018111 RID: 98577 RVA: 0x007368AF File Offset: 0x00734AAF
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

	// Token: 0x06018112 RID: 98578 RVA: 0x007368F0 File Offset: 0x00734AF0
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

	// Token: 0x06018113 RID: 98579 RVA: 0x007369D0 File Offset: 0x00734BD0
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

	// Token: 0x06018114 RID: 98580 RVA: 0x00736A5E File Offset: 0x00734C5E
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

	// Token: 0x06018115 RID: 98581 RVA: 0x00736A99 File Offset: 0x00734C99
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

	// Token: 0x06018116 RID: 98582 RVA: 0x00736AC8 File Offset: 0x00734CC8
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

	// Token: 0x06018117 RID: 98583 RVA: 0x00736B4E File Offset: 0x00734D4E
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

	// Token: 0x06018118 RID: 98584 RVA: 0x00736B88 File Offset: 0x00734D88
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

	// Token: 0x06018119 RID: 98585 RVA: 0x00736DE0 File Offset: 0x00734FE0
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
							flag3 = true;
						}
						else if (this.StandInputDelayCountDown > 0f)
						{
							this.StandInputDelayCountDown -= delta;
							flag3 = true;
						}
					}
					if (!flag3)
					{
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

	// Token: 0x0601811A RID: 98586 RVA: 0x00736FA0 File Offset: 0x007351A0
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

	// Token: 0x0601811B RID: 98587 RVA: 0x00737026 File Offset: 0x00735226
	public static void CreateStaticDefaultValue()
	{
		CharacterInputComponent.HoldPressMap = new Dictionary<CSharpScript.Game.Input.EInputAction, bool>();
	}

	// Token: 0x0601811C RID: 98588 RVA: 0x00737032 File Offset: 0x00735232
	public static void ResetStaticDefaultValue()
	{
		CharacterInputComponent.HoldPressMap = null;
	}

	// Token: 0x0601811D RID: 98589 RVA: 0x0073703C File Offset: 0x0073523C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterInputComponent characterInputComponent = (CharacterInputComponent)componentTemplate;
		if (characterInputComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterInputComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (characterInputComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (characterInputComponent.TempQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempQuat), "TempQuat"))
		{
			return false;
		}
		if (characterInputComponent.TempQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempQuat2), "TempQuat2"))
		{
			return false;
		}
		if (characterInputComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterInputComponent.AbilityComp == null)
		{
			this.AbilityComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AbilityComp), "AbilityComp"))
		{
			return false;
		}
		if (characterInputComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterInputComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (characterInputComponent.SkillComponent == null)
		{
			this.SkillComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComponent), "SkillComponent"))
		{
			return false;
		}
		if (characterInputComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterInputComponent.UnifiedComp == null)
		{
			this.UnifiedComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedComp), "UnifiedComp"))
		{
			return false;
		}
		if (characterInputComponent.CharacterInternal == null)
		{
			this.CharacterInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterInternal), "CharacterInternal"))
		{
			return false;
		}
		if (characterInputComponent.CharacterControllerInternal == null)
		{
			this.CharacterControllerInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterControllerInternal), "CharacterControllerInternal"))
		{
			return false;
		}
		if (characterInputComponent.InputLayer == null)
		{
			this.InputLayer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputLayer), "InputLayer"))
		{
			return false;
		}
		if (characterInputComponent.ExtraInputLayer == null)
		{
			this.ExtraInputLayer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExtraInputLayer), "ExtraInputLayer"))
		{
			return false;
		}
		if (characterInputComponent.InputEvents != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputEvents), "InputEvents"))
		{
			return false;
		}
		if (characterInputComponent.InputObservers != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<ICharacterInputObserver>(this.InputObservers), "InputObservers"))
		{
			return false;
		}
		if (characterInputComponent.InputCaches != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputCaches), "InputCaches"))
		{
			return false;
		}
		if (characterInputComponent.AxisValues != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AxisValues), "AxisValues"))
		{
			return false;
		}
		if (characterInputComponent.InputGroup == null)
		{
			this.InputGroup = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputGroup), "InputGroup"))
		{
			return false;
		}
		if (characterInputComponent.MoveVectorCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveVectorCache), "MoveVectorCache"))
		{
			return false;
		}
		if (characterInputComponent.ProcessedMoveInput != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ProcessedMoveInput), "ProcessedMoveInput"))
		{
			return false;
		}
		if (characterInputComponent.InputAngleRanges == null)
		{
			this.InputAngleRanges = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputAngleRanges), "InputAngleRanges"))
		{
			return false;
		}
		this.MoveInputOuterRingEnableCount = characterInputComponent.MoveInputOuterRingEnableCount;
		if (characterInputComponent.MoveDirectionCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveDirectionCache), "MoveDirectionCache"))
		{
			return false;
		}
		if (characterInputComponent.WorldMoveDirectionCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.WorldMoveDirectionCache), "WorldMoveDirectionCache"))
		{
			return false;
		}
		this.IsLocalInputInternal = characterInputComponent.IsLocalInputInternal;
		this.IsOnlyAllowFightInputInternal = characterInputComponent.IsOnlyAllowFightInputInternal;
		this.LastMovementInputTime = characterInputComponent.LastMovementInputTime;
		if (characterInputComponent.CommandTimeMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommandTimeMap), "CommandTimeMap"))
		{
			return false;
		}
		this.DisableHandle = characterInputComponent.DisableHandle;
		this.AutomaticFlightMode = characterInputComponent.AutomaticFlightMode;
		if (characterInputComponent.AutomaticFlightDataAsset == null)
		{
			this.AutomaticFlightDataAsset = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AutomaticFlightDataAsset), "AutomaticFlightDataAsset"))
		{
			return false;
		}
		this.AutomaticFlightModeTimeCache = characterInputComponent.AutomaticFlightModeTimeCache;
		this.CameraDrivenAutoFlightMode = characterInputComponent.CameraDrivenAutoFlightMode;
		if (characterInputComponent.CameraDrivenAutoFlightDataAsset == null)
		{
			this.CameraDrivenAutoFlightDataAsset = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraDrivenAutoFlightDataAsset), "CameraDrivenAutoFlightDataAsset"))
		{
			return false;
		}
		this.IsInCameraDrivenAutoFlight = characterInputComponent.IsInCameraDrivenAutoFlight;
		this.IsStartCameraDrivenAutoFlightTick = characterInputComponent.IsStartCameraDrivenAutoFlightTick;
		this.CameraDrivenAutoFlightTime = characterInputComponent.CameraDrivenAutoFlightTime;
		this.MoveDirectionDistanceMin = characterInputComponent.MoveDirectionDistanceMin;
		this.MoveDirectionDistanceMax = characterInputComponent.MoveDirectionDistanceMax;
		this.MovementDirectionAngleThreshold = characterInputComponent.MovementDirectionAngleThreshold;
		this.StandInputDelayCountDown = characterInputComponent.StandInputDelayCountDown;
		this.NextFrameClear = characterInputComponent.NextFrameClear;
		if (characterInputComponent.NextFrameClearAxis != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EInputAxis>(this.NextFrameClearAxis), "NextFrameClearAxis"))
		{
			return false;
		}
		this.LastShowMouseCursor = characterInputComponent.LastShowMouseCursor;
		if (characterInputComponent.TestInputEvent != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TestInputEvent), "TestInputEvent"))
		{
			return false;
		}
		if (characterInputComponent.CameraInputQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraInputQuat), "CameraInputQuat"))
		{
			return false;
		}
		if (characterInputComponent.PhotoMoveInput != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PhotoMoveInput), "PhotoMoveInput"))
		{
			return false;
		}
		if (characterInputComponent.CurrentMoveDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentMoveDirection), "CurrentMoveDirection"))
		{
			return false;
		}
		if (characterInputComponent.TagEventJump == null)
		{
			this.TagEventJump = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventJump), "TagEventJump"))
		{
			return false;
		}
		if (characterInputComponent.TagEventClimb == null)
		{
			this.TagEventClimb = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventClimb), "TagEventClimb"))
		{
			return false;
		}
		if (characterInputComponent.TagEventAttack == null)
		{
			this.TagEventAttack = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventAttack), "TagEventAttack"))
		{
			return false;
		}
		if (characterInputComponent.TagEventDodge == null)
		{
			this.TagEventDodge = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventDodge), "TagEventDodge"))
		{
			return false;
		}
		if (characterInputComponent.TagEventSkill == null)
		{
			this.TagEventSkill = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventSkill), "TagEventSkill"))
		{
			return false;
		}
		if (characterInputComponent.TagEventVision1 == null)
		{
			this.TagEventVision1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventVision1), "TagEventVision1"))
		{
			return false;
		}
		if (characterInputComponent.TagEventUltimateSkill == null)
		{
			this.TagEventUltimateSkill = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventUltimateSkill), "TagEventUltimateSkill"))
		{
			return false;
		}
		if (characterInputComponent.TagEventVision2 == null)
		{
			this.TagEventVision2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventVision2), "TagEventVision2"))
		{
			return false;
		}
		if (characterInputComponent.TagEventChangeRoll1 == null)
		{
			this.TagEventChangeRoll1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventChangeRoll1), "TagEventChangeRoll1"))
		{
			return false;
		}
		if (characterInputComponent.TagEventChangeRoll2 == null)
		{
			this.TagEventChangeRoll2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventChangeRoll2), "TagEventChangeRoll2"))
		{
			return false;
		}
		if (characterInputComponent.TagEventChangeRoll3 == null)
		{
			this.TagEventChangeRoll3 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventChangeRoll3), "TagEventChangeRoll3"))
		{
			return false;
		}
		if (characterInputComponent.TagEventLock == null)
		{
			this.TagEventLock = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventLock), "TagEventLock"))
		{
			return false;
		}
		if (characterInputComponent.TagEventAim == null)
		{
			this.TagEventAim = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventAim), "TagEventAim"))
		{
			return false;
		}
		if (characterInputComponent.TagEventMove == null)
		{
			this.TagEventMove = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventMove), "TagEventMove"))
		{
			return false;
		}
		this.IsMoveAxisToButtonEnabled = characterInputComponent.IsMoveAxisToButtonEnabled;
		if (characterInputComponent.MoveAxisToButtonLogic == null)
		{
			this.MoveAxisToButtonLogic = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveAxisToButtonLogic), "MoveAxisToButtonLogic"))
		{
			return false;
		}
		if (characterInputComponent.CurrentMoveAxisToButtonConfig == null)
		{
			this.CurrentMoveAxisToButtonConfig = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentMoveAxisToButtonConfig), "CurrentMoveAxisToButtonConfig"))
		{
			return false;
		}
		if (characterInputComponent.MoveAxisToButtonActiveCondition == null)
		{
			this.MoveAxisToButtonActiveCondition = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveAxisToButtonActiveCondition), "MoveAxisToButtonActiveCondition"))
		{
			return false;
		}
		this.InCameraFollowInput = characterInputComponent.InCameraFollowInput;
		if (characterInputComponent.CameraFollowInputTagTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraFollowInputTagTasks), "CameraFollowInputTagTasks"))
		{
			return false;
		}
		if (characterInputComponent.TagToDaPathMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagToDaPathMap), "TagToDaPathMap"))
		{
			return false;
		}
		this.CameraFollowInputLockRunState = characterInputComponent.CameraFollowInputLockRunState;
		this.CameraFollowInputInSprintState = characterInputComponent.CameraFollowInputInSprintState;
		if (characterInputComponent.CameraFollowInputConfig == null)
		{
			this.CameraFollowInputConfig = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraFollowInputConfig), "CameraFollowInputConfig"))
		{
			return false;
		}
		this.UseActorRelativeMoveInput = characterInputComponent.UseActorRelativeMoveInput;
		this.InvertMoveForward = characterInputComponent.InvertMoveForward;
		this.InvertMoveRight = characterInputComponent.InvertMoveRight;
		if (characterInputComponent.AutoMovingConfigInternal == null)
		{
			this.AutoMovingConfigInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AutoMovingConfigInternal), "AutoMovingConfigInternal"))
		{
			return false;
		}
		this.AutoSprintTime = characterInputComponent.AutoSprintTime;
		this.AutoSprintConfigTime = characterInputComponent.AutoSprintConfigTime;
		this.IsOverShoulderMode = characterInputComponent.IsOverShoulderMode;
		this.IsOverShoulderSprint = characterInputComponent.IsOverShoulderSprint;
		if (characterInputComponent.ChangeOverShoulderSprintMode == null)
		{
			this.ChangeOverShoulderSprintMode = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChangeOverShoulderSprintMode), "ChangeOverShoulderSprintMode"))
		{
			return false;
		}
		if (characterInputComponent.OverShoulderConfig == null)
		{
			this.OverShoulderConfig = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OverShoulderConfig), "OverShoulderConfig"))
		{
			return false;
		}
		if (characterInputComponent.LastCameraDir == null)
		{
			this.LastCameraDir = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastCameraDir), "LastCameraDir"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170025A0 RID: 9632
	// (get) Token: 0x0601811E RID: 98590 RVA: 0x00737AB3 File Offset: 0x00735CB3
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025A1 RID: 9633
	// (get) Token: 0x0601811F RID: 98591 RVA: 0x00737AB6 File Offset: 0x00735CB6
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025A2 RID: 9634
	// (get) Token: 0x06018120 RID: 98592 RVA: 0x00737AB9 File Offset: 0x00735CB9
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025A3 RID: 9635
	// (get) Token: 0x06018121 RID: 98593 RVA: 0x00737ABC File Offset: 0x00735CBC
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CE78 RID: 52856
	private const int ZERO_TIME = 0;

	// Token: 0x0400CE79 RID: 52857
	private const int NULL_CONFIG_TIME = -1;

	// Token: 0x0400CE7A RID: 52858
	private const int INVALID_PRIORITY = -1;

	// Token: 0x0400CE7B RID: 52859
	private const int INVALID_PRIORITY_INDEX = -1;

	// Token: 0x0400CE7C RID: 52860
	private const int INVALID_INPUT_TIME = -1;

	// Token: 0x0400CE7D RID: 52861
	private const float MOVE_VECTOR_CACHE_TIME = 100f;

	// Token: 0x0400CE7E RID: 52862
	private const float EXIT_CLIMB_BLOCK_ATTACK_RELEASE_TIME = 0.25f;

	// Token: 0x0400CE7F RID: 52863
	public const int CAMERA_FOLLOW_FORWARD_ANGLE = 50;

	// Token: 0x0400CE80 RID: 52864
	private const string FIRST_PERSON_CONFIG_MAP_PATH = "/Game/Aki/Character/Role/Common/Data/DA/DA_FirstPersonConfigMap.DA_FirstPersonConfigMap";

	// Token: 0x0400CE81 RID: 52865
	private const float LOW_STRENGTH_EXIT_VALUE = 2200f;

	// Token: 0x0400CE82 RID: 52866
	private const float STAND_INPUT_DELAY = 150f;

	// Token: 0x0400CE83 RID: 52867
	private const float FACING_SHOULDER_STAND_INPUT_DELAY = 200f;

	// Token: 0x0400CE84 RID: 52868
	private const float STAND_INPUT_TURN_THRESHOLD = 0.5f;

	// Token: 0x0400CE85 RID: 52869
	private const float FACING_INPUT_THRESHOLD_IN_LOCK_MODE = 60f;

	// Token: 0x0400CE86 RID: 52870
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

	// Token: 0x0400CE87 RID: 52871
	[StaticVariableRuleIgnore]
	private static readonly Stat GetCommandStat = Stat.Create("CharacterInputComponent.GetCommand", "", "");

	// Token: 0x0400CE88 RID: 52872
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteCommandStat = Stat.Create("CharacterInputComponent.ExecuteCommand", "", "");

	// Token: 0x0400CE89 RID: 52873
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchPressEventStat = Stat.Create("CharacterInputComponent.DispatchPressEvent", "", "");

	// Token: 0x0400CE8A RID: 52874
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchReleaseEventStat = Stat.Create("CharacterInputComponent.DispatchReleaseEvent", "", "");

	// Token: 0x0400CE8B RID: 52875
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressStat = Stat.Create("CharacterInputComponent.HandlePress", "", "");

	// Token: 0x0400CE8C RID: 52876
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseStat = Stat.Create("CharacterInputComponent.HandleRelease", "", "");

	// Token: 0x0400CE8D RID: 52877
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x0400CE8E RID: 52878
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x0400CE8F RID: 52879
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400CE90 RID: 52880
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CE91 RID: 52881
	private readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CE92 RID: 52882
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CE93 RID: 52883
	[Nullable(2)]
	private CharacterAbilityComponent AbilityComp;

	// Token: 0x0400CE94 RID: 52884
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CE95 RID: 52885
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400CE96 RID: 52886
	[Nullable(2)]
	private CharacterSkillComponent SkillComponent;

	// Token: 0x0400CE97 RID: 52887
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CE98 RID: 52888
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CE99 RID: 52889
	[Nullable(2)]
	private TsBaseCharacter CharacterInternal;

	// Token: 0x0400CE9A RID: 52890
	[Nullable(2)]
	private BP_CharacterController_C CharacterControllerInternal;

	// Token: 0x0400CE9B RID: 52891
	[Nullable(2)]
	private CharacterInputLayer InputLayer;

	// Token: 0x0400CE9C RID: 52892
	[Nullable(2)]
	private ExtraInputLayer ExtraInputLayer;

	// Token: 0x0400CE9D RID: 52893
	private readonly List<InputEvent> InputEvents = new List<InputEvent>();

	// Token: 0x0400CE9E RID: 52894
	private readonly HashSet<ICharacterInputObserver> InputObservers = new HashSet<ICharacterInputObserver>();

	// Token: 0x0400CE9F RID: 52895
	private readonly List<InputCache> InputCaches = new List<InputCache>();

	// Token: 0x0400CEA0 RID: 52896
	private readonly Dictionary<EInputAxis, float> AxisValues = new Dictionary<EInputAxis, float>();

	// Token: 0x0400CEA1 RID: 52897
	[Nullable(2)]
	private InputFilter InputGroup;

	// Token: 0x0400CEA2 RID: 52898
	private readonly global::Vector MoveVectorCache = global::Vector.Create();

	// Token: 0x0400CEA3 RID: 52899
	private readonly global::Vector ProcessedMoveInput = global::Vector.Create();

	// Token: 0x0400CEA4 RID: 52900
	[Nullable(2)]
	private InputAngleRange[] InputAngleRanges;

	// Token: 0x0400CEA5 RID: 52901
	private int MoveInputOuterRingEnableCount;

	// Token: 0x0400CEA6 RID: 52902
	private readonly global::Vector MoveDirectionCache = global::Vector.Create();

	// Token: 0x0400CEA7 RID: 52903
	private readonly global::Vector WorldMoveDirectionCache = global::Vector.Create();

	// Token: 0x0400CEA8 RID: 52904
	private bool IsLocalInputInternal;

	// Token: 0x0400CEA9 RID: 52905
	private bool IsOnlyAllowFightInputInternal;

	// Token: 0x0400CEAA RID: 52906
	private double LastMovementInputTime = -1.0;

	// Token: 0x0400CEAB RID: 52907
	private static Dictionary<CSharpScript.Game.Input.EInputAction, bool> HoldPressMap;

	// Token: 0x0400CEAC RID: 52908
	private readonly Dictionary<ECommandType, double> CommandTimeMap = new Dictionary<ECommandType, double>();

	// Token: 0x0400CEAD RID: 52909
	private int? DisableHandle;

	// Token: 0x0400CEAE RID: 52910
	private bool AutomaticFlightMode;

	// Token: 0x0400CEAF RID: 52911
	[Nullable(2)]
	private AutomaticFlightData AutomaticFlightDataAsset;

	// Token: 0x0400CEB0 RID: 52912
	private float AutomaticFlightModeTimeCache;

	// Token: 0x0400CEB1 RID: 52913
	private bool CameraDrivenAutoFlightMode;

	// Token: 0x0400CEB2 RID: 52914
	[Nullable(2)]
	private CameraDrivenAutoFlightData CameraDrivenAutoFlightDataAsset;

	// Token: 0x0400CEB3 RID: 52915
	private bool IsInCameraDrivenAutoFlight;

	// Token: 0x0400CEB4 RID: 52916
	private bool IsStartCameraDrivenAutoFlightTick;

	// Token: 0x0400CEB5 RID: 52917
	private float CameraDrivenAutoFlightTime;

	// Token: 0x0400CEB6 RID: 52918
	private float MoveDirectionDistanceMin;

	// Token: 0x0400CEB7 RID: 52919
	private float MoveDirectionDistanceMax;

	// Token: 0x0400CEB8 RID: 52920
	private float MovementDirectionAngleThreshold;

	// Token: 0x0400CEB9 RID: 52921
	private float StandInputDelayCountDown;

	// Token: 0x0400CEBA RID: 52922
	private bool NextFrameClear;

	// Token: 0x0400CEBB RID: 52923
	private readonly HashSet<EInputAxis> NextFrameClearAxis = new HashSet<EInputAxis>();

	// Token: 0x0400CEBC RID: 52924
	private bool LastShowMouseCursor;

	// Token: 0x0400CEBD RID: 52925
	private readonly List<InputEvent> TestInputEvent = new List<InputEvent>();

	// Token: 0x0400CEBE RID: 52926
	private readonly Quat CameraInputQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CEBF RID: 52927
	private readonly global::Vector PhotoMoveInput = global::Vector.Create();

	// Token: 0x0400CEC0 RID: 52928
	private readonly global::Vector CurrentMoveDirection = global::Vector.Create();

	// Token: 0x0400CEC1 RID: 52929
	[Nullable(2)]
	private ITagTask TagEventJump;

	// Token: 0x0400CEC2 RID: 52930
	[Nullable(2)]
	private ITagTask TagEventClimb;

	// Token: 0x0400CEC3 RID: 52931
	[Nullable(2)]
	private ITagTask TagEventAttack;

	// Token: 0x0400CEC4 RID: 52932
	[Nullable(2)]
	private ITagTask TagEventDodge;

	// Token: 0x0400CEC5 RID: 52933
	[Nullable(2)]
	private ITagTask TagEventSkill;

	// Token: 0x0400CEC6 RID: 52934
	[Nullable(2)]
	private ITagTask TagEventVision1;

	// Token: 0x0400CEC7 RID: 52935
	[Nullable(2)]
	private ITagTask TagEventUltimateSkill;

	// Token: 0x0400CEC8 RID: 52936
	[Nullable(2)]
	private ITagTask TagEventVision2;

	// Token: 0x0400CEC9 RID: 52937
	[Nullable(2)]
	private ITagTask TagEventChangeRoll1;

	// Token: 0x0400CECA RID: 52938
	[Nullable(2)]
	private ITagTask TagEventChangeRoll2;

	// Token: 0x0400CECB RID: 52939
	[Nullable(2)]
	private ITagTask TagEventChangeRoll3;

	// Token: 0x0400CECC RID: 52940
	[Nullable(2)]
	private ITagTask TagEventLock;

	// Token: 0x0400CECD RID: 52941
	[Nullable(2)]
	private ITagTask TagEventAim;

	// Token: 0x0400CECE RID: 52942
	[Nullable(2)]
	private ITagTask TagEventMove;

	// Token: 0x0400CECF RID: 52943
	private bool IsMoveAxisToButtonEnabled;

	// Token: 0x0400CED0 RID: 52944
	[Nullable(2)]
	private MoveInputSimButtonLogic MoveAxisToButtonLogic;

	// Token: 0x0400CED1 RID: 52945
	[Nullable(2)]
	private SInputActive CurrentMoveAxisToButtonConfig;

	// Token: 0x0400CED2 RID: 52946
	[Nullable(2)]
	private InputActiveCondition MoveAxisToButtonActiveCondition;

	// Token: 0x0400CED3 RID: 52947
	private bool InCameraFollowInput;

	// Token: 0x0400CED4 RID: 52948
	private readonly List<ITagTask> CameraFollowInputTagTasks = new List<ITagTask>();

	// Token: 0x0400CED5 RID: 52949
	private readonly Dictionary<int, string> TagToDaPathMap = new Dictionary<int, string>();

	// Token: 0x0400CED6 RID: 52950
	private bool CameraFollowInputLockRunState;

	// Token: 0x0400CED7 RID: 52951
	private bool CameraFollowInputInSprintState;

	// Token: 0x0400CED8 RID: 52952
	[Nullable(2)]
	private CameraFollowInputConfig CameraFollowInputConfig;

	// Token: 0x0400CED9 RID: 52953
	private bool UseActorRelativeMoveInput;

	// Token: 0x0400CEDA RID: 52954
	private bool InvertMoveForward;

	// Token: 0x0400CEDB RID: 52955
	private bool InvertMoveRight;

	// Token: 0x0400CEDC RID: 52956
	[Nullable(2)]
	private InputContinuously AutoMovingConfigInternal;

	// Token: 0x0400CEDD RID: 52957
	private float AutoSprintTime;

	// Token: 0x0400CEDE RID: 52958
	private float AutoSprintConfigTime;

	// Token: 0x0400CEDF RID: 52959
	private bool IsOverShoulderMode;

	// Token: 0x0400CEE0 RID: 52960
	private bool IsOverShoulderSprint;

	// Token: 0x0400CEE1 RID: 52961
	[Nullable(2)]
	private ITagTask ChangeOverShoulderSprintMode;

	// Token: 0x0400CEE2 RID: 52962
	[Nullable(2)]
	private OverShoulderModeConfig OverShoulderConfig;

	// Token: 0x0400CEE3 RID: 52963
	private global::Vector LastCameraDir = global::Vector.Create();
}
