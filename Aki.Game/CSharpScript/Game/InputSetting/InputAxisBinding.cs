using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.KeySetting;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006166 RID: 24934
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisBinding
	{
		// Token: 0x0603BC38 RID: 244792 RVA: 0x010F6548 File Offset: 0x010F4748
		public void Initialize(AxisMapping config)
		{
			this.AxisName = config.AxisName;
			this.Config = new AxisMapping?(config);
			this.AxisMappingType = (EAxisMappingType)this.Config.Value.AxisType;
			this.CurrentBindingType = (EInputBindingType)config.ExclusiveType;
			this.LastBindingType = (EInputBindingType)config.ExclusiveType;
			for (int i = 0; i < config.KeyboardVersionMapLength; i++)
			{
				DicIntInt? dicIntInt = config.KeyboardVersionMap(i);
				this.KeyboardVersionMap[(EKeySettingExclusiveType)dicIntInt.Value.Key] = dicIntInt.Value.Value;
			}
			for (int j = 0; j < config.GamepadVersionMapLength; j++)
			{
				DicIntInt? dicIntInt2 = config.GamepadVersionMap(j);
				this.GamepadVersionMap[(EKeySettingExclusiveType)dicIntInt2.Value.Key] = dicIntInt2.Value.Value;
			}
		}

		// Token: 0x0603BC39 RID: 244793 RVA: 0x010F662F File Offset: 0x010F482F
		public void Clear()
		{
			this.AxisName = null;
			this.AxisMappingType = EAxisMappingType.None;
			this.Config = null;
			this.PcKeysToBindingTypeMap.Clear();
			this.GamepadKeysToBindingTypeMap.Clear();
		}

		// Token: 0x0603BC3A RID: 244794 RVA: 0x010F6661 File Offset: 0x010F4861
		[NullableContext(2)]
		public string GetAxisName()
		{
			return this.AxisName;
		}

		// Token: 0x0603BC3B RID: 244795 RVA: 0x010F6669 File Offset: 0x010F4869
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x0603BC3C RID: 244796 RVA: 0x010F6678 File Offset: 0x010F4878
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.KeyboardVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BC3D RID: 244797 RVA: 0x010F6698 File Offset: 0x010F4898
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x0603BC3E RID: 244798 RVA: 0x010F66A8 File Offset: 0x010F48A8
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BC3F RID: 244799 RVA: 0x010F66C8 File Offset: 0x010F48C8
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> GetAllInputAxisKeyMap()
		{
			return InputSettings.Instance.GetInputAxisKeyMapByBindingType(this.AxisName);
		}

		// Token: 0x0603BC40 RID: 244800 RVA: 0x010F66DA File Offset: 0x010F48DA
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, InputAxisKey> GetInputAxisKeyMap(EInputBindingType bindingType)
		{
			return InputSettings.Instance.GetInputAxisKeyMap(this.AxisName, bindingType);
		}

		// Token: 0x0603BC41 RID: 244801 RVA: 0x010F66ED File Offset: 0x010F48ED
		[NullableContext(2)]
		public InputAxisKey GetCurrentPlatformKey()
		{
			if (Info.Instance.IsInKeyBoard())
			{
				return this.GetPcKey();
			}
			if (Info.Instance.IsInGamepad())
			{
				return this.GetGamepadKey();
			}
			return null;
		}

		// Token: 0x0603BC42 RID: 244802 RVA: 0x010F6716 File Offset: 0x010F4916
		public void GetCurrentPlatformKeyNameList(List<string> keyListRef)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				this.GetPcKeyNameList(keyListRef);
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				this.GetGamepadKeyNameList(keyListRef);
			}
		}

		// Token: 0x0603BC43 RID: 244803 RVA: 0x010F673F File Offset: 0x010F493F
		public IReadOnlyList<string> GetCurrentPlatformKeyNameList()
		{
			if (Info.Instance.IsInKeyBoard())
			{
				return this.GetPcKeyNameList();
			}
			if (Info.Instance.IsInGamepad())
			{
				return this.GetGamepadKeyNameList();
			}
			return Array.Empty<string>();
		}

		// Token: 0x0603BC44 RID: 244804 RVA: 0x010F676C File Offset: 0x010F496C
		[NullableContext(2)]
		public InputAxisKey GetCurrentPlatformKeyByIndex(int index)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				return this.GetPcKeyByIndex(index);
			}
			if (Info.Instance.IsInGamepad())
			{
				return this.GetGamepadKeyByIndex(index);
			}
			return null;
		}

		// Token: 0x0603BC45 RID: 244805 RVA: 0x010F6797 File Offset: 0x010F4997
		[NullableContext(2)]
		public InputAxisKey GetPcKeyByIndex(int index)
		{
			if (index >= this.PcKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputAxisKey(this.AxisName, this.PcKeys[index], this.CurrentBindingType);
		}

		// Token: 0x0603BC46 RID: 244806 RVA: 0x010F67CC File Offset: 0x010F49CC
		[NullableContext(2)]
		public InputAxisKey GetPcKey()
		{
			int num = 0;
			if (num >= this.PcKeys.Count)
			{
				return null;
			}
			string keyName = this.PcKeys[num];
			return InputSettings.Instance.GetInputAxisKey(this.AxisName, keyName, this.CurrentBindingType);
		}

		// Token: 0x0603BC47 RID: 244807 RVA: 0x010F6811 File Offset: 0x010F4A11
		[NullableContext(2)]
		public InputAxisKey GetGamepadKeyByIndex(int index)
		{
			if (index >= this.GamepadKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputAxisKey(this.AxisName, this.GamepadKeys[index], this.CurrentBindingType);
		}

		// Token: 0x0603BC48 RID: 244808 RVA: 0x010F6848 File Offset: 0x010F4A48
		[NullableContext(2)]
		public InputAxisKey GetGamepadKey()
		{
			int num = 0;
			if (num >= this.GamepadKeys.Count)
			{
				return null;
			}
			string keyName = this.GamepadKeys[num];
			return InputSettings.Instance.GetInputAxisKey(this.AxisName, keyName, this.CurrentBindingType);
		}

		// Token: 0x0603BC49 RID: 244809 RVA: 0x010F6890 File Offset: 0x010F4A90
		public void GetPcKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.PcKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC4A RID: 244810 RVA: 0x010F68E4 File Offset: 0x010F4AE4
		public IReadOnlyList<string> GetPcKeyNameList()
		{
			return this.PcKeys;
		}

		// Token: 0x0603BC4B RID: 244811 RVA: 0x010F68EC File Offset: 0x010F4AEC
		public void GetPcKeyNameMapByBindingType(Dictionary<string, float> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = null;
			if (!this.PcKeysToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, float>();
			}
			foreach (KeyValuePair<string, float> keyValuePair in dictionary)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BC4C RID: 244812 RVA: 0x010F6960 File Offset: 0x010F4B60
		public void GetGamepadKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.GamepadKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC4D RID: 244813 RVA: 0x010F69B4 File Offset: 0x010F4BB4
		public IReadOnlyList<string> GetGamepadKeyNameList()
		{
			return this.GamepadKeys;
		}

		// Token: 0x0603BC4E RID: 244814 RVA: 0x010F69BC File Offset: 0x010F4BBC
		public void GetGamepadKeyNameMapByBindingType(Dictionary<string, float> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, float> items;
			if (this.GamepadKeysToBindingTypeMap.TryGetValue(bindingType, out items))
			{
				keyMapRef.AddRange(items);
			}
		}

		// Token: 0x0603BC4F RID: 244815 RVA: 0x010F69E0 File Offset: 0x010F4BE0
		public void GetAllPcKeyScaleMap(Dictionary<EInputBindingType, Dictionary<string, float>> keyMapRef)
		{
			keyMapRef.AddRange(this.PcKeysToBindingTypeMap);
		}

		// Token: 0x0603BC50 RID: 244816 RVA: 0x010F69EE File Offset: 0x010F4BEE
		public IReadOnlyDictionary<EInputBindingType, Dictionary<string, float>> GetAllPcKeyScaleMap()
		{
			return this.PcKeysToBindingTypeMap;
		}

		// Token: 0x0603BC51 RID: 244817 RVA: 0x010F69F8 File Offset: 0x010F4BF8
		public Dictionary<string, float> GetPcKeyScaleMap(Dictionary<string, float> keyScaleMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = null;
			if (!this.PcKeysToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, float>();
			}
			foreach (KeyValuePair<string, float> keyValuePair in dictionary)
			{
				keyScaleMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
			return keyScaleMapRef;
		}

		// Token: 0x0603BC52 RID: 244818 RVA: 0x010F6A6C File Offset: 0x010F4C6C
		public void GetAllGamepadKeyScaleMap(Dictionary<EInputBindingType, Dictionary<string, float>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, float>> keyValuePair in this.GamepadKeysToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BC53 RID: 244819 RVA: 0x010F6ACC File Offset: 0x010F4CCC
		public IReadOnlyDictionary<EInputBindingType, Dictionary<string, float>> GetAllGamepadKeyScaleMap()
		{
			return this.GamepadKeysToBindingTypeMap;
		}

		// Token: 0x0603BC54 RID: 244820 RVA: 0x010F6AD4 File Offset: 0x010F4CD4
		public Dictionary<string, float> GetGamepadKeyScaleMap(Dictionary<string, float> keyScaleMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = null;
			if (!this.GamepadKeysToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, float>();
			}
			foreach (KeyValuePair<string, float> keyValuePair in dictionary)
			{
				keyScaleMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
			return keyScaleMapRef;
		}

		// Token: 0x0603BC55 RID: 244821 RVA: 0x010F6B48 File Offset: 0x010F4D48
		public void GetKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.KeyNameList)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC56 RID: 244822 RVA: 0x010F6B9C File Offset: 0x010F4D9C
		public void GetKeyNameListByBindingType(List<string> keyListRef, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = null;
			if (!this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, float>();
			}
			foreach (string item in dictionary.Keys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC57 RID: 244823 RVA: 0x010F6C08 File Offset: 0x010F4E08
		public bool HasKey(string keyName)
		{
			Dictionary<string, InputAxisKey> inputAxisKeyMap = InputSettings.Instance.GetInputAxisKeyMap(this.AxisName, this.CurrentBindingType);
			return inputAxisKeyMap != null && inputAxisKeyMap.ContainsKey(keyName);
		}

		// Token: 0x0603BC58 RID: 244824 RVA: 0x010F6C38 File Offset: 0x010F4E38
		public bool HasAnyKey()
		{
			return this.KeyNameList.Count > 0;
		}

		// Token: 0x0603BC59 RID: 244825 RVA: 0x010F6C48 File Offset: 0x010F4E48
		public InputAxisKey[] GetKey(float axisValue, EInputBindingType bindingType)
		{
			List<InputAxisKey> list = new List<InputAxisKey>();
			Dictionary<string, InputAxisKey> inputAxisKeyMap = InputSettings.Instance.GetInputAxisKeyMap(this.AxisName, bindingType);
			if (inputAxisKeyMap == null)
			{
				return new InputAxisKey[0];
			}
			foreach (InputAxisKey inputAxisKey in inputAxisKeyMap.Values)
			{
				if (inputAxisKey.Scale == axisValue)
				{
					list.Add(inputAxisKey);
				}
			}
			InputAxisKey[] array = new InputAxisKey[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}

		// Token: 0x0603BC5A RID: 244826 RVA: 0x010F6CF8 File Offset: 0x010F4EF8
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = null;
			if (!this.PcKeysToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				this.PcKeysToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary);
			}
			Dictionary<string, float> dictionary2 = null;
			if (!this.GamepadKeysToBindingTypeMap.TryGetValue(bindingType, out dictionary2))
			{
				this.GamepadKeysToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary2);
			}
			Dictionary<string, float> dictionary3 = new Dictionary<string, float>();
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, float> keyValuePair in dictionary)
				{
					dictionary3[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			if (dictionary2 != null)
			{
				foreach (KeyValuePair<string, float> keyValuePair2 in dictionary2)
				{
					dictionary3[keyValuePair2.Key] = keyValuePair2.Value;
				}
			}
			if (dictionary3.Count > 0)
			{
				this.CurrentBindingType = bindingType;
				this.SetKeys(dictionary3, bindingType);
				this.LastBindingType = this.CurrentBindingType;
			}
		}

		// Token: 0x0603BC5B RID: 244827 RVA: 0x010F6E14 File Offset: 0x010F5014
		public void SetKeys(Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
		{
			this.KeyNameListToBindingTypeMap[bindingType] = keyScaleMap;
			if (this.CurrentBindingType == bindingType)
			{
				InputSettings.Instance.SetAxisMapping(this.AxisName, keyScaleMap, this.LastBindingType, bindingType);
				List<string> list = new List<string>();
				foreach (string item in keyScaleMap.Keys)
				{
					list.Add(item);
				}
				this.KeyNameList = list;
				this.RefreshKeyList();
				return;
			}
			InputSettings.Instance.SetAxisMappingWithoutInputSettings(this.AxisName, keyScaleMap, bindingType);
			this.RefreshKeyListByBindingType(bindingType);
		}

		// Token: 0x0603BC5C RID: 244828 RVA: 0x010F6EC4 File Offset: 0x010F50C4
		public void SetAllKeys(Dictionary<string, float> keyScaleMap)
		{
			foreach (EInputBindingType bindingType in this.KeyNameListToBindingTypeMap.Keys)
			{
				this.SetKeys(keyScaleMap, bindingType);
			}
		}

		// Token: 0x0603BC5D RID: 244829 RVA: 0x010F6F20 File Offset: 0x010F5120
		public void SetKeyboardKeys(Dictionary<string, float> keyboardScaleMap, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = new Dictionary<string, float>();
			foreach (KeyValuePair<string, float> keyValuePair in keyboardScaleMap)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			this.GetGamepadKeyScaleMap(dictionary, bindingType);
			this.SetKeys(dictionary, bindingType);
		}

		// Token: 0x0603BC5E RID: 244830 RVA: 0x010F6F94 File Offset: 0x010F5194
		public void SetKeyboardKeysWithoutOriginal(Dictionary<string, float> keyboardScaleMap)
		{
			for (int i = 0; i < InputBindingDefine.inputBindingTypesArray.Length; i++)
			{
				EInputBindingType einputBindingType = InputBindingDefine.inputBindingTypesArray[i];
				if (einputBindingType != EInputBindingType.Original)
				{
					this.SetKeyboardKeys(keyboardScaleMap, einputBindingType);
				}
			}
		}

		// Token: 0x0603BC5F RID: 244831 RVA: 0x010F6FC8 File Offset: 0x010F51C8
		public void SetGamepadKeys(Dictionary<string, float> gamepadScaleMap, EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = new Dictionary<string, float>();
			foreach (KeyValuePair<string, float> keyValuePair in gamepadScaleMap)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			this.GetPcKeyScaleMap(dictionary, bindingType);
			this.SetKeys(dictionary, bindingType);
		}

		// Token: 0x0603BC60 RID: 244832 RVA: 0x010F703C File Offset: 0x010F523C
		public void SetGamepadKeysWithoutOriginal(Dictionary<string, float> gamepadScaleMap)
		{
			foreach (EInputBindingType einputBindingType in this.PcKeysToBindingTypeMap.Keys)
			{
				if (einputBindingType != EInputBindingType.Original)
				{
					this.SetGamepadKeys(gamepadScaleMap, einputBindingType);
				}
			}
		}

		// Token: 0x0603BC61 RID: 244833 RVA: 0x010F7098 File Offset: 0x010F5298
		public void RefreshKeys(TArray<FInputAxisKeyMapping> axisMappings, EInputBindingType bindingType)
		{
			Dictionary<string, float> orCreateKeyNameMap = this.GetOrCreateKeyNameMap(bindingType);
			orCreateKeyNameMap.Clear();
			for (int i = axisMappings.Num() - 1; i >= 0; i--)
			{
				FInputAxisKeyMapping finputAxisKeyMapping = axisMappings.Get(i);
				string key = finputAxisKeyMapping.Key.KeyName.ToString();
				orCreateKeyNameMap[key] = finputAxisKeyMapping.Scale;
			}
			if (this.CurrentBindingType == bindingType)
			{
				List<string> list = new List<string>();
				foreach (string item in orCreateKeyNameMap.Keys)
				{
					list.Add(item);
				}
				this.KeyNameList = list;
				this.RefreshKeyList();
				EventSystem.Instance.Emit<string>(EEventName.OnAxisKeyChanged, this.AxisName);
				return;
			}
			this.RefreshKeyListByBindingType(bindingType);
		}

		// Token: 0x0603BC62 RID: 244834 RVA: 0x010F717C File Offset: 0x010F537C
		public void ClearAllKeys()
		{
			if (this.PcKeys != null)
			{
				this.PcKeys.Clear();
			}
			if (this.GamepadKeys != null)
			{
				this.GamepadKeys.Clear();
			}
			if (this.KeyNameList != null)
			{
				this.KeyNameList.Clear();
			}
			InputSettings.Instance.ClearAxisMapping(this.AxisName);
		}

		// Token: 0x0603BC63 RID: 244835 RVA: 0x010F71D4 File Offset: 0x010F53D4
		public void ResetKeyStateToConfigBaseline()
		{
			this.PcKeys.Clear();
			this.GamepadKeys.Clear();
			this.KeyNameList.Clear();
			this.KeyNameListToBindingTypeMap.Clear();
			this.PcKeysToBindingTypeMap.Clear();
			this.GamepadKeysToBindingTypeMap.Clear();
			this.CurrentBindingType = (EInputBindingType)((this.Config != null) ? this.Config.Value.ExclusiveType : 0);
			this.LastBindingType = this.CurrentBindingType;
			this.ResetVersionMapsFromConfig();
			InputSettings.Instance.ClearAxisMapping(this.AxisName);
		}

		// Token: 0x0603BC64 RID: 244836 RVA: 0x010F7270 File Offset: 0x010F5470
		public void ResetVersionMapsFromConfig()
		{
			this.KeyboardVersionMap.Clear();
			this.GamepadVersionMap.Clear();
			if (this.Config == null)
			{
				return;
			}
			AxisMapping value = this.Config.Value;
			for (int i = 0; i < value.KeyboardVersionMapLength; i++)
			{
				DicIntInt? dicIntInt = value.KeyboardVersionMap(i);
				this.KeyboardVersionMap[(EKeySettingExclusiveType)dicIntInt.Value.Key] = dicIntInt.Value.Value;
			}
			for (int j = 0; j < value.GamepadVersionMapLength; j++)
			{
				DicIntInt? dicIntInt2 = value.GamepadVersionMap(j);
				this.GamepadVersionMap[(EKeySettingExclusiveType)dicIntInt2.Value.Key] = dicIntInt2.Value.Value;
			}
		}

		// Token: 0x0603BC65 RID: 244837 RVA: 0x010F733B File Offset: 0x010F553B
		public AxisMapping? GetAxisMappingConfig()
		{
			return this.Config;
		}

		// Token: 0x0603BC66 RID: 244838 RVA: 0x010F7343 File Offset: 0x010F5543
		public EAxisMappingType GetAxisMappingType()
		{
			return this.AxisMappingType;
		}

		// Token: 0x0603BC67 RID: 244839 RVA: 0x010F734B File Offset: 0x010F554B
		public Dictionary<EInputBindingType, Dictionary<string, float>> GetKeyNameListToBindingTypeMap()
		{
			return this.KeyNameListToBindingTypeMap;
		}

		// Token: 0x0603BC68 RID: 244840 RVA: 0x010F7354 File Offset: 0x010F5554
		public Dictionary<EInputBindingType, Dictionary<string, float>> GetCopyKeyNameListToBindingTypeMap()
		{
			Dictionary<EInputBindingType, Dictionary<string, float>> dictionary = new Dictionary<EInputBindingType, Dictionary<string, float>>();
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, float>> keyValuePair in this.KeyNameListToBindingTypeMap)
			{
				Dictionary<string, float> dictionary2 = new Dictionary<string, float>();
				foreach (KeyValuePair<string, float> keyValuePair2 in keyValuePair.Value)
				{
					dictionary2[keyValuePair2.Key] = keyValuePair2.Value;
				}
				dictionary[keyValuePair.Key] = dictionary2;
			}
			return dictionary;
		}

		// Token: 0x0603BC69 RID: 244841 RVA: 0x010F7410 File Offset: 0x010F5610
		private void RefreshKeyListByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary = new Dictionary<string, float>();
			Dictionary<string, float> dictionary2 = new Dictionary<string, float>();
			Dictionary<string, float> dictionary3 = null;
			if (!this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out dictionary3))
			{
				return;
			}
			foreach (KeyValuePair<string, float> keyValuePair in dictionary3)
			{
				string key = keyValuePair.Key;
				float value = keyValuePair.Value;
				InputKey key2 = InputSettings.Instance.GetKey(key);
				if (key2 != null)
				{
					if (key2.IsKeyboardKey || key2.IsMouseButton)
					{
						dictionary[key] = value;
					}
					else if (key2.IsGamepadKey)
					{
						dictionary2[key] = value;
					}
					else if (key2.IsPcPsTouchPadKey)
					{
						dictionary2[key] = value;
					}
				}
			}
			Dictionary<string, float> dictionary4;
			if (!this.PcKeysToBindingTypeMap.ContainsKey(bindingType) && dictionary.Count == 0 && this.PcKeysToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary4))
			{
				dictionary = new Dictionary<string, float>(dictionary4);
			}
			Dictionary<string, float> dictionary5;
			if (!this.GamepadKeysToBindingTypeMap.ContainsKey(bindingType) && dictionary2.Count == 0 && this.GamepadKeysToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary5))
			{
				dictionary2 = new Dictionary<string, float>(dictionary5);
			}
			if (this.CurrentBindingType == bindingType)
			{
				this.PcKeys.Clear();
				foreach (string item in dictionary.Keys)
				{
					this.PcKeys.Add(item);
				}
				this.GamepadKeys.Clear();
				foreach (string item2 in dictionary2.Keys)
				{
					this.GamepadKeys.Add(item2);
				}
			}
			this.PcKeysToBindingTypeMap[bindingType] = dictionary;
			this.GamepadKeysToBindingTypeMap[bindingType] = dictionary2;
		}

		// Token: 0x0603BC6A RID: 244842 RVA: 0x010F7610 File Offset: 0x010F5810
		private void RefreshKeyList()
		{
			this.RefreshKeyListByBindingType(this.CurrentBindingType);
		}

		// Token: 0x0603BC6B RID: 244843 RVA: 0x010F7620 File Offset: 0x010F5820
		private Dictionary<string, float> GetOrCreateKeyNameMap(EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary;
			if (!this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, float>();
				this.KeyNameListToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x0401F858 RID: 129112
		[Nullable(2)]
		private string AxisName;

		// Token: 0x0401F859 RID: 129113
		private AxisMapping? Config;

		// Token: 0x0401F85A RID: 129114
		private EAxisMappingType AxisMappingType;

		// Token: 0x0401F85B RID: 129115
		private readonly List<string> PcKeys = new List<string>();

		// Token: 0x0401F85C RID: 129116
		private readonly List<string> GamepadKeys = new List<string>();

		// Token: 0x0401F85D RID: 129117
		private List<string> KeyNameList = new List<string>();

		// Token: 0x0401F85E RID: 129118
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F85F RID: 129119
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F860 RID: 129120
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> KeyNameListToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x0401F861 RID: 129121
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> PcKeysToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x0401F862 RID: 129122
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> GamepadKeysToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x0401F863 RID: 129123
		private EInputBindingType LastBindingType;

		// Token: 0x0401F864 RID: 129124
		private EInputBindingType CurrentBindingType;
	}
}
