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
	// Token: 0x02006FC8 RID: 28616
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class InputController : ControllerBase
	{
		// Token: 0x06045970 RID: 285040 RVA: 0x01147F28 File Offset: 0x01146128
		public bool IsAllMoveEnable()
		{
			return this.CanMoveFront && this.CanMoveBack && this.CanMoveLeft && this.CanMoveRight;
		}

		// Token: 0x06045971 RID: 285041 RVA: 0x01147F4C File Offset: 0x0114614C
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

		// Token: 0x17009B8F RID: 39823
		// (get) Token: 0x06045972 RID: 285042 RVA: 0x01147FA1 File Offset: 0x011461A1
		[Nullable(2)]
		public InputModel Model
		{
			[NullableContext(2)]
			get
			{
				return InputModel.Instance;
			}
		}

		// Token: 0x06045973 RID: 285043 RVA: 0x01147FA8 File Offset: 0x011461A8
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x06045974 RID: 285044 RVA: 0x01147FB1 File Offset: 0x011461B1
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x06045975 RID: 285045 RVA: 0x01147FBC File Offset: 0x011461BC
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
			EventSystem.Instance.Add(EEventName.ForceReleaseInput, new Action<string>(this.OnForceReleaseInput));
			EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Add<string, int?>(EEventName.RefreshInputData, new Action<string, int?>(this.OnRefreshInputData));
		}

		// Token: 0x06045976 RID: 285046 RVA: 0x01148074 File Offset: 0x01146274
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
			EventSystem.Instance.Remove(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Remove(EEventName.ForceReleaseInput, new Action<string>(this.OnForceReleaseInput));
			EventSystem.Instance.Remove(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
			EventSystem.Instance.Remove(EEventName.RefreshInputData, new Action<string, int?>(this.OnRefreshInputData));
		}

		// Token: 0x06045977 RID: 285047 RVA: 0x0114812C File Offset: 0x0114632C
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

		// Token: 0x06045978 RID: 285048 RVA: 0x011481B4 File Offset: 0x011463B4
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

		// Token: 0x06045979 RID: 285049 RVA: 0x011481F8 File Offset: 0x011463F8
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

		// Token: 0x0604597A RID: 285050 RVA: 0x01148243 File Offset: 0x01146443
		public void BindInputActions(List<string> actionNames)
		{
			InputDistributeController.Instance.BindActions(actionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0604597B RID: 285051 RVA: 0x0114825C File Offset: 0x0114645C
		public void UnBindInputActions(List<string> actionNames)
		{
			InputDistributeController.Instance.UnBindActions(actionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0604597C RID: 285052 RVA: 0x01148275 File Offset: 0x01146475
		public void BindInputMoveAxes(List<string> axisNames)
		{
			InputDistributeController.Instance.BindAxes(axisNames, new TInputHandle<float>(this.OnInputMoveAxis));
		}

		// Token: 0x0604597D RID: 285053 RVA: 0x0114828E File Offset: 0x0114648E
		public void UnBindInputMoveAxes(List<string> axisNames)
		{
			InputDistributeController.Instance.UnBindAxes(axisNames, new TInputHandle<float>(this.OnInputMoveAxis));
		}

		// Token: 0x0604597E RID: 285054 RVA: 0x011482A8 File Offset: 0x011464A8
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

		// Token: 0x0604597F RID: 285055 RVA: 0x0114834C File Offset: 0x0114654C
		private void OnCloseLoadingView()
		{
			if (Info.Instance.PlatformType == ESourcePlatformType.IOS || Platform.Instance.CloudGamePlatform == ECloudGamePlatform.IOS.ToEnumString() || Platform.Instance.CloudGamePlatform == ECloudGamePlatform.Mac.ToEnumString())
			{
				int num = 0;
				int playerIndex = 0;
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey(new FName(EKey.Gamepad_LeftY)), (float)num);
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey(new FName(EKey.Gamepad_RightX)), (float)num);
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey(new FName(EKey.Gamepad_RightY)), (float)num);
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey(new FName(EKey.Gamepad_LeftX)), (float)num);
			}
		}

		// Token: 0x06045980 RID: 285056 RVA: 0x01148420 File Offset: 0x01146620
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

		// Token: 0x06045981 RID: 285057 RVA: 0x011484D8 File Offset: 0x011466D8
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

		// Token: 0x06045982 RID: 285058 RVA: 0x011485D4 File Offset: 0x011467D4
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

		// Token: 0x06045983 RID: 285059 RVA: 0x011486F8 File Offset: 0x011468F8
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

		// Token: 0x06045984 RID: 285060 RVA: 0x01148834 File Offset: 0x01146A34
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

		// Token: 0x06045985 RID: 285061 RVA: 0x01148895 File Offset: 0x01146A95
		private void TryRefreshInputData(int instanceId)
		{
			this.TryUnBindCurrentInputData();
			this.TryBindInputData(instanceId);
		}

		// Token: 0x06045986 RID: 285062 RVA: 0x011488A4 File Offset: 0x01146AA4
		private void OnInstanceChange(int lastInstanceId, int newInstanceId)
		{
			this.TryRefreshInputData(newInstanceId);
		}

		// Token: 0x06045987 RID: 285063 RVA: 0x011488B0 File Offset: 0x01146AB0
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

		// Token: 0x06045988 RID: 285064 RVA: 0x01148974 File Offset: 0x01146B74
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

		// Token: 0x06045989 RID: 285065 RVA: 0x01148A2C File Offset: 0x01146C2C
		public void GmSwitchBattleInputData(EInputDataType inputDataType)
		{
			this.TryUnBindCurrentInputData();
			this.HandleBindInputData(inputDataType);
		}

		// Token: 0x0604598A RID: 285066 RVA: 0x01148A3C File Offset: 0x01146C3C
		public void AddInputHandler(IInputHandler handler)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.AddInputHandler(handler);
		}

		// Token: 0x0604598B RID: 285067 RVA: 0x01148A5C File Offset: 0x01146C5C
		public void RemoveInputHandler(IInputHandler handler)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.RemoveInputHandler(handler);
		}

		// Token: 0x0604598C RID: 285068 RVA: 0x01148A7C File Offset: 0x01146C7C
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

		// Token: 0x0604598D RID: 285069 RVA: 0x01148BC8 File Offset: 0x01146DC8
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

		// Token: 0x0604598E RID: 285070 RVA: 0x01148CA4 File Offset: 0x01146EA4
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

		// Token: 0x0604598F RID: 285071 RVA: 0x01148E14 File Offset: 0x01147014
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

		// Token: 0x06045990 RID: 285072 RVA: 0x01148E54 File Offset: 0x01147054
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

		// Token: 0x06045991 RID: 285073 RVA: 0x01149218 File Offset: 0x01147418
		public int? QueryCommandPriority(ECommandType commandType)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return null;
			}
			return model.QueryCommandPriority(commandType);
		}

		// Token: 0x06045992 RID: 285074 RVA: 0x01149240 File Offset: 0x01147440
		public bool IsKeyDown(EInputAction action)
		{
			InputModel model = this.Model;
			float num;
			return model != null && model.GetPressTimes().TryGetValue(action, out num) && num != -1f;
		}

		// Token: 0x06045993 RID: 285075 RVA: 0x01149278 File Offset: 0x01147478
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

		// Token: 0x06045994 RID: 285076 RVA: 0x011492D8 File Offset: 0x011474D8
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

		// Token: 0x06045995 RID: 285077 RVA: 0x0114932C File Offset: 0x0114752C
		private float InvertDeltaTimeBySelfCenter(float deltaTime)
		{
			CharacterModel instance = CharacterModel.Instance;
			float num = (instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f;
			return deltaTime * num;
		}

		// Token: 0x06045996 RID: 285078 RVA: 0x01149352 File Offset: 0x01147552
		public void SetForceFeedbackConfig(EGlobalKuroForceFeedbackType feedbackConfig, int globalFeedbackCoef)
		{
			ABasePlayerController.SetKuroForceFeedbackConfig(feedbackConfig, globalFeedbackCoef);
		}

		// Token: 0x06045997 RID: 285079 RVA: 0x0114935C File Offset: 0x0114755C
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

		// Token: 0x06045998 RID: 285080 RVA: 0x01149384 File Offset: 0x01147584
		public void RemoveInputLayer(InputLayer layer)
		{
			InputModel model = this.Model;
			if (model == null)
			{
				return;
			}
			model.RemoveInputLayer(layer);
		}

		// Token: 0x06045999 RID: 285081 RVA: 0x011493A4 File Offset: 0x011475A4
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

		// Token: 0x0604599A RID: 285082 RVA: 0x01149464 File Offset: 0x01147664
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

		// Token: 0x0604599B RID: 285083 RVA: 0x01149488 File Offset: 0x01147688
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

		// Token: 0x17009B90 RID: 39824
		// (get) Token: 0x0604599C RID: 285084 RVA: 0x011494A8 File Offset: 0x011476A8
		public static InputController Instance
		{
			get
			{
				return InputController._Instance;
			}
		}

		// Token: 0x0604599D RID: 285085 RVA: 0x011494AF File Offset: 0x011476AF
		public static InputController GetOrCreateInstance()
		{
			if (InputController._Instance == null)
			{
				InputController.CreateInstance();
			}
			return InputController._Instance;
		}

		// Token: 0x0604599E RID: 285086 RVA: 0x011494C3 File Offset: 0x011476C3
		public static bool CreateInstance()
		{
			if (InputController._Instance != null)
			{
				return true;
			}
			InputController._Instance = new InputController();
			return true;
		}

		// Token: 0x0604599F RID: 285087 RVA: 0x011494D9 File Offset: 0x011476D9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060459A0 RID: 285088 RVA: 0x011494DB File Offset: 0x011476DB
		public static void ResetStaticDefaultValue()
		{
			InputController._Instance = null;
		}

		// Token: 0x060459A1 RID: 285089 RVA: 0x011494E3 File Offset: 0x011476E3
		static InputController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputController.CreateStaticDefaultValue), new Action(InputController.ResetStaticDefaultValue));
		}

		// Token: 0x040244FE RID: 148734
		private const int KEY_RELEASED_TIME = -1;

		// Token: 0x040244FF RID: 148735
		private readonly Stat PostProcessInputStat = Stat.Create("InputController.PostProcessInput", "", "");

		// Token: 0x04024500 RID: 148736
		private readonly Stat HandleInputAxisStat = Stat.Create("InputController.HandleInputAxis", "", "");

		// Token: 0x04024501 RID: 148737
		private readonly Stat HandleHoldStat = Stat.Create("InputController.HandleHold", "", "");

		// Token: 0x04024502 RID: 148738
		private readonly Stat UnBindInputDataStat = Stat.Create("InputController.UnBindInputData", "", "");

		// Token: 0x04024503 RID: 148739
		private readonly Stat HandleBindInputDataStat = Stat.Create("InputController.HandleBindInputData", "", "");

		// Token: 0x04024504 RID: 148740
		private readonly Stat BindInputDataStat = Stat.Create("InputController.BindInputData", "", "");

		// Token: 0x04024505 RID: 148741
		private readonly Stat AddViewHotKeyActionByTypeStat = Stat.Create("InputController.AddViewHotKeyActionByType", "", "");

		// Token: 0x04024506 RID: 148742
		private readonly Stat SwitchKeysByBindingTypeStat = Stat.Create("InputController.SwitchKeysByBindingType", "", "");

		// Token: 0x04024507 RID: 148743
		private bool CanMoveFront = true;

		// Token: 0x04024508 RID: 148744
		private bool CanMoveBack = true;

		// Token: 0x04024509 RID: 148745
		private bool CanMoveLeft = true;

		// Token: 0x0402450A RID: 148746
		private bool CanMoveRight = true;

		// Token: 0x0402450B RID: 148747
		private HashSet<EInputAxis> AutoClearAxisSet = new HashSet<EInputAxis>();

		// Token: 0x0402450C RID: 148748
		[Nullable(2)]
		private static InputController _Instance;
	}
}
