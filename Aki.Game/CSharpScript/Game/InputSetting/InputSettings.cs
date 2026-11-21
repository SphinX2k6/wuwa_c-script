using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200616E RID: 24942
	[NullableContext(1)]
	[Nullable(0)]
	public class InputSettings : Singleton
	{
		// Token: 0x0603BCDA RID: 244954 RVA: 0x010F9DCC File Offset: 0x010F7FCC
		private InputActionKey PopInputActionKey(string actionName, bool bShift, bool bCtrl, bool bAlt, bool bCmd, string keyName)
		{
			InputActionKey inputActionKey = null;
			if (this.InputActionKeyPool.Count > 0)
			{
				int index = this.InputActionKeyPool.Count - 1;
				inputActionKey = this.InputActionKeyPool[index];
				this.InputActionKeyPool.RemoveAt(index);
			}
			if (inputActionKey != null)
			{
				InputActionKey.Refresh(inputActionKey, actionName, bShift, bCtrl, bAlt, bCmd, keyName);
			}
			else
			{
				inputActionKey = InputActionKey.New(actionName, bShift, bCtrl, bAlt, bCmd, keyName);
			}
			return inputActionKey;
		}

		// Token: 0x0603BCDB RID: 244955 RVA: 0x010F9E34 File Offset: 0x010F8034
		private void RecycleInputActionKey(InputActionKey inputActionKey)
		{
			this.InputActionKeyPool.Add(inputActionKey);
		}

		// Token: 0x0603BCDC RID: 244956 RVA: 0x010F9E44 File Offset: 0x010F8044
		private InputAxisKey PopInputAxisKey(string axisName, float scale, string keyName)
		{
			InputAxisKey inputAxisKey = null;
			if (this.InputAxisKeyPool.Count > 0)
			{
				int index = this.InputAxisKeyPool.Count - 1;
				inputAxisKey = this.InputAxisKeyPool[index];
				this.InputAxisKeyPool.RemoveAt(index);
			}
			if (inputAxisKey != null)
			{
				InputAxisKey.Refresh(inputAxisKey, axisName, scale, keyName);
			}
			else
			{
				inputAxisKey = InputAxisKey.New(axisName, scale, keyName);
			}
			return inputAxisKey;
		}

		// Token: 0x0603BCDD RID: 244957 RVA: 0x010F9EA0 File Offset: 0x010F80A0
		private void RecycleInputAxisKey(InputAxisKey inputAxisKey)
		{
			this.InputAxisKeyPool.Add(inputAxisKey);
		}

		// Token: 0x0603BCDE RID: 244958 RVA: 0x010F9EAE File Offset: 0x010F80AE
		public void Initialize()
		{
			LanguageKeyTransUtils.Initialize();
			this.InputSettingsInstance = UInputSettings.GetInputSettings();
			this.Refresh();
		}

		// Token: 0x0603BCDF RID: 244959 RVA: 0x010F9EC6 File Offset: 0x010F80C6
		public void Clear()
		{
			this.InputSettingsInstance = null;
			this.InputActionKeyMappings.Clear();
			this.InputAxisKeyMappings.Clear();
			this.InputCombinationActionKeyMappings.Clear();
			this.InputCombinationAxisKeyMappings.Clear();
			this.ClearKey();
		}

		// Token: 0x0603BCE0 RID: 244960 RVA: 0x010F9F01 File Offset: 0x010F8101
		private void ReApplyGamepadDeadZone()
		{
			this.ReApplyIfValid(EFunction.GamepadLeftStickDeadZone);
			this.ReApplyIfValid(EFunction.GamepadRightStickDeadZone);
			this.ReApplyIfValid(EFunction.GamepadLeftTriggerDeadZone);
			this.ReApplyIfValid(EFunction.GamepadRightTriggerDeadZone);
		}

		// Token: 0x0603BCE1 RID: 244961 RVA: 0x010F9F2F File Offset: 0x010F812F
		private void ReApplyIfValid(EFunction id)
		{
			if (!GameSettingsManager.Instance.IsValid(id, false))
			{
				return;
			}
			GameSettingsManager.Instance.ReApply(id, EGameSettingsApplyReason.AnyTime, false);
		}

		// Token: 0x0603BCE2 RID: 244962 RVA: 0x010F9F4E File Offset: 0x010F814E
		public void Refresh()
		{
			this.RefreshActionKeyMappings();
			this.RefreshAxisKeyMappings();
			this.RefreshCombinationAxis();
		}

		// Token: 0x0603BCE3 RID: 244963 RVA: 0x010F9F64 File Offset: 0x010F8164
		private void RefreshActionKeyMappings()
		{
			TArray<FName> actionNames = this.GetActionNames();
			for (int i = 0; i < actionNames.Num(); i++)
			{
				FName inActionName = actionNames.Get(i);
				TArray<FInputActionKeyMapping> tarray = new TArray<FInputActionKeyMapping>();
				this.InputSettingsInstance.GetActionMappingByName(inActionName, ref tarray);
				TArray<FInputActionKeyMapping> tarray2 = tarray;
				string key = inActionName.ToString();
				Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> dictionary;
				if (!this.InputActionKeyMappings.TryGetValue(key, out dictionary) || dictionary == null)
				{
					dictionary = new Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>();
					this.InputActionKeyMappings[key] = dictionary;
				}
				for (int j = 0; j < tarray2.Num(); j++)
				{
					FInputActionKeyMapping finputActionKeyMapping = tarray2.Get(j);
					string text = finputActionKeyMapping.Key.KeyName.ToString();
					this.TryAddKey(text);
					foreach (EInputBindingType key2 in InputBindingDefine.inputBindingTypesArray)
					{
						Dictionary<string, InputActionKey> dictionary2;
						if (!dictionary.TryGetValue(key2, out dictionary2) || dictionary2 == null)
						{
							dictionary2 = new Dictionary<string, InputActionKey>();
							dictionary[key2] = dictionary2;
						}
						InputActionKey inputActionKey;
						dictionary2.TryGetValue(text, out inputActionKey);
						if (inputActionKey == null || !inputActionKey.IsEqual(finputActionKeyMapping))
						{
							InputActionKey inputActionKey2 = InputActionKey.NewByInputActionKeyMapping(finputActionKeyMapping);
							if (inputActionKey2 != null)
							{
								dictionary2[text] = inputActionKey2;
							}
						}
					}
				}
				tarray2.Empty(true);
			}
		}

		// Token: 0x0603BCE4 RID: 244964 RVA: 0x010FA0B4 File Offset: 0x010F82B4
		private void RefreshAxisKeyMappings()
		{
			TArray<FName> axisNames = this.GetAxisNames();
			for (int i = 0; i < axisNames.Num(); i++)
			{
				FName inAxisName = axisNames.Get(i);
				TArray<FInputAxisKeyMapping> tarray = new TArray<FInputAxisKeyMapping>();
				this.InputSettingsInstance.GetAxisMappingByName(inAxisName, ref tarray);
				TArray<FInputAxisKeyMapping> tarray2 = tarray;
				string key = inAxisName.ToString();
				Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> dictionary;
				if (!this.InputAxisKeyMappings.TryGetValue(key, out dictionary) || dictionary == null)
				{
					dictionary = new Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>();
					this.InputAxisKeyMappings[key] = dictionary;
				}
				for (int j = 0; j < tarray2.Num(); j++)
				{
					FInputAxisKeyMapping finputAxisKeyMapping = tarray2.Get(j);
					string text = finputAxisKeyMapping.Key.KeyName.ToString();
					this.TryAddKey(text);
					foreach (EInputBindingType key2 in InputBindingDefine.inputBindingTypesArray)
					{
						Dictionary<string, InputAxisKey> dictionary2;
						if (!dictionary.TryGetValue(key2, out dictionary2) || dictionary2 == null)
						{
							dictionary2 = new Dictionary<string, InputAxisKey>();
							dictionary[key2] = dictionary2;
						}
						InputAxisKey inputAxisKey;
						dictionary2.TryGetValue(text, out inputAxisKey);
						if (inputAxisKey == null || !inputAxisKey.IsEqual(finputAxisKeyMapping))
						{
							InputAxisKey value = InputAxisKey.NewByInputAxisKeyMapping(finputAxisKeyMapping);
							dictionary2[text] = value;
						}
					}
				}
				tarray2.Empty(true);
			}
		}

		// Token: 0x0603BCE5 RID: 244965 RVA: 0x010FA200 File Offset: 0x010F8400
		public void RemoveCombinationActionMapping(string actionName, string mainKeyName, string secondaryKeyName)
		{
			Dictionary<string, List<InputCombinationActionKey>> dictionary;
			if (!this.InputCombinationActionKeyMappings.TryGetValue(actionName, out dictionary) || dictionary == null)
			{
				return;
			}
			List<InputCombinationActionKey> list;
			if (!dictionary.TryGetValue(mainKeyName, out list) || list == null)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < list.Count; i++)
			{
				InputKey secondaryKey = list[i].GetSecondaryKey();
				if (((secondaryKey != null) ? secondaryKey.GetKeyName() : null) == secondaryKeyName)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				list.RemoveAt(num);
			}
			if (list.Count <= 0)
			{
				dictionary.Remove(mainKeyName);
			}
		}

		// Token: 0x0603BCE6 RID: 244966 RVA: 0x010FA284 File Offset: 0x010F8484
		public void NewInputCombinationActionKey(string actionName, string mainKeyName, string secondaryKeyName)
		{
			this.TryAddKey(mainKeyName);
			this.TryAddKey(secondaryKeyName);
			InputCombinationActionKey item = InputCombinationActionKey.New(actionName, mainKeyName, secondaryKeyName);
			Dictionary<string, List<InputCombinationActionKey>> dictionary;
			if (!this.InputCombinationActionKeyMappings.TryGetValue(actionName, out dictionary) || dictionary == null)
			{
				Dictionary<string, List<InputCombinationActionKey>> dictionary2 = new Dictionary<string, List<InputCombinationActionKey>>();
				dictionary2[mainKeyName] = new List<InputCombinationActionKey>
				{
					item
				};
				this.InputCombinationActionKeyMappings[actionName] = dictionary2;
				return;
			}
			List<InputCombinationActionKey> list;
			if (dictionary.TryGetValue(mainKeyName, out list) && list != null)
			{
				list.Add(item);
				return;
			}
			dictionary[mainKeyName] = new List<InputCombinationActionKey>
			{
				item
			};
		}

		// Token: 0x0603BCE7 RID: 244967 RVA: 0x010FA30C File Offset: 0x010F850C
		private void RefreshCombinationAxis()
		{
			this.InputCombinationAxisKeyMappings.Clear();
			IReadOnlyList<CombinationAxis> allCombinationAxisConfig = InputSettingsConfig.Instance.GetAllCombinationAxisConfig();
			if (allCombinationAxisConfig == null)
			{
				return;
			}
			foreach (CombinationAxis combinationAxis in allCombinationAxisConfig)
			{
				string axisName = combinationAxis.AxisName;
				for (int i = 0; i < combinationAxis.PcKeyMapLength; i++)
				{
					DicStringString? dicStringString = combinationAxis.PcKeyMap(i);
					string key = dicStringString.Value.Key;
					string value = dicStringString.Value.Value;
					this.NewCombinationAxisKey(axisName, value, key, combinationAxis.GetSecondaryKeyScaleMap(key).GetValueOrDefault());
				}
				for (int j = 0; j < combinationAxis.GamepadKeyMapLength; j++)
				{
					DicStringString? dicStringString2 = combinationAxis.GamepadKeyMap(j);
					string key2 = dicStringString2.Value.Key;
					string value2 = dicStringString2.Value.Value;
					this.NewCombinationAxisKey(axisName, value2, key2, combinationAxis.GetSecondaryKeyScaleMap(key2).GetValueOrDefault());
				}
			}
		}

		// Token: 0x0603BCE8 RID: 244968 RVA: 0x010FA43C File Offset: 0x010F863C
		public void ClearCombinationActionMappings()
		{
			this.InputCombinationActionKeyMappings.Clear();
		}

		// Token: 0x0603BCE9 RID: 244969 RVA: 0x010FA449 File Offset: 0x010F8649
		public void ClearCombinationAxisMappings()
		{
			this.InputCombinationAxisKeyMappings.Clear();
		}

		// Token: 0x0603BCEA RID: 244970 RVA: 0x010FA456 File Offset: 0x010F8656
		public void NewInputCombinationAxisKey(string axisName, string mainKeyName, string secondaryKeyName, float scale)
		{
			this.NewCombinationAxisKey(axisName, mainKeyName, secondaryKeyName, scale);
		}

		// Token: 0x0603BCEB RID: 244971 RVA: 0x010FA463 File Offset: 0x010F8663
		[Conditional("DEBUG")]
		public void RefreshDebugKey()
		{
		}

		// Token: 0x0603BCEC RID: 244972 RVA: 0x010FA468 File Offset: 0x010F8668
		public void RemoveCombinationAxisMapping(string axisName, string mainKeyName, string secondaryKeyName)
		{
			Dictionary<string, IList<InputCombinationAxisKey>> dictionary;
			if (!this.InputCombinationAxisKeyMappings.TryGetValue(axisName, out dictionary) || dictionary == null)
			{
				return;
			}
			IList<InputCombinationAxisKey> list;
			if (!dictionary.TryGetValue(mainKeyName, out list) || list == null)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < list.Count; i++)
			{
				InputKey secondaryKey = list[i].GetSecondaryKey();
				if (((secondaryKey != null) ? secondaryKey.GetKeyName() : null) == secondaryKeyName)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				list.RemoveAt(num);
			}
			if (list.Count <= 0)
			{
				dictionary.Remove(mainKeyName);
			}
		}

		// Token: 0x0603BCED RID: 244973 RVA: 0x010FA4EC File Offset: 0x010F86EC
		private void NewCombinationAxisKey(string axisName, string mainKeyName, string secondaryKeyName, float scale)
		{
			this.TryAddKey(mainKeyName);
			this.TryAddKey(secondaryKeyName);
			Dictionary<string, IList<InputCombinationAxisKey>> dictionary;
			if (!this.InputCombinationAxisKeyMappings.TryGetValue(axisName, out dictionary) || dictionary == null)
			{
				dictionary = new Dictionary<string, IList<InputCombinationAxisKey>>();
				this.InputCombinationAxisKeyMappings[axisName] = dictionary;
			}
			IList<InputCombinationAxisKey> list;
			if (!dictionary.TryGetValue(mainKeyName, out list) || list == null)
			{
				list = new List<InputCombinationAxisKey>();
				dictionary[mainKeyName] = list;
			}
			InputCombinationAxisKey item = InputCombinationAxisKey.New(axisName, mainKeyName, secondaryKeyName, scale);
			list.Add(item);
		}

		// Token: 0x0603BCEE RID: 244974 RVA: 0x010FA55B File Offset: 0x010F875B
		public void SaveKeyMappings()
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null)
			{
				return;
			}
			inputSettingsInstance.SaveKeyMappingsNotSort();
		}

		// Token: 0x0603BCEF RID: 244975 RVA: 0x010FA56D File Offset: 0x010F876D
		private void TryAddKey(string keyName)
		{
			if (this.InputKeyMap.ContainsKey(keyName))
			{
				return;
			}
			this.AddKey(keyName);
		}

		// Token: 0x0603BCF0 RID: 244976 RVA: 0x010FA588 File Offset: 0x010F8788
		private void AddKey(string keyName)
		{
			InputKey value = new InputKey(keyName);
			this.InputKeyMap[keyName] = value;
		}

		// Token: 0x0603BCF1 RID: 244977 RVA: 0x010FA5A9 File Offset: 0x010F87A9
		private void ClearKey()
		{
			this.InputKeyMap.Clear();
		}

		// Token: 0x0603BCF2 RID: 244978 RVA: 0x010FA5B6 File Offset: 0x010F87B6
		[NullableContext(2)]
		public InputKey GetKey(EKey key)
		{
			return this.GetKey(key.ToString());
		}

		// Token: 0x0603BCF3 RID: 244979 RVA: 0x010FA5CC File Offset: 0x010F87CC
		[return: Nullable(2)]
		public InputKey GetKey(string key)
		{
			InputKey result;
			if (this.InputKeyMap.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BCF4 RID: 244980 RVA: 0x010FA5EC File Offset: 0x010F87EC
		[return: Nullable(2)]
		public FKey GetUeKey(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				return null;
			}
			return key.ToUeKey();
		}

		// Token: 0x0603BCF5 RID: 244981 RVA: 0x010FA600 File Offset: 0x010F8800
		public float? GetInputAnalogKeyState(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				return null;
			}
			return new float?(key.GetInputAnalogKeyState());
		}

		// Token: 0x0603BCF6 RID: 244982 RVA: 0x010FA62C File Offset: 0x010F882C
		public bool IsInputKeyDown(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			return key != null && key.IsInputKeyDown();
		}

		// Token: 0x0603BCF7 RID: 244983 RVA: 0x010FA64C File Offset: 0x010F884C
		public bool IsKeyboardKey(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				FKey fkey = new FKey
				{
					KeyName = new FName(keyName)
				};
				return UKismetInputLibrary.Key_IsKeyboardKey(fkey);
			}
			return key.IsKeyboardKey;
		}

		// Token: 0x0603BCF8 RID: 244984 RVA: 0x010FA684 File Offset: 0x010F8884
		public bool IsGamepadKey(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				FKey fkey = new FKey
				{
					KeyName = new FName(keyName)
				};
				return UKismetInputLibrary.Key_IsGamepadKey(fkey);
			}
			return key.IsGamepadKey;
		}

		// Token: 0x0603BCF9 RID: 244985 RVA: 0x010FA6BC File Offset: 0x010F88BC
		public bool IsMouseButton(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				FKey fkey = new FKey
				{
					KeyName = new FName(keyName)
				};
				return UKismetInputLibrary.Key_IsMouseButton(fkey);
			}
			return key.IsMouseButton;
		}

		// Token: 0x0603BCFA RID: 244986 RVA: 0x010FA6F4 File Offset: 0x010F88F4
		public bool IsValidKey(string keyName)
		{
			return keyName != EKey.Keyboard_Invalid && keyName != EKey.Gamepad_Invalid && keyName != EKey.GenericUSBController_ButtonInvalid;
		}

		// Token: 0x0603BCFB RID: 244987 RVA: 0x010FA72C File Offset: 0x010F892C
		[return: Nullable(2)]
		public string GetKeyIconPath(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				return null;
			}
			return key.GetKeyIconPath();
		}

		// Token: 0x0603BCFC RID: 244988 RVA: 0x010FA74C File Offset: 0x010F894C
		public void SetActionMappingApplyInputSettings(string actionName, IList<string> keys, EInputBindingType bindingType, bool applyRemoveInputSettings, bool applyAddInputSettings)
		{
			this.ClearActionMappingInternalByBindingType(actionName, bindingType, applyRemoveInputSettings);
			this.SetAllActionMappingInternalByBindingType(actionName, keys, bindingType, applyAddInputSettings);
		}

		// Token: 0x0603BCFD RID: 244989 RVA: 0x010FA764 File Offset: 0x010F8964
		public void SetActionMapping(string actionName, IList<string> keys, EInputBindingType lastBindingType, EInputBindingType bindingType)
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null || !inputSettingsInstance.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Action按键映射时，InputSetting不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (lastBindingType != bindingType)
			{
				Dictionary<string, InputActionKey> inputActionKeyMapByBindingType = this.GetInputActionKeyMapByBindingType(actionName, lastBindingType);
				if (inputActionKeyMapByBindingType != null && inputActionKeyMapByBindingType.Count > 0)
				{
					TArray<FInputActionKeyMapping> tarray = new TArray<FInputActionKeyMapping>();
					foreach (InputActionKey inputActionKey in inputActionKeyMapByBindingType.Values)
					{
						tarray.Add(inputActionKey.ToUeInputActionKeyMapping());
					}
					this.InputSettingsInstance.RemoveActionMappings(tarray, true);
				}
			}
			this.SetActionMappingApplyInputSettings(actionName, keys, bindingType, true, true);
			this.ReApplyGamepadDeadZone();
		}

		// Token: 0x0603BCFE RID: 244990 RVA: 0x010FA840 File Offset: 0x010F8A40
		public void AddActionMapping(string actionName, string keyName, EInputBindingType bindingType, bool needApply)
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null || !inputSettingsInstance.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "添加Action按键映射时，InputSetting不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.AddActionMappingInternal(actionName, keyName, bindingType, needApply);
		}

		// Token: 0x0603BCFF RID: 244991 RVA: 0x010FA898 File Offset: 0x010F8A98
		private void SetAllActionMappingInternalByBindingType(string actionName, IList<string> keys, EInputBindingType bindingType, bool applyAddInputSettings)
		{
			if (keys.Count > 0)
			{
				if (applyAddInputSettings)
				{
					TArray<FInputActionKeyMapping> tarray = new TArray<FInputActionKeyMapping>();
					foreach (string keyName in keys)
					{
						InputActionKey inputActionKey = this.AddActionMappingInternal(actionName, keyName, bindingType, false);
						tarray.Add(inputActionKey.ToUeInputActionKeyMapping());
					}
					this.InputSettingsInstance.AddActionMappings(tarray, true);
					this.ReApplyGamepadDeadZone();
					return;
				}
				foreach (string keyName2 in keys)
				{
					this.AddActionMappingInternal(actionName, keyName2, bindingType, false);
				}
			}
		}

		// Token: 0x0603BD00 RID: 244992 RVA: 0x010FA958 File Offset: 0x010F8B58
		private InputActionKey AddActionMappingInternal(string actionName, string keyName, EInputBindingType bindingType, bool needApply)
		{
			this.TryAddKey(keyName);
			Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> dictionary = this.GetInputActionKeyMap(actionName);
			if (dictionary == null)
			{
				dictionary = new Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>();
				this.InputActionKeyMappings[actionName] = dictionary;
			}
			Dictionary<string, InputActionKey> dictionary2;
			if (!dictionary.TryGetValue(bindingType, out dictionary2) || dictionary2 == null)
			{
				dictionary2 = new Dictionary<string, InputActionKey>();
				dictionary[bindingType] = dictionary2;
			}
			InputActionKey inputActionKey = this.PopInputActionKey(actionName, false, false, false, false, keyName);
			if (needApply)
			{
				UInputSettings inputSettingsInstance = this.InputSettingsInstance;
				FInputActionKeyMapping finputActionKeyMapping = inputActionKey.ToUeInputActionKeyMapping();
				inputSettingsInstance.AddActionMapping(finputActionKeyMapping, true);
				this.ReApplyGamepadDeadZone();
			}
			dictionary2[keyName] = inputActionKey;
			return inputActionKey;
		}

		// Token: 0x0603BD01 RID: 244993 RVA: 0x010FA9DC File Offset: 0x010F8BDC
		public unsafe void RemoveActionMapping(string actionName, string keyName, EInputBindingType bindingType, bool applyInputSettings, bool rebuildKeyMaps)
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null || !inputSettingsInstance.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "删除Action按键映射时，InputSetting不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Dictionary<string, InputActionKey> inputActionKeyMapByBindingType = this.GetInputActionKeyMapByBindingType(actionName, bindingType);
			if (inputActionKeyMapByBindingType == null)
			{
				return;
			}
			InputActionKey inputActionKey;
			if (!inputActionKeyMapByBindingType.TryGetValue(keyName, out inputActionKey) || inputActionKey == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputSettings;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "删除Action按键映射时,找不到对应按键";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionName", actionName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", keyName);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.RemoveActionMappingInternal(inputActionKey, inputActionKeyMapByBindingType, applyInputSettings, rebuildKeyMaps);
		}

		// Token: 0x0603BD02 RID: 244994 RVA: 0x010FAAA4 File Offset: 0x010F8CA4
		private void RemoveActionMappingInternal(InputActionKey inputActionKey, Dictionary<string, InputActionKey> inputActionKeyMap, bool applyInputSettings, bool rebuildKeyMaps)
		{
			string keyName = inputActionKey.KeyName;
			if (applyInputSettings)
			{
				UInputSettings inputSettingsInstance = this.InputSettingsInstance;
				FInputActionKeyMapping finputActionKeyMapping = inputActionKey.ToUeInputActionKeyMapping();
				inputSettingsInstance.RemoveActionMapping(finputActionKeyMapping, rebuildKeyMaps);
				if (rebuildKeyMaps)
				{
					this.ReApplyGamepadDeadZone();
				}
			}
			inputActionKeyMap.Remove(keyName);
		}

		// Token: 0x0603BD03 RID: 244995 RVA: 0x010FAAE4 File Offset: 0x010F8CE4
		public void ClearActionMapping(string actionName)
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null || !inputSettingsInstance.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "删除Action所有按键映射时，InputSetting不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ClearActionMappingInternal(actionName);
		}

		// Token: 0x0603BD04 RID: 244996 RVA: 0x010FAB38 File Offset: 0x010F8D38
		private void ClearActionMappingInternal(string actionName)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> inputActionKeyMap = this.GetInputActionKeyMap(actionName);
			if (inputActionKeyMap == null)
			{
				return;
			}
			if (inputActionKeyMap.Count > 0)
			{
				TArray<FInputActionKeyMapping> tarray = new TArray<FInputActionKeyMapping>();
				foreach (Dictionary<string, InputActionKey> dictionary in inputActionKeyMap.Values)
				{
					foreach (InputActionKey inputActionKey in dictionary.Values)
					{
						tarray.Add(inputActionKey.ToUeInputActionKeyMapping());
						this.RecycleInputActionKey(inputActionKey);
					}
					dictionary.Clear();
				}
				this.InputSettingsInstance.RemoveActionMappings(tarray, true);
				this.ReApplyGamepadDeadZone();
			}
		}

		// Token: 0x0603BD05 RID: 244997 RVA: 0x010FAC10 File Offset: 0x010F8E10
		private void ClearActionMappingInternalByBindingType(string actionName, EInputBindingType bindingType, bool applyInputSettings)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> inputActionKeyMap = this.GetInputActionKeyMap(actionName);
			if (inputActionKeyMap == null)
			{
				return;
			}
			Dictionary<string, InputActionKey> dictionary;
			if (!inputActionKeyMap.TryGetValue(bindingType, out dictionary) || dictionary == null)
			{
				return;
			}
			if (applyInputSettings && dictionary.Count > 0)
			{
				TArray<FInputActionKeyMapping> tarray = new TArray<FInputActionKeyMapping>();
				foreach (InputActionKey inputActionKey in dictionary.Values)
				{
					tarray.Add(inputActionKey.ToUeInputActionKeyMapping());
					this.RecycleInputActionKey(inputActionKey);
				}
				this.InputSettingsInstance.RemoveActionMappings(tarray, true);
				this.ReApplyGamepadDeadZone();
			}
			else
			{
				foreach (InputActionKey inputActionKey2 in dictionary.Values)
				{
					this.RecycleInputActionKey(inputActionKey2);
				}
			}
			dictionary.Clear();
		}

		// Token: 0x0603BD06 RID: 244998 RVA: 0x010FAD00 File Offset: 0x010F8F00
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> GetInputActionKeyMap(string actionName)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> result;
			if (this.InputActionKeyMappings.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD07 RID: 244999 RVA: 0x010FAD20 File Offset: 0x010F8F20
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, InputActionKey> GetInputActionKeyMapByBindingType(string actionName, EInputBindingType bindingType)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> dictionary;
			if (!this.InputActionKeyMappings.TryGetValue(actionName, out dictionary) || dictionary == null)
			{
				return null;
			}
			Dictionary<string, InputActionKey> result;
			if (dictionary.TryGetValue(bindingType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD08 RID: 245000 RVA: 0x010FAD50 File Offset: 0x010F8F50
		[return: Nullable(2)]
		public InputActionKey GetInputActionKey(string actionName, string keyName, EInputBindingType bindingType)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> inputActionKeyMap = this.GetInputActionKeyMap(actionName);
			if (inputActionKeyMap == null)
			{
				return null;
			}
			Dictionary<string, InputActionKey> dictionary;
			if (!inputActionKeyMap.TryGetValue(bindingType, out dictionary) || dictionary == null)
			{
				return null;
			}
			InputActionKey result;
			if (dictionary.TryGetValue(keyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD09 RID: 245001 RVA: 0x010FAD88 File Offset: 0x010F8F88
		public TArray<FName> GetActionNames()
		{
			TArray<FName> result = new TArray<FName>();
			this.InputSettingsInstance.GetActionNames(ref result);
			return result;
		}

		// Token: 0x0603BD0A RID: 245002 RVA: 0x010FADAC File Offset: 0x010F8FAC
		public TArray<FInputActionKeyMapping> GetActionMappings(string actionName)
		{
			TArray<FInputActionKeyMapping> result = new TArray<FInputActionKeyMapping>();
			this.InputSettingsInstance.GetActionMappingByName(FNameUtil.GetDynamicFName(actionName).Value, ref result);
			return result;
		}

		// Token: 0x0603BD0B RID: 245003 RVA: 0x010FADDC File Offset: 0x010F8FDC
		private void SetAxisMappingWithAddInputSettings(string axisName, Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
		{
			Dictionary<string, InputAxisKey> inputAxisKeyMap = this.GetInputAxisKeyMap(axisName, bindingType);
			if (inputAxisKeyMap != null)
			{
				foreach (InputAxisKey inputAxisKey in inputAxisKeyMap.Values)
				{
					this.RemoveAxisMappingInternal(inputAxisKey, inputAxisKeyMap, false);
				}
			}
			List<ValueTuple<string, float>> list = new List<ValueTuple<string, float>>();
			foreach (KeyValuePair<string, float> keyValuePair in keyScaleMap)
			{
				list.Add(new ValueTuple<string, float>(keyValuePair.Key, keyValuePair.Value));
			}
			if (list.Count > 0)
			{
				TArray<FInputAxisKeyMapping> tarray = new TArray<FInputAxisKeyMapping>();
				foreach (ValueTuple<string, float> valueTuple in list)
				{
					InputAxisKey inputAxisKey2 = this.AddAxisMappingInternal(axisName, valueTuple.Item2, valueTuple.Item1, bindingType, false);
					tarray.Add(inputAxisKey2.ToUeInputAxisKeyMapping());
				}
				this.InputSettingsInstance.AddAxisMappings(tarray, true);
				this.ReApplyGamepadDeadZone();
			}
		}

		// Token: 0x0603BD0C RID: 245004 RVA: 0x010FAF18 File Offset: 0x010F9118
		private void SetAxisMappingApplyInputSettings(string axisName, Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
		{
			Dictionary<string, InputAxisKey> inputAxisKeyMap = this.GetInputAxisKeyMap(axisName, bindingType);
			if (inputAxisKeyMap != null)
			{
				List<InputAxisKey> list = new List<InputAxisKey>();
				foreach (InputAxisKey inputAxisKey in inputAxisKeyMap.Values)
				{
					string keyName = inputAxisKey.KeyName;
					if (!keyScaleMap.ContainsKey(keyName) || inputAxisKey.Scale != keyScaleMap[keyName])
					{
						list.Add(inputAxisKey);
					}
				}
				if (list.Count > 0)
				{
					TArray<FInputAxisKeyMapping> tarray = new TArray<FInputAxisKeyMapping>();
					foreach (InputAxisKey inputAxisKey2 in list)
					{
						tarray.Add(inputAxisKey2.ToUeInputAxisKeyMapping());
						this.RemoveAxisMappingInternal(inputAxisKey2, inputAxisKeyMap, false);
					}
					this.InputSettingsInstance.RemoveAxisMappings(tarray, true);
					this.ReApplyGamepadDeadZone();
				}
			}
			List<ValueTuple<string, float>> list2 = new List<ValueTuple<string, float>>();
			foreach (KeyValuePair<string, float> keyValuePair in keyScaleMap)
			{
				string key = keyValuePair.Key;
				float value = keyValuePair.Value;
				InputAxisKey inputAxisKey3 = this.GetInputAxisKey(axisName, key, bindingType);
				if (inputAxisKey3 == null || inputAxisKey3.Scale != keyScaleMap[key])
				{
					list2.Add(new ValueTuple<string, float>(key, value));
				}
			}
			if (list2.Count > 0)
			{
				TArray<FInputAxisKeyMapping> tarray2 = new TArray<FInputAxisKeyMapping>();
				foreach (ValueTuple<string, float> valueTuple in list2)
				{
					InputAxisKey inputAxisKey4 = this.AddAxisMappingInternal(axisName, valueTuple.Item2, valueTuple.Item1, bindingType, false);
					tarray2.Add(inputAxisKey4.ToUeInputAxisKeyMapping());
				}
				this.InputSettingsInstance.AddAxisMappings(tarray2, true);
				this.ReApplyGamepadDeadZone();
			}
		}

		// Token: 0x0603BD0D RID: 245005 RVA: 0x010FB120 File Offset: 0x010F9320
		public void SetAxisMappingWithoutInputSettings(string axisName, Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
		{
			Dictionary<string, InputAxisKey> inputAxisKeyMap = this.GetInputAxisKeyMap(axisName, bindingType);
			if (inputAxisKeyMap != null)
			{
				foreach (InputAxisKey inputAxisKey in inputAxisKeyMap.Values)
				{
					this.RemoveAxisMappingInternal(inputAxisKey, inputAxisKeyMap, false);
				}
			}
			foreach (KeyValuePair<string, float> keyValuePair in keyScaleMap)
			{
				string key = keyValuePair.Key;
				float value = keyValuePair.Value;
				this.AddAxisMappingInternal(axisName, value, key, bindingType, false);
			}
		}

		// Token: 0x0603BD0E RID: 245006 RVA: 0x010FB1D8 File Offset: 0x010F93D8
		public void SetAxisMapping(string axisName, Dictionary<string, float> keyScaleMap, EInputBindingType lastBindingType, EInputBindingType bindingType)
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null || !inputSettingsInstance.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Axis按键映射时，InputSetting不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", axisName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (lastBindingType != bindingType)
			{
				Dictionary<string, InputAxisKey> inputAxisKeyMap = this.GetInputAxisKeyMap(axisName, lastBindingType);
				if (inputAxisKeyMap != null && inputAxisKeyMap.Count > 0)
				{
					TArray<FInputAxisKeyMapping> tarray = new TArray<FInputAxisKeyMapping>();
					foreach (InputAxisKey inputAxisKey in inputAxisKeyMap.Values)
					{
						tarray.Add(inputAxisKey.ToUeInputAxisKeyMapping());
					}
					this.InputSettingsInstance.RemoveAxisMappings(tarray, true);
				}
				this.SetAxisMappingWithAddInputSettings(axisName, keyScaleMap, bindingType);
			}
			else
			{
				this.SetAxisMappingApplyInputSettings(axisName, keyScaleMap, bindingType);
			}
			this.ReApplyGamepadDeadZone();
		}

		// Token: 0x0603BD0F RID: 245007 RVA: 0x010FB2BC File Offset: 0x010F94BC
		private InputAxisKey AddAxisMappingInternal(string axisName, float scale, string keyName, EInputBindingType bindingType, bool needApply)
		{
			this.TryAddKey(keyName);
			Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> dictionary = this.GetInputAxisKeyMapByBindingType(axisName);
			if (dictionary == null)
			{
				dictionary = new Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>();
				this.InputAxisKeyMappings[axisName] = dictionary;
			}
			Dictionary<string, InputAxisKey> dictionary2;
			if (!dictionary.TryGetValue(bindingType, out dictionary2) || dictionary2 == null)
			{
				dictionary2 = new Dictionary<string, InputAxisKey>();
				dictionary[bindingType] = dictionary2;
			}
			InputAxisKey inputAxisKey = this.PopInputAxisKey(axisName, scale, keyName);
			if (needApply)
			{
				UInputSettings inputSettingsInstance = this.InputSettingsInstance;
				FInputAxisKeyMapping finputAxisKeyMapping = inputAxisKey.ToUeInputAxisKeyMapping();
				inputSettingsInstance.AddAxisMapping(finputAxisKeyMapping, true);
				this.ReApplyGamepadDeadZone();
			}
			dictionary2[keyName] = inputAxisKey;
			return inputAxisKey;
		}

		// Token: 0x0603BD10 RID: 245008 RVA: 0x010FB340 File Offset: 0x010F9540
		private void RemoveAxisMappingInternal(InputAxisKey inputAxisKey, Dictionary<string, InputAxisKey> inputAxisMap, bool needApply)
		{
			string keyName = inputAxisKey.KeyName;
			if (needApply)
			{
				UInputSettings inputSettingsInstance = this.InputSettingsInstance;
				FInputAxisKeyMapping finputAxisKeyMapping = inputAxisKey.ToUeInputAxisKeyMapping();
				inputSettingsInstance.RemoveAxisMapping(finputAxisKeyMapping, true);
				this.ReApplyGamepadDeadZone();
			}
			this.RecycleInputAxisKey(inputAxisKey);
			inputAxisMap.Remove(keyName);
		}

		// Token: 0x0603BD11 RID: 245009 RVA: 0x010FB384 File Offset: 0x010F9584
		public void ClearAxisMapping(string axisName)
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null || !inputSettingsInstance.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "删除Axis所有按键映射时，InputSetting不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> inputAxisKeyMapByBindingType = this.GetInputAxisKeyMapByBindingType(axisName);
			if (inputAxisKeyMapByBindingType == null)
			{
				return;
			}
			if (inputAxisKeyMapByBindingType.Count > 0)
			{
				TArray<FInputAxisKeyMapping> tarray = new TArray<FInputAxisKeyMapping>();
				foreach (Dictionary<string, InputAxisKey> dictionary in inputAxisKeyMapByBindingType.Values)
				{
					foreach (InputAxisKey inputAxisKey in dictionary.Values)
					{
						tarray.Add(inputAxisKey.ToUeInputAxisKeyMapping());
						this.RecycleInputAxisKey(inputAxisKey);
					}
					dictionary.Clear();
				}
				this.InputSettingsInstance.RemoveAxisMappings(tarray, true);
				this.ReApplyGamepadDeadZone();
			}
		}

		// Token: 0x0603BD12 RID: 245010 RVA: 0x010FB49C File Offset: 0x010F969C
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> GetInputAxisKeyMapByBindingType(string axisName)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> result;
			if (this.InputAxisKeyMappings.TryGetValue(axisName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD13 RID: 245011 RVA: 0x010FB4BC File Offset: 0x010F96BC
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, InputAxisKey> GetInputAxisKeyMap(string axisName, EInputBindingType bindingType)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> dictionary;
			if (!this.InputAxisKeyMappings.TryGetValue(axisName, out dictionary) || dictionary == null)
			{
				return null;
			}
			Dictionary<string, InputAxisKey> result;
			if (dictionary.TryGetValue(bindingType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD14 RID: 245012 RVA: 0x010FB4EC File Offset: 0x010F96EC
		[return: Nullable(2)]
		public InputAxisKey GetInputAxisKey(string axisName, string keyName, EInputBindingType bindingType)
		{
			Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> dictionary;
			if (!this.InputAxisKeyMappings.TryGetValue(axisName, out dictionary) || dictionary == null)
			{
				return null;
			}
			Dictionary<string, InputAxisKey> dictionary2;
			if (!dictionary.TryGetValue(bindingType, out dictionary2) || dictionary2 == null)
			{
				return null;
			}
			InputAxisKey result;
			if (dictionary2.TryGetValue(keyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD15 RID: 245013 RVA: 0x010FB52C File Offset: 0x010F972C
		public TArray<FName> GetAxisNames()
		{
			TArray<FName> result = new TArray<FName>();
			this.InputSettingsInstance.GetAxisNames(ref result);
			return result;
		}

		// Token: 0x0603BD16 RID: 245014 RVA: 0x010FB550 File Offset: 0x010F9750
		public TArray<FInputAxisKeyMapping> GetAxisMappings(string actionName)
		{
			TArray<FInputAxisKeyMapping> result = new TArray<FInputAxisKeyMapping>();
			this.InputSettingsInstance.GetAxisMappingByName(FNameUtil.GetDynamicFName(actionName).Value, ref result);
			return result;
		}

		// Token: 0x0603BD17 RID: 245015 RVA: 0x010FB580 File Offset: 0x010F9780
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<string, List<InputCombinationActionKey>> GetCombinationActionKeyMap(string actionName)
		{
			Dictionary<string, List<InputCombinationActionKey>> result;
			if (this.InputCombinationActionKeyMappings.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD18 RID: 245016 RVA: 0x010FB5A0 File Offset: 0x010F97A0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<InputCombinationActionKey> GetCombinationActionKey(string actionName, string mainKeyName)
		{
			Dictionary<string, List<InputCombinationActionKey>> dictionary;
			if (!this.InputCombinationActionKeyMappings.TryGetValue(actionName, out dictionary) || dictionary == null)
			{
				return null;
			}
			List<InputCombinationActionKey> result;
			if (dictionary.TryGetValue(mainKeyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD19 RID: 245017 RVA: 0x010FB5D0 File Offset: 0x010F97D0
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<string, IList<InputCombinationAxisKey>> GetCombinationAxisKeyMap(string axisName)
		{
			Dictionary<string, IList<InputCombinationAxisKey>> result;
			if (this.InputCombinationAxisKeyMappings.TryGetValue(axisName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD1A RID: 245018 RVA: 0x010FB5F0 File Offset: 0x010F97F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IList<InputCombinationAxisKey> GetCombinationAxisKey(string axisName, string mainKeyName)
		{
			Dictionary<string, IList<InputCombinationAxisKey>> dictionary;
			if (!this.InputCombinationAxisKeyMappings.TryGetValue(axisName, out dictionary) || dictionary == null)
			{
				return null;
			}
			IList<InputCombinationAxisKey> result;
			if (dictionary.TryGetValue(mainKeyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BD1B RID: 245019 RVA: 0x010FB620 File Offset: 0x010F9820
		public void SetUseMouseForTouch(bool value)
		{
			if (this.InputSettingsInstance == null)
			{
				return;
			}
			this.InputSettingsInstance.bUseMouseForTouch = value;
		}

		// Token: 0x0603BD1C RID: 245020 RVA: 0x010FB638 File Offset: 0x010F9838
		public EKeyboardPrimaryLangId GetKeyboardPrimaryLangId()
		{
			if (this.InputSettingsInstance != null)
			{
				EKeyboardPrimaryLangId ekeyboardPrimaryLangId = (EKeyboardPrimaryLangId)this.InputSettingsInstance.GetKeyboardPrimaryLangId().ToString();
				if (ekeyboardPrimaryLangId == EKeyboardPrimaryLangId.French || ekeyboardPrimaryLangId == EKeyboardPrimaryLangId.Thai)
				{
					return ekeyboardPrimaryLangId;
				}
			}
			return EKeyboardPrimaryLangId.Default;
		}

		// Token: 0x170070D5 RID: 28885
		// (get) Token: 0x0603BD1D RID: 245021 RVA: 0x010FB68D File Offset: 0x010F988D
		public static InputSettings Instance
		{
			get
			{
				if (InputSettings._instance == null)
				{
					InputSettings._instance = new InputSettings();
					InputSettings._instance.OnInit();
				}
				return InputSettings._instance;
			}
		}

		// Token: 0x0603BD1E RID: 245022 RVA: 0x010FB6B0 File Offset: 0x010F98B0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BD1F RID: 245023 RVA: 0x010FB6B2 File Offset: 0x010F98B2
		public static void ResetStaticDefaultValue()
		{
			InputSettings instance = InputSettings._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputSettings._instance = null;
		}

		// Token: 0x0603BD20 RID: 245024 RVA: 0x010FB6CB File Offset: 0x010F98CB
		static InputSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettings.CreateStaticDefaultValue), new Action(InputSettings.ResetStaticDefaultValue));
		}

		// Token: 0x0401F88A RID: 129162
		[Nullable(2)]
		private UInputSettings InputSettingsInstance;

		// Token: 0x0401F88B RID: 129163
		private readonly Dictionary<string, InputKey> InputKeyMap = new Dictionary<string, InputKey>();

		// Token: 0x0401F88C RID: 129164
		private readonly Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>> InputActionKeyMappings = new Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>>();

		// Token: 0x0401F88D RID: 129165
		private readonly Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>> InputAxisKeyMappings = new Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>>();

		// Token: 0x0401F88E RID: 129166
		private readonly Dictionary<string, Dictionary<string, List<InputCombinationActionKey>>> InputCombinationActionKeyMappings = new Dictionary<string, Dictionary<string, List<InputCombinationActionKey>>>();

		// Token: 0x0401F88F RID: 129167
		private readonly Dictionary<string, Dictionary<string, IList<InputCombinationAxisKey>>> InputCombinationAxisKeyMappings = new Dictionary<string, Dictionary<string, IList<InputCombinationAxisKey>>>();

		// Token: 0x0401F890 RID: 129168
		private readonly List<InputActionKey> InputActionKeyPool = new List<InputActionKey>();

		// Token: 0x0401F891 RID: 129169
		private readonly List<InputAxisKey> InputAxisKeyPool = new List<InputAxisKey>();

		// Token: 0x0401F892 RID: 129170
		[Nullable(2)]
		private static InputSettings _instance;
	}
}
