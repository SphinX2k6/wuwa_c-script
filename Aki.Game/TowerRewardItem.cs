using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002C04 RID: 11268
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerRewardItem : GridProxyAbstract<TowerReward>
{
	// Token: 0x06017672 RID: 95858 RVA: 0x005F56D0 File Offset: 0x005F38D0
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

	// Token: 0x06017673 RID: 95859 RVA: 0x005F57FA File Offset: 0x005F39FA
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, null);
	}

	// Token: 0x06017674 RID: 95860 RVA: 0x005F581D File Offset: 0x005F3A1D
	protected override void OnBeforeDestroy()
	{
		this.RewardScrollView = null;
	}

	// Token: 0x06017675 RID: 95861 RVA: 0x005F5828 File Offset: 0x005F3A28
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

	// Token: 0x06017676 RID: 95862 RVA: 0x005F58EE File Offset: 0x005F3AEE
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06017677 RID: 95863 RVA: 0x005F58F8 File Offset: 0x005F3AF8
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

	// Token: 0x06017678 RID: 95864 RVA: 0x005F5990 File Offset: 0x005F3B90
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

	// Token: 0x0400AF0F RID: 44815
	private bool RewardReceived;

	// Token: 0x0400AF10 RID: 44816
	private int RewardIndex;

	// Token: 0x0400AF11 RID: 44817
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x020091CC RID: 37324
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F2C9 RID: 193225
		ScrollView,
		// Token: 0x0402F2CA RID: 193226
		TitleText,
		// Token: 0x0402F2CB RID: 193227
		RewardButton,
		// Token: 0x0402F2CC RID: 193228
		ReceivedItem,
		// Token: 0x0402F2CD RID: 193229
		NotReachedItem,
		// Token: 0x0402F2CE RID: 193230
		NotReceivedItem
	}
}
