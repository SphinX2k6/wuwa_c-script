using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Launcher.Platform;
using Google.Protobuf;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF6 RID: 28662
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class InputSettingsController : ControllerBase
	{
		// Token: 0x06045B91 RID: 285585 RVA: 0x01151BEC File Offset: 0x0114FDEC
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.InputSettingUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.InputSettingUpdateNotify));
			EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.OnGetPlayerBasicInfo));
			return true;
		}

		// Token: 0x06045B92 RID: 285586 RVA: 0x01151C27 File Offset: 0x0114FE27
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InputSettingUpdateNotify);
			EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.OnGetPlayerBasicInfo));
			return true;
		}

		// Token: 0x06045B93 RID: 285587 RVA: 0x01151C58 File Offset: 0x0114FE58
		private void OnGetPlayerBasicInfo()
		{
			Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.XXJ, "登录直接请求服务端输入数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InputSettingRequest();
		}

		// Token: 0x06045B94 RID: 285588 RVA: 0x01151C88 File Offset: 0x0114FE88
		[NullableContext(2)]
		private void InputSettingUpdateNotify(IMessage msg, Net.CallbackStatus Status)
		{
			InputSettingUpdateNotify inputSettingUpdateNotify = (InputSettingUpdateNotify)msg;
			if (((inputSettingUpdateNotify != null) ? inputSettingUpdateNotify.InputSettingData : null) == null)
			{
				Log.Instance.Warn(ELogModule.InputSettings, ELogAuthor.TZJ, "输入设置通知缺少InputSettingData，保留当前状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.TryApplySparseInputSettingSnapshot(inputSettingUpdateNotify.InputSettingData))
			{
				EventSystem.Instance.Emit(EEventName.OnInputSettingUpdateNotify);
			}
		}

		// Token: 0x06045B95 RID: 285589 RVA: 0x01151CE8 File Offset: 0x0114FEE8
		public void InputSettingRequest()
		{
			InputSettingRequest message = Aki.Protocol.InputSettingRequest.Create();
			Net.Instance.Call(ERequestMessageId.InputSettingRequest, message, new Action<IMessage, Net.CallbackStatus>(this.InputSettingResponse), 0);
		}

		// Token: 0x06045B96 RID: 285590 RVA: 0x01151D18 File Offset: 0x0114FF18
		[NullableContext(2)]
		private void InputSettingResponse(IMessage msg, Net.CallbackStatus Status)
		{
			InputSettingResponse inputSettingResponse = (InputSettingResponse)msg;
			if (((inputSettingResponse != null) ? inputSettingResponse.InputSettingData : null) == null)
			{
				Log.Instance.Warn(ELogModule.InputSettings, ELogAuthor.TZJ, "输入设置响应缺少InputSettingData，保留当前状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			InputSettingData inputSettingData = inputSettingResponse.InputSettingData;
			if (inputSettingData.InputSettings == null || inputSettingData.InputSettings.Count <= 0)
			{
				this.ApplyEmptyServerInputSettings();
				EventSystem.Instance.Emit(EEventName.OnInputSettingResponse);
				return;
			}
			Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.TZJ, "使用服务端键位数据重建本地输入", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.TryApplySparseInputSettingSnapshot(inputSettingData))
			{
				EventSystem.Instance.Emit(EEventName.OnInputSettingResponse);
			}
		}

		// Token: 0x06045B97 RID: 285591 RVA: 0x01151DC0 File Offset: 0x0114FFC0
		private void ApplyEmptyServerInputSettings()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.AddChangeKeyReason(EGamepadChangeKeyReason.ProtoInputSetting);
			}
			try
			{
				if (LoginModel.Instance.IsNewAccount)
				{
					Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.TZJ, "新号没有服务端键位数据，恢复成配置表默认值", default(ReadOnlySpan<ValueTuple<string, object>>));
					InputSettingsManager.Instance.ResetDefaultInputKey();
				}
				else
				{
					Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.TZJ, "老号没有服务端键位数据，沿用本地已存按键", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			finally
			{
				SkillButtonUiGamepadDataBase gamepadData2 = SkillButtonUiModel.Instance.GamepadData;
				if (gamepadData2 != null)
				{
					gamepadData2.RemoveChangeKeyReason(EGamepadChangeKeyReason.ProtoInputSetting);
				}
			}
			InputSettingsManager.Instance.ClearAppliedServerOverrides();
			GameSettingsUtils.RefreshViewRevertState(Info.Instance.InputControllerMainType);
			if (!Platform.Instance.IsMobilePlatform())
			{
				this.InputSettingUpdateRequest();
			}
		}

		// Token: 0x06045B98 RID: 285592 RVA: 0x01151E88 File Offset: 0x01150088
		public void InputSettingUpdateRequest()
		{
			InputSettingUpdateRequest inputSettingUpdateRequest = Aki.Protocol.InputSettingUpdateRequest.Create();
			inputSettingUpdateRequest.InputSettingData = this.BuildInputSettingsToProtoData();
			Net.Instance.Call(ERequestMessageId.InputSettingUpdateRequest, inputSettingUpdateRequest, new Action<IMessage, Net.CallbackStatus>(this.InputSettingUpdateResponse), 0);
		}

		// Token: 0x06045B99 RID: 285593 RVA: 0x01151EC4 File Offset: 0x011500C4
		[NullableContext(2)]
		private void InputSettingUpdateResponse(IMessage msg, Net.CallbackStatus _)
		{
			InputSettingUpdateResponse inputSettingUpdateResponse = (InputSettingUpdateResponse)msg;
			if (inputSettingUpdateResponse == null)
			{
				return;
			}
			if (inputSettingUpdateResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(inputSettingUpdateResponse.ErrorCode, 29097, null, true, true);
		}

		// Token: 0x06045B9A RID: 285594 RVA: 0x01151F00 File Offset: 0x01150100
		private bool TryGetInputBindType(SettingInputType inputType, out EInputBindingType bindingType)
		{
			foreach (KeyValuePair<EInputBindingType, SettingInputType> keyValuePair in this.InputBindTypeMap)
			{
				EInputBindingType einputBindingType;
				SettingInputType settingInputType;
				keyValuePair.Deconstruct(out einputBindingType, out settingInputType);
				EInputBindingType einputBindingType2 = einputBindingType;
				if (settingInputType == inputType)
				{
					bindingType = einputBindingType2;
					return true;
				}
			}
			bindingType = EInputBindingType.Original;
			return false;
		}

		// Token: 0x06045B9B RID: 285595 RVA: 0x01151F70 File Offset: 0x01150170
		private bool TryGetInputControllerType(InputSettingDevice inputDeviceType, out CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			if (inputDeviceType == InputSettingDevice.Mouse)
			{
				inputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
				return true;
			}
			if (inputDeviceType == InputSettingDevice.Handle)
			{
				inputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad;
				return true;
			}
			inputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.None;
			return false;
		}

		// Token: 0x06045B9C RID: 285596 RVA: 0x01151F88 File Offset: 0x01150188
		private bool TryApplySparseInputSettingSnapshot(InputSettingData inputSettingsData)
		{
			NormalizedInputSettingSnapshot normalizedInputSettingSnapshot = this.TryNormalizeInputSettingSnapshot(inputSettingsData);
			if (normalizedInputSettingSnapshot == null)
			{
				return false;
			}
			string text = InputSettingsManager.Instance.CurrentDeviceLang;
			string serverDeviceLang = normalizedInputSettingSnapshot.KeyboardStorageLang ?? text;
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.AddChangeKeyReason(EGamepadChangeKeyReason.ProtoInputSetting);
			}
			bool result;
			try
			{
				InputSettingsManager.Instance.RebuildDefaultInputSnapshot();
				InputSettingsManager.Instance.ClearAppliedServerOverrides();
				InputSettingApplyCount applyCount = new InputSettingApplyCount();
				bool flag = false;
				foreach (NormalizedOneDeviceInputSetting deviceSetting in normalizedInputSettingSnapshot.DeviceSettings)
				{
					flag |= this.ApplyOneDeviceSparseOverrides(deviceSetting, applyCount);
				}
				bool flag2 = InputSettingsManager.Instance.ConvertAppliedServerKeyboardOverrides(serverDeviceLang, text);
				this.HandleLinkActionKey();
				this.HandleBothActionSyncAllExclusiveKey();
				this.NormalizeActionCombinationActionExclusivity(applyCount);
				InputSettingsManager.Instance.RebuildCurrentCombinationRuntimeMappings();
				bool needNormalizeUpload = flag || flag2;
				this.LogInputSettingApplyResult(normalizedInputSettingSnapshot.DeviceSettings.Count, applyCount, flag2, needNormalizeUpload);
				this.FinishApplyingInputSnapshot(needNormalizeUpload);
				result = true;
			}
			catch (Exception error)
			{
				this.TryRestoreDefaultSnapshot(error);
				result = false;
			}
			finally
			{
				SkillButtonUiGamepadDataBase gamepadData2 = SkillButtonUiModel.Instance.GamepadData;
				if (gamepadData2 != null)
				{
					gamepadData2.RemoveChangeKeyReason(EGamepadChangeKeyReason.ProtoInputSetting);
				}
			}
			return result;
		}

		// Token: 0x06045B9D RID: 285597 RVA: 0x011520D8 File Offset: 0x011502D8
		private unsafe void LogInputSettingApplyResult(int deviceCount, InputSettingApplyCount applyCount, bool deviceLangChanged, bool needNormalizeUpload)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "服务端键位数据应用完成";
			<>y__InlineArray13<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray13<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DeviceCount", deviceCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionApplied", applyCount.ActionApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActionSkipped", applyCount.ActionSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AxisApplied", applyCount.AxisApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AxisSkipped", applyCount.AxisSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("CombinationActionApplied", applyCount.CombinationActionApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("CombinationActionSkipped", applyCount.CombinationActionSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("CombinationAxisApplied", applyCount.CombinationAxisApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("CombinationAxisSkipped", applyCount.CombinationAxisSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("VersionOutdated", applyCount.VersionOutdated);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("ExclusivityCleared", applyCount.ExclusivityCleared);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("DeviceLangChanged", deviceLangChanged);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("NeedNormalizeUpload", needNormalizeUpload);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 13));
		}

		// Token: 0x06045B9E RID: 285598 RVA: 0x011522B9 File Offset: 0x011504B9
		private void FinishApplyingInputSnapshot(bool needNormalizeUpload)
		{
			if (needNormalizeUpload)
			{
				this.InputSettingUpdateRequest();
				return;
			}
			GameSettingsUtils.RefreshViewRevertState(Info.Instance.InputControllerMainType);
		}

		// Token: 0x06045B9F RID: 285599 RVA: 0x011522D4 File Offset: 0x011504D4
		private void TryRestoreDefaultSnapshot(Exception error)
		{
			try
			{
				InputSettingsManager.Instance.RebuildDefaultInputSnapshot();
				InputSettingsManager.Instance.ClearAppliedServerOverrides();
				Log.Instance.ErrorWithStack(ELogModule.InputSettings, ELogAuthor.TZJ, "应用服务端键位数据失败，已把所有键位恢复成配置表默认值", error, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "应用服务端键位数据失败，恢复配置表默认值也失败";
				Exception error2 = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", error.Message);
				instance.ErrorWithStack(module, author, message, error2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06045BA0 RID: 285600 RVA: 0x01152354 File Offset: 0x01150554
		[return: Nullable(2)]
		private unsafe NormalizedInputSettingSnapshot TryNormalizeInputSettingSnapshot(InputSettingData inputSettingsData)
		{
			NormalizedInputSettingSnapshot normalizedInputSettingSnapshot = new NormalizedInputSettingSnapshot();
			IReadOnlyList<OneDeviceInputSetting> inputSettings = inputSettingsData.InputSettings;
			if (inputSettings == null)
			{
				return normalizedInputSettingSnapshot;
			}
			foreach (OneDeviceInputSetting oneDeviceInputSetting in inputSettings)
			{
				InputSettingDevice device = oneDeviceInputSetting.Device;
				CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType;
				if (!this.TryGetInputControllerType(device, out inputControllerType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "服务端键位数据存在未知设备，跳过该设备";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Device", device);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					if (device == InputSettingDevice.Mouse)
					{
						normalizedInputSettingSnapshot.KeyboardStorageLang = (string.IsNullOrEmpty(oneDeviceInputSetting.DeviceSubType) ? null : oneDeviceInputSetting.DeviceSubType);
					}
					NormalizedOneDeviceInputSetting normalizedOneDeviceInputSetting = new NormalizedOneDeviceInputSetting
					{
						Device = device,
						InputControllerType = inputControllerType
					};
					this.NormalizeActionOverrides(oneDeviceInputSetting.InputAction, normalizedOneDeviceInputSetting.ActionOverrides);
					this.NormalizeAxisOverrides(oneDeviceInputSetting.InputAxis, normalizedOneDeviceInputSetting.AxisOverrides);
					this.NormalizeCombinationActionOverrides(oneDeviceInputSetting.InputCombinationAction, normalizedOneDeviceInputSetting.CombinationActionOverrides);
					this.NormalizeCombinationAxisOverrides(oneDeviceInputSetting.InputCombinationAxis, normalizedOneDeviceInputSetting.CombinationAxisOverrides);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "已解析服务端键位数据中一个设备的记录";
					<>y__InlineArray10<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray10<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Device", device);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DeviceSubType", oneDeviceInputSetting.DeviceSubType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActionReceived", oneDeviceInputSetting.InputAction.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ActionKept", normalizedOneDeviceInputSetting.ActionOverrides.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AxisReceived", oneDeviceInputSetting.InputAxis.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("AxisKept", normalizedOneDeviceInputSetting.AxisOverrides.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("CombinationActionReceived", oneDeviceInputSetting.InputCombinationAction.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("CombinationActionKept", normalizedOneDeviceInputSetting.CombinationActionOverrides.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("CombinationAxisReceived", oneDeviceInputSetting.InputCombinationAxis.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("CombinationAxisKept", normalizedOneDeviceInputSetting.CombinationAxisOverrides.Count);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 10));
					normalizedInputSettingSnapshot.DeviceSettings.Add(normalizedOneDeviceInputSetting);
				}
			}
			return normalizedInputSettingSnapshot;
		}

		// Token: 0x06045BA1 RID: 285601 RVA: 0x01152640 File Offset: 0x01150840
		private unsafe void AddWinnerRecord<[Nullable(2)] TRecord>(Dictionary<string, Dictionary<EInputBindingType, TRecord>> winnerMap, string name, EInputBindingType bindingType, TRecord record, string categoryName)
		{
			Dictionary<EInputBindingType, TRecord> dictionary;
			if (!winnerMap.TryGetValue(name, out dictionary))
			{
				dictionary = new Dictionary<EInputBindingType, TRecord>();
				winnerMap[name] = dictionary;
			}
			if (dictionary.ContainsKey(bindingType))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "服务端键位数据中同一精确身份重复出现，只保留最后一条原始记录";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Category", categoryName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", bindingType);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			dictionary[bindingType] = record;
		}

		// Token: 0x06045BA2 RID: 285602 RVA: 0x011526EC File Offset: 0x011508EC
		private void NormalizeActionOverrides([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<InputAction> actionList, List<NormalizedActionOverride> overridesRef)
		{
			if (actionList == null || actionList.Count == 0)
			{
				return;
			}
			Dictionary<string, Dictionary<EInputBindingType, InputAction>> dictionary = new Dictionary<string, Dictionary<EInputBindingType, InputAction>>();
			foreach (InputAction inputAction in actionList)
			{
				EInputBindingType bindingType;
				if (!this.TryGetInputBindType(inputAction.InputType, out bindingType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "Action记录存在未知InputType，跳过该记录";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionName", inputAction.ActionName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.AddWinnerRecord<InputAction>(dictionary, inputAction.ActionName, bindingType, inputAction, "Action");
				}
			}
			foreach (KeyValuePair<string, Dictionary<EInputBindingType, InputAction>> keyValuePair in dictionary)
			{
				string text;
				Dictionary<EInputBindingType, InputAction> dictionary2;
				keyValuePair.Deconstruct(out text, out dictionary2);
				string text2 = text;
				Dictionary<EInputBindingType, InputAction> dictionary3 = dictionary2;
				if (InputSettingsManager.Instance.GetActionBinding(text2) == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "Action记录存在未知ActionName，跳过该记录";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ActionName", text2);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					foreach (KeyValuePair<EInputBindingType, InputAction> keyValuePair2 in dictionary3)
					{
						EInputBindingType einputBindingType;
						InputAction inputAction2;
						keyValuePair2.Deconstruct(out einputBindingType, out inputAction2);
						EInputBindingType bindingType2 = einputBindingType;
						InputAction inputAction3 = inputAction2;
						NormalizedActionOverride normalizedActionOverride = new NormalizedActionOverride
						{
							ActionName = text2,
							BindingType = bindingType2,
							ExclusiveType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2),
							Version = inputAction3.Version
						};
						if (inputAction3.KeyNameList != null)
						{
							normalizedActionOverride.KeyNameList.AddRange(inputAction3.KeyNameList);
						}
						overridesRef.Add(normalizedActionOverride);
					}
				}
			}
		}

		// Token: 0x06045BA3 RID: 285603 RVA: 0x011528EC File Offset: 0x01150AEC
		private void NormalizeAxisOverrides([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<InputAxis> axisList, List<NormalizedAxisOverride> overridesRef)
		{
			if (axisList == null || axisList.Count == 0)
			{
				return;
			}
			Dictionary<string, Dictionary<EInputBindingType, InputAxis>> dictionary = new Dictionary<string, Dictionary<EInputBindingType, InputAxis>>();
			foreach (InputAxis inputAxis in axisList)
			{
				EInputBindingType bindingType;
				if (!this.TryGetInputBindType(inputAxis.InputType, out bindingType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "Axis记录存在未知InputType，跳过该记录";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AxisName", inputAxis.AxisName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.AddWinnerRecord<InputAxis>(dictionary, inputAxis.AxisName, bindingType, inputAxis, "Axis");
				}
			}
			foreach (KeyValuePair<string, Dictionary<EInputBindingType, InputAxis>> keyValuePair in dictionary)
			{
				string text;
				Dictionary<EInputBindingType, InputAxis> dictionary2;
				keyValuePair.Deconstruct(out text, out dictionary2);
				string text2 = text;
				Dictionary<EInputBindingType, InputAxis> dictionary3 = dictionary2;
				if (InputSettingsManager.Instance.GetAxisBinding(text2) == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "Axis记录存在未知AxisName，跳过该记录";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AxisName", text2);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					foreach (KeyValuePair<EInputBindingType, InputAxis> keyValuePair2 in dictionary3)
					{
						EInputBindingType einputBindingType;
						InputAxis inputAxis2;
						keyValuePair2.Deconstruct(out einputBindingType, out inputAxis2);
						EInputBindingType bindingType2 = einputBindingType;
						InputAxis inputAxis3 = inputAxis2;
						NormalizedAxisOverride normalizedAxisOverride = new NormalizedAxisOverride
						{
							AxisName = text2,
							BindingType = bindingType2,
							ExclusiveType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2),
							Version = inputAxis3.Version
						};
						foreach (KeyValuePair<string, int> keyValuePair3 in inputAxis3.KeyScaleMap)
						{
							int num;
							keyValuePair3.Deconstruct(out text, out num);
							string key = text;
							int num2 = num;
							normalizedAxisOverride.KeyScaleMap[key] = (float)num2 / 1000f;
						}
						overridesRef.Add(normalizedAxisOverride);
					}
				}
			}
		}

		// Token: 0x06045BA4 RID: 285604 RVA: 0x01152B48 File Offset: 0x01150D48
		private void NormalizeCombinationActionOverrides([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<Aki.Protocol.CombinationAction> combinationActionList, List<NormalizedCombinationActionOverride> overridesRef)
		{
			if (combinationActionList == null || combinationActionList.Count == 0)
			{
				return;
			}
			Dictionary<string, Dictionary<EInputBindingType, Aki.Protocol.CombinationAction>> dictionary = new Dictionary<string, Dictionary<EInputBindingType, Aki.Protocol.CombinationAction>>();
			foreach (Aki.Protocol.CombinationAction combinationAction in combinationActionList)
			{
				EInputBindingType bindingType;
				if (!this.TryGetInputBindType(combinationAction.InputType, out bindingType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "组合Action记录存在未知InputType，跳过该记录";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionName", combinationAction.ActionName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.AddWinnerRecord<Aki.Protocol.CombinationAction>(dictionary, combinationAction.ActionName, bindingType, combinationAction, "CombinationAction");
				}
			}
			foreach (KeyValuePair<string, Dictionary<EInputBindingType, Aki.Protocol.CombinationAction>> keyValuePair in dictionary)
			{
				string text;
				Dictionary<EInputBindingType, Aki.Protocol.CombinationAction> dictionary2;
				keyValuePair.Deconstruct(out text, out dictionary2);
				string text2 = text;
				foreach (KeyValuePair<EInputBindingType, Aki.Protocol.CombinationAction> keyValuePair2 in dictionary2)
				{
					EInputBindingType einputBindingType;
					Aki.Protocol.CombinationAction combinationAction2;
					keyValuePair2.Deconstruct(out einputBindingType, out combinationAction2);
					EInputBindingType bindingType2 = einputBindingType;
					Aki.Protocol.CombinationAction combinationAction3 = combinationAction2;
					Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
					if (this.TryNormalizeCombinationKeyList(combinationAction3.CombinationKeyList, text2, bindingType2, false, dictionary3))
					{
						overridesRef.Add(new NormalizedCombinationActionOverride
						{
							ActionName = text2,
							BindingType = bindingType2,
							ExclusiveType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2),
							Version = combinationAction3.Version,
							KeyMap = dictionary3
						});
					}
				}
			}
		}

		// Token: 0x06045BA5 RID: 285605 RVA: 0x01152CE8 File Offset: 0x01150EE8
		private unsafe void NormalizeCombinationAxisOverrides([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<Aki.Protocol.CombinationAxis> combinationAxisList, List<NormalizedCombinationAxisOverride> overridesRef)
		{
			if (combinationAxisList == null || combinationAxisList.Count == 0)
			{
				return;
			}
			Dictionary<string, Dictionary<EInputBindingType, Aki.Protocol.CombinationAxis>> dictionary = new Dictionary<string, Dictionary<EInputBindingType, Aki.Protocol.CombinationAxis>>();
			foreach (Aki.Protocol.CombinationAxis combinationAxis in combinationAxisList)
			{
				EInputBindingType bindingType;
				if (!this.TryGetInputBindType(combinationAxis.InputType, out bindingType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "组合Axis记录存在未知InputType，跳过该记录";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AxisName", combinationAxis.AxisName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.AddWinnerRecord<Aki.Protocol.CombinationAxis>(dictionary, combinationAxis.AxisName, bindingType, combinationAxis, "CombinationAxis");
				}
			}
			foreach (KeyValuePair<string, Dictionary<EInputBindingType, Aki.Protocol.CombinationAxis>> keyValuePair in dictionary)
			{
				string text;
				Dictionary<EInputBindingType, Aki.Protocol.CombinationAxis> dictionary2;
				keyValuePair.Deconstruct(out text, out dictionary2);
				string text2 = text;
				Dictionary<EInputBindingType, Aki.Protocol.CombinationAxis> dictionary3 = dictionary2;
				InputCombinationAxisBinding combinationAxisBindingByAxisName = InputSettingsManager.Instance.GetCombinationAxisBindingByAxisName(text2);
				if (combinationAxisBindingByAxisName == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "组合Axis记录存在未知AxisName，跳过该记录";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AxisName", text2);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					foreach (KeyValuePair<EInputBindingType, Aki.Protocol.CombinationAxis> keyValuePair2 in dictionary3)
					{
						EInputBindingType einputBindingType;
						Aki.Protocol.CombinationAxis combinationAxis2;
						keyValuePair2.Deconstruct(out einputBindingType, out combinationAxis2);
						EInputBindingType einputBindingType2 = einputBindingType;
						Aki.Protocol.CombinationAxis combinationAxis3 = combinationAxis2;
						Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
						if (this.TryNormalizeCombinationKeyList(combinationAxis3.CombinationKeyList, text2, einputBindingType2, true, dictionary4))
						{
							bool flag = true;
							foreach (string text3 in dictionary4.Keys)
							{
								float num;
								if (!combinationAxisBindingByAxisName.TryGetSourceAxisValueByBindingType(text3, einputBindingType2, out num))
								{
									Log instance3 = Log.Instance;
									ELogModule module3 = ELogModule.InputSettings;
									ELogAuthor author3 = ELogAuthor.TZJ;
									string message3 = "组合Axis记录的副键找不到有效的轴输入值，该身份保留默认值";
									<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AxisName", text2);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("secondaryKeyName", text3);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", einputBindingType2);
									instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
									flag = false;
									break;
								}
							}
							if (flag)
							{
								overridesRef.Add(new NormalizedCombinationAxisOverride
								{
									AxisName = text2,
									BindingType = einputBindingType2,
									ExclusiveType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(einputBindingType2),
									Version = combinationAxis3.Version,
									KeyMap = dictionary4
								});
							}
						}
					}
				}
			}
		}

		// Token: 0x06045BA6 RID: 285606 RVA: 0x01152FDC File Offset: 0x011511DC
		private unsafe bool TryNormalizeCombinationKeyList([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<CombinationKey> combinationKeyList, string name, EInputBindingType bindingType, bool isAxisOrder, Dictionary<string, string> keyMapRef)
		{
			keyMapRef.Clear();
			if (combinationKeyList == null)
			{
				return true;
			}
			foreach (CombinationKey combinationKey in combinationKeyList)
			{
				IReadOnlyList<string> keyNameList = combinationKey.KeyNameList;
				if (keyNameList == null || keyNameList.Count != 2)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "组合键记录的键对结构错误，该身份保留默认值";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bindingType", bindingType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("keyNameList", keyNameList);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					keyMapRef.Clear();
					return false;
				}
				string text = keyNameList[0];
				string text2 = keyNameList[1];
				if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "组合键记录的键名无效，该身份保留默认值";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Name", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("bindingType", bindingType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("mainKeyName", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("secondaryKeyName", text2);
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
					keyMapRef.Clear();
					return false;
				}
				if (isAxisOrder)
				{
					keyMapRef[text2] = text;
				}
				else
				{
					keyMapRef[text] = text2;
				}
			}
			return true;
		}

		// Token: 0x06045BA7 RID: 285607 RVA: 0x011531A8 File Offset: 0x011513A8
		private bool ApplyOneDeviceSparseOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount)
		{
			return false | this.ApplyNormalizedActionOverrides(deviceSetting, applyCount) | this.ApplyNormalizedAxisOverrides(deviceSetting, applyCount) | this.ApplyNormalizedCombinationActionOverrides(deviceSetting, applyCount) | this.ApplyNormalizedCombinationAxisOverrides(deviceSetting, applyCount);
		}

		// Token: 0x06045BA8 RID: 285608 RVA: 0x011531D0 File Offset: 0x011513D0
		private unsafe void LogVersionOutdatedKeys(string categoryName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, int outdatedCount)
		{
			if (outdatedCount <= 0)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "服务端键位记录的版本号落后于配置表，这些键位保留配置表默认值";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Category", categoryName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InputControllerType", inputControllerType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OutdatedCount", outdatedCount);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x06045BA9 RID: 285609 RVA: 0x01153258 File Offset: 0x01151458
		private bool ApplyNormalizedActionOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedActionOverride normalizedActionOverride in deviceSetting.ActionOverrides)
			{
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(normalizedActionOverride.ActionName);
				if (actionBinding == null)
				{
					applyCount.ActionSkipped++;
				}
				else if ((flag ? actionBinding.GetKeyboardVersion(normalizedActionOverride.ExclusiveType) : actionBinding.GetGamepadVersion(normalizedActionOverride.ExclusiveType)) > normalizedActionOverride.Version)
				{
					applyCount.ActionSkipped++;
					applyCount.VersionOutdated++;
					num++;
					result = true;
				}
				else
				{
					if (flag)
					{
						actionBinding.SetKeyboardKeys(normalizedActionOverride.KeyNameList, normalizedActionOverride.BindingType);
						actionBinding.SetKeyboardVersion(normalizedActionOverride.Version, normalizedActionOverride.ExclusiveType);
						InputSettingsManager.Instance.MarkAppliedKeyboardActionOverride(normalizedActionOverride.ActionName, normalizedActionOverride.BindingType);
					}
					else
					{
						actionBinding.SetGamepadKeys(normalizedActionOverride.KeyNameList, normalizedActionOverride.BindingType);
						actionBinding.SetGamepadVersion(normalizedActionOverride.Version, normalizedActionOverride.ExclusiveType);
					}
					applyCount.ActionApplied++;
				}
			}
			this.LogVersionOutdatedKeys("Action", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x06045BAA RID: 285610 RVA: 0x011533D0 File Offset: 0x011515D0
		private bool ApplyNormalizedAxisOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedAxisOverride normalizedAxisOverride in deviceSetting.AxisOverrides)
			{
				InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(normalizedAxisOverride.AxisName);
				if (axisBinding == null)
				{
					applyCount.AxisSkipped++;
				}
				else if ((flag ? axisBinding.GetKeyboardVersion(normalizedAxisOverride.ExclusiveType) : axisBinding.GetGamepadVersion(normalizedAxisOverride.ExclusiveType)) > normalizedAxisOverride.Version)
				{
					applyCount.AxisSkipped++;
					applyCount.VersionOutdated++;
					num++;
					result = true;
				}
				else
				{
					if (flag)
					{
						axisBinding.SetKeyboardKeys(normalizedAxisOverride.KeyScaleMap, normalizedAxisOverride.BindingType);
						axisBinding.SetKeyboardVersion(normalizedAxisOverride.Version, normalizedAxisOverride.ExclusiveType);
						InputSettingsManager.Instance.MarkAppliedKeyboardAxisOverride(normalizedAxisOverride.AxisName, normalizedAxisOverride.BindingType);
					}
					else
					{
						axisBinding.SetGamepadKeys(normalizedAxisOverride.KeyScaleMap, normalizedAxisOverride.BindingType);
						axisBinding.SetGamepadVersion(normalizedAxisOverride.Version, normalizedAxisOverride.ExclusiveType);
					}
					applyCount.AxisApplied++;
				}
			}
			this.LogVersionOutdatedKeys("Axis", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x06045BAB RID: 285611 RVA: 0x01153548 File Offset: 0x01151748
		private unsafe bool ApplyNormalizedCombinationActionOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedCombinationActionOverride normalizedCombinationActionOverride in deviceSetting.CombinationActionOverrides)
			{
				InputCombinationActionBinding inputCombinationActionBinding = InputSettingsManager.Instance.TryGetCombinationActionBinding(normalizedCombinationActionOverride.ActionName);
				if ((flag ? inputCombinationActionBinding.GetKeyboardVersion(normalizedCombinationActionOverride.ExclusiveType) : inputCombinationActionBinding.GetGamepadVersion(normalizedCombinationActionOverride.ExclusiveType)) > normalizedCombinationActionOverride.Version)
				{
					applyCount.CombinationActionSkipped++;
					applyCount.VersionOutdated++;
					num++;
					result = true;
				}
				else if (InputSettingsManager.Instance.IsNotInSettingsCombinationAction(normalizedCombinationActionOverride.ActionName, normalizedCombinationActionOverride.ExclusiveType, deviceSetting.InputControllerType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "组合Action不在改键设置中，该身份保留默认值";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", normalizedCombinationActionOverride.ActionName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InputControllerType", deviceSetting.InputControllerType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", normalizedCombinationActionOverride.BindingType);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					applyCount.CombinationActionSkipped++;
				}
				else
				{
					InputSettingsManager.Instance.ReplaceCombinationActionDeviceKeyMap(normalizedCombinationActionOverride.ActionName, deviceSetting.InputControllerType, normalizedCombinationActionOverride.BindingType, normalizedCombinationActionOverride.KeyMap);
					if (flag)
					{
						inputCombinationActionBinding.SetKeyboardVersion(normalizedCombinationActionOverride.Version, normalizedCombinationActionOverride.ExclusiveType);
						InputSettingsManager.Instance.MarkAppliedKeyboardCombinationActionOverride(normalizedCombinationActionOverride.ActionName, normalizedCombinationActionOverride.BindingType);
					}
					else
					{
						inputCombinationActionBinding.SetGamepadVersion(normalizedCombinationActionOverride.Version, normalizedCombinationActionOverride.ExclusiveType);
					}
					applyCount.CombinationActionApplied++;
				}
			}
			this.LogVersionOutdatedKeys("CombinationAction", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x06045BAC RID: 285612 RVA: 0x01153760 File Offset: 0x01151960
		private bool ApplyNormalizedCombinationAxisOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedCombinationAxisOverride normalizedCombinationAxisOverride in deviceSetting.CombinationAxisOverrides)
			{
				InputCombinationAxisBinding combinationAxisBindingByAxisName = InputSettingsManager.Instance.GetCombinationAxisBindingByAxisName(normalizedCombinationAxisOverride.AxisName);
				if (combinationAxisBindingByAxisName == null)
				{
					applyCount.CombinationAxisSkipped++;
				}
				else if ((flag ? combinationAxisBindingByAxisName.GetKeyboardVersion(normalizedCombinationAxisOverride.ExclusiveType) : combinationAxisBindingByAxisName.GetGamepadVersion(normalizedCombinationAxisOverride.ExclusiveType)) > normalizedCombinationAxisOverride.Version)
				{
					applyCount.CombinationAxisSkipped++;
					applyCount.VersionOutdated++;
					num++;
					result = true;
				}
				else
				{
					InputSettingsManager.Instance.ReplaceCombinationAxisDeviceKeyMap(normalizedCombinationAxisOverride.AxisName, deviceSetting.InputControllerType, normalizedCombinationAxisOverride.BindingType, normalizedCombinationAxisOverride.KeyMap);
					if (flag)
					{
						combinationAxisBindingByAxisName.SetKeyboardVersion(normalizedCombinationAxisOverride.Version, normalizedCombinationAxisOverride.ExclusiveType);
						InputSettingsManager.Instance.MarkAppliedKeyboardCombinationAxisOverride(normalizedCombinationAxisOverride.AxisName, normalizedCombinationAxisOverride.BindingType);
					}
					else
					{
						combinationAxisBindingByAxisName.SetGamepadVersion(normalizedCombinationAxisOverride.Version, normalizedCombinationAxisOverride.ExclusiveType);
					}
					applyCount.CombinationAxisApplied++;
				}
			}
			this.LogVersionOutdatedKeys("CombinationAxis", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x06045BAD RID: 285613 RVA: 0x011538D4 File Offset: 0x01151AD4
		private unsafe void ProcessConnectedKeySetting(int connectedKeySettingId, KeySetting keySettingConfig)
		{
			KeySetting? config = ConfigKeySettingById.GetConfig(connectedKeySettingId, true);
			if (config == null)
			{
				return;
			}
			KeySetting? keySetting = config;
			string actionOrAxisName = keySettingConfig.ActionOrAxisName;
			bool flag = keySettingConfig.ActionOrAxis == 1;
			string actionOrAxisName2 = keySetting.Value.ActionOrAxisName;
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionOrAxisName2);
			List<string> list = new List<string>();
			IReadOnlyDictionary<string, string> keyNameMap = null;
			EInputBindingType bindTypeByExclusiveType = InputSettingsManager.Instance.GetBindTypeByExclusiveType((EKeySettingExclusiveType)keySettingConfig.ExclusiveType);
			CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType;
			if (flag)
			{
				InputActionBinding actionBinding2 = InputSettingsManager.Instance.GetActionBinding(actionOrAxisName);
				InputCombinationActionBinding inputCombinationActionBinding = InputSettingsManager.Instance.TryGetCombinationActionBinding(actionOrAxisName);
				inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)keySettingConfig.InputControllerType;
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
				{
					if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
					{
						actionBinding2.GetKeyNameList(list);
					}
					else
					{
						actionBinding2.GetGamepadKeyNameList(list);
						keyNameMap = inputCombinationActionBinding.GetGamepadKeyNameMapByBindingType(bindTypeByExclusiveType);
					}
				}
				else
				{
					actionBinding2.GetPcKeyNameList(list);
					keyNameMap = inputCombinationActionBinding.GetPcKeyNameMap(bindTypeByExclusiveType);
				}
			}
			else
			{
				InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(actionOrAxisName);
				if (axisBinding == null)
				{
					return;
				}
				float pcAxisValue = keySettingConfig.PcAxisValue;
				float xboxAxisValue = keySettingConfig.XBoxAxisValue;
				Dictionary<string, float> dictionary = new Dictionary<string, float>();
				inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)keySettingConfig.InputControllerType;
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
				{
					if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
					{
						goto IL_215;
					}
				}
				else
				{
					axisBinding.GetPcKeyScaleMap(dictionary, bindTypeByExclusiveType);
					using (Dictionary<string, float>.Enumerator enumerator = dictionary.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, float> keyValuePair = enumerator.Current;
							string text;
							float num;
							keyValuePair.Deconstruct(out text, out num);
							string keyName = text;
							float num2 = num;
							if (MathUtils.Instance.IsNearlyEqual((double)num2, (double)pcAxisValue, null))
							{
								string item = InputKeyUtils.ConvertKeyToActionOrAxis(keyName, true);
								list.Add(item);
							}
						}
						goto IL_215;
					}
				}
				axisBinding.GetGamepadKeyScaleMap(dictionary, bindTypeByExclusiveType);
				foreach (KeyValuePair<string, float> keyValuePair in dictionary)
				{
					KeyValuePair<string, float> keyValuePair;
					string text;
					float num;
					keyValuePair.Deconstruct(out text, out num);
					string keyName2 = text;
					float num3 = num;
					if (MathUtils.Instance.IsNearlyEqual((double)num3, (double)xboxAxisValue, null))
					{
						string item2 = InputKeyUtils.ConvertKeyToActionOrAxis(keyName2, true);
						list.Add(item2);
					}
				}
			}
			IL_215:
			inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)keySettingConfig.InputControllerType;
			if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
			{
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
				{
					if (actionBinding != null)
					{
						actionBinding.SetKeys(list, bindTypeByExclusiveType);
					}
				}
				else
				{
					if (actionBinding != null)
					{
						actionBinding.SetGamepadKeys(list, bindTypeByExclusiveType);
					}
					InputSettingsManager.Instance.SetOrAddCombinationActionGamepadKeys(actionOrAxisName2, keyNameMap, bindTypeByExclusiveType);
				}
			}
			else
			{
				if (actionBinding != null)
				{
					actionBinding.SetKeyboardKeys(list, bindTypeByExclusiveType);
				}
				InputSettingsManager.Instance.SetOrAddCombinationActionKeyboardKeys(actionOrAxisName2, keyNameMap, bindTypeByExclusiveType);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "处理键位联动问题";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionOrAxisName", actionOrAxisName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsAction", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", keySettingConfig.InputControllerType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("LinkActionName", actionOrAxisName2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("KeyNames", list);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("after", (actionBinding != null) ? actionBinding.GetKeyNameList() : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
		}

		// Token: 0x06045BAE RID: 285614 RVA: 0x01153C4C File Offset: 0x01151E4C
		private unsafe void HandleLinkActionKey()
		{
			IReadOnlyList<KeySetting> configList = ConfigKeySettingAll.GetConfigList(true);
			if (configList == null)
			{
				return;
			}
			foreach (KeySetting keySettingConfig in configList)
			{
				Span<int> connectedKeySettingIdListBytes = keySettingConfig.GetConnectedKeySettingIdListBytes();
				if (connectedKeySettingIdListBytes.Length > 0)
				{
					Span<int> span = connectedKeySettingIdListBytes;
					for (int i = 0; i < span.Length; i++)
					{
						int connectedKeySettingId = *span[i];
						this.ProcessConnectedKeySetting(connectedKeySettingId, keySettingConfig);
					}
				}
			}
		}

		// Token: 0x06045BAF RID: 285615 RVA: 0x01153CD8 File Offset: 0x01151ED8
		public void HandleBothActionSyncAllExclusiveKey()
		{
			IReadOnlyList<KeySetting> configList = ConfigKeySettingAll.GetConfigList(true);
			if (configList == null)
			{
				return;
			}
			foreach (KeySetting keySetting in configList)
			{
				if (keySetting.BothActionNameLength == 2 && keySetting.BothActionSyncAllExclusive)
				{
					for (int i = 0; i < keySetting.BothActionNameLength; i++)
					{
						string text = keySetting.BothActionName(i);
						if (!string.IsNullOrEmpty(text))
						{
							InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(text);
							if (actionBinding != null)
							{
								List<string> list = new List<string>();
								actionBinding.GetKeyNameListByBindingType(list, EInputBindingType.Original);
								foreach (EInputBindingType einputBindingType in InputBindingDefine.inputBindingTypesArray)
								{
									if (einputBindingType != EInputBindingType.Original)
									{
										actionBinding.SetKeys(list, einputBindingType);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06045BB0 RID: 285616 RVA: 0x01153DB8 File Offset: 0x01151FB8
		private void NormalizeActionCombinationActionExclusivity(InputSettingApplyCount applyCount)
		{
			List<string> list = new List<string>(InputSettingsManager.Instance.GetCombinationActionBindingMap().Keys);
			Dictionary<string, string> keyMap = new Dictionary<string, string>();
			foreach (string actionName in list)
			{
				InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(actionName);
				if (combinationActionBindingByActionName != null)
				{
					InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
					if (actionBinding != null)
					{
						foreach (EInputBindingType bindingType in InputBindingDefine.inputBindingTypesArray)
						{
							Dictionary<string, string> dictionary = new Dictionary<string, string>();
							combinationActionBindingByActionName.GetGamepadKeyNameMapByBindingType(dictionary, bindingType);
							if (dictionary.Count > 0)
							{
								List<string> list2 = new List<string>();
								actionBinding.GetGamepadKeyNameListByBindingType(list2, bindingType);
								if (list2.Count > 0 && !(list2[0] == EKey.Gamepad_Invalid))
								{
									InputSettingsManager.Instance.ReplaceCombinationActionDeviceKeyMap(actionName, CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad, bindingType, keyMap);
									applyCount.ExclusivityCleared++;
								}
							}
						}
					}
				}
			}
			if (applyCount.ExclusivityCleared > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "手柄同名单键有效，已清除对应的组合键配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClearedCount", applyCount.ExclusivityCleared);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06045BB1 RID: 285617 RVA: 0x01153F14 File Offset: 0x01152114
		[NullableContext(2)]
		private unsafe InputSettingData BuildInputSettingsToProtoData()
		{
			InputSettingData inputSettingData = InputSettingData.Create();
			OneDeviceInputSetting oneDeviceInputSetting = OneDeviceInputSetting.Create();
			OneDeviceInputSetting oneDeviceInputSetting2 = OneDeviceInputSetting.Create();
			oneDeviceInputSetting.Device = InputSettingDevice.Mouse;
			oneDeviceInputSetting.DeviceSubType = InputSettingsManager.Instance.DeviceLang;
			oneDeviceInputSetting2.Device = InputSettingDevice.Handle;
			this.BuildActionBindingToProtoData(oneDeviceInputSetting, oneDeviceInputSetting2);
			this.BuildAxisBindingToProtoData(oneDeviceInputSetting, oneDeviceInputSetting2);
			this.BuildCombinationActionBindingToProtoData(oneDeviceInputSetting, oneDeviceInputSetting2);
			this.BuildCombinationAxisBindingToProtoData(oneDeviceInputSetting, oneDeviceInputSetting2);
			inputSettingData.InputSettings.AddRange(new <>z__ReadOnlyArray<OneDeviceInputSetting>(new OneDeviceInputSetting[]
			{
				oneDeviceInputSetting,
				oneDeviceInputSetting2
			}));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "已构建待上传的完整键位数据";
			<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DeviceSubType", oneDeviceInputSetting.DeviceSubType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("KeyboardAction", oneDeviceInputSetting.InputAction.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("KeyboardAxis", oneDeviceInputSetting.InputAxis.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("KeyboardCombinationAction", oneDeviceInputSetting.InputCombinationAction.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("KeyboardCombinationAxis", oneDeviceInputSetting.InputCombinationAxis.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("GamepadAction", oneDeviceInputSetting2.InputAction.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("GamepadAxis", oneDeviceInputSetting2.InputAxis.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("GamepadCombinationAction", oneDeviceInputSetting2.InputCombinationAction.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("GamepadCombinationAxis", oneDeviceInputSetting2.InputCombinationAxis.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
			return inputSettingData;
		}

		// Token: 0x06045BB2 RID: 285618 RVA: 0x0115410C File Offset: 0x0115230C
		private void BuildActionBindingToProtoData(OneDeviceInputSetting keyboardInputSettings, OneDeviceInputSetting gamepadInputSettings)
		{
			foreach (KeyValuePair<string, InputActionBinding> keyValuePair in InputSettingsManager.Instance.GetActionBindingMap())
			{
				string text;
				InputActionBinding inputActionBinding;
				keyValuePair.Deconstruct(out text, out inputActionBinding);
				string actionName = text;
				InputActionBinding inputActionBinding2 = inputActionBinding;
				Dictionary<EInputBindingType, List<string>> dictionary = new Dictionary<EInputBindingType, List<string>>();
				inputActionBinding2.GetAllPcKeyNameMap(dictionary);
				foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair2 in dictionary)
				{
					EInputBindingType einputBindingType;
					List<string> list;
					keyValuePair2.Deconstruct(out einputBindingType, out list);
					EInputBindingType bindingType = einputBindingType;
					List<string> list2 = list;
					EKeySettingExclusiveType exclusiveTypeByBindingType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType);
					int keyboardVersion = inputActionBinding2.GetKeyboardVersion(exclusiveTypeByBindingType);
					this.BuildActionKey(actionName, keyboardInputSettings, list2.ToArray(), keyboardVersion, bindingType);
				}
				Dictionary<EInputBindingType, List<string>> dictionary2 = new Dictionary<EInputBindingType, List<string>>();
				inputActionBinding2.GetAllGamepadKeyNameMap(dictionary2);
				foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair2 in dictionary2)
				{
					EInputBindingType einputBindingType;
					List<string> list;
					keyValuePair2.Deconstruct(out einputBindingType, out list);
					EInputBindingType bindingType2 = einputBindingType;
					List<string> list3 = list;
					EKeySettingExclusiveType exclusiveTypeByBindingType2 = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2);
					int gamepadVersion = inputActionBinding2.GetGamepadVersion(exclusiveTypeByBindingType2);
					this.BuildActionKey(actionName, gamepadInputSettings, list3.ToArray(), gamepadVersion, bindingType2);
				}
			}
		}

		// Token: 0x06045BB3 RID: 285619 RVA: 0x011542A0 File Offset: 0x011524A0
		private void BuildAxisBindingToProtoData(OneDeviceInputSetting keyboardInputSettings, OneDeviceInputSetting gamepadInputSettings)
		{
			foreach (KeyValuePair<string, InputAxisBinding> keyValuePair in InputSettingsManager.Instance.GetAxisBindingMap())
			{
				string text;
				InputAxisBinding inputAxisBinding;
				keyValuePair.Deconstruct(out text, out inputAxisBinding);
				string axisName = text;
				InputAxisBinding inputAxisBinding2 = inputAxisBinding;
				foreach (KeyValuePair<EInputBindingType, Dictionary<string, float>> keyValuePair2 in inputAxisBinding2.GetAllPcKeyScaleMap())
				{
					EInputBindingType einputBindingType;
					Dictionary<string, float> dictionary;
					keyValuePair2.Deconstruct(out einputBindingType, out dictionary);
					EInputBindingType bindingType = einputBindingType;
					Dictionary<string, float> keyScaleMap = dictionary;
					EKeySettingExclusiveType exclusiveTypeByBindingType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType);
					int keyboardVersion = inputAxisBinding2.GetKeyboardVersion(exclusiveTypeByBindingType);
					this.BuildAxisKey(axisName, keyboardInputSettings, keyScaleMap, keyboardVersion, bindingType);
				}
				foreach (KeyValuePair<EInputBindingType, Dictionary<string, float>> keyValuePair2 in inputAxisBinding2.GetAllGamepadKeyScaleMap())
				{
					EInputBindingType einputBindingType;
					Dictionary<string, float> dictionary;
					keyValuePair2.Deconstruct(out einputBindingType, out dictionary);
					EInputBindingType bindingType2 = einputBindingType;
					Dictionary<string, float> keyScaleMap2 = dictionary;
					EKeySettingExclusiveType exclusiveTypeByBindingType2 = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2);
					int gamepadVersion = inputAxisBinding2.GetGamepadVersion(exclusiveTypeByBindingType2);
					this.BuildAxisKey(axisName, gamepadInputSettings, keyScaleMap2, gamepadVersion, bindingType2);
				}
			}
		}

		// Token: 0x06045BB4 RID: 285620 RVA: 0x011543EC File Offset: 0x011525EC
		private void BuildCombinationActionBindingToProtoData(OneDeviceInputSetting keyboardInputSettings, OneDeviceInputSetting gamepadInputSettings)
		{
			foreach (KeyValuePair<string, InputCombinationActionBinding> keyValuePair in InputSettingsManager.Instance.GetCombinationActionBindingMap())
			{
				string text;
				InputCombinationActionBinding inputCombinationActionBinding;
				keyValuePair.Deconstruct(out text, out inputCombinationActionBinding);
				string actionName = text;
				InputCombinationActionBinding inputCombinationActionBinding2 = inputCombinationActionBinding;
				Dictionary<EInputBindingType, Dictionary<string, string>> dictionary = new Dictionary<EInputBindingType, Dictionary<string, string>>();
				inputCombinationActionBinding2.GetAllPcKeyNameMap(dictionary);
				foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair2 in dictionary)
				{
					EInputBindingType einputBindingType;
					Dictionary<string, string> dictionary2;
					keyValuePair2.Deconstruct(out einputBindingType, out dictionary2);
					EInputBindingType bindingType = einputBindingType;
					Dictionary<string, string> keyMap = dictionary2;
					EKeySettingExclusiveType exclusiveTypeByBindingType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType);
					int keyboardVersion = inputCombinationActionBinding2.GetKeyboardVersion(exclusiveTypeByBindingType);
					this.BuildCombinationActionKey(actionName, keyboardInputSettings, keyMap, keyboardVersion, bindingType);
				}
				Dictionary<EInputBindingType, Dictionary<string, string>> dictionary3 = new Dictionary<EInputBindingType, Dictionary<string, string>>();
				inputCombinationActionBinding2.GetAllGamepadKeyNameMap(dictionary3);
				foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair2 in dictionary3)
				{
					EInputBindingType einputBindingType;
					Dictionary<string, string> dictionary2;
					keyValuePair2.Deconstruct(out einputBindingType, out dictionary2);
					EInputBindingType bindingType2 = einputBindingType;
					Dictionary<string, string> keyMap2 = dictionary2;
					EKeySettingExclusiveType exclusiveTypeByBindingType2 = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2);
					int gamepadVersion = inputCombinationActionBinding2.GetGamepadVersion(exclusiveTypeByBindingType2);
					this.BuildCombinationActionKey(actionName, gamepadInputSettings, keyMap2, gamepadVersion, bindingType2);
				}
			}
		}

		// Token: 0x06045BB5 RID: 285621 RVA: 0x01154574 File Offset: 0x01152774
		private void BuildCombinationAxisBindingToProtoData(OneDeviceInputSetting keyboardInputSettings, OneDeviceInputSetting gamepadInputSettings)
		{
			foreach (KeyValuePair<string, InputCombinationAxisBinding> keyValuePair in InputSettingsManager.Instance.GetCombinationAxisBindingMap())
			{
				string text;
				InputCombinationAxisBinding inputCombinationAxisBinding;
				keyValuePair.Deconstruct(out text, out inputCombinationAxisBinding);
				string axisName = text;
				InputCombinationAxisBinding inputCombinationAxisBinding2 = inputCombinationAxisBinding;
				Dictionary<EInputBindingType, Dictionary<string, string>> dictionary = new Dictionary<EInputBindingType, Dictionary<string, string>>();
				inputCombinationAxisBinding2.GetAllPcKeyNameMap(dictionary);
				foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair2 in dictionary)
				{
					EInputBindingType einputBindingType;
					Dictionary<string, string> dictionary2;
					keyValuePair2.Deconstruct(out einputBindingType, out dictionary2);
					EInputBindingType bindingType = einputBindingType;
					Dictionary<string, string> keyMap = dictionary2;
					EKeySettingExclusiveType exclusiveTypeByBindingType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType);
					int keyboardVersion = inputCombinationAxisBinding2.GetKeyboardVersion(exclusiveTypeByBindingType);
					this.BuildCombinationAxisKey(axisName, keyboardInputSettings, keyMap, keyboardVersion, bindingType);
				}
				Dictionary<EInputBindingType, Dictionary<string, string>> dictionary3 = new Dictionary<EInputBindingType, Dictionary<string, string>>();
				inputCombinationAxisBinding2.GetAllGamepadKeyNameMap(dictionary3);
				foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair2 in dictionary3)
				{
					EInputBindingType einputBindingType;
					Dictionary<string, string> dictionary2;
					keyValuePair2.Deconstruct(out einputBindingType, out dictionary2);
					EInputBindingType bindingType2 = einputBindingType;
					Dictionary<string, string> keyMap2 = dictionary2;
					EKeySettingExclusiveType exclusiveTypeByBindingType2 = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType2);
					int gamepadVersion = inputCombinationAxisBinding2.GetGamepadVersion(exclusiveTypeByBindingType2);
					this.BuildCombinationAxisKey(axisName, gamepadInputSettings, keyMap2, gamepadVersion, bindingType2);
				}
			}
		}

		// Token: 0x06045BB6 RID: 285622 RVA: 0x011546FC File Offset: 0x011528FC
		private void BuildActionKey(string actionName, OneDeviceInputSetting inputSettings, string[] keyNameList, int version, EInputBindingType bindingType)
		{
			SettingInputType inputType = this.InputBindTypeMap[bindingType];
			InputAction inputAction = InputAction.Create();
			inputAction.ActionName = actionName;
			inputAction.Version = version;
			inputAction.InputType = inputType;
			inputAction.KeyNameList.AddRange(keyNameList);
			inputSettings.InputAction.Add(inputAction);
		}

		// Token: 0x06045BB7 RID: 285623 RVA: 0x0115474C File Offset: 0x0115294C
		private void BuildAxisKey(string axisName, OneDeviceInputSetting inputSettings, IReadOnlyDictionary<string, float> keyScaleMap, int version, EInputBindingType bindingType)
		{
			SettingInputType inputType = this.InputBindTypeMap[bindingType];
			InputAxis inputAxis = InputAxis.Create();
			inputAxis.AxisName = axisName;
			inputAxis.Version = version;
			inputAxis.InputType = inputType;
			foreach (KeyValuePair<string, float> keyValuePair in keyScaleMap)
			{
				string text;
				float num;
				keyValuePair.Deconstruct(out text, out num);
				string key = text;
				int value = (int)Math.Round((double)(num * 1000f));
				inputAxis.KeyScaleMap[key] = value;
			}
			inputSettings.InputAxis.Add(inputAxis);
		}

		// Token: 0x06045BB8 RID: 285624 RVA: 0x011547F4 File Offset: 0x011529F4
		private void BuildCombinationActionKey(string actionName, OneDeviceInputSetting inputSettings, Dictionary<string, string> keyMap, int version, EInputBindingType bindingType)
		{
			SettingInputType inputType = this.InputBindTypeMap[bindingType];
			Aki.Protocol.CombinationAction combinationAction = Aki.Protocol.CombinationAction.Create();
			combinationAction.ActionName = actionName;
			combinationAction.Version = version;
			combinationAction.InputType = inputType;
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string text3 = text;
				string text4 = text2;
				CombinationKey combinationKey = CombinationKey.Create();
				combinationKey.KeyNameList.AddRange(new <>z__ReadOnlyArray<string>(new string[]
				{
					text3,
					text4
				}));
				combinationAction.CombinationKeyList.Add(combinationKey);
			}
			inputSettings.InputCombinationAction.Add(combinationAction);
		}

		// Token: 0x06045BB9 RID: 285625 RVA: 0x011548B8 File Offset: 0x01152AB8
		private void BuildCombinationAxisKey(string axisName, OneDeviceInputSetting inputSettings, Dictionary<string, string> keyMap, int version, EInputBindingType bindingType)
		{
			SettingInputType inputType = this.InputBindTypeMap[bindingType];
			Aki.Protocol.CombinationAxis combinationAxis = Aki.Protocol.CombinationAxis.Create();
			combinationAxis.AxisName = axisName;
			combinationAxis.Version = version;
			combinationAxis.InputType = inputType;
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string text3 = text;
				string text4 = text2;
				CombinationKey combinationKey = CombinationKey.Create();
				combinationKey.KeyNameList.AddRange(new <>z__ReadOnlyArray<string>(new string[]
				{
					text4,
					text3
				}));
				combinationAxis.CombinationKeyList.Add(combinationKey);
			}
			inputSettings.InputCombinationAxis.Add(combinationAxis);
		}

		// Token: 0x17009B97 RID: 39831
		// (get) Token: 0x06045BBA RID: 285626 RVA: 0x0115497C File Offset: 0x01152B7C
		public static InputSettingsController Instance
		{
			get
			{
				return InputSettingsController._Instance;
			}
		}

		// Token: 0x06045BBB RID: 285627 RVA: 0x01154983 File Offset: 0x01152B83
		public static InputSettingsController GetOrCreateInstance()
		{
			if (InputSettingsController._Instance == null)
			{
				InputSettingsController.CreateInstance();
			}
			return InputSettingsController._Instance;
		}

		// Token: 0x06045BBC RID: 285628 RVA: 0x01154997 File Offset: 0x01152B97
		public static bool CreateInstance()
		{
			if (InputSettingsController._Instance != null)
			{
				return true;
			}
			InputSettingsController._Instance = new InputSettingsController();
			return true;
		}

		// Token: 0x06045BBD RID: 285629 RVA: 0x011549AD File Offset: 0x01152BAD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045BBE RID: 285630 RVA: 0x011549AF File Offset: 0x01152BAF
		public static void ResetStaticDefaultValue()
		{
			InputSettingsController._Instance = null;
		}

		// Token: 0x06045BBF RID: 285631 RVA: 0x011549B7 File Offset: 0x01152BB7
		static InputSettingsController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettingsController.CreateStaticDefaultValue), new Action(InputSettingsController.ResetStaticDefaultValue));
		}

		// Token: 0x04024605 RID: 148997
		private const float AXIS_SCALE_PROTOCOL_FACTOR = 1000f;

		// Token: 0x04024606 RID: 148998
		private const int COMBINATION_KEY_NAME_COUNT = 2;

		// Token: 0x04024607 RID: 148999
		private readonly Dictionary<EInputBindingType, SettingInputType> InputBindTypeMap = new Dictionary<EInputBindingType, SettingInputType>
		{
			{
				EInputBindingType.Original,
				SettingInputType.Normal
			},
			{
				EInputBindingType.Motor,
				SettingInputType.Motorcycle
			}
		};

		// Token: 0x04024608 RID: 149000
		[Nullable(2)]
		private static InputSettingsController _Instance;
	}
}
