using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;

// Token: 0x02002206 RID: 8710
[NullableContext(1)]
[Nullable(0)]
public class KeySettingRowData
{
	// Token: 0x17001586 RID: 5510
	// (get) Token: 0x06010F26 RID: 69414 RVA: 0x0041FFE0 File Offset: 0x0041E1E0
	private List<string> AllowKeys
	{
		get
		{
			if (this.AllowKeysPool == "")
			{
				return new List<string>();
			}
			KeyPool? config = ConfigKeyPoolById.GetConfig(this.AllowKeysPool, true);
			if (config != null && config.Value.ValidKeys() != null)
			{
				return config.Value.ValidKeys().ToList<string>();
			}
			return new List<string>();
		}
	}

	// Token: 0x17001587 RID: 5511
	// (get) Token: 0x06010F27 RID: 69415 RVA: 0x00420048 File Offset: 0x0041E248
	private List<string> AllowMainKeys
	{
		get
		{
			if (this.AllowMainKeysPool == "")
			{
				return new List<string>();
			}
			KeyPool? config = ConfigKeyPoolById.GetConfig(this.AllowMainKeysPool, true);
			if (config != null && config.Value.ValidKeys() != null)
			{
				return config.Value.ValidKeys().ToList<string>();
			}
			return new List<string>();
		}
	}

	// Token: 0x17001588 RID: 5512
	// (get) Token: 0x06010F28 RID: 69416 RVA: 0x004200B0 File Offset: 0x0041E2B0
	private List<string> AllowSecondKeys
	{
		get
		{
			if (this.AllowSecondKeysPool == "")
			{
				return new List<string>();
			}
			KeyPool? config = ConfigKeyPoolById.GetConfig(this.AllowSecondKeysPool, true);
			if (config != null && config.Value.ValidKeys() != null)
			{
				return config.Value.ValidKeys().ToList<string>();
			}
			return new List<string>();
		}
	}

	// Token: 0x06010F29 RID: 69417 RVA: 0x00420116 File Offset: 0x0041E316
	public void InitializeKeyType(KeyType keyType)
	{
		this.ConfigId = keyType.TypeId;
		this.KeyTypeConfig = new KeyType?(keyType);
		this.KeySettingRowType = EKeySettingRowType.KeyType;
		this.KeyTypeName = keyType.Name;
		this.KeyTypeIconSpritePath = keyType.IconSpritePath;
	}

	// Token: 0x06010F2A RID: 69418 RVA: 0x00420154 File Offset: 0x0041E354
	public void InitializeKeySetting(KeySetting keySettingConfig)
	{
		this.ConfigId = keySettingConfig.Id;
		this.SortId = keySettingConfig.SortId;
		this.KeySettingConfig = new KeySetting?(keySettingConfig);
		this.KeySettingRowType = EKeySettingRowType.KeySetting;
		this.SettingName = keySettingConfig.Name;
		this.ActionOrAxisName = keySettingConfig.ActionOrAxisName;
		this.IsActionOrAxis = (keySettingConfig.ActionOrAxis == 1);
		this.PcKeyIndex = keySettingConfig.PcKeyIndex;
		this.GamepadKeyIndex = keySettingConfig.XBoxKeyIndex;
		this.PcAxisValue = keySettingConfig.PcAxisValue;
		this.GamepadAxisValue = keySettingConfig.XBoxAxisValue;
		this.IsLock = keySettingConfig.IsLock;
		this.DetailTextId = keySettingConfig.DetailTextId;
		this.BothActionName = keySettingConfig.BothActionName().ToList<string>();
		this.BothActionSyncAllExclusive = keySettingConfig.BothActionSyncAllExclusive;
		this.CanCombination = keySettingConfig.CanCombination;
		this.OpenViewType = (EKeySettingOpenViewType)keySettingConfig.OpenViewType;
		this.IsCheckSameKey = keySettingConfig.IsCheckSameKey;
		this.ButtonTextId = keySettingConfig.ButtonTextId;
		this.ConnectedKeySettingIdList = keySettingConfig.ConnectedKeySettingIdList().ToList<int>();
		this.CanDisable = keySettingConfig.CanDisable;
		this.AllowKeysPool = keySettingConfig.AllowKeysPool;
		this.AllowMainKeysPool = keySettingConfig.AllowMainKeysPool;
		this.AllowSecondKeysPool = keySettingConfig.AllowSecondKeysPool;
		this.BindingType = InputSettingsManager.Instance.GetBindTypeByExclusiveType((EKeySettingExclusiveType)keySettingConfig.ExclusiveType);
		if (this.BothActionName != null && this.BothActionName.Count == 2)
		{
			string actionName = this.BothActionName[0];
			string actionName2 = this.BothActionName[1];
			this.OneActionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
			this.TwoActionBinding = InputSettingsManager.Instance.GetActionBinding(actionName2);
		}
		else if (this.IsActionOrAxis)
		{
			this.ActionBinding = InputSettingsManager.Instance.GetActionBinding(this.ActionOrAxisName);
		}
		else
		{
			this.CombinationAxisBinding = InputSettingsManager.Instance.GetCombinationAxisBindingByAxisName(this.ActionOrAxisName);
			this.AxisBinding = InputSettingsManager.Instance.GetAxisBinding(this.ActionOrAxisName);
		}
		this.InitIsOriginalCombinationActionSet();
	}

	// Token: 0x06010F2B RID: 69419 RVA: 0x0042035C File Offset: 0x0041E55C
	private void InitIsOriginalCombinationActionSet()
	{
		this.IsOriginalCombinationActionSet.Clear();
		if (InputSettingsManager.Instance.IsOriginalCombinationActionName(this.ActionOrAxisName, CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard))
		{
			this.IsOriginalCombinationActionSet.Add(CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard);
		}
		if (InputSettingsManager.Instance.IsOriginalCombinationActionName(this.ActionOrAxisName, CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad))
		{
			this.IsOriginalCombinationActionSet.Add(CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad);
		}
	}

	// Token: 0x06010F2C RID: 69420 RVA: 0x004203B4 File Offset: 0x0041E5B4
	[NullableContext(2)]
	public InputCombinationActionBinding FindCombinationActionBinding()
	{
		return InputSettingsManager.Instance.GetCombinationActionBindingByActionName(this.ActionOrAxisName);
	}

	// Token: 0x06010F2D RID: 69421 RVA: 0x004203C6 File Offset: 0x0041E5C6
	public void Clear()
	{
		this.ActionBinding = null;
		this.AxisBinding = null;
		this.CombinationAxisBinding = null;
		this.OneActionBinding = null;
		this.TwoActionBinding = null;
	}

	// Token: 0x06010F2E RID: 69422 RVA: 0x004203EB File Offset: 0x0041E5EB
	public EKeySettingRowType GetRowType()
	{
		return this.KeySettingRowType;
	}

	// Token: 0x06010F2F RID: 69423 RVA: 0x004203F3 File Offset: 0x0041E5F3
	public KeyType? GetKeyTypeConfig()
	{
		return this.KeyTypeConfig;
	}

	// Token: 0x06010F30 RID: 69424 RVA: 0x004203FB File Offset: 0x0041E5FB
	public KeySetting? GetKeySettingConfig()
	{
		return this.KeySettingConfig;
	}

	// Token: 0x06010F31 RID: 69425 RVA: 0x00420403 File Offset: 0x0041E603
	public string GetSettingName()
	{
		return this.SettingName;
	}

	// Token: 0x06010F32 RID: 69426 RVA: 0x0042040B File Offset: 0x0041E60B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetDisplayKeyName(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.OneActionBinding != null && this.TwoActionBinding != null)
		{
			return this.GetBothActionKeyName(this.OneActionBinding, this.TwoActionBinding, inputControllerType);
		}
		return this.GetCurrentKeyName(inputControllerType);
	}

	// Token: 0x06010F33 RID: 69427 RVA: 0x00420438 File Offset: 0x0041E638
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetBothActionKeyName(InputActionBinding oneActionBinding, InputActionBinding twoActionBinding, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (oneActionBinding == null || twoActionBinding == null)
		{
			return null;
		}
		List<string> actionSegmentKeys = this.GetActionSegmentKeys(oneActionBinding, inputControllerType, this.BindingType);
		List<string> actionSegmentKeys2 = this.GetActionSegmentKeys(twoActionBinding, inputControllerType, this.BindingType);
		return new List<string>
		{
			actionSegmentKeys[0],
			actionSegmentKeys2[0]
		};
	}

	// Token: 0x06010F34 RID: 69428 RVA: 0x0042048C File Offset: 0x0041E68C
	private List<string> GetActionSegmentKeys(InputActionBinding actionBinding, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, EInputBindingType bindingType)
	{
		List<string> list = new List<string>();
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				actionBinding.GetGamepadKeyNameListByBindingType(list, bindingType);
			}
		}
		else
		{
			actionBinding.GetPcKeyNameListByBindingType(list, bindingType);
		}
		return list;
	}

	// Token: 0x06010F35 RID: 69429 RVA: 0x004204BC File Offset: 0x0041E6BC
	private void SetActionSegmentKeys(InputActionBinding actionBinding, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, List<string> segmentKeys, EInputBindingType bindingType)
	{
		if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			actionBinding.SetKeyboardKeys(segmentKeys, bindingType);
			return;
		}
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			return;
		}
		actionBinding.SetGamepadKeys(segmentKeys, bindingType);
	}

	// Token: 0x06010F36 RID: 69430 RVA: 0x004204DA File Offset: 0x0041E6DA
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetCurrentKeyName(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsActionOrAxis)
		{
			return this.GetCurrentActionName(inputControllerType);
		}
		return this.GetCurrentAxisName(inputControllerType);
	}

	// Token: 0x06010F37 RID: 69431 RVA: 0x004204F4 File Offset: 0x0041E6F4
	public string GetCurrentKeyNameRichText(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, string linkString = "+")
	{
		List<string> displayKeyName = this.GetDisplayKeyName(inputControllerType);
		if (displayKeyName == null)
		{
			return "";
		}
		return this.GetKeyNameRichTextByKeyNameList(inputControllerType, displayKeyName, linkString);
	}

	// Token: 0x06010F38 RID: 69432 RVA: 0x0042051C File Offset: 0x0041E71C
	public string GetKeyNameRichTextByKeyNameList(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, List<string> keyNameList, string linkString = "+")
	{
		if (keyNameList == null)
		{
			return "";
		}
		string text = "";
		for (int i = 0; i < keyNameList.Count; i++)
		{
			string keyName = keyNameList[i];
			string keyIconPath = this.GetKeyIconPath(keyName, inputControllerType);
			if (!string.IsNullOrEmpty(keyIconPath))
			{
				text = text + "<texture=" + keyIconPath + ">";
			}
			if (i < keyNameList.Count - 1)
			{
				text += linkString;
			}
		}
		return text;
	}

	// Token: 0x06010F39 RID: 69433 RVA: 0x00420588 File Offset: 0x0041E788
	[return: Nullable(2)]
	public string GetKeyIconPath(string keyName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		InputSettingsConfig instance = InputSettingsConfig.Instance;
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				return null;
			}
			GamepadKey? gamepadKey = (instance != null) ? instance.GetGamepadKeyConfig(keyName) : null;
			if (gamepadKey != null)
			{
				global::EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
				string gamepadKeyIconPathByType = InputKeyUtils.GetGamepadKeyIconPathByType(keyName, lastGamepadEnum);
				if (StringUtils.IsBlank(gamepadKeyIconPathByType))
				{
					return null;
				}
				return gamepadKeyIconPathByType;
			}
		}
		else
		{
			string pcKeyIconPathByCurrentPlatform = InputKeyUtils.GetPcKeyIconPathByCurrentPlatform(keyName);
			if (pcKeyIconPathByCurrentPlatform != null)
			{
				return pcKeyIconPathByCurrentPlatform;
			}
		}
		return null;
	}

	// Token: 0x06010F3A RID: 69434 RVA: 0x004205F4 File Offset: 0x0041E7F4
	private bool IsValidActionKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.ActionBinding == null)
		{
			return false;
		}
		int keyIndex = this.GetKeyIndex(inputControllerType);
		List<string> list = new List<string>();
		this.ActionBinding.GetKeyNameListByBindingType(list, this.BindingType);
		string text = (list.Count > keyIndex) ? list[keyIndex] : null;
		return !string.IsNullOrEmpty(text) && InputSettings.Instance.IsValidKey(text);
	}

	// Token: 0x06010F3B RID: 69435 RVA: 0x00420654 File Offset: 0x0041E854
	public bool IsCombination(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (!this.IsActionOrAxis)
		{
			if (this.CombinationAxisBinding != null)
			{
				if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
				{
					return this.CombinationAxisBinding.HasKeyboardCombinationAxis(this.BindingType);
				}
				if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
				{
					return this.CombinationAxisBinding.HasGamepadCombinationAxis(this.BindingType);
				}
			}
			return false;
		}
		InputCombinationActionBinding inputCombinationActionBinding = this.FindCombinationActionBinding();
		if (inputCombinationActionBinding == null && !this.IsValidActionKey(inputControllerType))
		{
			return false;
		}
		if (inputCombinationActionBinding != null)
		{
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
			{
				return inputCombinationActionBinding.HasKeyboardCombinationAction(this.BindingType);
			}
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				return inputCombinationActionBinding.HasGamepadCombinationActionByBindingType(this.BindingType);
			}
		}
		return false;
	}

	// Token: 0x06010F3C RID: 69436 RVA: 0x004206E0 File Offset: 0x0041E8E0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> GetCurrentActionName(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsCombination(inputControllerType))
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
			{
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
				{
					return null;
				}
				InputCombinationActionBinding inputCombinationActionBinding = this.FindCombinationActionBinding();
				if (inputCombinationActionBinding != null)
				{
					inputCombinationActionBinding.GetGamepadKeyNameMapByBindingType(dictionary, this.BindingType);
				}
			}
			else
			{
				InputCombinationActionBinding inputCombinationActionBinding2 = this.FindCombinationActionBinding();
				if (inputCombinationActionBinding2 != null)
				{
					inputCombinationActionBinding2.GetPcKeyNameMap(dictionary, this.BindingType);
				}
			}
			if (dictionary == null || dictionary.Count == 0)
			{
				return null;
			}
			using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					return new List<string>
					{
						keyValuePair.Key,
						keyValuePair.Value
					};
				}
			}
			return null;
		}
		else
		{
			if (this.ActionBinding == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			InputActionBinding actionBinding = this.ActionBinding;
			if (actionBinding != null)
			{
				actionBinding.GetKeyNameListByBindingType(list, this.BindingType);
			}
			if (list == null || list.Count <= 0)
			{
				return null;
			}
			if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
			{
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
				{
					return null;
				}
				if (list.Count <= this.GamepadKeyIndex)
				{
					return null;
				}
				return new List<string>
				{
					list[this.GamepadKeyIndex]
				};
			}
			else
			{
				if (list.Count <= this.PcKeyIndex)
				{
					return null;
				}
				return new List<string>
				{
					list[this.PcKeyIndex]
				};
			}
		}
	}

	// Token: 0x06010F3D RID: 69437 RVA: 0x00420844 File Offset: 0x0041EA44
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> GetCurrentAxisName(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsCombination(inputControllerType))
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
			{
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
				{
					return null;
				}
				InputCombinationAxisBinding combinationAxisBinding = this.CombinationAxisBinding;
				if (combinationAxisBinding != null)
				{
					combinationAxisBinding.GetGamepadKeyNameMap(dictionary, this.BindingType);
				}
			}
			else
			{
				InputCombinationAxisBinding combinationAxisBinding2 = this.CombinationAxisBinding;
				if (combinationAxisBinding2 != null)
				{
					combinationAxisBinding2.GetPcKeyNameMap(dictionary, this.BindingType);
				}
			}
			if (dictionary == null || dictionary.Count == 0)
			{
				return null;
			}
			using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					return new List<string>
					{
						keyValuePair.Key,
						keyValuePair.Value
					};
				}
			}
			return null;
		}
		else
		{
			string inputAxisKeyName = this.GetInputAxisKeyName(inputControllerType);
			if (string.IsNullOrEmpty(inputAxisKeyName))
			{
				return null;
			}
			return new List<string>
			{
				inputAxisKeyName
			};
		}
	}

	// Token: 0x06010F3E RID: 69438 RVA: 0x00420930 File Offset: 0x0041EB30
	[NullableContext(2)]
	private string GetInputAxisKeyName(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		InputAxisBinding axisBinding = this.AxisBinding;
		Dictionary<string, InputAxisKey> dictionary = (axisBinding != null) ? axisBinding.GetInputAxisKeyMap(this.BindingType) : null;
		if (dictionary == null)
		{
			return null;
		}
		foreach (KeyValuePair<string, InputAxisKey> keyValuePair in dictionary)
		{
			string key = keyValuePair.Key;
			InputAxisKey value = keyValuePair.Value;
			InputKey key2 = value.GetKey();
			if (key2 != null)
			{
				if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
				{
					if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
					{
						return null;
					}
					if (key2.IsGamepadKey && value.Scale == this.GamepadAxisValue)
					{
						return key;
					}
				}
				else if ((key2.IsKeyboardKey || key2.IsMouseButton) && value.Scale == this.PcAxisValue)
				{
					return key;
				}
			}
		}
		return null;
	}

	// Token: 0x06010F3F RID: 69439 RVA: 0x00420A0C File Offset: 0x0041EC0C
	public void ChangeBothAction(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.OneActionBinding == null || this.TwoActionBinding == null)
		{
			return;
		}
		List<string> actionSegmentKeys = this.GetActionSegmentKeys(this.OneActionBinding, inputControllerType, this.BindingType);
		List<string> actionSegmentKeys2 = this.GetActionSegmentKeys(this.TwoActionBinding, inputControllerType, this.BindingType);
		if (actionSegmentKeys.Count <= 0 || actionSegmentKeys2.Count <= 0)
		{
			return;
		}
		string value = actionSegmentKeys[0];
		actionSegmentKeys[0] = actionSegmentKeys2[0];
		actionSegmentKeys2[0] = value;
		if (!this.BothActionSyncAllExclusive)
		{
			this.SetActionSegmentKeys(this.OneActionBinding, inputControllerType, actionSegmentKeys, this.BindingType);
			this.SetActionSegmentKeys(this.TwoActionBinding, inputControllerType, actionSegmentKeys2, this.BindingType);
			return;
		}
		foreach (EInputBindingType bindingType in InputBindingDefine.inputBindingTypesArray)
		{
			this.SetActionSegmentKeys(this.OneActionBinding, inputControllerType, actionSegmentKeys, bindingType);
			this.SetActionSegmentKeys(this.TwoActionBinding, inputControllerType, actionSegmentKeys2, bindingType);
		}
	}

	// Token: 0x06010F40 RID: 69440 RVA: 0x00420AF2 File Offset: 0x0041ECF2
	public bool IsBothAction()
	{
		return this.OneActionBinding != null && this.TwoActionBinding != null;
	}

	// Token: 0x06010F41 RID: 69441 RVA: 0x00420B08 File Offset: 0x0041ED08
	private void DisableActionBindingKey(int keyIndex, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.ActionBinding == null)
		{
			return;
		}
		List<string> list = new List<string>();
		this.ActionBinding.GetKeyNameListByBindingType(list, this.BindingType);
		if (keyIndex < 0)
		{
			return;
		}
		while (list.Count <= keyIndex)
		{
			list.Add(string.Empty);
		}
		list[keyIndex] = this.GetInvalidKey(inputControllerType);
		this.ActionBinding.SetKeys(list, this.BindingType);
	}

	// Token: 0x06010F42 RID: 69442 RVA: 0x00420B74 File Offset: 0x0041ED74
	private EKey GetInvalidKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			return EKey.Keyboard_Invalid;
		}
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			return EKey.Keyboard_Invalid;
		}
		return EKey.Gamepad_Invalid;
	}

	// Token: 0x06010F43 RID: 69443 RVA: 0x00420B94 File Offset: 0x0041ED94
	private void DisableAxisBindingKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.AxisBinding == null)
		{
			return;
		}
		if (this.AxisBinding.GetInputAxisKeyMap(this.BindingType) == null)
		{
			return;
		}
		string inputAxisKeyName = this.GetInputAxisKeyName(inputControllerType);
		if (string.IsNullOrEmpty(inputAxisKeyName))
		{
			return;
		}
		Dictionary<string, float> axisKeyScaleMap = this.GetAxisKeyScaleMap();
		float value;
		if (axisKeyScaleMap.TryGetValue(inputAxisKeyName, out value))
		{
			axisKeyScaleMap.Remove(inputAxisKeyName);
			string key = this.GetInvalidKey(inputControllerType);
			axisKeyScaleMap.Add(key, value);
		}
		this.AxisBinding.SetKeys(axisKeyScaleMap, this.BindingType);
	}

	// Token: 0x06010F44 RID: 69444 RVA: 0x00420C10 File Offset: 0x0041EE10
	private void InsertDisableKeyName(List<string> keyNameList, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		for (int i = 0; i < keyNameList.Count; i++)
		{
			if (string.IsNullOrEmpty((keyNameList.Count > i) ? keyNameList[i] : null))
			{
				keyNameList[i] = this.GetInvalidKey(inputControllerType);
			}
		}
	}

	// Token: 0x06010F45 RID: 69445 RVA: 0x00420C5B File Offset: 0x0041EE5B
	public bool SetKey(List<string> keyNameList, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsActionOrAxis)
		{
			return this.SetActionKey(keyNameList, inputControllerType);
		}
		return !this.IsCombination(inputControllerType) && (keyNameList != null && keyNameList.Count > 0) && this.SetAxisKey(keyNameList[0], inputControllerType);
	}

	// Token: 0x06010F46 RID: 69446 RVA: 0x00420C95 File Offset: 0x0041EE95
	public void DisableKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.OneActionBinding != null && this.TwoActionBinding != null)
		{
			return;
		}
		if (this.IsActionOrAxis)
		{
			this.DisableActionKey(inputControllerType);
			return;
		}
		this.DisableAxisKey(inputControllerType);
	}

	// Token: 0x06010F47 RID: 69447 RVA: 0x00420CBF File Offset: 0x0041EEBF
	public string ConvertKeyToActionOrAxis(string keyName)
	{
		return InputKeyUtils.ConvertKeyToActionOrAxis(keyName, this.IsActionOrAxis);
	}

	// Token: 0x06010F48 RID: 69448 RVA: 0x00420CD0 File Offset: 0x0041EED0
	private bool SetActionKey([Nullable(new byte[]
	{
		2,
		1
	})] List<string> keyNameList, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (keyNameList == null || keyNameList.Count <= 0)
		{
			if (this.ActionBinding != null)
			{
				int keyIndex = this.GetKeyIndex(inputControllerType);
				this.DisableActionBindingKey(keyIndex, inputControllerType);
			}
			InputSettingsManager.Instance.ClearCombinationActionKeyMap();
			return true;
		}
		List<string> currentKeyName = this.GetCurrentKeyName(inputControllerType);
		if (currentKeyName != null && currentKeyName.Count > 0 && currentKeyName[0] == keyNameList[0] && ((currentKeyName.Count > 1) ? currentKeyName[1] : null) == ((keyNameList.Count > 1) ? keyNameList[1] : null))
		{
			return true;
		}
		if (currentKeyName != null && currentKeyName.Count > 1)
		{
			InputSettingsManager.Instance.RemoveCombinationActionKeyMap(this.ActionOrAxisName, currentKeyName[0], (currentKeyName.Count > 1) ? currentKeyName[1] : "", this.BindingType);
		}
		if (keyNameList.Count == 1 || !this.CanCombination)
		{
			string value = this.ConvertKeyToActionOrAxis(keyNameList[0]);
			int keyIndex2 = this.GetKeyIndex(inputControllerType);
			if (keyIndex2 < 0)
			{
				return false;
			}
			if (this.ActionBinding != null)
			{
				List<string> list = new List<string>();
				this.ActionBinding.GetKeyNameListByBindingType(list, this.BindingType);
				if (list == null)
				{
					return false;
				}
				while (list.Count <= keyIndex2)
				{
					list.Add(string.Empty);
				}
				list[keyIndex2] = value;
				this.InsertDisableKeyName(list, inputControllerType);
				this.ActionBinding.SetKeys(list, this.BindingType);
				return true;
			}
		}
		else if (keyNameList.Count > 1)
		{
			InputSettingsManager.Instance.AddCombinationActionKeyMap(this.ActionOrAxisName, this.ConvertKeyToActionOrAxis(keyNameList[0]), (keyNameList.Count > 1) ? keyNameList[1] : "", this.BindingType);
			int keyIndex3 = this.GetKeyIndex(inputControllerType);
			this.DisableActionBindingKey(keyIndex3, inputControllerType);
		}
		return true;
	}

	// Token: 0x06010F49 RID: 69449 RVA: 0x00420E94 File Offset: 0x0041F094
	private void DisableActionKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsCombination(inputControllerType))
		{
			List<string> currentKeyName = this.GetCurrentKeyName(inputControllerType);
			if (currentKeyName != null && currentKeyName.Count > 1)
			{
				InputSettingsManager.Instance.RemoveCombinationActionKeyMap(this.ActionOrAxisName, currentKeyName[0], (currentKeyName.Count > 1) ? currentKeyName[1] : "", this.BindingType);
			}
			return;
		}
		if (this.ActionBinding != null)
		{
			int keyIndex = this.GetKeyIndex(inputControllerType);
			this.DisableActionBindingKey(keyIndex, inputControllerType);
		}
	}

	// Token: 0x06010F4A RID: 69450 RVA: 0x00420F0C File Offset: 0x0041F10C
	[NullableContext(2)]
	private bool SetAxisKey(string newKeyName, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.AxisBinding == null)
		{
			return false;
		}
		if (string.IsNullOrEmpty(newKeyName) && this.AxisBinding != null)
		{
			Dictionary<string, float> keyScaleMap = new Dictionary<string, float>();
			this.AxisBinding.SetKeys(keyScaleMap, this.BindingType);
			return true;
		}
		string text = null;
		float? num = null;
		Dictionary<string, float> axisKeyScaleMap = this.GetAxisKeyScaleMap();
		foreach (KeyValuePair<string, float> keyValuePair in axisKeyScaleMap)
		{
			string key = keyValuePair.Key;
			float value = keyValuePair.Value;
			InputKey key2 = InputSettings.Instance.GetKey(key);
			if (key2 != null)
			{
				if ((key2.IsKeyboardKey || key2.IsMouseButton) && inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard && value == this.PcAxisValue)
				{
					text = key;
					num = new float?(value);
					break;
				}
				if (key2.IsGamepadKey && inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad && value == this.GamepadAxisValue)
				{
					text = key;
					num = new float?(value);
					break;
				}
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			axisKeyScaleMap.Remove(text);
		}
		if (num != null && num.GetValueOrDefault() != 0f && !string.IsNullOrEmpty(newKeyName))
		{
			axisKeyScaleMap.Add(this.ConvertKeyToActionOrAxis(newKeyName), num.Value);
		}
		this.AxisBinding.SetKeys(axisKeyScaleMap, this.BindingType);
		return true;
	}

	// Token: 0x06010F4B RID: 69451 RVA: 0x00421068 File Offset: 0x0041F268
	private void DisableAxisKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsCombination(inputControllerType))
		{
			return;
		}
		this.DisableAxisBindingKey(inputControllerType);
	}

	// Token: 0x06010F4C RID: 69452 RVA: 0x0042107B File Offset: 0x0041F27B
	public void SetAxisBindingKeys(Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
	{
		InputAxisBinding axisBinding = this.AxisBinding;
		if (axisBinding == null)
		{
			return;
		}
		axisBinding.SetKeys(keyScaleMap, bindingType);
	}

	// Token: 0x06010F4D RID: 69453 RVA: 0x00421090 File Offset: 0x0041F290
	public Dictionary<string, float> GetAxisKeyScaleMap()
	{
		Dictionary<string, float> dictionary = new Dictionary<string, float>();
		if (this.AxisBinding == null)
		{
			return dictionary;
		}
		Dictionary<string, InputAxisKey> inputAxisKeyMap = this.AxisBinding.GetInputAxisKeyMap(this.BindingType);
		if (inputAxisKeyMap == null)
		{
			return dictionary;
		}
		foreach (KeyValuePair<string, InputAxisKey> keyValuePair in inputAxisKeyMap)
		{
			string key = keyValuePair.Key;
			InputAxisKey value = keyValuePair.Value;
			dictionary.Add(key, value.Scale);
		}
		return dictionary;
	}

	// Token: 0x06010F4E RID: 69454 RVA: 0x00421120 File Offset: 0x0041F320
	public int GetKeyIndex(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			return this.PcKeyIndex;
		}
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			return -1;
		}
		return this.GamepadKeyIndex;
	}

	// Token: 0x06010F4F RID: 69455 RVA: 0x0042113B File Offset: 0x0041F33B
	public float GetKeyScale(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			return this.PcAxisValue;
		}
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			return 0f;
		}
		return this.GamepadAxisValue;
	}

	// Token: 0x06010F50 RID: 69456 RVA: 0x0042115A File Offset: 0x0041F35A
	public bool IsAllowKey(string keyName)
	{
		return this.AllowKeys == null || this.AllowKeys.Count <= 0 || this.AllowKeys.Contains(keyName);
	}

	// Token: 0x06010F51 RID: 69457 RVA: 0x00421180 File Offset: 0x0041F380
	public bool IsAllowCombinationKey(string mainKeyName, string secondKeyName)
	{
		return (this.AllowMainKeys == null || this.AllowMainKeys.Count <= 0 || this.AllowMainKeys.Contains(mainKeyName)) && (this.AllowSecondKeys == null || this.AllowSecondKeys.Count <= 0 || this.AllowSecondKeys.Contains(secondKeyName));
	}

	// Token: 0x06010F52 RID: 69458 RVA: 0x004211E8 File Offset: 0x0041F3E8
	[NullableContext(2)]
	private bool IsSameKey(string keyName1, string keyName2)
	{
		return keyName1 != null && keyName2 != null && (keyName1 == keyName2 || ((keyName1.Contains(EKey.Gamepad_LeftTrigger) && keyName2.Contains(EKey.Gamepad_LeftTrigger)) || (keyName1.Contains(EKey.Gamepad_RightTrigger) && keyName2.Contains(EKey.Gamepad_RightTrigger))));
	}

	// Token: 0x06010F53 RID: 69459 RVA: 0x00421254 File Offset: 0x0041F454
	public bool HasKey(List<string> keyNameList, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (keyNameList.Count > 1)
		{
			if (this.IsCombination(inputControllerType))
			{
				InputCombinationActionBinding inputCombinationActionBinding = this.FindCombinationActionBinding();
				if (inputCombinationActionBinding != null)
				{
					return inputCombinationActionBinding.HasKey(keyNameList[0], (keyNameList.Count > 1) ? keyNameList[1] : "", this.BindingType);
				}
				if (this.CombinationAxisBinding != null)
				{
					return this.CombinationAxisBinding.HasKey(keyNameList[0], (keyNameList.Count > 1) ? keyNameList[1] : "", this.BindingType);
				}
			}
			return false;
		}
		string keyName = keyNameList[0];
		if (this.ActionBinding == null)
		{
			if (this.AxisBinding != null)
			{
				float keyScale = this.GetKeyScale(inputControllerType);
				foreach (InputAxisKey inputAxisKey in this.AxisBinding.GetKey(keyScale, this.BindingType))
				{
					if (this.IsSameKey(inputAxisKey.KeyName, keyName))
					{
						return true;
					}
				}
			}
			return false;
		}
		int keyIndex = this.GetKeyIndex(inputControllerType);
		List<string> list = new List<string>();
		this.ActionBinding.GetKeyNameListByBindingType(list, this.BindingType);
		if (list == null || list.Count == 0)
		{
			return false;
		}
		string keyName2 = (list.Count > keyIndex) ? list[keyIndex] : null;
		return this.IsSameKey(keyName2, keyName);
	}

	// Token: 0x06010F54 RID: 69460 RVA: 0x00421391 File Offset: 0x0041F591
	public string GetActionOrAxisName()
	{
		return this.ActionOrAxisName;
	}

	// Token: 0x06010F55 RID: 69461 RVA: 0x0042139C File Offset: 0x0041F59C
	public void ResetKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.ActionOrAxisName == null || this.ActionOrAxisName == "")
		{
			return;
		}
		if (this.BothActionName != null && this.BothActionName.Count == 2)
		{
			InputSettingsManager.Instance.ResetActionKeyByName(this.BothActionName[0], this.BindingType);
			InputSettingsManager.Instance.ResetActionKeyByName(this.BothActionName[1], this.BindingType);
			return;
		}
		bool flag = this.IsCombination(inputControllerType);
		bool flag2 = this.IsOriginalCombinationActionSet.Contains(inputControllerType);
		if (flag || flag2)
		{
			if (this.IsActionOrAxis)
			{
				InputSettingsManager.Instance.ResetCombinationActionKeyByName(this.ActionOrAxisName, inputControllerType, this.BindingType);
			}
			if (flag != flag2)
			{
				if (this.IsActionOrAxis)
				{
					InputSettingsManager.Instance.ResetActionKeyByName(this.ActionOrAxisName, this.BindingType);
					return;
				}
				InputSettingsManager.Instance.ResetAxisKeyByName(this.ActionOrAxisName, this.BindingType);
				return;
			}
		}
		else
		{
			if (this.IsActionOrAxis)
			{
				InputSettingsManager.Instance.ResetActionKeyByName(this.ActionOrAxisName, this.BindingType);
				return;
			}
			InputSettingsManager.Instance.ResetAxisKeyByName(this.ActionOrAxisName, this.BindingType);
		}
	}

	// Token: 0x040080D1 RID: 32977
	private KeyType? KeyTypeConfig;

	// Token: 0x040080D2 RID: 32978
	private KeySetting? KeySettingConfig;

	// Token: 0x040080D3 RID: 32979
	private EKeySettingRowType KeySettingRowType;

	// Token: 0x040080D4 RID: 32980
	public bool IsExpandDetail;

	// Token: 0x040080D5 RID: 32981
	private string SettingName = "";

	// Token: 0x040080D6 RID: 32982
	private string ActionOrAxisName = "";

	// Token: 0x040080D7 RID: 32983
	private readonly HashSet<CSharpScript.Game.Module.Menu.EInputControllerType> IsOriginalCombinationActionSet = new HashSet<CSharpScript.Game.Module.Menu.EInputControllerType>();

	// Token: 0x040080D8 RID: 32984
	public bool IsActionOrAxis = true;

	// Token: 0x040080D9 RID: 32985
	[Nullable(2)]
	public InputActionBinding ActionBinding;

	// Token: 0x040080DA RID: 32986
	[Nullable(2)]
	public InputAxisBinding AxisBinding;

	// Token: 0x040080DB RID: 32987
	[Nullable(2)]
	public InputCombinationAxisBinding CombinationAxisBinding;

	// Token: 0x040080DC RID: 32988
	[Nullable(2)]
	public InputActionBinding OneActionBinding;

	// Token: 0x040080DD RID: 32989
	[Nullable(2)]
	public InputActionBinding TwoActionBinding;

	// Token: 0x040080DE RID: 32990
	private int PcKeyIndex;

	// Token: 0x040080DF RID: 32991
	private int GamepadKeyIndex;

	// Token: 0x040080E0 RID: 32992
	private float PcAxisValue;

	// Token: 0x040080E1 RID: 32993
	private float GamepadAxisValue;

	// Token: 0x040080E2 RID: 32994
	public bool IsLock;

	// Token: 0x040080E3 RID: 32995
	private string AllowKeysPool = "";

	// Token: 0x040080E4 RID: 32996
	private string AllowMainKeysPool = "";

	// Token: 0x040080E5 RID: 32997
	private string AllowSecondKeysPool = "";

	// Token: 0x040080E6 RID: 32998
	public List<int> ConnectedKeySettingIdList = new List<int>();

	// Token: 0x040080E7 RID: 32999
	public string KeyTypeName = "";

	// Token: 0x040080E8 RID: 33000
	public string KeyTypeIconSpritePath = "";

	// Token: 0x040080E9 RID: 33001
	public string DetailTextId = "";

	// Token: 0x040080EA RID: 33002
	public int ConfigId;

	// Token: 0x040080EB RID: 33003
	public int SortId;

	// Token: 0x040080EC RID: 33004
	public List<string> BothActionName = new List<string>();

	// Token: 0x040080ED RID: 33005
	public bool BothActionSyncAllExclusive;

	// Token: 0x040080EE RID: 33006
	public bool CanCombination;

	// Token: 0x040080EF RID: 33007
	public EKeySettingOpenViewType OpenViewType;

	// Token: 0x040080F0 RID: 33008
	public bool IsCheckSameKey = true;

	// Token: 0x040080F1 RID: 33009
	[Nullable(2)]
	public string ButtonTextId;

	// Token: 0x040080F2 RID: 33010
	public bool CanDisable;

	// Token: 0x040080F3 RID: 33011
	public EInputBindingType BindingType;

	// Token: 0x040080F4 RID: 33012
	[Nullable(2)]
	public Action HelpBtnCallBack;
}
