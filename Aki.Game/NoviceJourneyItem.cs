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

// Token: 0x020013D8 RID: 5080
[NullableContext(1)]
[Nullable(0)]
public class NoviceJourneyItem : GridProxyAbstract<NewbieCourse>
{
	// Token: 0x06008F64 RID: 36708 RVA: 0x001EFAE4 File Offset: 0x001EDCE4
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

	// Token: 0x06008F65 RID: 36709 RVA: 0x001EFC74 File Offset: 0x001EDE74
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

	// Token: 0x06008F66 RID: 36710 RVA: 0x001EFD1C File Offset: 0x001EDF1C
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

	// Token: 0x06008F67 RID: 36711 RVA: 0x001EFD68 File Offset: 0x001EDF68
	private void HandleRewardItemClick(MediumItemGridExtendCallback parameter)
	{
		if (this.CurrentState != NoviceJourneyDefine.EItemState.CanReceive)
		{
			IItemData itemData = parameter.Data as IItemData;
			ItemController.Instance.OpenItemTipsByItemId(itemData.ItemId, true, null);
			return;
		}
		(ActivityManager.GetActivityController(this.ActivityData.Type) as ActivityNoviceJourneyController).RequestReward(this.Config.Value.Id);
	}

	// Token: 0x06008F68 RID: 36712 RVA: 0x001EFDCC File Offset: 0x001EDFCC
	protected override UniTask OnBeforeStartAsync()
	{
		NoviceJourneyItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NoviceJourneyItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F69 RID: 36713 RVA: 0x001EFE10 File Offset: 0x001EE010
	protected override void OnStart()
	{
		this.StateMap.Add(NoviceJourneyDefine.EItemState.Unaccomplished, new Action(this.HandleUnaccomplished));
		this.StateMap.Add(NoviceJourneyDefine.EItemState.CanReceive, new Action(this.HandleCanReceive));
		this.StateMap.Add(NoviceJourneyDefine.EItemState.HasReceived, new Action(this.HandleHasReceived));
	}

	// Token: 0x06008F6A RID: 36714 RVA: 0x001EFE68 File Offset: 0x001EE068
	protected override void OnBeforeDestroy()
	{
		foreach (RewardGridItem child in this.RewardItemList)
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06008F6B RID: 36715 RVA: 0x001EFEBC File Offset: 0x001EE0BC
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

	// Token: 0x06008F6C RID: 36716 RVA: 0x001EFF44 File Offset: 0x001EE144
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

	// Token: 0x06008F6D RID: 36717 RVA: 0x001EFFF4 File Offset: 0x001EE1F4
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

	// Token: 0x06008F6E RID: 36718 RVA: 0x001F007C File Offset: 0x001EE27C
	public void SetActivityData(ActivityNoviceJourneyData activityData)
	{
		this.ActivityData = activityData;
	}

	// Token: 0x06008F6F RID: 36719 RVA: 0x001F0088 File Offset: 0x001EE288
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

	// Token: 0x06008F70 RID: 36720 RVA: 0x001F0124 File Offset: 0x001EE324
	public void RefreshCurrentState()
	{
		this.CurrentState = this.ActivityData.GetRewardStateByLevel(this.Config.Value.Id);
		this.StateMap[this.CurrentState]();
	}

	// Token: 0x06008F71 RID: 36721 RVA: 0x001F016C File Offset: 0x001EE36C
	public override object GetKey(NewbieCourse data, int displayIndex)
	{
		return this.Config.Value.Id;
	}

	// Token: 0x04003F6E RID: 16238
	private readonly Dictionary<NoviceJourneyDefine.EItemState, Action> StateMap = new Dictionary<NoviceJourneyDefine.EItemState, Action>();

	// Token: 0x04003F6F RID: 16239
	private NoviceJourneyDefine.EItemState CurrentState;

	// Token: 0x04003F70 RID: 16240
	private readonly List<RewardGridItem> RewardItemList = new List<RewardGridItem>();

	// Token: 0x04003F71 RID: 16241
	private NewbieCourse? Config;

	// Token: 0x04003F72 RID: 16242
	[Nullable(2)]
	private ActivityNoviceJourneyData ActivityData;

	// Token: 0x02007A55 RID: 31317
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028430 RID: 164912
		public const int LevelText = 0;

		// Token: 0x04028431 RID: 164913
		public const int RewardItem1 = 1;

		// Token: 0x04028432 RID: 164914
		public const int RewardItem2 = 2;

		// Token: 0x04028433 RID: 164915
		public const int Button = 3;

		// Token: 0x04028434 RID: 164916
		public const int ReceivedItem = 4;

		// Token: 0x04028435 RID: 164917
		public const int CanReceiveItem = 5;

		// Token: 0x04028436 RID: 164918
		public const int CanReceiveLevelText = 6;

		// Token: 0x04028437 RID: 164919
		public const int SpriteReward = 7;

		// Token: 0x04028438 RID: 164920
		public const int ReceivedItem2 = 8;
	}
}
