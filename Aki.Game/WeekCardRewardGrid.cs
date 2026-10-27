using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023AC RID: 9132
[Nullable(new byte[]
{
	0,
	1
})]
public class WeekCardRewardGrid : GridProxyAbstract<IWeekRewardData>
{
	// Token: 0x06012424 RID: 74788 RVA: 0x0047EF4C File Offset: 0x0047D14C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012425 RID: 74789 RVA: 0x0047F014 File Offset: 0x0047D214
	[NullableContext(1)]
	public void Refresh(IWeekRewardData rewardData)
	{
		this.ItemId = rewardData.ItemId;
		base.SetItemIcon(base.GetTexture(1), rewardData.ItemId, null, null);
		base.GetText(2).SetText(rewardData.Count.ToString(), true);
	}

	// Token: 0x06012426 RID: 74790 RVA: 0x0047F065 File Offset: 0x0047D265
	[NullableContext(2)]
	public override void Refresh(IWeekRewardData data, bool isSelected, int gridIndex)
	{
		if (data != null)
		{
			this.Refresh(data);
		}
	}

	// Token: 0x06012427 RID: 74791 RVA: 0x0047F071 File Offset: 0x0047D271
	private void OnClickReward()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
	}

	// Token: 0x040089E7 RID: 35303
	private int ItemId;

	// Token: 0x02008948 RID: 35144
	private class EComponent
	{
		// Token: 0x0402CA08 RID: 182792
		public const int BtnReward = 0;

		// Token: 0x0402CA09 RID: 182793
		public const int TextureReward = 1;

		// Token: 0x0402CA0A RID: 182794
		public const int TextCount = 2;
	}
}
