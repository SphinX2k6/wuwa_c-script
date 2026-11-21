using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Input.BattleInputData;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200617E RID: 24958
	[NullableContext(1)]
	[Nullable(0)]
	public class InputSettingsManager : Singleton
	{
		// Token: 0x170070D8 RID: 28888
		// (get) Token: 0x0603BD8B RID: 245131 RVA: 0x0110062C File Offset: 0x010FE82C
		// (set) Token: 0x0603BD8C RID: 245132 RVA: 0x01100634 File Offset: 0x010FE834
		public string DeviceLang
		{
			get
			{
				return this.DeviceLangInternal;
			}
			set
			{
				if (StringUtils.IsBlank(value))
				{
					this.DeviceLangInternal = EKeyboardPrimaryLangId.Default;
					return;
				}
				this.DeviceLangInternal = value;
			}
		}

		// Token: 0x0603BD8D RID: 245133 RVA: 0x01100658 File Offset: 0x010FE858
		public void Initialize()
		{
			this.ActionMapping = new InputActionMapping();
			this.ActionMapping.Initialize();
			this.AxisMapping = new InputAxisMapping();
			this.AxisMapping.Initialize();
			this.CombinationActionMapping = new InputCombinationActionMapping();
			this.CombinationAxisMapping = new InputCombinationAxisMapping();
			this.RefreshAllActionKeys();
			this.RefreshAllAxisKeys();
			this.InitDeviceLangChangeDelegate();
			this.RefreshCombinationActionKeys();
			this.RefreshCombinationAxisKeys();
			this.InitKeySettingKeys();
			this.RebuildCurrentCombinationRuntimeMappings();
			this.ConvertInputActionSort();
			this.ConvertPhantomInput();
			this.TryFirstSaveKeyMappings();
		}

		// Token: 0x0603BD8E RID: 245134 RVA: 0x011006E4 File Offset: 0x010FE8E4
		public void Clear()
		{
			this.StopCheckCombinationActionKeyMapSave();
			this.SaveCombinationActionKeyMapIfDirty();
			this.ClearDeviceLangChangeDelegate();
			this.ActionMapping.Clear();
			this.ActionMapping = null;
			this.AxisMapping.Clear();
			this.AxisMapping = null;
			this.CombinationActionMapping.Clear();
			this.CombinationActionMapping = null;
			this.CombinationAxisMapping.Clear();
			this.CombinationAxisMapping = null;
		}

		// Token: 0x170070D9 RID: 28889
		// (get) Token: 0x0603BD8F RID: 245135 RVA: 0x0110074C File Offset: 0x010FE94C
		public bool CheckUseFrenchKeyboard
		{
			get
			{
				return InputSettings.Instance.GetKeyboardPrimaryLangId() == EKeyboardPrimaryLangId.French;
			}
		}

		// Token: 0x0603BD90 RID: 245136 RVA: 0x01100762 File Offset: 0x010FE962
		public bool CheckUseFrenchKeyboardLang(string deviceLang)
		{
			return deviceLang == EKeyboardPrimaryLangId.French;
		}

		// Token: 0x0603BD91 RID: 245137 RVA: 0x01100774 File Offset: 0x010FE974
		private void InitPcKeysMap()
		{
			this.NormalToFrenchPcKeysMap.Clear();
			this.FrenchToNormalPcKeysMap.Clear();
			IReadOnlyList<PcKey> pcKeyConfigList = InputSettingsConfig.Instance.GetPcKeyConfigList();
			if (pcKeyConfigList != null)
			{
				foreach (PcKey pcKey in pcKeyConfigList)
				{
					if (!StringUtils.IsBlank(pcKey.FrenchKeyName))
					{
						this.NormalToFrenchPcKeysMap[pcKey.KeyName] = pcKey.FrenchKeyName;
						this.FrenchToNormalPcKeysMap[pcKey.FrenchKeyName] = pcKey.KeyName;
					}
				}
			}
		}

		// Token: 0x0603BD92 RID: 245138 RVA: 0x0110081C File Offset: 0x010FEA1C
		private void InitDeviceLangChangeDelegate()
		{
			if (Platform.Instance.IsPcPlatform())
			{
				this.CurrentDeviceLang = InputSettings.Instance.GetKeyboardPrimaryLangId();
				this.DeviceLangInternal = this.CurrentDeviceLang;
				this.InitPcKeysMap();
				FDeviceLangChange fdeviceLangChange = DelegateUtils.ToManualReleaseDelegate<FDeviceLangChange>(new Action(this.OnDeviceLangChangeDelegate));
				UKuroStaticLibrary.BindDeviceLangChangeDelegate(fdeviceLangChange);
				return;
			}
			this.CurrentDeviceLang = EKeyboardPrimaryLangId.Default;
			this.DeviceLangInternal = EKeyboardPrimaryLangId.Default;
		}

		// Token: 0x0603BD93 RID: 245139 RVA: 0x01100891 File Offset: 0x010FEA91
		private void ClearDeviceLangChangeDelegate()
		{
			if (Platform.Instance.IsPcPlatform())
			{
				UKuroStaticLibrary.UnBindDeviceLangChangeDelegate();
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnDeviceLangChangeDelegate));
			}
		}

		// Token: 0x0603BD94 RID: 245140 RVA: 0x011008B8 File Offset: 0x010FEAB8
		private void OnDeviceLangChangeDelegate()
		{
			EKeyboardPrimaryLangId keyboardPrimaryLangId = InputSettings.Instance.GetKeyboardPrimaryLangId();
			this.CurrentDeviceLang = keyboardPrimaryLangId;
			this.ChangeActionAndAxisPcKeys(keyboardPrimaryLangId);
		}

		// Token: 0x0603BD95 RID: 245141 RVA: 0x011008E4 File Offset: 0x010FEAE4
		private string GetKeyNameByKeyboardLang(string lastDeviceLang, string deviceLang, string originalKeyName)
		{
			if (lastDeviceLang == EKeyboardPrimaryLangId.Default && deviceLang == EKeyboardPrimaryLangId.French)
			{
				string text;
				if (this.NormalToFrenchPcKeysMap.TryGetValue(originalKeyName, out text) && !string.IsNullOrEmpty(text))
				{
					return text;
				}
				return originalKeyName;
			}
			else
			{
				if (!(lastDeviceLang == EKeyboardPrimaryLangId.French) || !(deviceLang == EKeyboardPrimaryLangId.Default))
				{
					string text2 = originalKeyName;
					if (lastDeviceLang != EKeyboardPrimaryLangId.Default)
					{
						LanguageKeyTransBase keyTrans = LanguageKeyTransUtils.GetKeyTrans((EKeyboardPrimaryLangId)lastDeviceLang);
						if (keyTrans != null)
						{
							text2 = keyTrans.GetOtherToNormalPcKeysMap(originalKeyName);
						}
					}
					if (deviceLang != EKeyboardPrimaryLangId.Default)
					{
						LanguageKeyTransBase keyTrans2 = LanguageKeyTransUtils.GetKeyTrans((EKeyboardPrimaryLangId)deviceLang);
						if (keyTrans2 != null)
						{
							text2 = keyTrans2.GetNormalToOtherPcKeysMap(text2);
						}
					}
					return text2;
				}
				string text3;
				if (this.FrenchToNormalPcKeysMap.TryGetValue(originalKeyName, out text3) && !string.IsNullOrEmpty(text3))
				{
					return text3;
				}
				return originalKeyName;
			}
		}

		// Token: 0x0603BD96 RID: 245142 RVA: 0x011009CC File Offset: 0x010FEBCC
		private void ChangeActionPcKeys(string lastDeviceLang, string deviceLang)
		{
			IReadOnlyList<ActionMapping> allActionMappingConfig = InputSettingsConfig.Instance.GetAllActionMappingConfig();
			if (allActionMappingConfig != null)
			{
				foreach (ActionMapping actionMapping in allActionMappingConfig)
				{
					string actionName = actionMapping.ActionName;
					InputActionBinding actionBinding = this.GetActionBinding(actionName);
					if (actionBinding != null)
					{
						foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair in actionBinding.GetCopyKeyNameListToBindingTypeMap())
						{
							EInputBindingType einputBindingType;
							List<string> list;
							keyValuePair.Deconstruct(out einputBindingType, out list);
							EInputBindingType bindingType = einputBindingType;
							List<string> list2 = list;
							List<string> list3 = new List<string>(list2.Count);
							bool flag = false;
							foreach (string text in list2)
							{
								InputKey key = InputSettings.Instance.GetKey(text);
								if (key != null && key.IsKeyboardKey)
								{
									flag = true;
									list3.Add(this.GetKeyNameByKeyboardLang(lastDeviceLang, deviceLang, text));
								}
								else
								{
									list3.Add(text);
								}
							}
							if (flag)
							{
								this.SetActionKeysByBindingType(actionName, list3, bindingType);
							}
						}
					}
				}
			}
		}

		// Token: 0x0603BD97 RID: 245143 RVA: 0x01100B24 File Offset: 0x010FED24
		private void ChangeAxisPcKeys(string lastDeviceLang, string deviceLang)
		{
			IReadOnlyList<AxisMapping> allAxisMappingConfig = InputSettingsConfig.Instance.GetAllAxisMappingConfig();
			if (allAxisMappingConfig != null)
			{
				foreach (AxisMapping axisMapping in allAxisMappingConfig)
				{
					string axisName = axisMapping.AxisName;
					InputAxisBinding axisBinding = this.GetAxisBinding(axisName);
					if (axisBinding != null)
					{
						foreach (KeyValuePair<EInputBindingType, Dictionary<string, float>> keyValuePair in axisBinding.GetCopyKeyNameListToBindingTypeMap())
						{
							EInputBindingType key = keyValuePair.Key;
							Dictionary<string, float> value = keyValuePair.Value;
							Dictionary<string, float> dictionary = new Dictionary<string, float>();
							bool flag = false;
							foreach (KeyValuePair<string, float> keyValuePair2 in value)
							{
								string key2 = keyValuePair2.Key;
								float value2 = keyValuePair2.Value;
								InputKey key3 = InputSettings.Instance.GetKey(key2);
								if (key3 != null && key3.IsKeyboardKey)
								{
									flag = true;
									dictionary[this.GetKeyNameByKeyboardLang(lastDeviceLang, deviceLang, key2)] = value2;
								}
								else
								{
									dictionary[key2] = value2;
								}
							}
							if (flag)
							{
								this.SetAxisKeys(axisName, dictionary, key);
							}
						}
					}
				}
			}
		}

		// Token: 0x0603BD98 RID: 245144 RVA: 0x01100CAC File Offset: 0x010FEEAC
		private void ChangeCombinationActionPcKeys(string lastDeviceLang, string deviceLang)
		{
			IReadOnlyList<CombinationAction> allCombinationActionConfig = InputSettingsConfig.Instance.GetAllCombinationActionConfig();
			if (allCombinationActionConfig == null)
			{
				return;
			}
			foreach (CombinationAction combinationAction in allCombinationActionConfig)
			{
				string actionName = combinationAction.ActionName;
				InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
				if (combinationActionBindingByActionName != null)
				{
					foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in combinationActionBindingByActionName.GetCopyKeyMapToBindingTypeMap())
					{
						EInputBindingType key = keyValuePair.Key;
						foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
						{
							string key2 = keyValuePair2.Key;
							string value = keyValuePair2.Value;
							InputKey key3 = InputSettings.Instance.GetKey(key2);
							InputKey key4 = InputSettings.Instance.GetKey(value);
							if ((key3 != null && key3.IsKeyboardKey) || (key4 != null && key4.IsKeyboardKey))
							{
								string keyNameByKeyboardLang = this.GetKeyNameByKeyboardLang(lastDeviceLang, deviceLang, key2);
								string keyNameByKeyboardLang2 = this.GetKeyNameByKeyboardLang(lastDeviceLang, deviceLang, value);
								if (!(keyNameByKeyboardLang == key2) || !(keyNameByKeyboardLang2 == value))
								{
									this.RemoveCombinationActionKeyMap(actionName, key2, value, key);
									this.AddCombinationActionKeyMap(actionName, keyNameByKeyboardLang, keyNameByKeyboardLang2, key);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0603BD99 RID: 245145 RVA: 0x01100E60 File Offset: 0x010FF060
		public unsafe void ChangeActionAndAxisPcKeys(string deviceLang)
		{
			if (this.DeviceLangInternal == deviceLang)
			{
				return;
			}
			string deviceLangInternal = this.DeviceLangInternal;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "识别到键盘设备切换";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("上次键盘设备语种", deviceLangInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前键盘设备语种", deviceLang);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.AddAllowChangeKeyReason("OnDeviceLangChange");
			}
			this.DeviceLangInternal = deviceLang;
			this.ChangeActionPcKeys(deviceLangInternal, deviceLang);
			this.ChangeAxisPcKeys(deviceLangInternal, deviceLang);
			this.ChangeCombinationActionPcKeys(deviceLangInternal, deviceLang);
			EventSystem.Instance.Emit(EEventName.OnDeviceLangChange);
			SkillButtonUiGamepadDataBase gamepadData2 = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData2 != null)
			{
				gamepadData2.RemoveAllowChangeKeyReason("OnDeviceLangChange");
			}
			if (Net.Instance.IsServerConnected())
			{
				InputSettingsController.Instance.InputSettingUpdateRequest();
			}
		}

		// Token: 0x0603BD9A RID: 245146 RVA: 0x01100F50 File Offset: 0x010FF150
		public unsafe bool ConvertAppliedServerKeyboardOverrides(string serverDeviceLang, string localDeviceLang)
		{
			if (!Platform.Instance.IsPcPlatform() || serverDeviceLang == localDeviceLang)
			{
				this.DeviceLang = localDeviceLang;
				return false;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "服务端存储的键盘布局与本地布局不一致，转换服务端键盘覆盖项";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("服务端存储布局", serverDeviceLang);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("本地布局", localDeviceLang);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.AddAllowChangeKeyReason("OnDeviceLangChange");
			}
			try
			{
				this.ConvertAppliedActionKeyboardOverrides(serverDeviceLang, localDeviceLang);
				this.ConvertAppliedAxisKeyboardOverrides(serverDeviceLang, localDeviceLang);
				this.ConvertAppliedCombinationActionKeyboardOverrides(serverDeviceLang, localDeviceLang);
				this.ConvertAppliedCombinationAxisKeyboardOverrides(serverDeviceLang, localDeviceLang);
			}
			finally
			{
				this.DeviceLang = localDeviceLang;
				SkillButtonUiGamepadDataBase gamepadData2 = SkillButtonUiModel.Instance.GamepadData;
				if (gamepadData2 != null)
				{
					gamepadData2.RemoveAllowChangeKeyReason("OnDeviceLangChange");
				}
			}
			EventSystem.Instance.Emit(EEventName.OnDeviceLangChange);
			return true;
		}

		// Token: 0x0603BD9B RID: 245147 RVA: 0x01101050 File Offset: 0x010FF250
		private string ConvertKeyboardKeyName(string lastDeviceLang, string deviceLang, string keyName)
		{
			InputKey key = InputSettings.Instance.GetKey(keyName);
			if (key == null || !key.IsKeyboardKey)
			{
				return keyName;
			}
			return this.GetKeyNameByKeyboardLang(lastDeviceLang, deviceLang, keyName);
		}

		// Token: 0x0603BD9C RID: 245148 RVA: 0x01101080 File Offset: 0x010FF280
		private void ConvertAppliedActionKeyboardOverrides(string lastDeviceLang, string deviceLang)
		{
			foreach (KeyValuePair<string, HashSet<EInputBindingType>> keyValuePair in this.AppliedKeyboardActionOverrides)
			{
				string text;
				HashSet<EInputBindingType> hashSet;
				keyValuePair.Deconstruct(out text, out hashSet);
				string actionName = text;
				HashSet<EInputBindingType> hashSet2 = hashSet;
				InputActionBinding actionBinding = this.GetActionBinding(actionName);
				if (actionBinding != null)
				{
					foreach (EInputBindingType bindingType in hashSet2)
					{
						List<string> list = new List<string>();
						actionBinding.GetPcKeyNameListByBindingType(list, bindingType);
						List<string> list2 = new List<string>(list.Count);
						bool flag = false;
						foreach (string text2 in list)
						{
							string text3 = this.ConvertKeyboardKeyName(lastDeviceLang, deviceLang, text2);
							if (text3 != text2)
							{
								flag = true;
							}
							list2.Add(text3);
						}
						if (flag)
						{
							actionBinding.SetKeyboardKeys(list2, bindingType);
						}
					}
				}
			}
		}

		// Token: 0x0603BD9D RID: 245149 RVA: 0x011011C0 File Offset: 0x010FF3C0
		private void ConvertAppliedAxisKeyboardOverrides(string lastDeviceLang, string deviceLang)
		{
			foreach (KeyValuePair<string, HashSet<EInputBindingType>> keyValuePair in this.AppliedKeyboardAxisOverrides)
			{
				string text;
				HashSet<EInputBindingType> hashSet;
				keyValuePair.Deconstruct(out text, out hashSet);
				string axisName = text;
				HashSet<EInputBindingType> hashSet2 = hashSet;
				InputAxisBinding axisBinding = this.GetAxisBinding(axisName);
				if (axisBinding != null)
				{
					foreach (EInputBindingType bindingType in hashSet2)
					{
						Dictionary<string, float> dictionary = new Dictionary<string, float>();
						axisBinding.GetPcKeyScaleMap(dictionary, bindingType);
						Dictionary<string, float> dictionary2 = new Dictionary<string, float>();
						bool flag = false;
						foreach (KeyValuePair<string, float> keyValuePair2 in dictionary)
						{
							float num;
							keyValuePair2.Deconstruct(out text, out num);
							string text2 = text;
							float value = num;
							string text3 = this.ConvertKeyboardKeyName(lastDeviceLang, deviceLang, text2);
							if (text3 != text2)
							{
								flag = true;
							}
							dictionary2[text3] = value;
						}
						if (flag)
						{
							axisBinding.SetKeyboardKeys(dictionary2, bindingType);
						}
					}
				}
			}
		}

		// Token: 0x0603BD9E RID: 245150 RVA: 0x01101310 File Offset: 0x010FF510
		private void ConvertAppliedCombinationActionKeyboardOverrides(string lastDeviceLang, string deviceLang)
		{
			foreach (KeyValuePair<string, HashSet<EInputBindingType>> keyValuePair in this.AppliedKeyboardCombinationActionOverrides)
			{
				string text;
				HashSet<EInputBindingType> hashSet;
				keyValuePair.Deconstruct(out text, out hashSet);
				string actionName = text;
				HashSet<EInputBindingType> hashSet2 = hashSet;
				InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
				if (combinationActionBindingByActionName != null)
				{
					foreach (EInputBindingType bindingType in hashSet2)
					{
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						combinationActionBindingByActionName.GetPcKeyNameMap(dictionary, bindingType);
						Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
						bool flag = false;
						foreach (KeyValuePair<string, string> keyValuePair2 in dictionary)
						{
							string text2;
							keyValuePair2.Deconstruct(out text, out text2);
							string text3 = text;
							string text4 = text2;
							string text5 = this.ConvertKeyboardKeyName(lastDeviceLang, deviceLang, text3);
							string text6 = this.ConvertKeyboardKeyName(lastDeviceLang, deviceLang, text4);
							if (text5 != text3 || text6 != text4)
							{
								flag = true;
							}
							dictionary2[text5] = text6;
						}
						if (flag)
						{
							combinationActionBindingByActionName.ReplaceKeyboardKeyMap(bindingType, dictionary2);
						}
					}
				}
			}
		}

		// Token: 0x0603BD9F RID: 245151 RVA: 0x01101498 File Offset: 0x010FF698
		private void ConvertAppliedCombinationAxisKeyboardOverrides(string lastDeviceLang, string deviceLang)
		{
			foreach (KeyValuePair<string, HashSet<EInputBindingType>> keyValuePair in this.AppliedKeyboardCombinationAxisOverrides)
			{
				string text;
				HashSet<EInputBindingType> hashSet;
				keyValuePair.Deconstruct(out text, out hashSet);
				string axisName = text;
				HashSet<EInputBindingType> hashSet2 = hashSet;
				InputCombinationAxisBinding combinationAxisBindingByAxisName = this.GetCombinationAxisBindingByAxisName(axisName);
				if (combinationAxisBindingByAxisName != null)
				{
					foreach (EInputBindingType bindingType in hashSet2)
					{
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						combinationAxisBindingByAxisName.GetPcKeyNameMap(dictionary, bindingType);
						Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
						bool flag = false;
						foreach (KeyValuePair<string, string> keyValuePair2 in dictionary)
						{
							string text2;
							keyValuePair2.Deconstruct(out text, out text2);
							string text3 = text;
							string text4 = text2;
							string text5 = this.ConvertKeyboardKeyName(lastDeviceLang, deviceLang, text4);
							string text6 = this.ConvertKeyboardKeyName(lastDeviceLang, deviceLang, text3);
							if (text5 != text4 || text6 != text3)
							{
								flag = true;
							}
							dictionary2[text6] = text5;
						}
						if (flag)
						{
							combinationAxisBindingByAxisName.ReplaceKeyboardKeyMap(bindingType, dictionary2);
						}
					}
				}
			}
		}

		// Token: 0x0603BDA0 RID: 245152 RVA: 0x01101620 File Offset: 0x010FF820
		public void RebuildDefaultInputSnapshot()
		{
			this.ResetAllActionAndAxisBindingStates();
			InputSettings.Instance.ClearCombinationActionMappings();
			InputSettings.Instance.ClearCombinationAxisMappings();
			this.RefreshAllActionKeys();
			this.RefreshAllAxisKeys();
			this.RefreshCombinationActionKeys();
			this.RefreshCombinationAxisKeys();
			this.InitKeySettingKeys();
			this.SwitchKeysByBindingType(this.CurrentBindingType);
		}

		// Token: 0x0603BDA1 RID: 245153 RVA: 0x01101671 File Offset: 0x010FF871
		private void ResetAllActionAndAxisBindingStates()
		{
			InputActionMapping actionMapping = this.ActionMapping;
			if (actionMapping != null)
			{
				actionMapping.ResetAllActionBindingStates();
			}
			InputAxisMapping axisMapping = this.AxisMapping;
			if (axisMapping == null)
			{
				return;
			}
			axisMapping.ResetAllAxisBindingStates();
		}

		// Token: 0x0603BDA2 RID: 245154 RVA: 0x01101694 File Offset: 0x010FF894
		public void ResetDefaultInputKey()
		{
			this.RebuildDefaultInputSnapshot();
			InputSettings.Instance.SaveKeyMappings();
		}

		// Token: 0x0603BDA3 RID: 245155 RVA: 0x011016A6 File Offset: 0x010FF8A6
		public void ClearAllKeys()
		{
			InputActionMapping actionMapping = this.ActionMapping;
			if (actionMapping != null)
			{
				actionMapping.ClearAllActionKeys();
			}
			InputAxisMapping axisMapping = this.AxisMapping;
			if (axisMapping != null)
			{
				axisMapping.ClearAllAxisKeys();
			}
			this.ClearCombinationActionKeyMap();
			this.ClearCombinationAxisKeyMap();
		}

		// Token: 0x0603BDA4 RID: 245156 RVA: 0x011016D8 File Offset: 0x010FF8D8
		public void RefreshAllActionKeys()
		{
			IReadOnlyList<ActionMapping> allActionMappingConfig = InputSettingsConfig.Instance.GetAllActionMappingConfig();
			if (allActionMappingConfig != null)
			{
				foreach (ActionMapping actionMappingConfig in allActionMappingConfig)
				{
					string actionName = actionMappingConfig.ActionName;
					this.OriginalActionNameSet.Add(actionName);
					this.SetDefaultConfigActionKeys(actionName, actionMappingConfig, (EInputBindingType)actionMappingConfig.ExclusiveType);
				}
			}
		}

		// Token: 0x0603BDA5 RID: 245157 RVA: 0x0110174C File Offset: 0x010FF94C
		private void SetDefaultConfigActionKeys(string actionName, ActionMapping actionMappingConfig, EInputBindingType bindingType)
		{
			List<string> list = new List<string>();
			if (this.CheckUseFrenchKeyboard)
			{
				for (int i = 0; i < actionMappingConfig.FrancePcKeysLength; i++)
				{
					list.Add(actionMappingConfig.FrancePcKeys(i));
				}
			}
			else
			{
				LanguageKeyTransBase keyTrans = LanguageKeyTransUtils.GetKeyTrans(this.CurrentDeviceLang);
				if (keyTrans != null)
				{
					string[] actionPcKeys = keyTrans.GetActionPcKeys(actionMappingConfig);
					list.AddRange(actionPcKeys);
				}
			}
			List<string> list2 = new List<string>();
			for (int j = 0; j < actionMappingConfig.GamepadKeysLength; j++)
			{
				string text = actionMappingConfig.GamepadKeys(j);
				if (!string.IsNullOrEmpty(text))
				{
					list2.Add(text);
				}
			}
			List<string> list3 = new List<string>(list);
			list3.AddRange(list2);
			this.SetActionKeysByBindingType(actionName, list3, bindingType);
		}

		// Token: 0x0603BDA6 RID: 245158 RVA: 0x011017FC File Offset: 0x010FF9FC
		public void RefreshAllAxisKeys()
		{
			IReadOnlyList<AxisMapping> allAxisMappingConfig = InputSettingsConfig.Instance.GetAllAxisMappingConfig();
			if (allAxisMappingConfig != null)
			{
				foreach (AxisMapping axisMappingConfig in allAxisMappingConfig)
				{
					string axisName = axisMappingConfig.AxisName;
					this.SetDefaultConfigAxisKeys(axisName, axisMappingConfig, (EInputBindingType)axisMappingConfig.ExclusiveType);
				}
			}
		}

		// Token: 0x0603BDA7 RID: 245159 RVA: 0x01101864 File Offset: 0x010FFA64
		private void SetDefaultConfigAxisKeys(string axisName, AxisMapping axisMappingConfig, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = new Dictionary<string, float>();
			if (this.CheckUseFrenchKeyboard)
			{
				for (int i = 0; i < axisMappingConfig.FrancePcKeysLength; i++)
				{
					DicStringFloat? dicStringFloat = axisMappingConfig.FrancePcKeys(i);
					dictionary[dicStringFloat.Value.Key] = dicStringFloat.Value.Value;
				}
			}
			else
			{
				LanguageKeyTransBase keyTrans = LanguageKeyTransUtils.GetKeyTrans(this.CurrentDeviceLang);
				if (keyTrans != null)
				{
					dictionary = keyTrans.GetAxisPcKeys(axisMappingConfig);
				}
			}
			Dictionary<string, float> dictionary2 = new Dictionary<string, float>();
			for (int j = 0; j < axisMappingConfig.GamepadKeysLength; j++)
			{
				DicStringFloat? dicStringFloat2 = axisMappingConfig.GamepadKeys(j);
				dictionary2[dicStringFloat2.Value.Key] = dicStringFloat2.Value.Value;
			}
			Dictionary<string, float> dictionary3 = new Dictionary<string, float>();
			dictionary3.AddRange(dictionary);
			dictionary3.AddRange(dictionary2);
			this.SetAxisKeys(axisName, dictionary3, bindingType);
		}

		// Token: 0x0603BDA8 RID: 245160 RVA: 0x01101948 File Offset: 0x010FFB48
		public void ResetActionKeyByName(string actionName, EInputBindingType bindingType)
		{
			ActionMapping? actionMappingConfigByActionName = InputSettingsConfig.Instance.GetActionMappingConfigByActionName(actionName);
			if (actionMappingConfigByActionName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "Action按键配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionName", actionName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.SetDefaultConfigActionKeys(actionName, actionMappingConfigByActionName.Value, bindingType);
		}

		// Token: 0x0603BDA9 RID: 245161 RVA: 0x011019A4 File Offset: 0x010FFBA4
		public void ResetAxisKeyByName(string axisName, EInputBindingType bindingType)
		{
			AxisMapping? axisMappingConfigByAxisName = InputSettingsConfig.Instance.GetAxisMappingConfigByAxisName(axisName);
			if (axisMappingConfigByAxisName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "Axis按键配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AxisName", axisName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.SetDefaultConfigAxisKeys(axisName, axisMappingConfigByAxisName.Value, bindingType);
		}

		// Token: 0x0603BDAA RID: 245162 RVA: 0x01101A00 File Offset: 0x010FFC00
		public unsafe void ResetCombinationActionKeyByName(string actionName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, EInputBindingType bindingType)
		{
			List<List<string>> list = new List<List<string>>();
			IList<IList<string>> list2;
			if (this.CombinationActionKeyMap.TryGetValue(actionName, out list2) && list2 != null)
			{
				foreach (IList<string> list3 in list2)
				{
					List<List<string>> list4 = list;
					int num = 2;
					List<string> list5 = new List<string>(num);
					CollectionsMarshal.SetCount<string>(list5, num);
					Span<string> span = CollectionsMarshal.AsSpan<string>(list5);
					int num2 = 0;
					*span[num2] = list3[0];
					num2++;
					*span[num2] = list3[1];
					List<string> list6 = list5;
					list4.AddRange(new ReadOnlySpan<List<string>>(ref list6));
				}
			}
			foreach (List<string> list7 in list)
			{
				string mainKeyName = list7[0];
				string secondaryKeyName = list7[1];
				this.RemoveCombinationActionKeyMap(actionName, mainKeyName, secondaryKeyName, bindingType);
			}
			if (!this.IsOriginalCombinationActionName(actionName, inputControllerType))
			{
				return;
			}
			CombinationAction? combinationActionConfigByActionName = InputSettingsConfig.Instance.GetCombinationActionConfigByActionName(actionName);
			if (combinationActionConfigByActionName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "组合Action按键配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionName", actionName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			HashSet<string> keyboardOriginalCombinationActionNameSet;
			this.OriginalCombinationActionNameMap.TryGetValue(CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard, out keyboardOriginalCombinationActionNameSet);
			HashSet<string> gamepadOriginalCombinationActionNameSet;
			this.OriginalCombinationActionNameMap.TryGetValue(CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad, out gamepadOriginalCombinationActionNameSet);
			this.SetDefaultConfigCombinationActionKeys(combinationActionConfigByActionName.Value, keyboardOriginalCombinationActionNameSet, gamepadOriginalCombinationActionNameSet, bindingType);
		}

		// Token: 0x0603BDAB RID: 245163 RVA: 0x01101B88 File Offset: 0x010FFD88
		public EInputBindingType GetBindTypeByExclusiveType(EKeySettingExclusiveType exclusiveType)
		{
			EInputBindingType result;
			if (!this.ExclusiveTypeToBindingTypeMap.TryGetValue(exclusiveType, out result))
			{
				return EInputBindingType.Original;
			}
			return result;
		}

		// Token: 0x0603BDAC RID: 245164 RVA: 0x01101BA8 File Offset: 0x010FFDA8
		public EKeySettingExclusiveType GetExclusiveTypeByBindingType(EInputBindingType bindingType)
		{
			foreach (KeyValuePair<EKeySettingExclusiveType, EInputBindingType> keyValuePair in this.ExclusiveTypeToBindingTypeMap)
			{
				if (keyValuePair.Value == bindingType)
				{
					return keyValuePair.Key;
				}
			}
			return EKeySettingExclusiveType.None;
		}

		// Token: 0x0603BDAD RID: 245165 RVA: 0x01101C0C File Offset: 0x010FFE0C
		[return: Nullable(2)]
		public InputActionBinding GetActionBinding(string actionName)
		{
			return this.ActionMapping.GetActionBinding(actionName);
		}

		// Token: 0x0603BDAE RID: 245166 RVA: 0x01101C1A File Offset: 0x010FFE1A
		public IReadOnlyDictionary<string, InputActionBinding> GetActionBindingMap()
		{
			return this.ActionMapping.GetActionBindingMap();
		}

		// Token: 0x0603BDAF RID: 245167 RVA: 0x01101C27 File Offset: 0x010FFE27
		[NullableContext(2)]
		public InputActionBinding GetActionBindingByConfigId(int configId)
		{
			return this.ActionMapping.GetActionBindingByConfigId(configId);
		}

		// Token: 0x0603BDB0 RID: 245168 RVA: 0x01101C38 File Offset: 0x010FFE38
		[return: Nullable(2)]
		public unsafe string CheckGetActionKeyIconPath(InputActionBinding actionBinding)
		{
			InputKey currentPlatformKey = actionBinding.GetCurrentPlatformKey();
			if (currentPlatformKey == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "Action找不到对应按键";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", actionBinding.GetActionName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("KeyName", null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			string keyIconPath = currentPlatformKey.GetKeyIconPath();
			if (string.IsNullOrEmpty(keyIconPath))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputSettings;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "此按键配置了空的图标路径";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("KeyName", currentPlatformKey.GetKeyName());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return keyIconPath;
		}

		// Token: 0x0603BDB1 RID: 245169 RVA: 0x01101CE7 File Offset: 0x010FFEE7
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlySet<InputActionBinding> GetActionBindingByActionMappingType(EActionMappingType actionMappingType)
		{
			return this.ActionMapping.GetActionBindingByActionMappingType(actionMappingType);
		}

		// Token: 0x0603BDB2 RID: 245170 RVA: 0x01101CF8 File Offset: 0x010FFEF8
		public void SetActionKeysByBindingType(string actionName, List<string> keys, EInputBindingType bindingType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "设置Action按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ActionMapping.SetKeys(actionName, keys, bindingType);
		}

		// Token: 0x0603BDB3 RID: 245171 RVA: 0x01101D3C File Offset: 0x010FFF3C
		public void SetActionKeys(string actionName, List<string> keys)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "设置Action按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			InputActionBinding actionBinding = this.ActionMapping.GetActionBinding(actionName);
			if (actionBinding == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputSettings;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "设置Action按键时，找不到对应Action";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("actionName", actionName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.ActionMapping.SetKeys(actionName, keys, actionBinding.CurrentBindingType);
		}

		// Token: 0x0603BDB4 RID: 245172 RVA: 0x01101DBC File Offset: 0x010FFFBC
		public void RefreshActionKeys(string actionName, TArray<FInputActionKeyMapping> actionMappings, EInputBindingType bindingType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "刷新Action按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ActionMapping.RefreshKeysByActionMappings(actionName, actionMappings, bindingType);
		}

		// Token: 0x0603BDB5 RID: 245173 RVA: 0x01101DFE File Offset: 0x010FFFFE
		[return: Nullable(2)]
		public InputAxisBinding GetAxisBinding(string axisName)
		{
			return this.AxisMapping.GetAxisBinding(axisName);
		}

		// Token: 0x0603BDB6 RID: 245174 RVA: 0x01101E0C File Offset: 0x0110000C
		public IReadOnlyDictionary<string, InputAxisBinding> GetAxisBindingMap()
		{
			return this.AxisMapping.GetAxisBindingMap();
		}

		// Token: 0x0603BDB7 RID: 245175 RVA: 0x01101E19 File Offset: 0x01100019
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlySet<InputAxisBinding> GetAxisBindingByAxisMappingType(EAxisMappingType axisMappingType)
		{
			return this.AxisMapping.GetAxisBindingByAxisMappingType(axisMappingType);
		}

		// Token: 0x0603BDB8 RID: 245176 RVA: 0x01101E28 File Offset: 0x01100028
		[return: Nullable(2)]
		public unsafe string CheckGetAxisKeyIconPath(InputAxisBinding axisBinding)
		{
			InputAxisKey currentPlatformKey = axisBinding.GetCurrentPlatformKey();
			if (currentPlatformKey == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "Axis找不到对应按键";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AxisName", axisBinding.GetAxisName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("KeyName", null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			string keyIconPath = currentPlatformKey.GetKeyIconPath();
			if (string.IsNullOrEmpty(keyIconPath))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputSettings;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "此按键配置了空的图标路径";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("KeyName", currentPlatformKey.KeyName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return keyIconPath;
		}

		// Token: 0x0603BDB9 RID: 245177 RVA: 0x01101ED8 File Offset: 0x011000D8
		[return: TupleElementNames(new string[]
		{
			"IsContain",
			"ContainAxisBinding"
		})]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public ValueTuple<bool, InputAxisBinding> ContainAxisKeyByType(EAxisMappingType axisMappingType, string keyName)
		{
			IReadOnlySet<InputAxisBinding> axisBindingByAxisMappingType = this.AxisMapping.GetAxisBindingByAxisMappingType(axisMappingType);
			if (axisBindingByAxisMappingType != null)
			{
				foreach (InputAxisBinding inputAxisBinding in axisBindingByAxisMappingType)
				{
					if (inputAxisBinding.HasKey(keyName))
					{
						return new ValueTuple<bool, InputAxisBinding>(true, inputAxisBinding);
					}
				}
			}
			return new ValueTuple<bool, InputAxisBinding>(false, null);
		}

		// Token: 0x0603BDBA RID: 245178 RVA: 0x01101F48 File Offset: 0x01100148
		public void SetAxisKeys(string axisName, Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "设置Axis按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.AxisMapping.SetKeys(axisName, keyScaleMap, bindingType);
		}

		// Token: 0x0603BDBB RID: 245179 RVA: 0x01101F8C File Offset: 0x0110018C
		public void RefreshAxisKeys(string axisName, TArray<FInputAxisKeyMapping> axisMappings, EInputBindingType bindingType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "刷新Axis按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.AxisMapping.RefreshKeys(axisName, axisMappings, bindingType);
		}

		// Token: 0x0603BDBC RID: 245180 RVA: 0x01101FCE File Offset: 0x011001CE
		public void RefreshCombinationActionKeys()
		{
			this.ClearCombinationActionKeyMap();
			this.CombinationActionKeyMap.Clear();
			this.SetCombinationActionKeyMapDirty();
			this.RefreshCombinationActionFromConfig();
		}

		// Token: 0x0603BDBD RID: 245181 RVA: 0x01101FF0 File Offset: 0x011001F0
		private void RefreshCombinationActionFromConfig()
		{
			this.OriginalCombinationActionNameMap.Clear();
			IReadOnlyList<CombinationAction> allCombinationActionConfig = InputSettingsConfig.Instance.GetAllCombinationActionConfig();
			if (allCombinationActionConfig == null)
			{
				return;
			}
			this.OriginalCombinationActionNameSet.Clear();
			foreach (CombinationAction combinationAction in allCombinationActionConfig)
			{
				this.OriginalCombinationActionNameSet.Add(combinationAction.ActionName);
			}
			HashSet<string> hashSet = new HashSet<string>();
			HashSet<string> hashSet2 = new HashSet<string>();
			foreach (CombinationAction combinationActionConfig in allCombinationActionConfig)
			{
				int exclusiveType = combinationActionConfig.ExclusiveType;
				this.SetDefaultConfigCombinationActionKeys(combinationActionConfig, hashSet, hashSet2, (EInputBindingType)exclusiveType);
			}
			this.OriginalCombinationActionNameMap[CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard] = hashSet;
			this.OriginalCombinationActionNameMap[CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad] = hashSet2;
		}

		// Token: 0x0603BDBE RID: 245182 RVA: 0x011020D8 File Offset: 0x011002D8
		private void SetDefaultConfigCombinationActionKeys(CombinationAction combinationActionConfig, HashSet<string> keyboardOriginalCombinationActionNameSet, HashSet<string> gamepadOriginalCombinationActionNameSet, EInputBindingType bindingType)
		{
			string actionName = combinationActionConfig.ActionName;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (this.CheckUseFrenchKeyboard)
			{
				dictionary = combinationActionConfig.FrancePcKeys();
			}
			else
			{
				LanguageKeyTransBase keyTrans = LanguageKeyTransUtils.GetKeyTrans(this.CurrentDeviceLang);
				if (keyTrans != null)
				{
					dictionary = keyTrans.GetCombinationActionPcKeys(combinationActionConfig);
				}
			}
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string mainKeyName = text;
				string secondaryKeyName = text2;
				InputCombinationActionBinding inputCombinationActionBinding = this.AddCombinationActionKeyMap(actionName, mainKeyName, secondaryKeyName, bindingType);
				Dictionary<EKeySettingExclusiveType, int> dictionary2 = new Dictionary<EKeySettingExclusiveType, int>();
				for (int i = 0; i < combinationActionConfig.KeyboardVersionMapLength; i++)
				{
					DicIntInt? dicIntInt = combinationActionConfig.KeyboardVersionMap(i);
					EKeySettingExclusiveType key = (EKeySettingExclusiveType)dicIntInt.Value.Key;
					dictionary2.Add(key, dicIntInt.Value.Value);
				}
				if (inputCombinationActionBinding != null)
				{
					inputCombinationActionBinding.SetKeyboardVersionMap(dictionary2);
				}
				keyboardOriginalCombinationActionNameSet.Add(actionName);
			}
			if (combinationActionConfig.GamepadKeysLength > 0)
			{
				for (int j = 0; j < combinationActionConfig.GamepadKeysLength; j++)
				{
					DicStringString? dicStringString = combinationActionConfig.GamepadKeys(j);
					string key2 = dicStringString.Value.Key;
					string value = dicStringString.Value.Value;
					InputCombinationActionBinding inputCombinationActionBinding2 = this.AddCombinationActionKeyMap(actionName, key2, value, bindingType);
					Dictionary<EKeySettingExclusiveType, int> dictionary3 = new Dictionary<EKeySettingExclusiveType, int>();
					for (int k = 0; k < combinationActionConfig.GamepadVersionMapLength; k++)
					{
						DicIntInt? dicIntInt2 = combinationActionConfig.GamepadVersionMap(k);
						EKeySettingExclusiveType key3 = (EKeySettingExclusiveType)dicIntInt2.Value.Key;
						dictionary3.Add(key3, dicIntInt2.Value.Value);
					}
					if (inputCombinationActionBinding2 != null)
					{
						inputCombinationActionBinding2.SetGamepadVersionMap(dictionary3);
					}
					gamepadOriginalCombinationActionNameSet.Add(actionName);
				}
			}
		}

		// Token: 0x0603BDBF RID: 245183 RVA: 0x011022B8 File Offset: 0x011004B8
		[return: Nullable(2)]
		public InputCombinationActionBinding SetCombinationActionKeyboardKeys(string actionName, Dictionary<string, string> keyNameMap, EInputBindingType bindingType)
		{
			InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName == null)
			{
				return null;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			combinationActionBindingByActionName.GetPcKeyNameMap(dictionary, bindingType);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.RemoveCombinationActionKeyMap(actionName, key, value, bindingType);
			}
			foreach (KeyValuePair<string, string> keyValuePair2 in keyNameMap)
			{
				string key2 = keyValuePair2.Key;
				string value2 = keyValuePair2.Value;
				this.AddCombinationActionKeyMap(actionName, key2, value2, bindingType);
			}
			return combinationActionBindingByActionName;
		}

		// Token: 0x0603BDC0 RID: 245184 RVA: 0x01102390 File Offset: 0x01100590
		[return: Nullable(2)]
		public InputCombinationActionBinding SetOrAddCombinationActionKeyboardKeys(string actionName, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> keyNameMap, EInputBindingType bindingType)
		{
			InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName != null)
			{
				IReadOnlyDictionary<string, string> pcKeyNameMap = combinationActionBindingByActionName.GetPcKeyNameMap(bindingType);
				if (pcKeyNameMap != null)
				{
					foreach (KeyValuePair<string, string> keyValuePair in pcKeyNameMap)
					{
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string mainKeyName = text;
						string secondaryKeyName = text2;
						this.RemoveCombinationActionKeyMap(actionName, mainKeyName, secondaryKeyName, bindingType);
					}
				}
			}
			if (keyNameMap != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair2 in keyNameMap)
				{
					string key = keyValuePair2.Key;
					string value = keyValuePair2.Value;
					this.AddCombinationActionKeyMap(actionName, key, value, bindingType);
				}
			}
			return combinationActionBindingByActionName;
		}

		// Token: 0x0603BDC1 RID: 245185 RVA: 0x0110245C File Offset: 0x0110065C
		[return: Nullable(2)]
		public InputCombinationActionBinding SetCombinationActionGamepadKeys(string actionName, Dictionary<string, string> keyNameMap, EInputBindingType bindingType)
		{
			InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName == null)
			{
				return null;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			combinationActionBindingByActionName.GetGamepadKeyNameMapByBindingType(dictionary, bindingType);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.RemoveCombinationActionKeyMap(actionName, key, value, bindingType);
			}
			if (keyNameMap.Count > 0)
			{
				using (Dictionary<string, string>.Enumerator enumerator = keyNameMap.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair2 = enumerator.Current;
						string key2 = keyValuePair2.Key;
						string value2 = keyValuePair2.Value;
						this.AddCombinationActionKeyMap(actionName, key2, value2, bindingType);
					}
					return combinationActionBindingByActionName;
				}
			}
			this.AddCombinationActionKeyMapEmptyData(actionName, bindingType);
			return combinationActionBindingByActionName;
		}

		// Token: 0x0603BDC2 RID: 245186 RVA: 0x01102544 File Offset: 0x01100744
		[return: Nullable(2)]
		public InputCombinationActionBinding SetOrAddCombinationActionGamepadKeys(string actionName, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> keyNameMap, EInputBindingType bindingType)
		{
			InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName != null)
			{
				IReadOnlyDictionary<string, string> gamepadKeyNameMapByBindingType = combinationActionBindingByActionName.GetGamepadKeyNameMapByBindingType(bindingType);
				if (gamepadKeyNameMapByBindingType != null)
				{
					foreach (KeyValuePair<string, string> keyValuePair in gamepadKeyNameMapByBindingType)
					{
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string mainKeyName = text;
						string secondaryKeyName = text2;
						this.RemoveCombinationActionKeyMap(actionName, mainKeyName, secondaryKeyName, bindingType);
					}
				}
			}
			if (keyNameMap != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in keyNameMap)
				{
					string text;
					string text2;
					keyValuePair.Deconstruct(out text2, out text);
					string mainKeyName2 = text2;
					string secondaryKeyName2 = text;
					this.AddCombinationActionKeyMap(actionName, mainKeyName2, secondaryKeyName2, bindingType);
				}
			}
			return combinationActionBindingByActionName;
		}

		// Token: 0x0603BDC3 RID: 245187 RVA: 0x01102610 File Offset: 0x01100810
		public void ConvertInputActionSort()
		{
			bool? flag = new bool?(LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.IsConvertInputActionSort, false));
			if (flag.GetValueOrDefault())
			{
				return;
			}
			if (this.ActionMapping == null)
			{
				return;
			}
			foreach (InputActionBinding inputActionBinding in ((IReadOnlyDictionary<string, InputActionBinding>)this.ActionMapping.GetActionBindingMap()).Values)
			{
				inputActionBinding.ConvertSort();
			}
			InputSettings.Instance.SaveKeyMappings();
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsConvertInputActionSort, true);
		}

		// Token: 0x0603BDC4 RID: 245188 RVA: 0x0110269C File Offset: 0x0110089C
		private void ConvertPhantomInput()
		{
			bool? flag = new bool?(LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.IsConvertInput, false));
			if (!flag.GetValueOrDefault())
			{
				this.ConvertPhantomInputInternal();
				LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsConvertInput, true);
			}
		}

		// Token: 0x0603BDC5 RID: 245189 RVA: 0x011026D0 File Offset: 0x011008D0
		private void TryFirstSaveKeyMappings()
		{
			bool? flag = new bool?(LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.IsSavedKeyMappings, false));
			if (flag.GetValueOrDefault())
			{
				return;
			}
			InputSettings.Instance.SaveKeyMappings();
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsSavedKeyMappings, true);
		}

		// Token: 0x0603BDC6 RID: 245190 RVA: 0x0110270C File Offset: 0x0110090C
		private void ConvertPhantomInputInternal()
		{
			InputActionBinding actionBinding = this.GetActionBinding("幻象2");
			if (actionBinding == null)
			{
				return;
			}
			if (actionBinding.HasKey(EKey.Gamepad_LeftTrigger))
			{
				InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName("幻象2");
				if (combinationActionBindingByActionName == null)
				{
					return;
				}
				if (combinationActionBindingByActionName.HasKey(EKey.Gamepad_LeftShoulder, EKey.Gamepad_FaceButton_Left, EInputBindingType.Original))
				{
					InputActionBinding inputActionBinding = actionBinding;
					string text = EKey.Gamepad_LeftTrigger;
					inputActionBinding.RemoveKeys(new Span<string>(ref text), EInputBindingType.Original);
					InputActionBinding actionBinding2 = this.GetActionBinding("瞄准");
					if (actionBinding2 != null && !actionBinding2.HasKey(EKey.Gamepad_LeftTrigger))
					{
						InputActionBinding inputActionBinding2 = actionBinding2;
						string text2 = EKey.Gamepad_LeftTrigger;
						inputActionBinding2.AddKeys(new Span<string>(ref text2), EInputBindingType.Original);
					}
					InputCombinationActionBinding combinationActionBindingByActionName2 = this.GetCombinationActionBindingByActionName("瞄准");
					if (combinationActionBindingByActionName2 != null)
					{
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						combinationActionBindingByActionName2.GetGamepadKeyNameMapByBindingType(dictionary, EInputBindingType.Original);
						string a;
						if (dictionary.TryGetValue(EKey.Gamepad_LeftShoulder, out a) && a == EKey.Gamepad_FaceButton_Left)
						{
							combinationActionBindingByActionName2.RemoveKey(EKey.Gamepad_LeftShoulder, EInputBindingType.Original);
						}
					}
				}
			}
		}

		// Token: 0x0603BDC7 RID: 245191 RVA: 0x01102822 File Offset: 0x01100A22
		public void ClearCombinationActionKeyMap()
		{
			InputCombinationActionMapping combinationActionMapping = this.CombinationActionMapping;
			if (combinationActionMapping != null)
			{
				combinationActionMapping.Clear();
			}
			this.CombinationActionKeyMap.Clear();
			InputSettings.Instance.ClearCombinationActionMappings();
			this.SetCombinationActionKeyMapDirty();
		}

		// Token: 0x0603BDC8 RID: 245192 RVA: 0x01102850 File Offset: 0x01100A50
		public unsafe void ReplaceCombinationActionDeviceKeyMap(string actionName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, EInputBindingType bindingType, IReadOnlyDictionary<string, string> keyMap)
		{
			InputCombinationActionBinding inputCombinationActionBinding = this.TryGetCombinationActionBinding(actionName);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "整体替换组合Action按键";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", actionName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InputControllerType", inputControllerType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", bindingType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("keyMap", keyMap);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				inputCombinationActionBinding.ReplaceGamepadKeyMap(bindingType, keyMap);
			}
			else
			{
				inputCombinationActionBinding.ReplaceKeyboardKeyMap(bindingType, keyMap);
			}
			this.SetCombinationActionKeyMapDirty();
		}

		// Token: 0x0603BDC9 RID: 245193 RVA: 0x01102914 File Offset: 0x01100B14
		public unsafe void ReplaceCombinationAxisDeviceKeyMap(string axisName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, EInputBindingType bindingType, IReadOnlyDictionary<string, string> keyMap)
		{
			InputCombinationAxisBinding combinationAxisBindingByAxisName = this.GetCombinationAxisBindingByAxisName(axisName);
			if (combinationAxisBindingByAxisName == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "整体替换组合Axis按键";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AxisName", axisName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InputControllerType", inputControllerType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", bindingType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("keyMap", keyMap);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				combinationAxisBindingByAxisName.ReplaceGamepadKeyMap(bindingType, keyMap);
				return;
			}
			combinationAxisBindingByAxisName.ReplaceKeyboardKeyMap(bindingType, keyMap);
		}

		// Token: 0x0603BDCA RID: 245194 RVA: 0x011029D4 File Offset: 0x01100BD4
		public unsafe void RebuildCurrentCombinationRuntimeMappings()
		{
			int num = this.RebuildCurrentCombinationActionRuntimeMappings();
			int num2 = this.RebuildCurrentCombinationAxisRuntimeMappings();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "组合键运行时按键映射重建完成";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BindingType", this.CurrentBindingType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CombinationActionKeyPairCount", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CombinationAxisKeyPairCount", num2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0603BDCB RID: 245195 RVA: 0x01102A70 File Offset: 0x01100C70
		private int RebuildCurrentCombinationActionRuntimeMappings()
		{
			InputSettings.Instance.ClearCombinationActionMappings();
			this.CombinationActionMapping.ClearKeyNameIndex();
			this.CombinationActionKeyMap.Clear();
			int num = 0;
			foreach (InputCombinationActionBinding inputCombinationActionBinding in this.CombinationActionMapping.GetCombinationActionBindingMap().Values)
			{
				string actionName = inputCombinationActionBinding.GetActionName();
				if (!string.IsNullOrEmpty(actionName))
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					inputCombinationActionBinding.GetKeyMapByBindingType(dictionary, this.CurrentBindingType);
					List<IList<string>> list = new List<IList<string>>();
					foreach (KeyValuePair<string, string> keyValuePair in dictionary)
					{
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string text3 = text;
						string text4 = text2;
						this.CombinationActionMapping.AddKeyNameIndex(inputCombinationActionBinding, text3, text4);
						InputSettings.Instance.NewInputCombinationActionKey(actionName, text3, text4);
						list.Add(new List<string>
						{
							text3,
							text4
						});
					}
					if (list.Count > 0)
					{
						this.CombinationActionKeyMap[actionName] = list;
					}
					num += list.Count;
				}
			}
			this.SetCombinationActionKeyMapDirty();
			return num;
		}

		// Token: 0x0603BDCC RID: 245196 RVA: 0x01102BC8 File Offset: 0x01100DC8
		private unsafe int RebuildCurrentCombinationAxisRuntimeMappings()
		{
			InputSettings.Instance.ClearCombinationAxisMappings();
			this.CombinationAxisMapping.ClearKeyNameIndex();
			int num = 0;
			foreach (InputCombinationAxisBinding inputCombinationAxisBinding in this.CombinationAxisMapping.GetCombinationAxisBindingMap().Values)
			{
				string axisName = inputCombinationAxisBinding.GetAxisName();
				if (!string.IsNullOrEmpty(axisName))
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					inputCombinationAxisBinding.GetKeyMap(dictionary, this.CurrentBindingType);
					foreach (KeyValuePair<string, string> keyValuePair in dictionary)
					{
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string text3 = text;
						string mainKeyName = text2;
						float scale;
						if (!inputCombinationAxisBinding.TryGetSourceAxisValueByBindingType(text3, this.CurrentBindingType, out scale))
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.InputSettings;
							ELogAuthor author = ELogAuthor.TZJ;
							string message = "重建组合Axis运行时映射时，副键找不到有效的轴输入值";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AxisName", axisName);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("secondaryKeyName", text3);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", this.CurrentBindingType);
							instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
						else
						{
							this.CombinationAxisMapping.AddKeyNameIndex(inputCombinationAxisBinding, text3, mainKeyName);
							InputSettings.Instance.NewInputCombinationAxisKey(axisName, mainKeyName, text3, scale);
							num++;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0603BDCD RID: 245197 RVA: 0x01102D80 File Offset: 0x01100F80
		[return: Nullable(2)]
		public InputCombinationActionBinding AddCombinationActionKeyMap(string actionName, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			InputCombinationActionBinding result = this.AddCombinationActionKeyMapInternal(actionName, mainKeyName, secondaryKeyName, bindingType);
			IList<IList<string>> list;
			if (this.CombinationActionKeyMap.TryGetValue(actionName, out list) && list != null)
			{
				string[] item = new string[]
				{
					mainKeyName,
					secondaryKeyName
				};
				bool flag = false;
				foreach (IList<string> list2 in list)
				{
					if (list2[0] == mainKeyName && list2[1] == secondaryKeyName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(item);
				}
			}
			else
			{
				string[] item2 = new string[]
				{
					mainKeyName,
					secondaryKeyName
				};
				this.CombinationActionKeyMap[actionName] = new List<IList<string>>
				{
					item2
				};
			}
			this.SetCombinationActionKeyMapDirty();
			return result;
		}

		// Token: 0x0603BDCE RID: 245198 RVA: 0x01102E58 File Offset: 0x01101058
		public unsafe void AddCombinationActionKeyMapEmptyData(string actionName, EInputBindingType bindingType)
		{
			InputCombinationActionBinding inputCombinationActionBinding = this.TryGetCombinationActionBinding(actionName);
			if (inputCombinationActionBinding == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加组合键按键空数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", actionName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bindingType", bindingType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			inputCombinationActionBinding.AddKeyEmptyData(bindingType);
			this.SetCombinationActionKeyMapDirty();
		}

		// Token: 0x0603BDCF RID: 245199 RVA: 0x01102ED8 File Offset: 0x011010D8
		[return: Nullable(2)]
		private unsafe InputCombinationActionBinding ReplaceCombinationActionKeyMapInternal(string actionName, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			InputCombinationActionBinding inputCombinationActionBinding = this.TryGetCombinationActionBinding(actionName);
			if (inputCombinationActionBinding == null)
			{
				return null;
			}
			string secondaryKeyNameByMainKey = inputCombinationActionBinding.GetSecondaryKeyNameByMainKey(mainKeyName, bindingType);
			if (!string.IsNullOrEmpty(secondaryKeyNameByMainKey) && secondaryKeyNameByMainKey != secondaryKeyName)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "组合键主键已存在,更换旧的组合键数据";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", inputCombinationActionBinding.GetActionName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mainKeyName", mainKeyName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("secondaryKeyName", secondaryKeyNameByMainKey);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.RemoveCombinationActionKeyMap(actionName, mainKeyName, secondaryKeyNameByMainKey, bindingType);
			}
			return this.AddCombinationActionKeyMapInternal(actionName, mainKeyName, secondaryKeyName, bindingType);
		}

		// Token: 0x0603BDD0 RID: 245200 RVA: 0x01102F98 File Offset: 0x01101198
		[return: Nullable(2)]
		private unsafe InputCombinationActionBinding AddCombinationActionKeyMapInternal(string actionName, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			InputCombinationActionBinding inputCombinationActionBinding = this.TryGetCombinationActionBinding(actionName);
			if (inputCombinationActionBinding == null)
			{
				return null;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加组合键按键";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", inputCombinationActionBinding.GetActionName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mainKeyName", mainKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("secondaryKeyName", secondaryKeyName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			InputCombinationActionMapping combinationActionMapping = this.CombinationActionMapping;
			if (combinationActionMapping != null)
			{
				combinationActionMapping.AddKey(inputCombinationActionBinding, mainKeyName, secondaryKeyName, bindingType);
			}
			InputSettings.Instance.NewInputCombinationActionKey(inputCombinationActionBinding.GetActionName(), mainKeyName, secondaryKeyName);
			return inputCombinationActionBinding;
		}

		// Token: 0x0603BDD1 RID: 245201 RVA: 0x0110304C File Offset: 0x0110124C
		public InputCombinationActionBinding TryGetCombinationActionBinding(string actionName)
		{
			InputCombinationActionBinding inputCombinationActionBinding = this.GetCombinationActionBindingByActionName(actionName);
			if (inputCombinationActionBinding == null)
			{
				bool flag = this.OriginalCombinationActionNameSet.Contains(actionName);
				bool flag2 = this.OriginalActionNameSet.Contains(actionName);
				inputCombinationActionBinding = this.CombinationActionMapping.NewCombinationActionBinding(actionName, 0, flag || !flag2);
				inputCombinationActionBinding.InitializeBindingType(this.CurrentBindingType);
			}
			return inputCombinationActionBinding;
		}

		// Token: 0x0603BDD2 RID: 245202 RVA: 0x011030A4 File Offset: 0x011012A4
		public void RemoveCombinationActionKeyMap(string actionName, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			this.RemoveCombinationActionKeyInternal(actionName, mainKeyName, secondaryKeyName, bindingType);
			IList<IList<string>> list;
			if (this.CombinationActionKeyMap.TryGetValue(actionName, out list) && list != null)
			{
				List<int> list2 = new List<int>();
				for (int i = 0; i < list.Count; i++)
				{
					IList<string> list3 = list[i];
					if (list3[0] == mainKeyName && list3[1] == secondaryKeyName)
					{
						list2.Add(i);
					}
				}
				for (int j = list2.Count - 1; j >= 0; j--)
				{
					int index = list2[j];
					list.RemoveAt(index);
				}
				if (list.Count <= 0)
				{
					this.CombinationActionKeyMap.Remove(actionName);
				}
			}
			else
			{
				this.CombinationActionKeyMap.Remove(actionName);
			}
			this.SetCombinationActionKeyMapDirty();
		}

		// Token: 0x0603BDD3 RID: 245203 RVA: 0x01103170 File Offset: 0x01101370
		private unsafe void RemoveCombinationActionKeyInternal(string actionName, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "删除组合键按键";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", combinationActionBindingByActionName.GetActionName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RemoveMainKey", mainKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RemoveSecondaryKeyName", secondaryKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("bindingType", bindingType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			InputCombinationActionMapping combinationActionMapping = this.CombinationActionMapping;
			if (combinationActionMapping != null)
			{
				combinationActionMapping.RemoveKey(combinationActionBindingByActionName, mainKeyName, secondaryKeyName, bindingType);
			}
			InputSettings.Instance.RemoveCombinationActionMapping(combinationActionBindingByActionName.GetActionName(), mainKeyName, secondaryKeyName);
		}

		// Token: 0x0603BDD4 RID: 245204 RVA: 0x0110323F File Offset: 0x0110143F
		[return: Nullable(2)]
		public InputCombinationAxisBinding AddCombinationAxisKeyMap(string axisName, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			return this.AddCombinationAxisKeyMapInternal(axisName, secondaryKeyName, mainKeyName, bindingType);
		}

		// Token: 0x0603BDD5 RID: 245205 RVA: 0x0110324C File Offset: 0x0110144C
		[return: Nullable(2)]
		private unsafe InputCombinationAxisBinding AddCombinationAxisKeyMapInternal(string axisName, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			InputCombinationAxisBinding combinationAxisBindingByAxisName = this.GetCombinationAxisBindingByAxisName(axisName);
			if (combinationAxisBindingByAxisName == null)
			{
				return null;
			}
			float scale;
			if (!combinationAxisBindingByAxisName.TryGetSourceAxisValueByBindingType(secondaryKeyName, bindingType, out scale))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "添加组合Axis按键时，副键找不到有效的轴输入值";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AxisName", axisName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("secondaryKeyName", secondaryKeyName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bindingType", bindingType);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.InputSettings;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "添加组合键按键";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("AxisName", axisName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("mainKeyName", mainKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("secondaryKeyName", secondaryKeyName);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			InputCombinationAxisMapping combinationAxisMapping = this.CombinationAxisMapping;
			if (combinationAxisMapping != null)
			{
				combinationAxisMapping.AddKeyMap(combinationAxisBindingByAxisName, secondaryKeyName, mainKeyName, bindingType);
			}
			InputSettings.Instance.NewInputCombinationAxisKey(axisName, mainKeyName, secondaryKeyName, scale);
			return combinationAxisBindingByAxisName;
		}

		// Token: 0x0603BDD6 RID: 245206 RVA: 0x01103376 File Offset: 0x01101576
		public void RemoveCombinationAxisKeyMap(string axisName, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			this.RemoveCombinationAxisKeyInternal(axisName, secondaryKeyName, mainKeyName, bindingType);
		}

		// Token: 0x0603BDD7 RID: 245207 RVA: 0x01103384 File Offset: 0x01101584
		private unsafe void RemoveCombinationAxisKeyInternal(string axisName, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			InputCombinationAxisBinding combinationAxisBindingByAxisName = this.GetCombinationAxisBindingByAxisName(axisName);
			if (combinationAxisBindingByAxisName == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "删除组合键按键";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AxisName", axisName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RemoveMainKey", mainKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RemoveSecondaryKeyName", secondaryKeyName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			InputCombinationAxisMapping combinationAxisMapping = this.CombinationAxisMapping;
			if (combinationAxisMapping != null)
			{
				combinationAxisMapping.RemoveKeyMap(combinationAxisBindingByAxisName, secondaryKeyName, mainKeyName, bindingType);
			}
			InputSettings.Instance.RemoveCombinationAxisMapping(axisName, mainKeyName, secondaryKeyName);
		}

		// Token: 0x0603BDD8 RID: 245208 RVA: 0x0110342C File Offset: 0x0110162C
		private void InitKeySettingActionKey(InputActionBinding actionBinding, KeySetting config)
		{
			string actionName = actionBinding.GetActionName();
			ActionMapping? actionMappingConfigByActionName = InputSettingsConfig.Instance.GetActionMappingConfigByActionName(actionName);
			if (actionMappingConfigByActionName == null)
			{
				return;
			}
			EInputBindingType bindTypeByExclusiveType = this.GetBindTypeByExclusiveType((EKeySettingExclusiveType)config.ExclusiveType);
			CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)config.InputControllerType;
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				string[] actionPcKeys = LanguageKeyTransUtils.GetKeyTrans(this.CurrentDeviceLang).GetActionPcKeys(actionMappingConfigByActionName.Value);
				if (bindTypeByExclusiveType == EInputBindingType.Original)
				{
					actionBinding.SetKeyboardKeysWithoutOriginal(actionPcKeys);
				}
				else
				{
					actionBinding.SetKeyboardKeys(actionPcKeys, bindTypeByExclusiveType);
				}
			}
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < actionMappingConfigByActionName.Value.GamepadKeysLength; i++)
				{
					string text = actionMappingConfigByActionName.Value.GamepadKeys(i);
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
				if (list.Count > 0)
				{
					if (bindTypeByExclusiveType == EInputBindingType.Original)
					{
						actionBinding.SetGamepadKeysWithoutOriginal(list);
						return;
					}
					actionBinding.SetGamepadKeys(list, bindTypeByExclusiveType);
				}
			}
		}

		// Token: 0x0603BDD9 RID: 245209 RVA: 0x01103514 File Offset: 0x01101714
		private void InitKeySettingAxisKey(InputAxisBinding axisBinding, KeySetting config)
		{
			string axisName = axisBinding.GetAxisName();
			AxisMapping? axisMappingConfigByAxisName = InputSettingsConfig.Instance.GetAxisMappingConfigByAxisName(axisName);
			if (axisMappingConfigByAxisName == null)
			{
				return;
			}
			EInputBindingType bindTypeByExclusiveType = this.GetBindTypeByExclusiveType((EKeySettingExclusiveType)config.ExclusiveType);
			CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)config.InputControllerType;
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				Dictionary<string, float> axisPcKeys = LanguageKeyTransUtils.GetKeyTrans(this.CurrentDeviceLang).GetAxisPcKeys(axisMappingConfigByAxisName.Value);
				if (bindTypeByExclusiveType == EInputBindingType.Original)
				{
					axisBinding.SetKeyboardKeysWithoutOriginal(axisPcKeys);
				}
				else
				{
					axisBinding.SetKeyboardKeys(axisPcKeys, bindTypeByExclusiveType);
				}
			}
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				Dictionary<string, float> dictionary = axisMappingConfigByAxisName.Value.GamepadKeys();
				if (dictionary != null)
				{
					if (bindTypeByExclusiveType == EInputBindingType.Original)
					{
						axisBinding.SetGamepadKeysWithoutOriginal(dictionary);
						return;
					}
					axisBinding.SetGamepadKeys(dictionary, bindTypeByExclusiveType);
				}
			}
		}

		// Token: 0x0603BDDA RID: 245210 RVA: 0x011035BC File Offset: 0x011017BC
		private void InitCombinationActionKeysWithBindingType(InputCombinationActionBinding combinationActionBinding, EInputBindingType bindingType, Dictionary<string, string> keyNameMap, bool isGamepad)
		{
			if (isGamepad)
			{
				combinationActionBinding.ReplaceGamepadKeyMap(bindingType, keyNameMap);
			}
			else
			{
				combinationActionBinding.ReplaceKeyboardKeyMap(bindingType, keyNameMap);
			}
			this.SetCombinationActionKeyMapDirty();
		}

		// Token: 0x0603BDDB RID: 245211 RVA: 0x011035DC File Offset: 0x011017DC
		private void InitKeySettingCombinationActionKey(InputCombinationActionBinding combinationActionBinding, KeySetting config)
		{
			string actionName = combinationActionBinding.GetActionName();
			CombinationAction? combinationActionConfigByActionName = InputSettingsConfig.Instance.GetCombinationActionConfigByActionName(actionName);
			if (combinationActionConfigByActionName == null)
			{
				return;
			}
			EInputBindingType bindTypeByExclusiveType = this.GetBindTypeByExclusiveType((EKeySettingExclusiveType)config.ExclusiveType);
			CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)config.InputControllerType;
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				Dictionary<string, string> combinationActionPcKeys = LanguageKeyTransUtils.GetKeyTrans(this.CurrentDeviceLang).GetCombinationActionPcKeys(combinationActionConfigByActionName.Value);
				if (bindTypeByExclusiveType == EInputBindingType.Original)
				{
					foreach (EInputBindingType einputBindingType in InputBindingDefine.inputBindingTypesArray)
					{
						if (einputBindingType != EInputBindingType.Original)
						{
							this.InitCombinationActionKeysWithBindingType(combinationActionBinding, einputBindingType, combinationActionPcKeys, false);
						}
					}
				}
				else
				{
					this.InitCombinationActionKeysWithBindingType(combinationActionBinding, bindTypeByExclusiveType, combinationActionPcKeys, false);
				}
			}
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				CombinationAction? combinationActionConfigByActionName2 = InputSettingsConfig.Instance.GetCombinationActionConfigByActionName(actionName);
				if (combinationActionConfigByActionName2 != null)
				{
					Dictionary<string, string> dictionary = combinationActionConfigByActionName2.Value.GamepadKeys();
					if (dictionary != null)
					{
						if (bindTypeByExclusiveType == EInputBindingType.Original)
						{
							foreach (EInputBindingType einputBindingType2 in InputBindingDefine.inputBindingTypesArray)
							{
								if (einputBindingType2 != EInputBindingType.Original)
								{
									this.InitCombinationActionKeysWithBindingType(combinationActionBinding, einputBindingType2, dictionary, true);
								}
							}
							return;
						}
						this.InitCombinationActionKeysWithBindingType(combinationActionBinding, bindTypeByExclusiveType, dictionary, true);
					}
				}
			}
		}

		// Token: 0x0603BDDC RID: 245212 RVA: 0x011036F0 File Offset: 0x011018F0
		private void InitCombinationAxisKeysWithBindingType(InputCombinationAxisBinding combinationAxisBinding, EInputBindingType bindingType, Dictionary<string, string> keyNameMap, bool isGamepad)
		{
			if (isGamepad)
			{
				combinationAxisBinding.ReplaceGamepadKeyMap(bindingType, keyNameMap);
				return;
			}
			combinationAxisBinding.ReplaceKeyboardKeyMap(bindingType, keyNameMap);
		}

		// Token: 0x0603BDDD RID: 245213 RVA: 0x01103708 File Offset: 0x01101908
		private void InitKeySettingCombinationAxisKey(InputCombinationAxisBinding combinationAxisBinding, KeySetting config)
		{
			string axisName = combinationAxisBinding.GetAxisName();
			CombinationAxis? combinationAxisConfigByAxisName = InputSettingsConfig.Instance.GetCombinationAxisConfigByAxisName(axisName);
			if (combinationAxisConfigByAxisName == null)
			{
				return;
			}
			EInputBindingType bindTypeByExclusiveType = this.GetBindTypeByExclusiveType((EKeySettingExclusiveType)config.ExclusiveType);
			CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = (CSharpScript.Game.Module.Menu.EInputControllerType)config.InputControllerType;
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				Dictionary<string, string> dictionary = combinationAxisConfigByAxisName.Value.PcKeyMap();
				if (dictionary != null)
				{
					if (bindTypeByExclusiveType == EInputBindingType.Original)
					{
						foreach (EInputBindingType einputBindingType in InputBindingDefine.inputBindingTypesArray)
						{
							if (einputBindingType != EInputBindingType.Original)
							{
								this.InitCombinationAxisKeysWithBindingType(combinationAxisBinding, einputBindingType, dictionary, false);
							}
						}
					}
					else
					{
						this.InitCombinationAxisKeysWithBindingType(combinationAxisBinding, bindTypeByExclusiveType, dictionary, false);
					}
				}
			}
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad || inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.None)
			{
				CombinationAxis? combinationAxisConfigByAxisName2 = InputSettingsConfig.Instance.GetCombinationAxisConfigByAxisName(axisName);
				if (combinationAxisConfigByAxisName2 != null)
				{
					Dictionary<string, string> dictionary2 = combinationAxisConfigByAxisName2.Value.GamepadKeyMap();
					if (dictionary2 != null)
					{
						if (bindTypeByExclusiveType == EInputBindingType.Original)
						{
							foreach (EInputBindingType einputBindingType2 in InputBindingDefine.inputBindingTypesArray)
							{
								if (einputBindingType2 != EInputBindingType.Original)
								{
									this.InitCombinationAxisKeysWithBindingType(combinationAxisBinding, einputBindingType2, dictionary2, true);
								}
							}
							return;
						}
						this.InitCombinationAxisKeysWithBindingType(combinationAxisBinding, bindTypeByExclusiveType, dictionary2, true);
					}
				}
			}
		}

		// Token: 0x0603BDDE RID: 245214 RVA: 0x0110381C File Offset: 0x01101A1C
		private void AddActionNameToInputControllerMap(Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>> inputControllerMap, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, string actionName)
		{
			HashSet<string> hashSet;
			inputControllerMap.TryGetValue(inputControllerType, out hashSet);
			if (hashSet == null)
			{
				hashSet = new HashSet<string>();
				inputControllerMap.Add(inputControllerType, hashSet);
			}
			hashSet.Add(actionName);
		}

		// Token: 0x0603BDDF RID: 245215 RVA: 0x0110384C File Offset: 0x01101A4C
		private void AddInSettingActionName(KeySetting inSettingConfig)
		{
			Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>> dictionary;
			this.InSettingActionNameMap.TryGetValue((EKeySettingExclusiveType)inSettingConfig.ExclusiveType, out dictionary);
			if (dictionary == null)
			{
				dictionary = new Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>>();
				this.InSettingActionNameMap.Add((EKeySettingExclusiveType)inSettingConfig.ExclusiveType, dictionary);
			}
			if (inSettingConfig.InputControllerType != 0)
			{
				this.AddActionNameToInputControllerMap(dictionary, (CSharpScript.Game.Module.Menu.EInputControllerType)inSettingConfig.InputControllerType, inSettingConfig.ActionOrAxisName);
				return;
			}
			this.AddActionNameToInputControllerMap(dictionary, CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard, inSettingConfig.ActionOrAxisName);
			this.AddActionNameToInputControllerMap(dictionary, CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad, inSettingConfig.ActionOrAxisName);
		}

		// Token: 0x0603BDE0 RID: 245216 RVA: 0x011038C8 File Offset: 0x01101AC8
		private void InitKeySettingKeys()
		{
			this.InSettingActionNameMap.Clear();
			IReadOnlyList<KeySetting> configList = ConfigKeySettingAll.GetConfigList(true);
			if (configList != null)
			{
				foreach (KeySetting keySetting in configList)
				{
					string actionOrAxisName = keySetting.ActionOrAxisName;
					if (!StringUtils.IsBlank(actionOrAxisName))
					{
						if (keySetting.ActionOrAxis == 1)
						{
							InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionOrAxisName);
							if (combinationActionBindingByActionName != null)
							{
								this.InitKeySettingCombinationActionKey(combinationActionBindingByActionName, keySetting);
							}
							InputActionBinding actionBinding = this.GetActionBinding(actionOrAxisName);
							if (actionBinding != null)
							{
								this.InitKeySettingActionKey(actionBinding, keySetting);
							}
							this.AddInSettingActionName(keySetting);
						}
						else
						{
							InputCombinationAxisBinding combinationAxisBindingByAxisName = this.GetCombinationAxisBindingByAxisName(actionOrAxisName);
							if (combinationAxisBindingByAxisName != null)
							{
								this.InitKeySettingCombinationAxisKey(combinationAxisBindingByAxisName, keySetting);
							}
							InputAxisBinding axisBinding = this.GetAxisBinding(actionOrAxisName);
							if (axisBinding != null)
							{
								this.InitKeySettingAxisKey(axisBinding, keySetting);
							}
						}
					}
				}
			}
		}

		// Token: 0x0603BDE1 RID: 245217 RVA: 0x011039A4 File Offset: 0x01101BA4
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public IReadOnlyDictionary<string, InputCombinationActionBinding> GetCombinationActionBindingByKeyName(string mainKeyName, string secondaryKeyName)
		{
			return this.CombinationActionMapping.GetCombinationActionBindingByKeyName(mainKeyName, secondaryKeyName);
		}

		// Token: 0x0603BDE2 RID: 245218 RVA: 0x011039B3 File Offset: 0x01101BB3
		[return: Nullable(2)]
		public InputCombinationActionBinding GetCombinationActionBindingByActionName(string actionName)
		{
			return this.CombinationActionMapping.GetCombinationActionBindingByActionName(actionName);
		}

		// Token: 0x0603BDE3 RID: 245219 RVA: 0x011039C1 File Offset: 0x01101BC1
		public IReadOnlyDictionary<string, InputCombinationActionBinding> GetCombinationActionBindingMap()
		{
			return this.CombinationActionMapping.GetCombinationActionBindingMap();
		}

		// Token: 0x0603BDE4 RID: 245220 RVA: 0x011039CE File Offset: 0x01101BCE
		public bool IsCombinationActionMainKey(string keyName)
		{
			return this.CombinationActionMapping.IsMainKey(keyName);
		}

		// Token: 0x0603BDE5 RID: 245221 RVA: 0x011039DC File Offset: 0x01101BDC
		public bool IsCombinationAction(string mainKeyName, string secondaryKeyName)
		{
			IReadOnlyDictionary<string, InputCombinationActionBinding> combinationActionBindingByKeyName = this.GetCombinationActionBindingByKeyName(mainKeyName, secondaryKeyName);
			InputModel instance = InputModel.Instance;
			BattleInputData battleInputData = (instance != null) ? instance.GetCurrentInputData() : null;
			EInputBindingType bindingType = (battleInputData != null) ? battleInputData.KeyBindingType : EInputBindingType.Original;
			if (combinationActionBindingByKeyName == null || combinationActionBindingByKeyName.Count <= 0)
			{
				return false;
			}
			using (IEnumerator<InputCombinationActionBinding> enumerator = combinationActionBindingByKeyName.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasKey(mainKeyName, secondaryKeyName, bindingType))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603BDE6 RID: 245222 RVA: 0x01103A6C File Offset: 0x01101C6C
		public void RefreshCombinationAxisKeys()
		{
			this.ClearCombinationAxisKeyMap();
			IReadOnlyList<CombinationAxis> allCombinationAxisConfig = InputSettingsConfig.Instance.GetAllCombinationAxisConfig();
			if (allCombinationAxisConfig == null)
			{
				return;
			}
			foreach (CombinationAxis config in allCombinationAxisConfig)
			{
				InputCombinationAxisMapping combinationAxisMapping = this.CombinationAxisMapping;
				if (combinationAxisMapping != null)
				{
					combinationAxisMapping.NewCombinationAxisBinding(config);
				}
			}
		}

		// Token: 0x0603BDE7 RID: 245223 RVA: 0x01103AD4 File Offset: 0x01101CD4
		private void ClearCombinationAxisKeyMap()
		{
			InputCombinationAxisMapping combinationAxisMapping = this.CombinationAxisMapping;
			if (combinationAxisMapping != null)
			{
				combinationAxisMapping.Clear();
			}
			InputSettings.Instance.ClearCombinationAxisMappings();
		}

		// Token: 0x0603BDE8 RID: 245224 RVA: 0x01103AF1 File Offset: 0x01101CF1
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<InputCombinationAxisBinding> GetCombinationAxisBindingByKeyName(string mainKeyName, string secondaryKeyName)
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingByKeyName(mainKeyName, secondaryKeyName);
		}

		// Token: 0x0603BDE9 RID: 245225 RVA: 0x01103B00 File Offset: 0x01101D00
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IReadOnlyDictionary<string, List<InputCombinationAxisBinding>> GetCombinationAxisBindingMapByMainKeyName(string mainKeyName)
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingMapByMainKeyName(mainKeyName);
		}

		// Token: 0x0603BDEA RID: 245226 RVA: 0x01103B0E File Offset: 0x01101D0E
		[return: Nullable(2)]
		public InputCombinationAxisBinding GetCombinationAxisBindingByAxisName(string axisName)
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingByAxisName(axisName);
		}

		// Token: 0x0603BDEB RID: 245227 RVA: 0x01103B1C File Offset: 0x01101D1C
		public IReadOnlyDictionary<string, InputCombinationAxisBinding> GetCombinationAxisBindingMap()
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingMap();
		}

		// Token: 0x0603BDEC RID: 245228 RVA: 0x01103B29 File Offset: 0x01101D29
		public bool IsCombinationAxisMainKey(string keyName)
		{
			return this.CombinationAxisMapping.IsMainKey(keyName);
		}

		// Token: 0x0603BDED RID: 245229 RVA: 0x01103B38 File Offset: 0x01101D38
		public bool IsCombinationAxis(string mainKeyName, string secondaryKeyName)
		{
			IReadOnlyList<InputCombinationAxisBinding> combinationAxisBindingByKeyName = this.GetCombinationAxisBindingByKeyName(mainKeyName, secondaryKeyName);
			return combinationAxisBindingByKeyName != null && combinationAxisBindingByKeyName.Count > 0;
		}

		// Token: 0x0603BDEE RID: 245230 RVA: 0x01103B60 File Offset: 0x01101D60
		public bool GetActionKeyDisplayData(InputKeyDisplayData actionKeyDisplayDataRef, string actionName)
		{
			List<string> currentPlatformCustomActionKeyNameList = (Global.PlayerController as TsBasePlayerController).GetCurrentPlatformCustomActionKeyNameList(actionName);
			if (currentPlatformCustomActionKeyNameList != null)
			{
				actionKeyDisplayDataRef.RefreshInput(actionName, currentPlatformCustomActionKeyNameList);
				return true;
			}
			InputCombinationActionBinding combinationActionBindingByActionName = this.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName != null)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				combinationActionBindingByActionName.GetCurrentPlatformKeyNameMap(dictionary);
				if (dictionary.Count > 0)
				{
					actionKeyDisplayDataRef.RefreshCombinationInput(actionName, dictionary);
					return true;
				}
			}
			InputActionBinding actionBinding = this.GetActionBinding(actionName);
			if (actionBinding != null)
			{
				IReadOnlyList<string> currentPlatformKeyNameList = actionBinding.GetCurrentPlatformKeyNameList();
				if (currentPlatformKeyNameList.Count > 0)
				{
					actionKeyDisplayDataRef.RefreshInput(actionName, currentPlatformKeyNameList);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603BDEF RID: 245231 RVA: 0x01103BE0 File Offset: 0x01101DE0
		public bool GetAxisKeyDisplayData(InputKeyDisplayData axisKeyDisplayDataRef, string axisName)
		{
			InputCombinationAxisBinding combinationAxisBindingByAxisName = this.GetCombinationAxisBindingByAxisName(axisName);
			if (combinationAxisBindingByAxisName != null)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				combinationAxisBindingByAxisName.GetCurrentPlatformKeyNameMap(dictionary);
				if (dictionary != null && dictionary.Count > 0)
				{
					axisKeyDisplayDataRef.RefreshCombinationInput(axisName, dictionary);
					return true;
				}
			}
			InputAxisBinding axisBinding = this.GetAxisBinding(axisName);
			if (axisBinding != null)
			{
				IReadOnlyList<string> currentPlatformKeyNameList = axisBinding.GetCurrentPlatformKeyNameList();
				if (currentPlatformKeyNameList.Count > 0)
				{
					axisKeyDisplayDataRef.RefreshInput(axisName, currentPlatformKeyNameList);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603BDF0 RID: 245232 RVA: 0x01103C44 File Offset: 0x01101E44
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			this.CurrentBindingType = bindingType;
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.AddChangeKeyReason(EGamepadChangeKeyReason.SwitchBattleInputData);
			}
			this.CombinationActionMapping.SwitchKeysByBindingType(bindingType);
			this.CombinationAxisMapping.SwitchKeysByBindingType(bindingType);
			this.ActionMapping.SwitchKeysByBindingType(bindingType);
			this.AxisMapping.SwitchKeysByBindingType(bindingType);
			this.RebuildCurrentCombinationRuntimeMappings();
			SkillButtonUiGamepadDataBase gamepadData2 = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData2 == null)
			{
				return;
			}
			gamepadData2.RemoveChangeKeyReason(EGamepadChangeKeyReason.SwitchBattleInputData);
		}

		// Token: 0x0603BDF1 RID: 245233 RVA: 0x01103CBC File Offset: 0x01101EBC
		public bool IsOriginalCombinationActionName(string actionName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			HashSet<string> hashSet;
			return this.OriginalCombinationActionNameMap.TryGetValue(inputControllerType, out hashSet) && hashSet.Contains(actionName);
		}

		// Token: 0x0603BDF2 RID: 245234 RVA: 0x01103CE4 File Offset: 0x01101EE4
		public bool IsNotInSettingsCombinationAction(string actionName, EKeySettingExclusiveType exclusiveType, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			if (!this.IsOriginalCombinationActionName(actionName, inputControllerType))
			{
				return false;
			}
			Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>> dictionary;
			this.InSettingActionNameMap.TryGetValue(exclusiveType, out dictionary);
			if (dictionary == null)
			{
				return true;
			}
			HashSet<string> hashSet;
			dictionary.TryGetValue(inputControllerType, out hashSet);
			return hashSet == null || !hashSet.Contains(actionName);
		}

		// Token: 0x0603BDF3 RID: 245235 RVA: 0x01103D2A File Offset: 0x01101F2A
		private void SetCombinationActionKeyMapDirty()
		{
			this.CombinationActionKeyMapDirty = new bool?(true);
			this.StartCheckCombinationActionKeyMapSave();
		}

		// Token: 0x0603BDF4 RID: 245236 RVA: 0x01103D3E File Offset: 0x01101F3E
		private void StartCheckCombinationActionKeyMapSave()
		{
			if (this.IsCheckingCombinationActionKeyMapSave())
			{
				return;
			}
			this.CheckCombinationActionKeyMapSaveTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				if (this.SaveCombinationActionKeyMapIfDirty())
				{
					this.StopCheckCombinationActionKeyMapSave();
				}
			}, 10000f, null, null, true, 1f);
		}

		// Token: 0x0603BDF5 RID: 245237 RVA: 0x01103D72 File Offset: 0x01101F72
		private void StopCheckCombinationActionKeyMapSave()
		{
			if (this.CheckCombinationActionKeyMapSaveTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckCombinationActionKeyMapSaveTimerId);
				this.CheckCombinationActionKeyMapSaveTimerId = null;
			}
		}

		// Token: 0x0603BDF6 RID: 245238 RVA: 0x01103D94 File Offset: 0x01101F94
		private bool IsCheckingCombinationActionKeyMapSave()
		{
			return this.CheckCombinationActionKeyMapSaveTimerId != null;
		}

		// Token: 0x0603BDF7 RID: 245239 RVA: 0x01103D9F File Offset: 0x01101F9F
		private bool SaveCombinationActionKeyMapIfDirty()
		{
			if (this.CombinationActionKeyMapDirty.GetValueOrDefault())
			{
				LocalStorage.SetGlobal<Dictionary<string, IList<IList<string>>>>(ELocalStorageGlobalKey.CombineAction, this.CombinationActionKeyMap);
				this.CombinationActionKeyMapDirty = new bool?(false);
				return true;
			}
			return false;
		}

		// Token: 0x0603BDF8 RID: 245240 RVA: 0x01103DCC File Offset: 0x01101FCC
		private static void MarkAppliedKeyboardOverride(Dictionary<string, HashSet<EInputBindingType>> overrideMap, string name, EInputBindingType bindingType)
		{
			HashSet<EInputBindingType> hashSet;
			if (!overrideMap.TryGetValue(name, out hashSet))
			{
				hashSet = new HashSet<EInputBindingType>();
				overrideMap[name] = hashSet;
			}
			hashSet.Add(bindingType);
		}

		// Token: 0x0603BDF9 RID: 245241 RVA: 0x01103DFA File Offset: 0x01101FFA
		public void MarkAppliedKeyboardActionOverride(string actionName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardActionOverrides, actionName, bindingType);
		}

		// Token: 0x0603BDFA RID: 245242 RVA: 0x01103E09 File Offset: 0x01102009
		public void MarkAppliedKeyboardAxisOverride(string axisName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardAxisOverrides, axisName, bindingType);
		}

		// Token: 0x0603BDFB RID: 245243 RVA: 0x01103E18 File Offset: 0x01102018
		public void MarkAppliedKeyboardCombinationActionOverride(string actionName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardCombinationActionOverrides, actionName, bindingType);
		}

		// Token: 0x0603BDFC RID: 245244 RVA: 0x01103E27 File Offset: 0x01102027
		public void MarkAppliedKeyboardCombinationAxisOverride(string axisName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardCombinationAxisOverrides, axisName, bindingType);
		}

		// Token: 0x0603BDFD RID: 245245 RVA: 0x01103E36 File Offset: 0x01102036
		public void ClearAppliedServerOverrides()
		{
			this.AppliedKeyboardActionOverrides.Clear();
			this.AppliedKeyboardAxisOverrides.Clear();
			this.AppliedKeyboardCombinationActionOverrides.Clear();
			this.AppliedKeyboardCombinationAxisOverrides.Clear();
		}

		// Token: 0x170070DA RID: 28890
		// (get) Token: 0x0603BDFE RID: 245246 RVA: 0x01103E64 File Offset: 0x01102064
		public static InputSettingsManager Instance
		{
			get
			{
				if (InputSettingsManager._instance == null)
				{
					InputSettingsManager._instance = new InputSettingsManager();
					InputSettingsManager._instance.OnInit();
				}
				return InputSettingsManager._instance;
			}
		}

		// Token: 0x0603BDFF RID: 245247 RVA: 0x01103E87 File Offset: 0x01102087
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BE00 RID: 245248 RVA: 0x01103E89 File Offset: 0x01102089
		public static void ResetStaticDefaultValue()
		{
			InputSettingsManager instance = InputSettingsManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputSettingsManager._instance = null;
		}

		// Token: 0x0603BE01 RID: 245249 RVA: 0x01103EA2 File Offset: 0x011020A2
		static InputSettingsManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettingsManager.CreateStaticDefaultValue), new Action(InputSettingsManager.ResetStaticDefaultValue));
		}

		// Token: 0x0603BE02 RID: 245250 RVA: 0x01103EC4 File Offset: 0x011020C4
		public InputSettingsManager()
		{
			Dictionary<EKeySettingExclusiveType, EInputBindingType> dictionary = new Dictionary<EKeySettingExclusiveType, EInputBindingType>();
			dictionary[EKeySettingExclusiveType.None] = EInputBindingType.Original;
			dictionary[EKeySettingExclusiveType.Motor] = EInputBindingType.Motor;
			this.ExclusiveTypeToBindingTypeMap = dictionary;
			this.DeviceLangInternal = "";
			this.CurrentDeviceLang = EKeyboardPrimaryLangId.Default;
			this.ActionSwitchKeysStat = Stat.Create("InputSettingsManager.ActionSwitchKeys", "", "");
			this.AxisSwitchKeysStat = Stat.Create("InputSettingsManager.AxisSwitchKeys", "", "");
			this.CombinationActionSwitchKeysStat = Stat.Create("InputSettingsManager.CombinationActionSwitchKeys", "", "");
			this.CombinationAxisSwitchKeysStat = Stat.Create("InputSettingsManager.CombinationAxisSwitchKeys", "", "");
			this.OriginalActionNameSet = new HashSet<string>();
			this.OriginalCombinationActionNameSet = new HashSet<string>();
			this.InSettingActionNameMap = new Dictionary<EKeySettingExclusiveType, Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>>>();
			this.AppliedKeyboardActionOverrides = new Dictionary<string, HashSet<EInputBindingType>>();
			this.AppliedKeyboardAxisOverrides = new Dictionary<string, HashSet<EInputBindingType>>();
			this.AppliedKeyboardCombinationActionOverrides = new Dictionary<string, HashSet<EInputBindingType>>();
			this.AppliedKeyboardCombinationAxisOverrides = new Dictionary<string, HashSet<EInputBindingType>>();
			base..ctor();
		}

		// Token: 0x0401FA6B RID: 129643
		private const int CHECK_COMBINATIONACTIONKEYMAP_SAVE_INTERVAL = 10000;

		// Token: 0x0401FA6C RID: 129644
		[Nullable(2)]
		private InputActionMapping ActionMapping;

		// Token: 0x0401FA6D RID: 129645
		[Nullable(2)]
		private InputAxisMapping AxisMapping;

		// Token: 0x0401FA6E RID: 129646
		[Nullable(2)]
		private InputCombinationActionMapping CombinationActionMapping;

		// Token: 0x0401FA6F RID: 129647
		[Nullable(2)]
		private InputCombinationAxisMapping CombinationAxisMapping;

		// Token: 0x0401FA70 RID: 129648
		private Dictionary<string, IList<IList<string>>> CombinationActionKeyMap = new Dictionary<string, IList<IList<string>>>();

		// Token: 0x0401FA71 RID: 129649
		private bool? CombinationActionKeyMapDirty;

		// Token: 0x0401FA72 RID: 129650
		[Nullable(2)]
		private TimerHandle CheckCombinationActionKeyMapSaveTimerId;

		// Token: 0x0401FA73 RID: 129651
		private readonly Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>> OriginalCombinationActionNameMap = new Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>>();

		// Token: 0x0401FA74 RID: 129652
		private readonly Dictionary<string, string> NormalToFrenchPcKeysMap = new Dictionary<string, string>();

		// Token: 0x0401FA75 RID: 129653
		private readonly Dictionary<string, string> FrenchToNormalPcKeysMap = new Dictionary<string, string>();

		// Token: 0x0401FA76 RID: 129654
		private readonly Dictionary<EKeySettingExclusiveType, EInputBindingType> ExclusiveTypeToBindingTypeMap;

		// Token: 0x0401FA77 RID: 129655
		private string DeviceLangInternal;

		// Token: 0x0401FA78 RID: 129656
		public EKeyboardPrimaryLangId CurrentDeviceLang;

		// Token: 0x0401FA79 RID: 129657
		public EInputBindingType CurrentBindingType;

		// Token: 0x0401FA7A RID: 129658
		private readonly Stat ActionSwitchKeysStat;

		// Token: 0x0401FA7B RID: 129659
		private readonly Stat AxisSwitchKeysStat;

		// Token: 0x0401FA7C RID: 129660
		private readonly Stat CombinationActionSwitchKeysStat;

		// Token: 0x0401FA7D RID: 129661
		private readonly Stat CombinationAxisSwitchKeysStat;

		// Token: 0x0401FA7E RID: 129662
		private readonly HashSet<string> OriginalActionNameSet;

		// Token: 0x0401FA7F RID: 129663
		private readonly HashSet<string> OriginalCombinationActionNameSet;

		// Token: 0x0401FA80 RID: 129664
		private readonly Dictionary<EKeySettingExclusiveType, Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>>> InSettingActionNameMap;

		// Token: 0x0401FA81 RID: 129665
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardActionOverrides;

		// Token: 0x0401FA82 RID: 129666
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardAxisOverrides;

		// Token: 0x0401FA83 RID: 129667
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardCombinationActionOverrides;

		// Token: 0x0401FA84 RID: 129668
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardCombinationAxisOverrides;

		// Token: 0x0401FA85 RID: 129669
		[Nullable(2)]
		private static InputSettingsManager _instance;
	}
}
