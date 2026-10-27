using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200111D RID: 4381
public class BabelTowerBuffStarAndDescItem : UiPanelBase
{
	// Token: 0x060072A3 RID: 29347 RVA: 0x001784C0 File Offset: 0x001766C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060072A4 RID: 29348 RVA: 0x00178529 File Offset: 0x00176729
	[NullableContext(1)]
	public void Refresh(string starText, bool showStar, string descTextId)
	{
		base.GetText(0).SetUIActive(showStar);
		if (showStar)
		{
			base.GetText(0).SetText(starText, true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), descTextId, Array.Empty<object>());
	}

	// Token: 0x020076E4 RID: 30436
	private class EComponents
	{
		// Token: 0x040273B7 RID: 160695
		public const int StarNumText = 0;

		// Token: 0x040273B8 RID: 160696
		public const int DescText = 1;
	}
}
