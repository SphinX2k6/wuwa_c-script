using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001FD7 RID: 8151
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SelectGroup : GridProxyAbstract<InventoryDefine.ISelectGroupData>
{
	// Token: 0x0600FF72 RID: 65394 RVA: 0x003E34BC File Offset: 0x003E16BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickedAll));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FF73 RID: 65395 RVA: 0x003E35C5 File Offset: 0x003E17C5
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<SelectItem, InventoryDefine.ISelectItemData>(base.GetLayoutBase(3), new Func<SelectItem>(this.InitSelectItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600FF74 RID: 65396 RVA: 0x003E35F8 File Offset: 0x003E17F8
	private SelectItem InitSelectItem()
	{
		return new SelectItem
		{
			CallbackClickItem = new Action<EToggleState, int>(this.OnClickedItem),
			CallbackGetState = new Func<int, bool>(this.GetSelectState)
		};
	}

	// Token: 0x0600FF75 RID: 65397 RVA: 0x003E3624 File Offset: 0x003E1824
	public override void Refresh(InventoryDefine.ISelectGroupData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.InitAllData();
		int filterRuleId = this.Data.FilterRuleId;
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(filterRuleId);
		base.GetText(0).ShowTextNew(filterRuleConfig.Value.Title);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(data.FilterId);
		base.GetItem(1).SetUIActive(filterConfig.Value.IsSupportSelectAll);
		this.RefreshToggleAll();
		this.Layout.RefreshByData(this.ItemDataList, null, false);
	}

	// Token: 0x0600FF76 RID: 65398 RVA: 0x003E36B8 File Offset: 0x003E18B8
	private void InitAllData()
	{
		List<InventoryDefine.ISelectItemData> list = new List<InventoryDefine.ISelectItemData>();
		InventoryDefine.ISelectGroupData data = this.Data;
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(data.FilterId);
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(data.FilterRuleId);
		int[] array = filterRuleConfig.Value.IdList();
		int filterType = filterRuleConfig.Value.FilterType;
		Func<int[], FilterItemData[]> filterDataFuncByFilterType = FilterModel.Instance.GetFilterDataFuncByFilterType((FilterDefine.EFilterType)filterType);
		foreach (int num in array)
		{
			FilterItemData filterItemData = filterDataFuncByFilterType(new int[]
			{
				num
			})[0];
			InventoryDefine.SelectItemData item = new InventoryDefine.SelectItemData
			{
				FilterId = data.FilterId,
				FilterRuleId = data.FilterRuleId,
				Value = num,
				Name = filterItemData.Content,
				IconPath = filterItemData.GetIconPath(),
				IsShowIcon = filterConfig.Value.IsShowIcon,
				NeedChangeColor = filterRuleConfig.Value.NeedChangeColor
			};
			if (Array.IndexOf<int>(data.ValueList, num) >= 0 && !this.SelectValueMap.ContainsKey(num))
			{
				this.SelectValueMap.Add(num, num);
			}
			list.Add(item);
		}
		this.ItemDataList = list;
	}

	// Token: 0x0600FF77 RID: 65399 RVA: 0x003E3808 File Offset: 0x003E1A08
	public void RefreshToggleAll()
	{
		int filterId = this.Data.FilterId;
		if (!FilterConfig.Instance.GetFilterConfig(filterId).Value.IsSupportSelectAll)
		{
			return;
		}
		EToggleState state = (this.SelectValueMap.Count == this.ItemDataList.Count) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600FF78 RID: 65400 RVA: 0x003E3870 File Offset: 0x003E1A70
	public void RefreshGroupItem()
	{
		foreach (KeyValuePair<object, SelectItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			keyValuePair.Value.RefreshToggleState();
		}
	}

	// Token: 0x0600FF79 RID: 65401 RVA: 0x003E38D0 File Offset: 0x003E1AD0
	public void ResetSelect()
	{
		this.SelectValueMap.Clear();
		foreach (KeyValuePair<object, SelectItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			keyValuePair.Value.RefreshToggleState();
		}
		this.RefreshToggleAll();
	}

	// Token: 0x0600FF7A RID: 65402 RVA: 0x003E3940 File Offset: 0x003E1B40
	public bool GetSelectState(int value)
	{
		return this.SelectValueMap.ContainsKey(value);
	}

	// Token: 0x0600FF7B RID: 65403 RVA: 0x003E3950 File Offset: 0x003E1B50
	public int[] GetSelectValueList()
	{
		int[] array = new int[this.SelectValueMap.Count];
		int num = 0;
		foreach (int num2 in this.SelectValueMap.Values)
		{
			array[num++] = num2;
		}
		return array;
	}

	// Token: 0x0600FF7C RID: 65404 RVA: 0x003E39C0 File Offset: 0x003E1BC0
	private void OnClickedAll(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			using (Dictionary<object, SelectItem>.KeyCollection.Enumerator enumerator = this.Layout.GetLayoutItemMap().Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					int num = (int)obj;
					if (!this.SelectValueMap.ContainsKey(num))
					{
						this.SelectValueMap.Add(num, num);
					}
				}
				goto IL_66;
			}
		}
		if (state == EToggleState.ETT_UnChecked)
		{
			this.ResetSelect();
		}
		IL_66:
		this.RefreshGroupItem();
	}

	// Token: 0x0600FF7D RID: 65405 RVA: 0x003E3A4C File Offset: 0x003E1C4C
	private void OnClickedItem(EToggleState state, int value)
	{
		if (state == EToggleState.ETT_Checked)
		{
			if (!this.SelectValueMap.ContainsKey(value))
			{
				this.SelectValueMap.Add(value, value);
			}
		}
		else
		{
			this.SelectValueMap.Remove(value);
		}
		this.RefreshToggleAll();
	}

	// Token: 0x0600FF7E RID: 65406 RVA: 0x003E3A82 File Offset: 0x003E1C82
	public override object GetKey(InventoryDefine.ISelectGroupData data, int displayIndex)
	{
		return this.Data.FilterRuleId;
	}

	// Token: 0x0600FF7F RID: 65407 RVA: 0x003E3A94 File Offset: 0x003E1C94
	public int GetRuleId()
	{
		return this.Data.FilterRuleId;
	}

	// Token: 0x04007638 RID: 30264
	[Nullable(2)]
	private InventoryDefine.ISelectGroupData Data;

	// Token: 0x04007639 RID: 30265
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SelectItem, InventoryDefine.ISelectItemData> Layout;

	// Token: 0x0400763A RID: 30266
	private readonly Dictionary<int, int> SelectValueMap = new Dictionary<int, int>();

	// Token: 0x0400763B RID: 30267
	private List<InventoryDefine.ISelectItemData> ItemDataList = new List<InventoryDefine.ISelectItemData>();

	// Token: 0x020085EE RID: 34286
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402B97B RID: 178555
		Title,
		// Token: 0x0402B97C RID: 178556
		SelectAllToggleRootItem,
		// Token: 0x0402B97D RID: 178557
		SelectAllToggle,
		// Token: 0x0402B97E RID: 178558
		Layout,
		// Token: 0x0402B97F RID: 178559
		FilterItem
	}
}
