using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

// Token: 0x02003329 RID: 13097
[NullableContext(2)]
[Nullable(0)]
public class RedDotBase
{
	// Token: 0x1700279E RID: 10142
	// (get) Token: 0x0601C8C7 RID: 116935 RVA: 0x00801359 File Offset: 0x007FF559
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

	// Token: 0x0601C8C8 RID: 116936 RVA: 0x00801370 File Offset: 0x007FF570
	public void SetRedDotActiveByGm(bool bShow)
	{
		this.SetRedDotActive(bShow);
	}

	// Token: 0x0601C8C9 RID: 116937 RVA: 0x0080137C File Offset: 0x007FF57C
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

	// Token: 0x0601C8CA RID: 116938 RVA: 0x0080143C File Offset: 0x007FF63C
	private bool CheckParentState(bool newState)
	{
		Tree<RedDotBase> tree = this.Tree;
		return ((tree != null) ? tree.Parent : null) == null || (this.Tree.Parent.Element.IsActive || !newState);
	}

	// Token: 0x0601C8CB RID: 116939 RVA: 0x00801474 File Offset: 0x007FF674
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

	// Token: 0x0601C8CC RID: 116940 RVA: 0x008014D0 File Offset: 0x007FF6D0
	public void Init(ERedDotName name)
	{
		this.Name = new ERedDotName?(name);
		this.AddCheckEvent();
		this.AddActiveEvents();
		this.AddDisActiveEvents();
	}

	// Token: 0x0601C8CD RID: 116941 RVA: 0x008014F0 File Offset: 0x007FF6F0
	protected void OnActiveEvent()
	{
		this.SetRedDotActive(true);
	}

	// Token: 0x0601C8CE RID: 116942 RVA: 0x008014F9 File Offset: 0x007FF6F9
	protected void OnDisActiveEvent()
	{
		this.SetRedDotActive(false);
	}

	// Token: 0x0601C8CF RID: 116943 RVA: 0x00801504 File Offset: 0x007FF704
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

	// Token: 0x0601C8D0 RID: 116944 RVA: 0x00801578 File Offset: 0x007FF778
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

	// Token: 0x0601C8D1 RID: 116945 RVA: 0x00801598 File Offset: 0x007FF798
	private void PushToEventQueue(int uId = 0)
	{
		RedDotSystem.Instance.PushToEventQueue(new TRedDotCheckEvent(this.CheckSelf), uId, this.Name.Value);
	}

	// Token: 0x0601C8D2 RID: 116946 RVA: 0x008015BC File Offset: 0x007FF7BC
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

	// Token: 0x0601C8D3 RID: 116947 RVA: 0x00801668 File Offset: 0x007FF868
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

	// Token: 0x0601C8D4 RID: 116948 RVA: 0x00801734 File Offset: 0x007FF934
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

	// Token: 0x0601C8D5 RID: 116949 RVA: 0x0080180C File Offset: 0x007FFA0C
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

	// Token: 0x0601C8D6 RID: 116950 RVA: 0x00801898 File Offset: 0x007FFA98
	private RedDotData GetData(int uId)
	{
		RedDotData result;
		this.DataMap.TryGetValue(uId, out result);
		return result;
	}

	// Token: 0x0601C8D7 RID: 116951 RVA: 0x008018B8 File Offset: 0x007FFAB8
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

	// Token: 0x0601C8D8 RID: 116952 RVA: 0x008018F0 File Offset: 0x007FFAF0
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

	// Token: 0x0601C8D9 RID: 116953 RVA: 0x0080191B File Offset: 0x007FFB1B
	public void UnBindGivenUi(int uId = 0, UUIItem uiItem = null)
	{
		RedDotData data = this.GetData(uId);
		if (data == null)
		{
			return;
		}
		data.DeleteUiItem(uiItem);
	}

	// Token: 0x0601C8DA RID: 116954 RVA: 0x00801930 File Offset: 0x007FFB30
	public void UnBindUi()
	{
		foreach (RedDotData redDotData in this.DataMap.Values)
		{
			redDotData.ClearUiItem();
		}
		this.StateChangeCallback = null;
	}

	// Token: 0x0601C8DB RID: 116955 RVA: 0x0080198C File Offset: 0x007FFB8C
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

	// Token: 0x0601C8DC RID: 116956 RVA: 0x008019E0 File Offset: 0x007FFBE0
	public void UnBindUiAndClearData()
	{
		this.UnBindUi();
		foreach (int id in this.DataMap.Keys)
		{
			RedDotSystem.Instance.PopRedDotEventData(id, this.Name.Value);
		}
		this.DataMap.Clear();
	}

	// Token: 0x0601C8DD RID: 116957 RVA: 0x00801A58 File Offset: 0x007FFC58
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

	// Token: 0x0601C8DE RID: 116958 RVA: 0x00801A94 File Offset: 0x007FFC94
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

	// Token: 0x0601C8DF RID: 116959 RVA: 0x00801AF4 File Offset: 0x007FFCF4
	public ERedDotName? GetParentName()
	{
		return this.OnGetParentName();
	}

	// Token: 0x0601C8E0 RID: 116960 RVA: 0x00801AFC File Offset: 0x007FFCFC
	protected virtual void AddCheckEvent()
	{
	}

	// Token: 0x0601C8E1 RID: 116961 RVA: 0x00801AFE File Offset: 0x007FFCFE
	protected virtual void RemoveCheckEvent()
	{
	}

	// Token: 0x0601C8E2 RID: 116962 RVA: 0x00801B00 File Offset: 0x007FFD00
	protected virtual void AddActiveEvents()
	{
	}

	// Token: 0x0601C8E3 RID: 116963 RVA: 0x00801B02 File Offset: 0x007FFD02
	protected virtual void AddDisActiveEvents()
	{
	}

	// Token: 0x0601C8E4 RID: 116964 RVA: 0x00801B04 File Offset: 0x007FFD04
	protected virtual bool OnCheck(int uId = 0)
	{
		return false;
	}

	// Token: 0x0601C8E5 RID: 116965 RVA: 0x00801B07 File Offset: 0x007FFD07
	protected virtual bool IsMultiple()
	{
		return false;
	}

	// Token: 0x0601C8E6 RID: 116966 RVA: 0x00801B0C File Offset: 0x007FFD0C
	protected virtual ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601C8E7 RID: 116967 RVA: 0x00801B22 File Offset: 0x007FFD22
	protected virtual int GetParentCheckUid(int uId)
	{
		return uId;
	}

	// Token: 0x0601C8E8 RID: 116968 RVA: 0x00801B25 File Offset: 0x007FFD25
	protected virtual bool IsAllEventParamAsUId()
	{
		return true;
	}

	// Token: 0x0601C8E9 RID: 116969 RVA: 0x00801B28 File Offset: 0x007FFD28
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

	// Token: 0x0601C8EA RID: 116970 RVA: 0x00801DF0 File Offset: 0x007FFFF0
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

	// Token: 0x0601C8EB RID: 116971 RVA: 0x00801FE8 File Offset: 0x008001E8
	public void UpdateAllRedDotData()
	{
		foreach (int uId in this.DataMap.Keys)
		{
			this.PushToEventQueue(uId);
		}
	}

	// Token: 0x0400E2B8 RID: 58040
	public ERedDotName? Name;

	// Token: 0x0400E2B9 RID: 58041
	private bool IsActive = true;

	// Token: 0x0400E2BA RID: 58042
	[Nullable(1)]
	private readonly Dictionary<int, RedDotData> DataMap = new Dictionary<int, RedDotData>();

	// Token: 0x0400E2BB RID: 58043
	private Action<bool, int> StateChangeCallback;

	// Token: 0x0400E2BC RID: 58044
	private Stat StatsObject;

	// Token: 0x0400E2BD RID: 58045
	private Action EventCheckAction0;
}
