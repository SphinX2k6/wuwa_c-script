using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.KeySetting;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FE4 RID: 28644
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionBinding
	{
		// Token: 0x06045A51 RID: 285265 RVA: 0x0114B8BC File Offset: 0x01149ABC
		public void Initialize(ActionMapping config)
		{
			this.ActionName = config.ActionName;
			this.Config = new ActionMapping?(config);
			this.ConfigId = this.Config.Value.Id;
			this.ActionMappingType = (EActionMappingType)this.Config.Value.ActionType;
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

		// Token: 0x06045A52 RID: 285266 RVA: 0x0114B9BC File Offset: 0x01149BBC
		public void Clear()
		{
			this.ActionName = null;
			this.ActionMappingType = EActionMappingType.None;
			this.Config = null;
			this.PcKeys.Clear();
			this.GamepadKeys.Clear();
			this.KeyNameList.Clear();
			this.KeyNameListToBindingTypeMap.Clear();
			this.PcKeysToBindingTypeMap.Clear();
			this.GamepadKeysToBindingTypeMap.Clear();
		}

		// Token: 0x06045A53 RID: 285267 RVA: 0x0114BA25 File Offset: 0x01149C25
		[NullableContext(2)]
		public string GetActionName()
		{
			return this.ActionName;
		}

		// Token: 0x06045A54 RID: 285268 RVA: 0x0114BA2D File Offset: 0x01149C2D
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x06045A55 RID: 285269 RVA: 0x0114BA3C File Offset: 0x01149C3C
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			return this.KeyboardVersionMap.GetValueOrDefault(type, 0);
		}

		// Token: 0x06045A56 RID: 285270 RVA: 0x0114BA4B File Offset: 0x01149C4B
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x06045A57 RID: 285271 RVA: 0x0114BA5C File Offset: 0x01149C5C
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045A58 RID: 285272 RVA: 0x0114BA7C File Offset: 0x01149C7C
		[NullableContext(2)]
		public InputActionKey GetCurrentPlatformKeyByIndex(int index)
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

		// Token: 0x06045A59 RID: 285273 RVA: 0x0114BAA7 File Offset: 0x01149CA7
		[NullableContext(2)]
		public InputKey GetCurrentPlatformKey()
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

		// Token: 0x06045A5A RID: 285274 RVA: 0x0114BAD0 File Offset: 0x01149CD0
		[NullableContext(2)]
		public InputActionKey GetPcKeyByIndex(int index)
		{
			if (index < 0 || index >= this.PcKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputActionKey(this.ActionName, this.PcKeys[index], this.CurrentBindingType);
		}

		// Token: 0x06045A5B RID: 285275 RVA: 0x0114BB08 File Offset: 0x01149D08
		[NullableContext(2)]
		public InputKey GetPcKey()
		{
			if (this.PcKeys.Count == 0)
			{
				return null;
			}
			string key = this.PcKeys[0];
			return InputSettings.Instance.GetKey(key);
		}

		// Token: 0x06045A5C RID: 285276 RVA: 0x0114BB3C File Offset: 0x01149D3C
		[NullableContext(2)]
		public InputActionKey GetGamepadKeyByIndex(int index)
		{
			if (index < 0 || index >= this.GamepadKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputActionKey(this.ActionName, this.GamepadKeys[index], this.CurrentBindingType);
		}

		// Token: 0x06045A5D RID: 285277 RVA: 0x0114BB74 File Offset: 0x01149D74
		[NullableContext(2)]
		public InputKey GetGamepadKey()
		{
			if (this.GamepadKeys.Count == 0)
			{
				return null;
			}
			string key = this.GamepadKeys[0];
			return InputSettings.Instance.GetKey(key);
		}

		// Token: 0x06045A5E RID: 285278 RVA: 0x0114BBA8 File Offset: 0x01149DA8
		public void GetAllPcKeyNameMap(Dictionary<EInputBindingType, List<string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair in this.PcKeysToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045A5F RID: 285279 RVA: 0x0114BC08 File Offset: 0x01149E08
		public void GetPcKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.PcKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x06045A60 RID: 285280 RVA: 0x0114BC5C File Offset: 0x01149E5C
		public IReadOnlyList<string> GetPcKeyNameList()
		{
			return this.PcKeys;
		}

		// Token: 0x06045A61 RID: 285281 RVA: 0x0114BC64 File Offset: 0x01149E64
		public void GetPcKeyNameListByBindingType(List<string> keyListRef, EInputBindingType bindingType)
		{
			List<string> list;
			if (this.PcKeysToBindingTypeMap.TryGetValue(bindingType, out list))
			{
				foreach (string item in list)
				{
					keyListRef.Add(item);
				}
			}
		}

		// Token: 0x06045A62 RID: 285282 RVA: 0x0114BCC4 File Offset: 0x01149EC4
		public IReadOnlyList<string> GetPcKeyNameListReadonly()
		{
			return this.PcKeys;
		}

		// Token: 0x06045A63 RID: 285283 RVA: 0x0114BCCC File Offset: 0x01149ECC
		public void GetAllGamepadKeyNameMap(Dictionary<EInputBindingType, List<string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair in this.GamepadKeysToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045A64 RID: 285284 RVA: 0x0114BD2C File Offset: 0x01149F2C
		public void GetGamepadKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.GamepadKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x06045A65 RID: 285285 RVA: 0x0114BD80 File Offset: 0x01149F80
		public IReadOnlyList<string> GetGamepadKeyNameList()
		{
			return this.GamepadKeys;
		}

		// Token: 0x06045A66 RID: 285286 RVA: 0x0114BD88 File Offset: 0x01149F88
		public void GetGamepadKeyNameListByBindingType(List<string> keyListRef, EInputBindingType bindingType)
		{
			List<string> list;
			if (this.GamepadKeysToBindingTypeMap.TryGetValue(bindingType, out list))
			{
				foreach (string item in list)
				{
					keyListRef.Add(item);
				}
			}
		}

		// Token: 0x06045A67 RID: 285287 RVA: 0x0114BDE8 File Offset: 0x01149FE8
		public IReadOnlyList<string> GetGamepadKeyNameListReadonly()
		{
			return this.GamepadKeys;
		}

		// Token: 0x06045A68 RID: 285288 RVA: 0x0114BDF0 File Offset: 0x01149FF0
		public void GetKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.KeyNameList)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x06045A69 RID: 285289 RVA: 0x0114BE44 File Offset: 0x0114A044
		public IReadOnlyList<string> GetKeyNameList()
		{
			return this.KeyNameList;
		}

		// Token: 0x06045A6A RID: 285290 RVA: 0x0114BE4C File Offset: 0x0114A04C
		public void GetKeyNameListByBindingType(List<string> keyListRef, EInputBindingType bindingType)
		{
			List<string> collection;
			if (this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out collection))
			{
				keyListRef.AddRange(collection);
			}
		}

		// Token: 0x06045A6B RID: 285291 RVA: 0x0114BE70 File Offset: 0x0114A070
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

		// Token: 0x06045A6C RID: 285292 RVA: 0x0114BE99 File Offset: 0x0114A099
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

		// Token: 0x06045A6D RID: 285293 RVA: 0x0114BEC6 File Offset: 0x0114A0C6
		public void GetCurrentGamepadKeyNameList(List<string> keyListRef)
		{
			this.GetGamepadKeyNameList(keyListRef);
		}

		// Token: 0x06045A6E RID: 285294 RVA: 0x0114BECF File Offset: 0x0114A0CF
		public IReadOnlyList<string> GetCurrentGamepadKeyNameList()
		{
			return this.GetGamepadKeyNameList();
		}

		// Token: 0x06045A6F RID: 285295 RVA: 0x0114BED8 File Offset: 0x0114A0D8
		public bool HasKey(string keyName)
		{
			Dictionary<string, InputActionKey> inputActionKeyMapByBindingType = InputSettings.Instance.GetInputActionKeyMapByBindingType(this.ActionName, this.CurrentBindingType);
			return inputActionKeyMapByBindingType != null && inputActionKeyMapByBindingType.ContainsKey(keyName);
		}

		// Token: 0x06045A70 RID: 285296 RVA: 0x0114BF08 File Offset: 0x0114A108
		public bool HasAnyKey()
		{
			return this.KeyNameList.Count > 0;
		}

		// Token: 0x06045A71 RID: 285297 RVA: 0x0114BF18 File Offset: 0x0114A118
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			List<string> list = this.PcKeysToBindingTypeMap.GetValueOrDefault(bindingType) ?? this.PcKeysToBindingTypeMap.GetValueOrDefault(EInputBindingType.Original);
			List<string> list2 = this.GamepadKeysToBindingTypeMap.GetValueOrDefault(bindingType) ?? this.GamepadKeysToBindingTypeMap.GetValueOrDefault(EInputBindingType.Original);
			List<string> list3 = new List<string>();
			if (list != null)
			{
				list3.AddRange(list);
			}
			if (list2 != null)
			{
				list3.AddRange(list2);
			}
			if (list3.Count > 0)
			{
				this.CurrentBindingType = bindingType;
				this.SetKeys(list3, bindingType);
				this.LastBindingType = this.CurrentBindingType;
			}
		}

		// Token: 0x06045A72 RID: 285298 RVA: 0x0114BFA0 File Offset: 0x0114A1A0
		public void SetKeys(List<string> keys, EInputBindingType bindingType)
		{
			this.KeyNameListToBindingTypeMap[bindingType] = keys;
			if (this.CurrentBindingType == bindingType)
			{
				InputSettings.Instance.SetActionMapping(this.ActionName, keys, this.LastBindingType, bindingType);
				this.KeyNameList = keys;
				this.RefreshKeyList();
				EventSystem.Instance.Emit<string>(EEventName.OnActionKeyChanged, this.ActionName);
				return;
			}
			InputSettings.Instance.SetActionMappingApplyInputSettings(this.ActionName, keys, bindingType, false, false);
			this.RefreshKeyListByBindingType(bindingType);
		}

		// Token: 0x06045A73 RID: 285299 RVA: 0x0114C01C File Offset: 0x0114A21C
		public void SetKeyboardKeys(IReadOnlyList<string> keyboardKeys, EInputBindingType bindingType)
		{
			List<string> list = new List<string>(keyboardKeys);
			List<string> collection;
			if (this.GamepadKeysToBindingTypeMap.TryGetValue(bindingType, out collection))
			{
				list.AddRange(collection);
			}
			this.SetKeys(list, bindingType);
		}

		// Token: 0x06045A74 RID: 285300 RVA: 0x0114C050 File Offset: 0x0114A250
		public void SetKeyboardKeysWithoutOriginal(IReadOnlyList<string> keyboardKeys)
		{
			foreach (EInputBindingType einputBindingType in InputBindingDefine.inputBindingTypesArray)
			{
				if (einputBindingType != EInputBindingType.Original)
				{
					this.SetKeyboardKeys(keyboardKeys, einputBindingType);
				}
			}
		}

		// Token: 0x06045A75 RID: 285301 RVA: 0x0114C080 File Offset: 0x0114A280
		public void SetGamepadKeys(IReadOnlyList<string> gamepadKeys, EInputBindingType bindingType)
		{
			List<string> list = new List<string>();
			List<string> collection;
			if (this.PcKeysToBindingTypeMap.TryGetValue(bindingType, out collection))
			{
				list.AddRange(collection);
			}
			list.AddRange(gamepadKeys);
			this.SetKeys(list, bindingType);
		}

		// Token: 0x06045A76 RID: 285302 RVA: 0x0114C0BC File Offset: 0x0114A2BC
		public void SetGamepadKeysWithoutOriginal(IReadOnlyList<string> gamepadKeys)
		{
			foreach (EInputBindingType einputBindingType in this.PcKeysToBindingTypeMap.Keys)
			{
				if (einputBindingType != EInputBindingType.Original)
				{
					this.SetGamepadKeys(gamepadKeys, einputBindingType);
				}
			}
		}

		// Token: 0x06045A77 RID: 285303 RVA: 0x0114C118 File Offset: 0x0114A318
		public void RefreshKeysByActionMappings(TArray<FInputActionKeyMapping> actionMappings, EInputBindingType bindingType)
		{
			List<string> orCreateKeyNameList = this.GetOrCreateKeyNameList(bindingType);
			orCreateKeyNameList.Clear();
			for (int i = actionMappings.Num() - 1; i >= 0; i--)
			{
				string item = actionMappings.Get(i).Key.KeyName.ToString();
				orCreateKeyNameList.Add(item);
			}
			if (this.CurrentBindingType == bindingType)
			{
				this.KeyNameList = orCreateKeyNameList;
				this.RefreshKeyList();
				EventSystem.Instance.Emit<string>(EEventName.OnActionKeyChanged, this.ActionName);
				return;
			}
			this.RefreshKeyListByBindingType(bindingType);
		}

		// Token: 0x06045A78 RID: 285304 RVA: 0x0114C1A4 File Offset: 0x0114A3A4
		public unsafe void AddKeys([Nullable(new byte[]
		{
			0,
			1
		})] Span<string> keys, EInputBindingType bindingType)
		{
			List<string> orCreateKeyNameList = this.GetOrCreateKeyNameList(bindingType);
			Span<string> span = keys;
			for (int i = 0; i < span.Length; i++)
			{
				string text = *span[i];
				if (!keys.Contains(text))
				{
					orCreateKeyNameList.Add(text);
				}
			}
			if (this.CurrentBindingType == bindingType)
			{
				span = keys;
				for (int i = 0; i < span.Length; i++)
				{
					string keyName = *span[i];
					InputSettings.Instance.AddActionMapping(this.ActionName, keyName, bindingType, true);
				}
				this.KeyNameList = orCreateKeyNameList;
				this.RefreshKeyList();
				return;
			}
			this.RefreshKeyListByBindingType(bindingType);
		}

		// Token: 0x06045A79 RID: 285305 RVA: 0x0114C238 File Offset: 0x0114A438
		public unsafe void RemoveKeys([Nullable(new byte[]
		{
			0,
			1
		})] Span<string> keys, EInputBindingType bindingType)
		{
			List<string> orCreateKeyNameList = this.GetOrCreateKeyNameList(bindingType);
			Span<string> span = keys;
			for (int i = 0; i < span.Length; i++)
			{
				string item = *span[i];
				orCreateKeyNameList.Remove(item);
			}
			if (this.CurrentBindingType == bindingType)
			{
				span = keys;
				for (int i = 0; i < span.Length; i++)
				{
					string keyName = *span[i];
					InputSettings.Instance.RemoveActionMapping(this.ActionName, keyName, bindingType, true, true);
				}
				this.KeyNameList = orCreateKeyNameList;
				this.RefreshKeyList();
				return;
			}
			this.RefreshKeyListByBindingType(bindingType);
		}

		// Token: 0x06045A7A RID: 285306 RVA: 0x0114C2C5 File Offset: 0x0114A4C5
		public void ClearAllKeys()
		{
			this.PcKeys.Clear();
			this.GamepadKeys.Clear();
			this.KeyNameList.Clear();
			InputSettings.Instance.ClearActionMapping(this.ActionName);
		}

		// Token: 0x06045A7B RID: 285307 RVA: 0x0114C2F8 File Offset: 0x0114A4F8
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
			InputSettings.Instance.ClearActionMapping(this.ActionName);
		}

		// Token: 0x06045A7C RID: 285308 RVA: 0x0114C394 File Offset: 0x0114A594
		public void ResetVersionMapsFromConfig()
		{
			this.KeyboardVersionMap.Clear();
			this.GamepadVersionMap.Clear();
			if (this.Config == null)
			{
				return;
			}
			ActionMapping value = this.Config.Value;
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

		// Token: 0x06045A7D RID: 285309 RVA: 0x0114C45F File Offset: 0x0114A65F
		public ActionMapping? GetActionMappingConfig()
		{
			return this.Config;
		}

		// Token: 0x06045A7E RID: 285310 RVA: 0x0114C467 File Offset: 0x0114A667
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x06045A7F RID: 285311 RVA: 0x0114C46F File Offset: 0x0114A66F
		public EActionMappingType GetActionMappingType()
		{
			return this.ActionMappingType;
		}

		// Token: 0x06045A80 RID: 285312 RVA: 0x0114C478 File Offset: 0x0114A678
		private void RefreshKeyListByBindingType(EInputBindingType bindingType)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3;
			if (this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out list3))
			{
				foreach (string text in list3)
				{
					InputKey key = InputSettings.Instance.GetKey(text);
					if (key != null)
					{
						if (key.IsKeyboardKey || key.IsMouseButton)
						{
							list.Add(text);
						}
						else if (key.IsGamepadKey)
						{
							list2.Add(text);
						}
						else if (key.IsPcPsTouchPadKey)
						{
							list2.Add(text);
						}
					}
				}
			}
			List<string> list4;
			if (list.Count == 0 && !this.PcKeysToBindingTypeMap.ContainsKey(bindingType) && this.PcKeysToBindingTypeMap.TryGetValue(EInputBindingType.Original, out list4))
			{
				list = list4;
			}
			List<string> list5;
			if (list2.Count == 0 && !this.GamepadKeysToBindingTypeMap.ContainsKey(bindingType) && this.GamepadKeysToBindingTypeMap.TryGetValue(EInputBindingType.Original, out list5))
			{
				list2 = list5;
			}
			if (this.CurrentBindingType == bindingType)
			{
				this.PcKeys = list;
				this.GamepadKeys = list2;
			}
			this.PcKeysToBindingTypeMap[bindingType] = list;
			this.GamepadKeysToBindingTypeMap[bindingType] = list2;
		}

		// Token: 0x06045A81 RID: 285313 RVA: 0x0114C5B4 File Offset: 0x0114A7B4
		private void RefreshKeyList()
		{
			this.RefreshKeyListByBindingType(this.CurrentBindingType);
		}

		// Token: 0x06045A82 RID: 285314 RVA: 0x0114C5C4 File Offset: 0x0114A7C4
		public void ConvertSort()
		{
			ActionMapping? actionMappingConfigByActionName = InputSettingsConfig.Instance.GetActionMappingConfigByActionName(this.ActionName);
			List<string> configPcKeys = new List<string>();
			if (InputSettingsManager.Instance.CheckUseFrenchKeyboard)
			{
				int francePcKeysLength = actionMappingConfigByActionName.Value.FrancePcKeysLength;
				configPcKeys.EnsureCapacity(francePcKeysLength);
				for (int i = 0; i < francePcKeysLength; i++)
				{
					configPcKeys.Add(actionMappingConfigByActionName.Value.FrancePcKeys(i));
				}
			}
			else
			{
				string[] actionPcKeys = LanguageKeyTransUtils.GetKeyTrans(InputSettingsManager.Instance.CurrentDeviceLang).GetActionPcKeys(actionMappingConfigByActionName.Value);
				configPcKeys.AddRange(actionPcKeys);
			}
			this.KeyNameList.Sort(delegate(string aKeyName, string bKeyName)
			{
				bool flag = InputSettings.Instance.IsKeyboardKey(aKeyName) || InputSettings.Instance.IsMouseButton(aKeyName);
				bool flag2 = InputSettings.Instance.IsKeyboardKey(bKeyName) || InputSettings.Instance.IsMouseButton(bKeyName);
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (flag == flag2)
					{
						int num = configPcKeys.IndexOf(aKeyName);
						int num2 = configPcKeys.IndexOf(bKeyName);
						if (num != -1 && num2 != -1)
						{
							if (num >= num2)
							{
								return 1;
							}
							return -1;
						}
					}
					bool flag3 = InputSettings.Instance.IsGamepadKey(aKeyName);
					bool flag4 = InputSettings.Instance.IsGamepadKey(bKeyName);
					if (flag3 == flag4)
					{
						return 0;
					}
					if (!flag3)
					{
						return 1;
					}
					return -1;
				}
			});
			this.SetKeys(this.KeyNameList, this.CurrentBindingType);
		}

		// Token: 0x06045A83 RID: 285315 RVA: 0x0114C69D File Offset: 0x0114A89D
		public Dictionary<EInputBindingType, List<string>> GetKeyNameListToBindingTypeMap()
		{
			return this.KeyNameListToBindingTypeMap;
		}

		// Token: 0x06045A84 RID: 285316 RVA: 0x0114C6A5 File Offset: 0x0114A8A5
		public Dictionary<EInputBindingType, List<string>> GetCopyKeyNameListToBindingTypeMap()
		{
			return new Dictionary<EInputBindingType, List<string>>(this.KeyNameListToBindingTypeMap);
		}

		// Token: 0x06045A85 RID: 285317 RVA: 0x0114C6B4 File Offset: 0x0114A8B4
		private List<string> GetOrCreateKeyNameList(EInputBindingType bindingType)
		{
			List<string> result;
			if (!this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out result))
			{
				result = (this.KeyNameListToBindingTypeMap[bindingType] = new List<string>());
			}
			return result;
		}

		// Token: 0x04024595 RID: 148885
		[Nullable(2)]
		private string ActionName;

		// Token: 0x04024596 RID: 148886
		private int ConfigId;

		// Token: 0x04024597 RID: 148887
		private ActionMapping? Config;

		// Token: 0x04024598 RID: 148888
		private EActionMappingType ActionMappingType;

		// Token: 0x04024599 RID: 148889
		private List<string> PcKeys = new List<string>();

		// Token: 0x0402459A RID: 148890
		private List<string> GamepadKeys = new List<string>();

		// Token: 0x0402459B RID: 148891
		private List<string> KeyNameList = new List<string>();

		// Token: 0x0402459C RID: 148892
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0402459D RID: 148893
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0402459E RID: 148894
		private readonly Dictionary<EInputBindingType, List<string>> KeyNameListToBindingTypeMap = new Dictionary<EInputBindingType, List<string>>();

		// Token: 0x0402459F RID: 148895
		private readonly Dictionary<EInputBindingType, List<string>> PcKeysToBindingTypeMap = new Dictionary<EInputBindingType, List<string>>();

		// Token: 0x040245A0 RID: 148896
		private readonly Dictionary<EInputBindingType, List<string>> GamepadKeysToBindingTypeMap = new Dictionary<EInputBindingType, List<string>>();

		// Token: 0x040245A1 RID: 148897
		private EInputBindingType LastBindingType;

		// Token: 0x040245A2 RID: 148898
		public EInputBindingType CurrentBindingType;
	}
}
