using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D7A RID: 3450
internal class StarLayoutItem : UiPanelBase
{
	// Token: 0x06008DB7 RID: 36279 RVA: 0x002AC6D2 File Offset: 0x002AA8D2
	[NullableContext(1)]
	public StarLayoutItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008DB8 RID: 36280 RVA: 0x002AC6E7 File Offset: 0x002AA8E7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06008DB9 RID: 36281 RVA: 0x002AC720 File Offset: 0x002AA920
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayoutNew<StarItem>(base.GetVerticalLayout(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.InitStarItem), base.GetItem(1));
	}

	// Token: 0x06008DBA RID: 36282 RVA: 0x002AC748 File Offset: 0x002AA948
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

	// Token: 0x06008DBB RID: 36283 RVA: 0x002AC774 File Offset: 0x002AA974
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

	// Token: 0x06008DBC RID: 36284 RVA: 0x002AC7C1 File Offset: 0x002AA9C1
	protected override void OnBeforeDestroy()
	{
		this.StarLayout.ClearChildren();
	}

	// Token: 0x040054E8 RID: 21736
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<StarItem> StarLayout;

	// Token: 0x02006FD3 RID: 28627
	private enum EStarDefine
	{
		// Token: 0x0402487D RID: 149629
		Layout,
		// Token: 0x0402487E RID: 149630
		StarItem
	}
}
