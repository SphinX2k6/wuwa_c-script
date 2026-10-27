using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018C1 RID: 6337
internal class StarLayoutItem : UiPanelBase
{
	// Token: 0x0600B9CE RID: 47566 RVA: 0x002A1F7A File Offset: 0x002A017A
	[NullableContext(1)]
	public StarLayoutItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B9CF RID: 47567 RVA: 0x002A1F8F File Offset: 0x002A018F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600B9D0 RID: 47568 RVA: 0x002A1FC8 File Offset: 0x002A01C8
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayoutNew<StarItem>(base.GetVerticalLayout(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.InitStarItem), base.GetItem(1));
	}

	// Token: 0x0600B9D1 RID: 47569 RVA: 0x002A1FF0 File Offset: 0x002A01F0
	[NullableContext(1)]
	private ILayoutItem<StarItem> InitStarItem([Nullable(2)] object data, UUIItem uiItem, int index)
	{
		StarItem value = new StarItem(uiItem);
		return new LayoutItem<StarItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600B9D2 RID: 47570 RVA: 0x002A201C File Offset: 0x002A021C
	[NullableContext(2)]
	public void RefreshStar(int[] starNum)
	{
		int num = (starNum != null) ? starNum.Length : 0;
		base.GetVerticalLayout(0).RootUIComp.Get().SetUIActive(num > 0);
		if (num > 0)
		{
			this.StarLayout.RebuildLayoutByDataNew<int>(starNum, null);
		}
	}

	// Token: 0x0600B9D3 RID: 47571 RVA: 0x002A2069 File Offset: 0x002A0269
	protected override void OnBeforeDestroy()
	{
		this.StarLayout.ClearChildren();
	}

	// Token: 0x0400543D RID: 21565
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<StarItem> StarLayout;

	// Token: 0x02007E4C RID: 32332
	private enum EStarDefine
	{
		// Token: 0x04029550 RID: 169296
		Layout,
		// Token: 0x04029551 RID: 169297
		StarItem
	}
}
