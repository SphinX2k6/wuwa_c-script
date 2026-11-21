using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using FilterDefine;
using UnrealEngine;

// Token: 0x020014AA RID: 5290
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SelectGroup : GridProxyAbstract<InventoryDefine.ISelectGroupData>
{
	// Token: 0x0600D3DA RID: 54234 RVA: 0x003EFAC0 File Offset: 0x003EDCC0
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

	// Token: 0x0600D3DB RID: 54235 RVA: 0x003EFBC9 File Offset: 0x003EDDC9
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<SelectItem, InventoryDefine.ISelectItemData>(base.GetLayoutBase(3), new Func<SelectItem>(this.InitSelectItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600D3DC RID: 54236 RVA: 0x003EFBFC File Offset: 0x003EDDFC
	private SelectItem InitSelectItem()
	{
		return new SelectItem
		{
			CallbackClickItem = new Action<EToggleState, int>(this.OnClickedItem),
			CallbackGetState = new Func<int, bool>(this.GetSelectState)
		};
	}

	// Token: 0x0600D3DD RID: 54237 RVA: 0x003EFC28 File Offset: 0x003EDE28
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

	// Token: 0x0600D3DE RID: 54238 RVA: 0x003EFCBC File Offset: 0x003EDEBC
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

	// Token: 0x0600D3DF RID: 54239 RVA: 0x003EFE0C File Offset: 0x003EE00C
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

	// Token: 0x0600D3E0 RID: 54240 RVA: 0x003EFE74 File Offset: 0x003EE074
	public void RefreshGroupItem()
	{
		foreach (KeyValuePair<object, SelectItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			keyValuePair.Value.RefreshToggleState();
		}
	}

	// Token: 0x0600D3E1 RID: 54241 RVA: 0x003EFED4 File Offset: 0x003EE0D4
	public void ResetSelect()
	{
		this.SelectValueMap.Clear();
		foreach (KeyValuePair<object, SelectItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			keyValuePair.Value.RefreshToggleState();
		}
		this.RefreshToggleAll();
	}

	// Token: 0x0600D3E2 RID: 54242 RVA: 0x003EFF44 File Offset: 0x003EE144
	public bool GetSelectState(int value)
	{
		return this.SelectValueMap.ContainsKey(value);
	}

	// Token: 0x0600D3E3 RID: 54243 RVA: 0x003EFF54 File Offset: 0x003EE154
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

	// Token: 0x0600D3E4 RID: 54244 RVA: 0x003EFFC4 File Offset: 0x003EE1C4
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

	// Token: 0x0600D3E5 RID: 54245 RVA: 0x003F0050 File Offset: 0x003EE250
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

	// Token: 0x0600D3E6 RID: 54246 RVA: 0x003F0086 File Offset: 0x003EE286
	public override object GetKey(InventoryDefine.ISelectGroupData data, int displayIndex)
	{
		return this.Data.FilterRuleId;
	}

	// Token: 0x0600D3E7 RID: 54247 RVA: 0x003F0098 File Offset: 0x003EE298
	public int GetRuleId()
	{
		return this.Data.FilterRuleId;
	}

	// Token: 0x04007721 RID: 30497
	[Nullable(2)]
	private InventoryDefine.ISelectGroupData Data;

	// Token: 0x04007722 RID: 30498
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SelectItem, InventoryDefine.ISelectItemData> Layout;

	// Token: 0x04007723 RID: 30499
	private readonly Dictionary<int, int> SelectValueMap = new Dictionary<int, int>();

	// Token: 0x04007724 RID: 30500
	private List<InventoryDefine.ISelectItemData> ItemDataList = new List<InventoryDefine.ISelectItemData>();

	// Token: 0x02007775 RID: 30581
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04026C8A RID: 158858
		Title,
		// Token: 0x04026C8B RID: 158859
		SelectAllToggleRootItem,
		// Token: 0x04026C8C RID: 158860
		SelectAllToggle,
		// Token: 0x04026C8D RID: 158861
		Layout,
		// Token: 0x04026C8E RID: 158862
		FilterItem
	}
}
