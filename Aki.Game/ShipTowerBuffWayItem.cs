using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029A1 RID: 10657
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerBuffWayItem : GridProxyAbstract<IGetWayItemData>
{
	// Token: 0x06016180 RID: 90496 RVA: 0x005961F8 File Offset: 0x005943F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnWayClick))
		};
	}

	// Token: 0x06016181 RID: 90497 RVA: 0x0059625F File Offset: 0x0059445F
	[NullableContext(1)]
	public override void Refresh(IGetWayItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(1).SetText(this.ItemData.Text, true);
	}

	// Token: 0x06016182 RID: 90498 RVA: 0x00596280 File Offset: 0x00594480
	private void OnBtnWayClick()
	{
		IGetWayItemData itemData = this.ItemData;
		if (itemData == null)
		{
			return;
		}
		Action function = itemData.Function;
		if (function == null)
		{
			return;
		}
		function();
	}

	// Token: 0x0400A4B1 RID: 42161
	[Nullable(2)]
	private IGetWayItemData ItemData;

	// Token: 0x02008FAA RID: 36778
	private static class EChildType
	{
		// Token: 0x0402E882 RID: 190594
		public const int BtnWay = 0;

		// Token: 0x0402E883 RID: 190595
		public const int TxtWay = 1;
	}
}
