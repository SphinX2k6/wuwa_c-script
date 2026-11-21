using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

// Token: 0x0200289B RID: 10395
[NullableContext(2)]
[Nullable(0)]
public class RedDotBase
{
	// Token: 0x17002B3A RID: 11066
	// (get) Token: 0x0601A5BF RID: 107967 RVA: 0x008278FD File Offset: 0x00825AFD
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Tree<RedDotBase> Tree
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return RedDotModel.Instance.GetRedDotTree(this.Name.Value);
		}
	}

	// Token: 0x0601A5C0 RID: 107968 RVA: 0x00827914 File Offset: 0x00825B14
	public void SetRedDotActiveByGm(bool bShow)
	{
		this.SetRedDotActive(bShow);
	}

	// Token: 0x0601A5C1 RID: 107969 RVA: 0x00827920 File Offset: 0x00825B20
	private void SetSelfAndChildActive(bool value)
	{
		this.IsActive = value;
		if (!value)
		{
			this.RemoveCheckEvent();
			using (Dictionary<int, RedDotData>.ValueCollection.Enumerator enumerator = this.DataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					RedDotData redDotData = enumerator.Current;
					redDotData.SetUIItemActive(false);
				}
				goto IL_4F;
			}
		}
		this.AddCheckEvent();
		IL_4F:
		if (this.Tree != null)
		{
			foreach (RedDotBase redDotBase in this.Tree.ChildMap.Keys)
			{
				redDotBase.SetSelfAndChildActive(value);
			}
		}
	}

	// Token: 0x0601A5C2 RID: 107970 RVA: 0x008279E0 File Offset: 0x00825BE0
	private bool CheckParentState(bool newState)
	{
		Tree<RedDotBase> tree = this.Tree;
		return ((tree != null) ? tree.Parent : null) == null || (this.Tree.Parent.Element.IsActive || !newState);
	}

	// Token: 0x0601A5C3 RID: 107971 RVA: 0x00827A18 File Offset: 0x00825C18
	private void SetRedDotActive(bool value)
	{
		if (value == this.IsActive)
		{
			return;
		}
		if (!this.CheckParentState(value))
		{
			return;
		}
		this.SetSelfAndChildActive(value);
		if (value)
		{
			this.CalculateStateCount();
		}
		Tree<RedDotBase> tree = this.Tree;
		if (((tree != null) ? tree.Parent : null) != null)
		{
			this.Tree.Parent.Element.OnChildActiveChange(this, value);
		}
	}

	// Token: 0x0601A5C4 RID: 107972 RVA: 0x00827A74 File Offset: 0x00825C74
	public void Init(ERedDotName name)
	{
		this.Name = new ERedDotName?(name);
		this.AddCheckEvent();
		this.AddActiveEvents();
		this.AddDisActiveEvents();
	}

	// Token: 0x0601A5C5 RID: 107973 RVA: 0x00827A94 File Offset: 0x00825C94
	protected void OnActiveEvent()
	{
		this.SetRedDotActive(true);
	}

	// Token: 0x0601A5C6 RID: 107974 RVA: 0x00827A9D File Offset: 0x00825C9D
	protected void OnDisActiveEvent()
	{
		this.SetRedDotActive(false);
	}

	// Token: 0x0601A5C7 RID: 107975 RVA: 0x00827AA8 File Offset: 0x00825CA8
	protected void EventCheck()
	{
		int uId = 0;
		if (!this.IsMultiple())
		{
			this.TryGenerateData(uId);
			this.PushToEventQueue(uId);
			return;
		}
		foreach (int uId2 in this.DataMap.Keys)
		{
			this.PushToEventQueue(uId2);
		}
	}

	// Token: 0x0601A5C8 RID: 107976 RVA: 0x00827B1C File Offset: 0x00825D1C
	protected void EventCheckWithUid(int uId)
	{
		if (this.IsAllEventParamAsUId())
		{
			this.TryGenerateData(uId);
			this.PushToEventQueue(uId);
			return;
		}
		this.EventCheck();
	}

	// Token: 0x0601A5C9 RID: 107977 RVA: 0x00827B3C File Offset: 0x00825D3C
	private void PushToEventQueue(int uId = 0)
	{
		RedDotSystem.Instance.PushToEventQueue(new TRedDotCheckEvent(this.CheckSelf), uId, this.Name.Value);
	}

	// Token: 0x0601A5CA RID: 107978 RVA: 0x00827B60 File Offset: 0x00825D60
	private unsafe void CheckSelf(int uId = 0)
	{
		bool flag = this.OnCheck(uId);
		RedDotData data = this.GetData(uId);
		if (data == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RedDot;
			ELogAuthor author = ELogAuthor.TL;
			string message = "Check失败，红点数据未绑定到事件上！";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", this.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uId", uId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (data.TryChangeState(flag))
		{
			Action<bool, int> stateChangeCallback = this.StateChangeCallback;
			if (stateChangeCallback != null)
			{
				stateChangeCallback(data.State, uId);
			}
			this.NotifyParentStateChange(flag, uId);
		}
	}

	// Token: 0x0601A5CB RID: 107979 RVA: 0x00827C0C File Offset: 0x00825E0C
	[NullableContext(1)]
	private void OnChildActiveChange(RedDotBase child, bool newActiveState)
	{
		foreach (KeyValuePair<int, RedDotData> keyValuePair in child.DataMap)
		{
			int key = keyValuePair.Key;
			RedDotData value = keyValuePair.Value;
			RedDotData redDotData;
			if (this.DataMap.TryGetValue(key, out redDotData))
			{
				if (newActiveState)
				{
					redDotData.StateCount += value.StateCount;
				}
				else
				{
					redDotData.StateCount -= value.StateCount;
				}
				redDotData.UpdateRedDotUIActive();
			}
		}
		Tree<RedDotBase> tree = this.Tree;
		if (((tree != null) ? tree.Parent : null) != null)
		{
			this.Tree.Parent.Element.OnChildActiveChange(child, newActiveState);
		}
	}

	// Token: 0x0601A5CC RID: 107980 RVA: 0x00827CD8 File Offset: 0x00825ED8
	private void CalculateStateCount()
	{
		foreach (KeyValuePair<int, RedDotData> keyValuePair in this.DataMap)
		{
			int key = keyValuePair.Key;
			RedDotData value = keyValuePair.Value;
			bool flag = this.OnCheck(key);
			value.StateCount = ((flag > false) ? 1 : 0);
			if (flag)
			{
				value.SetUIItemActive(true);
				this.NotifyParentStateChange(flag, key);
			}
		}
		if (this.Tree != null)
		{
			foreach (RedDotBase redDotBase in this.Tree.ChildMap.Keys)
			{
				redDotBase.CalculateStateCount();
			}
		}
	}

	// Token: 0x0601A5CD RID: 107981 RVA: 0x00827DB0 File Offset: 0x00825FB0
	private void NotifyParentStateChange(bool result, int rawUniqueId = 0)
	{
		Tree<RedDotBase> tree = this.Tree;
		RedDotBase redDotBase;
		if (tree == null)
		{
			redDotBase = null;
		}
		else
		{
			Tree<RedDotBase> parent = tree.Parent;
			redDotBase = ((parent != null) ? parent.Element : null);
		}
		RedDotBase redDotBase2 = redDotBase;
		if (redDotBase2 == null)
		{
			return;
		}
		int num;
		if (!redDotBase2.IsMultiple())
		{
			num = 0;
		}
		else
		{
			int parentCheckUid = this.GetParentCheckUid(rawUniqueId);
			num = ((parentCheckUid >= 0) ? parentCheckUid : rawUniqueId);
		}
		redDotBase2.TryGenerateData(num);
		RedDotData data = redDotBase2.GetData(num);
		if (data != null && data.OnChildrenStateChange(result))
		{
			Action<bool, int> stateChangeCallback = redDotBase2.StateChangeCallback;
			if (stateChangeCallback != null)
			{
				stateChangeCallback(data.State, num);
			}
			redDotBase2.NotifyParentStateChange(result, num);
		}
	}

	// Token: 0x0601A5CE RID: 107982 RVA: 0x00827E3C File Offset: 0x0082603C
	private RedDotData GetData(int uId)
	{
		RedDotData result;
		this.DataMap.TryGetValue(uId, out result);
		return result;
	}

	// Token: 0x0601A5CF RID: 107983 RVA: 0x00827E5C File Offset: 0x0082605C
	[NullableContext(1)]
	private RedDotData TryGenerateData(int uId = 0)
	{
		RedDotData redDotData;
		if (!this.DataMap.TryGetValue(uId, out redDotData))
		{
			redDotData = new RedDotData();
			this.DataMap[uId] = redDotData;
			this.CheckSelf(uId);
		}
		return redDotData;
	}

	// Token: 0x0601A5D0 RID: 107984 RVA: 0x00827E94 File Offset: 0x00826094
	public void BindUi(int uId = 0, UUIItem uiItem = null, Action<bool, int> stateChangeCallback = null)
	{
		this.TryGenerateData(uId);
		RedDotData data = this.GetData(uId);
		if (data != null)
		{
			data.SetUiItem(uiItem);
		}
		this.StateChangeCallback = stateChangeCallback;
		this.UpdateState(uId);
	}

	// Token: 0x0601A5D1 RID: 107985 RVA: 0x00827EBF File Offset: 0x008260BF
	public void UnBindGivenUi(int uId = 0, UUIItem uiItem = null)
	{
		RedDotData data = this.GetData(uId);
		if (data == null)
		{
			return;
		}
		data.DeleteUiItem(uiItem);
	}

	// Token: 0x0601A5D2 RID: 107986 RVA: 0x00827ED4 File Offset: 0x008260D4
	public void UnBindUi()
	{
		foreach (RedDotData redDotData in this.DataMap.Values)
		{
			redDotData.ClearUiItem();
		}
		this.StateChangeCallback = null;
	}

	// Token: 0x0601A5D3 RID: 107987 RVA: 0x00827F30 File Offset: 0x00826130
	public void UnBindGivenUiAndDeleteData(int uId = 0, UUIItem uiItem = null)
	{
		RedDotData data = this.GetData(uId);
		if (data == null)
		{
			return;
		}
		data.DeleteUiItem(uiItem);
		if (data.GetUiItemSet().Count > 0)
		{
			return;
		}
		RedDotSystem.Instance.PopRedDotEventData(uId, this.Name.Value);
		this.DataMap.Remove(uId);
	}

	// Token: 0x0601A5D4 RID: 107988 RVA: 0x00827F84 File Offset: 0x00826184
	public void UnBindUiAndClearData()
	{
		this.UnBindUi();
		foreach (int id in this.DataMap.Keys)
		{
			RedDotSystem.Instance.PopRedDotEventData(id, this.Name.Value);
		}
		this.DataMap.Clear();
	}

	// Token: 0x0601A5D5 RID: 107989 RVA: 0x00827FFC File Offset: 0x008261FC
	public void UpdateState(int uId = 0)
	{
		RedDotData data = this.GetData(uId);
		if (data != null)
		{
			data.UpdateRedDotUIActive();
		}
		Action<bool, int> stateChangeCallback = this.StateChangeCallback;
		if (stateChangeCallback == null)
		{
			return;
		}
		stateChangeCallback(data != null && data.State, uId);
	}

	// Token: 0x0601A5D6 RID: 107990 RVA: 0x00828038 File Offset: 0x00826238
	public bool IsRedDotActive()
	{
		using (Dictionary<int, RedDotData>.ValueCollection.Enumerator enumerator = this.DataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601A5D7 RID: 107991 RVA: 0x00828098 File Offset: 0x00826298
	public ERedDotName? GetParentName()
	{
		return this.OnGetParentName();
	}

	// Token: 0x0601A5D8 RID: 107992 RVA: 0x008280A0 File Offset: 0x008262A0
	protected virtual void AddCheckEvent()
	{
	}

	// Token: 0x0601A5D9 RID: 107993 RVA: 0x008280A2 File Offset: 0x008262A2
	protected virtual void RemoveCheckEvent()
	{
	}

	// Token: 0x0601A5DA RID: 107994 RVA: 0x008280A4 File Offset: 0x008262A4
	protected virtual void AddActiveEvents()
	{
	}

	// Token: 0x0601A5DB RID: 107995 RVA: 0x008280A6 File Offset: 0x008262A6
	protected virtual void AddDisActiveEvents()
	{
	}

	// Token: 0x0601A5DC RID: 107996 RVA: 0x008280A8 File Offset: 0x008262A8
	protected virtual bool OnCheck(int uId = 0)
	{
		return false;
	}

	// Token: 0x0601A5DD RID: 107997 RVA: 0x008280AB File Offset: 0x008262AB
	protected virtual bool IsMultiple()
	{
		return false;
	}

	// Token: 0x0601A5DE RID: 107998 RVA: 0x008280B0 File Offset: 0x008262B0
	protected virtual ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601A5DF RID: 107999 RVA: 0x008280C6 File Offset: 0x008262C6
	protected virtual int GetParentCheckUid(int uId)
	{
		return uId;
	}

	// Token: 0x0601A5E0 RID: 108000 RVA: 0x008280C9 File Offset: 0x008262C9
	protected virtual bool IsAllEventParamAsUId()
	{
		return true;
	}

	// Token: 0x0601A5E1 RID: 108001 RVA: 0x008280CC File Offset: 0x008262CC
	[NullableContext(1)]
	public string ToRedDotString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		StringBuilder stringBuilder3 = new StringBuilder();
		StringBuilder stringBuilder4;
		StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler;
		foreach (KeyValuePair<int, RedDotData> keyValuePair in this.DataMap)
		{
			int key = keyValuePair.Key;
			RedDotData value = keyValuePair.Value;
			stringBuilder3.Clear();
			foreach (UUIItem uuiitem in value.GetUiItemSet())
			{
				stringBuilder4 = stringBuilder3;
				StringBuilder stringBuilder5 = stringBuilder4;
				appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder4);
				appendInterpolatedStringHandler.AppendFormatted(uuiitem.GetDisplayName());
				appendInterpolatedStringHandler.AppendLiteral(", ");
				stringBuilder5.Append(ref appendInterpolatedStringHandler);
			}
			stringBuilder4 = stringBuilder2;
			StringBuilder stringBuilder6 = stringBuilder4;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(30, 3, stringBuilder4);
			appendInterpolatedStringHandler.AppendLiteral("{uid:");
			appendInterpolatedStringHandler.AppendFormatted<int>(key);
			appendInterpolatedStringHandler.AppendLiteral(", stateCount:");
			appendInterpolatedStringHandler.AppendFormatted<int>(value.StateCount);
			appendInterpolatedStringHandler.AppendLiteral(" uiItem:[");
			appendInterpolatedStringHandler.AppendFormatted(stringBuilder3.ToString());
			appendInterpolatedStringHandler.AppendLiteral("] }");
			stringBuilder6.Append(ref appendInterpolatedStringHandler);
		}
		StringBuilder stringBuilder7 = new StringBuilder();
		if (this.Tree != null)
		{
			foreach (RedDotBase redDotBase in this.Tree.ChildMap.Keys)
			{
				stringBuilder4 = stringBuilder7;
				StringBuilder stringBuilder8 = stringBuilder4;
				appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder4);
				appendInterpolatedStringHandler.AppendFormatted<ERedDotName?>(redDotBase.Name);
				appendInterpolatedStringHandler.AppendLiteral(", ");
				stringBuilder8.Append(ref appendInterpolatedStringHandler);
			}
		}
		stringBuilder4 = stringBuilder;
		StringBuilder stringBuilder9 = stringBuilder4;
		appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(25, 4, stringBuilder4);
		appendInterpolatedStringHandler.AppendLiteral("[红点:");
		appendInterpolatedStringHandler.AppendFormatted<ERedDotName?>(this.Name);
		appendInterpolatedStringHandler.AppendLiteral(" 父红点:");
		Tree<RedDotBase> tree = this.Tree;
		ERedDotName? value2;
		if (tree == null)
		{
			value2 = null;
		}
		else
		{
			Tree<RedDotBase> parent = tree.Parent;
			value2 = ((parent != null) ? parent.Element.Name : null);
		}
		appendInterpolatedStringHandler.AppendFormatted<ERedDotName?>(value2);
		appendInterpolatedStringHandler.AppendLiteral(" 子红点:");
		appendInterpolatedStringHandler.AppendFormatted(stringBuilder7.ToString());
		appendInterpolatedStringHandler.AppendLiteral("  数据:{ ");
		appendInterpolatedStringHandler.AppendFormatted(stringBuilder2.ToString());
		appendInterpolatedStringHandler.AppendLiteral(" }]\n");
		stringBuilder9.Append(ref appendInterpolatedStringHandler);
		return stringBuilder.ToString();
	}

	// Token: 0x0601A5E2 RID: 108002 RVA: 0x00828394 File Offset: 0x00826594
	public unsafe void PrintStateDebugString()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RedDot;
		ELogAuthor author = ELogAuthor.CX;
		string message = "=======子红点状态打印开始=======：";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (KeyValuePair<int, RedDotData> keyValuePair in this.DataMap)
		{
			int key = keyValuePair.Key;
			RedDotData value = keyValuePair.Value;
			HashSet<UUIItem> uiItemSet = value.GetUiItemSet();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RedDot;
			ELogAuthor author2 = ELogAuthor.CX;
			string message2 = "红点状态数据：";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Uid", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("State", value.State);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateCount", value.StateCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("UiItemSize", uiItemSet.Count);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			foreach (UUIItem uuiitem in uiItemSet)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RedDot;
				ELogAuthor author3 = ELogAuthor.CX;
				string message3 = "受控制的UI对象";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("UiItem", uuiitem.GetDisplayName());
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.RedDot;
		ELogAuthor author4 = ELogAuthor.CX;
		string message4 = "=======子红点状态打印结束=======：";
		ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Name", this.Name);
		instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
	}

	// Token: 0x0601A5E3 RID: 108003 RVA: 0x0082858C File Offset: 0x0082678C
	public void UpdateAllRedDotData()
	{
		foreach (int uId in this.DataMap.Keys)
		{
			this.PushToEventQueue(uId);
		}
	}

	// Token: 0x0400E768 RID: 59240
	public ERedDotName? Name;

	// Token: 0x0400E769 RID: 59241
	private bool IsActive = true;

	// Token: 0x0400E76A RID: 59242
	[Nullable(1)]
	private readonly Dictionary<int, RedDotData> DataMap = new Dictionary<int, RedDotData>();

	// Token: 0x0400E76B RID: 59243
	private Action<bool, int> StateChangeCallback;

	// Token: 0x0400E76C RID: 59244
	private Stat StatsObject;

	// Token: 0x0400E76D RID: 59245
	private Action EventCheckAction0;
}
