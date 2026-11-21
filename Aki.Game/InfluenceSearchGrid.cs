using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144C RID: 5196
[NullableContext(1)]
[Nullable(0)]
internal class InfluenceSearchGrid : UiPanelBase
{
	// Token: 0x0600CEB4 RID: 52916 RVA: 0x003D7320 File Offset: 0x003D5520
	public InfluenceSearchGrid(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CEB5 RID: 52917 RVA: 0x003D7338 File Offset: 0x003D5538
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CEB6 RID: 52918 RVA: 0x003D73E3 File Offset: 0x003D55E3
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<InfluenceSearchItem>(base.GetVerticalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceSearchItem>(this.InitItem), base.GetItem(3));
	}

	// Token: 0x0600CEB7 RID: 52919 RVA: 0x003D740C File Offset: 0x003D560C
	private ILayoutItem<InfluenceSearchItem> InitItem(object influenceId, UUIItem uiItem, int index)
	{
		InfluenceSearchItem influenceSearchItem = new InfluenceSearchItem(uiItem);
		influenceSearchItem.UpdateItem((int)influenceId, this.CountryId);
		return new LayoutItem<InfluenceSearchItem>
		{
			Key = index,
			Value = influenceSearchItem
		};
	}

	// Token: 0x0600CEB8 RID: 52920 RVA: 0x003D744C File Offset: 0x003D564C
	public void UpdateGrid(int countryId, int[] influenceIdList)
	{
		this.CountryId = countryId;
		Country value = InfluenceConfig.Instance.GetCountryConfig(countryId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Title, Array.Empty<object>());
		UUIItem item = base.GetItem(1);
		bool flag = influenceIdList.Length != 0;
		item.SetUIActive(!flag);
		this.Layout.RebuildLayoutByDataNew<int>(influenceIdList, null);
	}

	// Token: 0x0600CEB9 RID: 52921 RVA: 0x003D74BC File Offset: 0x003D56BC
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
		this.Layout = null;
	}

	// Token: 0x04007591 RID: 30097
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<InfluenceSearchItem> Layout;

	// Token: 0x04007592 RID: 30098
	private int CountryId;

	// Token: 0x020076F9 RID: 30457
	[NullableContext(0)]
	private enum EInfluenceSearchGrid
	{
		// Token: 0x04026A65 RID: 158309
		Title,
		// Token: 0x04026A66 RID: 158310
		NoSearchText,
		// Token: 0x04026A67 RID: 158311
		Layout,
		// Token: 0x04026A68 RID: 158312
		LayoutItem
	}
}
