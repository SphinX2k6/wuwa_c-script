using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200088C RID: 2188
[NullableContext(1)]
[Nullable(0)]
public class NoviceJourneyItem : GridProxyAbstract<NewbieCourse>
{
	// Token: 0x060062F9 RID: 25337 RVA: 0x001F861C File Offset: 0x001F681C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
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
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.RequestReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060062FA RID: 25338 RVA: 0x001F87AC File Offset: 0x001F69AC
	private void RequestReward()
	{
		if (this.CurrentState == NoviceJourneyDefine.EItemState.Unaccomplished)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("NewbieCourse_LevelTips", Array.Empty<object>());
			return;
		}
		if (this.CurrentState == NoviceJourneyDefine.EItemState.CanReceive)
		{
			(ActivityManager.GetActivityController(this.ActivityData.Type) as ActivityNoviceJourneyController).RequestReward(this.Config.Value.Id);
			foreach (RewardGridItem rewardGridItem in this.RewardItemList)
			{
				rewardGridItem.SetReceivableVisible(false);
			}
		}
	}

	// Token: 0x060062FB RID: 25339 RVA: 0x001F8854 File Offset: 0x001F6A54
	private UniTask CreateRewardItem(AActor itemActor)
	{
		NoviceJourneyItem.<CreateRewardItem>d__8 <CreateRewardItem>d__;
		<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRewardItem>d__.<>4__this = this;
		<CreateRewardItem>d__.itemActor = itemActor;
		<CreateRewardItem>d__.<>1__state = -1;
		<CreateRewardItem>d__.<>t__builder.Start<NoviceJourneyItem.<CreateRewardItem>d__8>(ref <CreateRewardItem>d__);
		return <CreateRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x060062FC RID: 25340 RVA: 0x001F88A0 File Offset: 0x001F6AA0
	private void HandleRewardItemClick(MediumItemGridExtendCallback parameter)
	{
		if (this.CurrentState != NoviceJourneyDefine.EItemState.CanReceive)
		{
			IItemData itemData = parameter.Data as IItemData;
			ItemController.Instance.OpenItemTipsByItemId(itemData.ItemId, true, null, false);
			return;
		}
		(ActivityManager.GetActivityController(this.ActivityData.Type) as ActivityNoviceJourneyController).RequestReward(this.Config.Value.Id);
	}

	// Token: 0x060062FD RID: 25341 RVA: 0x001F8904 File Offset: 0x001F6B04
	protected override UniTask OnBeforeStartAsync()
	{
		NoviceJourneyItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NoviceJourneyItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060062FE RID: 25342 RVA: 0x001F8948 File Offset: 0x001F6B48
	protected override void OnStart()
	{
		this.StateMap.Add(NoviceJourneyDefine.EItemState.Unaccomplished, new Action(this.HandleUnaccomplished));
		this.StateMap.Add(NoviceJourneyDefine.EItemState.CanReceive, new Action(this.HandleCanReceive));
		this.StateMap.Add(NoviceJourneyDefine.EItemState.HasReceived, new Action(this.HandleHasReceived));
	}

	// Token: 0x060062FF RID: 25343 RVA: 0x001F89A0 File Offset: 0x001F6BA0
	protected override void OnBeforeDestroy()
	{
		foreach (RewardGridItem child in this.RewardItemList)
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06006300 RID: 25344 RVA: 0x001F89F4 File Offset: 0x001F6BF4
	private void HandleUnaccomplished()
	{
		base.GetItem(5).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		foreach (RewardGridItem rewardGridItem in this.RewardItemList)
		{
			rewardGridItem.SetLockVisible(true);
		}
	}

	// Token: 0x06006301 RID: 25345 RVA: 0x001F8A7C File Offset: 0x001F6C7C
	private void HandleCanReceive()
	{
		base.GetItem(5).SetUIActive(true);
		base.GetItem(7).SetUIActive(true);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		base.GetText(6).SetText(this.Config.Value.Id.ToString(), true);
		foreach (RewardGridItem rewardGridItem in this.RewardItemList)
		{
			rewardGridItem.SetReceivableVisible(true);
		}
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x001F8B2C File Offset: 0x001F6D2C
	private void HandleHasReceived()
	{
		base.GetItem(5).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(4).SetUIActive(true);
		base.GetItem(8).SetUIActive(true);
		foreach (RewardGridItem rewardGridItem in this.RewardItemList)
		{
			rewardGridItem.SetReceivedVisible(true);
		}
	}

	// Token: 0x06006303 RID: 25347 RVA: 0x001F8BB4 File Offset: 0x001F6DB4
	public void SetActivityData(ActivityNoviceJourneyData activityData)
	{
		this.ActivityData = activityData;
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x001F8BC0 File Offset: 0x001F6DC0
	public override void Refresh(NewbieCourse config, bool isSelected, int gridIndex)
	{
		this.Config = new NewbieCourse?(config);
		base.GetText(0).SetText(config.Id.ToString(), true);
		IItemData[] rewardList = ActivityNoviceJourneyConfig.Instance.GetRewardList(this.Config.Value.Reward);
		int i = 0;
		int count = this.RewardItemList.Count;
		while (i < count)
		{
			RewardGridItem rewardGridItem = this.RewardItemList[i];
			if (i < rewardList.Length)
			{
				rewardGridItem.RefreshByData(rewardList[i]);
			}
			else
			{
				rewardGridItem.SetActive(false);
			}
			i++;
		}
		this.RefreshCurrentState();
	}

	// Token: 0x06006305 RID: 25349 RVA: 0x001F8C5C File Offset: 0x001F6E5C
	public void RefreshCurrentState()
	{
		this.CurrentState = this.ActivityData.GetRewardStateByLevel(this.Config.Value.Id);
		this.StateMap[this.CurrentState]();
	}

	// Token: 0x06006306 RID: 25350 RVA: 0x001F8CA4 File Offset: 0x001F6EA4
	public override object GetKey(NewbieCourse data, int displayIndex)
	{
		return this.Config.Value.Id;
	}

	// Token: 0x04004006 RID: 16390
	private readonly Dictionary<NoviceJourneyDefine.EItemState, Action> StateMap = new Dictionary<NoviceJourneyDefine.EItemState, Action>();

	// Token: 0x04004007 RID: 16391
	private NoviceJourneyDefine.EItemState CurrentState;

	// Token: 0x04004008 RID: 16392
	private readonly List<RewardGridItem> RewardItemList = new List<RewardGridItem>();

	// Token: 0x04004009 RID: 16393
	private NewbieCourse? Config;

	// Token: 0x0400400A RID: 16394
	[Nullable(2)]
	private ActivityNoviceJourneyData ActivityData;

	// Token: 0x02006BDB RID: 27611
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402374D RID: 145229
		public const int LevelText = 0;

		// Token: 0x0402374E RID: 145230
		public const int RewardItem1 = 1;

		// Token: 0x0402374F RID: 145231
		public const int RewardItem2 = 2;

		// Token: 0x04023750 RID: 145232
		public const int Button = 3;

		// Token: 0x04023751 RID: 145233
		public const int ReceivedItem = 4;

		// Token: 0x04023752 RID: 145234
		public const int CanReceiveItem = 5;

		// Token: 0x04023753 RID: 145235
		public const int CanReceiveLevelText = 6;

		// Token: 0x04023754 RID: 145236
		public const int SpriteReward = 7;

		// Token: 0x04023755 RID: 145237
		public const int ReceivedItem2 = 8;
	}
}
