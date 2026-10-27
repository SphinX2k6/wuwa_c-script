using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BEF RID: 11247
public class TowerElementLayoutItem : UiPanelBase
{
	// Token: 0x060175B9 RID: 95673 RVA: 0x005F0DF8 File Offset: 0x005EEFF8
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

	// Token: 0x060175BA RID: 95674 RVA: 0x005F0E61 File Offset: 0x005EF061
	protected override void OnStart()
	{
		this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(0), new Func<TowerElementItem>(this.InitElementItem), null, false, true);
	}

	// Token: 0x060175BB RID: 95675 RVA: 0x005F0E84 File Offset: 0x005EF084
	[NullableContext(1)]
	public void Refresh(int[] recommendElement)
	{
		bool uiActive = recommendElement != null && recommendElement.Length != 0;
		base.SetUiActive(uiActive);
		this.ElementLayout.RefreshByData(recommendElement, null, false);
	}

	// Token: 0x060175BC RID: 95676 RVA: 0x005F0EB2 File Offset: 0x005EF0B2
	[NullableContext(1)]
	private TowerElementItem InitElementItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x060175BD RID: 95677 RVA: 0x005F0EB9 File Offset: 0x005EF0B9
	protected override void OnBeforeDestroy()
	{
		this.ElementLayout = null;
	}

	// Token: 0x0400AECD RID: 44749
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementLayout;

	// Token: 0x020091AC RID: 37292
	private enum EChildType
	{
		// Token: 0x0402F21C RID: 193052
		ElementLayout,
		// Token: 0x0402F21D RID: 193053
		ElementItem
	}
}
