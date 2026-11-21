using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000DA8 RID: 3496
[NullableContext(1)]
[Nullable(0)]
public class TipsGetWayPanel : UiPanelBase
{
	// Token: 0x06008EF7 RID: 36599 RVA: 0x002B018D File Offset: 0x002AE38D
	public TipsGetWayPanel(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008EF8 RID: 36600 RVA: 0x002B01A4 File Offset: 0x002AE3A4
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

	// Token: 0x06008EF9 RID: 36601 RVA: 0x002B020D File Offset: 0x002AE40D
	protected override void OnStart()
	{
		this.GetWayLayout = new GenericLayoutNew<TipsGetWayItem>(base.GetVerticalLayout(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TipsGetWayItem>(this.RefreshGetWayInfo), null);
	}

	// Token: 0x06008EFA RID: 36602 RVA: 0x002B022E File Offset: 0x002AE42E
	protected override void OnBeforeDestroy()
	{
		this.GetWayData = new IGetWayItemData[0];
	}

	// Token: 0x06008EFB RID: 36603 RVA: 0x002B023C File Offset: 0x002AE43C
	public void Refresh(IGetWayItemData[] data)
	{
		IGetWayItemData[] array = new IGetWayItemData[data.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = data[i];
		}
		Array.Sort<IGetWayItemData>(array, delegate(IGetWayItemData left, IGetWayItemData right)
		{
			int num = right.SortIndex.CompareTo(left.SortIndex);
			if (num == 0)
			{
				return right.Id.CompareTo(left.Id);
			}
			return num;
		});
		this.GetWayData = array;
		this.GetWayLayout.RebuildLayoutByDataNew<IGetWayItemData>(this.GetWayData, null);
		this.SetActive(this.GetWayData.Length != 0);
	}

	// Token: 0x06008EFC RID: 36604 RVA: 0x002B02BC File Offset: 0x002AE4BC
	private ILayoutItem<TipsGetWayItem> RefreshGetWayInfo(object data, UUIItem uiItem, int index)
	{
		TipsGetWayItem value = new TipsGetWayItem(uiItem, (IGetWayItemData)data);
		return new LayoutItem<TipsGetWayItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0400559F RID: 21919
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IGetWayItemData[] GetWayData;

	// Token: 0x040055A0 RID: 21920
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TipsGetWayItem> GetWayLayout;

	// Token: 0x02006FEB RID: 28651
	[NullableContext(0)]
	private class ETipsGetWayNode
	{
		// Token: 0x040248E2 RID: 149730
		public const int PanelLink = 0;

		// Token: 0x040248E3 RID: 149731
		public const int ButtonLink = 1;
	}
}
