using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006C7 RID: 1735
[NullableContext(1)]
[Nullable(0)]
public class DailyAdventureRewardItem : UiPanelBase
{
	// Token: 0x06004F7F RID: 20351 RVA: 0x001AB298 File Offset: 0x001A9498
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.RequestReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004F80 RID: 20352 RVA: 0x001AB428 File Offset: 0x001A9628
	protected override UniTask OnBeforeStartAsync()
	{
		DailyAdventureRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DailyAdventureRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004F81 RID: 20353 RVA: 0x001AB46B File Offset: 0x001A966B
	protected override void OnBeforeDestroy()
	{
		this.RewardItemList.Clear();
	}

	// Token: 0x06004F82 RID: 20354 RVA: 0x001AB478 File Offset: 0x001A9678
	private UniTask CreateRewardItem(AActor item)
	{
		DailyAdventureRewardItem.<CreateRewardItem>d__6 <CreateRewardItem>d__;
		<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRewardItem>d__.<>4__this = this;
		<CreateRewardItem>d__.item = item;
		<CreateRewardItem>d__.<>1__state = -1;
		<CreateRewardItem>d__.<>t__builder.Start<DailyAdventureRewardItem.<CreateRewardItem>d__6>(ref <CreateRewardItem>d__);
		return <CreateRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x06004F83 RID: 20355 RVA: 0x001AB4C4 File Offset: 0x001A96C4
	private void HandleRewardItemClick(MediumItemGridExtendCallback parameter)
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.RewardState != ERewardState.FinishedAndUnClaimed)
		{
			IItemGridData itemGridData = parameter.Data as IItemGridData;
			ItemController.Instance.OpenItemTipsByItemId(itemGridData.Item.ItemData.ItemId, true, null, false);
			return;
		}
		ActivityDailyAdventureController.Instance.RequestPointReward(this.Data.RewardId);
	}

	// Token: 0x06004F84 RID: 20356 RVA: 0x001AB528 File Offset: 0x001A9728
	public void Refresh(DailyAdventureRewardData data)
	{
		this.Data = data;
		DailyAdventurePoint? dailyAdventurePointConfig = ActivityDailyAdventureConfig.Instance.GetDailyAdventurePointConfig(data.RewardId);
		if (dailyAdventurePointConfig == null)
		{
			return;
		}
		List<TItem> previewReward = this.GetPreviewReward(dailyAdventurePointConfig.Value.Drop);
		for (int i = 0; i < this.RewardItemList.Count; i++)
		{
			bool flag = previewReward.Count > i;
			DailyAdventureSmallGridItem dailyAdventureSmallGridItem = this.RewardItemList[i];
			if (flag)
			{
				ItemGridData data2 = new ItemGridData
				{
					Item = previewReward[i],
					HasClaimed = (this.Data.RewardState == ERewardState.FinishedAndClaimed)
				};
				dailyAdventureSmallGridItem.Refresh(data2, this.Data.RewardState == ERewardState.FinishedAndUnClaimed, this.Data.RewardState == ERewardState.Progress);
			}
			dailyAdventureSmallGridItem.SetActive(flag);
		}
		base.GetText(2).SetText(dailyAdventurePointConfig.Value.NeedPt.ToString(), true);
		this.RefreshState(data.RewardState);
	}

	// Token: 0x06004F85 RID: 20357 RVA: 0x001AB62C File Offset: 0x001A982C
	private void RefreshState(ERewardState state)
	{
		switch (state)
		{
		case ERewardState.FinishedAndUnClaimed:
			this.SetTextChangeColor(true);
			base.GetText(5).ShowTextNew("Text_ActivityTaskReceive_Text");
			base.GetItem(1).SetUIActive(false);
			base.GetItem(6).SetUIActive(true);
			base.GetItem(7).SetUIActive(true);
			base.GetItem(8).SetUIActive(false);
			return;
		case ERewardState.Progress:
			this.SetTextChangeColor(false);
			base.GetText(5).ShowTextNew("Text_ActivityTaskOngoing_Text");
			base.GetItem(1).SetUIActive(true);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			return;
		case ERewardState.FinishedAndClaimed:
			this.SetTextChangeColor(false);
			base.GetText(5).ShowTextNew("Text_ActivityTaskClaimed_Text");
			base.GetItem(1).SetUIActive(true);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x06004F86 RID: 20358 RVA: 0x001AB734 File Offset: 0x001A9934
	private void SetTextChangeColor(bool useChangeColor)
	{
		UUIItem text = base.GetText(5);
		FColor? fcolor = new FColor?(base.GetText(5).changeColor);
		text.SetChangeColor(useChangeColor, fcolor);
	}

	// Token: 0x06004F87 RID: 20359 RVA: 0x001AB764 File Offset: 0x001A9964
	private List<TItem> GetPreviewReward(int dropId)
	{
		DropPackage? dropPackage;
		Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
		List<TItem> list = new List<TItem>();
		if (dictionary == null)
		{
			return list;
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			TItem item = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(key, 0),
				Count = value
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06004F88 RID: 20360 RVA: 0x001AB820 File Offset: 0x001A9A20
	private void RequestReward()
	{
		if (this.Data == null || this.Data.RewardState != ERewardState.FinishedAndUnClaimed)
		{
			return;
		}
		ActivityDailyAdventureController.Instance.RequestPointReward(this.Data.RewardId);
	}

	// Token: 0x0400395E RID: 14686
	[Nullable(2)]
	protected DailyAdventureRewardData Data;

	// Token: 0x0400395F RID: 14687
	private readonly List<DailyAdventureSmallGridItem> RewardItemList = new List<DailyAdventureSmallGridItem>();

	// Token: 0x0200697F RID: 27007
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022BD1 RID: 142289
		public const int Button = 0;

		// Token: 0x04022BD2 RID: 142290
		public const int SpriteBase = 1;

		// Token: 0x04022BD3 RID: 142291
		public const int TxtNum = 2;

		// Token: 0x04022BD4 RID: 142292
		public const int Item1 = 3;

		// Token: 0x04022BD5 RID: 142293
		public const int Item2 = 4;

		// Token: 0x04022BD6 RID: 142294
		public const int TxtState = 5;

		// Token: 0x04022BD7 RID: 142295
		public const int SpriteReceive = 6;

		// Token: 0x04022BD8 RID: 142296
		public const int PanelReceive = 7;

		// Token: 0x04022BD9 RID: 142297
		public const int SpriteDone = 8;
	}
}
