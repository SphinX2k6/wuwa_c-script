using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;

// Token: 0x020016EA RID: 5866
[NullableContext(1)]
[Nullable(0)]
public class KeySettingRowData
{
	// Token: 0x170015BD RID: 5565
	// (get) Token: 0x0600E3B9 RID: 58297 RVA: 0x0042C984 File Offset: 0x0042AB84
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
				return new List<string>(config.Value.ValidKeys());
			}
			return new List<string>();
		}
	}

	// Token: 0x170015BE RID: 5566
	// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x0042C9EC File Offset: 0x0042ABEC
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
				return new List<string>(config.Value.ValidKeys());
			}
			return new List<string>();
		}
	}

	// Token: 0x170015BF RID: 5567
	// (get) Token: 0x0600E3BB RID: 58299 RVA: 0x0042CA54 File Offset: 0x0042AC54
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
				return new List<string>(config.Value.ValidKeys());
			}
			return new List<string>();
		}
	}

	// Token: 0x0600E3BC RID: 58300 RVA: 0x0042CABA File Offset: 0x0042ACBA
	public void InitializeKeyType(KeyType keyType)
	{
		this.ConfigId = keyType.TypeId;
		this.KeyTypeConfig = new KeyType?(keyType);
		this.KeySettingRowType = EKeySettingRowType.KeyType;
		this.KeyTypeName = keyType.Name;
		this.KeyTypeIconSpritePath = keyType.IconSpritePath;
	}

	// Token: 0x0600E3BD RID: 58301 RVA: 0x0042CAF8 File Offset: 0x0042ACF8
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
		this.BothActionName = new List<string>(keySettingConfig.BothActionName());
		this.BothActionSyncAllExclusive = keySettingConfig.BothActionSyncAllExclusive;
		this.CanCombination = keySettingConfig.CanCombination;
		this.OpenViewType = (EKeySettingOpenViewType)keySettingConfig.OpenViewType;
		this.IsCheckSameKey = keySettingConfig.IsCheckSameKey;
		this.ButtonTextId = keySettingConfig.ButtonTextId;
		this.ConnectedKeySettingIdList = new List<int>(keySettingConfig.ConnectedKeySettingIdList());
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

	// Token: 0x0600E3BE RID: 58302 RVA: 0x0042CD00 File Offset: 0x0042AF00
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

	// Token: 0x0600E3BF RID: 58303 RVA: 0x0042CD58 File Offset: 0x0042AF58
	[NullableContext(2)]
	public InputCombinationActionBinding FindCombinationActionBinding()
	{
		return InputSettingsManager.Instance.GetCombinationActionBindingByActionName(this.ActionOrAxisName);
	}

	// Token: 0x0600E3C0 RID: 58304 RVA: 0x0042CD6A File Offset: 0x0042AF6A
	public void Clear()
	{
		this.ActionBinding = null;
		this.AxisBinding = null;
		this.CombinationAxisBinding = null;
		this.OneActionBinding = null;
		this.TwoActionBinding = null;
	}

	// Token: 0x0600E3C1 RID: 58305 RVA: 0x0042CD8F File Offset: 0x0042AF8F
	public EKeySettingRowType GetRowType()
	{
		return this.KeySettingRowType;
	}

	// Token: 0x0600E3C2 RID: 58306 RVA: 0x0042CD97 File Offset: 0x0042AF97
	public KeyType? GetKeyTypeConfig()
	{
		return this.KeyTypeConfig;
	}

	// Token: 0x0600E3C3 RID: 58307 RVA: 0x0042CD9F File Offset: 0x0042AF9F
	public KeySetting? GetKeySettingConfig()
	{
		return this.KeySettingConfig;
	}

	// Token: 0x0600E3C4 RID: 58308 RVA: 0x0042CDA7 File Offset: 0x0042AFA7
	public string GetSettingName()
	{
		return this.SettingName;
	}

	// Token: 0x0600E3C5 RID: 58309 RVA: 0x0042CDAF File Offset: 0x0042AFAF
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

	// Token: 0x0600E3C6 RID: 58310 RVA: 0x0042CDDC File Offset: 0x0042AFDC
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

	// Token: 0x0600E3C7 RID: 58311 RVA: 0x0042CE30 File Offset: 0x0042B030
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

	// Token: 0x0600E3C8 RID: 58312 RVA: 0x0042CE60 File Offset: 0x0042B060
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

	// Token: 0x0600E3C9 RID: 58313 RVA: 0x0042CE7E File Offset: 0x0042B07E
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

	// Token: 0x0600E3CA RID: 58314 RVA: 0x0042CE98 File Offset: 0x0042B098
	public string GetCurrentKeyNameRichText(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType, string linkString = "+")
	{
		List<string> displayKeyName = this.GetDisplayKeyName(inputControllerType);
		if (displayKeyName == null)
		{
			return "";
		}
		return this.GetKeyNameRichTextByKeyNameList(inputControllerType, displayKeyName, linkString);
	}

	// Token: 0x0600E3CB RID: 58315 RVA: 0x0042CEC0 File Offset: 0x0042B0C0
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

	// Token: 0x0600E3CC RID: 58316 RVA: 0x0042CF2C File Offset: 0x0042B12C
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

	// Token: 0x0600E3CD RID: 58317 RVA: 0x0042CF98 File Offset: 0x0042B198
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

	// Token: 0x0600E3CE RID: 58318 RVA: 0x0042CFF8 File Offset: 0x0042B1F8
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

	// Token: 0x0600E3CF RID: 58319 RVA: 0x0042D084 File Offset: 0x0042B284
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

	// Token: 0x0600E3D0 RID: 58320 RVA: 0x0042D1E8 File Offset: 0x0042B3E8
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

	// Token: 0x0600E3D1 RID: 58321 RVA: 0x0042D2D4 File Offset: 0x0042B4D4
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

	// Token: 0x0600E3D2 RID: 58322 RVA: 0x0042D3B0 File Offset: 0x0042B5B0
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

	// Token: 0x0600E3D3 RID: 58323 RVA: 0x0042D496 File Offset: 0x0042B696
	public bool IsBothAction()
	{
		return this.OneActionBinding != null && this.TwoActionBinding != null;
	}

	// Token: 0x0600E3D4 RID: 58324 RVA: 0x0042D4AC File Offset: 0x0042B6AC
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

	// Token: 0x0600E3D5 RID: 58325 RVA: 0x0042D518 File Offset: 0x0042B718
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

	// Token: 0x0600E3D6 RID: 58326 RVA: 0x0042D538 File Offset: 0x0042B738
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

	// Token: 0x0600E3D7 RID: 58327 RVA: 0x0042D5B4 File Offset: 0x0042B7B4
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

	// Token: 0x0600E3D8 RID: 58328 RVA: 0x0042D5FF File Offset: 0x0042B7FF
	public bool SetKey(List<string> keyNameList, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsActionOrAxis)
		{
			return this.SetActionKey(keyNameList, inputControllerType);
		}
		return !this.IsCombination(inputControllerType) && (keyNameList != null && keyNameList.Count > 0) && this.SetAxisKey(keyNameList[0], inputControllerType);
	}

	// Token: 0x0600E3D9 RID: 58329 RVA: 0x0042D639 File Offset: 0x0042B839
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

	// Token: 0x0600E3DA RID: 58330 RVA: 0x0042D663 File Offset: 0x0042B863
	public string ConvertKeyToActionOrAxis(string keyName)
	{
		return InputKeyUtils.ConvertKeyToActionOrAxis(keyName, this.IsActionOrAxis);
	}

	// Token: 0x0600E3DB RID: 58331 RVA: 0x0042D674 File Offset: 0x0042B874
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

	// Token: 0x0600E3DC RID: 58332 RVA: 0x0042D838 File Offset: 0x0042BA38
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

	// Token: 0x0600E3DD RID: 58333 RVA: 0x0042D8B0 File Offset: 0x0042BAB0
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

	// Token: 0x0600E3DE RID: 58334 RVA: 0x0042DA0C File Offset: 0x0042BC0C
	private void DisableAxisKey(CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (this.IsCombination(inputControllerType))
		{
			return;
		}
		this.DisableAxisBindingKey(inputControllerType);
	}

	// Token: 0x0600E3DF RID: 58335 RVA: 0x0042DA1F File Offset: 0x0042BC1F
	public void SetAxisBindingKeys(Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
	{
		InputAxisBinding axisBinding = this.AxisBinding;
		if (axisBinding == null)
		{
			return;
		}
		axisBinding.SetKeys(keyScaleMap, bindingType);
	}

	// Token: 0x0600E3E0 RID: 58336 RVA: 0x0042DA34 File Offset: 0x0042BC34
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

	// Token: 0x0600E3E1 RID: 58337 RVA: 0x0042DAC4 File Offset: 0x0042BCC4
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

	// Token: 0x0600E3E2 RID: 58338 RVA: 0x0042DADF File Offset: 0x0042BCDF
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

	// Token: 0x0600E3E3 RID: 58339 RVA: 0x0042DAFE File Offset: 0x0042BCFE
	public bool IsAllowKey(string keyName)
	{
		return this.AllowKeys == null || this.AllowKeys.Count <= 0 || this.AllowKeys.Contains(keyName);
	}

	// Token: 0x0600E3E4 RID: 58340 RVA: 0x0042DB24 File Offset: 0x0042BD24
	public bool IsAllowCombinationKey(string mainKeyName, string secondKeyName)
	{
		return (this.AllowMainKeys == null || this.AllowMainKeys.Count <= 0 || this.AllowMainKeys.Contains(mainKeyName)) && (this.AllowSecondKeys == null || this.AllowSecondKeys.Count <= 0 || this.AllowSecondKeys.Contains(secondKeyName));
	}

	// Token: 0x0600E3E5 RID: 58341 RVA: 0x0042DB8C File Offset: 0x0042BD8C
	[NullableContext(2)]
	private bool IsSameKey(string keyName1, string keyName2)
	{
		return keyName1 != null && keyName2 != null && (keyName1 == keyName2 || ((keyName1.Contains(EKey.Gamepad_LeftTrigger) && keyName2.Contains(EKey.Gamepad_LeftTrigger)) || (keyName1.Contains(EKey.Gamepad_RightTrigger) && keyName2.Contains(EKey.Gamepad_RightTrigger))));
	}

	// Token: 0x0600E3E6 RID: 58342 RVA: 0x0042DBF8 File Offset: 0x0042BDF8
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

	// Token: 0x0600E3E7 RID: 58343 RVA: 0x0042DD35 File Offset: 0x0042BF35
	public string GetActionOrAxisName()
	{
		return this.ActionOrAxisName;
	}

	// Token: 0x0600E3E8 RID: 58344 RVA: 0x0042DD40 File Offset: 0x0042BF40
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

	// Token: 0x0400820F RID: 33295
	private KeyType? KeyTypeConfig;

	// Token: 0x04008210 RID: 33296
	private KeySetting? KeySettingConfig;

	// Token: 0x04008211 RID: 33297
	private EKeySettingRowType KeySettingRowType;

	// Token: 0x04008212 RID: 33298
	public bool IsExpandDetail;

	// Token: 0x04008213 RID: 33299
	private string SettingName = "";

	// Token: 0x04008214 RID: 33300
	private string ActionOrAxisName = "";

	// Token: 0x04008215 RID: 33301
	private readonly HashSet<CSharpScript.Game.Module.Menu.EInputControllerType> IsOriginalCombinationActionSet = new HashSet<CSharpScript.Game.Module.Menu.EInputControllerType>();

	// Token: 0x04008216 RID: 33302
	public bool IsActionOrAxis = true;

	// Token: 0x04008217 RID: 33303
	[Nullable(2)]
	public InputActionBinding ActionBinding;

	// Token: 0x04008218 RID: 33304
	[Nullable(2)]
	public InputAxisBinding AxisBinding;

	// Token: 0x04008219 RID: 33305
	[Nullable(2)]
	public InputCombinationAxisBinding CombinationAxisBinding;

	// Token: 0x0400821A RID: 33306
	[Nullable(2)]
	public InputActionBinding OneActionBinding;

	// Token: 0x0400821B RID: 33307
	[Nullable(2)]
	public InputActionBinding TwoActionBinding;

	// Token: 0x0400821C RID: 33308
	private int PcKeyIndex;

	// Token: 0x0400821D RID: 33309
	private int GamepadKeyIndex;

	// Token: 0x0400821E RID: 33310
	private float PcAxisValue;

	// Token: 0x0400821F RID: 33311
	private float GamepadAxisValue;

	// Token: 0x04008220 RID: 33312
	public bool IsLock;

	// Token: 0x04008221 RID: 33313
	private string AllowKeysPool = "";

	// Token: 0x04008222 RID: 33314
	private string AllowMainKeysPool = "";

	// Token: 0x04008223 RID: 33315
	private string AllowSecondKeysPool = "";

	// Token: 0x04008224 RID: 33316
	public List<int> ConnectedKeySettingIdList = new List<int>();

	// Token: 0x04008225 RID: 33317
	public string KeyTypeName = "";

	// Token: 0x04008226 RID: 33318
	public string KeyTypeIconSpritePath = "";

	// Token: 0x04008227 RID: 33319
	public string DetailTextId = "";

	// Token: 0x04008228 RID: 33320
	public int ConfigId;

	// Token: 0x04008229 RID: 33321
	public int SortId;

	// Token: 0x0400822A RID: 33322
	public List<string> BothActionName = new List<string>();

	// Token: 0x0400822B RID: 33323
	public bool BothActionSyncAllExclusive;

	// Token: 0x0400822C RID: 33324
	public bool CanCombination;

	// Token: 0x0400822D RID: 33325
	public EKeySettingOpenViewType OpenViewType;

	// Token: 0x0400822E RID: 33326
	public bool IsCheckSameKey = true;

	// Token: 0x0400822F RID: 33327
	[Nullable(2)]
	public string ButtonTextId;

	// Token: 0x04008230 RID: 33328
	public bool CanDisable;

	// Token: 0x04008231 RID: 33329
	public EInputBindingType BindingType;

	// Token: 0x04008232 RID: 33330
	[Nullable(2)]
	public Action HelpBtnCallBack;
}
