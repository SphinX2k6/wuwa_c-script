using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FE8 RID: 28648
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationActionBinding
	{
		// Token: 0x06045ABD RID: 285373 RVA: 0x0114D8DC File Offset: 0x0114BADC
		private void InitBindingTypeDataByCombinationAction(string actionName)
		{
			CombinationAction? combinationActionConfigByActionName = InputSettingsConfig.Instance.GetCombinationActionConfigByActionName(actionName);
			if (combinationActionConfigByActionName == null)
			{
				return;
			}
			this.ConfigBindingType = (EInputBindingType)combinationActionConfigByActionName.Value.ExclusiveType;
			this.CurrentBindingType = (EInputBindingType)combinationActionConfigByActionName.Value.ExclusiveType;
			for (int i = 0; i < combinationActionConfigByActionName.Value.BlockInputLength; i++)
			{
				this.BlockInputKeySet.Add(combinationActionConfigByActionName.Value.BlockInput(i));
			}
			if (this.ConfigBindingType == EInputBindingType.Original)
			{
				for (int j = 0; j < InputBindingDefine.inputBindingTypesArray.Length; j++)
				{
					EInputBindingType key = InputBindingDefine.inputBindingTypesArray[j];
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
					Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
					for (int k = 0; k < combinationActionConfigByActionName.Value.PcKeysLength; k++)
					{
						DicStringString? dicStringString = combinationActionConfigByActionName.Value.PcKeys(k);
						string key2 = dicStringString.Value.Key;
						string value = dicStringString.Value.Value;
						dictionary[key2] = value;
						dictionary3[key2] = value;
					}
					this.PcKeysMapToBindingTypeMap[key] = dictionary;
					for (int l = 0; l < combinationActionConfigByActionName.Value.GamepadKeysLength; l++)
					{
						DicStringString? dicStringString2 = combinationActionConfigByActionName.Value.GamepadKeys(l);
						string key3 = dicStringString2.Value.Key;
						string value2 = dicStringString2.Value.Value;
						dictionary2[key3] = value2;
						dictionary3[key3] = value2;
					}
					this.GamepadKeysMapToBindingTypeMap[key] = dictionary2;
					this.KeyMapToBindingTypeMap[key] = dictionary3;
				}
				return;
			}
			Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
			Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
			Dictionary<string, string> dictionary6 = new Dictionary<string, string>();
			for (int m = 0; m < combinationActionConfigByActionName.Value.PcKeysLength; m++)
			{
				DicStringString? dicStringString3 = combinationActionConfigByActionName.Value.PcKeys(m);
				string key4 = dicStringString3.Value.Key;
				string value3 = dicStringString3.Value.Value;
				dictionary4[key4] = value3;
				dictionary6[key4] = value3;
			}
			this.PcKeysMapToBindingTypeMap[this.ConfigBindingType] = dictionary4;
			for (int n = 0; n < combinationActionConfigByActionName.Value.GamepadKeysLength; n++)
			{
				DicStringString? dicStringString4 = combinationActionConfigByActionName.Value.GamepadKeys(n);
				string key5 = dicStringString4.Value.Key;
				string value4 = dicStringString4.Value.Value;
				dictionary5[key5] = value4;
				dictionary6[key5] = value4;
			}
			this.GamepadKeysMapToBindingTypeMap[this.ConfigBindingType] = dictionary5;
			this.KeyMapToBindingTypeMap[this.ConfigBindingType] = dictionary6;
		}

		// Token: 0x06045ABE RID: 285374 RVA: 0x0114DBC8 File Offset: 0x0114BDC8
		private void InitBindingTypeDataByAction(string actionName)
		{
			ActionMapping? actionMappingConfigByActionName = InputSettingsConfig.Instance.GetActionMappingConfigByActionName(actionName);
			this.ConfigBindingType = (EInputBindingType)((actionMappingConfigByActionName != null) ? actionMappingConfigByActionName.Value.ExclusiveType : 0);
			this.CurrentBindingType = (EInputBindingType)((actionMappingConfigByActionName != null) ? actionMappingConfigByActionName.Value.ExclusiveType : 0);
			if (this.ConfigBindingType == EInputBindingType.Original)
			{
				for (int i = 0; i < InputBindingDefine.inputBindingTypesArray.Length; i++)
				{
					EInputBindingType key = InputBindingDefine.inputBindingTypesArray[i];
					this.PcKeysMapToBindingTypeMap[key] = new Dictionary<string, string>();
					this.GamepadKeysMapToBindingTypeMap[key] = new Dictionary<string, string>();
					this.KeyMapToBindingTypeMap[key] = new Dictionary<string, string>();
				}
				return;
			}
			this.PcKeysMapToBindingTypeMap[this.ConfigBindingType] = new Dictionary<string, string>();
			this.GamepadKeysMapToBindingTypeMap[this.ConfigBindingType] = new Dictionary<string, string>();
			this.KeyMapToBindingTypeMap[this.ConfigBindingType] = new Dictionary<string, string>();
		}

		// Token: 0x06045ABF RID: 285375 RVA: 0x0114DCBB File Offset: 0x0114BEBB
		public void Initialize(string actionName, int secondaryKeyValidTime, bool isOriginalCombinationAction)
		{
			this.ActionName = actionName;
			this.SecondaryKeyValidTime = (float)secondaryKeyValidTime;
			if (isOriginalCombinationAction)
			{
				this.InitBindingTypeDataByCombinationAction(actionName);
				return;
			}
			this.InitBindingTypeDataByAction(actionName);
		}

		// Token: 0x06045AC0 RID: 285376 RVA: 0x0114DCDE File Offset: 0x0114BEDE
		public void InitializeBindingType(EInputBindingType bindingType)
		{
			this.CurrentBindingType = bindingType;
		}

		// Token: 0x06045AC1 RID: 285377 RVA: 0x0114DCE8 File Offset: 0x0114BEE8
		public void Clear()
		{
			this.PcKeyMap.Clear();
			this.GamepadKeyMap.Clear();
			this.KeyMap.Clear();
			this.ActionName = null;
			this.KeyMapToBindingTypeMap.Clear();
			this.PcKeysMapToBindingTypeMap.Clear();
			this.GamepadKeysMapToBindingTypeMap.Clear();
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x06045AC2 RID: 285378 RVA: 0x0114DD49 File Offset: 0x0114BF49
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x06045AC3 RID: 285379 RVA: 0x0114DD54 File Offset: 0x0114BF54
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary = null;
			Dictionary<string, string> dictionary2;
			if (this.PcKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary2))
			{
				dictionary = dictionary2;
			}
			Dictionary<string, string> dictionary3;
			if (dictionary == null && this.PcKeysMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary3))
			{
				dictionary = dictionary3;
			}
			Dictionary<string, string> dictionary4 = null;
			Dictionary<string, string> dictionary5;
			if (this.GamepadKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary5))
			{
				dictionary4 = dictionary5;
			}
			Dictionary<string, string> dictionary6;
			if (dictionary4 == null && this.GamepadKeysMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary6))
			{
				dictionary4 = dictionary6;
			}
			Dictionary<string, string> dictionary7 = new Dictionary<string, string>();
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in dictionary)
				{
					string key = keyValuePair.Key;
					string value = keyValuePair.Value;
					dictionary7[key] = value;
				}
			}
			if (dictionary4 != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair2 in dictionary4)
				{
					string key2 = keyValuePair2.Key;
					string value2 = keyValuePair2.Value;
					dictionary7[key2] = value2;
				}
			}
			if (dictionary7 != null)
			{
				this.CurrentBindingType = bindingType;
				this.KeyMap.Clear();
				this.PcKeyMap.Clear();
				this.GamepadKeyMap.Clear();
				foreach (KeyValuePair<string, string> keyValuePair3 in dictionary7)
				{
					string key3 = keyValuePair3.Key;
					string value3 = keyValuePair3.Value;
					this.AddKey(key3, value3, bindingType);
				}
			}
		}

		// Token: 0x06045AC4 RID: 285380 RVA: 0x0114DEF4 File Offset: 0x0114C0F4
		public void AddKey(string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			this.GetOrCreateKeyMap(bindingType)[mainKeyName] = secondaryKeyName;
			if (this.CurrentBindingType == bindingType)
			{
				this.KeyMap[mainKeyName] = secondaryKeyName;
			}
			InputKey key = InputSettings.Instance.GetKey(mainKeyName);
			if (key == null)
			{
				return;
			}
			if (key.IsKeyboardKey || key.IsMouseButton)
			{
				this.GetOrCreatePcKeyMap(bindingType)[mainKeyName] = secondaryKeyName;
				if (this.CurrentBindingType == bindingType)
				{
					this.PcKeyMap[mainKeyName] = secondaryKeyName;
				}
			}
			if (key.IsGamepadKey)
			{
				this.GetOrCreateGamepadKeyMap(bindingType)[mainKeyName] = secondaryKeyName;
				if (this.CurrentBindingType == bindingType)
				{
					this.GamepadKeyMap[mainKeyName] = secondaryKeyName;
				}
			}
		}

		// Token: 0x06045AC5 RID: 285381 RVA: 0x0114DF98 File Offset: 0x0114C198
		public void AddKeyEmptyData(EInputBindingType bindingType)
		{
			this.GetOrCreateKeyMap(bindingType).Clear();
			if (this.CurrentBindingType == bindingType)
			{
				this.KeyMap.Clear();
			}
			this.GetOrCreatePcKeyMap(bindingType).Clear();
			if (this.CurrentBindingType == bindingType)
			{
				this.PcKeyMap.Clear();
			}
			this.GetOrCreateGamepadKeyMap(bindingType).Clear();
			if (this.CurrentBindingType == bindingType)
			{
				this.GamepadKeyMap.Clear();
			}
		}

		// Token: 0x06045AC6 RID: 285382 RVA: 0x0114E008 File Offset: 0x0114C208
		public void ReplaceKeyboardKeyMap(EInputBindingType bindingType, IReadOnlyDictionary<string, string> keyMap)
		{
			Dictionary<string, string> orCreatePcKeyMap = this.GetOrCreatePcKeyMap(bindingType);
			orCreatePcKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				orCreatePcKeyMap[key] = value;
			}
			this.RefreshMergedKeyMapByBindingType(bindingType);
		}

		// Token: 0x06045AC7 RID: 285383 RVA: 0x0114E078 File Offset: 0x0114C278
		public void ReplaceGamepadKeyMap(EInputBindingType bindingType, IReadOnlyDictionary<string, string> keyMap)
		{
			Dictionary<string, string> orCreateGamepadKeyMap = this.GetOrCreateGamepadKeyMap(bindingType);
			orCreateGamepadKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				orCreateGamepadKeyMap[key] = value;
			}
			this.RefreshMergedKeyMapByBindingType(bindingType);
		}

		// Token: 0x06045AC8 RID: 285384 RVA: 0x0114E0E8 File Offset: 0x0114C2E8
		private void RefreshMergedKeyMapByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, string> orCreatePcKeyMap = this.GetOrCreatePcKeyMap(bindingType);
			Dictionary<string, string> orCreateGamepadKeyMap = this.GetOrCreateGamepadKeyMap(bindingType);
			Dictionary<string, string> orCreateKeyMap = this.GetOrCreateKeyMap(bindingType);
			orCreateKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in orCreatePcKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				orCreateKeyMap[key] = value;
			}
			foreach (KeyValuePair<string, string> keyValuePair in orCreateGamepadKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text2, out text);
				string key2 = text2;
				string value2 = text;
				orCreateKeyMap[key2] = value2;
			}
			if (this.CurrentBindingType != bindingType)
			{
				return;
			}
			this.PcKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in orCreatePcKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key3 = text;
				string value3 = text2;
				this.PcKeyMap[key3] = value3;
			}
			this.GamepadKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in orCreateGamepadKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text2, out text);
				string key4 = text2;
				string value4 = text;
				this.GamepadKeyMap[key4] = value4;
			}
			this.KeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in orCreateKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key5 = text;
				string value5 = text2;
				this.KeyMap[key5] = value5;
			}
		}

		// Token: 0x06045AC9 RID: 285385 RVA: 0x0114E2F8 File Offset: 0x0114C4F8
		public bool RemoveKey(string mainKeyName, EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (this.KeyMapToBindingTypeMap.TryGetValue(bindingType, out dictionary) && dictionary != null)
			{
				dictionary.Remove(mainKeyName);
			}
			Dictionary<string, string> dictionary2;
			if (this.PcKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary2) && dictionary2 != null)
			{
				dictionary2.Remove(mainKeyName);
			}
			Dictionary<string, string> dictionary3;
			if (this.GamepadKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary3) && dictionary3 != null)
			{
				dictionary3.Remove(mainKeyName);
			}
			if (this.CurrentBindingType == bindingType)
			{
				this.KeyMap.Remove(mainKeyName);
				this.PcKeyMap.Remove(mainKeyName);
				this.GamepadKeyMap.Remove(mainKeyName);
				return true;
			}
			return false;
		}

		// Token: 0x06045ACA RID: 285386 RVA: 0x0114E38C File Offset: 0x0114C58C
		public void GetKeyMapByBindingType(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableKeyMap = this.GetSuitableKeyMap(bindingType);
			if (suitableKeyMap == null)
			{
				return;
			}
			foreach (KeyValuePair<string, string> keyValuePair in suitableKeyMap)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				keyMapRef[key] = value;
			}
		}

		// Token: 0x06045ACB RID: 285387 RVA: 0x0114E3FC File Offset: 0x0114C5FC
		public bool HasAnyKey()
		{
			foreach (Dictionary<string, string> dictionary in this.KeyMapToBindingTypeMap.Values)
			{
				foreach (KeyValuePair<string, string> keyValuePair in dictionary)
				{
					string key = keyValuePair.Key;
					string value = keyValuePair.Value;
					if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06045ACC RID: 285388 RVA: 0x0114E4A8 File Offset: 0x0114C6A8
		public void GetKeyMap(Dictionary<string, string> keyMapRef)
		{
			Dictionary<string, string> suitableKeyMap = this.GetSuitableKeyMap(this.CurrentBindingType);
			if (suitableKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitableKeyMap);
		}

		// Token: 0x06045ACD RID: 285389 RVA: 0x0114E4CD File Offset: 0x0114C6CD
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public IReadOnlyDictionary<string, string> GetKeyMap()
		{
			return this.GetSuitableKeyMap(this.CurrentBindingType);
		}

		// Token: 0x06045ACE RID: 285390 RVA: 0x0114E4DB File Offset: 0x0114C6DB
		public bool IsValid()
		{
			return this.KeyMap != null && this.KeyMap.Count > 0;
		}

		// Token: 0x06045ACF RID: 285391 RVA: 0x0114E4F5 File Offset: 0x0114C6F5
		[NullableContext(2)]
		public string GetActionName()
		{
			return this.ActionName;
		}

		// Token: 0x06045AD0 RID: 285392 RVA: 0x0114E4FD File Offset: 0x0114C6FD
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x06045AD1 RID: 285393 RVA: 0x0114E50C File Offset: 0x0114C70C
		public void SetKeyboardVersionMap(Dictionary<EKeySettingExclusiveType, int> versionMap)
		{
			foreach (KeyValuePair<EKeySettingExclusiveType, int> keyValuePair in versionMap)
			{
				EKeySettingExclusiveType key = keyValuePair.Key;
				int value = keyValuePair.Value;
				this.KeyboardVersionMap[key] = value;
			}
		}

		// Token: 0x06045AD2 RID: 285394 RVA: 0x0114E570 File Offset: 0x0114C770
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.KeyboardVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045AD3 RID: 285395 RVA: 0x0114E590 File Offset: 0x0114C790
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x06045AD4 RID: 285396 RVA: 0x0114E5A0 File Offset: 0x0114C7A0
		public void SetGamepadVersionMap(Dictionary<EKeySettingExclusiveType, int> versionMap)
		{
			foreach (KeyValuePair<EKeySettingExclusiveType, int> keyValuePair in versionMap)
			{
				EKeySettingExclusiveType key = keyValuePair.Key;
				int value = keyValuePair.Value;
				this.GamepadVersionMap[key] = value;
			}
		}

		// Token: 0x06045AD5 RID: 285397 RVA: 0x0114E604 File Offset: 0x0114C804
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045AD6 RID: 285398 RVA: 0x0114E624 File Offset: 0x0114C824
		public bool HasKeyboardCombinationAction(EInputBindingType bindingType)
		{
			Dictionary<string, string> suitablePcKeyMap = this.GetSuitablePcKeyMap(bindingType);
			return suitablePcKeyMap != null && suitablePcKeyMap.Count > 0;
		}

		// Token: 0x06045AD7 RID: 285399 RVA: 0x0114E648 File Offset: 0x0114C848
		public bool HasGamepadCombinationActionByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(bindingType);
			return suitableGamepadKeyMap != null && suitableGamepadKeyMap.Count > 0;
		}

		// Token: 0x06045AD8 RID: 285400 RVA: 0x0114E66C File Offset: 0x0114C86C
		public bool HasGamepadCombinationAction()
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(this.CurrentBindingType);
			return suitableGamepadKeyMap != null && suitableGamepadKeyMap.Count > 0;
		}

		// Token: 0x06045AD9 RID: 285401 RVA: 0x0114E694 File Offset: 0x0114C894
		public bool HasCombinationAction(string mainKeyName, string secondaryKeyName)
		{
			return this.HasKey(mainKeyName, secondaryKeyName, this.CurrentBindingType);
		}

		// Token: 0x06045ADA RID: 285402 RVA: 0x0114E6A4 File Offset: 0x0114C8A4
		public float GetSecondaryKeyValidTime()
		{
			return this.SecondaryKeyValidTime;
		}

		// Token: 0x06045ADB RID: 285403 RVA: 0x0114E6AC File Offset: 0x0114C8AC
		public void GetAllPcKeyNameMap(Dictionary<EInputBindingType, Dictionary<string, string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.PcKeysMapToBindingTypeMap)
			{
				EInputBindingType einputBindingType;
				Dictionary<string, string> dictionary;
				keyValuePair.Deconstruct(out einputBindingType, out dictionary);
				EInputBindingType key = einputBindingType;
				Dictionary<string, string> dictionary2 = dictionary;
				keyMapRef[key] = new Dictionary<string, string>(dictionary2);
			}
		}

		// Token: 0x06045ADC RID: 285404 RVA: 0x0114E718 File Offset: 0x0114C918
		public void GetPcKeyNameMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitablePcKeyMap = this.GetSuitablePcKeyMap(bindingType);
			if (suitablePcKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitablePcKeyMap);
		}

		// Token: 0x06045ADD RID: 285405 RVA: 0x0114E738 File Offset: 0x0114C938
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public IReadOnlyDictionary<string, string> GetPcKeyNameMap(EInputBindingType bindingType)
		{
			return this.GetSuitablePcKeyMap(bindingType);
		}

		// Token: 0x06045ADE RID: 285406 RVA: 0x0114E744 File Offset: 0x0114C944
		public void GetPcKeyNameList(List<string> keyListRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitablePcKeyMap = this.GetSuitablePcKeyMap(bindingType);
			if (suitablePcKeyMap == null)
			{
				return;
			}
			keyListRef.EnsureCapacity(suitablePcKeyMap.Count * 2);
			foreach (KeyValuePair<string, string> keyValuePair in suitablePcKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string item = text;
				string item2 = text2;
				keyListRef.Add(item);
				keyListRef.Add(item2);
			}
		}

		// Token: 0x06045ADF RID: 285407 RVA: 0x0114E7C8 File Offset: 0x0114C9C8
		public void GetAllGamepadKeyNameMap(Dictionary<EInputBindingType, Dictionary<string, string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.GamepadKeysMapToBindingTypeMap)
			{
				EInputBindingType einputBindingType;
				Dictionary<string, string> dictionary;
				keyValuePair.Deconstruct(out einputBindingType, out dictionary);
				EInputBindingType key = einputBindingType;
				Dictionary<string, string> dictionary2 = dictionary;
				keyMapRef[key] = new Dictionary<string, string>(dictionary2);
			}
		}

		// Token: 0x06045AE0 RID: 285408 RVA: 0x0114E834 File Offset: 0x0114CA34
		public void GetGamepadKeyNameMapByBindingType(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(bindingType);
			if (suitableGamepadKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitableGamepadKeyMap);
		}

		// Token: 0x06045AE1 RID: 285409 RVA: 0x0114E854 File Offset: 0x0114CA54
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public IReadOnlyDictionary<string, string> GetGamepadKeyNameMapByBindingType(EInputBindingType bindingType)
		{
			return this.GetSuitableGamepadKeyMap(bindingType);
		}

		// Token: 0x06045AE2 RID: 285410 RVA: 0x0114E860 File Offset: 0x0114CA60
		public void GetGamepadKeyNameMap(Dictionary<string, string> keyMapRef)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(this.CurrentBindingType);
			if (suitableGamepadKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitableGamepadKeyMap);
		}

		// Token: 0x06045AE3 RID: 285411 RVA: 0x0114E885 File Offset: 0x0114CA85
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public IReadOnlyDictionary<string, string> GetGamepadKeyNameMap()
		{
			return this.GetSuitableGamepadKeyMap(this.CurrentBindingType);
		}

		// Token: 0x06045AE4 RID: 285412 RVA: 0x0114E894 File Offset: 0x0114CA94
		public void GetGamepadKeyNameList(List<string> keyListRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(bindingType);
			if (suitableGamepadKeyMap == null)
			{
				return;
			}
			keyListRef.EnsureCapacity(suitableGamepadKeyMap.Count * 2);
			foreach (KeyValuePair<string, string> keyValuePair in suitableGamepadKeyMap)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				keyListRef.Add(key);
				keyListRef.Add(value);
			}
		}

		// Token: 0x06045AE5 RID: 285413 RVA: 0x0114E918 File Offset: 0x0114CB18
		public void GetCurrentPlatformKeyNameMap(Dictionary<string, string> keyMapRef)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				this.GetPcKeyNameMap(keyMapRef, this.CurrentBindingType);
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				this.GetGamepadKeyNameMapByBindingType(keyMapRef, this.CurrentBindingType);
			}
		}

		// Token: 0x06045AE6 RID: 285414 RVA: 0x0114E94D File Offset: 0x0114CB4D
		public void GetCurrentPlatformKeyNameList(List<string> keyListRef)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				this.GetPcKeyNameList(keyListRef, this.CurrentBindingType);
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				this.GetGamepadKeyNameList(keyListRef, this.CurrentBindingType);
			}
		}

		// Token: 0x06045AE7 RID: 285415 RVA: 0x0114E982 File Offset: 0x0114CB82
		public void GetCurrentGamepadKeyNameList(List<string> keyListRef)
		{
			this.GetGamepadKeyNameList(keyListRef, this.CurrentBindingType);
		}

		// Token: 0x06045AE8 RID: 285416 RVA: 0x0114E994 File Offset: 0x0114CB94
		public bool HasKey(string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableKeyMap = this.GetSuitableKeyMap(bindingType);
			string a;
			return suitableKeyMap != null && suitableKeyMap.TryGetValue(mainKeyName, out a) && a == secondaryKeyName;
		}

		// Token: 0x06045AE9 RID: 285417 RVA: 0x0114E9C4 File Offset: 0x0114CBC4
		public bool HasKeyByAll(string mainKeyName, string secondaryKeyName)
		{
			using (Dictionary<EInputBindingType, Dictionary<string, string>>.ValueCollection.Enumerator enumerator = this.KeyMapToBindingTypeMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string a;
					if (enumerator.Current.TryGetValue(mainKeyName, out a) && a == secondaryKeyName)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06045AEA RID: 285418 RVA: 0x0114EA30 File Offset: 0x0114CC30
		[return: Nullable(2)]
		public string GetSecondaryKeyNameByMainKey(string mainKeyName, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableKeyMap = this.GetSuitableKeyMap(bindingType);
			if (suitableKeyMap == null)
			{
				return null;
			}
			string result;
			if (suitableKeyMap.TryGetValue(mainKeyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045AEB RID: 285419 RVA: 0x0114EA58 File Offset: 0x0114CC58
		public Dictionary<EInputBindingType, Dictionary<string, string>> GetKeyMapToBindingTypeMap()
		{
			return this.KeyMapToBindingTypeMap;
		}

		// Token: 0x06045AEC RID: 285420 RVA: 0x0114EA60 File Offset: 0x0114CC60
		public Dictionary<string, string> GetCopyKeyMap()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2;
			if (this.KeyMapToBindingTypeMap.TryGetValue(this.CurrentBindingType, out dictionary2))
			{
				foreach (KeyValuePair<string, string> keyValuePair in dictionary2)
				{
					string key = keyValuePair.Key;
					string value = keyValuePair.Value;
					dictionary[key] = value;
				}
			}
			return dictionary;
		}

		// Token: 0x06045AED RID: 285421 RVA: 0x0114EAE0 File Offset: 0x0114CCE0
		public Dictionary<EInputBindingType, Dictionary<string, string>> GetCopyKeyMapToBindingTypeMap()
		{
			Dictionary<EInputBindingType, Dictionary<string, string>> dictionary = new Dictionary<EInputBindingType, Dictionary<string, string>>();
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.KeyMapToBindingTypeMap)
			{
				EInputBindingType key = keyValuePair.Key;
				Dictionary<string, string> value = keyValuePair.Value;
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				foreach (KeyValuePair<string, string> keyValuePair2 in value)
				{
					string key2 = keyValuePair2.Key;
					string value2 = keyValuePair2.Value;
					dictionary2[key2] = value2;
				}
				dictionary[key] = dictionary2;
			}
			return dictionary;
		}

		// Token: 0x06045AEE RID: 285422 RVA: 0x0114EBA8 File Offset: 0x0114CDA8
		private Dictionary<string, string> GetOrCreateKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (!this.KeyMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.KeyMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06045AEF RID: 285423 RVA: 0x0114EBDC File Offset: 0x0114CDDC
		private Dictionary<string, string> GetOrCreatePcKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (!this.PcKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.PcKeysMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06045AF0 RID: 285424 RVA: 0x0114EC10 File Offset: 0x0114CE10
		private Dictionary<string, string> GetOrCreateGamepadKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (!this.GamepadKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.GamepadKeysMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06045AF1 RID: 285425 RVA: 0x0114EC44 File Offset: 0x0114CE44
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, string> GetSuitableKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary = null;
			Dictionary<string, string> dictionary2;
			if (this.KeyMapToBindingTypeMap.TryGetValue(bindingType, out dictionary2))
			{
				dictionary = dictionary2;
			}
			Dictionary<string, string> dictionary3;
			if (dictionary == null && this.ConfigBindingType == EInputBindingType.Original && this.KeyMapToBindingTypeMap.TryGetValue(this.ConfigBindingType, out dictionary3))
			{
				dictionary = dictionary3;
			}
			return dictionary;
		}

		// Token: 0x06045AF2 RID: 285426 RVA: 0x0114EC88 File Offset: 0x0114CE88
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, string> GetSuitablePcKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			this.PcKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary);
			if (dictionary == null && this.ConfigBindingType == EInputBindingType.Original)
			{
				this.PcKeysMapToBindingTypeMap.TryGetValue(this.ConfigBindingType, out dictionary);
			}
			return dictionary;
		}

		// Token: 0x06045AF3 RID: 285427 RVA: 0x0114ECC4 File Offset: 0x0114CEC4
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, string> GetSuitableGamepadKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			this.GamepadKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary);
			if (dictionary == null && this.ConfigBindingType == EInputBindingType.Original)
			{
				this.GamepadKeysMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary);
			}
			return dictionary;
		}

		// Token: 0x040245B4 RID: 148916
		private readonly Dictionary<string, string> PcKeyMap = new Dictionary<string, string>();

		// Token: 0x040245B5 RID: 148917
		private readonly Dictionary<string, string> GamepadKeyMap = new Dictionary<string, string>();

		// Token: 0x040245B6 RID: 148918
		private readonly Dictionary<string, string> KeyMap = new Dictionary<string, string>();

		// Token: 0x040245B7 RID: 148919
		private float SecondaryKeyValidTime;

		// Token: 0x040245B8 RID: 148920
		[Nullable(2)]
		private string ActionName;

		// Token: 0x040245B9 RID: 148921
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x040245BA RID: 148922
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x040245BB RID: 148923
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> KeyMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x040245BC RID: 148924
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> PcKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x040245BD RID: 148925
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> GamepadKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x040245BE RID: 148926
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();

		// Token: 0x040245BF RID: 148927
		public EInputBindingType ConfigBindingType;

		// Token: 0x040245C0 RID: 148928
		public EInputBindingType CurrentBindingType;
	}
}
