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
	// Token: 0x02006165 RID: 24933
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionBinding
	{
		// Token: 0x0603BC02 RID: 244738 RVA: 0x010F56B0 File Offset: 0x010F38B0
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

		// Token: 0x0603BC03 RID: 244739 RVA: 0x010F57B0 File Offset: 0x010F39B0
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

		// Token: 0x0603BC04 RID: 244740 RVA: 0x010F5819 File Offset: 0x010F3A19
		[NullableContext(2)]
		public string GetActionName()
		{
			return this.ActionName;
		}

		// Token: 0x0603BC05 RID: 244741 RVA: 0x010F5821 File Offset: 0x010F3A21
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x0603BC06 RID: 244742 RVA: 0x010F5830 File Offset: 0x010F3A30
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			return this.KeyboardVersionMap.GetValueOrDefault(type, 0);
		}

		// Token: 0x0603BC07 RID: 244743 RVA: 0x010F583F File Offset: 0x010F3A3F
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x0603BC08 RID: 244744 RVA: 0x010F5850 File Offset: 0x010F3A50
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BC09 RID: 244745 RVA: 0x010F5870 File Offset: 0x010F3A70
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

		// Token: 0x0603BC0A RID: 244746 RVA: 0x010F589B File Offset: 0x010F3A9B
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

		// Token: 0x0603BC0B RID: 244747 RVA: 0x010F58C4 File Offset: 0x010F3AC4
		[NullableContext(2)]
		public InputActionKey GetPcKeyByIndex(int index)
		{
			if (index < 0 || index >= this.PcKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputActionKey(this.ActionName, this.PcKeys[index], this.CurrentBindingType);
		}

		// Token: 0x0603BC0C RID: 244748 RVA: 0x010F58FC File Offset: 0x010F3AFC
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

		// Token: 0x0603BC0D RID: 244749 RVA: 0x010F5930 File Offset: 0x010F3B30
		[NullableContext(2)]
		public InputActionKey GetGamepadKeyByIndex(int index)
		{
			if (index < 0 || index >= this.GamepadKeys.Count)
			{
				return null;
			}
			return InputSettings.Instance.GetInputActionKey(this.ActionName, this.GamepadKeys[index], this.CurrentBindingType);
		}

		// Token: 0x0603BC0E RID: 244750 RVA: 0x010F5968 File Offset: 0x010F3B68
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

		// Token: 0x0603BC0F RID: 244751 RVA: 0x010F599C File Offset: 0x010F3B9C
		public void GetAllPcKeyNameMap(Dictionary<EInputBindingType, List<string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair in this.PcKeysToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BC10 RID: 244752 RVA: 0x010F59FC File Offset: 0x010F3BFC
		public void GetPcKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.PcKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC11 RID: 244753 RVA: 0x010F5A50 File Offset: 0x010F3C50
		public IReadOnlyList<string> GetPcKeyNameList()
		{
			return this.PcKeys;
		}

		// Token: 0x0603BC12 RID: 244754 RVA: 0x010F5A58 File Offset: 0x010F3C58
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

		// Token: 0x0603BC13 RID: 244755 RVA: 0x010F5AB8 File Offset: 0x010F3CB8
		public IReadOnlyList<string> GetPcKeyNameListReadonly()
		{
			return this.PcKeys;
		}

		// Token: 0x0603BC14 RID: 244756 RVA: 0x010F5AC0 File Offset: 0x010F3CC0
		public void GetAllGamepadKeyNameMap(Dictionary<EInputBindingType, List<string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, List<string>> keyValuePair in this.GamepadKeysToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BC15 RID: 244757 RVA: 0x010F5B20 File Offset: 0x010F3D20
		public void GetGamepadKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.GamepadKeys)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC16 RID: 244758 RVA: 0x010F5B74 File Offset: 0x010F3D74
		public IReadOnlyList<string> GetGamepadKeyNameList()
		{
			return this.GamepadKeys;
		}

		// Token: 0x0603BC17 RID: 244759 RVA: 0x010F5B7C File Offset: 0x010F3D7C
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

		// Token: 0x0603BC18 RID: 244760 RVA: 0x010F5BDC File Offset: 0x010F3DDC
		public IReadOnlyList<string> GetGamepadKeyNameListReadonly()
		{
			return this.GamepadKeys;
		}

		// Token: 0x0603BC19 RID: 244761 RVA: 0x010F5BE4 File Offset: 0x010F3DE4
		public void GetKeyNameList(List<string> keyListRef)
		{
			foreach (string item in this.KeyNameList)
			{
				keyListRef.Add(item);
			}
		}

		// Token: 0x0603BC1A RID: 244762 RVA: 0x010F5C38 File Offset: 0x010F3E38
		public IReadOnlyList<string> GetKeyNameList()
		{
			return this.KeyNameList;
		}

		// Token: 0x0603BC1B RID: 244763 RVA: 0x010F5C40 File Offset: 0x010F3E40
		public void GetKeyNameListByBindingType(List<string> keyListRef, EInputBindingType bindingType)
		{
			List<string> collection;
			if (this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out collection))
			{
				keyListRef.AddRange(collection);
			}
		}

		// Token: 0x0603BC1C RID: 244764 RVA: 0x010F5C64 File Offset: 0x010F3E64
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

		// Token: 0x0603BC1D RID: 244765 RVA: 0x010F5C8D File Offset: 0x010F3E8D
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

		// Token: 0x0603BC1E RID: 244766 RVA: 0x010F5CBA File Offset: 0x010F3EBA
		public void GetCurrentGamepadKeyNameList(List<string> keyListRef)
		{
			this.GetGamepadKeyNameList(keyListRef);
		}

		// Token: 0x0603BC1F RID: 244767 RVA: 0x010F5CC3 File Offset: 0x010F3EC3
		public IReadOnlyList<string> GetCurrentGamepadKeyNameList()
		{
			return this.GetGamepadKeyNameList();
		}

		// Token: 0x0603BC20 RID: 244768 RVA: 0x010F5CCC File Offset: 0x010F3ECC
		public bool HasKey(string keyName)
		{
			Dictionary<string, InputActionKey> inputActionKeyMapByBindingType = InputSettings.Instance.GetInputActionKeyMapByBindingType(this.ActionName, this.CurrentBindingType);
			return inputActionKeyMapByBindingType != null && inputActionKeyMapByBindingType.ContainsKey(keyName);
		}

		// Token: 0x0603BC21 RID: 244769 RVA: 0x010F5CFC File Offset: 0x010F3EFC
		public bool HasAnyKey()
		{
			return this.KeyNameList.Count > 0;
		}

		// Token: 0x0603BC22 RID: 244770 RVA: 0x010F5D0C File Offset: 0x010F3F0C
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

		// Token: 0x0603BC23 RID: 244771 RVA: 0x010F5D94 File Offset: 0x010F3F94
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

		// Token: 0x0603BC24 RID: 244772 RVA: 0x010F5E10 File Offset: 0x010F4010
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

		// Token: 0x0603BC25 RID: 244773 RVA: 0x010F5E44 File Offset: 0x010F4044
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

		// Token: 0x0603BC26 RID: 244774 RVA: 0x010F5E74 File Offset: 0x010F4074
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

		// Token: 0x0603BC27 RID: 244775 RVA: 0x010F5EB0 File Offset: 0x010F40B0
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

		// Token: 0x0603BC28 RID: 244776 RVA: 0x010F5F0C File Offset: 0x010F410C
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

		// Token: 0x0603BC29 RID: 244777 RVA: 0x010F5F98 File Offset: 0x010F4198
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

		// Token: 0x0603BC2A RID: 244778 RVA: 0x010F602C File Offset: 0x010F422C
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

		// Token: 0x0603BC2B RID: 244779 RVA: 0x010F60B9 File Offset: 0x010F42B9
		public void ClearAllKeys()
		{
			this.PcKeys.Clear();
			this.GamepadKeys.Clear();
			this.KeyNameList.Clear();
			InputSettings.Instance.ClearActionMapping(this.ActionName);
		}

		// Token: 0x0603BC2C RID: 244780 RVA: 0x010F60EC File Offset: 0x010F42EC
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

		// Token: 0x0603BC2D RID: 244781 RVA: 0x010F6188 File Offset: 0x010F4388
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

		// Token: 0x0603BC2E RID: 244782 RVA: 0x010F6253 File Offset: 0x010F4453
		public ActionMapping? GetActionMappingConfig()
		{
			return this.Config;
		}

		// Token: 0x0603BC2F RID: 244783 RVA: 0x010F625B File Offset: 0x010F445B
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x0603BC30 RID: 244784 RVA: 0x010F6263 File Offset: 0x010F4463
		public EActionMappingType GetActionMappingType()
		{
			return this.ActionMappingType;
		}

		// Token: 0x0603BC31 RID: 244785 RVA: 0x010F626C File Offset: 0x010F446C
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

		// Token: 0x0603BC32 RID: 244786 RVA: 0x010F63A8 File Offset: 0x010F45A8
		private void RefreshKeyList()
		{
			this.RefreshKeyListByBindingType(this.CurrentBindingType);
		}

		// Token: 0x0603BC33 RID: 244787 RVA: 0x010F63B8 File Offset: 0x010F45B8
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

		// Token: 0x0603BC34 RID: 244788 RVA: 0x010F6491 File Offset: 0x010F4691
		public Dictionary<EInputBindingType, List<string>> GetKeyNameListToBindingTypeMap()
		{
			return this.KeyNameListToBindingTypeMap;
		}

		// Token: 0x0603BC35 RID: 244789 RVA: 0x010F6499 File Offset: 0x010F4699
		public Dictionary<EInputBindingType, List<string>> GetCopyKeyNameListToBindingTypeMap()
		{
			return new Dictionary<EInputBindingType, List<string>>(this.KeyNameListToBindingTypeMap);
		}

		// Token: 0x0603BC36 RID: 244790 RVA: 0x010F64A8 File Offset: 0x010F46A8
		private List<string> GetOrCreateKeyNameList(EInputBindingType bindingType)
		{
			List<string> result;
			if (!this.KeyNameListToBindingTypeMap.TryGetValue(bindingType, out result))
			{
				result = (this.KeyNameListToBindingTypeMap[bindingType] = new List<string>());
			}
			return result;
		}

		// Token: 0x0401F84A RID: 129098
		[Nullable(2)]
		private string ActionName;

		// Token: 0x0401F84B RID: 129099
		private int ConfigId;

		// Token: 0x0401F84C RID: 129100
		private ActionMapping? Config;

		// Token: 0x0401F84D RID: 129101
		private EActionMappingType ActionMappingType;

		// Token: 0x0401F84E RID: 129102
		private List<string> PcKeys = new List<string>();

		// Token: 0x0401F84F RID: 129103
		private List<string> GamepadKeys = new List<string>();

		// Token: 0x0401F850 RID: 129104
		private List<string> KeyNameList = new List<string>();

		// Token: 0x0401F851 RID: 129105
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F852 RID: 129106
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F853 RID: 129107
		private readonly Dictionary<EInputBindingType, List<string>> KeyNameListToBindingTypeMap = new Dictionary<EInputBindingType, List<string>>();

		// Token: 0x0401F854 RID: 129108
		private readonly Dictionary<EInputBindingType, List<string>> PcKeysToBindingTypeMap = new Dictionary<EInputBindingType, List<string>>();

		// Token: 0x0401F855 RID: 129109
		private readonly Dictionary<EInputBindingType, List<string>> GamepadKeysToBindingTypeMap = new Dictionary<EInputBindingType, List<string>>();

		// Token: 0x0401F856 RID: 129110
		private EInputBindingType LastBindingType;

		// Token: 0x0401F857 RID: 129111
		public EInputBindingType CurrentBindingType;
	}
}
