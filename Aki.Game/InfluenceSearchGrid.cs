using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8A RID: 8074
[NullableContext(1)]
[Nullable(0)]
internal class InfluenceSearchGrid : UiPanelBase
{
	// Token: 0x0600FA95 RID: 64149 RVA: 0x003CB7E8 File Offset: 0x003C99E8
	public InfluenceSearchGrid(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FA96 RID: 64150 RVA: 0x003CB800 File Offset: 0x003C9A00
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

	// Token: 0x0600FA97 RID: 64151 RVA: 0x003CB8AB File Offset: 0x003C9AAB
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<InfluenceSearchItem>(base.GetVerticalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceSearchItem>(this.InitItem), base.GetItem(3));
	}

	// Token: 0x0600FA98 RID: 64152 RVA: 0x003CB8D4 File Offset: 0x003C9AD4
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

	// Token: 0x0600FA99 RID: 64153 RVA: 0x003CB914 File Offset: 0x003C9B14
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

	// Token: 0x0600FA9A RID: 64154 RVA: 0x003CB984 File Offset: 0x003C9B84
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
		this.Layout = null;
	}

	// Token: 0x040074B0 RID: 29872
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<InfluenceSearchItem> Layout;

	// Token: 0x040074B1 RID: 29873
	private int CountryId;

	// Token: 0x02008574 RID: 34164
	[NullableContext(0)]
	private enum EInfluenceSearchGrid
	{
		// Token: 0x0402B742 RID: 177986
		Title,
		// Token: 0x0402B743 RID: 177987
		NoSearchText,
		// Token: 0x0402B744 RID: 177988
		Layout,
		// Token: 0x0402B745 RID: 177989
		LayoutItem
	}
}
