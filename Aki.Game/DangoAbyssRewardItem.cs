using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A56 RID: 6742
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssRewardItem : GridProxyAbstract<IActivityRewardData>
{
	// Token: 0x0600C670 RID: 50800 RVA: 0x002D2224 File Offset: 0x002D0424
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C671 RID: 50801 RVA: 0x002D23D4 File Offset: 0x002D05D4
	protected override void OnStart()
	{
		this.ItemLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(7), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
	}

	// Token: 0x0600C672 RID: 50802 RVA: 0x002D23F7 File Offset: 0x002D05F7
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600C673 RID: 50803 RVA: 0x002D23FE File Offset: 0x002D05FE
	private void OnClickButton()
	{
		IActivityRewardData rewardData = this.RewardData;
		if (rewardData == null)
		{
			return;
		}
		Action clickFunction = rewardData.ClickFunction;
		if (clickFunction == null)
		{
			return;
		}
		clickFunction();
	}

	// Token: 0x0600C674 RID: 50804 RVA: 0x002D241C File Offset: 0x002D061C
	public override void Refresh(IActivityRewardData data, bool isSelected, int gridIndex)
	{
		this.RewardData = data;
		if (data.NameTextArgs != null)
		{
			base.GetText(6).SetText(data.NameTextArgs[0] + "/" + data.NameTextArgs[1], true);
			base.GetText(5).SetText(data.NameText ?? "", true);
		}
		base.GetButton(2).RootUIComp.Get().SetUIActive(data.RewardState == EActivityRewardState.Enable);
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(data.RewardState == EActivityRewardState.Disabled);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(data.RewardState == EActivityRewardState.Claimed);
		}
		UUIItem item3 = base.GetItem(1);
		if (item3 != null)
		{
			item3.SetUIActive(data.RewardButtonRedDot.GetValueOrDefault());
		}
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
		if (itemLayout != null)
		{
			itemLayout.RefreshByData(data.RewardList.ToList<TItem>(), null, false);
		}
		string resourceId = (data.RewardState != EActivityRewardState.Claimed) ? "SP_ItemBgNor" : "SP_ItemBgFinish";
		string path = UiResourceConfig.Instance.GetResourceConfig(resourceId).Value.Path;
		this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		UUIItem item4 = base.GetItem(9);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(data.RewardState == EActivityRewardState.Claimed);
	}

	// Token: 0x04005B74 RID: 23412
	[Nullable(2)]
	private IActivityRewardData RewardData;

	// Token: 0x04005B75 RID: 23413
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x02007FA0 RID: 32672
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029ABC RID: 170684
		public const int BgSprite = 0;

		// Token: 0x04029ABD RID: 170685
		public const int ReDotItem = 1;

		// Token: 0x04029ABE RID: 170686
		public const int Button = 2;

		// Token: 0x04029ABF RID: 170687
		public const int DoingItem = 3;

		// Token: 0x04029AC0 RID: 170688
		public const int ClaimedItem = 4;

		// Token: 0x04029AC1 RID: 170689
		public const int NameText = 5;

		// Token: 0x04029AC2 RID: 170690
		public const int ProgressText = 6;

		// Token: 0x04029AC3 RID: 170691
		public const int RewardLayout = 7;

		// Token: 0x04029AC4 RID: 170692
		public const int RewardItem = 8;

		// Token: 0x04029AC5 RID: 170693
		public const int MaskItem = 9;
	}
}
