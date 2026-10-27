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
	// Token: 0x02006FE5 RID: 28645
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisBinding
	{
		// Token: 0x06045A87 RID: 285319 RVA: 0x0114C754 File Offset: 0x0114A954
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

		// Token: 0x06045A88 RID: 285320 RVA: 0x0114C83B File Offset: 0x0114AA3B
		public void Clear()
		{
			this.AxisName = null;
			this.AxisMappingType = EAxisMappingType.None;
			this.Config = null;
			this.PcKeysToBindingTypeMap.Clear();
			this.GamepadKeysToBindingTypeMap.Clear();
		}

		// Token: 0x06045A89 RID: 285321 RVA: 0x0114C86D File Offset: 0x0114AA6D
		[NullableContext(2)]
		public string GetAxisName()
		{
			return this.AxisName;
		}

		// Token: 0x06045A8A RID: 285322 RVA: 0x0114C875 File Offset: 0x0114AA75
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x06045A8B RID: 285323 RVA: 0x0114C884 File Offset: 0x0114AA84
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.KeyboardVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045A8C RID: 285324 RVA: 0x0114C8A4 File Offset: 0x0114AAA4
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x06045A8D RID: 285325 RVA: 0x0114C8B4 File Offset: 0x0114AAB4
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045A8E RID: 285326 RVA: 0x0114C8D4 File Offset: 0x0114AAD4
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

		// Token: 0x06045A8F RID: 285327 RVA: 0x0114C8E6 File Offset: 0x0114AAE6
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

		// Token: 0x06045A90 RID: 285328 RVA: 0x0114C8F9 File Offset: 0x0114AAF9
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

		// Token: 0x06045A91 RID: 285329 RVA: 0x0114C922 File Offset: 0x0114AB22
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

		// Token: 0x06045A92 RID: 285330 RVA: 0x0114C94B File Offset: 0x0114AB4B
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

		// Token: 0x06045A93 RID: 285331 RVA: 0x0114C978 File Offset: 0x0114AB78
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

		// Token: 0x06045A94 RID: 285332 RVA: 0x0114C9A3 File Offset: 0x0114ABA3
		[NullableContext(2)]
		public InputAxisKey GetPcKeyByIndex(int index)
		{
			if (index >= this.PcKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputAxisKey(this.AxisName, this.PcKeys[index], this.CurrentBindingType);
		}

		// Token: 0x06045A95 RID: 285333 RVA: 0x0114C9D8 File Offset: 0x0114ABD8
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

		// Token: 0x06045A96 RID: 285334 RVA: 0x0114CA1D File Offset: 0x0114AC1D
		[NullableContext(2)]
		public InputAxisKey GetGamepadKeyByIndex(int index)
		{
			if (index >= this.GamepadKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputAxisKey(this.AxisName, this.GamepadKeys[index], this.CurrentBindingType);
		}

		// Token: 0x06045A97 RID: 285335 RVA: 0x0114CA54 File Offset: 0x0114AC54
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

		// Token: 0x06045A98 RID: 285336 RVA: 0x0114CA9C File Offset: 0x0114AC9C
		public void GetPcKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.PcKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x06045A99 RID: 285337 RVA: 0x0114CAF0 File Offset: 0x0114ACF0
		public IReadOnlyList<string> GetPcKeyNameList()
		{
			return this.PcKeys;
		}

		// Token: 0x06045A9A RID: 285338 RVA: 0x0114CAF8 File Offset: 0x0114ACF8
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

		// Token: 0x06045A9B RID: 285339 RVA: 0x0114CB6C File Offset: 0x0114AD6C
		public void GetGamepadKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.GamepadKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x06045A9C RID: 285340 RVA: 0x0114CBC0 File Offset: 0x0114ADC0
		public IReadOnlyList<string> GetGamepadKeyNameList()
		{
			return this.GamepadKeys;
		}

		// Token: 0x06045A9D RID: 285341 RVA: 0x0114CBC8 File Offset: 0x0114ADC8
		public void GetGamepadKeyNameMapByBindingType(Dictionary<string, float> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, float> items;
			if (this.GamepadKeysToBindingTypeMap.TryGetValue(bindingType, out items))
			{
				keyMapRef.AddRange(items);
			}
		}

		// Token: 0x06045A9E RID: 285342 RVA: 0x0114CBEC File Offset: 0x0114ADEC
		public void GetAllPcKeyScaleMap(Dictionary<EInputBindingType, Dictionary<string, float>> keyMapRef)
		{
			keyMapRef.AddRange(this.PcKeysToBindingTypeMap);
		}

		// Token: 0x06045A9F RID: 285343 RVA: 0x0114CBFA File Offset: 0x0114ADFA
		public IReadOnlyDictionary<EInputBindingType, Dictionary<string, float>> GetAllPcKeyScaleMap()
		{
			return this.PcKeysToBindingTypeMap;
		}

		// Token: 0x06045AA0 RID: 285344 RVA: 0x0114CC04 File Offset: 0x0114AE04
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

		// Token: 0x06045AA1 RID: 285345 RVA: 0x0114CC78 File Offset: 0x0114AE78
		public void GetAllGamepadKeyScaleMap(Dictionary<EInputBindingType, Dictionary<string, float>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, float>> keyValuePair in this.GamepadKeysToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045AA2 RID: 285346 RVA: 0x0114CCD8 File Offset: 0x0114AED8
		public IReadOnlyDictionary<EInputBindingType, Dictionary<string, float>> GetAllGamepadKeyScaleMap()
		{
			return this.GamepadKeysToBindingTypeMap;
		}

		// Token: 0x06045AA3 RID: 285347 RVA: 0x0114CCE0 File Offset: 0x0114AEE0
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

		// Token: 0x06045AA4 RID: 285348 RVA: 0x0114CD54 File Offset: 0x0114AF54
		public void GetKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.KeyNameList)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x06045AA5 RID: 285349 RVA: 0x0114CDA8 File Offset: 0x0114AFA8
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

		// Token: 0x06045AA6 RID: 285350 RVA: 0x0114CE14 File Offset: 0x0114B014
		public bool HasKey(string keyName)
		{
			Dictionary<string, InputAxisKey> inputAxisKeyMap = InputSettings.Instance.GetInputAxisKeyMap(this.AxisName, this.CurrentBindingType);
			return inputAxisKeyMap != null && inputAxisKeyMap.ContainsKey(keyName);
		}

		// Token: 0x06045AA7 RID: 285351 RVA: 0x0114CE44 File Offset: 0x0114B044
		public bool HasAnyKey()
		{
			return this.KeyNameList.Count > 0;
		}

		// Token: 0x06045AA8 RID: 285352 RVA: 0x0114CE54 File Offset: 0x0114B054
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

		// Token: 0x06045AA9 RID: 285353 RVA: 0x0114CF04 File Offset: 0x0114B104
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

		// Token: 0x06045AAA RID: 285354 RVA: 0x0114D020 File Offset: 0x0114B220
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

		// Token: 0x06045AAB RID: 285355 RVA: 0x0114D0D0 File Offset: 0x0114B2D0
		public void SetAllKeys(Dictionary<string, float> keyScaleMap)
		{
			foreach (EInputBindingType bindingType in this.KeyNameListToBindingTypeMap.Keys)
			{
				this.SetKeys(keyScaleMap, bindingType);
			}
		}

		// Token: 0x06045AAC RID: 285356 RVA: 0x0114D12C File Offset: 0x0114B32C
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

		// Token: 0x06045AAD RID: 285357 RVA: 0x0114D1A0 File Offset: 0x0114B3A0
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

		// Token: 0x06045AAE RID: 285358 RVA: 0x0114D1D4 File Offset: 0x0114B3D4
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

		// Token: 0x06045AAF RID: 285359 RVA: 0x0114D248 File Offset: 0x0114B448
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

		// Token: 0x06045AB0 RID: 285360 RVA: 0x0114D2A4 File Offset: 0x0114B4A4
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

		// Token: 0x06045AB1 RID: 285361 RVA: 0x0114D388 File Offset: 0x0114B588
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

		// Token: 0x06045AB2 RID: 285362 RVA: 0x0114D3E0 File Offset: 0x0114B5E0
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

		// Token: 0x06045AB3 RID: 285363 RVA: 0x0114D47C File Offset: 0x0114B67C
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

		// Token: 0x06045AB4 RID: 285364 RVA: 0x0114D547 File Offset: 0x0114B747
		public AxisMapping? GetAxisMappingConfig()
		{
			return this.Config;
		}

		// Token: 0x06045AB5 RID: 285365 RVA: 0x0114D54F File Offset: 0x0114B74F
		public EAxisMappingType GetAxisMappingType()
		{
			return this.AxisMappingType;
		}

		// Token: 0x06045AB6 RID: 285366 RVA: 0x0114D557 File Offset: 0x0114B757
		public Dictionary<EInputBindingType, Dictionary<string, float>> GetKeyNameListToBindingTypeMap()
		{
			return this.KeyNameListToBindingTypeMap;
		}

		// Token: 0x06045AB7 RID: 285367 RVA: 0x0114D560 File Offset: 0x0114B760
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

		// Token: 0x06045AB8 RID: 285368 RVA: 0x0114D61C File Offset: 0x0114B81C
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

		// Token: 0x06045AB9 RID: 285369 RVA: 0x0114D81C File Offset: 0x0114BA1C
		private void RefreshKeyList()
		{
			this.RefreshKeyListByBindingType(this.CurrentBindingType);
		}

		// Token: 0x06045ABA RID: 285370 RVA: 0x0114D82C File Offset: 0x0114BA2C
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

		// Token: 0x040245A3 RID: 148899
		[Nullable(2)]
		private string AxisName;

		// Token: 0x040245A4 RID: 148900
		private AxisMapping? Config;

		// Token: 0x040245A5 RID: 148901
		private EAxisMappingType AxisMappingType;

		// Token: 0x040245A6 RID: 148902
		private readonly List<string> PcKeys = new List<string>();

		// Token: 0x040245A7 RID: 148903
		private readonly List<string> GamepadKeys = new List<string>();

		// Token: 0x040245A8 RID: 148904
		private List<string> KeyNameList = new List<string>();

		// Token: 0x040245A9 RID: 148905
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x040245AA RID: 148906
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x040245AB RID: 148907
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> KeyNameListToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x040245AC RID: 148908
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> PcKeysToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x040245AD RID: 148909
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> GamepadKeysToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x040245AE RID: 148910
		private EInputBindingType LastBindingType;

		// Token: 0x040245AF RID: 148911
		private EInputBindingType CurrentBindingType;
	}
}
