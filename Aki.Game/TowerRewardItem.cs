using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200217F RID: 8575
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerRewardItem : GridProxyAbstract<TowerReward>
{
	// Token: 0x060150A3 RID: 86179 RVA: 0x006221F4 File Offset: 0x006203F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRewardButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060150A4 RID: 86180 RVA: 0x0062231E File Offset: 0x0062051E
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, null);
	}

	// Token: 0x060150A5 RID: 86181 RVA: 0x00622341 File Offset: 0x00620541
	protected override void OnBeforeDestroy()
	{
		this.RewardScrollView = null;
	}

	// Token: 0x060150A6 RID: 86182 RVA: 0x0062234C File Offset: 0x0062054C
	public override void Refresh(TowerReward data, bool isSelected, int gridIndex)
	{
		this.RewardReceived = data.IsReceived.GetValueOrDefault();
		this.RewardIndex = data.Index;
		List<TItem> challengeRewards = this.GetChallengeRewards(data.RewardId);
		this.RewardScrollView.RefreshByData(challengeRewards, delegate
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardScrollView.GetScrollItemList())
			{
				commonItemSmallItemGrid.SetReceivedVisible(this.RewardReceived);
			}
		}, false);
		int difficultyMaxStars = TowerModel.Instance.GetDifficultyMaxStars(TowerModel.Instance.CurrentSelectDifficulties, false);
		base.GetText(1).SetText(data.Target.ToString(), true);
		base.GetItem(3).SetUIActive(this.RewardReceived);
		base.GetItem(4).SetUIActive(difficultyMaxStars < data.Target);
		base.GetItem(5).SetUIActive(difficultyMaxStars >= data.Target && !this.RewardReceived);
	}

	// Token: 0x060150A7 RID: 86183 RVA: 0x00622412 File Offset: 0x00620612
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060150A8 RID: 86184 RVA: 0x0062241C File Offset: 0x0062061C
	private List<TItem> GetChallengeRewards(int dropId)
	{
		DropPackage? dropPackage;
		Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060150A9 RID: 86185 RVA: 0x006224B4 File Offset: 0x006206B4
	private void OnClickRewardButton()
	{
		int currentSelectDifficulties = TowerModel.Instance.CurrentSelectDifficulties;
		int getReachedStars = TowerModel.Instance.GetDifficultyMaxStars(currentSelectDifficulties, false);
		List<TowerReward> difficultyReward = TowerModel.Instance.GetDifficultyReward(currentSelectDifficulties);
		List<TowerReward> list = (difficultyReward != null) ? difficultyReward.FindAll(delegate(TowerReward item)
		{
			bool? isReceived = item.IsReceived;
			bool flag = false;
			return (isReceived.GetValueOrDefault() == flag & isReceived != null) && getReachedStars >= item.Target;
		}) : null;
		List<int> list2;
		if (list == null)
		{
			list2 = null;
		}
		else
		{
			list2 = list.ConvertAll<int>((TowerReward item) => item.Index);
		}
		List<int> rewardIndexList = list2 ?? new List<int>();
		TowerController.Instance.TowerRewardRequest(currentSelectDifficulties, this.RewardIndex, rewardIndexList);
		base.GetItem(3).SetUIActive(true);
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x0400B314 RID: 45844
	private bool RewardReceived;

	// Token: 0x0400B315 RID: 45845
	private int RewardIndex;

	// Token: 0x0400B316 RID: 45846
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x0200840F RID: 33807
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A9CA RID: 174538
		ScrollView,
		// Token: 0x0402A9CB RID: 174539
		TitleText,
		// Token: 0x0402A9CC RID: 174540
		RewardButton,
		// Token: 0x0402A9CD RID: 174541
		ReceivedItem,
		// Token: 0x0402A9CE RID: 174542
		NotReachedItem,
		// Token: 0x0402A9CF RID: 174543
		NotReceivedItem
	}
}
