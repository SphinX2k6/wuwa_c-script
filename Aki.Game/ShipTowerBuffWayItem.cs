using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F1C RID: 7964
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerBuffWayItem : GridProxyAbstract<IGetWayItemData>
{
	// Token: 0x06013B86 RID: 80774 RVA: 0x005C11B8 File Offset: 0x005BF3B8
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

	// Token: 0x06013B87 RID: 80775 RVA: 0x005C121F File Offset: 0x005BF41F
	[NullableContext(1)]
	public override void Refresh(IGetWayItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(1).SetText(this.ItemData.Text, true);
	}

	// Token: 0x06013B88 RID: 80776 RVA: 0x005C1240 File Offset: 0x005BF440
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

	// Token: 0x0400A89B RID: 43163
	[Nullable(2)]
	private IGetWayItemData ItemData;

	// Token: 0x020081F3 RID: 33267
	private static class EChildType
	{
		// Token: 0x04029F81 RID: 171905
		public const int BtnWay = 0;

		// Token: 0x04029F82 RID: 171906
		public const int TxtWay = 1;
	}
}
