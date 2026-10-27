using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001212 RID: 4626
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewDailyAdventure : ActivitySubViewBase
{
	// Token: 0x06007BD7 RID: 31703 RVA: 0x001A200C File Offset: 0x001A020C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007BD8 RID: 31704 RVA: 0x001A2229 File Offset: 0x001A0429
	protected override void OnSetData()
	{
		this.DailyAdventureData = (this.ActivityBaseData as ActivityDailyAdventureData);
		this.ProgressPoint = this.DailyAdventureData.ProgressPoint;
	}

	// Token: 0x06007BD9 RID: 31705 RVA: 0x001A2250 File Offset: 0x001A0450
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewDailyAdventure.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDailyAdventure.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007BDA RID: 31706 RVA: 0x001A2294 File Offset: 0x001A0494
	[NullableContext(1)]
	private UniTask CreateRewardItem(AActor itemActor)
	{
		ActivitySubViewDailyAdventure.<CreateRewardItem>d__11 <CreateRewardItem>d__;
		<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRewardItem>d__.<>4__this = this;
		<CreateRewardItem>d__.itemActor = itemActor;
		<CreateRewardItem>d__.<>1__state = -1;
		<CreateRewardItem>d__.<>t__builder.Start<ActivitySubViewDailyAdventure.<CreateRewardItem>d__11>(ref <CreateRewardItem>d__);
		return <CreateRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007BDB RID: 31707 RVA: 0x001A22DF File Offset: 0x001A04DF
	protected override void OnStart()
	{
		this.PanelTime = base.GetItem(5);
		this.TextTime = base.GetText(6);
		this.NiagaraProgressItem = base.GetUiNiagara(14);
		this.NiagaraProgressItem.SetUIActive(false);
		this.RefreshInfo();
	}

	// Token: 0x06007BDC RID: 31708 RVA: 0x001A231B File Offset: 0x001A051B
	protected override void OnBeforeDestroy()
	{
		this.NiagaraProgressItem.DeactivateSystem();
		this.NiagaraProgressItem.SetUIActive(false);
	}

	// Token: 0x06007BDD RID: 31709 RVA: 0x001A2334 File Offset: 0x001A0534
	[NullableContext(1)]
	private DailyAdventureTaskItem InitQuestItem()
	{
		return new DailyAdventureTaskItem();
	}

	// Token: 0x06007BDE RID: 31710 RVA: 0x001A233B File Offset: 0x001A053B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06007BDF RID: 31711 RVA: 0x001A2375 File Offset: 0x001A0575
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06007BE0 RID: 31712 RVA: 0x001A23AF File Offset: 0x001A05AF
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id == this.ActivityBaseData.Id)
		{
			this.RefreshTask();
			this.RefreshReward();
		}
	}

	// Token: 0x06007BE1 RID: 31713 RVA: 0x001A23CB File Offset: 0x001A05CB
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshTask();
		this.RefreshReward();
		this.DailyAdventureData.ReadDailyTips();
	}

	// Token: 0x06007BE2 RID: 31714 RVA: 0x001A23EC File Offset: 0x001A05EC
	private void RefreshInfo()
	{
		base.GetText(4).SetText(this.DailyAdventureData.GetTitle(), true);
		DailyAdventureActivity? activityDailyAdventureConfig = ActivityDailyAdventureConfig.Instance.GetActivityDailyAdventureConfig(this.DailyAdventureData.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), activityDailyAdventureConfig.Value.AreaTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), activityDailyAdventureConfig.Value.AreaDescription, Array.Empty<object>());
		UUITexture texture = base.GetTexture(2);
		texture.SetUIActive(false);
		base.SetTextureByPath(activityDailyAdventureConfig.Value.AreaPic, texture, null, delegate(bool _)
		{
			texture.SetUIActive(true);
		});
	}

	// Token: 0x06007BE3 RID: 31715 RVA: 0x001A24C0 File Offset: 0x001A06C0
	private void RefreshTask()
	{
		List<DailyAdventureTaskData> allTaskInfo = this.DailyAdventureData.GetAllTaskInfo();
		this.TaskLayout.RefreshByData(allTaskInfo, null, false);
	}

	// Token: 0x06007BE4 RID: 31716 RVA: 0x001A24E8 File Offset: 0x001A06E8
	private void RefreshReward()
	{
		base.GetText(7).SetText(this.DailyAdventureData.ProgressPoint.ToString(), true);
		if (this.DailyAdventureData.ProgressPoint > this.ProgressPoint)
		{
			this.NiagaraProgressItem.SetUIActive(true);
			this.NiagaraProgressItem.ActivateSystem(true);
		}
		this.ProgressPoint = this.DailyAdventureData.ProgressPoint;
		List<DailyAdventureRewardData> allPointReward = this.DailyAdventureData.GetAllPointReward();
		int num = 0;
		while (num < allPointReward.Count && num < this.RewardItemList.Count)
		{
			this.RewardItemList[num].Refresh(allPointReward[num]);
			num++;
		}
	}

	// Token: 0x06007BE5 RID: 31717 RVA: 0x001A2591 File Offset: 0x001A0791
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007BE6 RID: 31718 RVA: 0x001A259C File Offset: 0x001A079C
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.PanelTime.SetUIActive(item);
		if (item)
		{
			this.TextTime.SetText(item2, true);
		}
	}

	// Token: 0x06007BE7 RID: 31719 RVA: 0x001A25D8 File Offset: 0x001A07D8
	private void OnActivityCrossDayRefresh()
	{
		if (!this.DailyAdventureData.CheckIfInShowTime())
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DailyAdventureRefresh);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x040038BE RID: 14526
	protected ActivityDailyAdventureData DailyAdventureData;

	// Token: 0x040038BF RID: 14527
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<DailyAdventureTaskItem, DailyAdventureTaskData> TaskLayout;

	// Token: 0x040038C0 RID: 14528
	[Nullable(1)]
	protected List<DailyAdventureRewardItem> RewardItemList = new List<DailyAdventureRewardItem>();

	// Token: 0x040038C1 RID: 14529
	private UUIItem PanelTime;

	// Token: 0x040038C2 RID: 14530
	private UUIText TextTime;

	// Token: 0x040038C3 RID: 14531
	private UUINiagara NiagaraProgressItem;

	// Token: 0x040038C4 RID: 14532
	private int ProgressPoint;

	// Token: 0x020077F0 RID: 30704
	[NullableContext(0)]
	private class ESubViewComponents
	{
		// Token: 0x04027886 RID: 161926
		public const int TxtName = 0;

		// Token: 0x04027887 RID: 161927
		public const int TxtInfo = 1;

		// Token: 0x04027888 RID: 161928
		public const int TexMap = 2;

		// Token: 0x04027889 RID: 161929
		public const int PanelQuest = 3;

		// Token: 0x0402788A RID: 161930
		public const int TxtTitle = 4;

		// Token: 0x0402788B RID: 161931
		public const int PanelTime = 5;

		// Token: 0x0402788C RID: 161932
		public const int TxtTime = 6;

		// Token: 0x0402788D RID: 161933
		public const int TxtProgress = 7;

		// Token: 0x0402788E RID: 161934
		public const int PanelReward = 8;

		// Token: 0x0402788F RID: 161935
		public const int Reward1 = 9;

		// Token: 0x04027890 RID: 161936
		public const int Reward2 = 10;

		// Token: 0x04027891 RID: 161937
		public const int Reward3 = 11;

		// Token: 0x04027892 RID: 161938
		public const int Reward4 = 12;

		// Token: 0x04027893 RID: 161939
		public const int Reward5 = 13;

		// Token: 0x04027894 RID: 161940
		public const int ProgressNiagara = 14;
	}
}
