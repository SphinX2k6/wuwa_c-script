using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200216A RID: 8554
public class TowerElementLayoutItem : UiPanelBase
{
	// Token: 0x06014FEA RID: 85994 RVA: 0x0061D958 File Offset: 0x0061BB58
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

	// Token: 0x06014FEB RID: 85995 RVA: 0x0061D9C1 File Offset: 0x0061BBC1
	protected override void OnStart()
	{
		this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(0), new Func<TowerElementItem>(this.InitElementItem), null, false, true);
	}

	// Token: 0x06014FEC RID: 85996 RVA: 0x0061D9E4 File Offset: 0x0061BBE4
	[NullableContext(1)]
	public void Refresh(int[] recommendElement)
	{
		bool uiActive = recommendElement != null && recommendElement.Length != 0;
		base.SetUiActive(uiActive);
		this.ElementLayout.RefreshByData(recommendElement, null, false);
	}

	// Token: 0x06014FED RID: 85997 RVA: 0x0061DA12 File Offset: 0x0061BC12
	[NullableContext(1)]
	private TowerElementItem InitElementItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x06014FEE RID: 85998 RVA: 0x0061DA19 File Offset: 0x0061BC19
	protected override void OnBeforeDestroy()
	{
		this.ElementLayout = null;
	}

	// Token: 0x0400B2D2 RID: 45778
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementLayout;

	// Token: 0x020083EF RID: 33775
	private enum EChildType
	{
		// Token: 0x0402A91D RID: 174365
		ElementLayout,
		// Token: 0x0402A91E RID: 174366
		ElementItem
	}
}
