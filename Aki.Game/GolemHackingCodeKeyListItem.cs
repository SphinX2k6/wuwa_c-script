using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004C6 RID: 1222
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class GolemHackingCodeKeyListItem : GridProxyAbstract<List<GolemHackingCodeGridInfo>>
{
	// Token: 0x06003D1B RID: 15643 RVA: 0x001599AA File Offset: 0x00157BAA
	public GolemHackingCodeKeyListItem(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06003D1C RID: 15644 RVA: 0x001599BC File Offset: 0x00157BBC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003D1D RID: 15645 RVA: 0x00159A25 File Offset: 0x00157C25
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<GolemHackingCodeKeyItem, GolemHackingCodeGridInfo>(base.GetHorizontalLayout(0), new Func<GolemHackingCodeKeyItem>(this.CreateItem), null, false, true);
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x00159A48 File Offset: 0x00157C48
	public override void Refresh(List<GolemHackingCodeGridInfo> data, bool isSelected, int gridIndex)
	{
		this.Layout.RefreshByData(data, null, false);
	}

	// Token: 0x06003D1F RID: 15647 RVA: 0x00159A58 File Offset: 0x00157C58
	private GolemHackingCodeKeyItem CreateItem()
	{
		return new GolemHackingCodeKeyItem(this.Proxy);
	}

	// Token: 0x06003D20 RID: 15648 RVA: 0x00159A65 File Offset: 0x00157C65
	public void OnMatrixHover(int curIndex, string value)
	{
		GolemHackingCodeKeyItem layoutItemByIndex = this.Layout.GetLayoutItemByIndex(curIndex);
		if (layoutItemByIndex == null)
		{
			return;
		}
		layoutItemByIndex.OnMatrixHover(value);
	}

	// Token: 0x06003D21 RID: 15649 RVA: 0x00159A80 File Offset: 0x00157C80
	public void OnMatrixUnHover()
	{
		foreach (GolemHackingCodeKeyItem golemHackingCodeKeyItem in this.Layout.GetLayoutItemList())
		{
			golemHackingCodeKeyItem.OnMatrixUnHover();
		}
	}

	// Token: 0x0400313F RID: 12607
	protected GolemHackingGameProxy Proxy;

	// Token: 0x04003140 RID: 12608
	protected GenericLayout<GolemHackingCodeKeyItem, GolemHackingCodeGridInfo> Layout;

	// Token: 0x020067A0 RID: 26528
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04022341 RID: 140097
		PanelKeyGroup,
		// Token: 0x04022342 RID: 140098
		BtnCodeKey
	}
}
