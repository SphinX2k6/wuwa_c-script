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

// Token: 0x020006C6 RID: 1734
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewDailyAdventure : ActivitySubViewBase
{
	// Token: 0x06004F6D RID: 20333 RVA: 0x001AAC84 File Offset: 0x001A8E84
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

	// Token: 0x06004F6E RID: 20334 RVA: 0x001AAEA1 File Offset: 0x001A90A1
	protected override void OnSetData()
	{
		this.DailyAdventureData = (this.ActivityBaseData as ActivityDailyAdventureData);
		this.ProgressPoint = this.DailyAdventureData.ProgressPoint;
	}

	// Token: 0x06004F6F RID: 20335 RVA: 0x001AAEC8 File Offset: 0x001A90C8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewDailyAdventure.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDailyAdventure.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004F70 RID: 20336 RVA: 0x001AAF0C File Offset: 0x001A910C
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

	// Token: 0x06004F71 RID: 20337 RVA: 0x001AAF57 File Offset: 0x001A9157
	protected override void OnStart()
	{
		this.PanelTime = base.GetItem(5);
		this.TextTime = base.GetText(6);
		this.NiagaraProgressItem = base.GetUiNiagara(14);
		this.NiagaraProgressItem.SetUIActive(false);
		this.RefreshInfo();
	}

	// Token: 0x06004F72 RID: 20338 RVA: 0x001AAF93 File Offset: 0x001A9193
	protected override void OnBeforeDestroy()
	{
		this.NiagaraProgressItem.DeactivateSystem();
		this.NiagaraProgressItem.SetUIActive(false);
	}

	// Token: 0x06004F73 RID: 20339 RVA: 0x001AAFAC File Offset: 0x001A91AC
	[NullableContext(1)]
	private DailyAdventureTaskItem InitQuestItem()
	{
		return new DailyAdventureTaskItem();
	}

	// Token: 0x06004F74 RID: 20340 RVA: 0x001AAFB3 File Offset: 0x001A91B3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06004F75 RID: 20341 RVA: 0x001AAFED File Offset: 0x001A91ED
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06004F76 RID: 20342 RVA: 0x001AB027 File Offset: 0x001A9227
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id == this.ActivityBaseData.Id)
		{
			this.RefreshTask();
			this.RefreshReward();
		}
	}

	// Token: 0x06004F77 RID: 20343 RVA: 0x001AB043 File Offset: 0x001A9243
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshTask();
		this.RefreshReward();
		this.DailyAdventureData.ReadDailyTips();
	}

	// Token: 0x06004F78 RID: 20344 RVA: 0x001AB064 File Offset: 0x001A9264
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

	// Token: 0x06004F79 RID: 20345 RVA: 0x001AB138 File Offset: 0x001A9338
	private void RefreshTask()
	{
		List<DailyAdventureTaskData> allTaskInfo = this.DailyAdventureData.GetAllTaskInfo();
		this.TaskLayout.RefreshByData(allTaskInfo, null, false);
	}

	// Token: 0x06004F7A RID: 20346 RVA: 0x001AB160 File Offset: 0x001A9360
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

	// Token: 0x06004F7B RID: 20347 RVA: 0x001AB209 File Offset: 0x001A9409
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06004F7C RID: 20348 RVA: 0x001AB214 File Offset: 0x001A9414
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

	// Token: 0x06004F7D RID: 20349 RVA: 0x001AB250 File Offset: 0x001A9450
	private void OnActivityCrossDayRefresh()
	{
		if (!this.DailyAdventureData.CheckIfInShowTime())
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DailyAdventureRefresh);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x04003957 RID: 14679
	protected ActivityDailyAdventureData DailyAdventureData;

	// Token: 0x04003958 RID: 14680
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<DailyAdventureTaskItem, DailyAdventureTaskData> TaskLayout;

	// Token: 0x04003959 RID: 14681
	[Nullable(1)]
	protected List<DailyAdventureRewardItem> RewardItemList = new List<DailyAdventureRewardItem>();

	// Token: 0x0400395A RID: 14682
	private UUIItem PanelTime;

	// Token: 0x0400395B RID: 14683
	private UUIText TextTime;

	// Token: 0x0400395C RID: 14684
	private UUINiagara NiagaraProgressItem;

	// Token: 0x0400395D RID: 14685
	private int ProgressPoint;

	// Token: 0x0200697B RID: 27003
	[NullableContext(0)]
	private class ESubViewComponents
	{
		// Token: 0x04022BB7 RID: 142263
		public const int TxtName = 0;

		// Token: 0x04022BB8 RID: 142264
		public const int TxtInfo = 1;

		// Token: 0x04022BB9 RID: 142265
		public const int TexMap = 2;

		// Token: 0x04022BBA RID: 142266
		public const int PanelQuest = 3;

		// Token: 0x04022BBB RID: 142267
		public const int TxtTitle = 4;

		// Token: 0x04022BBC RID: 142268
		public const int PanelTime = 5;

		// Token: 0x04022BBD RID: 142269
		public const int TxtTime = 6;

		// Token: 0x04022BBE RID: 142270
		public const int TxtProgress = 7;

		// Token: 0x04022BBF RID: 142271
		public const int PanelReward = 8;

		// Token: 0x04022BC0 RID: 142272
		public const int Reward1 = 9;

		// Token: 0x04022BC1 RID: 142273
		public const int Reward2 = 10;

		// Token: 0x04022BC2 RID: 142274
		public const int Reward3 = 11;

		// Token: 0x04022BC3 RID: 142275
		public const int Reward4 = 12;

		// Token: 0x04022BC4 RID: 142276
		public const int Reward5 = 13;

		// Token: 0x04022BC5 RID: 142277
		public const int ProgressNiagara = 14;
	}
}
