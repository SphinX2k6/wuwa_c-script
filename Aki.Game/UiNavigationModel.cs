using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.UiNavigation;

// Token: 0x02002CD1 RID: 11473
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class UiNavigationModel : ModelBase
{
	// Token: 0x06018107 RID: 98567 RVA: 0x0061E8F4 File Offset: 0x0061CAF4
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
			tsUiNavigationPlatformChangeListener.ChangeAlpha();
		}
	}

	// Token: 0x06018108 RID: 98568 RVA: 0x0061EA34 File Offset: 0x0061CC34
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

	// Token: 0x06018109 RID: 98569 RVA: 0x0061EBCC File Offset: 0x0061CDCC
	protected override bool OnClear()
	{
		this.ClearCursor();
		UiNavigationGlobalData.ClearBlockListener();
		return true;
	}

	// Token: 0x0601810A RID: 98570 RVA: 0x0061EBDA File Offset: 0x0061CDDA
	[NullableContext(2)]
	public void SetCursorFollowItem(TsUiNavigationBehaviorListener listener)
	{
		this.Cursor.SetFollowItem(listener);
	}

	// Token: 0x0601810B RID: 98571 RVA: 0x0061EBE8 File Offset: 0x0061CDE8
	public void SetIsUseMouse(bool value)
	{
		this.Cursor.SetIsUseMouse(value);
	}

	// Token: 0x0601810C RID: 98572 RVA: 0x0061EBF6 File Offset: 0x0061CDF6
	public void MarkMoveInstantly()
	{
		this.Cursor.IsMoveInstantly = true;
	}

	// Token: 0x0601810D RID: 98573 RVA: 0x0061EC04 File Offset: 0x0061CE04
	public void SetCursorActiveDelayTime(float time)
	{
		this.Cursor.SetCursorActiveDelayTime(time);
	}

	// Token: 0x0601810E RID: 98574 RVA: 0x0061EC12 File Offset: 0x0061CE12
	public void TrySetCursorActive(bool value)
	{
		this.Cursor.TrySetUseItemUiActive(value);
	}

	// Token: 0x0601810F RID: 98575 RVA: 0x0061EC20 File Offset: 0x0061CE20
	public void RefreshCursorActive()
	{
		this.Cursor.RefreshCursorActive();
	}

	// Token: 0x06018110 RID: 98576 RVA: 0x0061EC2D File Offset: 0x0061CE2D
	public void RepeatMove()
	{
		this.Cursor.RepeatMove();
	}

	// Token: 0x06018111 RID: 98577 RVA: 0x0061EC3C File Offset: 0x0061CE3C
	public void ClearCursor()
	{
		Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "清理光标", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.Cursor.Clear();
	}

	// Token: 0x06018112 RID: 98578 RVA: 0x0061EC73 File Offset: 0x0061CE73
	protected override bool OnLeaveLevel()
	{
		this.ClearCursor();
		return true;
	}

	// Token: 0x06018113 RID: 98579 RVA: 0x0061EC7C File Offset: 0x0061CE7C
	public void Tick(float delta)
	{
		this.Cursor.Tick(delta);
	}

	// Token: 0x06018114 RID: 98580 RVA: 0x0061EC8A File Offset: 0x0061CE8A
	public void AddActionHotKeyComponent(string actionName, HashSet<HotKeyComponent> hotKeyComponentSet)
	{
		this.ActionNameHotKeyComponentMap[actionName] = hotKeyComponentSet;
	}

	// Token: 0x06018115 RID: 98581 RVA: 0x0061EC99 File Offset: 0x0061CE99
	public HashSet<HotKeyComponent> GetActionHotKeyComponentSet(string actionName)
	{
		return this.ActionNameHotKeyComponentMap[actionName];
	}

	// Token: 0x06018116 RID: 98582 RVA: 0x0061ECA8 File Offset: 0x0061CEA8
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

	// Token: 0x06018117 RID: 98583 RVA: 0x0061ECD4 File Offset: 0x0061CED4
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
					return hashSet2.ToArray<string>();
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

	// Token: 0x06018118 RID: 98584 RVA: 0x0061EDF4 File Offset: 0x0061CFF4
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

	// Token: 0x06018119 RID: 98585 RVA: 0x0061EE54 File Offset: 0x0061D054
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

	// Token: 0x0601811A RID: 98586 RVA: 0x0061EECC File Offset: 0x0061D0CC
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

	// Token: 0x0601811B RID: 98587 RVA: 0x0061EEFC File Offset: 0x0061D0FC
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

	// Token: 0x0601811C RID: 98588 RVA: 0x0061EF58 File Offset: 0x0061D158
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

	// Token: 0x0601811D RID: 98589 RVA: 0x0061F038 File Offset: 0x0061D238
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

	// Token: 0x0601811E RID: 98590 RVA: 0x0061F120 File Offset: 0x0061D320
	public void AddAxisHotKeyComponent(string axisName, HashSet<HotKeyComponent> hotKeyComponentSet)
	{
		this.AxisNameHotKeyComponentMap[axisName] = hotKeyComponentSet;
	}

	// Token: 0x0601811F RID: 98591 RVA: 0x0061F12F File Offset: 0x0061D32F
	public HashSet<HotKeyComponent> GetAxisHotKeyComponentSet(string axisName)
	{
		return this.AxisNameHotKeyComponentMap[axisName];
	}

	// Token: 0x06018120 RID: 98592 RVA: 0x0061F140 File Offset: 0x0061D340
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

	// Token: 0x06018121 RID: 98593 RVA: 0x0061F16C File Offset: 0x0061D36C
	public void AddPlatformListener(TsUiNavigationPlatformChangeListener listener)
	{
		this.PlatformListenerSet.Add(listener);
	}

	// Token: 0x06018122 RID: 98594 RVA: 0x0061F17B File Offset: 0x0061D37B
	public void RemovePlatformListener(TsUiNavigationPlatformChangeListener listener)
	{
		this.PlatformListenerSet.Remove(listener);
	}

	// Token: 0x17002073 RID: 8307
	// (get) Token: 0x06018123 RID: 98595 RVA: 0x0061F18A File Offset: 0x0061D38A
	[Nullable(2)]
	public TsUiNavigationBehaviorListener GuideFocusListener
	{
		[NullableContext(2)]
		get
		{
			return this.GuideFocusListenerInternal;
		}
	}

	// Token: 0x06018124 RID: 98596 RVA: 0x0061F192 File Offset: 0x0061D392
	public void SetGuideFocusListener(TsUiNavigationBehaviorListener listener)
	{
		this.GuideFocusListenerInternal = listener;
	}

	// Token: 0x06018125 RID: 98597 RVA: 0x0061F19B File Offset: 0x0061D39B
	public void ResetGuideFocusListener()
	{
		this.GuideFocusListenerInternal = null;
	}

	// Token: 0x17002074 RID: 8308
	// (get) Token: 0x06018126 RID: 98598 RVA: 0x0061F1A4 File Offset: 0x0061D3A4
	public static UiNavigationModel Instance
	{
		get
		{
			return UiNavigationModel._Instance;
		}
	}

	// Token: 0x06018127 RID: 98599 RVA: 0x0061F1AB File Offset: 0x0061D3AB
	public static UiNavigationModel GetOrCreateInstance()
	{
		if (UiNavigationModel._Instance == null)
		{
			UiNavigationModel.CreateInstance();
		}
		return UiNavigationModel._Instance;
	}

	// Token: 0x06018128 RID: 98600 RVA: 0x0061F1BF File Offset: 0x0061D3BF
	public static bool CreateInstance()
	{
		if (UiNavigationModel._Instance != null)
		{
			return true;
		}
		UiNavigationModel._Instance = new UiNavigationModel();
		return true;
	}

	// Token: 0x06018129 RID: 98601 RVA: 0x0061F1D5 File Offset: 0x0061D3D5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601812A RID: 98602 RVA: 0x0061F1D7 File Offset: 0x0061D3D7
	public static void ResetStaticDefaultValue()
	{
		UiNavigationModel._Instance = null;
	}

	// Token: 0x0601812B RID: 98603 RVA: 0x0061F1DF File Offset: 0x0061D3DF
	static UiNavigationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationModel.CreateStaticDefaultValue), new Action(UiNavigationModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B30D RID: 45837
	private readonly Cursor Cursor = new Cursor();

	// Token: 0x0400B30E RID: 45838
	public bool IsOpenLog;

	// Token: 0x0400B30F RID: 45839
	private readonly Dictionary<string, HashSet<HotKeyComponent>> ActionNameHotKeyComponentMap = new Dictionary<string, HashSet<HotKeyComponent>>();

	// Token: 0x0400B310 RID: 45840
	private readonly Dictionary<string, HashSet<HotKeyComponent>> AxisNameHotKeyComponentMap = new Dictionary<string, HashSet<HotKeyComponent>>();

	// Token: 0x0400B311 RID: 45841
	private readonly HashSet<TsUiNavigationPlatformChangeListener> PlatformListenerSet = new HashSet<TsUiNavigationPlatformChangeListener>();

	// Token: 0x0400B312 RID: 45842
	[Nullable(2)]
	private TsUiNavigationBehaviorListener GuideFocusListenerInternal;

	// Token: 0x0400B313 RID: 45843
	[Nullable(2)]
	private static UiNavigationModel _Instance;
}
