using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200095E RID: 2398
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTaskMainView : UiViewBase
{
	// Token: 0x0600695C RID: 26972 RVA: 0x0020DC56 File Offset: 0x0020BE56
	public ActivityRegressTaskMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600695D RID: 26973 RVA: 0x0020DC6C File Offset: 0x0020BE6C
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

	// Token: 0x0600695E RID: 26974 RVA: 0x0020DCF4 File Offset: 0x0020BEF4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressTaskMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressTaskMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600695F RID: 26975 RVA: 0x0020DD37 File Offset: 0x0020BF37
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshCurrentView));
	}

	// Token: 0x06006960 RID: 26976 RVA: 0x0020DD71 File Offset: 0x0020BF71
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshCurrentView));
	}

	// Token: 0x06006961 RID: 26977 RVA: 0x0020DDAC File Offset: 0x0020BFAC
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

	// Token: 0x06006962 RID: 26978 RVA: 0x0020DE0C File Offset: 0x0020C00C
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

	// Token: 0x06006963 RID: 26979 RVA: 0x0020DE47 File Offset: 0x0020C047
	protected override void OnBeforeShow()
	{
		this.RefreshTitle();
		this.RefreshCurrentView();
		this.RefreshTimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x06006964 RID: 26980 RVA: 0x0020DE84 File Offset: 0x0020C084
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x06006965 RID: 26981 RVA: 0x0020DE8C File Offset: 0x0020C08C
	protected override void OnBeforeDestroy()
	{
		this.CloseAllSubUi();
	}

	// Token: 0x06006966 RID: 26982 RVA: 0x0020DE94 File Offset: 0x0020C094
	private UniTask CreateTabs()
	{
		ActivityRegressTaskMainView.<CreateTabs>d__15 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<ActivityRegressTaskMainView.<CreateTabs>d__15>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x06006967 RID: 26983 RVA: 0x0020DED8 File Offset: 0x0020C0D8
	private CommonTabData GetCommonData(int index)
	{
		ITaskSubViewTabData taskSubViewTabData = ActivityRegressTaskDefineData.taskSubViewTabDataMap[(EActivityRegressTaskSubViewType)index];
		return new CommonTabData(UiResourceConfig.Instance.GetResourcePath(taskSubViewTabData.IconName), null, null);
	}

	// Token: 0x06006968 RID: 26984 RVA: 0x0020DF09 File Offset: 0x0020C109
	private ActivityRegressTabItemPanel ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabItemPanel();
	}

	// Token: 0x06006969 RID: 26985 RVA: 0x0020DF10 File Offset: 0x0020C110
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

	// Token: 0x0600696A RID: 26986 RVA: 0x0020DF58 File Offset: 0x0020C158
	private UniTask RefreshTabs()
	{
		ActivityRegressTaskMainView.<RefreshTabs>d__19 <RefreshTabs>d__;
		<RefreshTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabs>d__.<>4__this = this;
		<RefreshTabs>d__.<>1__state = -1;
		<RefreshTabs>d__.<>t__builder.Start<ActivityRegressTaskMainView.<RefreshTabs>d__19>(ref <RefreshTabs>d__);
		return <RefreshTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600696B RID: 26987 RVA: 0x0020DF9C File Offset: 0x0020C19C
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

	// Token: 0x0600696C RID: 26988 RVA: 0x0020DFE8 File Offset: 0x0020C1E8
	private void UpdateTitle()
	{
		ITaskSubViewTabData taskSubViewTabData = ActivityRegressTaskDefineData.taskSubViewTabDataMap[this.CurrentViewType.Value];
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(taskSubViewTabData.IconName);
		this.CaptionTabComponent.UpdateTitle(resourcePath, new CommonTabTitleData(taskSubViewTabData.TitleKey, Array.Empty<object>()));
	}

	// Token: 0x0600696D RID: 26989 RVA: 0x0020E03C File Offset: 0x0020C23C
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

	// Token: 0x0600696E RID: 26990 RVA: 0x0020E088 File Offset: 0x0020C288
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

	// Token: 0x0600696F RID: 26991 RVA: 0x0020E0D4 File Offset: 0x0020C2D4
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

	// Token: 0x06006970 RID: 26992 RVA: 0x0020E120 File Offset: 0x0020C320
	private void CloseAllSubUi()
	{
		foreach (KeyValuePair<EActivityRegressTaskSubViewType, ActivityRegressTaskSubViewBase> keyValuePair in this.ChildViewMap)
		{
			keyValuePair.Value.CloseMeAsync().Forget<bool>();
		}
		this.ChildViewMap.Clear();
	}

	// Token: 0x06006971 RID: 26993 RVA: 0x0020E188 File Offset: 0x0020C388
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

	// Token: 0x06006972 RID: 26994 RVA: 0x0020E1D7 File Offset: 0x0020C3D7
	private void OnTimerRefresh(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x06006973 RID: 26995 RVA: 0x0020E1DF File Offset: 0x0020C3DF
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x040042D2 RID: 17106
	[Nullable(2)]
	private ActivityRegressMainCaptionListPanel CaptionTabComponent;

	// Token: 0x040042D3 RID: 17107
	private EActivityRegressTaskSubViewType? CurrentViewType;

	// Token: 0x040042D4 RID: 17108
	private readonly Dictionary<EActivityRegressTaskSubViewType, ActivityRegressTaskSubViewBase> ChildViewMap = new Dictionary<EActivityRegressTaskSubViewType, ActivityRegressTaskSubViewBase>();

	// Token: 0x040042D5 RID: 17109
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x02006C59 RID: 27737
	[NullableContext(0)]
	private class EActivityRegressTaskSubViewComponents
	{
		// Token: 0x040239A6 RID: 145830
		public const int CaptionNameList = 0;

		// Token: 0x040239A7 RID: 145831
		public const int TexBg = 1;

		// Token: 0x040239A8 RID: 145832
		public const int Content = 2;

		// Token: 0x040239A9 RID: 145833
		public const int TexBg2 = 3;

		// Token: 0x040239AA RID: 145834
		public const int TxtTime = 4;
	}
}
