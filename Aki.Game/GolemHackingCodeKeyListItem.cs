using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001012 RID: 4114
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class GolemHackingCodeKeyListItem : GridProxyAbstract<List<GolemHackingCodeGridInfo>>
{
	// Token: 0x06006986 RID: 27014 RVA: 0x00151082 File Offset: 0x0014F282
	public GolemHackingCodeKeyListItem(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06006987 RID: 27015 RVA: 0x00151094 File Offset: 0x0014F294
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

	// Token: 0x06006988 RID: 27016 RVA: 0x001510FD File Offset: 0x0014F2FD
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<GolemHackingCodeKeyItem, GolemHackingCodeGridInfo>(base.GetHorizontalLayout(0), new Func<GolemHackingCodeKeyItem>(this.CreateItem), null, false, true);
	}

	// Token: 0x06006989 RID: 27017 RVA: 0x00151120 File Offset: 0x0014F320
	public override void Refresh(List<GolemHackingCodeGridInfo> data, bool isSelected, int gridIndex)
	{
		this.Layout.RefreshByData(data, null, false);
	}

	// Token: 0x0600698A RID: 27018 RVA: 0x00151130 File Offset: 0x0014F330
	private GolemHackingCodeKeyItem CreateItem()
	{
		return new GolemHackingCodeKeyItem(this.Proxy);
	}

	// Token: 0x0600698B RID: 27019 RVA: 0x0015113D File Offset: 0x0014F33D
	public void OnMatrixHover(int curIndex, string value)
	{
		GolemHackingCodeKeyItem layoutItemByIndex = this.Layout.GetLayoutItemByIndex(curIndex);
		if (layoutItemByIndex == null)
		{
			return;
		}
		layoutItemByIndex.OnMatrixHover(value);
	}

	// Token: 0x0600698C RID: 27020 RVA: 0x00151158 File Offset: 0x0014F358
	public void OnMatrixUnHover()
	{
		foreach (GolemHackingCodeKeyItem golemHackingCodeKeyItem in this.Layout.GetLayoutItemList())
		{
			golemHackingCodeKeyItem.OnMatrixUnHover();
		}
	}

	// Token: 0x040030A6 RID: 12454
	protected GolemHackingGameProxy Proxy;

	// Token: 0x040030A7 RID: 12455
	protected GenericLayout<GolemHackingCodeKeyItem, GolemHackingCodeGridInfo> Layout;

	// Token: 0x0200760C RID: 30220
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026FF6 RID: 159734
		PanelKeyGroup,
		// Token: 0x04026FF7 RID: 159735
		BtnCodeKey
	}
}
