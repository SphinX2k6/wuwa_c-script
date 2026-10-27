using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002CDD RID: 11485
[NullableContext(1)]
[Nullable(0)]
public class MultiTemplateComponent : IGridPreserver
{
	// Token: 0x06018196 RID: 98710 RVA: 0x0062102C File Offset: 0x0061F22C
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

	// Token: 0x06018197 RID: 98711 RVA: 0x00621120 File Offset: 0x0061F320
	public void RefreshByData(List<IMultiTemplateGridData> dataList, bool playGridAnim = false)
	{
		if (!this.CheckDataListValid(dataList))
		{
			return;
		}
		this.RecycleAllItems();
		this.DataList = dataList.ToList<IMultiTemplateGridData>();
		this.AllocateDisplayItems();
		this.RefreshDirectly();
		if (playGridAnim && this.GridsController != null)
		{
			this.GridsController.PlayGridAnim(this.GetDisplayGridNum(), false);
		}
	}

	// Token: 0x06018198 RID: 98712 RVA: 0x00621174 File Offset: 0x0061F374
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

	// Token: 0x06018199 RID: 98713 RVA: 0x006211DC File Offset: 0x0061F3DC
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

	// Token: 0x0601819A RID: 98714 RVA: 0x00621260 File Offset: 0x0061F460
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

	// Token: 0x0601819B RID: 98715 RVA: 0x006213B0 File Offset: 0x0061F5B0
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

	// Token: 0x0601819C RID: 98716 RVA: 0x00621414 File Offset: 0x0061F614
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

	// Token: 0x0601819D RID: 98717 RVA: 0x00621474 File Offset: 0x0061F674
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

	// Token: 0x0601819E RID: 98718 RVA: 0x006214B4 File Offset: 0x0061F6B4
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

	// Token: 0x0601819F RID: 98719 RVA: 0x006214FC File Offset: 0x0061F6FC
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

	// Token: 0x060181A0 RID: 98720 RVA: 0x0062152C File Offset: 0x0061F72C
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

	// Token: 0x060181A1 RID: 98721 RVA: 0x00621570 File Offset: 0x0061F770
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

	// Token: 0x060181A2 RID: 98722 RVA: 0x006216E0 File Offset: 0x0061F8E0
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

	// Token: 0x060181A3 RID: 98723 RVA: 0x00621782 File Offset: 0x0061F982
	public List<UUIItem> GetDisplayItems()
	{
		return this.DisplayItems;
	}

	// Token: 0x060181A4 RID: 98724 RVA: 0x0062178A File Offset: 0x0061F98A
	[NullableContext(2)]
	public UUIItem GetItemByDisplayIndex(int displayIndex)
	{
		if (displayIndex < 0 || displayIndex >= this.DisplayItems.Count)
		{
			return null;
		}
		return this.DisplayItems[displayIndex];
	}

	// Token: 0x060181A5 RID: 98725 RVA: 0x006217AC File Offset: 0x0061F9AC
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

	// Token: 0x060181A6 RID: 98726 RVA: 0x006217E0 File Offset: 0x0061F9E0
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

	// Token: 0x060181A7 RID: 98727 RVA: 0x0062187C File Offset: 0x0061FA7C
	public int GetDisplayGridNum()
	{
		return this.DisplayItems.Count;
	}

	// Token: 0x060181A8 RID: 98728 RVA: 0x00621889 File Offset: 0x0061FA89
	public int GetPreservedGridNum()
	{
		return this.DisplayItems.Count;
	}

	// Token: 0x060181A9 RID: 98729 RVA: 0x00621896 File Offset: 0x0061FA96
	public int GetDisplayGridStartIndex()
	{
		return 0;
	}

	// Token: 0x060181AA RID: 98730 RVA: 0x00621899 File Offset: 0x0061FA99
	public int GetDisplayGridEndIndex()
	{
		return this.GetDisplayGridNum() - 1;
	}

	// Token: 0x060181AB RID: 98731 RVA: 0x006218A3 File Offset: 0x0061FAA3
	[NullableContext(2)]
	public UUIItem GetGrid(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.DisplayItems.Count)
		{
			return null;
		}
		return this.DisplayItems[gridIndex];
	}

	// Token: 0x060181AC RID: 98732 RVA: 0x006218C5 File Offset: 0x0061FAC5
	[NullableContext(2)]
	public UUIItem GetGridByDisplayIndex(int displayIndex)
	{
		if (displayIndex < 0 || displayIndex >= this.DisplayItems.Count)
		{
			return null;
		}
		return this.DisplayItems[displayIndex];
	}

	// Token: 0x060181AD RID: 98733 RVA: 0x006218E7 File Offset: 0x0061FAE7
	public float GetGridAnimationInterval()
	{
		return 0f;
	}

	// Token: 0x060181AE RID: 98734 RVA: 0x006218EE File Offset: 0x0061FAEE
	public float GetGridAnimationStartTime()
	{
		return 0f;
	}

	// Token: 0x060181AF RID: 98735 RVA: 0x006218F5 File Offset: 0x0061FAF5
	public void NotifyAnimationStart()
	{
	}

	// Token: 0x060181B0 RID: 98736 RVA: 0x006218F7 File Offset: 0x0061FAF7
	public void NotifyAnimationEnd()
	{
	}

	// Token: 0x060181B1 RID: 98737 RVA: 0x006218F9 File Offset: 0x0061FAF9
	[NullableContext(2)]
	public UUIInturnAnimController GetUiAnimController()
	{
		return this.AnimControllerComponent;
	}

	// Token: 0x0400B349 RID: 45897
	[Nullable(2)]
	private readonly UUIItem RootItem;

	// Token: 0x0400B34A RID: 45898
	private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

	// Token: 0x0400B34B RID: 45899
	private readonly Dictionary<int, UUIItem> TemplateItems = new Dictionary<int, UUIItem>();

	// Token: 0x0400B34C RID: 45900
	private readonly Dictionary<int, List<UUIItem>> PoolItems = new Dictionary<int, List<UUIItem>>();

	// Token: 0x0400B34D RID: 45901
	private readonly Dictionary<UUIItem, ISyncGridProxy> ProxyItems = new Dictionary<UUIItem, ISyncGridProxy>();

	// Token: 0x0400B34E RID: 45902
	private readonly List<UUIItem> DisplayItems = new List<UUIItem>();

	// Token: 0x0400B34F RID: 45903
	[Nullable(2)]
	private readonly GridAppearAnimationBase GridsController;

	// Token: 0x0400B350 RID: 45904
	[Nullable(2)]
	private readonly UUIInturnAnimController AnimControllerComponent;
}
