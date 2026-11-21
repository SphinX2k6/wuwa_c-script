using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.UiNavigation;

// Token: 0x0200222A RID: 8746
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class UiNavigationModel : ModelBase
{
	// Token: 0x06015984 RID: 88452 RVA: 0x00644498 File Offset: 0x00642698
	public void InputControllerModeChange()
	{
		foreach (HashSet<HotKeyComponent> hashSet in this.ActionNameHotKeyComponentMap.Values)
		{
			foreach (HotKeyComponent hotKeyComponent in hashSet)
			{
				hotKeyComponent.RefreshMode();
			}
		}
		foreach (HashSet<HotKeyComponent> hashSet2 in this.AxisNameHotKeyComponentMap.Values)
		{
			foreach (HotKeyComponent hotKeyComponent2 in hashSet2)
			{
				hotKeyComponent2.RefreshMode();
			}
		}
		foreach (TsUiNavigationPlatformChangeListener tsUiNavigationPlatformChangeListener in this.PlatformListenerSet)
		{
			tsUiNavigationPlatformChangeListener.ChangeState();
		}
	}

	// Token: 0x06015985 RID: 88453 RVA: 0x006445D8 File Offset: 0x006427D8
	public unsafe void CustomShieldHotKeyComponent(HashSet<int> excludeHotKeyIndexSet, bool bActive)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "业务触发自定义屏蔽热键组件";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("excludeHotKeyIndexSet", excludeHotKeyIndexSet);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bActive", bActive);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		foreach (HashSet<HotKeyComponent> hashSet in this.ActionNameHotKeyComponentMap.Values)
		{
			foreach (HotKeyComponent hotKeyComponent in hashSet)
			{
				if (!excludeHotKeyIndexSet.Contains(hotKeyComponent.GetHotKeyMapIndex()))
				{
					hotKeyComponent.OnlySetVisibleMode(HotKeyViewDefine.ELogicMode.CustomShield, bActive);
				}
			}
		}
		foreach (HashSet<HotKeyComponent> hashSet2 in this.AxisNameHotKeyComponentMap.Values)
		{
			foreach (HotKeyComponent hotKeyComponent2 in hashSet2)
			{
				if (!excludeHotKeyIndexSet.Contains(hotKeyComponent2.GetHotKeyMapIndex()))
				{
					hotKeyComponent2.OnlySetVisibleMode(HotKeyViewDefine.ELogicMode.CustomShield, bActive);
				}
			}
		}
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
	}

	// Token: 0x06015986 RID: 88454 RVA: 0x00644770 File Offset: 0x00642970
	protected override bool OnClear()
	{
		this.ClearCursor();
		UiNavigationGlobalData.ClearBlockListener();
		return true;
	}

	// Token: 0x06015987 RID: 88455 RVA: 0x0064477E File Offset: 0x0064297E
	[NullableContext(2)]
	public void SetCursorFollowItem(TsUiNavigationBehaviorListener listener)
	{
		this.Cursor.SetFollowItem(listener);
	}

	// Token: 0x06015988 RID: 88456 RVA: 0x0064478C File Offset: 0x0064298C
	public void SetIsUseMouse(bool value)
	{
		this.Cursor.SetIsUseMouse(value);
	}

	// Token: 0x06015989 RID: 88457 RVA: 0x0064479A File Offset: 0x0064299A
	public void MarkMoveInstantly()
	{
		this.Cursor.IsMoveInstantly = true;
	}

	// Token: 0x0601598A RID: 88458 RVA: 0x006447A8 File Offset: 0x006429A8
	public void SetCursorActiveDelayTime(float time)
	{
		this.Cursor.SetCursorActiveDelayTime(time);
	}

	// Token: 0x0601598B RID: 88459 RVA: 0x006447B6 File Offset: 0x006429B6
	public void TrySetCursorActive(bool value)
	{
		this.Cursor.TrySetUseItemUiActive(value);
	}

	// Token: 0x0601598C RID: 88460 RVA: 0x006447C4 File Offset: 0x006429C4
	public void RefreshCursorActive()
	{
		this.Cursor.RefreshCursorActive();
	}

	// Token: 0x0601598D RID: 88461 RVA: 0x006447D1 File Offset: 0x006429D1
	public void RepeatMove()
	{
		this.Cursor.RepeatMove();
	}

	// Token: 0x0601598E RID: 88462 RVA: 0x006447E0 File Offset: 0x006429E0
	public void ClearCursor()
	{
		Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "清理光标", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.Cursor.Clear();
	}

	// Token: 0x0601598F RID: 88463 RVA: 0x00644817 File Offset: 0x00642A17
	protected override bool OnLeaveLevel()
	{
		this.ClearCursor();
		return true;
	}

	// Token: 0x06015990 RID: 88464 RVA: 0x00644820 File Offset: 0x00642A20
	public void Tick(float delta)
	{
		this.Cursor.Tick(delta);
	}

	// Token: 0x06015991 RID: 88465 RVA: 0x0064482E File Offset: 0x00642A2E
	public void AddActionHotKeyComponent(string actionName, HashSet<HotKeyComponent> hotKeyComponentSet)
	{
		this.ActionNameHotKeyComponentMap[actionName] = hotKeyComponentSet;
	}

	// Token: 0x06015992 RID: 88466 RVA: 0x0064483D File Offset: 0x00642A3D
	public HashSet<HotKeyComponent> GetActionHotKeyComponentSet(string actionName)
	{
		return this.ActionNameHotKeyComponentMap[actionName];
	}

	// Token: 0x06015993 RID: 88467 RVA: 0x0064484C File Offset: 0x00642A4C
	public HashSet<HotKeyComponent> GetOrAddActionHotKeyComponentSet(string actionName)
	{
		HashSet<HotKeyComponent> hashSet;
		if (!this.ActionNameHotKeyComponentMap.TryGetValue(actionName, out hashSet))
		{
			hashSet = new HashSet<HotKeyComponent>();
			this.AddActionHotKeyComponent(actionName, hashSet);
		}
		return hashSet;
	}

	// Token: 0x06015994 RID: 88468 RVA: 0x00644878 File Offset: 0x00642A78
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] CheckActionNameInKeySet(string actionName, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] ValueTuple<IReadOnlyList<string>, bool> inKeyNameData)
	{
		HashSet<string> hashSet = new HashSet<string>(inKeyNameData.Item1);
		ValueTuple<IReadOnlyList<string>, bool>? platformKeyNameDataByActionName = this.GetPlatformKeyNameDataByActionName(actionName);
		if (platformKeyNameDataByActionName == null)
		{
			return null;
		}
		bool item = inKeyNameData.Item2;
		bool item2 = platformKeyNameDataByActionName.Value.Item2;
		if (item == item2)
		{
			if (item)
			{
				HashSet<string> hashSet2 = new HashSet<string>();
				foreach (string item3 in platformKeyNameDataByActionName.Value.Item1)
				{
					if (hashSet.Contains(item3))
					{
						hashSet2.Add(item3);
					}
				}
				if (hashSet2.Count == hashSet.Count)
				{
					string[] array = new string[hashSet2.Count];
					hashSet2.CopyTo(array, 0);
					return array;
				}
			}
			else
			{
				foreach (string text in platformKeyNameDataByActionName.Value.Item1)
				{
					if (hashSet.Contains(text))
					{
						return new string[]
						{
							text
						};
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06015995 RID: 88469 RVA: 0x006449AC File Offset: 0x00642BAC
	[return: Nullable(2)]
	private string CheckAxisNameInKeySet(string axisName, HashSet<string> keyNameSet)
	{
		IReadOnlyList<string> platformKeyNameListByAxisName = this.GetPlatformKeyNameListByAxisName(axisName);
		if (platformKeyNameListByAxisName == null)
		{
			return null;
		}
		foreach (string text in platformKeyNameListByAxisName)
		{
			if (keyNameSet.Contains(text))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06015996 RID: 88470 RVA: 0x00644A0C File Offset: 0x00642C0C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<IReadOnlyList<string>, bool>? GetPlatformKeyNameDataByActionName(string actionName)
	{
		InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(actionName);
		if (combinationActionBindingByActionName != null)
		{
			List<string> list = new List<string>();
			combinationActionBindingByActionName.GetCurrentPlatformKeyNameList(list);
			if (list.Count > 0)
			{
				return new ValueTuple<IReadOnlyList<string>, bool>?(new ValueTuple<IReadOnlyList<string>, bool>(list, true));
			}
		}
		InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
		if (actionBinding != null)
		{
			IReadOnlyList<string> currentPlatformKeyNameList = actionBinding.GetCurrentPlatformKeyNameList();
			if (currentPlatformKeyNameList.Count > 0)
			{
				return new ValueTuple<IReadOnlyList<string>, bool>?(new ValueTuple<IReadOnlyList<string>, bool>(currentPlatformKeyNameList, false));
			}
		}
		return null;
	}

	// Token: 0x06015997 RID: 88471 RVA: 0x00644A84 File Offset: 0x00642C84
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<string> GetPlatformKeyNameListByAxisName(string axisName)
	{
		InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(axisName);
		if (axisBinding != null)
		{
			IReadOnlyList<string> currentPlatformKeyNameList = axisBinding.GetCurrentPlatformKeyNameList();
			if (currentPlatformKeyNameList.Count > 0)
			{
				return currentPlatformKeyNameList;
			}
		}
		return null;
	}

	// Token: 0x06015998 RID: 88472 RVA: 0x00644AB4 File Offset: 0x00642CB4
	public IReadOnlyList<string> GetGamepadKeyNameListByActionName(string actionName)
	{
		InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(actionName);
		if (combinationActionBindingByActionName != null)
		{
			List<string> list = new List<string>();
			combinationActionBindingByActionName.GetCurrentGamepadKeyNameList(list);
			if (list.Count > 0)
			{
				return list;
			}
		}
		InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
		if (actionBinding != null)
		{
			IReadOnlyList<string> currentGamepadKeyNameList = actionBinding.GetCurrentGamepadKeyNameList();
			if (currentGamepadKeyNameList.Count > 0)
			{
				return currentGamepadKeyNameList;
			}
		}
		return Array.Empty<string>();
	}

	// Token: 0x06015999 RID: 88473 RVA: 0x00644B10 File Offset: 0x00642D10
	public bool CheckActionNameListInNavigation(string refActionName)
	{
		ValueTuple<IReadOnlyList<string>, bool>? platformKeyNameDataByActionName = this.GetPlatformKeyNameDataByActionName(refActionName);
		if (platformKeyNameDataByActionName == null)
		{
			return false;
		}
		foreach (KeyValuePair<string, HashSet<HotKeyComponent>> keyValuePair in this.ActionNameHotKeyComponentMap)
		{
			string text;
			HashSet<HotKeyComponent> hashSet;
			keyValuePair.Deconstruct(out text, out hashSet);
			string text2 = text;
			HashSet<HotKeyComponent> hashSet2 = hashSet;
			if (!(refActionName == text2) && this.CheckActionNameInKeySet(text2, platformKeyNameDataByActionName.Value) != null)
			{
				foreach (HotKeyComponent hotKeyComponent in hashSet2)
				{
					if (hotKeyComponent.IsHotKeyActive() && hotKeyComponent.IsOccupancyFightInput())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0601599A RID: 88474 RVA: 0x00644BF0 File Offset: 0x00642DF0
	public bool CheckAxisNameListInNavigation(string refAxisName)
	{
		IReadOnlyList<string> platformKeyNameListByAxisName = this.GetPlatformKeyNameListByAxisName(refAxisName);
		if (platformKeyNameListByAxisName == null)
		{
			return false;
		}
		HashSet<string> keyNameSet = new HashSet<string>(platformKeyNameListByAxisName);
		foreach (KeyValuePair<string, HashSet<HotKeyComponent>> keyValuePair in this.AxisNameHotKeyComponentMap)
		{
			string text;
			HashSet<HotKeyComponent> hashSet;
			keyValuePair.Deconstruct(out text, out hashSet);
			string text2 = text;
			HashSet<HotKeyComponent> hashSet2 = hashSet;
			if (!(refAxisName == text2) && this.CheckAxisNameInKeySet(text2, keyNameSet) != null)
			{
				foreach (HotKeyComponent hotKeyComponent in hashSet2)
				{
					if (hotKeyComponent.IsHotKeyActive() && hotKeyComponent.GetHotKeyFunctionType() != "ShowOnly")
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0601599B RID: 88475 RVA: 0x00644CD8 File Offset: 0x00642ED8
	public void AddAxisHotKeyComponent(string axisName, HashSet<HotKeyComponent> hotKeyComponentSet)
	{
		this.AxisNameHotKeyComponentMap[axisName] = hotKeyComponentSet;
	}

	// Token: 0x0601599C RID: 88476 RVA: 0x00644CE7 File Offset: 0x00642EE7
	public HashSet<HotKeyComponent> GetAxisHotKeyComponentSet(string axisName)
	{
		return this.AxisNameHotKeyComponentMap[axisName];
	}

	// Token: 0x0601599D RID: 88477 RVA: 0x00644CF8 File Offset: 0x00642EF8
	public HashSet<HotKeyComponent> GetOrAddAxisHotKeyComponentsSet(string axisName)
	{
		HashSet<HotKeyComponent> hashSet;
		if (!this.AxisNameHotKeyComponentMap.TryGetValue(axisName, out hashSet))
		{
			hashSet = new HashSet<HotKeyComponent>();
			this.AddAxisHotKeyComponent(axisName, hashSet);
		}
		return hashSet;
	}

	// Token: 0x0601599E RID: 88478 RVA: 0x00644D24 File Offset: 0x00642F24
	public void AddPlatformListener(TsUiNavigationPlatformChangeListener listener)
	{
		this.PlatformListenerSet.Add(listener);
	}

	// Token: 0x0601599F RID: 88479 RVA: 0x00644D33 File Offset: 0x00642F33
	public void RemovePlatformListener(TsUiNavigationPlatformChangeListener listener)
	{
		this.PlatformListenerSet.Remove(listener);
	}

	// Token: 0x170020C6 RID: 8390
	// (get) Token: 0x060159A0 RID: 88480 RVA: 0x00644D42 File Offset: 0x00642F42
	[Nullable(2)]
	public TsUiNavigationBehaviorListener GuideFocusListener
	{
		[NullableContext(2)]
		get
		{
			return this.GuideFocusListenerInternal;
		}
	}

	// Token: 0x060159A1 RID: 88481 RVA: 0x00644D4A File Offset: 0x00642F4A
	public void SetGuideFocusListener(TsUiNavigationBehaviorListener listener)
	{
		this.GuideFocusListenerInternal = listener;
	}

	// Token: 0x060159A2 RID: 88482 RVA: 0x00644D53 File Offset: 0x00642F53
	public void ResetGuideFocusListener()
	{
		this.GuideFocusListenerInternal = null;
	}

	// Token: 0x170020C7 RID: 8391
	// (get) Token: 0x060159A3 RID: 88483 RVA: 0x00644D5C File Offset: 0x00642F5C
	public static UiNavigationModel Instance
	{
		get
		{
			return UiNavigationModel._Instance;
		}
	}

	// Token: 0x060159A4 RID: 88484 RVA: 0x00644D63 File Offset: 0x00642F63
	public static UiNavigationModel GetOrCreateInstance()
	{
		if (UiNavigationModel._Instance == null)
		{
			UiNavigationModel.CreateInstance();
		}
		return UiNavigationModel._Instance;
	}

	// Token: 0x060159A5 RID: 88485 RVA: 0x00644D77 File Offset: 0x00642F77
	public static bool CreateInstance()
	{
		if (UiNavigationModel._Instance != null)
		{
			return true;
		}
		UiNavigationModel._Instance = new UiNavigationModel();
		return true;
	}

	// Token: 0x060159A6 RID: 88486 RVA: 0x00644D8D File Offset: 0x00642F8D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060159A7 RID: 88487 RVA: 0x00644D8F File Offset: 0x00642F8F
	public static void ResetStaticDefaultValue()
	{
		UiNavigationModel._Instance = null;
	}

	// Token: 0x060159A8 RID: 88488 RVA: 0x00644D97 File Offset: 0x00642F97
	static UiNavigationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationModel.CreateStaticDefaultValue), new Action(UiNavigationModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B679 RID: 46713
	private readonly Cursor Cursor = new Cursor();

	// Token: 0x0400B67A RID: 46714
	public bool IsOpenLog;

	// Token: 0x0400B67B RID: 46715
	private readonly Dictionary<string, HashSet<HotKeyComponent>> ActionNameHotKeyComponentMap = new Dictionary<string, HashSet<HotKeyComponent>>();

	// Token: 0x0400B67C RID: 46716
	private readonly Dictionary<string, HashSet<HotKeyComponent>> AxisNameHotKeyComponentMap = new Dictionary<string, HashSet<HotKeyComponent>>();

	// Token: 0x0400B67D RID: 46717
	private readonly HashSet<TsUiNavigationPlatformChangeListener> PlatformListenerSet = new HashSet<TsUiNavigationPlatformChangeListener>();

	// Token: 0x0400B67E RID: 46718
	[Nullable(2)]
	private TsUiNavigationBehaviorListener GuideFocusListenerInternal;

	// Token: 0x0400B67F RID: 46719
	[Nullable(2)]
	private static UiNavigationModel _Instance;
}
