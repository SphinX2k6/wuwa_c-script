using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BE7 RID: 11239
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailInformationBuffItem : UiPanelBase
{
	// Token: 0x06017588 RID: 95624 RVA: 0x005F031A File Offset: 0x005EE51A
	public TowerDetailInformationBuffItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06017589 RID: 95625 RVA: 0x005F0330 File Offset: 0x005EE530
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

	// Token: 0x0601758A RID: 95626 RVA: 0x005F0399 File Offset: 0x005EE599
	protected override void OnStart()
	{
		this.BuffScroller = new GenericLayoutNew<TowerDetailInformationBuffSubItem>(base.GetVerticalLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TowerDetailInformationBuffSubItem>(this.CreateBuffItem), null);
	}

	// Token: 0x0601758B RID: 95627 RVA: 0x005F03BC File Offset: 0x005EE5BC
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

	// Token: 0x0601758C RID: 95628 RVA: 0x005F03F6 File Offset: 0x005EE5F6
	public void Update(TowerDetailBuffData data)
	{
		this.BuffData = data;
		this.RefreshView();
	}

	// Token: 0x0601758D RID: 95629 RVA: 0x005F0408 File Offset: 0x005EE608
	private void RefreshView()
	{
		this.BuffScroller.RebuildLayoutByDataNew<TowerDetailBuff>(this.BuffData.Buffs, null);
	}

	// Token: 0x0601758E RID: 95630 RVA: 0x005F0434 File Offset: 0x005EE634
	protected override void OnBeforeDestroy()
	{
		this.BuffScroller.ClearChildren();
	}

	// Token: 0x0400AEC1 RID: 44737
	[Nullable(2)]
	private TowerDetailBuffData BuffData;

	// Token: 0x0400AEC2 RID: 44738
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TowerDetailInformationBuffSubItem> BuffScroller;

	// Token: 0x020091A4 RID: 37284
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F201 RID: 193025
		public const int BuffItem = 0;

		// Token: 0x0402F202 RID: 193026
		public const int BuffScroller = 1;
	}
}
