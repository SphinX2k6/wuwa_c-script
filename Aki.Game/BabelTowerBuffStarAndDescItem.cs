using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005D1 RID: 1489
public class BabelTowerBuffStarAndDescItem : UiPanelBase
{
	// Token: 0x06004639 RID: 17977 RVA: 0x00180E7C File Offset: 0x0017F07C
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

	// Token: 0x0600463A RID: 17978 RVA: 0x00180EE5 File Offset: 0x0017F0E5
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

	// Token: 0x02006878 RID: 26744
	private class EComponents
	{
		// Token: 0x04022700 RID: 141056
		public const int StarNumText = 0;

		// Token: 0x04022701 RID: 141057
		public const int DescText = 1;
	}
}
