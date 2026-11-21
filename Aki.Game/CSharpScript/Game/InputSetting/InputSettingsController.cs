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
	// Token: 0x02006177 RID: 24951
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class InputSettingsController : ControllerBase
	{
		// Token: 0x0603BD42 RID: 245058 RVA: 0x010FB97C File Offset: 0x010F9B7C
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.InputSettingUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.InputSettingUpdateNotify));
			EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.OnGetPlayerBasicInfo));
			return true;
		}

		// Token: 0x0603BD43 RID: 245059 RVA: 0x010FB9B7 File Offset: 0x010F9BB7
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InputSettingUpdateNotify);
			EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.OnGetPlayerBasicInfo));
			return true;
		}

		// Token: 0x0603BD44 RID: 245060 RVA: 0x010FB9E8 File Offset: 0x010F9BE8
		private void OnGetPlayerBasicInfo()
		{
			Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.XXJ, "登录直接请求服务端输入数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InputSettingRequest();
		}

		// Token: 0x0603BD45 RID: 245061 RVA: 0x010FBA18 File Offset: 0x010F9C18
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

		// Token: 0x0603BD46 RID: 245062 RVA: 0x010FBA78 File Offset: 0x010F9C78
		public void InputSettingRequest()
		{
			InputSettingRequest message = Aki.Protocol.InputSettingRequest.Create();
			Net.Instance.Call(ERequestMessageId.InputSettingRequest, message, new Action<IMessage, Net.CallbackStatus>(this.InputSettingResponse), 0);
		}

		// Token: 0x0603BD47 RID: 245063 RVA: 0x010FBAA8 File Offset: 0x010F9CA8
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

		// Token: 0x0603BD48 RID: 245064 RVA: 0x010FBB50 File Offset: 0x010F9D50
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

		// Token: 0x0603BD49 RID: 245065 RVA: 0x010FBC18 File Offset: 0x010F9E18
		public void InputSettingUpdateRequest()
		{
			InputSettingUpdateRequest inputSettingUpdateRequest = Aki.Protocol.InputSettingUpdateRequest.Create();
			inputSettingUpdateRequest.InputSettingData = this.BuildInputSettingsToProtoData();
			Net.Instance.Call(ERequestMessageId.InputSettingUpdateRequest, inputSettingUpdateRequest, new Action<IMessage, Net.CallbackStatus>(this.InputSettingUpdateResponse), 0);
		}

		// Token: 0x0603BD4A RID: 245066 RVA: 0x010FBC54 File Offset: 0x010F9E54
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(inputSettingUpdateResponse.ErrorCode, 20916, null, true, true);
		}

		// Token: 0x0603BD4B RID: 245067 RVA: 0x010FBC90 File Offset: 0x010F9E90
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

		// Token: 0x0603BD4C RID: 245068 RVA: 0x010FBD00 File Offset: 0x010F9F00
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

		// Token: 0x0603BD4D RID: 245069 RVA: 0x010FBD18 File Offset: 0x010F9F18
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
				InputSettingApplyCount inputSettingApplyCount = new InputSettingApplyCount();
				bool flag = false;
				foreach (NormalizedOneDeviceInputSetting deviceSetting in normalizedInputSettingSnapshot.DeviceSettings)
				{
					flag |= this.ApplyOneDeviceSparseOverrides(deviceSetting, inputSettingApplyCount, false);
				}
				foreach (NormalizedOneDeviceInputSetting deviceSetting2 in normalizedInputSettingSnapshot.DeviceSettings)
				{
					flag |= this.ApplyOneDeviceSparseOverrides(deviceSetting2, inputSettingApplyCount, true);
				}
				bool flag2 = InputSettingsManager.Instance.ConvertAppliedServerKeyboardOverrides(serverDeviceLang, text);
				this.HandleLinkActionKey();
				this.HandleBothActionSyncAllExclusiveKey();
				this.NormalizeActionCombinationActionExclusivity(inputSettingApplyCount);
				InputSettingsManager.Instance.RebuildCurrentCombinationRuntimeMappings();
				bool needNormalizeUpload = flag || flag2 || inputSettingApplyCount.EmptyOverrideRejected > 0;
				this.LogInputSettingApplyResult(normalizedInputSettingSnapshot.DeviceSettings.Count, inputSettingApplyCount, flag2, needNormalizeUpload);
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

		// Token: 0x0603BD4E RID: 245070 RVA: 0x010FBEF4 File Offset: 0x010FA0F4
		private unsafe void LogInputSettingApplyResult(int deviceCount, InputSettingApplyCount applyCount, bool deviceLangChanged, bool needNormalizeUpload)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "服务端键位数据应用完成";
			<>y__InlineArray14<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray14<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DeviceCount", deviceCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionApplied", applyCount.ActionApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActionSkipped", applyCount.ActionSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AxisApplied", applyCount.AxisApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AxisSkipped", applyCount.AxisSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("CombinationActionApplied", applyCount.CombinationActionApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("CombinationActionSkipped", applyCount.CombinationActionSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("CombinationAxisApplied", applyCount.CombinationAxisApplied);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("CombinationAxisSkipped", applyCount.CombinationAxisSkipped);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("VersionOutdated", applyCount.VersionOutdated);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("ExclusivityCleared", applyCount.ExclusivityCleared);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("EmptyOverrideRejected", applyCount.EmptyOverrideRejected);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("DeviceLangChanged", deviceLangChanged);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 13) = new ValueTuple<string, object>("NeedNormalizeUpload", needNormalizeUpload);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 14));
		}

		// Token: 0x0603BD4F RID: 245071 RVA: 0x010FC0F8 File Offset: 0x010FA2F8
		private void FinishApplyingInputSnapshot(bool needNormalizeUpload)
		{
			if (needNormalizeUpload)
			{
				this.InputSettingUpdateRequest();
				return;
			}
			GameSettingsUtils.RefreshViewRevertState(Info.Instance.InputControllerMainType);
		}

		// Token: 0x0603BD50 RID: 245072 RVA: 0x010FC114 File Offset: 0x010FA314
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

		// Token: 0x0603BD51 RID: 245073 RVA: 0x010FC194 File Offset: 0x010FA394
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

		// Token: 0x0603BD52 RID: 245074 RVA: 0x010FC480 File Offset: 0x010FA680
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

		// Token: 0x0603BD53 RID: 245075 RVA: 0x010FC52C File Offset: 0x010FA72C
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

		// Token: 0x0603BD54 RID: 245076 RVA: 0x010FC72C File Offset: 0x010FA92C
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

		// Token: 0x0603BD55 RID: 245077 RVA: 0x010FC988 File Offset: 0x010FAB88
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

		// Token: 0x0603BD56 RID: 245078 RVA: 0x010FCB28 File Offset: 0x010FAD28
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

		// Token: 0x0603BD57 RID: 245079 RVA: 0x010FCE1C File Offset: 0x010FB01C
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

		// Token: 0x0603BD58 RID: 245080 RVA: 0x010FCFE8 File Offset: 0x010FB1E8
		private bool ApplyOneDeviceSparseOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount, bool applyEmptyOverrides)
		{
			return false | this.ApplyNormalizedActionOverrides(deviceSetting, applyCount, applyEmptyOverrides) | this.ApplyNormalizedAxisOverrides(deviceSetting, applyCount, applyEmptyOverrides) | this.ApplyNormalizedCombinationActionOverrides(deviceSetting, applyCount, applyEmptyOverrides) | this.ApplyNormalizedCombinationAxisOverrides(deviceSetting, applyCount, applyEmptyOverrides);
		}

		// Token: 0x0603BD59 RID: 245081 RVA: 0x010FD013 File Offset: 0x010FB213
		private static bool IsValidBindingKey(string keyName)
		{
			return !string.IsNullOrEmpty(keyName) && keyName != EKey.Keyboard_Invalid && keyName != EKey.Gamepad_Invalid;
		}

		// Token: 0x0603BD5A RID: 245082 RVA: 0x010FD044 File Offset: 0x010FB244
		private static bool HasValidBindingKey(IEnumerable<string> keyNames)
		{
			using (IEnumerator<string> enumerator = keyNames.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (InputSettingsController.IsValidBindingKey(enumerator.Current))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603BD5B RID: 245083 RVA: 0x010FD094 File Offset: 0x010FB294
		private static bool HasValidCombinationBinding(IReadOnlyDictionary<string, string> keyMap)
		{
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string keyName = text;
				string keyName2 = text2;
				if (InputSettingsController.IsValidBindingKey(keyName) && InputSettingsController.IsValidBindingKey(keyName2))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603BD5C RID: 245084 RVA: 0x010FD0FC File Offset: 0x010FB2FC
		private unsafe bool CanApplyEmptyOverride(string name, EInputBindingType bindingType, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, bool isAction, bool isCombination, InputSettingApplyCount applyCount)
		{
			IReadOnlyList<KeySetting> configList = ConfigKeySettingAll.GetConfigList(true);
			if (configList == null)
			{
				return true;
			}
			EKeySettingExclusiveType exclusiveTypeByBindingType = InputSettingsManager.Instance.GetExclusiveTypeByBindingType(bindingType);
			foreach (KeySetting keySetting in configList)
			{
				if (!keySetting.CanDisable && keySetting.ActionOrAxis == 1 == isAction && keySetting.ExclusiveType == (int)exclusiveTypeByBindingType && (keySetting.InputControllerType == 0 || keySetting.InputControllerType == (int)inputControllerType))
				{
					bool flag = keySetting.ActionOrAxisName == name;
					if (isAction)
					{
						int num = 0;
						while (!flag && num < keySetting.BothActionNameLength)
						{
							flag = (keySetting.BothActionName(num) == name);
							num++;
						}
					}
					if (flag && ((!isCombination && !keySetting.CanCombination) || !this.HasOtherBinding(name, bindingType, inputControllerType, isAction, isCombination)))
					{
						applyCount.EmptyOverrideRejected++;
						Log instance = Log.Instance;
						ELogModule module = ELogModule.InputSettings;
						ELogAuthor author = ELogAuthor.TZJ;
						string message = "服务端要求清空不可禁用的键位，忽略该记录并回传本地键位";
						<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("KeySettingId", keySetting.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("InputControllerType", inputControllerType);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BindingType", bindingType);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("IsAction", isAction);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("IsCombination", isCombination);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603BD5D RID: 245085 RVA: 0x010FD2F8 File Offset: 0x010FB4F8
		private bool HasOtherBinding(string name, EInputBindingType bindingType, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, bool isAction, bool isCombination)
		{
			bool flag = inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			if (!isCombination)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (isAction)
				{
					InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(name);
					if (flag)
					{
						if (combinationActionBindingByActionName != null)
						{
							combinationActionBindingByActionName.GetPcKeyNameMap(dictionary, bindingType);
						}
					}
					else if (combinationActionBindingByActionName != null)
					{
						combinationActionBindingByActionName.GetGamepadKeyNameMapByBindingType(dictionary, bindingType);
					}
				}
				else
				{
					InputCombinationAxisBinding combinationAxisBindingByAxisName = InputSettingsManager.Instance.GetCombinationAxisBindingByAxisName(name);
					if (flag)
					{
						if (combinationAxisBindingByAxisName != null)
						{
							combinationAxisBindingByAxisName.GetPcKeyNameMap(dictionary, bindingType);
						}
					}
					else if (combinationAxisBindingByAxisName != null)
					{
						combinationAxisBindingByAxisName.GetGamepadKeyNameMap(dictionary, bindingType);
					}
				}
				return InputSettingsController.HasValidCombinationBinding(dictionary);
			}
			if (isAction)
			{
				List<string> list = new List<string>();
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(name);
				if (flag)
				{
					if (actionBinding != null)
					{
						actionBinding.GetPcKeyNameListByBindingType(list, bindingType);
					}
				}
				else if (actionBinding != null)
				{
					actionBinding.GetGamepadKeyNameListByBindingType(list, bindingType);
				}
				return InputSettingsController.HasValidBindingKey(list);
			}
			Dictionary<string, float> dictionary2 = new Dictionary<string, float>();
			InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(name);
			if (flag)
			{
				if (axisBinding != null)
				{
					axisBinding.GetPcKeyNameMapByBindingType(dictionary2, bindingType);
				}
			}
			else if (axisBinding != null)
			{
				axisBinding.GetGamepadKeyNameMapByBindingType(dictionary2, bindingType);
			}
			return InputSettingsController.HasValidBindingKey(dictionary2.Keys);
		}

		// Token: 0x0603BD5E RID: 245086 RVA: 0x010FD3F4 File Offset: 0x010FB5F4
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

		// Token: 0x0603BD5F RID: 245087 RVA: 0x010FD47C File Offset: 0x010FB67C
		private bool ApplyNormalizedActionOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount, bool applyEmptyOverrides)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedActionOverride normalizedActionOverride in deviceSetting.ActionOverrides)
			{
				bool flag2 = !InputSettingsController.HasValidBindingKey(normalizedActionOverride.KeyNameList);
				if (flag2 == applyEmptyOverrides)
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
					else if (flag2 && !this.CanApplyEmptyOverride(normalizedActionOverride.ActionName, normalizedActionOverride.BindingType, deviceSetting.InputControllerType, true, false, applyCount))
					{
						applyCount.ActionSkipped++;
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
			}
			this.LogVersionOutdatedKeys("Action", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x0603BD60 RID: 245088 RVA: 0x010FD644 File Offset: 0x010FB844
		private bool ApplyNormalizedAxisOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount, bool applyEmptyOverrides)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedAxisOverride normalizedAxisOverride in deviceSetting.AxisOverrides)
			{
				bool flag2 = !InputSettingsController.HasValidBindingKey(normalizedAxisOverride.KeyScaleMap.Keys);
				if (flag2 == applyEmptyOverrides)
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
					else if (flag2 && !this.CanApplyEmptyOverride(normalizedAxisOverride.AxisName, normalizedAxisOverride.BindingType, deviceSetting.InputControllerType, false, false, applyCount))
					{
						applyCount.AxisSkipped++;
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
			}
			this.LogVersionOutdatedKeys("Axis", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x0603BD61 RID: 245089 RVA: 0x010FD810 File Offset: 0x010FBA10
		private unsafe bool ApplyNormalizedCombinationActionOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount, bool applyEmptyOverrides)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedCombinationActionOverride normalizedCombinationActionOverride in deviceSetting.CombinationActionOverrides)
			{
				bool flag2 = !InputSettingsController.HasValidCombinationBinding(normalizedCombinationActionOverride.KeyMap);
				if (flag2 == applyEmptyOverrides)
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
					else if (flag2 && !this.CanApplyEmptyOverride(normalizedCombinationActionOverride.ActionName, normalizedCombinationActionOverride.BindingType, deviceSetting.InputControllerType, true, true, applyCount))
					{
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
			}
			this.LogVersionOutdatedKeys("CombinationAction", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x0603BD62 RID: 245090 RVA: 0x010FDA78 File Offset: 0x010FBC78
		private bool ApplyNormalizedCombinationAxisOverrides(NormalizedOneDeviceInputSetting deviceSetting, InputSettingApplyCount applyCount, bool applyEmptyOverrides)
		{
			bool result = false;
			int num = 0;
			bool flag = deviceSetting.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			foreach (NormalizedCombinationAxisOverride normalizedCombinationAxisOverride in deviceSetting.CombinationAxisOverrides)
			{
				bool flag2 = !InputSettingsController.HasValidCombinationBinding(normalizedCombinationAxisOverride.KeyMap);
				if (flag2 == applyEmptyOverrides)
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
					else if (flag2 && !this.CanApplyEmptyOverride(normalizedCombinationAxisOverride.AxisName, normalizedCombinationAxisOverride.BindingType, deviceSetting.InputControllerType, false, true, applyCount))
					{
						applyCount.CombinationAxisSkipped++;
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
			}
			this.LogVersionOutdatedKeys("CombinationAxis", deviceSetting.InputControllerType, num);
			return result;
		}

		// Token: 0x0603BD63 RID: 245091 RVA: 0x010FDC3C File Offset: 0x010FBE3C
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

		// Token: 0x0603BD64 RID: 245092 RVA: 0x010FDFB4 File Offset: 0x010FC1B4
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

		// Token: 0x0603BD65 RID: 245093 RVA: 0x010FE040 File Offset: 0x010FC240
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

		// Token: 0x0603BD66 RID: 245094 RVA: 0x010FE120 File Offset: 0x010FC320
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

		// Token: 0x0603BD67 RID: 245095 RVA: 0x010FE27C File Offset: 0x010FC47C
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

		// Token: 0x0603BD68 RID: 245096 RVA: 0x010FE474 File Offset: 0x010FC674
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

		// Token: 0x0603BD69 RID: 245097 RVA: 0x010FE608 File Offset: 0x010FC808
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

		// Token: 0x0603BD6A RID: 245098 RVA: 0x010FE754 File Offset: 0x010FC954
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

		// Token: 0x0603BD6B RID: 245099 RVA: 0x010FE8DC File Offset: 0x010FCADC
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

		// Token: 0x0603BD6C RID: 245100 RVA: 0x010FEA64 File Offset: 0x010FCC64
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

		// Token: 0x0603BD6D RID: 245101 RVA: 0x010FEAB4 File Offset: 0x010FCCB4
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

		// Token: 0x0603BD6E RID: 245102 RVA: 0x010FEB5C File Offset: 0x010FCD5C
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

		// Token: 0x0603BD6F RID: 245103 RVA: 0x010FEC20 File Offset: 0x010FCE20
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

		// Token: 0x170070D7 RID: 28887
		// (get) Token: 0x0603BD70 RID: 245104 RVA: 0x010FECE4 File Offset: 0x010FCEE4
		public static InputSettingsController Instance
		{
			get
			{
				return InputSettingsController._Instance;
			}
		}

		// Token: 0x0603BD71 RID: 245105 RVA: 0x010FECEB File Offset: 0x010FCEEB
		public static InputSettingsController GetOrCreateInstance()
		{
			if (InputSettingsController._Instance == null)
			{
				InputSettingsController.CreateInstance();
			}
			return InputSettingsController._Instance;
		}

		// Token: 0x0603BD72 RID: 245106 RVA: 0x010FECFF File Offset: 0x010FCEFF
		public static bool CreateInstance()
		{
			if (InputSettingsController._Instance != null)
			{
				return true;
			}
			InputSettingsController._Instance = new InputSettingsController();
			return true;
		}

		// Token: 0x0603BD73 RID: 245107 RVA: 0x010FED15 File Offset: 0x010FCF15
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BD74 RID: 245108 RVA: 0x010FED17 File Offset: 0x010FCF17
		public static void ResetStaticDefaultValue()
		{
			InputSettingsController._Instance = null;
		}

		// Token: 0x0603BD75 RID: 245109 RVA: 0x010FED1F File Offset: 0x010FCF1F
		static InputSettingsController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettingsController.CreateStaticDefaultValue), new Action(InputSettingsController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F8BB RID: 129211
		private const float AXIS_SCALE_PROTOCOL_FACTOR = 1000f;

		// Token: 0x0401F8BC RID: 129212
		private const int COMBINATION_KEY_NAME_COUNT = 2;

		// Token: 0x0401F8BD RID: 129213
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

		// Token: 0x0401F8BE RID: 129214
		[Nullable(2)]
		private static InputSettingsController _Instance;
	}
}
