using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014AA RID: 5290
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTaskMainView : UiViewBase
{
	// Token: 0x060095C7 RID: 38343 RVA: 0x00204CEE File Offset: 0x00202EEE
	public ActivityRegressTaskMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060095C8 RID: 38344 RVA: 0x00204D04 File Offset: 0x00202F04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x060095C9 RID: 38345 RVA: 0x00204D8C File Offset: 0x00202F8C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressTaskMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressTaskMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060095CA RID: 38346 RVA: 0x00204DCF File Offset: 0x00202FCF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshCurrentView));
	}

	// Token: 0x060095CB RID: 38347 RVA: 0x00204E09 File Offset: 0x00203009
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshCurrentView));
	}

	// Token: 0x060095CC RID: 38348 RVA: 0x00204E44 File Offset: 0x00203044
	private void OnInventoryUpdate(int configId, int count)
	{
		if (this.CurrentViewType == null)
		{
			return;
		}
		ActivityRegressTaskSubViewBase activityRegressTaskSubViewBase;
		if (this.ChildViewMap.TryGetValue(this.CurrentViewType.Value, out activityRegressTaskSubViewBase))
		{
			EActivityRegressTaskSubViewType? currentViewType = this.CurrentViewType;
			EActivityRegressTaskSubViewType eactivityRegressTaskSubViewType = EActivityRegressTaskSubViewType.MainTask;
			if ((currentViewType.GetValueOrDefault() == eactivityRegressTaskSubViewType & currentViewType != null) && configId == 20)
			{
				activityRegressTaskSubViewBase.Update();
			}
		}
	}

	// Token: 0x060095CD RID: 38349 RVA: 0x00204EA4 File Offset: 0x002030A4
	private void RefreshCurrentView()
	{
		if (this.CurrentViewType == null)
		{
			return;
		}
		ActivityRegressTaskSubViewBase activityRegressTaskSubViewBase;
		if (this.ChildViewMap.TryGetValue(this.CurrentViewType.Value, out activityRegressTaskSubViewBase))
		{
			activityRegressTaskSubViewBase.Update();
		}
	}

	// Token: 0x060095CE RID: 38350 RVA: 0x00204EDF File Offset: 0x002030DF
	protected override void OnBeforeShow()
	{
		this.RefreshTitle();
		this.RefreshCurrentView();
		this.RefreshTimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x060095CF RID: 38351 RVA: 0x00204F1C File Offset: 0x0020311C
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x060095D0 RID: 38352 RVA: 0x00204F24 File Offset: 0x00203124
	protected override void OnBeforeDestroy()
	{
		this.CloseAllSubUi();
	}

	// Token: 0x060095D1 RID: 38353 RVA: 0x00204F2C File Offset: 0x0020312C
	private UniTask CreateTabs()
	{
		ActivityRegressTaskMainView.<CreateTabs>d__15 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<ActivityRegressTaskMainView.<CreateTabs>d__15>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x060095D2 RID: 38354 RVA: 0x00204F70 File Offset: 0x00203170
	private CommonTabData GetCommonData(int index)
	{
		ITaskSubViewTabData taskSubViewTabData = ActivityRegressTaskDefineData.taskSubViewTabDataMap[(EActivityRegressTaskSubViewType)index];
		return new CommonTabData(UiResourceConfig.Instance.GetResourcePath(taskSubViewTabData.IconName), null, null);
	}

	// Token: 0x060095D3 RID: 38355 RVA: 0x00204FA1 File Offset: 0x002031A1
	private ActivityRegressTabItemPanel ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabItemPanel();
	}

	// Token: 0x060095D4 RID: 38356 RVA: 0x00204FA8 File Offset: 0x002031A8
	private void OnTabSelected(int index)
	{
		ActivityRegressTaskMainView.<>c__DisplayClass18_0 CS$<>8__locals1 = new ActivityRegressTaskMainView.<>c__DisplayClass18_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.index = index;
		UiAsyncTask task = new UiAsyncTask("ActivityRegressTaskSubViewBase.OnTabSelected", delegate()
		{
			ActivityRegressTaskMainView.<>c__DisplayClass18_0.<<OnTabSelected>b__0>d <<OnTabSelected>b__0>d;
			<<OnTabSelected>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnTabSelected>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnTabSelected>b__0>d.<>1__state = -1;
			<<OnTabSelected>b__0>d.<>t__builder.Start<ActivityRegressTaskMainView.<>c__DisplayClass18_0.<<OnTabSelected>b__0>d>(ref <<OnTabSelected>b__0>d);
			return <<OnTabSelected>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x060095D5 RID: 38357 RVA: 0x00204FF0 File Offset: 0x002031F0
	private UniTask RefreshTabs()
	{
		ActivityRegressTaskMainView.<RefreshTabs>d__19 <RefreshTabs>d__;
		<RefreshTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabs>d__.<>4__this = this;
		<RefreshTabs>d__.<>1__state = -1;
		<RefreshTabs>d__.<>t__builder.Start<ActivityRegressTaskMainView.<RefreshTabs>d__19>(ref <RefreshTabs>d__);
		return <RefreshTabs>d__.<>t__builder.Task;
	}

	// Token: 0x060095D6 RID: 38358 RVA: 0x00205034 File Offset: 0x00203234
	private UniTask ChangeSubUi(EActivityRegressTaskSubViewType viewType)
	{
		ActivityRegressTaskMainView.<ChangeSubUi>d__20 <ChangeSubUi>d__;
		<ChangeSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeSubUi>d__.<>4__this = this;
		<ChangeSubUi>d__.viewType = viewType;
		<ChangeSubUi>d__.<>1__state = -1;
		<ChangeSubUi>d__.<>t__builder.Start<ActivityRegressTaskMainView.<ChangeSubUi>d__20>(ref <ChangeSubUi>d__);
		return <ChangeSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x060095D7 RID: 38359 RVA: 0x00205080 File Offset: 0x00203280
	private void UpdateTitle()
	{
		ITaskSubViewTabData taskSubViewTabData = ActivityRegressTaskDefineData.taskSubViewTabDataMap[this.CurrentViewType.Value];
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(taskSubViewTabData.IconName);
		this.CaptionTabComponent.UpdateTitle(resourcePath, new CommonTabTitleData(taskSubViewTabData.TitleKey, Array.Empty<object>()));
	}

	// Token: 0x060095D8 RID: 38360 RVA: 0x002050D4 File Offset: 0x002032D4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ActivityRegressTaskSubViewBase> CreateSubUi(EActivityRegressTaskSubViewType viewType)
	{
		ActivityRegressTaskMainView.<CreateSubUi>d__22 <CreateSubUi>d__;
		<CreateSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder<ActivityRegressTaskSubViewBase>.Create();
		<CreateSubUi>d__.<>4__this = this;
		<CreateSubUi>d__.viewType = viewType;
		<CreateSubUi>d__.<>1__state = -1;
		<CreateSubUi>d__.<>t__builder.Start<ActivityRegressTaskMainView.<CreateSubUi>d__22>(ref <CreateSubUi>d__);
		return <CreateSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x060095D9 RID: 38361 RVA: 0x00205120 File Offset: 0x00203320
	private UniTask OpenSubUi(EActivityRegressTaskSubViewType viewType)
	{
		ActivityRegressTaskMainView.<OpenSubUi>d__23 <OpenSubUi>d__;
		<OpenSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSubUi>d__.<>4__this = this;
		<OpenSubUi>d__.viewType = viewType;
		<OpenSubUi>d__.<>1__state = -1;
		<OpenSubUi>d__.<>t__builder.Start<ActivityRegressTaskMainView.<OpenSubUi>d__23>(ref <OpenSubUi>d__);
		return <OpenSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x060095DA RID: 38362 RVA: 0x0020516C File Offset: 0x0020336C
	private UniTask HideSubUi(EActivityRegressTaskSubViewType viewType)
	{
		ActivityRegressTaskMainView.<HideSubUi>d__24 <HideSubUi>d__;
		<HideSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideSubUi>d__.<>4__this = this;
		<HideSubUi>d__.viewType = viewType;
		<HideSubUi>d__.<>1__state = -1;
		<HideSubUi>d__.<>t__builder.Start<ActivityRegressTaskMainView.<HideSubUi>d__24>(ref <HideSubUi>d__);
		return <HideSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x060095DB RID: 38363 RVA: 0x002051B8 File Offset: 0x002033B8
	private void CloseAllSubUi()
	{
		foreach (KeyValuePair<EActivityRegressTaskSubViewType, ActivityRegressTaskSubViewBase> keyValuePair in this.ChildViewMap)
		{
			keyValuePair.Value.CloseMeAsync().Forget<bool>();
		}
		this.ChildViewMap.Clear();
	}

	// Token: 0x060095DC RID: 38364 RVA: 0x00205220 File Offset: 0x00203420
	private void RefreshTitle()
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(activityData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(4).SetUIActive(item);
		if (item)
		{
			base.GetText(4).SetText(item2, true);
		}
	}

	// Token: 0x060095DD RID: 38365 RVA: 0x0020526F File Offset: 0x0020346F
	private void OnTimerRefresh(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x060095DE RID: 38366 RVA: 0x00205277 File Offset: 0x00203477
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x0400423A RID: 16954
	[Nullable(2)]
	private ActivityRegressMainCaptionListPanel CaptionTabComponent;

	// Token: 0x0400423B RID: 16955
	private EActivityRegressTaskSubViewType? CurrentViewType;

	// Token: 0x0400423C RID: 16956
	private readonly Dictionary<EActivityRegressTaskSubViewType, ActivityRegressTaskSubViewBase> ChildViewMap = new Dictionary<EActivityRegressTaskSubViewType, ActivityRegressTaskSubViewBase>();

	// Token: 0x0400423D RID: 16957
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x02007AD5 RID: 31445
	[NullableContext(0)]
	private class EActivityRegressTaskSubViewComponents
	{
		// Token: 0x0402868C RID: 165516
		public const int CaptionNameList = 0;

		// Token: 0x0402868D RID: 165517
		public const int TexBg = 1;

		// Token: 0x0402868E RID: 165518
		public const int Content = 2;

		// Token: 0x0402868F RID: 165519
		public const int TexBg2 = 3;

		// Token: 0x04028690 RID: 165520
		public const int TxtTime = 4;
	}
}
