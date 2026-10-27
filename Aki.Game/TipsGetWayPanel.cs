using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018EF RID: 6383
[NullableContext(1)]
[Nullable(0)]
public class TipsGetWayPanel : UiPanelBase
{
	// Token: 0x0600BB0D RID: 47885 RVA: 0x002A5A1D File Offset: 0x002A3C1D
	public TipsGetWayPanel(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BB0E RID: 47886 RVA: 0x002A5A34 File Offset: 0x002A3C34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BB0F RID: 47887 RVA: 0x002A5A9D File Offset: 0x002A3C9D
	protected override void OnStart()
	{
		this.GetWayLayout = new GenericLayoutNew<TipsGetWayItem>(base.GetVerticalLayout(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TipsGetWayItem>(this.RefreshGetWayInfo), null);
	}

	// Token: 0x0600BB10 RID: 47888 RVA: 0x002A5ABE File Offset: 0x002A3CBE
	protected override void OnBeforeDestroy()
	{
		this.GetWayData = new IGetWayItemData[0];
	}

	// Token: 0x0600BB11 RID: 47889 RVA: 0x002A5ACC File Offset: 0x002A3CCC
	public void Refresh(IGetWayItemData[] data)
	{
		IGetWayItemData[] getWayData2 = (from getWayData in data
		orderby getWayData.SortIndex descending, getWayData.Id descending
		select getWayData).ToArray<IGetWayItemData>();
		this.GetWayData = getWayData2;
		this.GetWayLayout.RebuildLayoutByDataNew<IGetWayItemData>(this.GetWayData, null);
		this.SetActive(this.GetWayData.Length != 0);
	}

	// Token: 0x0600BB12 RID: 47890 RVA: 0x002A5B5C File Offset: 0x002A3D5C
	private ILayoutItem<TipsGetWayItem> RefreshGetWayInfo(object data, UUIItem uiItem, int index)
	{
		TipsGetWayItem value = new TipsGetWayItem(uiItem, (IGetWayItemData)data);
		return new LayoutItem<TipsGetWayItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x040054F4 RID: 21748
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IGetWayItemData[] GetWayData;

	// Token: 0x040054F5 RID: 21749
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TipsGetWayItem> GetWayLayout;

	// Token: 0x02007E64 RID: 32356
	[NullableContext(0)]
	private class ETipsGetWayNode
	{
		// Token: 0x040295B5 RID: 169397
		public const int PanelLink = 0;

		// Token: 0x040295B6 RID: 169398
		public const int ButtonLink = 1;
	}
}
