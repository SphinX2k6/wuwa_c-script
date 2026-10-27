using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CDF RID: 11487
[NullableContext(1)]
[Nullable(0)]
public class MultiTemplateScrollView
{
	// Token: 0x060181BD RID: 98749 RVA: 0x00621978 File Offset: 0x0061FB78
	public MultiTemplateScrollView(UUIMultiTemplateScrollViewComponent scrollView)
	{
		this.ScrollView = scrollView;
		this.ScrollView.OnItemCreate.Bind(new Action<int, AUIBaseActor>(this.OnItemCreate));
		this.ScrollView.OnItemRefresh.Bind(new Action<int, AUIBaseActor>(this.OnItemRefresh));
		this.ScrollView.OnItemClear.Bind(new Action<int, AUIBaseActor>(this.OnItemClear));
		this.ScrollView.OnCheckItemNavigable.Bind(new Func<int, bool>(this.OnCheckItemNavigable));
		TWeakObjectPtr<AUIBaseActor> content = this.ScrollView.Content;
		if (content.IsValid(false, false))
		{
			TArray<UActorComponent> tarray = content.Get().K2_GetComponentsByClass(UUIInturnAnimController.StaticClass());
			if (tarray != null && tarray.Num() > 0)
			{
				this.InturnAnimController = (tarray.Get(0) as UUIInturnAnimController);
			}
		}
	}

	// Token: 0x060181BE RID: 98750 RVA: 0x00621A64 File Offset: 0x0061FC64
	public void RefreshByData(MultiTemplateScrollViewRefreshContext context)
	{
		List<IMultiTemplateGridData> list = context.DataList.ToList<IMultiTemplateGridData>();
		this.DataList = list;
		TArray<int> tarray = new TArray<int>();
		foreach (IMultiTemplateGridData multiTemplateGridData in list)
		{
			tarray.Add(multiTemplateGridData.GetTemplateIndex());
		}
		this.ScrollView.RefreshByData(tarray, context.KeepContentPosition, context.ScrollToGridIndex);
		if (context.PlayGridAnim)
		{
			this.PlayGridAnim(context.GridAnimName);
		}
	}

	// Token: 0x060181BF RID: 98751 RVA: 0x00621AFC File Offset: 0x0061FCFC
	[NullableContext(2)]
	private void OnItemCreate(int gridIndex, AUIBaseActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateScrollView;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateScrollView] [OnItemCreate] 无效的Actor";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (gridIndex < 0 || gridIndex >= this.DataList.Count)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[MultiTemplateScrollView] [OnItemCreate] 无效的gridIndex";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		UUIItem uiitem = actor.GetUIItem();
		if (uiitem == null || !uiitem.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author3 = ELogAuthor.LZK;
			string message3 = "[MultiTemplateScrollView] [OnItemCreate] 无效的item";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		if (this.ProxyItems.ContainsKey(uiitem))
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author4 = ELogAuthor.LZK;
			string message4 = "[MultiTemplateScrollView] [OnItemCreate] 重复触发Proxy的创建";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return;
		}
		ISyncGridProxy syncGridProxy = this.DataList[gridIndex].CreateProxy();
		syncGridProxy.GridIndex = gridIndex;
		syncGridProxy.CreateThenShowByActor(actor);
		this.ProxyItems[uiitem] = syncGridProxy;
	}

	// Token: 0x060181C0 RID: 98752 RVA: 0x00621C34 File Offset: 0x0061FE34
	[NullableContext(2)]
	private void OnItemRefresh(int gridIndex, AUIBaseActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateScrollView;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateScrollView] [OnItemRefresh] 无效的Actor";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUIItem uiitem = actor.GetUIItem();
		if (uiitem == null || !uiitem.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[MultiTemplateScrollView] [OnItemRefresh] 无效的item";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		ISyncGridProxy syncGridProxy;
		if (!this.ProxyItems.TryGetValue(uiitem, out syncGridProxy))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author3 = ELogAuthor.LZK;
			string message3 = "[MultiTemplateScrollView] [OnItemRefresh] proxy未创建";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		IMultiTemplateGridData multiTemplateGridData = this.DataList[gridIndex];
		syncGridProxy.GridIndex = gridIndex;
		syncGridProxy.Refresh(multiTemplateGridData.Data);
	}

	// Token: 0x060181C1 RID: 98753 RVA: 0x00621D20 File Offset: 0x0061FF20
	[NullableContext(2)]
	private void OnItemClear(int gridIndex, AUIBaseActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateScrollView;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateScrollView] [OnItemClear] 无效的Actor";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUIItem uiitem = actor.GetUIItem();
		if (uiitem == null || !uiitem.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[MultiTemplateScrollView] [OnItemClear] 无效的item";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		ISyncGridProxy syncGridProxy;
		if (!this.ProxyItems.TryGetValue(uiitem, out syncGridProxy))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.MultiTemplateScrollView;
			ELogAuthor author3 = ELogAuthor.LZK;
			string message3 = "[MultiTemplateScrollView] [OnItemClear] proxy未创建";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("gridIndex", gridIndex);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		syncGridProxy.GridIndex = gridIndex;
		syncGridProxy.Clear();
	}

	// Token: 0x060181C2 RID: 98754 RVA: 0x00621DF7 File Offset: 0x0061FFF7
	public bool IsGridDisplaying(int gridIndex)
	{
		return this.ScrollView.IsInDisplayRange(gridIndex, true);
	}

	// Token: 0x060181C3 RID: 98755 RVA: 0x00621E06 File Offset: 0x00620006
	private bool OnCheckItemNavigable(int gridIndex)
	{
		return gridIndex < 0 || gridIndex >= this.DataList.Count || this.DataList[gridIndex].IsNavigable();
	}

	// Token: 0x060181C4 RID: 98756 RVA: 0x00621E30 File Offset: 0x00620030
	[NullableContext(2)]
	public ISyncGridProxy GetProxyByGridIndex(int gridIndex)
	{
		UUIItem gridItem = this.ScrollView.GetGridItem(gridIndex);
		if (gridItem == null || !gridItem.IsValid())
		{
			return null;
		}
		ISyncGridProxy result;
		if (this.ProxyItems.TryGetValue(gridItem, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060181C5 RID: 98757 RVA: 0x00621E6C File Offset: 0x0062006C
	public bool RefreshProxyDirectly(int gridIndex)
	{
		ISyncGridProxy proxyByGridIndex = this.GetProxyByGridIndex(gridIndex);
		if (proxyByGridIndex == null)
		{
			return false;
		}
		proxyByGridIndex.Refresh(this.DataList[gridIndex].Data);
		return true;
	}

	// Token: 0x060181C6 RID: 98758 RVA: 0x00621EA0 File Offset: 0x006200A0
	public bool RefreshProxyByData(int gridIndex, IMultiTemplateGridData data)
	{
		ISyncGridProxy proxyByGridIndex = this.GetProxyByGridIndex(gridIndex);
		if (proxyByGridIndex == null)
		{
			return false;
		}
		this.DataList[gridIndex] = data;
		proxyByGridIndex.Refresh(data.Data);
		return true;
	}

	// Token: 0x060181C7 RID: 98759 RVA: 0x00621ED4 File Offset: 0x006200D4
	public void PlayGridAnim(string animName)
	{
		if (this.InturnAnimController != null)
		{
			this.InturnAnimController.Play(animName, -1, true);
		}
	}

	// Token: 0x0400B356 RID: 45910
	protected List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

	// Token: 0x0400B357 RID: 45911
	private readonly Dictionary<UUIItem, ISyncGridProxy> ProxyItems = new Dictionary<UUIItem, ISyncGridProxy>();

	// Token: 0x0400B358 RID: 45912
	[Nullable(2)]
	private readonly UUIInturnAnimController InturnAnimController;

	// Token: 0x0400B359 RID: 45913
	public readonly UUIMultiTemplateScrollViewComponent ScrollView;
}
