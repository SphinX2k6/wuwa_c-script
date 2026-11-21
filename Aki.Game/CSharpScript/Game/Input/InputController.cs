using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input.BattleInputData;
using CSharpScript.Game.Input.InputActionLogic;
using CSharpScript.Game.Input.InputDataTypeCreator;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.Input;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006149 RID: 24905
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class InputController : ControllerBase
	{
		// Token: 0x0603BB20 RID: 244512 RVA: 0x010F1D08 File Offset: 0x010EFF08
		public bool IsAllMoveEnable()
		{
			return this.CanMoveFront && this.CanMoveBack && this.CanMoveLeft && this.CanMoveRight;
		}

		// Token: 0x0603BB21 RID: 244513 RVA: 0x010F1D2C File Offset: 0x010EFF2C
		public void InitializeEnvironment()
		{
			InputDataTypeCreatorFactory.Initialize();
			InputActionLogicFactory.Initialize();
			if (Info.Instance.UseFastInputCallback)
			{
				UKuroInputDelegateLibrary.InitializeEnvironment();
			}
			if (Info.Instance.AxisInputOptimize)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Input.AxisOptimize 1", null);
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Input.AxisOptimize 0", null);
		}

		// Token: 0x170070CF RID: 28879
		// (get) Token: 0x0603BB22 RID: 244514 RVA: 0x010F1D81 File Offset: 0x010EFF81
		[Nullable(2)]
		public InputModel Model
		{
			[NullableContext(2)]
			get
			{
				return InputModel.Instance;
			}
		}

		// Token: 0x0603BB23 RID: 244515 RVA: 0x010F1D88 File Offset: 0x010EFF88
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x0603BB24 RID: 244516 RVA: 0x010F1D91 File Offset: 0x010EFF91
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x0603BB25 RID: 244517 RVA: 0x010F1D9C File Offset: 0x010EFF9C
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
			EventSystem.Instance.Add(EEventName.ForceReleaseInput, new Action<string>(this.OnForceReleaseInput));
			EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Add<string, int?>(EEventName.RefreshInputData, new Action<string, int?>(this.OnRefreshInputData));
		}

		// Token: 0x0603BB26 RID: 244518 RVA: 0x010F1E54 File Offset: 0x010F0054
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
			EventSystem.Instance.Remove(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Remove(EEventName.ForceReleaseInput, new Action<string>(this.OnForceReleaseInput));
			EventSystem.Instance.Remove(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Remove(EEventName.RefreshInputData, new Action<string, int?>(this.OnRefreshInputData));
		}

		// Token: 0x0603BB27 RID: 244519 RVA: 0x010F1F0C File Offset: 0x010F010C
		private void OnInputCameraAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			BattleInputData currentInputData = model.GetCurrentInputData();
			if (currentInputData == null)
			{
				return;
			}
			EInputAxis? inputAxis = inputIdentification.GetInputAxis(currentInputData);
			if (inputAxis == null)
			{
				return;
			}
			this.InputAxis(inputAxis.Value, value, false);
			APlayerController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			if (value > 0f && inputAxis.Value != EInputAxis.Zoom && Info.Instance.IsInKeyBoard() && !characterController.bShowMouseCursor)
			{
				InputManager.Instance.MoveCursorToCenter();
			}
		}

		// Token: 0x0603BB28 RID: 244520 RVA: 0x010F1F94 File Offset: 0x010F0194
		private void OnInputMoveAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			BattleInputData currentInputData = model.GetCurrentInputData();
			if (currentInputData == null)
			{
				return;
			}
			EInputAxis? inputAxis = inputIdentification.GetInputAxis(currentInputData);
			if (inputAxis == null)
			{
				return;
			}
			this.InputAxis(inputAxis.Value, value, false);
		}

		// Token: 0x0603BB29 RID: 244521 RVA: 0x010F1FD8 File Offset: 0x010F01D8
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			EInputState state = (actionType == InputDistributeDefine.EActionType.Press) ? EInputState.Press : EInputState.Release;
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			BattleInputData currentInputData = model.GetCurrentInputData();
			if (currentInputData == null)
			{
				return;
			}
			EInputAction? inputAction = inputIdentification.GetInputAction(currentInputData);
			if (inputAction == null)
			{
				return;
			}
			this.InputAction(inputAction.Value, state);
		}

		// Token: 0x0603BB2A RID: 244522 RVA: 0x010F2023 File Offset: 0x010F0223
		public void BindInputActions(List<string> actionNames)
		{
			InputDistributeController.Instance.BindActions(actionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603BB2B RID: 244523 RVA: 0x010F203C File Offset: 0x010F023C
		public void UnBindInputActions(List<string> actionNames)
		{
			InputDistributeController.Instance.UnBindActions(actionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603BB2C RID: 244524 RVA: 0x010F2055 File Offset: 0x010F0255
		public void BindInputMoveAxes(List<string> axisNames)
		{
			InputDistributeController.Instance.BindAxes(axisNames, new TInputHandle<float>(this.OnInputMoveAxis));
		}

		// Token: 0x0603BB2D RID: 244525 RVA: 0x010F206E File Offset: 0x010F026E
		public void UnBindInputMoveAxes(List<string> axisNames)
		{
			InputDistributeController.Instance.UnBindAxes(axisNames, new TInputHandle<float>(this.OnInputMoveAxis));
		}

		// Token: 0x0603BB2E RID: 244526 RVA: 0x010F2088 File Offset: 0x010F0288
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			bool flag = plotInfo.PlotLevel == EPlotLevel.LevelD || plotInfo.PlotLevel == EPlotLevel.LevelE;
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			EInputDataType currentInputDataType = model.GetCurrentInputDataType();
			foreach (KeyValuePair<EInputAction, float> keyValuePair in model.GetPressTimes())
			{
				EInputAction key = keyValuePair.Key;
				if (flag)
				{
					InputActionLogicBase inputActionLogic = InputActionLogicFactory.GetInputActionLogic(key);
					if (inputActionLogic != null && !inputActionLogic.IsAllowReleaseInput(currentInputDataType))
					{
						continue;
					}
				}
				this.InputAction(key, EInputState.Release);
			}
		}

		// Token: 0x0603BB2F RID: 244527 RVA: 0x010F212C File Offset: 0x010F032C
		private void OnCloseLoadingView()
		{
			if (Info.Instance.PlatformType == ESourcePlatformType.IOS || Platform.Instance.CloudGamePlatform == ECloudGamePlatform.IOS.ToEnumString() || Platform.Instance.CloudGamePlatform == ECloudGamePlatform.Mac.ToEnumString())
			{
				int num = 0;
				int playerIndex = 0;
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey
				{
					KeyName = new FName(EKey.Gamepad_LeftY)
				}, (float)num);
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey
				{
					KeyName = new FName(EKey.Gamepad_RightX)
				}, (float)num);
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey
				{
					KeyName = new FName(EKey.Gamepad_RightY)
				}, (float)num);
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey
				{
					KeyName = new FName(EKey.Gamepad_LeftX)
				}, (float)num);
			}
		}

		// Token: 0x0603BB30 RID: 244528 RVA: 0x010F2218 File Offset: 0x010F0418
		private void OnForceReleaseInput(string reason)
		{
			if (!string.IsNullOrEmpty(reason))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "强制释放所有按键";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			EInputDataType currentInputDataType = model.GetCurrentInputDataType();
			foreach (KeyValuePair<EInputAction, float> keyValuePair in model.GetPressTimes())
			{
				EInputAction key = keyValuePair.Key;
				InputActionLogicBase inputActionLogic = InputActionLogicFactory.GetInputActionLogic(key);
				if (inputActionLogic == null || inputActionLogic.IsAllowReleaseInput(currentInputDataType))
				{
					this.InputAction(key, EInputState.Release);
				}
			}
		}

		// Token: 0x0603BB31 RID: 244529 RVA: 0x010F22D0 File Offset: 0x010F04D0
		private void ForceClearAxisInput(string reason)
		{
			if (reason.Length > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "强制清理所有轴输入";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (this.Model == null)
			{
				return;
			}
			Dictionary<EInputAxis, float> axisValues = this.Model.GetAxisValues();
			List<IInputHandler> handlers = this.Model.GetHandlers();
			foreach (KeyValuePair<EInputAxis, float> keyValuePair in axisValues)
			{
				EInputAxis key = keyValuePair.Key;
				if (keyValuePair.Value != 0f)
				{
					axisValues[key] = 0f;
					foreach (IInputHandler inputHandler in handlers)
					{
						inputHandler.ClearSingleAxisInput(key, false);
					}
				}
			}
		}

		// Token: 0x0603BB32 RID: 244530 RVA: 0x010F23CC File Offset: 0x010F05CC
		private unsafe void TryUnBindCurrentInputData()
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			BattleInputData currentInputData = model.GetCurrentInputData();
			if (currentInputData != null)
			{
				string[] actionNameList = currentInputData.GetActionNameList();
				string[] moveAxisList = currentInputData.GetMoveAxisList();
				string[] cameraAxisList = currentInputData.GetCameraAxisList();
				InputDistributeController.Instance.UnBindActions(actionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
				InputDistributeController.Instance.UnBindAxes(moveAxisList, new TInputHandle<float>(this.OnInputMoveAxis));
				InputDistributeController.Instance.UnBindAxes(cameraAxisList, new TInputHandle<float>(this.OnInputCameraAxis));
				InputManager.Instance.RemoveViewHotKeyActionByType(currentInputData.Type);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "InstanceChange解除绑定";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("输入数据类型", currentInputData.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionNameList", actionNameList);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("moveAxisNameList", moveAxisList);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("cameraAxisNameList", cameraAxisList);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}

		// Token: 0x0603BB33 RID: 244531 RVA: 0x010F24F0 File Offset: 0x010F06F0
		private unsafe void HandleBindInputData(EInputDataType inputDataType)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.SetCurrentInputDataType(inputDataType);
			BattleInputData currentInputData = model.GetCurrentInputData();
			if (currentInputData != null)
			{
				string[] actionNameList = currentInputData.GetActionNameList();
				string[] moveAxisList = currentInputData.GetMoveAxisList();
				string[] cameraAxisList = currentInputData.GetCameraAxisList();
				InputDistributeController.Instance.BindActions(actionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
				InputDistributeController.Instance.BindAxes(moveAxisList, new TInputHandle<float>(this.OnInputMoveAxis));
				InputDistributeController.Instance.BindAxes(cameraAxisList, new TInputHandle<float>(this.OnInputCameraAxis));
				InputManager.Instance.AddViewHotKeyActionByType(currentInputData.Type);
				InputSettingsManager.Instance.SwitchKeysByBindingType(currentInputData.KeyBindingType);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "InstanceChange绑定输入";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("输入数据类型", currentInputData.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionNameList", actionNameList);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("moveAxisNameList", moveAxisList);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("cameraAxisNameList", cameraAxisList);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}

		// Token: 0x0603BB34 RID: 244532 RVA: 0x010F262C File Offset: 0x010F082C
		private void TryBindInputData(int instanceId)
		{
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			if (instance == null)
			{
				return;
			}
			InstanceDungeon? config = instance.GetConfig(instanceId);
			if (config == null)
			{
				return;
			}
			InputDataTypeCreator inputDataCreator = InputDataTypeCreatorFactory.GetInputDataCreator((EDungeonSubType)config.Value.InstSubType, (EWorldDungeonSubType)config.Value.WorldDungeonSubType);
			if (inputDataCreator == null)
			{
				return;
			}
			EInputDataType inputDataType = inputDataCreator.GetInputDataType();
			this.HandleBindInputData(inputDataType);
		}

		// Token: 0x0603BB35 RID: 244533 RVA: 0x010F268D File Offset: 0x010F088D
		private void TryRefreshInputData(int instanceId)
		{
			this.TryUnBindCurrentInputData();
			this.TryBindInputData(instanceId);
		}

		// Token: 0x0603BB36 RID: 244534 RVA: 0x010F269C File Offset: 0x010F089C
		private void OnInstanceChange(int lastInstanceId, int newInstanceId)
		{
			this.TryRefreshInputData(newInstanceId);
		}

		// Token: 0x0603BB37 RID: 244535 RVA: 0x010F26A8 File Offset: 0x010F08A8
		private unsafe void OnRefreshInputData(string reason, int? type)
		{
			if (type.GetValueOrDefault() == 1)
			{
				this.OnForceReleaseInput("OnRefreshInputData");
			}
			else if (type.GetValueOrDefault() == 2)
			{
				this.ForceClearAxisInput("OnRefreshInputData");
			}
			else
			{
				this.OnForceReleaseInput("OnRefreshInputData");
				this.ForceClearAxisInput("OnRefreshInputData");
			}
			CreatureModel instance = CreatureModel.Instance;
			if (instance == null)
			{
				return;
			}
			int instanceId = instance.GetInstanceId();
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "刷新当前绑定输入";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原因", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前副本id", instanceId);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.TryRefreshInputData(instanceId);
		}

		// Token: 0x0603BB38 RID: 244536 RVA: 0x010F276C File Offset: 0x010F096C
		private void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			if (instance == null)
			{
				return;
			}
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			foreach (KeyValuePair<EInputAction, float> keyValuePair in model.GetPressTimes())
			{
				EInputAction key = keyValuePair.Key;
				string actionInputDistributeTagName = instance.GetActionInputDistributeTagName(keyValuePair.Key.Name);
				if (!string.IsNullOrEmpty(actionInputDistributeTagName) && !instance.IsTagMatchAnyCurrentInputTag(actionInputDistributeTagName, false) && !instance.IsPreventIgnoredAction(keyValuePair.Key.Name))
				{
					this.InputAction(key, EInputState.Release);
				}
			}
			model.NextFrameRefreshAxisValues();
		}

		// Token: 0x0603BB39 RID: 244537 RVA: 0x010F2824 File Offset: 0x010F0A24
		public void GmSwitchBattleInputData(EInputDataType inputDataType)
		{
			this.TryUnBindCurrentInputData();
			this.HandleBindInputData(inputDataType);
		}

		// Token: 0x0603BB3A RID: 244538 RVA: 0x010F2834 File Offset: 0x010F0A34
		public void AddInputHandler(IInputHandler handler)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.AddInputHandler(handler);
		}

		// Token: 0x0603BB3B RID: 244539 RVA: 0x010F2854 File Offset: 0x010F0A54
		public void RemoveInputHandler(IInputHandler handler)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.RemoveInputHandler(handler);
		}

		// Token: 0x0603BB3C RID: 244540 RVA: 0x010F2874 File Offset: 0x010F0A74
		public void InputAction(EInputAction action, EInputState state)
		{
			if (EInputAction.锁定目标 == action && !FunctionModel.Instance.IsOpen(10031))
			{
				return;
			}
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			Dictionary<EInputAction, float> pressTimes = model.GetPressTimes();
			if (state == EInputState.Press)
			{
				model.SetHoldTime(action, null);
				float num = (float)Time.Instance.WorldTimeSeconds;
				pressTimes[action] = num;
				List<IInputHandler> handlers = model.GetHandlers();
				for (int i = 0; i < handlers.Count; i++)
				{
					IInputHandler inputHandler = handlers[i];
					InputFilter inputFilter = inputHandler.GetInputFilter();
					if (inputFilter.BlockAction(action))
					{
						return;
					}
					if (inputFilter.ListenToAction(action))
					{
						inputHandler.HandlePressEvent(action, num);
					}
				}
				return;
			}
			if (state != EInputState.Release)
			{
				return;
			}
			float num2;
			if (!pressTimes.TryGetValue(action, out num2))
			{
				num2 = -1f;
			}
			if (num2 == -1f)
			{
				return;
			}
			float time = this.QueryHoldTimeAccumulate(action);
			model.SetHoldTime(action, new float?((float)-1));
			pressTimes[action] = -1f;
			List<IInputHandler> handlers2 = model.GetHandlers();
			for (int j = 0; j < handlers2.Count; j++)
			{
				IInputHandler inputHandler2 = handlers2[j];
				InputFilter inputFilter2 = inputHandler2.GetInputFilter();
				if (inputFilter2.BlockAction(action))
				{
					break;
				}
				if (inputFilter2.ListenToAction(action))
				{
					inputHandler2.HandleReleaseEvent(action, time);
				}
			}
		}

		// Token: 0x0603BB3D RID: 244541 RVA: 0x010F29C0 File Offset: 0x010F0BC0
		public void SetMoveControlEnabled(bool bFront, bool bBack, bool bLeft, bool bRight)
		{
			this.CanMoveFront = bFront;
			this.CanMoveBack = bBack;
			this.CanMoveLeft = bLeft;
			this.CanMoveRight = bRight;
			if (!Info.Instance.AxisInputOptimize)
			{
				return;
			}
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.NextFrameRefreshAxisValues();
			if (bFront && bBack && bLeft && bRight)
			{
				return;
			}
			Dictionary<EInputAxis, float> axisValues = model.GetAxisValues();
			List<IInputHandler> handlers = model.GetHandlers();
			if (!bFront || !bBack)
			{
				axisValues[EInputAxis.MoveForward] = 0f;
				for (int i = 0; i < handlers.Count; i++)
				{
					handlers[i].ClearSingleAxisInput(EInputAxis.MoveForward, false);
				}
			}
			if (!bRight || !bLeft)
			{
				axisValues[EInputAxis.MoveRight] = 0f;
				for (int j = 0; j < handlers.Count; j++)
				{
					handlers[j].ClearSingleAxisInput(EInputAxis.MoveRight, false);
				}
			}
		}

		// Token: 0x0603BB3E RID: 244542 RVA: 0x010F2A9C File Offset: 0x010F0C9C
		public unsafe void InputAxis(EInputAxis axis, float value, bool autoClear = true)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			Dictionary<EInputAxis, float> axisValues = model.GetAxisValues();
			if (Info.Instance.AxisInputOptimize)
			{
				if (autoClear)
				{
					this.AutoClearAxisSet.Add(axis);
				}
				float num;
				if (axisValues.TryGetValue(axis, out num) && num == value)
				{
					return;
				}
			}
			else if (value == 0f && axisValues.ContainsKey(axis))
			{
				return;
			}
			if (InputModel.Instance.IsOpenInputAxisLog && axis == (EInputAxis)3)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputLog][InputController]开始接收输入";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("axis", axis);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (axis == EInputAxis.MoveForward)
			{
				if (!this.CanMoveFront && value > 0f)
				{
					return;
				}
				if (!this.CanMoveBack && value < 0f)
				{
					return;
				}
			}
			if (axis == EInputAxis.MoveRight)
			{
				if (!this.CanMoveRight && value > 0f)
				{
					return;
				}
				if (!this.CanMoveLeft && value < 0f)
				{
					return;
				}
			}
			axisValues[axis] = value;
			if (InputModel.Instance.IsOpenInputAxisLog)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Input;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "[InputLog][InputController]完成接收输入";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisSet", axisValues);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0603BB3F RID: 244543 RVA: 0x010F2C0C File Offset: 0x010F0E0C
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			List<IInputHandler> handlers = model.GetHandlers();
			for (int i = 0; i < handlers.Count; i++)
			{
				handlers[i].PreProcessInput(deltaTime, gamePaused);
			}
		}

		// Token: 0x0603BB40 RID: 244544 RVA: 0x010F2C4C File Offset: 0x010F0E4C
		public unsafe void PostProcessInput(float deltaTime, bool gamePaused)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			List<IInputHandler> handlers = model.GetHandlers();
			foreach (KeyValuePair<EInputAxis, float> keyValuePair in model.GetAxisValues())
			{
				EInputAxis key = keyValuePair.Key;
				float value = keyValuePair.Value;
				for (int i = 0; i < handlers.Count; i++)
				{
					IInputHandler inputHandler = handlers[i];
					InputFilter inputFilter = inputHandler.GetInputFilter();
					if (inputFilter.BlockAxis(key))
					{
						inputHandler.ClearSingleAxisInput(key, false);
						break;
					}
					if (inputFilter.ListenToAxis(key))
					{
						if (InputModel.Instance.IsOpenInputAxisLog && key == (EInputAxis)3)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Input;
							ELogAuthor author = ELogAuthor.XXJ;
							string message = "[InputLog][InputController]开始处理轴输入";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("axis", key);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
							instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						inputHandler.HandleInputAxis(key, value);
					}
				}
			}
			foreach (KeyValuePair<EInputAction, float> keyValuePair2 in model.GetHoldTimes())
			{
				EInputAction key2 = keyValuePair2.Key;
				float value2 = keyValuePair2.Value;
				if (value2 != -1f)
				{
					float num = this.InvertDeltaTimeBySelfCenter(deltaTime);
					float num2 = value2 + num;
					model.SetHoldTime(key2, new float?(num2));
					for (int j = 0; j < handlers.Count; j++)
					{
						IInputHandler inputHandler2 = handlers[j];
						InputFilter inputFilter2 = inputHandler2.GetInputFilter();
						if (inputFilter2.BlockAction(key2))
						{
							break;
						}
						if (inputFilter2.ListenToAction(key2))
						{
							inputHandler2.HandleHoldEvent(key2, num2);
						}
					}
				}
			}
			try
			{
				for (int k = 0; k < handlers.Count; k++)
				{
					handlers[k].PostProcessInput(deltaTime, gamePaused);
				}
			}
			catch (Exception ex)
			{
				if (ex != null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Json;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "PostProcessInput";
					Exception error = ex;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("msg", ex.Message);
					instance2.ErrorWithStack(module2, author2, message2, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Json;
					ELogAuthor author3 = ELogAuthor.XXJ;
					string message3 = "PostProcessInput";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", ex);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			finally
			{
			}
			if (!Info.Instance.AxisInputOptimize)
			{
				model.GetAxisValues().Clear();
			}
			else
			{
				foreach (EInputAxis einputAxis in this.AutoClearAxisSet)
				{
					if (model.GetAxisValues().ContainsKey(einputAxis))
					{
						model.GetAxisValues().Remove(einputAxis);
					}
					for (int l = 0; l < handlers.Count; l++)
					{
						handlers[l].ClearSingleAxisInput(einputAxis, true);
					}
				}
				this.AutoClearAxisSet.Clear();
			}
			if (InputModel.Instance.IsOpenInputAxisLog)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputLog][InputController]开始输入处理完成", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0603BB41 RID: 244545 RVA: 0x010F3010 File Offset: 0x010F1210
		public int? QueryCommandPriority(ECommandType commandType)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return null;
			}
			return model.QueryCommandPriority(commandType);
		}

		// Token: 0x0603BB42 RID: 244546 RVA: 0x010F3038 File Offset: 0x010F1238
		public bool IsKeyDown(EInputAction action)
		{
			InputModel model = this.Model;
			float num;
			return model != null && model.GetPressTimes().TryGetValue(action, out num) && num != -1f;
		}

		// Token: 0x0603BB43 RID: 244547 RVA: 0x010F3070 File Offset: 0x010F1270
		public float GetKeyDownTime(EInputAction action)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return 0f;
			}
			float num;
			if (!model.GetPressTimes().TryGetValue(action, out num))
			{
				return 0f;
			}
			if (num != -1f)
			{
				return (float)Math.Max(0.0, Time.Instance.WorldTimeSeconds - (double)num);
			}
			return 0f;
		}

		// Token: 0x0603BB44 RID: 244548 RVA: 0x010F30D0 File Offset: 0x010F12D0
		private float QueryHoldTimeAccumulate(EInputAction action)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return -1f;
			}
			float? holdTime = model.GetHoldTime(action);
			if (holdTime != null)
			{
				float? num = holdTime;
				float num2 = (float)-1;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					return holdTime.Value;
				}
			}
			return -1f;
		}

		// Token: 0x0603BB45 RID: 244549 RVA: 0x010F3124 File Offset: 0x010F1324
		private float InvertDeltaTimeBySelfCenter(float deltaTime)
		{
			CharacterModel instance = CharacterModel.Instance;
			float num = (instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f;
			return deltaTime * num;
		}

		// Token: 0x0603BB46 RID: 244550 RVA: 0x010F314A File Offset: 0x010F134A
		public void SetForceFeedbackConfig(EGlobalKuroForceFeedbackType feedbackConfig, int globalFeedbackCoef)
		{
			ABasePlayerController.SetKuroForceFeedbackConfig(feedbackConfig, globalFeedbackCoef);
		}

		// Token: 0x0603BB47 RID: 244551 RVA: 0x010F3154 File Offset: 0x010F1354
		public void AddInputLayer(int unitId, InputLayer layer)
		{
			layer.UnitId = unitId;
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.AddInputLayer(unitId, layer);
		}

		// Token: 0x0603BB48 RID: 244552 RVA: 0x010F317C File Offset: 0x010F137C
		public void RemoveInputLayer(InputLayer layer)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.RemoveInputLayer(layer);
		}

		// Token: 0x0603BB49 RID: 244553 RVA: 0x010F319C File Offset: 0x010F139C
		[NullableContext(2)]
		public InputLayer CreateInputLayer(EInputLayer layerType)
		{
			switch (layerType)
			{
			case EInputLayer.None:
				return null;
			case EInputLayer.Character:
				return new CharacterInputLayer();
			case EInputLayer.Extra:
				return new ExtraInputLayer();
			case EInputLayer.Vision:
				return new VisionInputLayer();
			case EInputLayer.Vehicle:
				return new VehicleInputLayer();
			case EInputLayer.Interaction:
				return new InteractionInputLayer();
			case EInputLayer.FollowShooter:
				return new FollowShooterInputLayer();
			case EInputLayer.Manipulate:
				return new ManipulateInputLayer();
			case EInputLayer.ElementalField:
				return new ElementalFieldInputLayer();
			case EInputLayer.TowerDefense:
				return new TowerDefenseInputLayer();
			case EInputLayer.SurvivorsRogue:
				return new SurvivorsRogueInputLayer();
			case EInputLayer.HoldingHands:
				return new HoldingHandsInputLayer();
			case EInputLayer.Panoramic:
				return new PanoramicInputLayer();
			case EInputLayer.OverShoulder:
				return new OverShoulderInputLayer();
			case EInputLayer.Potato:
				return new PotatoInputLayer();
			default:
				if (layerType == EInputLayer.AceAntiCheat)
				{
					return new AceAntiCheatInputLayer();
				}
				if (layerType != EInputLayer.Swallow)
				{
					return null;
				}
				return new SwallowInputLayer();
			}
		}

		// Token: 0x0603BB4A RID: 244554 RVA: 0x010F325C File Offset: 0x010F145C
		[NullableContext(2)]
		public InputLayer GetInputLayer(int unitId, EInputLayer layerType)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return null;
			}
			return model.GetInputLayer(unitId, layerType);
		}

		// Token: 0x0603BB4B RID: 244555 RVA: 0x010F3280 File Offset: 0x010F1480
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<InputLayer> GetInputLayers(int unitId)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return null;
			}
			return model.GetInputLayers(unitId);
		}

		// Token: 0x170070D0 RID: 28880
		// (get) Token: 0x0603BB4C RID: 244556 RVA: 0x010F32A0 File Offset: 0x010F14A0
		public static InputController Instance
		{
			get
			{
				return InputController._Instance;
			}
		}

		// Token: 0x0603BB4D RID: 244557 RVA: 0x010F32A7 File Offset: 0x010F14A7
		public static InputController GetOrCreateInstance()
		{
			if (InputController._Instance == null)
			{
				InputController.CreateInstance();
			}
			return InputController._Instance;
		}

		// Token: 0x0603BB4E RID: 244558 RVA: 0x010F32BB File Offset: 0x010F14BB
		public static bool CreateInstance()
		{
			if (InputController._Instance != null)
			{
				return true;
			}
			InputController._Instance = new InputController();
			return true;
		}

		// Token: 0x0603BB4F RID: 244559 RVA: 0x010F32D1 File Offset: 0x010F14D1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BB50 RID: 244560 RVA: 0x010F32D3 File Offset: 0x010F14D3
		public static void ResetStaticDefaultValue()
		{
			InputController._Instance = null;
		}

		// Token: 0x0603BB51 RID: 244561 RVA: 0x010F32DB File Offset: 0x010F14DB
		static InputController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputController.CreateStaticDefaultValue), new Action(InputController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F7B3 RID: 128947
		private const int KEY_RELEASED_TIME = -1;

		// Token: 0x0401F7B4 RID: 128948
		private readonly Stat PostProcessInputStat = Stat.Create("InputController.PostProcessInput", "", "");

		// Token: 0x0401F7B5 RID: 128949
		private readonly Stat HandleInputAxisStat = Stat.Create("InputController.HandleInputAxis", "", "");

		// Token: 0x0401F7B6 RID: 128950
		private readonly Stat HandleHoldStat = Stat.Create("InputController.HandleHold", "", "");

		// Token: 0x0401F7B7 RID: 128951
		private readonly Stat UnBindInputDataStat = Stat.Create("InputController.UnBindInputData", "", "");

		// Token: 0x0401F7B8 RID: 128952
		private readonly Stat HandleBindInputDataStat = Stat.Create("InputController.HandleBindInputData", "", "");

		// Token: 0x0401F7B9 RID: 128953
		private readonly Stat BindInputDataStat = Stat.Create("InputController.BindInputData", "", "");

		// Token: 0x0401F7BA RID: 128954
		private readonly Stat AddViewHotKeyActionByTypeStat = Stat.Create("InputController.AddViewHotKeyActionByType", "", "");

		// Token: 0x0401F7BB RID: 128955
		private readonly Stat SwitchKeysByBindingTypeStat = Stat.Create("InputController.SwitchKeysByBindingType", "", "");

		// Token: 0x0401F7BC RID: 128956
		private bool CanMoveFront = true;

		// Token: 0x0401F7BD RID: 128957
		private bool CanMoveBack = true;

		// Token: 0x0401F7BE RID: 128958
		private bool CanMoveLeft = true;

		// Token: 0x0401F7BF RID: 128959
		private bool CanMoveRight = true;

		// Token: 0x0401F7C0 RID: 128960
		private HashSet<EInputAxis> AutoClearAxisSet = new HashSet<EInputAxis>();

		// Token: 0x0401F7C1 RID: 128961
		[Nullable(2)]
		private static InputController _Instance;
	}
}
