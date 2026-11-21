using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014FD RID: 5373
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class KeySettingViewModel
{
	// Token: 0x170013DF RID: 5087
	// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x003FA8D7 File Offset: 0x003F8AD7
	public static bool IsEditing
	{
		get
		{
			return KeySettingViewModel.IsEditingInternal;
		}
	}

	// Token: 0x170013E0 RID: 5088
	// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x003FA8DE File Offset: 0x003F8ADE
	// (set) Token: 0x0600D6B7 RID: 54967 RVA: 0x003FA8E5 File Offset: 0x003F8AE5
	public static CSharpScript.Game.Module.Menu.EInputControllerType InputControllerType
	{
		get
		{
			return KeySettingViewModel.InputControllerTypeInternal;
		}
		set
		{
			KeySettingViewModel.InputControllerTypeInternal = value;
		}
	}

	// Token: 0x170013E1 RID: 5089
	// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x003FA8F0 File Offset: 0x003F8AF0
	public static EKeySettingDeviceType CurrentDeviceType
	{
		get
		{
			CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = KeySettingViewModel.InputControllerType;
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
			{
				return EKeySettingDeviceType.Keyboard;
			}
			if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				return EKeySettingDeviceType.None;
			}
			return EKeySettingDeviceType.Gamepad;
		}
	}

	// Token: 0x0600D6B9 RID: 54969 RVA: 0x003FA912 File Offset: 0x003F8B12
	public static void OnViewStart()
	{
		KeySettingViewModel.AddEvents();
		if (Info.Instance.IsInKeyBoard())
		{
			KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
			return;
		}
		if (Info.Instance.IsInGamepad())
		{
			KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad;
		}
	}

	// Token: 0x0600D6BA RID: 54970 RVA: 0x003FA940 File Offset: 0x003F8B40
	public static void InitData(EKeySettingExclusiveType type = EKeySettingExclusiveType.None)
	{
		IReadOnlyList<KeyType> allKeyTypeConfig = MenuBaseConfig.Instance.GetAllKeyTypeConfig();
		if (allKeyTypeConfig == null)
		{
			return;
		}
		KeySettingViewModel.KeySettingRowDataMap.Clear();
		KeySettingViewModel.HiddenKeySettingRowDataMap.Clear();
		KeySettingViewModel.InitializeKeyBoardSettingRowData(allKeyTypeConfig, type);
		KeySettingViewModel.InitializeXboxKeySettingRowData(allKeyTypeConfig, type);
	}

	// Token: 0x0600D6BB RID: 54971 RVA: 0x003FA97E File Offset: 0x003F8B7E
	public static List<KeySettingRowData> GetKeySettingDataList()
	{
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			return KeySettingViewModel.KeyBoardSettingRowDataList;
		}
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			return KeySettingViewModel.GamepadKeySettingRowDataList;
		}
		return new List<KeySettingRowData>();
	}

	// Token: 0x0600D6BC RID: 54972 RVA: 0x003FA9A1 File Offset: 0x003F8BA1
	public static void OnViewDestroy()
	{
		KeySettingViewModel.Clear();
	}

	// Token: 0x0600D6BD RID: 54973 RVA: 0x003FA9A8 File Offset: 0x003F8BA8
	public static void ResetSettings()
	{
		foreach (KeySettingRowData keySettingRowData in KeySettingViewModel.KeyBoardSettingRowDataList)
		{
			keySettingRowData.ResetKey(CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard);
		}
		foreach (KeySettingRowData keySettingRowData2 in KeySettingViewModel.HiddenKeyBoardSettingRowDataList)
		{
			keySettingRowData2.ResetKey(CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard);
		}
		foreach (KeySettingRowData keySettingRowData3 in KeySettingViewModel.GamepadKeySettingRowDataList)
		{
			keySettingRowData3.ResetKey(CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad);
		}
		foreach (KeySettingRowData keySettingRowData4 in KeySettingViewModel.HiddenGamepadKeySettingRowDataList)
		{
			keySettingRowData4.ResetKey(CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad);
		}
	}

	// Token: 0x0600D6BE RID: 54974 RVA: 0x003FAAB8 File Offset: 0x003F8CB8
	public static void ExternalFinishEditKey()
	{
		KeySettingViewModel.FinishEditKey();
	}

	// Token: 0x0600D6BF RID: 54975 RVA: 0x003FAAC0 File Offset: 0x003F8CC0
	public static void WaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		KeySettingViewModel.WaitKeySettingRowData = data;
		KeySettingViewModel.SelectKey(data);
		KeySettingViewModel.NotifyOnWaitKeySetting(data, item);
		EKeySettingOpenViewType openViewType = data.OpenViewType;
		if (openViewType != EKeySettingOpenViewType.None)
		{
			if (openViewType != EKeySettingOpenViewType.OpenAssemblyView)
			{
				if (openViewType == EKeySettingOpenViewType.OpenChangeLockView)
				{
					MenuController.Instance.OpenChangeLockView();
				}
			}
			else
			{
				RouletteController.Instance.OpenAssemblyView(ERouletteType.Function, null, null, null, false);
			}
			KeySettingViewModel.FinishEditKey();
			return;
		}
		if (data.IsLock)
		{
			GenericPromptController.Instance.ShowPromptByCode("KeyLock", Array.Empty<object>());
			KeySettingViewModel.FinishEditKey();
			return;
		}
		KeySettingViewModel.WaitKeySettingRowData = data;
		if (data.BothActionName != null && data.BothActionName.Count == 2)
		{
			ChangeActionInfo changeActionInfo = new ChangeActionInfo();
			changeActionInfo.InputControllerType = KeySettingViewModel.InputControllerType;
			changeActionInfo.KeySettingRowData = data;
			Action<bool> onConfirmCallback;
			if ((onConfirmCallback = KeySettingViewModel.<>O.<0>__OnConfirmChangeBothAction) == null)
			{
				onConfirmCallback = (KeySettingViewModel.<>O.<0>__OnConfirmChangeBothAction = new Action<bool>(KeySettingViewModel.OnConfirmChangeBothAction));
			}
			changeActionInfo.OnConfirmCallback = onConfirmCallback;
			ChangeActionInfo param = changeActionInfo;
			UiManager.Instance.OpenView(EUiViewName.ChangeActionTipsView, param, null);
			KeySettingViewModel.FinishEditKey();
			return;
		}
		KeySettingViewModel.BeginEditKey();
	}

	// Token: 0x0600D6C0 RID: 54976 RVA: 0x003FABC1 File Offset: 0x003F8DC1
	[NullableContext(2)]
	public static void SelectKey(KeySettingRowData data)
	{
		KeySettingViewModel.NotifyOnKeySelected(data);
	}

	// Token: 0x0600D6C1 RID: 54977 RVA: 0x003FABC9 File Offset: 0x003F8DC9
	public static void HoverKey(KeySettingRowData data)
	{
		KeySettingViewModel.NotifyOnKeyHover(data);
	}

	// Token: 0x0600D6C2 RID: 54978 RVA: 0x003FABD1 File Offset: 0x003F8DD1
	public static void UnHoverKey(KeySettingRowData data)
	{
		KeySettingViewModel.NotifyOnKeyUnHover(data);
	}

	// Token: 0x0600D6C3 RID: 54979 RVA: 0x003FABD9 File Offset: 0x003F8DD9
	public static void AddOnWaitKeySettingDelegate(Action<KeySettingRowData, IKeySettingItem> d)
	{
		if (!KeySettingViewModel.DelegatesOnWaitKeySetting.Contains(d))
		{
			KeySettingViewModel.DelegatesOnWaitKeySetting.Add(d);
		}
	}

	// Token: 0x0600D6C4 RID: 54980 RVA: 0x003FABF4 File Offset: 0x003F8DF4
	public static void RemoveOnWaitKeySettingDelegate(Action<KeySettingRowData, IKeySettingItem> d)
	{
		int num = KeySettingViewModel.DelegatesOnWaitKeySetting.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnWaitKeySetting.RemoveAt(num);
		}
	}

	// Token: 0x0600D6C5 RID: 54981 RVA: 0x003FAC1C File Offset: 0x003F8E1C
	public static void AddOnKeyChangeDelegate(Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeyChange.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeyChange.Add(d);
		}
	}

	// Token: 0x0600D6C6 RID: 54982 RVA: 0x003FAC38 File Offset: 0x003F8E38
	public static void RemoveOnKeyChangeDelegate(Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeyChange.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeyChange.RemoveAt(num);
		}
	}

	// Token: 0x0600D6C7 RID: 54983 RVA: 0x003FAC60 File Offset: 0x003F8E60
	public static void AddOnKeySelectedDelegate([Nullable(new byte[]
	{
		1,
		2
	})] Action<KeySettingRowData> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeySelected.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeySelected.Add(d);
		}
	}

	// Token: 0x0600D6C8 RID: 54984 RVA: 0x003FAC7C File Offset: 0x003F8E7C
	public static void RemoveOnKeySelectedDelegate([Nullable(new byte[]
	{
		1,
		2
	})] Action<KeySettingRowData> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeySelected.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeySelected.RemoveAt(num);
		}
	}

	// Token: 0x0600D6C9 RID: 54985 RVA: 0x003FACA4 File Offset: 0x003F8EA4
	public static void AddOnBeforeBeginEditKeyDelegate(Action d)
	{
		if (!KeySettingViewModel.DelegatesOnBeforeBeginEditKey.Contains(d))
		{
			KeySettingViewModel.DelegatesOnBeforeBeginEditKey.Add(d);
		}
	}

	// Token: 0x0600D6CA RID: 54986 RVA: 0x003FACC0 File Offset: 0x003F8EC0
	public static void RemoveOnBeforeBeginEditKeyDelegate(Action d)
	{
		int num = KeySettingViewModel.DelegatesOnBeforeBeginEditKey.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnBeforeBeginEditKey.RemoveAt(num);
		}
	}

	// Token: 0x0600D6CB RID: 54987 RVA: 0x003FACE8 File Offset: 0x003F8EE8
	public static void AddOnBeginEditKeyDelegate(Action d)
	{
		if (!KeySettingViewModel.DelegatesOnBeginEditKey.Contains(d))
		{
			KeySettingViewModel.DelegatesOnBeginEditKey.Add(d);
		}
	}

	// Token: 0x0600D6CC RID: 54988 RVA: 0x003FAD04 File Offset: 0x003F8F04
	public static void RemoveOnBeginEditKeyDelegate(Action d)
	{
		int num = KeySettingViewModel.DelegatesOnBeginEditKey.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnBeginEditKey.RemoveAt(num);
		}
	}

	// Token: 0x0600D6CD RID: 54989 RVA: 0x003FAD2C File Offset: 0x003F8F2C
	public static void AddOnFinishEditKeyDelegate(Action d)
	{
		if (!KeySettingViewModel.DelegatesOnFinishEditKey.Contains(d))
		{
			KeySettingViewModel.DelegatesOnFinishEditKey.Add(d);
		}
	}

	// Token: 0x0600D6CE RID: 54990 RVA: 0x003FAD48 File Offset: 0x003F8F48
	public static void RemoveOnFinishEditKeyDelegate(Action d)
	{
		int num = KeySettingViewModel.DelegatesOnFinishEditKey.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnFinishEditKey.RemoveAt(num);
		}
	}

	// Token: 0x0600D6CF RID: 54991 RVA: 0x003FAD70 File Offset: 0x003F8F70
	public static void AddOnKeyHoverDelegate(Action<KeySettingRowData> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeyHover.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeyHover.Add(d);
		}
	}

	// Token: 0x0600D6D0 RID: 54992 RVA: 0x003FAD8C File Offset: 0x003F8F8C
	public static void RemoveOnKeyHoverDelegate(Action<KeySettingRowData> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeyHover.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeyHover.RemoveAt(num);
		}
	}

	// Token: 0x0600D6D1 RID: 54993 RVA: 0x003FADB4 File Offset: 0x003F8FB4
	public static void AddOnKeyUnHoverDelegate(Action<KeySettingRowData> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeyUnHover.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeyUnHover.Add(d);
		}
	}

	// Token: 0x0600D6D2 RID: 54994 RVA: 0x003FADD0 File Offset: 0x003F8FD0
	public static void RemoveOnKeyUnHoverDelegate(Action<KeySettingRowData> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeyUnHover.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeyUnHover.RemoveAt(num);
		}
	}

	// Token: 0x0600D6D3 RID: 54995 RVA: 0x003FADF8 File Offset: 0x003F8FF8
	private static void NotifyOnWaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		foreach (Action<KeySettingRowData, IKeySettingItem> action in KeySettingViewModel.DelegatesOnWaitKeySetting)
		{
			action(data, item);
		}
	}

	// Token: 0x0600D6D4 RID: 54996 RVA: 0x003FAE4C File Offset: 0x003F904C
	private static void NotifyOnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		foreach (Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> action in KeySettingViewModel.DelegatesOnKeyChange)
		{
			action(data, inputControllerType);
		}
		EventSystem.Instance.Emit<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(EEventName.OnCommonKeySettingKeyChange, data, inputControllerType);
	}

	// Token: 0x0600D6D5 RID: 54997 RVA: 0x003FAEB0 File Offset: 0x003F90B0
	[NullableContext(2)]
	private static void NotifyOnKeySelected(KeySettingRowData data)
	{
		foreach (Action<KeySettingRowData> action in KeySettingViewModel.DelegatesOnKeySelected)
		{
			action(data);
		}
	}

	// Token: 0x0600D6D6 RID: 54998 RVA: 0x003FAF00 File Offset: 0x003F9100
	private static void NotifyOnBeforeBeginEditKey()
	{
		foreach (Action action in KeySettingViewModel.DelegatesOnBeforeBeginEditKey)
		{
			action();
		}
	}

	// Token: 0x0600D6D7 RID: 54999 RVA: 0x003FAF50 File Offset: 0x003F9150
	private static void NotifyOnBeginEditKey()
	{
		foreach (Action action in KeySettingViewModel.DelegatesOnBeginEditKey)
		{
			action();
		}
	}

	// Token: 0x0600D6D8 RID: 55000 RVA: 0x003FAFA0 File Offset: 0x003F91A0
	private static void NotifyOnFinishEditKey()
	{
		foreach (Action action in KeySettingViewModel.DelegatesOnFinishEditKey)
		{
			action();
		}
	}

	// Token: 0x0600D6D9 RID: 55001 RVA: 0x003FAFF0 File Offset: 0x003F91F0
	private static void NotifyOnKeyHover(KeySettingRowData data)
	{
		foreach (Action<KeySettingRowData> action in KeySettingViewModel.DelegatesOnKeyHover)
		{
			action(data);
		}
	}

	// Token: 0x0600D6DA RID: 55002 RVA: 0x003FB040 File Offset: 0x003F9240
	private static void NotifyOnKeyUnHover(KeySettingRowData data)
	{
		foreach (Action<KeySettingRowData> action in KeySettingViewModel.DelegatesOnKeyUnHover)
		{
			action(data);
		}
	}

	// Token: 0x0600D6DB RID: 55003 RVA: 0x003FB090 File Offset: 0x003F9290
	private static void AddEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnInputAnyKey;
		Action<bool, FKey> handle;
		if ((handle = KeySettingViewModel.<>O.<1>__OnInputAnyKey) == null)
		{
			handle = (KeySettingViewModel.<>O.<1>__OnInputAnyKey = new Action<bool, FKey>(KeySettingViewModel.OnInputAnyKey));
		}
		instance.Add(name, handle);
	}

	// Token: 0x0600D6DC RID: 55004 RVA: 0x003FB0BD File Offset: 0x003F92BD
	private static void RemoveEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnInputAnyKey;
		Action<bool, FKey> handle;
		if ((handle = KeySettingViewModel.<>O.<1>__OnInputAnyKey) == null)
		{
			handle = (KeySettingViewModel.<>O.<1>__OnInputAnyKey = new Action<bool, FKey>(KeySettingViewModel.OnInputAnyKey));
		}
		instance.Remove(name, handle);
	}

	// Token: 0x0600D6DD RID: 55005 RVA: 0x003FB0EC File Offset: 0x003F92EC
	private static void Clear()
	{
		KeySettingViewModel.DelegatesOnWaitKeySetting.Clear();
		KeySettingViewModel.DelegatesOnKeyChange.Clear();
		KeySettingViewModel.DelegatesOnKeySelected.Clear();
		KeySettingViewModel.DelegatesOnBeforeBeginEditKey.Clear();
		KeySettingViewModel.DelegatesOnBeginEditKey.Clear();
		KeySettingViewModel.DelegatesOnFinishEditKey.Clear();
		KeySettingViewModel.DelegatesOnKeyHover.Clear();
		KeySettingViewModel.DelegatesOnKeyUnHover.Clear();
		KeySettingViewModel.WaitKeySettingRowData = null;
		KeySettingViewModel.EditKeyNameList.Clear();
		KeySettingViewModel.GamepadKeySettingRowDataList.Clear();
		KeySettingViewModel.KeyBoardSettingRowDataList.Clear();
		KeySettingViewModel.KeySettingRowDataMap.Clear();
		KeySettingViewModel.HiddenKeySettingRowDataMap.Clear();
		KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.None;
		KeySettingViewModel.RemoveEditKeyTimerHandle();
		KeySettingViewModel.RemoveEvents();
	}

	// Token: 0x0600D6DE RID: 55006 RVA: 0x003FB194 File Offset: 0x003F9394
	private static void InitializeKeyBoardSettingRowData(IReadOnlyList<KeyType> keyTypeConfigList, EKeySettingExclusiveType exclusiveType)
	{
		KeySettingViewModel.KeyBoardSettingRowDataList.Clear();
		MenuBaseConfig instance = MenuBaseConfig.Instance;
		foreach (KeyType keyType in keyTypeConfigList)
		{
			int typeId = keyType.TypeId;
			IReadOnlyList<KeySetting> collection = instance.GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(typeId, 1, exclusiveType) ?? new List<KeySetting>();
			IReadOnlyList<KeySetting> collection2 = instance.GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(typeId, 0, exclusiveType) ?? new List<KeySetting>();
			List<KeySetting> list = new List<KeySetting>();
			list.AddRange(collection);
			list.AddRange(collection2);
			if (list.Count > 0)
			{
				KeySettingRowData keySettingRowData = new KeySettingRowData();
				keySettingRowData.InitializeKeyType(keyType);
				if (exclusiveType == EKeySettingExclusiveType.RhythmShip)
				{
					keySettingRowData.HelpBtnCallBack = RhythmShipModel.Instance.OpenKeyHelpView;
				}
				KeySettingViewModel.KeyBoardSettingRowDataList.Add(keySettingRowData);
				list.Sort(delegate(KeySetting aConfig, KeySetting bConfig)
				{
					if (aConfig.SortId == bConfig.SortId)
					{
						return aConfig.Id - bConfig.Id;
					}
					return aConfig.SortId - bConfig.SortId;
				});
				foreach (KeySetting keySettingConfig in list)
				{
					KeySettingRowData keySettingRowData2 = new KeySettingRowData();
					keySettingRowData2.InitializeKeySetting(keySettingConfig);
					if (keySettingConfig.OnlyWorkNotShow)
					{
						KeySettingViewModel.HiddenKeySettingRowDataMap[keySettingConfig.Id] = keySettingRowData2;
					}
					else
					{
						KeySettingViewModel.KeyBoardSettingRowDataList.Add(keySettingRowData2);
						KeySettingViewModel.KeySettingRowDataMap[keySettingConfig.Id] = keySettingRowData2;
					}
				}
			}
		}
	}

	// Token: 0x0600D6DF RID: 55007 RVA: 0x003FB338 File Offset: 0x003F9538
	private static void InitializeXboxKeySettingRowData(IReadOnlyList<KeyType> keyTypeConfigList, EKeySettingExclusiveType exclusiveType)
	{
		KeySettingViewModel.GamepadKeySettingRowDataList.Clear();
		MenuBaseConfig instance = MenuBaseConfig.Instance;
		foreach (KeyType keyType in keyTypeConfigList)
		{
			int typeId = keyType.TypeId;
			IReadOnlyList<KeySetting> collection = instance.GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(typeId, 2, exclusiveType) ?? new List<KeySetting>();
			IReadOnlyList<KeySetting> collection2 = instance.GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(typeId, 0, exclusiveType) ?? new List<KeySetting>();
			List<KeySetting> list = new List<KeySetting>();
			list.AddRange(collection);
			list.AddRange(collection2);
			if (list.Count > 0)
			{
				KeySettingRowData keySettingRowData = new KeySettingRowData();
				keySettingRowData.InitializeKeyType(keyType);
				if (exclusiveType == EKeySettingExclusiveType.RhythmShip)
				{
					keySettingRowData.HelpBtnCallBack = RhythmShipModel.Instance.OpenKeyHelpView;
				}
				KeySettingViewModel.GamepadKeySettingRowDataList.Add(keySettingRowData);
				list.Sort(delegate(KeySetting aConfig, KeySetting bConfig)
				{
					if (aConfig.SortId == bConfig.SortId)
					{
						return aConfig.Id - bConfig.Id;
					}
					return aConfig.SortId - bConfig.SortId;
				});
				foreach (KeySetting keySettingConfig in list)
				{
					KeySettingRowData keySettingRowData2 = new KeySettingRowData();
					keySettingRowData2.InitializeKeySetting(keySettingConfig);
					if (keySettingConfig.OnlyWorkNotShow)
					{
						KeySettingViewModel.HiddenKeySettingRowDataMap[keySettingConfig.Id] = keySettingRowData2;
					}
					else
					{
						KeySettingViewModel.GamepadKeySettingRowDataList.Add(keySettingRowData2);
						KeySettingViewModel.KeySettingRowDataMap[keySettingConfig.Id] = keySettingRowData2;
					}
				}
			}
		}
	}

	// Token: 0x0600D6E0 RID: 55008 RVA: 0x003FB4DC File Offset: 0x003F96DC
	private static void RecordEditKey(string keyName)
	{
		KeySettingViewModel.EditKeyNameList.Add(keyName);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InputSettings;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "[KeySetting]记录要设置的按键";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EditKeyNameList", new List<string>(KeySettingViewModel.EditKeyNameList));
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600D6E1 RID: 55009 RVA: 0x003FB524 File Offset: 0x003F9724
	private static void ClearEditKeyNameList()
	{
		KeySettingViewModel.EditKeyNameList.Clear();
	}

	// Token: 0x0600D6E2 RID: 55010 RVA: 0x003FB530 File Offset: 0x003F9730
	private static void BeginEditKey()
	{
		KeySettingViewModel.NotifyOnBeforeBeginEditKey();
		KeySettingViewModel.EditKeyTimerHandle = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.XXJ, "[KeySetting]当等待键盘输入改键时25", default(ReadOnlySpan<ValueTuple<string, object>>));
			KeySettingViewModel.RemoveEditKeyTimerHandle();
			KeySettingViewModel.SetInputDisable(true);
			KeySettingViewModel.NotifyOnBeginEditKey();
			KeySettingViewModel.IsEditingInternal = true;
		}, null, null);
	}

	// Token: 0x0600D6E3 RID: 55011 RVA: 0x003FB568 File Offset: 0x003F9768
	private static void FinishEditKey()
	{
		Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.XXJ, "[KeySetting]当输入改键结束时", default(ReadOnlySpan<ValueTuple<string, object>>));
		KeySettingViewModel.SetInputDisable(false);
		KeySettingViewModel.RemoveEditKeyTimerHandle();
		KeySettingViewModel.SelectKey(null);
		UiLayer.Instance.SetShowMaskLayer("KeySettingMask", false);
		KeySettingViewModel.NotifyOnFinishEditKey();
		KeySettingViewModel.IsEditingInternal = false;
	}

	// Token: 0x0600D6E4 RID: 55012 RVA: 0x003FB5C0 File Offset: 0x003F97C0
	private static void SetInputDisable(bool isDisable)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InputSettings;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "[KeySetting]设置是否允许输入";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isWait", isDisable);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		KeySettingViewModel.ClearEditKeyNameList();
		MenuModel.Instance.IsWaitForKeyInput = isDisable;
		InputDistributeController.Instance.RefreshInputTag();
		UiLayer.Instance.SetShowMaskLayer("KeySettingMask", isDisable);
	}

	// Token: 0x0600D6E5 RID: 55013 RVA: 0x003FB623 File Offset: 0x003F9823
	private static void RemoveEditKeyTimerHandle()
	{
		if (KeySettingViewModel.EditKeyTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(KeySettingViewModel.EditKeyTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(KeySettingViewModel.EditKeyTimerHandle);
			KeySettingViewModel.EditKeyTimerHandle = null;
		}
	}

	// Token: 0x0600D6E6 RID: 55014 RVA: 0x003FB654 File Offset: 0x003F9854
	[return: Nullable(2)]
	private static KeySettingRowData GetSameKeySettingRowData(List<KeySettingRowData> keySettingRowDataList, List<string> checkKeyNameList, [Nullable(2)] KeySettingRowData filterKeyRowData)
	{
		if (checkKeyNameList == null || checkKeyNameList.Count <= 0)
		{
			return null;
		}
		foreach (KeySettingRowData keySettingRowData in keySettingRowDataList)
		{
			if (keySettingRowData != filterKeyRowData && keySettingRowData.HasKey(checkKeyNameList, KeySettingViewModel.InputControllerType))
			{
				return keySettingRowData;
			}
		}
		return null;
	}

	// Token: 0x0600D6E7 RID: 55015 RVA: 0x003FB6C4 File Offset: 0x003F98C4
	private static List<KeySettingRowData> SetConnectedKey(KeySettingRowData keySettingRawData, List<string> keyNameList)
	{
		List<KeySettingRowData> list = new List<KeySettingRowData>();
		foreach (int num in keySettingRawData.ConnectedKeySettingIdList)
		{
			KeySettingRowData keySettingRowData = null;
			KeySetting? config = ConfigKeySettingById.GetConfig(num, true);
			if (config != null && config.Value.OnlyWorkNotShow)
			{
				KeySettingViewModel.HiddenKeySettingRowDataMap.TryGetValue(num, out keySettingRowData);
			}
			else
			{
				KeySettingViewModel.KeySettingRowDataMap.TryGetValue(num, out keySettingRowData);
			}
			if (keySettingRowData != null)
			{
				keySettingRowData.SetKey(keyNameList, KeySettingViewModel.InputControllerType);
				list.Add(keySettingRowData);
			}
		}
		return list;
	}

	// Token: 0x0600D6E8 RID: 55016 RVA: 0x003FB774 File Offset: 0x003F9974
	private static void SetAndRefreshConnectedKey(KeySettingRowData keySettingRawData, List<string> keyNameList)
	{
		foreach (KeySettingRowData data in KeySettingViewModel.SetConnectedKey(keySettingRawData, keyNameList))
		{
			KeySettingViewModel.NotifyOnKeyChange(data, KeySettingViewModel.InputControllerType);
		}
	}

	// Token: 0x0600D6E9 RID: 55017 RVA: 0x003FB7CC File Offset: 0x003F99CC
	private unsafe static void OnInputAnyKey(bool bPress, FKey key)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.RepeatKeyTipsView))
		{
			return;
		}
		if (MenuModel.Instance == null || !MenuModel.Instance.IsWaitForKeyInput)
		{
			return;
		}
		string keyName = key.KeyName.ToString();
		InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("放弃改键");
		if (actionBinding != null && actionBinding.HasKey(keyName))
		{
			KeySettingViewModel.FinishEditKey();
			return;
		}
		if (KeySettingViewModel.WaitKeySettingRowData == null)
		{
			KeySettingViewModel.FinishEditKey();
			return;
		}
		if (KeySettingViewModel.WaitKeySettingRowData.IsLock)
		{
			GenericPromptController.Instance.ShowPromptByCode("KeyLock", Array.Empty<object>());
			KeySettingViewModel.FinishEditKey();
			return;
		}
		if (bPress)
		{
			KeySettingViewModel.RecordEditKey(keyName);
			return;
		}
		if (KeySettingViewModel.EditKeyNameList.Count > 1)
		{
			if (!KeySettingViewModel.WaitKeySettingRowData.CanCombination)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[KeySetting]改键失败，原因：该输入在配置上不允许修改成组合键";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionOrAxisName", KeySettingViewModel.WaitKeySettingRowData.GetActionOrAxisName());
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
				KeySettingViewModel.ClearEditKeyNameList();
				return;
			}
			if (!KeySettingViewModel.WaitKeySettingRowData.IsAllowCombinationKey(KeySettingViewModel.EditKeyNameList[0], KeySettingViewModel.EditKeyNameList[1]))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputSettings;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "[KeySetting]改键失败，原因：尝试修改为组合输入，但不在允许设置的组合按键范围配置里内";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionOrAxisName", KeySettingViewModel.WaitKeySettingRowData.GetActionOrAxisName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MainKey", KeySettingViewModel.EditKeyNameList[0]);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SecondKey", KeySettingViewModel.EditKeyNameList[1]);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
				KeySettingViewModel.ClearEditKeyNameList();
				return;
			}
		}
		else
		{
			if (!KeySettingViewModel.WaitKeySettingRowData.IsAllowKey(KeySettingViewModel.EditKeyNameList[0]))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.InputSettings;
				ELogAuthor author3 = ELogAuthor.XXJ;
				string message3 = "[KeySetting]改键失败，原因：不在允许设置的组合按键范围配置里内";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ActionOrAxisName", KeySettingViewModel.WaitKeySettingRowData.GetActionOrAxisName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("this.EditKeyNameList[0]", KeySettingViewModel.EditKeyNameList[0]);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
				KeySettingViewModel.ClearEditKeyNameList();
				return;
			}
			if (!MenuController.Instance.IsInputControllerTypeIncludeKey(KeySettingViewModel.InputControllerType, KeySettingViewModel.EditKeyNameList[0]))
			{
				GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
				KeySettingViewModel.ClearEditKeyNameList();
				return;
			}
		}
		List<KeySettingRowData> keySettingRowDataList = KeySettingViewModel.GamepadKeySettingRowDataList;
		if (InputSettings.Instance.IsKeyboardKey(keyName) || InputSettings.Instance.IsMouseButton(keyName))
		{
			keySettingRowDataList = KeySettingViewModel.KeyBoardSettingRowDataList;
		}
		KeySettingRowData sameKeySettingRowData = KeySettingViewModel.GetSameKeySettingRowData(keySettingRowDataList, KeySettingViewModel.EditKeyNameList, KeySettingViewModel.WaitKeySettingRowData);
		if (sameKeySettingRowData != null && sameKeySettingRowData.IsCheckSameKey)
		{
			List<string> editKeyNameList = new List<string>
			{
				KeySettingViewModel.EditKeyNameList[0]
			};
			if (KeySettingViewModel.EditKeyNameList.Count > 1 && KeySettingViewModel.EditKeyNameList[1] != null)
			{
				editKeyNameList.Add(KeySettingViewModel.EditKeyNameList[1]);
			}
			RepeatKeyInfo param = new RepeatKeyInfo
			{
				InputControllerType = KeySettingViewModel.InputControllerType,
				CurrentKeySettingRowData = KeySettingViewModel.WaitKeySettingRowData,
				RepeatKeySettingRowData = sameKeySettingRowData,
				OnCloseCallback = delegate(bool bConfirm)
				{
					if (!bConfirm)
					{
						KeySettingViewModel.SetInputDisable(true);
						return;
					}
					KeySettingViewModel.FinishEditKey();
					List<string> currentKeyName = KeySettingViewModel.WaitKeySettingRowData.GetCurrentKeyName(KeySettingViewModel.InputControllerType);
					if (currentKeyName == null)
					{
						return;
					}
					if (!sameKeySettingRowData.IsActionOrAxis && !KeySettingViewModel.WaitKeySettingRowData.IsActionOrAxis && sameKeySettingRowData.GetActionOrAxisName() == KeySettingViewModel.WaitKeySettingRowData.GetActionOrAxisName() && !sameKeySettingRowData.IsCombination(KeySettingViewModel.InputControllerType) && !KeySettingViewModel.WaitKeySettingRowData.IsCombination(KeySettingViewModel.InputControllerType))
					{
						Dictionary<string, float> axisKeyScaleMap = KeySettingViewModel.WaitKeySettingRowData.GetAxisKeyScaleMap();
						string key2 = editKeyNameList[0];
						string key3 = currentKeyName[0];
						float num;
						axisKeyScaleMap.TryGetValue(key2, out num);
						float num2;
						axisKeyScaleMap.TryGetValue(key3, out num2);
						if (num2 != 0f)
						{
							axisKeyScaleMap[key2] = num2;
						}
						if (num != 0f)
						{
							axisKeyScaleMap[key3] = num;
						}
						KeySettingViewModel.WaitKeySettingRowData.SetAxisBindingKeys(axisKeyScaleMap, KeySettingViewModel.WaitKeySettingRowData.BindingType);
					}
					else
					{
						sameKeySettingRowData.SetKey(currentKeyName, KeySettingViewModel.InputControllerType);
						KeySettingViewModel.WaitKeySettingRowData.SetKey(editKeyNameList, KeySettingViewModel.InputControllerType);
					}
					KeySettingViewModel.NotifyOnKeyChange(KeySettingViewModel.WaitKeySettingRowData, KeySettingViewModel.InputControllerType);
					KeySettingViewModel.NotifyOnKeyChange(sameKeySettingRowData, KeySettingViewModel.InputControllerType);
					KeySettingViewModel.SetAndRefreshConnectedKey(KeySettingViewModel.WaitKeySettingRowData, editKeyNameList);
					KeySettingViewModel.SetAndRefreshConnectedKey(sameKeySettingRowData, currentKeyName);
					InputSettingsController.Instance.InputSettingUpdateRequest();
					InputSettings.Instance.SaveKeyMappings();
				}
			};
			KeySettingViewModel.SetInputDisable(false);
			UiManager.Instance.OpenView(EUiViewName.RepeatKeyTipsView, param, null);
			return;
		}
		if (KeySettingViewModel.EditKeyNameList.Count > 0)
		{
			KeySettingViewModel.WaitKeySettingRowData.SetKey(KeySettingViewModel.EditKeyNameList, KeySettingViewModel.InputControllerType);
			KeySettingViewModel.NotifyOnKeyChange(KeySettingViewModel.WaitKeySettingRowData, KeySettingViewModel.InputControllerType);
			KeySettingViewModel.SetAndRefreshConnectedKey(KeySettingViewModel.WaitKeySettingRowData, KeySettingViewModel.EditKeyNameList);
			InputSettingsController.Instance.InputSettingUpdateRequest();
			InputSettings.Instance.SaveKeyMappings();
			KeySettingViewModel.FinishEditKey();
		}
	}

	// Token: 0x0600D6EA RID: 55018 RVA: 0x003FBBC8 File Offset: 0x003F9DC8
	private static void OnConfirmChangeBothAction(bool bRevert)
	{
		if (KeySettingViewModel.WaitKeySettingRowData == null)
		{
			KeySettingViewModel.FinishEditKey();
			return;
		}
		if (bRevert)
		{
			KeySettingViewModel.WaitKeySettingRowData.ChangeBothAction(KeySettingViewModel.InputControllerType);
			KeySettingViewModel.NotifyOnKeyChange(KeySettingViewModel.WaitKeySettingRowData, KeySettingViewModel.InputControllerType);
			InputSettingsController.Instance.InputSettingUpdateRequest();
			InputSettings.Instance.SaveKeyMappings();
		}
		KeySettingViewModel.FinishEditKey();
	}

	// Token: 0x04007851 RID: 30801
	private static readonly List<Action<KeySettingRowData, IKeySettingItem>> DelegatesOnWaitKeySetting = new List<Action<KeySettingRowData, IKeySettingItem>>();

	// Token: 0x04007852 RID: 30802
	private static readonly List<Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>> DelegatesOnKeyChange = new List<Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>>();

	// Token: 0x04007853 RID: 30803
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private static readonly List<Action<KeySettingRowData>> DelegatesOnKeySelected = new List<Action<KeySettingRowData>>();

	// Token: 0x04007854 RID: 30804
	private static readonly List<Action> DelegatesOnBeforeBeginEditKey = new List<Action>();

	// Token: 0x04007855 RID: 30805
	private static readonly List<Action> DelegatesOnBeginEditKey = new List<Action>();

	// Token: 0x04007856 RID: 30806
	private static readonly List<Action> DelegatesOnFinishEditKey = new List<Action>();

	// Token: 0x04007857 RID: 30807
	private static readonly List<Action<KeySettingRowData>> DelegatesOnKeyHover = new List<Action<KeySettingRowData>>();

	// Token: 0x04007858 RID: 30808
	private static readonly List<Action<KeySettingRowData>> DelegatesOnKeyUnHover = new List<Action<KeySettingRowData>>();

	// Token: 0x04007859 RID: 30809
	[Nullable(2)]
	private static KeySettingRowData WaitKeySettingRowData;

	// Token: 0x0400785A RID: 30810
	private static readonly List<string> EditKeyNameList = new List<string>();

	// Token: 0x0400785B RID: 30811
	private static readonly List<KeySettingRowData> GamepadKeySettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x0400785C RID: 30812
	private static readonly List<KeySettingRowData> HiddenGamepadKeySettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x0400785D RID: 30813
	private static readonly List<KeySettingRowData> KeyBoardSettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x0400785E RID: 30814
	private static readonly List<KeySettingRowData> HiddenKeyBoardSettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x0400785F RID: 30815
	private static readonly Dictionary<int, KeySettingRowData> KeySettingRowDataMap = new Dictionary<int, KeySettingRowData>();

	// Token: 0x04007860 RID: 30816
	private static readonly Dictionary<int, KeySettingRowData> HiddenKeySettingRowDataMap = new Dictionary<int, KeySettingRowData>();

	// Token: 0x04007861 RID: 30817
	private static CSharpScript.Game.Module.Menu.EInputControllerType InputControllerTypeInternal = CSharpScript.Game.Module.Menu.EInputControllerType.None;

	// Token: 0x04007862 RID: 30818
	private static bool IsEditingInternal = false;

	// Token: 0x04007863 RID: 30819
	[Nullable(2)]
	private static TimerHandle EditKeyTimerHandle;

	// Token: 0x020077A7 RID: 30631
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026D65 RID: 159077
		[Nullable(0)]
		public static Action<bool> <0>__OnConfirmChangeBothAction;

		// Token: 0x04026D66 RID: 159078
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<bool, FKey> <1>__OnInputAnyKey;
	}
}
