using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001891 RID: 6289
[Nullable(new byte[]
{
	0,
	1
})]
public class WeekCardRewardGrid : GridProxyAbstract<IWeekRewardData>
{
	// Token: 0x0600F8D6 RID: 63702 RVA: 0x0048C420 File Offset: 0x0048A620
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

	// Token: 0x0600F8D7 RID: 63703 RVA: 0x0048C4E8 File Offset: 0x0048A6E8
	[NullableContext(1)]
	public void Refresh(IWeekRewardData rewardData)
	{
		this.ItemId = rewardData.ItemId;
		base.SetItemIcon(base.GetTexture(1), rewardData.ItemId, null, null);
		base.GetText(2).SetText(rewardData.Count.ToString(), true);
	}

	// Token: 0x0600F8D8 RID: 63704 RVA: 0x0048C539 File Offset: 0x0048A739
	[NullableContext(2)]
	public override void Refresh(IWeekRewardData data, bool isSelected, int gridIndex)
	{
		if (data != null)
		{
			this.Refresh(data);
		}
	}

	// Token: 0x0600F8D9 RID: 63705 RVA: 0x0048C545 File Offset: 0x0048A745
	private void OnClickReward()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
	}

	// Token: 0x04008B2E RID: 35630
	private int ItemId;

	// Token: 0x02007AD1 RID: 31441
	private class EComponent
	{
		// Token: 0x04027D23 RID: 163107
		public const int BtnReward = 0;

		// Token: 0x04027D24 RID: 163108
		public const int TextureReward = 1;

		// Token: 0x04027D25 RID: 163109
		public const int TextCount = 2;
	}
}
