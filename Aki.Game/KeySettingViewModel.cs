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

// Token: 0x0200202A RID: 8234
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class KeySettingViewModel
{
	// Token: 0x170013B2 RID: 5042
	// (get) Token: 0x0601024D RID: 66125 RVA: 0x003EE2DF File Offset: 0x003EC4DF
	public static bool IsEditing
	{
		get
		{
			return KeySettingViewModel.IsEditingInternal;
		}
	}

	// Token: 0x170013B3 RID: 5043
	// (get) Token: 0x0601024E RID: 66126 RVA: 0x003EE2E6 File Offset: 0x003EC4E6
	// (set) Token: 0x0601024F RID: 66127 RVA: 0x003EE2ED File Offset: 0x003EC4ED
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

	// Token: 0x170013B4 RID: 5044
	// (get) Token: 0x06010250 RID: 66128 RVA: 0x003EE2F8 File Offset: 0x003EC4F8
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

	// Token: 0x06010251 RID: 66129 RVA: 0x003EE31A File Offset: 0x003EC51A
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

	// Token: 0x06010252 RID: 66130 RVA: 0x003EE348 File Offset: 0x003EC548
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

	// Token: 0x06010253 RID: 66131 RVA: 0x003EE386 File Offset: 0x003EC586
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

	// Token: 0x06010254 RID: 66132 RVA: 0x003EE3A9 File Offset: 0x003EC5A9
	public static void OnViewDestroy()
	{
		KeySettingViewModel.Clear();
	}

	// Token: 0x06010255 RID: 66133 RVA: 0x003EE3B0 File Offset: 0x003EC5B0
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

	// Token: 0x06010256 RID: 66134 RVA: 0x003EE4C0 File Offset: 0x003EC6C0
	public static void ExternalFinishEditKey()
	{
		KeySettingViewModel.FinishEditKey();
	}

	// Token: 0x06010257 RID: 66135 RVA: 0x003EE4C8 File Offset: 0x003EC6C8
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

	// Token: 0x06010258 RID: 66136 RVA: 0x003EE5C9 File Offset: 0x003EC7C9
	[NullableContext(2)]
	public static void SelectKey(KeySettingRowData data)
	{
		KeySettingViewModel.NotifyOnKeySelected(data);
	}

	// Token: 0x06010259 RID: 66137 RVA: 0x003EE5D1 File Offset: 0x003EC7D1
	public static void HoverKey(KeySettingRowData data)
	{
		KeySettingViewModel.NotifyOnKeyHover(data);
	}

	// Token: 0x0601025A RID: 66138 RVA: 0x003EE5D9 File Offset: 0x003EC7D9
	public static void UnHoverKey(KeySettingRowData data)
	{
		KeySettingViewModel.NotifyOnKeyUnHover(data);
	}

	// Token: 0x0601025B RID: 66139 RVA: 0x003EE5E1 File Offset: 0x003EC7E1
	public static void AddOnWaitKeySettingDelegate(Action<KeySettingRowData, IKeySettingItem> d)
	{
		if (!KeySettingViewModel.DelegatesOnWaitKeySetting.Contains(d))
		{
			KeySettingViewModel.DelegatesOnWaitKeySetting.Add(d);
		}
	}

	// Token: 0x0601025C RID: 66140 RVA: 0x003EE5FC File Offset: 0x003EC7FC
	public static void RemoveOnWaitKeySettingDelegate(Action<KeySettingRowData, IKeySettingItem> d)
	{
		int num = KeySettingViewModel.DelegatesOnWaitKeySetting.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnWaitKeySetting.RemoveAt(num);
		}
	}

	// Token: 0x0601025D RID: 66141 RVA: 0x003EE624 File Offset: 0x003EC824
	public static void AddOnKeyChangeDelegate(Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeyChange.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeyChange.Add(d);
		}
	}

	// Token: 0x0601025E RID: 66142 RVA: 0x003EE640 File Offset: 0x003EC840
	public static void RemoveOnKeyChangeDelegate(Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeyChange.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeyChange.RemoveAt(num);
		}
	}

	// Token: 0x0601025F RID: 66143 RVA: 0x003EE668 File Offset: 0x003EC868
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

	// Token: 0x06010260 RID: 66144 RVA: 0x003EE684 File Offset: 0x003EC884
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

	// Token: 0x06010261 RID: 66145 RVA: 0x003EE6AC File Offset: 0x003EC8AC
	public static void AddOnBeforeBeginEditKeyDelegate(Action d)
	{
		if (!KeySettingViewModel.DelegatesOnBeforeBeginEditKey.Contains(d))
		{
			KeySettingViewModel.DelegatesOnBeforeBeginEditKey.Add(d);
		}
	}

	// Token: 0x06010262 RID: 66146 RVA: 0x003EE6C8 File Offset: 0x003EC8C8
	public static void RemoveOnBeforeBeginEditKeyDelegate(Action d)
	{
		int num = KeySettingViewModel.DelegatesOnBeforeBeginEditKey.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnBeforeBeginEditKey.RemoveAt(num);
		}
	}

	// Token: 0x06010263 RID: 66147 RVA: 0x003EE6F0 File Offset: 0x003EC8F0
	public static void AddOnBeginEditKeyDelegate(Action d)
	{
		if (!KeySettingViewModel.DelegatesOnBeginEditKey.Contains(d))
		{
			KeySettingViewModel.DelegatesOnBeginEditKey.Add(d);
		}
	}

	// Token: 0x06010264 RID: 66148 RVA: 0x003EE70C File Offset: 0x003EC90C
	public static void RemoveOnBeginEditKeyDelegate(Action d)
	{
		int num = KeySettingViewModel.DelegatesOnBeginEditKey.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnBeginEditKey.RemoveAt(num);
		}
	}

	// Token: 0x06010265 RID: 66149 RVA: 0x003EE734 File Offset: 0x003EC934
	public static void AddOnFinishEditKeyDelegate(Action d)
	{
		if (!KeySettingViewModel.DelegatesOnFinishEditKey.Contains(d))
		{
			KeySettingViewModel.DelegatesOnFinishEditKey.Add(d);
		}
	}

	// Token: 0x06010266 RID: 66150 RVA: 0x003EE750 File Offset: 0x003EC950
	public static void RemoveOnFinishEditKeyDelegate(Action d)
	{
		int num = KeySettingViewModel.DelegatesOnFinishEditKey.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnFinishEditKey.RemoveAt(num);
		}
	}

	// Token: 0x06010267 RID: 66151 RVA: 0x003EE778 File Offset: 0x003EC978
	public static void AddOnKeyHoverDelegate(Action<KeySettingRowData> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeyHover.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeyHover.Add(d);
		}
	}

	// Token: 0x06010268 RID: 66152 RVA: 0x003EE794 File Offset: 0x003EC994
	public static void RemoveOnKeyHoverDelegate(Action<KeySettingRowData> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeyHover.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeyHover.RemoveAt(num);
		}
	}

	// Token: 0x06010269 RID: 66153 RVA: 0x003EE7BC File Offset: 0x003EC9BC
	public static void AddOnKeyUnHoverDelegate(Action<KeySettingRowData> d)
	{
		if (!KeySettingViewModel.DelegatesOnKeyUnHover.Contains(d))
		{
			KeySettingViewModel.DelegatesOnKeyUnHover.Add(d);
		}
	}

	// Token: 0x0601026A RID: 66154 RVA: 0x003EE7D8 File Offset: 0x003EC9D8
	public static void RemoveOnKeyUnHoverDelegate(Action<KeySettingRowData> d)
	{
		int num = KeySettingViewModel.DelegatesOnKeyUnHover.IndexOf(d);
		if (num != -1)
		{
			KeySettingViewModel.DelegatesOnKeyUnHover.RemoveAt(num);
		}
	}

	// Token: 0x0601026B RID: 66155 RVA: 0x003EE800 File Offset: 0x003ECA00
	private static void NotifyOnWaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		foreach (Action<KeySettingRowData, IKeySettingItem> action in KeySettingViewModel.DelegatesOnWaitKeySetting)
		{
			action(data, item);
		}
	}

	// Token: 0x0601026C RID: 66156 RVA: 0x003EE854 File Offset: 0x003ECA54
	private static void NotifyOnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		foreach (Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> action in KeySettingViewModel.DelegatesOnKeyChange)
		{
			action(data, inputControllerType);
		}
		EventSystem.Instance.Emit<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(EEventName.OnCommonKeySettingKeyChange, data, inputControllerType);
	}

	// Token: 0x0601026D RID: 66157 RVA: 0x003EE8B8 File Offset: 0x003ECAB8
	[NullableContext(2)]
	private static void NotifyOnKeySelected(KeySettingRowData data)
	{
		foreach (Action<KeySettingRowData> action in KeySettingViewModel.DelegatesOnKeySelected)
		{
			action(data);
		}
	}

	// Token: 0x0601026E RID: 66158 RVA: 0x003EE908 File Offset: 0x003ECB08
	private static void NotifyOnBeforeBeginEditKey()
	{
		foreach (Action action in KeySettingViewModel.DelegatesOnBeforeBeginEditKey)
		{
			action();
		}
	}

	// Token: 0x0601026F RID: 66159 RVA: 0x003EE958 File Offset: 0x003ECB58
	private static void NotifyOnBeginEditKey()
	{
		foreach (Action action in KeySettingViewModel.DelegatesOnBeginEditKey)
		{
			action();
		}
	}

	// Token: 0x06010270 RID: 66160 RVA: 0x003EE9A8 File Offset: 0x003ECBA8
	private static void NotifyOnFinishEditKey()
	{
		foreach (Action action in KeySettingViewModel.DelegatesOnFinishEditKey)
		{
			action();
		}
	}

	// Token: 0x06010271 RID: 66161 RVA: 0x003EE9F8 File Offset: 0x003ECBF8
	private static void NotifyOnKeyHover(KeySettingRowData data)
	{
		foreach (Action<KeySettingRowData> action in KeySettingViewModel.DelegatesOnKeyHover)
		{
			action(data);
		}
	}

	// Token: 0x06010272 RID: 66162 RVA: 0x003EEA48 File Offset: 0x003ECC48
	private static void NotifyOnKeyUnHover(KeySettingRowData data)
	{
		foreach (Action<KeySettingRowData> action in KeySettingViewModel.DelegatesOnKeyUnHover)
		{
			action(data);
		}
	}

	// Token: 0x06010273 RID: 66163 RVA: 0x003EEA98 File Offset: 0x003ECC98
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

	// Token: 0x06010274 RID: 66164 RVA: 0x003EEAC5 File Offset: 0x003ECCC5
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

	// Token: 0x06010275 RID: 66165 RVA: 0x003EEAF4 File Offset: 0x003ECCF4
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

	// Token: 0x06010276 RID: 66166 RVA: 0x003EEB9C File Offset: 0x003ECD9C
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

	// Token: 0x06010277 RID: 66167 RVA: 0x003EED40 File Offset: 0x003ECF40
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

	// Token: 0x06010278 RID: 66168 RVA: 0x003EEEE4 File Offset: 0x003ED0E4
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

	// Token: 0x06010279 RID: 66169 RVA: 0x003EEF2C File Offset: 0x003ED12C
	private static void ClearEditKeyNameList()
	{
		KeySettingViewModel.EditKeyNameList.Clear();
	}

	// Token: 0x0601027A RID: 66170 RVA: 0x003EEF38 File Offset: 0x003ED138
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

	// Token: 0x0601027B RID: 66171 RVA: 0x003EEF70 File Offset: 0x003ED170
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

	// Token: 0x0601027C RID: 66172 RVA: 0x003EEFC8 File Offset: 0x003ED1C8
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

	// Token: 0x0601027D RID: 66173 RVA: 0x003EF02B File Offset: 0x003ED22B
	private static void RemoveEditKeyTimerHandle()
	{
		if (KeySettingViewModel.EditKeyTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(KeySettingViewModel.EditKeyTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(KeySettingViewModel.EditKeyTimerHandle);
			KeySettingViewModel.EditKeyTimerHandle = null;
		}
	}

	// Token: 0x0601027E RID: 66174 RVA: 0x003EF05C File Offset: 0x003ED25C
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

	// Token: 0x0601027F RID: 66175 RVA: 0x003EF0CC File Offset: 0x003ED2CC
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

	// Token: 0x06010280 RID: 66176 RVA: 0x003EF17C File Offset: 0x003ED37C
	private static void SetAndRefreshConnectedKey(KeySettingRowData keySettingRawData, List<string> keyNameList)
	{
		foreach (KeySettingRowData data in KeySettingViewModel.SetConnectedKey(keySettingRawData, keyNameList))
		{
			KeySettingViewModel.NotifyOnKeyChange(data, KeySettingViewModel.InputControllerType);
		}
	}

	// Token: 0x06010281 RID: 66177 RVA: 0x003EF1D4 File Offset: 0x003ED3D4
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

	// Token: 0x06010282 RID: 66178 RVA: 0x003EF5D0 File Offset: 0x003ED7D0
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

	// Token: 0x04007768 RID: 30568
	private static readonly List<Action<KeySettingRowData, IKeySettingItem>> DelegatesOnWaitKeySetting = new List<Action<KeySettingRowData, IKeySettingItem>>();

	// Token: 0x04007769 RID: 30569
	private static readonly List<Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>> DelegatesOnKeyChange = new List<Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>>();

	// Token: 0x0400776A RID: 30570
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private static readonly List<Action<KeySettingRowData>> DelegatesOnKeySelected = new List<Action<KeySettingRowData>>();

	// Token: 0x0400776B RID: 30571
	private static readonly List<Action> DelegatesOnBeforeBeginEditKey = new List<Action>();

	// Token: 0x0400776C RID: 30572
	private static readonly List<Action> DelegatesOnBeginEditKey = new List<Action>();

	// Token: 0x0400776D RID: 30573
	private static readonly List<Action> DelegatesOnFinishEditKey = new List<Action>();

	// Token: 0x0400776E RID: 30574
	private static readonly List<Action<KeySettingRowData>> DelegatesOnKeyHover = new List<Action<KeySettingRowData>>();

	// Token: 0x0400776F RID: 30575
	private static readonly List<Action<KeySettingRowData>> DelegatesOnKeyUnHover = new List<Action<KeySettingRowData>>();

	// Token: 0x04007770 RID: 30576
	[Nullable(2)]
	private static KeySettingRowData WaitKeySettingRowData;

	// Token: 0x04007771 RID: 30577
	private static readonly List<string> EditKeyNameList = new List<string>();

	// Token: 0x04007772 RID: 30578
	private static readonly List<KeySettingRowData> GamepadKeySettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x04007773 RID: 30579
	private static readonly List<KeySettingRowData> HiddenGamepadKeySettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x04007774 RID: 30580
	private static readonly List<KeySettingRowData> KeyBoardSettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x04007775 RID: 30581
	private static readonly List<KeySettingRowData> HiddenKeyBoardSettingRowDataList = new List<KeySettingRowData>();

	// Token: 0x04007776 RID: 30582
	private static readonly Dictionary<int, KeySettingRowData> KeySettingRowDataMap = new Dictionary<int, KeySettingRowData>();

	// Token: 0x04007777 RID: 30583
	private static readonly Dictionary<int, KeySettingRowData> HiddenKeySettingRowDataMap = new Dictionary<int, KeySettingRowData>();

	// Token: 0x04007778 RID: 30584
	private static CSharpScript.Game.Module.Menu.EInputControllerType InputControllerTypeInternal = CSharpScript.Game.Module.Menu.EInputControllerType.None;

	// Token: 0x04007779 RID: 30585
	private static bool IsEditingInternal = false;

	// Token: 0x0400777A RID: 30586
	[Nullable(2)]
	private static TimerHandle EditKeyTimerHandle;

	// Token: 0x02008620 RID: 34336
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BA56 RID: 178774
		[Nullable(0)]
		public static Action<bool> <0>__OnConfirmChangeBothAction;

		// Token: 0x0402BA57 RID: 178775
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<bool, FKey> <1>__OnInputAnyKey;
	}
}
