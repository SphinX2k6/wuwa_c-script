using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006169 RID: 24937
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationActionBinding
	{
		// Token: 0x0603BC6E RID: 244846 RVA: 0x010F76D0 File Offset: 0x010F58D0
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

		// Token: 0x0603BC6F RID: 244847 RVA: 0x010F79BC File Offset: 0x010F5BBC
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

		// Token: 0x0603BC70 RID: 244848 RVA: 0x010F7AAF File Offset: 0x010F5CAF
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

		// Token: 0x0603BC71 RID: 244849 RVA: 0x010F7AD2 File Offset: 0x010F5CD2
		public void InitializeBindingType(EInputBindingType bindingType)
		{
			this.CurrentBindingType = bindingType;
		}

		// Token: 0x0603BC72 RID: 244850 RVA: 0x010F7ADC File Offset: 0x010F5CDC
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

		// Token: 0x0603BC73 RID: 244851 RVA: 0x010F7B3D File Offset: 0x010F5D3D
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x0603BC74 RID: 244852 RVA: 0x010F7B48 File Offset: 0x010F5D48
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

		// Token: 0x0603BC75 RID: 244853 RVA: 0x010F7CE8 File Offset: 0x010F5EE8
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

		// Token: 0x0603BC76 RID: 244854 RVA: 0x010F7D8C File Offset: 0x010F5F8C
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

		// Token: 0x0603BC77 RID: 244855 RVA: 0x010F7DFC File Offset: 0x010F5FFC
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

		// Token: 0x0603BC78 RID: 244856 RVA: 0x010F7E6C File Offset: 0x010F606C
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

		// Token: 0x0603BC79 RID: 244857 RVA: 0x010F7EDC File Offset: 0x010F60DC
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

		// Token: 0x0603BC7A RID: 244858 RVA: 0x010F80EC File Offset: 0x010F62EC
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

		// Token: 0x0603BC7B RID: 244859 RVA: 0x010F8180 File Offset: 0x010F6380
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

		// Token: 0x0603BC7C RID: 244860 RVA: 0x010F81F0 File Offset: 0x010F63F0
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

		// Token: 0x0603BC7D RID: 244861 RVA: 0x010F829C File Offset: 0x010F649C
		public void GetKeyMap(Dictionary<string, string> keyMapRef)
		{
			Dictionary<string, string> suitableKeyMap = this.GetSuitableKeyMap(this.CurrentBindingType);
			if (suitableKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitableKeyMap);
		}

		// Token: 0x0603BC7E RID: 244862 RVA: 0x010F82C1 File Offset: 0x010F64C1
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

		// Token: 0x0603BC7F RID: 244863 RVA: 0x010F82CF File Offset: 0x010F64CF
		public bool IsValid()
		{
			return this.KeyMap != null && this.KeyMap.Count > 0;
		}

		// Token: 0x0603BC80 RID: 244864 RVA: 0x010F82E9 File Offset: 0x010F64E9
		[NullableContext(2)]
		public string GetActionName()
		{
			return this.ActionName;
		}

		// Token: 0x0603BC81 RID: 244865 RVA: 0x010F82F1 File Offset: 0x010F64F1
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x0603BC82 RID: 244866 RVA: 0x010F8300 File Offset: 0x010F6500
		public void SetKeyboardVersionMap(Dictionary<EKeySettingExclusiveType, int> versionMap)
		{
			foreach (KeyValuePair<EKeySettingExclusiveType, int> keyValuePair in versionMap)
			{
				EKeySettingExclusiveType key = keyValuePair.Key;
				int value = keyValuePair.Value;
				this.KeyboardVersionMap[key] = value;
			}
		}

		// Token: 0x0603BC83 RID: 244867 RVA: 0x010F8364 File Offset: 0x010F6564
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.KeyboardVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BC84 RID: 244868 RVA: 0x010F8384 File Offset: 0x010F6584
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x0603BC85 RID: 244869 RVA: 0x010F8394 File Offset: 0x010F6594
		public void SetGamepadVersionMap(Dictionary<EKeySettingExclusiveType, int> versionMap)
		{
			foreach (KeyValuePair<EKeySettingExclusiveType, int> keyValuePair in versionMap)
			{
				EKeySettingExclusiveType key = keyValuePair.Key;
				int value = keyValuePair.Value;
				this.GamepadVersionMap[key] = value;
			}
		}

		// Token: 0x0603BC86 RID: 244870 RVA: 0x010F83F8 File Offset: 0x010F65F8
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BC87 RID: 244871 RVA: 0x010F8418 File Offset: 0x010F6618
		public bool HasKeyboardCombinationAction(EInputBindingType bindingType)
		{
			Dictionary<string, string> suitablePcKeyMap = this.GetSuitablePcKeyMap(bindingType);
			return suitablePcKeyMap != null && suitablePcKeyMap.Count > 0;
		}

		// Token: 0x0603BC88 RID: 244872 RVA: 0x010F843C File Offset: 0x010F663C
		public bool HasGamepadCombinationActionByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(bindingType);
			return suitableGamepadKeyMap != null && suitableGamepadKeyMap.Count > 0;
		}

		// Token: 0x0603BC89 RID: 244873 RVA: 0x010F8460 File Offset: 0x010F6660
		public bool HasGamepadCombinationAction()
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(this.CurrentBindingType);
			return suitableGamepadKeyMap != null && suitableGamepadKeyMap.Count > 0;
		}

		// Token: 0x0603BC8A RID: 244874 RVA: 0x010F8488 File Offset: 0x010F6688
		public bool HasCombinationAction(string mainKeyName, string secondaryKeyName)
		{
			return this.HasKey(mainKeyName, secondaryKeyName, this.CurrentBindingType);
		}

		// Token: 0x0603BC8B RID: 244875 RVA: 0x010F8498 File Offset: 0x010F6698
		public float GetSecondaryKeyValidTime()
		{
			return this.SecondaryKeyValidTime;
		}

		// Token: 0x0603BC8C RID: 244876 RVA: 0x010F84A0 File Offset: 0x010F66A0
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

		// Token: 0x0603BC8D RID: 244877 RVA: 0x010F850C File Offset: 0x010F670C
		public void GetPcKeyNameMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitablePcKeyMap = this.GetSuitablePcKeyMap(bindingType);
			if (suitablePcKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitablePcKeyMap);
		}

		// Token: 0x0603BC8E RID: 244878 RVA: 0x010F852C File Offset: 0x010F672C
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

		// Token: 0x0603BC8F RID: 244879 RVA: 0x010F8538 File Offset: 0x010F6738
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

		// Token: 0x0603BC90 RID: 244880 RVA: 0x010F85BC File Offset: 0x010F67BC
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

		// Token: 0x0603BC91 RID: 244881 RVA: 0x010F8628 File Offset: 0x010F6828
		public void GetGamepadKeyNameMapByBindingType(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(bindingType);
			if (suitableGamepadKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitableGamepadKeyMap);
		}

		// Token: 0x0603BC92 RID: 244882 RVA: 0x010F8648 File Offset: 0x010F6848
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

		// Token: 0x0603BC93 RID: 244883 RVA: 0x010F8654 File Offset: 0x010F6854
		public void GetGamepadKeyNameMap(Dictionary<string, string> keyMapRef)
		{
			Dictionary<string, string> suitableGamepadKeyMap = this.GetSuitableGamepadKeyMap(this.CurrentBindingType);
			if (suitableGamepadKeyMap == null)
			{
				return;
			}
			keyMapRef.AddRange(suitableGamepadKeyMap);
		}

		// Token: 0x0603BC94 RID: 244884 RVA: 0x010F8679 File Offset: 0x010F6879
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

		// Token: 0x0603BC95 RID: 244885 RVA: 0x010F8688 File Offset: 0x010F6888
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

		// Token: 0x0603BC96 RID: 244886 RVA: 0x010F870C File Offset: 0x010F690C
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

		// Token: 0x0603BC97 RID: 244887 RVA: 0x010F8741 File Offset: 0x010F6941
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

		// Token: 0x0603BC98 RID: 244888 RVA: 0x010F8776 File Offset: 0x010F6976
		public void GetCurrentGamepadKeyNameList(List<string> keyListRef)
		{
			this.GetGamepadKeyNameList(keyListRef, this.CurrentBindingType);
		}

		// Token: 0x0603BC99 RID: 244889 RVA: 0x010F8788 File Offset: 0x010F6988
		public bool HasKey(string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			Dictionary<string, string> suitableKeyMap = this.GetSuitableKeyMap(bindingType);
			string a;
			return suitableKeyMap != null && suitableKeyMap.TryGetValue(mainKeyName, out a) && a == secondaryKeyName;
		}

		// Token: 0x0603BC9A RID: 244890 RVA: 0x010F87B8 File Offset: 0x010F69B8
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

		// Token: 0x0603BC9B RID: 244891 RVA: 0x010F8824 File Offset: 0x010F6A24
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

		// Token: 0x0603BC9C RID: 244892 RVA: 0x010F884C File Offset: 0x010F6A4C
		public Dictionary<EInputBindingType, Dictionary<string, string>> GetKeyMapToBindingTypeMap()
		{
			return this.KeyMapToBindingTypeMap;
		}

		// Token: 0x0603BC9D RID: 244893 RVA: 0x010F8854 File Offset: 0x010F6A54
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

		// Token: 0x0603BC9E RID: 244894 RVA: 0x010F88D4 File Offset: 0x010F6AD4
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

		// Token: 0x0603BC9F RID: 244895 RVA: 0x010F899C File Offset: 0x010F6B9C
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

		// Token: 0x0603BCA0 RID: 244896 RVA: 0x010F89D0 File Offset: 0x010F6BD0
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

		// Token: 0x0603BCA1 RID: 244897 RVA: 0x010F8A04 File Offset: 0x010F6C04
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

		// Token: 0x0603BCA2 RID: 244898 RVA: 0x010F8A38 File Offset: 0x010F6C38
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

		// Token: 0x0603BCA3 RID: 244899 RVA: 0x010F8A7C File Offset: 0x010F6C7C
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

		// Token: 0x0603BCA4 RID: 244900 RVA: 0x010F8AB8 File Offset: 0x010F6CB8
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

		// Token: 0x0401F869 RID: 129129
		private readonly Dictionary<string, string> PcKeyMap = new Dictionary<string, string>();

		// Token: 0x0401F86A RID: 129130
		private readonly Dictionary<string, string> GamepadKeyMap = new Dictionary<string, string>();

		// Token: 0x0401F86B RID: 129131
		private readonly Dictionary<string, string> KeyMap = new Dictionary<string, string>();

		// Token: 0x0401F86C RID: 129132
		private float SecondaryKeyValidTime;

		// Token: 0x0401F86D RID: 129133
		[Nullable(2)]
		private string ActionName;

		// Token: 0x0401F86E RID: 129134
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F86F RID: 129135
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F870 RID: 129136
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> KeyMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x0401F871 RID: 129137
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> PcKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x0401F872 RID: 129138
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> GamepadKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x0401F873 RID: 129139
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();

		// Token: 0x0401F874 RID: 129140
		public EInputBindingType ConfigBindingType;

		// Token: 0x0401F875 RID: 129141
		public EInputBindingType CurrentBindingType;
	}
}
