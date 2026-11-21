using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002236 RID: 8758
[NullableContext(1)]
[Nullable(0)]
public class MultiTemplateComponent : IGridPreserver
{
	// Token: 0x06015A15 RID: 88597 RVA: 0x00646CA0 File Offset: 0x00644EA0
	public MultiTemplateComponent(UUIItem rootItem, Dictionary<int, UUIItem> templateItems)
	{
		this.RootItem = rootItem;
		this.TemplateItems = templateItems;
		foreach (KeyValuePair<int, UUIItem> keyValuePair in templateItems)
		{
			this.PoolItems[keyValuePair.Key] = new List<UUIItem>();
			keyValuePair.Value.SetUIActive(false);
		}
		AActor owner = rootItem.GetOwner();
		if (owner != null)
		{
			this.AnimControllerComponent = (owner.GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		}
		this.GridsController = new InTurnGridAppearAnimation(this);
		this.GridsController.RegisterAnimController();
	}

	// Token: 0x06015A16 RID: 88598 RVA: 0x00646D94 File Offset: 0x00644F94
	public void RefreshByData(List<IMultiTemplateGridData> dataList, bool playGridAnim = false)
	{
		if (!this.CheckDataListValid(dataList))
		{
			return;
		}
		this.RecycleAllItems();
		this.DataList = new List<IMultiTemplateGridData>(dataList);
		this.AllocateDisplayItems();
		this.RefreshDirectly();
		if (playGridAnim && this.GridsController != null)
		{
			this.GridsController.PlayGridAnim(this.GetDisplayGridNum(), false);
		}
	}

	// Token: 0x06015A17 RID: 88599 RVA: 0x00646DE8 File Offset: 0x00644FE8
	public bool AddItem(IMultiTemplateGridData data)
	{
		UUIItem uuiitem = this.AcquireItem(data);
		if (uuiitem == null)
		{
			return false;
		}
		ISyncGridProxy syncGridProxy = this.EnsureProxy(uuiitem, data);
		uuiitem.SetUIActive(true);
		int count = this.DataList.Count;
		this.DataList.Add(data);
		this.DisplayItems.Add(uuiitem);
		uuiitem.SetHierarchyIndex(count);
		syncGridProxy.GridIndex = count;
		syncGridProxy.Refresh(data.Data);
		return true;
	}

	// Token: 0x06015A18 RID: 88600 RVA: 0x00646E50 File Offset: 0x00645050
	public bool RemoveLastItem()
	{
		if (this.DisplayItems.Count == 0)
		{
			Log.Instance.Error(ELogModule.MultiTemplateComponent, ELogAuthor.LZK, "[MultiTemplateComponent] [RemoveLastItem] Display items is empty", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		int displayIndex = this.DisplayItems.Count - 1;
		this.RecycleItemByIndex(displayIndex);
		this.DataList.RemoveAt(this.DataList.Count - 1);
		this.DisplayItems.RemoveAt(this.DisplayItems.Count - 1);
		return true;
	}

	// Token: 0x06015A19 RID: 88601 RVA: 0x00646ED4 File Offset: 0x006450D4
	public unsafe void RefreshDirectly()
	{
		if (this.DisplayItems.Count != this.DataList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateComponent;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateComponent] [RefreshDirectly] Display items length is not equal to data list length";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("displayItemsLength", this.DisplayItems.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dataListLength", this.DataList.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		for (int i = 0; i < this.DataList.Count; i++)
		{
			IMultiTemplateGridData multiTemplateGridData = this.DataList[i];
			UUIItem uuiitem = this.DisplayItems[i];
			ISyncGridProxy syncGridProxy;
			if (!this.ProxyItems.TryGetValue(uuiitem, out syncGridProxy))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MultiTemplateComponent;
				ELogAuthor author2 = ELogAuthor.LZK;
				string message2 = "[MultiTemplateComponent] [RefreshDirectly] Proxy not found for display item";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("index", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("item", uuiitem);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			else
			{
				syncGridProxy.Refresh(multiTemplateGridData.Data);
			}
		}
	}

	// Token: 0x06015A1A RID: 88602 RVA: 0x00647024 File Offset: 0x00645224
	private void AllocateDisplayItems()
	{
		for (int i = 0; i < this.DataList.Count; i++)
		{
			IMultiTemplateGridData data = this.DataList[i];
			UUIItem uuiitem = this.AcquireItem(data);
			if (uuiitem != null)
			{
				ISyncGridProxy syncGridProxy = this.EnsureProxy(uuiitem, data);
				uuiitem.SetUIActive(true);
				uuiitem.SetHierarchyIndex(i);
				syncGridProxy.GridIndex = i;
				this.DisplayItems.Add(uuiitem);
			}
		}
	}

	// Token: 0x06015A1B RID: 88603 RVA: 0x00647088 File Offset: 0x00645288
	[return: Nullable(2)]
	private UUIItem AcquireItem(IMultiTemplateGridData data)
	{
		int templateIndex = data.GetTemplateIndex();
		UUIItem uuiitem = this.PopItemFromPool(templateIndex);
		if (uuiitem != null)
		{
			return uuiitem;
		}
		UUIItem uuiitem2 = this.CreateItemByTemplateIndex(templateIndex);
		if (uuiitem2 == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateComponent;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateComponent] [AcquireItem] Failed to create item by template index";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("templateIndex", templateIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return uuiitem2;
	}

	// Token: 0x06015A1C RID: 88604 RVA: 0x006470E8 File Offset: 0x006452E8
	private ISyncGridProxy EnsureProxy(UUIItem item, IMultiTemplateGridData data)
	{
		ISyncGridProxy syncGridProxy;
		if (!this.ProxyItems.TryGetValue(item, out syncGridProxy))
		{
			syncGridProxy = data.CreateProxy();
			this.ProxyItems[item] = syncGridProxy;
			syncGridProxy.CreateByActor(item.GetOwner());
		}
		return syncGridProxy;
	}

	// Token: 0x06015A1D RID: 88605 RVA: 0x00647128 File Offset: 0x00645328
	[NullableContext(2)]
	private UUIItem PopItemFromPool(int templateIndex)
	{
		List<UUIItem> list;
		if (!this.PoolItems.TryGetValue(templateIndex, out list))
		{
			return null;
		}
		if (list.Count == 0)
		{
			return null;
		}
		UUIItem result = list[list.Count - 1];
		list.RemoveAt(list.Count - 1);
		return result;
	}

	// Token: 0x06015A1E RID: 88606 RVA: 0x00647170 File Offset: 0x00645370
	[NullableContext(2)]
	private UUIItem CreateItemByTemplateIndex(int templateIndex)
	{
		UUIItem item;
		if (!this.TemplateItems.TryGetValue(templateIndex, out item))
		{
			return null;
		}
		return LguiUtil.Instance.CopyItem(item, this.RootItem);
	}

	// Token: 0x06015A1F RID: 88607 RVA: 0x006471A0 File Offset: 0x006453A0
	private void RecycleAllItems()
	{
		if (this.DisplayItems.Count == 0)
		{
			return;
		}
		for (int i = 0; i < this.DisplayItems.Count; i++)
		{
			this.RecycleItemByIndex(i);
		}
		this.DisplayItems.Clear();
	}

	// Token: 0x06015A20 RID: 88608 RVA: 0x006471E4 File Offset: 0x006453E4
	private unsafe void RecycleItemByIndex(int displayIndex)
	{
		if (displayIndex < 0 || displayIndex >= this.DisplayItems.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateComponent;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateComponent] [RecycleItemByIndex] Display index out of range";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("displayIndex", displayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("displayItemsLength", this.DisplayItems.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		UUIItem uuiitem = this.DisplayItems[displayIndex];
		if (uuiitem == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MultiTemplateComponent;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[MultiTemplateComponent] [RecycleItemByIndex] Item not found in display items";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("displayIndex", displayIndex);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		ISyncGridProxy syncGridProxy;
		if (!this.ProxyItems.TryGetValue(uuiitem, out syncGridProxy))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.MultiTemplateComponent;
			ELogAuthor author3 = ELogAuthor.LZK;
			string message3 = "[MultiTemplateComponent] [RecycleItemByIndex] Proxy not found in proxy items";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("displayIndex", displayIndex);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		int templateIndex = this.DataList[displayIndex].GetTemplateIndex();
		List<UUIItem> list;
		if (!this.PoolItems.TryGetValue(templateIndex, out list))
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.MultiTemplateComponent;
			ELogAuthor author4 = ELogAuthor.LZK;
			string message4 = "[MultiTemplateComponent] [RecycleItemByIndex] Template index not found in pool items";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("templateIndex", templateIndex);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		uuiitem.SetUIActive(false);
		list.Add(uuiitem);
		syncGridProxy.Clear();
	}

	// Token: 0x06015A21 RID: 88609 RVA: 0x00647354 File Offset: 0x00645554
	public unsafe bool CheckDataListValid(List<IMultiTemplateGridData> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			int templateIndex = dataList[i].GetTemplateIndex();
			if (!this.TemplateItems.ContainsKey(templateIndex))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiTemplateComponent;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "[MultiTemplateComponent] [CheckDataListValid] Template index not found in template items";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dataIndex", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("templateIndex", templateIndex);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
		}
		return true;
	}

	// Token: 0x06015A22 RID: 88610 RVA: 0x006473F6 File Offset: 0x006455F6
	public List<UUIItem> GetDisplayItems()
	{
		return this.DisplayItems;
	}

	// Token: 0x06015A23 RID: 88611 RVA: 0x006473FE File Offset: 0x006455FE
	[NullableContext(2)]
	public UUIItem GetItemByDisplayIndex(int displayIndex)
	{
		if (displayIndex < 0 || displayIndex >= this.DisplayItems.Count)
		{
			return null;
		}
		return this.DisplayItems[displayIndex];
	}

	// Token: 0x06015A24 RID: 88612 RVA: 0x00647420 File Offset: 0x00645620
	[NullableContext(2)]
	public ISyncGridProxy GetProxyByDisplayIndex(int displayIndex)
	{
		UUIItem uuiitem = this.DisplayItems[displayIndex];
		if (uuiitem == null)
		{
			return null;
		}
		ISyncGridProxy result;
		if (this.ProxyItems.TryGetValue(uuiitem, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06015A25 RID: 88613 RVA: 0x00647454 File Offset: 0x00645654
	public unsafe int GetTemplateIndexByDisplayIndex(int displayIndex)
	{
		if (displayIndex < 0 || displayIndex >= this.DataList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiTemplateComponent;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MultiTemplateComponent] [GetTemplateIndexByDisplayIndex] Display index out of range";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("displayIndex", displayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dataListLength", this.DataList.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return -1;
		}
		return this.DataList[displayIndex].GetTemplateIndex();
	}

	// Token: 0x06015A26 RID: 88614 RVA: 0x006474F0 File Offset: 0x006456F0
	public int GetDisplayGridNum()
	{
		return this.DisplayItems.Count;
	}

	// Token: 0x06015A27 RID: 88615 RVA: 0x006474FD File Offset: 0x006456FD
	public int GetPreservedGridNum()
	{
		return this.DisplayItems.Count;
	}

	// Token: 0x06015A28 RID: 88616 RVA: 0x0064750A File Offset: 0x0064570A
	public int GetDisplayGridStartIndex()
	{
		return 0;
	}

	// Token: 0x06015A29 RID: 88617 RVA: 0x0064750D File Offset: 0x0064570D
	public int GetDisplayGridEndIndex()
	{
		return this.GetDisplayGridNum() - 1;
	}

	// Token: 0x06015A2A RID: 88618 RVA: 0x00647517 File Offset: 0x00645717
	[NullableContext(2)]
	public UUIItem GetGrid(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.DisplayItems.Count)
		{
			return null;
		}
		return this.DisplayItems[gridIndex];
	}

	// Token: 0x06015A2B RID: 88619 RVA: 0x00647539 File Offset: 0x00645739
	[NullableContext(2)]
	public UUIItem GetGridByDisplayIndex(int displayIndex)
	{
		if (displayIndex < 0 || displayIndex >= this.DisplayItems.Count)
		{
			return null;
		}
		return this.DisplayItems[displayIndex];
	}

	// Token: 0x06015A2C RID: 88620 RVA: 0x0064755B File Offset: 0x0064575B
	public float GetGridAnimationInterval()
	{
		return 0f;
	}

	// Token: 0x06015A2D RID: 88621 RVA: 0x00647562 File Offset: 0x00645762
	public float GetGridAnimationStartTime()
	{
		return 0f;
	}

	// Token: 0x06015A2E RID: 88622 RVA: 0x00647569 File Offset: 0x00645769
	public void NotifyAnimationStart()
	{
	}

	// Token: 0x06015A2F RID: 88623 RVA: 0x0064756B File Offset: 0x0064576B
	public void NotifyAnimationEnd()
	{
	}

	// Token: 0x06015A30 RID: 88624 RVA: 0x0064756D File Offset: 0x0064576D
	[NullableContext(2)]
	public UUIInturnAnimController GetUiAnimController()
	{
		return this.AnimControllerComponent;
	}

	// Token: 0x0400B6B5 RID: 46773
	[Nullable(2)]
	private readonly UUIItem RootItem;

	// Token: 0x0400B6B6 RID: 46774
	private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

	// Token: 0x0400B6B7 RID: 46775
	private readonly Dictionary<int, UUIItem> TemplateItems = new Dictionary<int, UUIItem>();

	// Token: 0x0400B6B8 RID: 46776
	private readonly Dictionary<int, List<UUIItem>> PoolItems = new Dictionary<int, List<UUIItem>>();

	// Token: 0x0400B6B9 RID: 46777
	private readonly Dictionary<UUIItem, ISyncGridProxy> ProxyItems = new Dictionary<UUIItem, ISyncGridProxy>();

	// Token: 0x0400B6BA RID: 46778
	private readonly List<UUIItem> DisplayItems = new List<UUIItem>();

	// Token: 0x0400B6BB RID: 46779
	[Nullable(2)]
	private readonly GridAppearAnimationBase GridsController;

	// Token: 0x0400B6BC RID: 46780
	[Nullable(2)]
	private readonly UUIInturnAnimController AnimControllerComponent;
}
