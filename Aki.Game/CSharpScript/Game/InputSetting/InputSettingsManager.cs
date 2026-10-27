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
	// Token: 0x02006FFD RID: 28669
	[NullableContext(1)]
	[Nullable(0)]
	public class InputSettingsManager : Singleton
	{
		// Token: 0x17009B98 RID: 39832
		// (get) Token: 0x06045BD5 RID: 285653 RVA: 0x011562C4 File Offset: 0x011544C4
		// (set) Token: 0x06045BD6 RID: 285654 RVA: 0x011562CC File Offset: 0x011544CC
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

		// Token: 0x06045BD7 RID: 285655 RVA: 0x011562F0 File Offset: 0x011544F0
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

		// Token: 0x06045BD8 RID: 285656 RVA: 0x0115637C File Offset: 0x0115457C
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

		// Token: 0x17009B99 RID: 39833
		// (get) Token: 0x06045BD9 RID: 285657 RVA: 0x011563E4 File Offset: 0x011545E4
		public bool CheckUseFrenchKeyboard
		{
			get
			{
				return InputSettings.Instance.GetKeyboardPrimaryLangId() == EKeyboardPrimaryLangId.French;
			}
		}

		// Token: 0x06045BDA RID: 285658 RVA: 0x011563FA File Offset: 0x011545FA
		public bool CheckUseFrenchKeyboardLang(string deviceLang)
		{
			return deviceLang == EKeyboardPrimaryLangId.French;
		}

		// Token: 0x06045BDB RID: 285659 RVA: 0x0115640C File Offset: 0x0115460C
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

		// Token: 0x06045BDC RID: 285660 RVA: 0x011564B4 File Offset: 0x011546B4
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

		// Token: 0x06045BDD RID: 285661 RVA: 0x01156529 File Offset: 0x01154729
		private void ClearDeviceLangChangeDelegate()
		{
			if (Platform.Instance.IsPcPlatform())
			{
				UKuroStaticLibrary.UnBindDeviceLangChangeDelegate();
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnDeviceLangChangeDelegate));
			}
		}

		// Token: 0x06045BDE RID: 285662 RVA: 0x01156550 File Offset: 0x01154750
		private void OnDeviceLangChangeDelegate()
		{
			EKeyboardPrimaryLangId keyboardPrimaryLangId = InputSettings.Instance.GetKeyboardPrimaryLangId();
			this.CurrentDeviceLang = keyboardPrimaryLangId;
			this.ChangeActionAndAxisPcKeys(keyboardPrimaryLangId);
		}

		// Token: 0x06045BDF RID: 285663 RVA: 0x0115657C File Offset: 0x0115477C
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

		// Token: 0x06045BE0 RID: 285664 RVA: 0x01156664 File Offset: 0x01154864
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

		// Token: 0x06045BE1 RID: 285665 RVA: 0x011567BC File Offset: 0x011549BC
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

		// Token: 0x06045BE2 RID: 285666 RVA: 0x01156944 File Offset: 0x01154B44
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

		// Token: 0x06045BE3 RID: 285667 RVA: 0x01156AF8 File Offset: 0x01154CF8
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

		// Token: 0x06045BE4 RID: 285668 RVA: 0x01156BE8 File Offset: 0x01154DE8
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

		// Token: 0x06045BE5 RID: 285669 RVA: 0x01156CE8 File Offset: 0x01154EE8
		private string ConvertKeyboardKeyName(string lastDeviceLang, string deviceLang, string keyName)
		{
			InputKey key = InputSettings.Instance.GetKey(keyName);
			if (key == null || !key.IsKeyboardKey)
			{
				return keyName;
			}
			return this.GetKeyNameByKeyboardLang(lastDeviceLang, deviceLang, keyName);
		}

		// Token: 0x06045BE6 RID: 285670 RVA: 0x01156D18 File Offset: 0x01154F18
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

		// Token: 0x06045BE7 RID: 285671 RVA: 0x01156E58 File Offset: 0x01155058
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

		// Token: 0x06045BE8 RID: 285672 RVA: 0x01156FA8 File Offset: 0x011551A8
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

		// Token: 0x06045BE9 RID: 285673 RVA: 0x01157130 File Offset: 0x01155330
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

		// Token: 0x06045BEA RID: 285674 RVA: 0x011572B8 File Offset: 0x011554B8
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

		// Token: 0x06045BEB RID: 285675 RVA: 0x01157309 File Offset: 0x01155509
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

		// Token: 0x06045BEC RID: 285676 RVA: 0x0115732C File Offset: 0x0115552C
		public void ResetDefaultInputKey()
		{
			this.RebuildDefaultInputSnapshot();
			InputSettings.Instance.SaveKeyMappings();
		}

		// Token: 0x06045BED RID: 285677 RVA: 0x0115733E File Offset: 0x0115553E
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

		// Token: 0x06045BEE RID: 285678 RVA: 0x01157370 File Offset: 0x01155570
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

		// Token: 0x06045BEF RID: 285679 RVA: 0x011573E4 File Offset: 0x011555E4
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

		// Token: 0x06045BF0 RID: 285680 RVA: 0x01157494 File Offset: 0x01155694
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

		// Token: 0x06045BF1 RID: 285681 RVA: 0x011574FC File Offset: 0x011556FC
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

		// Token: 0x06045BF2 RID: 285682 RVA: 0x011575E0 File Offset: 0x011557E0
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

		// Token: 0x06045BF3 RID: 285683 RVA: 0x0115763C File Offset: 0x0115583C
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

		// Token: 0x06045BF4 RID: 285684 RVA: 0x01157698 File Offset: 0x01155898
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

		// Token: 0x06045BF5 RID: 285685 RVA: 0x01157820 File Offset: 0x01155A20
		public EInputBindingType GetBindTypeByExclusiveType(EKeySettingExclusiveType exclusiveType)
		{
			EInputBindingType result;
			if (!this.ExclusiveTypeToBindingTypeMap.TryGetValue(exclusiveType, out result))
			{
				return EInputBindingType.Original;
			}
			return result;
		}

		// Token: 0x06045BF6 RID: 285686 RVA: 0x01157840 File Offset: 0x01155A40
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

		// Token: 0x06045BF7 RID: 285687 RVA: 0x011578A4 File Offset: 0x01155AA4
		[return: Nullable(2)]
		public InputActionBinding GetActionBinding(string actionName)
		{
			return this.ActionMapping.GetActionBinding(actionName);
		}

		// Token: 0x06045BF8 RID: 285688 RVA: 0x011578B2 File Offset: 0x01155AB2
		public IReadOnlyDictionary<string, InputActionBinding> GetActionBindingMap()
		{
			return this.ActionMapping.GetActionBindingMap();
		}

		// Token: 0x06045BF9 RID: 285689 RVA: 0x011578BF File Offset: 0x01155ABF
		[NullableContext(2)]
		public InputActionBinding GetActionBindingByConfigId(int configId)
		{
			return this.ActionMapping.GetActionBindingByConfigId(configId);
		}

		// Token: 0x06045BFA RID: 285690 RVA: 0x011578D0 File Offset: 0x01155AD0
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

		// Token: 0x06045BFB RID: 285691 RVA: 0x0115797F File Offset: 0x01155B7F
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlySet<InputActionBinding> GetActionBindingByActionMappingType(EActionMappingType actionMappingType)
		{
			return this.ActionMapping.GetActionBindingByActionMappingType(actionMappingType);
		}

		// Token: 0x06045BFC RID: 285692 RVA: 0x01157990 File Offset: 0x01155B90
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

		// Token: 0x06045BFD RID: 285693 RVA: 0x011579D4 File Offset: 0x01155BD4
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

		// Token: 0x06045BFE RID: 285694 RVA: 0x01157A54 File Offset: 0x01155C54
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

		// Token: 0x06045BFF RID: 285695 RVA: 0x01157A96 File Offset: 0x01155C96
		[return: Nullable(2)]
		public InputAxisBinding GetAxisBinding(string axisName)
		{
			return this.AxisMapping.GetAxisBinding(axisName);
		}

		// Token: 0x06045C00 RID: 285696 RVA: 0x01157AA4 File Offset: 0x01155CA4
		public IReadOnlyDictionary<string, InputAxisBinding> GetAxisBindingMap()
		{
			return this.AxisMapping.GetAxisBindingMap();
		}

		// Token: 0x06045C01 RID: 285697 RVA: 0x01157AB1 File Offset: 0x01155CB1
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlySet<InputAxisBinding> GetAxisBindingByAxisMappingType(EAxisMappingType axisMappingType)
		{
			return this.AxisMapping.GetAxisBindingByAxisMappingType(axisMappingType);
		}

		// Token: 0x06045C02 RID: 285698 RVA: 0x01157AC0 File Offset: 0x01155CC0
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

		// Token: 0x06045C03 RID: 285699 RVA: 0x01157B70 File Offset: 0x01155D70
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

		// Token: 0x06045C04 RID: 285700 RVA: 0x01157BE0 File Offset: 0x01155DE0
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

		// Token: 0x06045C05 RID: 285701 RVA: 0x01157C24 File Offset: 0x01155E24
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

		// Token: 0x06045C06 RID: 285702 RVA: 0x01157C66 File Offset: 0x01155E66
		public void RefreshCombinationActionKeys()
		{
			this.ClearCombinationActionKeyMap();
			this.CombinationActionKeyMap.Clear();
			this.SetCombinationActionKeyMapDirty();
			this.RefreshCombinationActionFromConfig();
		}

		// Token: 0x06045C07 RID: 285703 RVA: 0x01157C88 File Offset: 0x01155E88
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

		// Token: 0x06045C08 RID: 285704 RVA: 0x01157D70 File Offset: 0x01155F70
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

		// Token: 0x06045C09 RID: 285705 RVA: 0x01157F50 File Offset: 0x01156150
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

		// Token: 0x06045C0A RID: 285706 RVA: 0x01158028 File Offset: 0x01156228
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

		// Token: 0x06045C0B RID: 285707 RVA: 0x011580F4 File Offset: 0x011562F4
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

		// Token: 0x06045C0C RID: 285708 RVA: 0x011581DC File Offset: 0x011563DC
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

		// Token: 0x06045C0D RID: 285709 RVA: 0x011582A8 File Offset: 0x011564A8
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

		// Token: 0x06045C0E RID: 285710 RVA: 0x01158334 File Offset: 0x01156534
		private void ConvertPhantomInput()
		{
			bool? flag = new bool?(LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.IsConvertInput, false));
			if (!flag.GetValueOrDefault())
			{
				this.ConvertPhantomInputInternal();
				LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsConvertInput, true);
			}
		}

		// Token: 0x06045C0F RID: 285711 RVA: 0x01158368 File Offset: 0x01156568
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

		// Token: 0x06045C10 RID: 285712 RVA: 0x011583A4 File Offset: 0x011565A4
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

		// Token: 0x06045C11 RID: 285713 RVA: 0x011584BA File Offset: 0x011566BA
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

		// Token: 0x06045C12 RID: 285714 RVA: 0x011584E8 File Offset: 0x011566E8
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

		// Token: 0x06045C13 RID: 285715 RVA: 0x011585AC File Offset: 0x011567AC
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

		// Token: 0x06045C14 RID: 285716 RVA: 0x0115866C File Offset: 0x0115686C
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

		// Token: 0x06045C15 RID: 285717 RVA: 0x01158708 File Offset: 0x01156908
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

		// Token: 0x06045C16 RID: 285718 RVA: 0x01158860 File Offset: 0x01156A60
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

		// Token: 0x06045C17 RID: 285719 RVA: 0x01158A18 File Offset: 0x01156C18
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

		// Token: 0x06045C18 RID: 285720 RVA: 0x01158AF0 File Offset: 0x01156CF0
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

		// Token: 0x06045C19 RID: 285721 RVA: 0x01158B70 File Offset: 0x01156D70
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

		// Token: 0x06045C1A RID: 285722 RVA: 0x01158C30 File Offset: 0x01156E30
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

		// Token: 0x06045C1B RID: 285723 RVA: 0x01158CE4 File Offset: 0x01156EE4
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

		// Token: 0x06045C1C RID: 285724 RVA: 0x01158D3C File Offset: 0x01156F3C
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

		// Token: 0x06045C1D RID: 285725 RVA: 0x01158E08 File Offset: 0x01157008
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

		// Token: 0x06045C1E RID: 285726 RVA: 0x01158ED7 File Offset: 0x011570D7
		[return: Nullable(2)]
		public InputCombinationAxisBinding AddCombinationAxisKeyMap(string axisName, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			return this.AddCombinationAxisKeyMapInternal(axisName, secondaryKeyName, mainKeyName, bindingType);
		}

		// Token: 0x06045C1F RID: 285727 RVA: 0x01158EE4 File Offset: 0x011570E4
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

		// Token: 0x06045C20 RID: 285728 RVA: 0x0115900E File Offset: 0x0115720E
		public void RemoveCombinationAxisKeyMap(string axisName, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			this.RemoveCombinationAxisKeyInternal(axisName, secondaryKeyName, mainKeyName, bindingType);
		}

		// Token: 0x06045C21 RID: 285729 RVA: 0x0115901C File Offset: 0x0115721C
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

		// Token: 0x06045C22 RID: 285730 RVA: 0x011590C4 File Offset: 0x011572C4
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

		// Token: 0x06045C23 RID: 285731 RVA: 0x011591AC File Offset: 0x011573AC
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

		// Token: 0x06045C24 RID: 285732 RVA: 0x01159254 File Offset: 0x01157454
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

		// Token: 0x06045C25 RID: 285733 RVA: 0x01159274 File Offset: 0x01157474
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

		// Token: 0x06045C26 RID: 285734 RVA: 0x01159388 File Offset: 0x01157588
		private void InitCombinationAxisKeysWithBindingType(InputCombinationAxisBinding combinationAxisBinding, EInputBindingType bindingType, Dictionary<string, string> keyNameMap, bool isGamepad)
		{
			if (isGamepad)
			{
				combinationAxisBinding.ReplaceGamepadKeyMap(bindingType, keyNameMap);
				return;
			}
			combinationAxisBinding.ReplaceKeyboardKeyMap(bindingType, keyNameMap);
		}

		// Token: 0x06045C27 RID: 285735 RVA: 0x011593A0 File Offset: 0x011575A0
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

		// Token: 0x06045C28 RID: 285736 RVA: 0x011594B4 File Offset: 0x011576B4
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

		// Token: 0x06045C29 RID: 285737 RVA: 0x011594E4 File Offset: 0x011576E4
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

		// Token: 0x06045C2A RID: 285738 RVA: 0x01159560 File Offset: 0x01157760
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

		// Token: 0x06045C2B RID: 285739 RVA: 0x0115963C File Offset: 0x0115783C
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

		// Token: 0x06045C2C RID: 285740 RVA: 0x0115964B File Offset: 0x0115784B
		[return: Nullable(2)]
		public InputCombinationActionBinding GetCombinationActionBindingByActionName(string actionName)
		{
			return this.CombinationActionMapping.GetCombinationActionBindingByActionName(actionName);
		}

		// Token: 0x06045C2D RID: 285741 RVA: 0x01159659 File Offset: 0x01157859
		public IReadOnlyDictionary<string, InputCombinationActionBinding> GetCombinationActionBindingMap()
		{
			return this.CombinationActionMapping.GetCombinationActionBindingMap();
		}

		// Token: 0x06045C2E RID: 285742 RVA: 0x01159666 File Offset: 0x01157866
		public bool IsCombinationActionMainKey(string keyName)
		{
			return this.CombinationActionMapping.IsMainKey(keyName);
		}

		// Token: 0x06045C2F RID: 285743 RVA: 0x01159674 File Offset: 0x01157874
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

		// Token: 0x06045C30 RID: 285744 RVA: 0x01159704 File Offset: 0x01157904
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

		// Token: 0x06045C31 RID: 285745 RVA: 0x0115976C File Offset: 0x0115796C
		private void ClearCombinationAxisKeyMap()
		{
			InputCombinationAxisMapping combinationAxisMapping = this.CombinationAxisMapping;
			if (combinationAxisMapping != null)
			{
				combinationAxisMapping.Clear();
			}
			InputSettings.Instance.ClearCombinationAxisMappings();
		}

		// Token: 0x06045C32 RID: 285746 RVA: 0x01159789 File Offset: 0x01157989
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<InputCombinationAxisBinding> GetCombinationAxisBindingByKeyName(string mainKeyName, string secondaryKeyName)
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingByKeyName(mainKeyName, secondaryKeyName);
		}

		// Token: 0x06045C33 RID: 285747 RVA: 0x01159798 File Offset: 0x01157998
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

		// Token: 0x06045C34 RID: 285748 RVA: 0x011597A6 File Offset: 0x011579A6
		[return: Nullable(2)]
		public InputCombinationAxisBinding GetCombinationAxisBindingByAxisName(string axisName)
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingByAxisName(axisName);
		}

		// Token: 0x06045C35 RID: 285749 RVA: 0x011597B4 File Offset: 0x011579B4
		public IReadOnlyDictionary<string, InputCombinationAxisBinding> GetCombinationAxisBindingMap()
		{
			return this.CombinationAxisMapping.GetCombinationAxisBindingMap();
		}

		// Token: 0x06045C36 RID: 285750 RVA: 0x011597C1 File Offset: 0x011579C1
		public bool IsCombinationAxisMainKey(string keyName)
		{
			return this.CombinationAxisMapping.IsMainKey(keyName);
		}

		// Token: 0x06045C37 RID: 285751 RVA: 0x011597D0 File Offset: 0x011579D0
		public bool IsCombinationAxis(string mainKeyName, string secondaryKeyName)
		{
			IReadOnlyList<InputCombinationAxisBinding> combinationAxisBindingByKeyName = this.GetCombinationAxisBindingByKeyName(mainKeyName, secondaryKeyName);
			return combinationAxisBindingByKeyName != null && combinationAxisBindingByKeyName.Count > 0;
		}

		// Token: 0x06045C38 RID: 285752 RVA: 0x011597F8 File Offset: 0x011579F8
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

		// Token: 0x06045C39 RID: 285753 RVA: 0x01159878 File Offset: 0x01157A78
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

		// Token: 0x06045C3A RID: 285754 RVA: 0x011598DC File Offset: 0x01157ADC
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

		// Token: 0x06045C3B RID: 285755 RVA: 0x01159954 File Offset: 0x01157B54
		public bool IsOriginalCombinationActionName(string actionName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			HashSet<string> hashSet;
			return this.OriginalCombinationActionNameMap.TryGetValue(inputControllerType, out hashSet) && hashSet.Contains(actionName);
		}

		// Token: 0x06045C3C RID: 285756 RVA: 0x0115997C File Offset: 0x01157B7C
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

		// Token: 0x06045C3D RID: 285757 RVA: 0x011599C2 File Offset: 0x01157BC2
		private void SetCombinationActionKeyMapDirty()
		{
			this.CombinationActionKeyMapDirty = new bool?(true);
			this.StartCheckCombinationActionKeyMapSave();
		}

		// Token: 0x06045C3E RID: 285758 RVA: 0x011599D6 File Offset: 0x01157BD6
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

		// Token: 0x06045C3F RID: 285759 RVA: 0x01159A0A File Offset: 0x01157C0A
		private void StopCheckCombinationActionKeyMapSave()
		{
			if (this.CheckCombinationActionKeyMapSaveTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CheckCombinationActionKeyMapSaveTimerId);
				this.CheckCombinationActionKeyMapSaveTimerId = null;
			}
		}

		// Token: 0x06045C40 RID: 285760 RVA: 0x01159A2C File Offset: 0x01157C2C
		private bool IsCheckingCombinationActionKeyMapSave()
		{
			return this.CheckCombinationActionKeyMapSaveTimerId != null;
		}

		// Token: 0x06045C41 RID: 285761 RVA: 0x01159A37 File Offset: 0x01157C37
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

		// Token: 0x06045C42 RID: 285762 RVA: 0x01159A64 File Offset: 0x01157C64
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

		// Token: 0x06045C43 RID: 285763 RVA: 0x01159A92 File Offset: 0x01157C92
		public void MarkAppliedKeyboardActionOverride(string actionName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardActionOverrides, actionName, bindingType);
		}

		// Token: 0x06045C44 RID: 285764 RVA: 0x01159AA1 File Offset: 0x01157CA1
		public void MarkAppliedKeyboardAxisOverride(string axisName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardAxisOverrides, axisName, bindingType);
		}

		// Token: 0x06045C45 RID: 285765 RVA: 0x01159AB0 File Offset: 0x01157CB0
		public void MarkAppliedKeyboardCombinationActionOverride(string actionName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardCombinationActionOverrides, actionName, bindingType);
		}

		// Token: 0x06045C46 RID: 285766 RVA: 0x01159ABF File Offset: 0x01157CBF
		public void MarkAppliedKeyboardCombinationAxisOverride(string axisName, EInputBindingType bindingType)
		{
			InputSettingsManager.MarkAppliedKeyboardOverride(this.AppliedKeyboardCombinationAxisOverrides, axisName, bindingType);
		}

		// Token: 0x06045C47 RID: 285767 RVA: 0x01159ACE File Offset: 0x01157CCE
		public void ClearAppliedServerOverrides()
		{
			this.AppliedKeyboardActionOverrides.Clear();
			this.AppliedKeyboardAxisOverrides.Clear();
			this.AppliedKeyboardCombinationActionOverrides.Clear();
			this.AppliedKeyboardCombinationAxisOverrides.Clear();
		}

		// Token: 0x17009B9A RID: 39834
		// (get) Token: 0x06045C48 RID: 285768 RVA: 0x01159AFC File Offset: 0x01157CFC
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

		// Token: 0x06045C49 RID: 285769 RVA: 0x01159B1F File Offset: 0x01157D1F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045C4A RID: 285770 RVA: 0x01159B21 File Offset: 0x01157D21
		public static void ResetStaticDefaultValue()
		{
			InputSettingsManager instance = InputSettingsManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputSettingsManager._instance = null;
		}

		// Token: 0x06045C4B RID: 285771 RVA: 0x01159B3A File Offset: 0x01157D3A
		static InputSettingsManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettingsManager.CreateStaticDefaultValue), new Action(InputSettingsManager.ResetStaticDefaultValue));
		}

		// Token: 0x06045C4C RID: 285772 RVA: 0x01159B5C File Offset: 0x01157D5C
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

		// Token: 0x040247B5 RID: 149429
		private const int CHECK_COMBINATIONACTIONKEYMAP_SAVE_INTERVAL = 10000;

		// Token: 0x040247B6 RID: 149430
		[Nullable(2)]
		private InputActionMapping ActionMapping;

		// Token: 0x040247B7 RID: 149431
		[Nullable(2)]
		private InputAxisMapping AxisMapping;

		// Token: 0x040247B8 RID: 149432
		[Nullable(2)]
		private InputCombinationActionMapping CombinationActionMapping;

		// Token: 0x040247B9 RID: 149433
		[Nullable(2)]
		private InputCombinationAxisMapping CombinationAxisMapping;

		// Token: 0x040247BA RID: 149434
		private Dictionary<string, IList<IList<string>>> CombinationActionKeyMap = new Dictionary<string, IList<IList<string>>>();

		// Token: 0x040247BB RID: 149435
		private bool? CombinationActionKeyMapDirty;

		// Token: 0x040247BC RID: 149436
		[Nullable(2)]
		private TimerHandle CheckCombinationActionKeyMapSaveTimerId;

		// Token: 0x040247BD RID: 149437
		private readonly Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>> OriginalCombinationActionNameMap = new Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>>();

		// Token: 0x040247BE RID: 149438
		private readonly Dictionary<string, string> NormalToFrenchPcKeysMap = new Dictionary<string, string>();

		// Token: 0x040247BF RID: 149439
		private readonly Dictionary<string, string> FrenchToNormalPcKeysMap = new Dictionary<string, string>();

		// Token: 0x040247C0 RID: 149440
		private readonly Dictionary<EKeySettingExclusiveType, EInputBindingType> ExclusiveTypeToBindingTypeMap;

		// Token: 0x040247C1 RID: 149441
		private string DeviceLangInternal;

		// Token: 0x040247C2 RID: 149442
		public EKeyboardPrimaryLangId CurrentDeviceLang;

		// Token: 0x040247C3 RID: 149443
		public EInputBindingType CurrentBindingType;

		// Token: 0x040247C4 RID: 149444
		private readonly Stat ActionSwitchKeysStat;

		// Token: 0x040247C5 RID: 149445
		private readonly Stat AxisSwitchKeysStat;

		// Token: 0x040247C6 RID: 149446
		private readonly Stat CombinationActionSwitchKeysStat;

		// Token: 0x040247C7 RID: 149447
		private readonly Stat CombinationAxisSwitchKeysStat;

		// Token: 0x040247C8 RID: 149448
		private readonly HashSet<string> OriginalActionNameSet;

		// Token: 0x040247C9 RID: 149449
		private readonly HashSet<string> OriginalCombinationActionNameSet;

		// Token: 0x040247CA RID: 149450
		private readonly Dictionary<EKeySettingExclusiveType, Dictionary<CSharpScript.Game.Module.Menu.EInputControllerType, HashSet<string>>> InSettingActionNameMap;

		// Token: 0x040247CB RID: 149451
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardActionOverrides;

		// Token: 0x040247CC RID: 149452
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardAxisOverrides;

		// Token: 0x040247CD RID: 149453
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardCombinationActionOverrides;

		// Token: 0x040247CE RID: 149454
		private readonly Dictionary<string, HashSet<EInputBindingType>> AppliedKeyboardCombinationAxisOverrides;

		// Token: 0x040247CF RID: 149455
		[Nullable(2)]
		private static InputSettingsManager _instance;
	}
}
