using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002162 RID: 8546
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailInformationBuffItem : UiPanelBase
{
	// Token: 0x06014FB9 RID: 85945 RVA: 0x0061CE7A File Offset: 0x0061B07A
	public TowerDetailInformationBuffItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014FBA RID: 85946 RVA: 0x0061CE90 File Offset: 0x0061B090
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014FBB RID: 85947 RVA: 0x0061CEF9 File Offset: 0x0061B0F9
	protected override void OnStart()
	{
		this.BuffScroller = new GenericLayoutNew<TowerDetailInformationBuffSubItem>(base.GetVerticalLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailInformationBuffSubItem>(this.CreateBuffItem), null);
	}

	// Token: 0x06014FBC RID: 85948 RVA: 0x0061CF1C File Offset: 0x0061B11C
	private ILayoutItem<TowerDetailInformationBuffSubItem> CreateBuffItem(object tempData, UUIItem uiItem, int index)
	{
		TowerDetailBuff data = (TowerDetailBuff)tempData;
		TowerDetailInformationBuffSubItem towerDetailInformationBuffSubItem = new TowerDetailInformationBuffSubItem(uiItem);
		towerDetailInformationBuffSubItem.Update(data);
		return new LayoutItem<TowerDetailInformationBuffSubItem>
		{
			Key = index,
			Value = towerDetailInformationBuffSubItem
		};
	}

	// Token: 0x06014FBD RID: 85949 RVA: 0x0061CF56 File Offset: 0x0061B156
	public void Update(TowerDetailBuffData data)
	{
		this.BuffData = data;
		this.RefreshView();
	}

	// Token: 0x06014FBE RID: 85950 RVA: 0x0061CF68 File Offset: 0x0061B168
	private void RefreshView()
	{
		this.BuffScroller.RebuildLayoutByDataNew<TowerDetailBuff>(this.BuffData.Buffs, null);
	}

	// Token: 0x06014FBF RID: 85951 RVA: 0x0061CF94 File Offset: 0x0061B194
	protected override void OnBeforeDestroy()
	{
		this.BuffScroller.ClearChildren();
	}

	// Token: 0x0400B2C6 RID: 45766
	[Nullable(2)]
	private TowerDetailBuffData BuffData;

	// Token: 0x0400B2C7 RID: 45767
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TowerDetailInformationBuffSubItem> BuffScroller;

	// Token: 0x020083E7 RID: 33767
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402A902 RID: 174338
		public const int BuffItem = 0;

		// Token: 0x0402A903 RID: 174339
		public const int BuffScroller = 1;
	}
}
