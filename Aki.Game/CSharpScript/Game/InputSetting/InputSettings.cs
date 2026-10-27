using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FED RID: 28653
	[NullableContext(1)]
	[Nullable(0)]
	public class InputSettings : Singleton
	{
		// Token: 0x06045B29 RID: 285481 RVA: 0x0114FFD8 File Offset: 0x0114E1D8
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

		// Token: 0x06045B2A RID: 285482 RVA: 0x01150040 File Offset: 0x0114E240
		private void RecycleInputActionKey(InputActionKey inputActionKey)
		{
			this.InputActionKeyPool.Add(inputActionKey);
		}

		// Token: 0x06045B2B RID: 285483 RVA: 0x01150050 File Offset: 0x0114E250
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

		// Token: 0x06045B2C RID: 285484 RVA: 0x011500AC File Offset: 0x0114E2AC
		private void RecycleInputAxisKey(InputAxisKey inputAxisKey)
		{
			this.InputAxisKeyPool.Add(inputAxisKey);
		}

		// Token: 0x06045B2D RID: 285485 RVA: 0x011500BA File Offset: 0x0114E2BA
		public void Initialize()
		{
			LanguageKeyTransUtils.Initialize();
			this.InputSettingsInstance = UInputSettings.GetInputSettings();
			this.Refresh();
		}

		// Token: 0x06045B2E RID: 285486 RVA: 0x011500D2 File Offset: 0x0114E2D2
		public void Clear()
		{
			this.InputSettingsInstance = null;
			this.InputActionKeyMappings.Clear();
			this.InputAxisKeyMappings.Clear();
			this.InputCombinationActionKeyMappings.Clear();
			this.InputCombinationAxisKeyMappings.Clear();
			this.ClearKey();
		}

		// Token: 0x06045B2F RID: 285487 RVA: 0x0115010D File Offset: 0x0114E30D
		private void ReApplyGamepadDeadZone()
		{
			this.ReApplyIfValid(EFunction.GamepadLeftStickDeadZone);
			this.ReApplyIfValid(EFunction.GamepadRightStickDeadZone);
			this.ReApplyIfValid(EFunction.GamepadLeftTriggerDeadZone);
			this.ReApplyIfValid(EFunction.GamepadRightTriggerDeadZone);
		}

		// Token: 0x06045B30 RID: 285488 RVA: 0x0115013B File Offset: 0x0114E33B
		private void ReApplyIfValid(EFunction id)
		{
			if (!GameSettingsManager.Instance.IsValid(id, false))
			{
				return;
			}
			GameSettingsManager.Instance.ReApply(id, EGameSettingsApplyReason.AnyTime, false);
		}

		// Token: 0x06045B31 RID: 285489 RVA: 0x0115015A File Offset: 0x0114E35A
		public void Refresh()
		{
			this.RefreshActionKeyMappings();
			this.RefreshAxisKeyMappings();
			this.RefreshCombinationAxis();
		}

		// Token: 0x06045B32 RID: 285490 RVA: 0x01150170 File Offset: 0x0114E370
		private void RefreshActionKeyMappings()
		{
			TArray<FName> actionNames = this.GetActionNames();
			for (int i = 0; i < actionNames.Num(); i++)
			{
				FName inActionName = actionNames.Get(i);
				TArray<FInputActionKeyMapping> tarray = new TArray<FInputActionKeyMapping>();
				this.InputSettingsInstance.GetActionMappingByName(inActionName, ref tarray);
				TArray<FInputActionKeyMapping> tarray2 = tarray;
				string text = inActionName.ToString();
				if (Info.Instance.IsPlayInEditor && InputSettingsConfig.Instance.GetActionMappingConfigByActionName(text) == null)
				{
					this.InputSettingsInstance.RemoveActionMappings(tarray2, true);
				}
				else
				{
					Dictionary<EInputBindingType, Dictionary<string, InputActionKey>> dictionary;
					if (!this.InputActionKeyMappings.TryGetValue(text, out dictionary) || dictionary == null)
					{
						dictionary = new Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>();
						this.InputActionKeyMappings[text] = dictionary;
					}
					for (int j = 0; j < tarray2.Num(); j++)
					{
						FInputActionKeyMapping finputActionKeyMapping = tarray2.Get(j);
						string text2 = finputActionKeyMapping.Key.KeyName.ToString();
						this.TryAddKey(text2);
						foreach (EInputBindingType key in InputBindingDefine.inputBindingTypesArray)
						{
							Dictionary<string, InputActionKey> dictionary2;
							if (!dictionary.TryGetValue(key, out dictionary2) || dictionary2 == null)
							{
								dictionary2 = new Dictionary<string, InputActionKey>();
								dictionary[key] = dictionary2;
							}
							InputActionKey inputActionKey;
							dictionary2.TryGetValue(text2, out inputActionKey);
							if (inputActionKey == null || !inputActionKey.IsEqual(finputActionKeyMapping))
							{
								InputActionKey inputActionKey2 = InputActionKey.NewByInputActionKeyMapping(finputActionKeyMapping);
								if (inputActionKey2 != null)
								{
									dictionary2[text2] = inputActionKey2;
								}
							}
						}
					}
					tarray2.Empty(true);
				}
			}
		}

		// Token: 0x06045B33 RID: 285491 RVA: 0x011502F8 File Offset: 0x0114E4F8
		private void RefreshAxisKeyMappings()
		{
			TArray<FName> axisNames = this.GetAxisNames();
			for (int i = 0; i < axisNames.Num(); i++)
			{
				FName inAxisName = axisNames.Get(i);
				TArray<FInputAxisKeyMapping> tarray = new TArray<FInputAxisKeyMapping>();
				this.InputSettingsInstance.GetAxisMappingByName(inAxisName, ref tarray);
				TArray<FInputAxisKeyMapping> tarray2 = tarray;
				string text = inAxisName.ToString();
				if (Info.Instance.IsPlayInEditor && InputSettingsConfig.Instance.GetAxisMappingConfigByAxisName(text) == null)
				{
					this.InputSettingsInstance.RemoveAxisMappings(tarray2, true);
				}
				else
				{
					Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> dictionary;
					if (!this.InputAxisKeyMappings.TryGetValue(text, out dictionary) || dictionary == null)
					{
						dictionary = new Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>();
						this.InputAxisKeyMappings[text] = dictionary;
					}
					for (int j = 0; j < tarray2.Num(); j++)
					{
						FInputAxisKeyMapping finputAxisKeyMapping = tarray2.Get(j);
						string text2 = finputAxisKeyMapping.Key.KeyName.ToString();
						this.TryAddKey(text2);
						foreach (EInputBindingType key in InputBindingDefine.inputBindingTypesArray)
						{
							Dictionary<string, InputAxisKey> dictionary2;
							if (!dictionary.TryGetValue(key, out dictionary2) || dictionary2 == null)
							{
								dictionary2 = new Dictionary<string, InputAxisKey>();
								dictionary[key] = dictionary2;
							}
							InputAxisKey inputAxisKey;
							dictionary2.TryGetValue(text2, out inputAxisKey);
							if (inputAxisKey == null || !inputAxisKey.IsEqual(finputAxisKeyMapping))
							{
								InputAxisKey value = InputAxisKey.NewByInputAxisKeyMapping(finputAxisKeyMapping);
								dictionary2[text2] = value;
							}
						}
					}
					tarray2.Empty(true);
				}
			}
		}

		// Token: 0x06045B34 RID: 285492 RVA: 0x0115047C File Offset: 0x0114E67C
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

		// Token: 0x06045B35 RID: 285493 RVA: 0x01150500 File Offset: 0x0114E700
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

		// Token: 0x06045B36 RID: 285494 RVA: 0x01150588 File Offset: 0x0114E788
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

		// Token: 0x06045B37 RID: 285495 RVA: 0x011506B8 File Offset: 0x0114E8B8
		public void ClearCombinationActionMappings()
		{
			this.InputCombinationActionKeyMappings.Clear();
		}

		// Token: 0x06045B38 RID: 285496 RVA: 0x011506C5 File Offset: 0x0114E8C5
		public void ClearCombinationAxisMappings()
		{
			this.InputCombinationAxisKeyMappings.Clear();
		}

		// Token: 0x06045B39 RID: 285497 RVA: 0x011506D2 File Offset: 0x0114E8D2
		public void NewInputCombinationAxisKey(string axisName, string mainKeyName, string secondaryKeyName, float scale)
		{
			this.NewCombinationAxisKey(axisName, mainKeyName, secondaryKeyName, scale);
		}

		// Token: 0x06045B3A RID: 285498 RVA: 0x011506DF File Offset: 0x0114E8DF
		[Conditional("DEBUG")]
		public void RefreshDebugKey()
		{
		}

		// Token: 0x06045B3B RID: 285499 RVA: 0x011506E4 File Offset: 0x0114E8E4
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

		// Token: 0x06045B3C RID: 285500 RVA: 0x01150768 File Offset: 0x0114E968
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

		// Token: 0x06045B3D RID: 285501 RVA: 0x011507D7 File Offset: 0x0114E9D7
		public void SaveKeyMappings()
		{
			UInputSettings inputSettingsInstance = this.InputSettingsInstance;
			if (inputSettingsInstance == null)
			{
				return;
			}
			inputSettingsInstance.SaveKeyMappingsNotSort();
		}

		// Token: 0x06045B3E RID: 285502 RVA: 0x011507E9 File Offset: 0x0114E9E9
		private void TryAddKey(string keyName)
		{
			if (this.InputKeyMap.ContainsKey(keyName))
			{
				return;
			}
			this.AddKey(keyName);
		}

		// Token: 0x06045B3F RID: 285503 RVA: 0x01150804 File Offset: 0x0114EA04
		private void AddKey(string keyName)
		{
			InputKey value = new InputKey(keyName);
			this.InputKeyMap[keyName] = value;
		}

		// Token: 0x06045B40 RID: 285504 RVA: 0x01150825 File Offset: 0x0114EA25
		private void ClearKey()
		{
			this.InputKeyMap.Clear();
		}

		// Token: 0x06045B41 RID: 285505 RVA: 0x01150832 File Offset: 0x0114EA32
		[NullableContext(2)]
		public InputKey GetKey(EKey key)
		{
			return this.GetKey(key.ToString());
		}

		// Token: 0x06045B42 RID: 285506 RVA: 0x01150848 File Offset: 0x0114EA48
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

		// Token: 0x06045B43 RID: 285507 RVA: 0x01150868 File Offset: 0x0114EA68
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

		// Token: 0x06045B44 RID: 285508 RVA: 0x0115087C File Offset: 0x0114EA7C
		public float? GetInputAnalogKeyState(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				return null;
			}
			return new float?(key.GetInputAnalogKeyState());
		}

		// Token: 0x06045B45 RID: 285509 RVA: 0x011508A8 File Offset: 0x0114EAA8
		public bool IsInputKeyDown(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			return key != null && key.IsInputKeyDown();
		}

		// Token: 0x06045B46 RID: 285510 RVA: 0x011508C8 File Offset: 0x0114EAC8
		public bool IsKeyboardKey(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				FKey fkey = new FKey(new FName(keyName));
				return UKismetInputLibrary.Key_IsKeyboardKey(fkey);
			}
			return key.IsKeyboardKey;
		}

		// Token: 0x06045B47 RID: 285511 RVA: 0x011508FC File Offset: 0x0114EAFC
		public bool IsGamepadKey(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				FKey fkey = new FKey(new FName(keyName));
				return UKismetInputLibrary.Key_IsGamepadKey(fkey);
			}
			return key.IsGamepadKey;
		}

		// Token: 0x06045B48 RID: 285512 RVA: 0x01150930 File Offset: 0x0114EB30
		public bool IsMouseButton(string keyName)
		{
			InputKey key = this.GetKey(keyName);
			if (key == null)
			{
				FKey fkey = new FKey(new FName(keyName));
				return UKismetInputLibrary.Key_IsMouseButton(fkey);
			}
			return key.IsMouseButton;
		}

		// Token: 0x06045B49 RID: 285513 RVA: 0x01150962 File Offset: 0x0114EB62
		public bool IsValidKey(string keyName)
		{
			return keyName != EKey.Keyboard_Invalid && keyName != EKey.Gamepad_Invalid && keyName != EKey.GenericUSBController_ButtonInvalid;
		}

		// Token: 0x06045B4A RID: 285514 RVA: 0x0115099C File Offset: 0x0114EB9C
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

		// Token: 0x06045B4B RID: 285515 RVA: 0x011509BC File Offset: 0x0114EBBC
		public void SetActionMappingApplyInputSettings(string actionName, IList<string> keys, EInputBindingType bindingType, bool applyRemoveInputSettings, bool applyAddInputSettings)
		{
			this.ClearActionMappingInternalByBindingType(actionName, bindingType, applyRemoveInputSettings);
			this.SetAllActionMappingInternalByBindingType(actionName, keys, bindingType, applyAddInputSettings);
		}

		// Token: 0x06045B4C RID: 285516 RVA: 0x011509D4 File Offset: 0x0114EBD4
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

		// Token: 0x06045B4D RID: 285517 RVA: 0x01150AB0 File Offset: 0x0114ECB0
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

		// Token: 0x06045B4E RID: 285518 RVA: 0x01150B08 File Offset: 0x0114ED08
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

		// Token: 0x06045B4F RID: 285519 RVA: 0x01150BC8 File Offset: 0x0114EDC8
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

		// Token: 0x06045B50 RID: 285520 RVA: 0x01150C4C File Offset: 0x0114EE4C
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

		// Token: 0x06045B51 RID: 285521 RVA: 0x01150D14 File Offset: 0x0114EF14
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

		// Token: 0x06045B52 RID: 285522 RVA: 0x01150D54 File Offset: 0x0114EF54
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

		// Token: 0x06045B53 RID: 285523 RVA: 0x01150DA8 File Offset: 0x0114EFA8
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

		// Token: 0x06045B54 RID: 285524 RVA: 0x01150E80 File Offset: 0x0114F080
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

		// Token: 0x06045B55 RID: 285525 RVA: 0x01150F70 File Offset: 0x0114F170
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

		// Token: 0x06045B56 RID: 285526 RVA: 0x01150F90 File Offset: 0x0114F190
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

		// Token: 0x06045B57 RID: 285527 RVA: 0x01150FC0 File Offset: 0x0114F1C0
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

		// Token: 0x06045B58 RID: 285528 RVA: 0x01150FF8 File Offset: 0x0114F1F8
		public TArray<FName> GetActionNames()
		{
			TArray<FName> result = new TArray<FName>();
			this.InputSettingsInstance.GetActionNames(ref result);
			return result;
		}

		// Token: 0x06045B59 RID: 285529 RVA: 0x0115101C File Offset: 0x0114F21C
		public TArray<FInputActionKeyMapping> GetActionMappings(string actionName)
		{
			TArray<FInputActionKeyMapping> result = new TArray<FInputActionKeyMapping>();
			this.InputSettingsInstance.GetActionMappingByName(FNameUtil.GetDynamicFName(actionName).Value, ref result);
			return result;
		}

		// Token: 0x06045B5A RID: 285530 RVA: 0x0115104C File Offset: 0x0114F24C
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

		// Token: 0x06045B5B RID: 285531 RVA: 0x01151188 File Offset: 0x0114F388
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

		// Token: 0x06045B5C RID: 285532 RVA: 0x01151390 File Offset: 0x0114F590
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

		// Token: 0x06045B5D RID: 285533 RVA: 0x01151448 File Offset: 0x0114F648
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

		// Token: 0x06045B5E RID: 285534 RVA: 0x0115152C File Offset: 0x0114F72C
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

		// Token: 0x06045B5F RID: 285535 RVA: 0x011515B0 File Offset: 0x0114F7B0
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

		// Token: 0x06045B60 RID: 285536 RVA: 0x011515F4 File Offset: 0x0114F7F4
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

		// Token: 0x06045B61 RID: 285537 RVA: 0x0115170C File Offset: 0x0114F90C
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

		// Token: 0x06045B62 RID: 285538 RVA: 0x0115172C File Offset: 0x0114F92C
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

		// Token: 0x06045B63 RID: 285539 RVA: 0x0115175C File Offset: 0x0114F95C
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

		// Token: 0x06045B64 RID: 285540 RVA: 0x0115179C File Offset: 0x0114F99C
		public TArray<FName> GetAxisNames()
		{
			TArray<FName> result = new TArray<FName>();
			this.InputSettingsInstance.GetAxisNames(ref result);
			return result;
		}

		// Token: 0x06045B65 RID: 285541 RVA: 0x011517C0 File Offset: 0x0114F9C0
		public TArray<FInputAxisKeyMapping> GetAxisMappings(string actionName)
		{
			TArray<FInputAxisKeyMapping> result = new TArray<FInputAxisKeyMapping>();
			this.InputSettingsInstance.GetAxisMappingByName(FNameUtil.GetDynamicFName(actionName).Value, ref result);
			return result;
		}

		// Token: 0x06045B66 RID: 285542 RVA: 0x011517F0 File Offset: 0x0114F9F0
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

		// Token: 0x06045B67 RID: 285543 RVA: 0x01151810 File Offset: 0x0114FA10
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

		// Token: 0x06045B68 RID: 285544 RVA: 0x01151840 File Offset: 0x0114FA40
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

		// Token: 0x06045B69 RID: 285545 RVA: 0x01151860 File Offset: 0x0114FA60
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

		// Token: 0x06045B6A RID: 285546 RVA: 0x01151890 File Offset: 0x0114FA90
		public void SetUseMouseForTouch(bool value)
		{
			if (this.InputSettingsInstance == null)
			{
				return;
			}
			this.InputSettingsInstance.bUseMouseForTouch = value;
		}

		// Token: 0x06045B6B RID: 285547 RVA: 0x011518A8 File Offset: 0x0114FAA8
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

		// Token: 0x17009B95 RID: 39829
		// (get) Token: 0x06045B6C RID: 285548 RVA: 0x011518FD File Offset: 0x0114FAFD
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

		// Token: 0x06045B6D RID: 285549 RVA: 0x01151920 File Offset: 0x0114FB20
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045B6E RID: 285550 RVA: 0x01151922 File Offset: 0x0114FB22
		public static void ResetStaticDefaultValue()
		{
			InputSettings instance = InputSettings._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputSettings._instance = null;
		}

		// Token: 0x06045B6F RID: 285551 RVA: 0x0115193B File Offset: 0x0114FB3B
		static InputSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettings.CreateStaticDefaultValue), new Action(InputSettings.ResetStaticDefaultValue));
		}

		// Token: 0x040245D5 RID: 148949
		[Nullable(2)]
		private UInputSettings InputSettingsInstance;

		// Token: 0x040245D6 RID: 148950
		private readonly Dictionary<string, InputKey> InputKeyMap = new Dictionary<string, InputKey>();

		// Token: 0x040245D7 RID: 148951
		private readonly Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>> InputActionKeyMappings = new Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputActionKey>>>();

		// Token: 0x040245D8 RID: 148952
		private readonly Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>> InputAxisKeyMappings = new Dictionary<string, Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>>>();

		// Token: 0x040245D9 RID: 148953
		private readonly Dictionary<string, Dictionary<string, List<InputCombinationActionKey>>> InputCombinationActionKeyMappings = new Dictionary<string, Dictionary<string, List<InputCombinationActionKey>>>();

		// Token: 0x040245DA RID: 148954
		private readonly Dictionary<string, Dictionary<string, IList<InputCombinationAxisKey>>> InputCombinationAxisKeyMappings = new Dictionary<string, Dictionary<string, IList<InputCombinationAxisKey>>>();

		// Token: 0x040245DB RID: 148955
		private readonly List<InputActionKey> InputActionKeyPool = new List<InputActionKey>();

		// Token: 0x040245DC RID: 148956
		private readonly List<InputAxisKey> InputAxisKeyPool = new List<InputAxisKey>();

		// Token: 0x040245DD RID: 148957
		[Nullable(2)]
		private static InputSettings _instance;
	}
}
