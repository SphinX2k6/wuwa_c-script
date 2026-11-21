using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F15 RID: 3861
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssRewardItem : GridProxyAbstract<IActivityRewardData>
{
	// Token: 0x06009A80 RID: 39552 RVA: 0x002DD338 File Offset: 0x002DB538
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

	// Token: 0x06009A81 RID: 39553 RVA: 0x002DD4E8 File Offset: 0x002DB6E8
	protected override void OnStart()
	{
		this.ItemLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(7), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
	}

	// Token: 0x06009A82 RID: 39554 RVA: 0x002DD50B File Offset: 0x002DB70B
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06009A83 RID: 39555 RVA: 0x002DD512 File Offset: 0x002DB712
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

	// Token: 0x06009A84 RID: 39556 RVA: 0x002DD530 File Offset: 0x002DB730
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
			itemLayout.RefreshByData(data.RewardList, null, false);
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

	// Token: 0x04005C43 RID: 23619
	[Nullable(2)]
	private IActivityRewardData RewardData;

	// Token: 0x04005C44 RID: 23620
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x0200712F RID: 28975
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024DF9 RID: 151033
		public const int BgSprite = 0;

		// Token: 0x04024DFA RID: 151034
		public const int ReDotItem = 1;

		// Token: 0x04024DFB RID: 151035
		public const int Button = 2;

		// Token: 0x04024DFC RID: 151036
		public const int DoingItem = 3;

		// Token: 0x04024DFD RID: 151037
		public const int ClaimedItem = 4;

		// Token: 0x04024DFE RID: 151038
		public const int NameText = 5;

		// Token: 0x04024DFF RID: 151039
		public const int ProgressText = 6;

		// Token: 0x04024E00 RID: 151040
		public const int RewardLayout = 7;

		// Token: 0x04024E01 RID: 151041
		public const int RewardItem = 8;

		// Token: 0x04024E02 RID: 151042
		public const int MaskItem = 9;
	}
}
