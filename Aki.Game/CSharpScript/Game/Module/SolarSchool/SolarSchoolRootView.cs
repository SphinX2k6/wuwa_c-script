using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCommonRootView;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A35 RID: 23093
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolRootView : CommonRootViewBase<SolarSchoolRootViewModel>
	{
		// Token: 0x06038E5F RID: 233055 RVA: 0x00FEF0FC File Offset: 0x00FED2FC
		public SolarSchoolRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17006C7B RID: 27771
		// (get) Token: 0x06038E60 RID: 233056 RVA: 0x00FEF197 File Offset: 0x00FED397
		// (set) Token: 0x06038E61 RID: 233057 RVA: 0x00FEF19F File Offset: 0x00FED39F
		[Nullable(2)]
		public VisualNovelContext VisualNovelContext { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17006C7C RID: 27772
		// (get) Token: 0x06038E62 RID: 233058 RVA: 0x00FEF1A8 File Offset: 0x00FED3A8
		// (set) Token: 0x06038E63 RID: 233059 RVA: 0x00FEF1B0 File Offset: 0x00FED3B0
		[Nullable(2)]
		public VisualNovelScene Scene { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17006C7D RID: 27773
		// (get) Token: 0x06038E64 RID: 233060 RVA: 0x00FEF1B9 File Offset: 0x00FED3B9
		public SolarSchoolVisualNovelView VisualNovelView
		{
			get
			{
				return this.GetVisualNovelView();
			}
		}

		// Token: 0x17006C7E RID: 27774
		// (get) Token: 0x06038E65 RID: 233061 RVA: 0x00FEF1C4 File Offset: 0x00FED3C4
		public ECommonChildViewName? CurrentChildViewName
		{
			get
			{
				CommonChildViewBase curChildView = base.GetCurChildView();
				if (curChildView == null)
				{
					return null;
				}
				return curChildView.ViewName;
			}
		}

		// Token: 0x06038E66 RID: 233062 RVA: 0x00FEF1EA File Offset: 0x00FED3EA
		public void MarkCurrentLocationPresentFinished()
		{
			SolarSchoolLocationPanel solarSchoolLocationPanel = base.GetCurChildView() as SolarSchoolLocationPanel;
			if (solarSchoolLocationPanel == null)
			{
				return;
			}
			solarSchoolLocationPanel.MarkPresentFinished();
		}

		// Token: 0x06038E67 RID: 233063 RVA: 0x00FEF201 File Offset: 0x00FED401
		public void SetVisualNovelDateVisible(bool visible)
		{
			this.VisualNovelDateVisible = visible;
			this.ApplyDateVisible();
		}

		// Token: 0x06038E68 RID: 233064 RVA: 0x00FEF210 File Offset: 0x00FED410
		public void PushHudHide()
		{
			this.HudHideCount++;
			if (this.HudHideCount == 1)
			{
				this.ApplyHudVisible();
			}
		}

		// Token: 0x06038E69 RID: 233065 RVA: 0x00FEF22F File Offset: 0x00FED42F
		public void PopHudHide()
		{
			if (this.HudHideCount == 0)
			{
				return;
			}
			this.HudHideCount--;
			if (this.HudHideCount == 0)
			{
				this.ApplyHudVisible();
			}
		}

		// Token: 0x06038E6A RID: 233066 RVA: 0x00FEF258 File Offset: 0x00FED458
		internal UniTask PlayVisualNovelShakeAsync()
		{
			SolarSchoolRootView.<PlayVisualNovelShakeAsync>d__77 <PlayVisualNovelShakeAsync>d__;
			<PlayVisualNovelShakeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayVisualNovelShakeAsync>d__.<>4__this = this;
			<PlayVisualNovelShakeAsync>d__.<>1__state = -1;
			<PlayVisualNovelShakeAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlayVisualNovelShakeAsync>d__77>(ref <PlayVisualNovelShakeAsync>d__);
			return <PlayVisualNovelShakeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E6B RID: 233067 RVA: 0x00FEF29B File Offset: 0x00FED49B
		internal void FinishVisualNovelShake()
		{
			this.VisualNovelShakeVersion++;
			this.StopVisualNovelShake();
		}

		// Token: 0x06038E6C RID: 233068 RVA: 0x00FEF2B4 File Offset: 0x00FED4B4
		private void StopVisualNovelShake()
		{
			CustomPromise<bool> visualNovelShakePromise = this.VisualNovelShakePromise;
			this.VisualNovelShakePromise = null;
			if (visualNovelShakePromise == null)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null || !uiViewSequence.HasSequenceNameInPlaying("Shake"))
				{
					goto IL_41;
				}
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.StopSequenceByKey("Shake", true, true);
			}
			IL_41:
			if (visualNovelShakePromise == null)
			{
				return;
			}
			visualNovelShakePromise.SetResult(true);
		}

		// Token: 0x06038E6D RID: 233069 RVA: 0x00FEF30D File Offset: 0x00FED50D
		internal void SetVisualNovelPlayback(float? playbackRate, bool paused)
		{
			this.VisualNovelPlaybackRate = playbackRate;
			this.VisualNovelPaused = paused;
			if (this.RootActor == null)
			{
				return;
			}
			SolarSchoolVisualNovelView.ApplySequencePlayback(this.RootActor, playbackRate.GetValueOrDefault(1f), paused);
		}

		// Token: 0x06038E6E RID: 233070 RVA: 0x00FEF33E File Offset: 0x00FED53E
		private void OnVisualNovelSequenceStarted(string sequenceName)
		{
			if (this.VisualNovelPlaybackRate == null)
			{
				return;
			}
			SolarSchoolVisualNovelView.ApplySequencePlayback(this.RootActor, this.VisualNovelPlaybackRate.Value, this.VisualNovelPaused);
		}

		// Token: 0x06038E6F RID: 233071 RVA: 0x00FEF36C File Offset: 0x00FED56C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038E70 RID: 233072 RVA: 0x00FEF568 File Offset: 0x00FED768
		protected override void OnRegisterViewData()
		{
			this.ViewModel = new SolarSchoolRootViewModel
			{
				SetBackgroundByLocation = new Action<int, string>(this.SetActivityBackgroundByLocation),
				SetBackgroundById = new Action<int>(this.SetBackgroundByAvgBackgroundId),
				ApplyBackgroundSpine = new Action<ValueTuple<string, string>?>(this.SetBackgroundSpine),
				ApplyRootUiParams = new Action<SolarSchoolRootUiParams>(this.ApplyRootUiParams),
				ApplyInvitationTag = new Action<bool>(this.ApplyInvitationTag),
				ApplyFestivalTips = new Action<SolarSchoolFestivalTipsParams>(this.ApplyFestivalTips),
				ApplyFatiguePreview = new Action<int>(this.ApplyFatiguePreview),
				ApplyClearFatiguePreview = new Action(this.ApplyClearFatiguePreview),
				ApplyHoldFatigueUntilSettled = new Action<int>(this.ApplyHoldFatigueUntilSettled),
				ApplyLocationRole = new Action(this.ApplyLocationRole),
				SnapTimeSlotPhase = new Action<ESolarSchoolMapTimePhase>(this.SnapTimeSlotPhase),
				RefreshDate = new Action(this.RefreshDate),
				SnapTimeDisplay = new Action(this.SnapTimeDisplay),
				PlayDayTransition = new Func<ESolarSchoolTimeTransition, Action, bool>(this.PlayDayTransition),
				StopDayTransition = new Action(this.StopDayTransition),
				FocusMapOnHome = new Action(this.FocusMapOnHome),
				PushDateToNextDay = new Action(this.PushDateToNextDay),
				PlayEndingTimeTransition = new Func<VisualNovelDate, Action, bool>(this.PlayEndingTimeTransition),
				StopTimeSlotTransition = new Action(this.StopTimeSlotTransition),
				RefreshDateVisible = new Action(this.ApplyDateVisible)
			};
		}

		// Token: 0x06038E71 RID: 233073 RVA: 0x00FEF6E8 File Offset: 0x00FED8E8
		protected override void OnRegisterDefaultChildView()
		{
			this.DefaultChildViewName = new ECommonChildViewName?(ECommonChildViewName.SolarSchoolMain);
		}

		// Token: 0x06038E72 RID: 233074 RVA: 0x00FEF6F6 File Offset: 0x00FED8F6
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(3);
		}

		// Token: 0x06038E73 RID: 233075 RVA: 0x00FEF708 File Offset: 0x00FED908
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolRootView.<OnBeforeStartAsync>d__86 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolRootView.<OnBeforeStartAsync>d__86>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E74 RID: 233076 RVA: 0x00FEF74B File Offset: 0x00FED94B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnSeasonTimeChanged));
		}

		// Token: 0x06038E75 RID: 233077 RVA: 0x00FEF769 File Offset: 0x00FED969
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnSeasonTimeChanged));
		}

		// Token: 0x06038E76 RID: 233078 RVA: 0x00FEF788 File Offset: 0x00FED988
		public UniTask EnterVisualNovelAsync(VisualNovelContext context)
		{
			SolarSchoolRootView.<EnterVisualNovelAsync>d__89 <EnterVisualNovelAsync>d__;
			<EnterVisualNovelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterVisualNovelAsync>d__.<>4__this = this;
			<EnterVisualNovelAsync>d__.context = context;
			<EnterVisualNovelAsync>d__.<>1__state = -1;
			<EnterVisualNovelAsync>d__.<>t__builder.Start<SolarSchoolRootView.<EnterVisualNovelAsync>d__89>(ref <EnterVisualNovelAsync>d__);
			return <EnterVisualNovelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E77 RID: 233079 RVA: 0x00FEF7D4 File Offset: 0x00FED9D4
		public UniTask ExitVisualNovelAsync(bool skipCloseSequence)
		{
			SolarSchoolRootView.<ExitVisualNovelAsync>d__90 <ExitVisualNovelAsync>d__;
			<ExitVisualNovelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitVisualNovelAsync>d__.<>4__this = this;
			<ExitVisualNovelAsync>d__.skipCloseSequence = skipCloseSequence;
			<ExitVisualNovelAsync>d__.<>1__state = -1;
			<ExitVisualNovelAsync>d__.<>t__builder.Start<SolarSchoolRootView.<ExitVisualNovelAsync>d__90>(ref <ExitVisualNovelAsync>d__);
			return <ExitVisualNovelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E78 RID: 233080 RVA: 0x00FEF820 File Offset: 0x00FEDA20
		public UniTask CloseVisualNovelViewAsync()
		{
			SolarSchoolRootView.<CloseVisualNovelViewAsync>d__91 <CloseVisualNovelViewAsync>d__;
			<CloseVisualNovelViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseVisualNovelViewAsync>d__.<>4__this = this;
			<CloseVisualNovelViewAsync>d__.<>1__state = -1;
			<CloseVisualNovelViewAsync>d__.<>t__builder.Start<SolarSchoolRootView.<CloseVisualNovelViewAsync>d__91>(ref <CloseVisualNovelViewAsync>d__);
			return <CloseVisualNovelViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E79 RID: 233081 RVA: 0x00FEF863 File Offset: 0x00FEDA63
		public void RefreshMapPanel()
		{
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.RefreshLocations();
		}

		// Token: 0x06038E7A RID: 233082 RVA: 0x00FEF875 File Offset: 0x00FEDA75
		public void NotifyMapAppear()
		{
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.NotifyAppear();
		}

		// Token: 0x06038E7B RID: 233083 RVA: 0x00FEF887 File Offset: 0x00FEDA87
		[NullableContext(2)]
		private SolarSchoolMapPanel GetMapPanel()
		{
			return base.GetCurChildView() as SolarSchoolMapPanel;
		}

		// Token: 0x06038E7C RID: 233084 RVA: 0x00FEF894 File Offset: 0x00FEDA94
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			CommonChildViewBase curChildView = base.GetCurChildView();
			if (curChildView == null)
			{
				return null;
			}
			return curChildView.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x06038E7D RID: 233085 RVA: 0x00FEF8A8 File Offset: 0x00FEDAA8
		private bool PlayEndingTimeTransition(VisualNovelDate date, Action onFinish)
		{
			ESolarSchoolMapTimePhase mapTimePhase = SolarSchoolTimeData.GetMapTimePhase((ESolarSchoolTimeSlot)date.PeriodId);
			SolarSchoolDateItem date2 = this.Date;
			int result2;
			bool result = ((date2 != null) ? (result2 = (date2.PlayTimeSlotTransition(mapTimePhase, onFinish) ? 1 : 0)) : (result2 = 0)) != 0;
			SolarSchoolDateItem date3 = this.Date;
			if (date3 == null)
			{
				return result2 != 0;
			}
			date3.SetDate(date.Month, date.Day, date.PeriodId);
			return result;
		}

		// Token: 0x06038E7E RID: 233086 RVA: 0x00FEF8FB File Offset: 0x00FEDAFB
		private void RefreshDate()
		{
			if (SolarSchoolGamePlayModel.Instance.GetCurrentStateType() == ESolarSchoolStageStateType.DayEnd && UiManager.Instance.IsViewOpen(EUiViewName.SolarSchoolDayChangeLoadingView))
			{
				return;
			}
			SolarSchoolDateItem date = this.Date;
			if (date == null)
			{
				return;
			}
			date.Refresh();
		}

		// Token: 0x06038E7F RID: 233087 RVA: 0x00FEF92C File Offset: 0x00FEDB2C
		private void SnapTimeDisplay()
		{
			SolarSchoolDateItem date = this.Date;
			if (date != null)
			{
				date.Refresh();
			}
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.SnapMapTimePhase(SolarSchoolGamePlayModel.Instance.TimeData.DisplayMapTimePhase);
		}

		// Token: 0x06038E80 RID: 233088 RVA: 0x00FEF95E File Offset: 0x00FEDB5E
		private void SnapTimeSlotPhase(ESolarSchoolMapTimePhase phase)
		{
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.SnapMapTimePhase(phase);
		}

		// Token: 0x06038E81 RID: 233089 RVA: 0x00FEF971 File Offset: 0x00FEDB71
		private void StopTimeSlotTransition()
		{
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel != null)
			{
				mapPanel.StopMapTimePhaseTransition();
			}
			SolarSchoolDateItem date = this.Date;
			if (date == null)
			{
				return;
			}
			date.StopTimeSlotTransition();
		}

		// Token: 0x06038E82 RID: 233090 RVA: 0x00FEF994 File Offset: 0x00FEDB94
		private string GetDayTransitionSequence(ESolarSchoolTimeTransition transitionType)
		{
			if (transitionType != ESolarSchoolTimeTransition.DayMid)
			{
				return string.Empty;
			}
			return SolarSchoolUtils.GetDayTransitionSequenceName(SolarSchoolGamePlayModel.Instance.TimeData.CurrentMapTimePhase);
		}

		// Token: 0x06038E83 RID: 233091 RVA: 0x00FEF9B4 File Offset: 0x00FEDBB4
		private bool PlayDayTransition(ESolarSchoolTimeTransition transitionType, Action onFinish)
		{
			string dayTransitionSequence = this.GetDayTransitionSequence(transitionType);
			if (string.IsNullOrEmpty(dayTransitionSequence) || this.UiViewSequence == null)
			{
				return false;
			}
			this.StopDayTransition();
			this.DayTransitionSeqName = dayTransitionSequence;
			this.DayTransitionFinish = onFinish;
			base.PlaySequence(dayTransitionSequence, null, true);
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel != null)
			{
				mapPanel.PlayDayTransitionSequence(dayTransitionSequence);
			}
			return true;
		}

		// Token: 0x06038E84 RID: 233092 RVA: 0x00FEFA0B File Offset: 0x00FEDC0B
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Date_Change")
			{
				this.PushDateToNextDay();
				return;
			}
			if (eventName == "Switch")
			{
				this.ApplyPendingSeasonFxSystem();
			}
		}

		// Token: 0x06038E85 RID: 233093 RVA: 0x00FEFA34 File Offset: 0x00FEDC34
		private void OnDayTransitionSequenceFinish(string sequenceName)
		{
			if (sequenceName != this.DayTransitionSeqName)
			{
				return;
			}
			this.DayTransitionSeqName = null;
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel != null)
			{
				mapPanel.StopDayTransitionSequence();
			}
			Action dayTransitionFinish = this.DayTransitionFinish;
			this.DayTransitionFinish = null;
			if (dayTransitionFinish == null)
			{
				return;
			}
			dayTransitionFinish();
		}

		// Token: 0x06038E86 RID: 233094 RVA: 0x00FEFA74 File Offset: 0x00FEDC74
		private void StopDayTransition()
		{
			string dayTransitionSeqName = this.DayTransitionSeqName;
			if (dayTransitionSeqName == null)
			{
				return;
			}
			this.DayTransitionSeqName = null;
			this.DayTransitionFinish = null;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey(dayTransitionSeqName, false, true);
			}
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.StopDayTransitionSequence();
		}

		// Token: 0x06038E87 RID: 233095 RVA: 0x00FEFAC0 File Offset: 0x00FEDCC0
		private void FocusMapOnHome()
		{
			SolarSchoolLocation? activityHomeLocation = SolarSchoolConfig.Instance.GetActivityHomeLocation(SolarSchoolGamePlayModel.Instance.ActivityId);
			if (activityHomeLocation == null)
			{
				return;
			}
			SolarSchoolMapPanel mapPanel = this.GetMapPanel();
			if (mapPanel == null)
			{
				return;
			}
			mapPanel.FocusOnLocation(activityHomeLocation.Value.Id, new double?(0.75), false);
		}

		// Token: 0x06038E88 RID: 233096 RVA: 0x00FEFB1A File Offset: 0x00FEDD1A
		private void PushDateToNextDay()
		{
			SolarSchoolDateItem date = this.Date;
			if (date == null)
			{
				return;
			}
			date.SetDateByDayIndexDuringDayTransition(SolarSchoolGamePlayModel.Instance.GetDayEndTargetDayIndex(), ESolarSchoolTimeSlot.Morning);
		}

		// Token: 0x06038E89 RID: 233097 RVA: 0x00FEFB38 File Offset: 0x00FEDD38
		protected override void OnBeforeDestroy()
		{
			this.HideBackgroundSpine();
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext != null)
			{
				visualNovelContext.Player.Stop();
			}
			this.FinishVisualNovelShake();
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			AUIBaseActor seasonFxActor = this.SeasonFxActor;
			if (seasonFxActor != null)
			{
				seasonFxActor.OnSequencePlayEvent.Unbind();
			}
			this.SeasonFxActor = null;
		}

		// Token: 0x06038E8A RID: 233098 RVA: 0x00FEFB9C File Offset: 0x00FEDD9C
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			SolarSchoolRootView.<OnDestroyAsyncImplementImplement>d__109 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<SolarSchoolRootView.<OnDestroyAsyncImplementImplement>d__109>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06038E8B RID: 233099 RVA: 0x00FEFBE0 File Offset: 0x00FEDDE0
		private UniTask PrepareCharactersAsync(IReadOnlyList<int> characterIds)
		{
			SolarSchoolRootView.<PrepareCharactersAsync>d__110 <PrepareCharactersAsync>d__;
			<PrepareCharactersAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareCharactersAsync>d__.<>4__this = this;
			<PrepareCharactersAsync>d__.characterIds = characterIds;
			<PrepareCharactersAsync>d__.<>1__state = -1;
			<PrepareCharactersAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PrepareCharactersAsync>d__110>(ref <PrepareCharactersAsync>d__);
			return <PrepareCharactersAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E8C RID: 233100 RVA: 0x00FEFC2C File Offset: 0x00FEDE2C
		private UniTask CreateIdleCharacterItemAsync()
		{
			SolarSchoolRootView.<CreateIdleCharacterItemAsync>d__111 <CreateIdleCharacterItemAsync>d__;
			<CreateIdleCharacterItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateIdleCharacterItemAsync>d__.<>4__this = this;
			<CreateIdleCharacterItemAsync>d__.<>1__state = -1;
			<CreateIdleCharacterItemAsync>d__.<>t__builder.Start<SolarSchoolRootView.<CreateIdleCharacterItemAsync>d__111>(ref <CreateIdleCharacterItemAsync>d__);
			return <CreateIdleCharacterItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E8D RID: 233101 RVA: 0x00FEFC70 File Offset: 0x00FEDE70
		private UniTask CreateIdleTextureCharacterItemAsync()
		{
			SolarSchoolRootView.<CreateIdleTextureCharacterItemAsync>d__112 <CreateIdleTextureCharacterItemAsync>d__;
			<CreateIdleTextureCharacterItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateIdleTextureCharacterItemAsync>d__.<>4__this = this;
			<CreateIdleTextureCharacterItemAsync>d__.<>1__state = -1;
			<CreateIdleTextureCharacterItemAsync>d__.<>t__builder.Start<SolarSchoolRootView.<CreateIdleTextureCharacterItemAsync>d__112>(ref <CreateIdleTextureCharacterItemAsync>d__);
			return <CreateIdleTextureCharacterItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E8E RID: 233102 RVA: 0x00FEFCB4 File Offset: 0x00FEDEB4
		[NullableContext(2)]
		private VisualNovelCharacter AcquireCharacter(int characterId)
		{
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext == null || visualNovelContext.IsStopped || this.WaitToDestroy || base.IsDestroyOrDestroying)
			{
				return null;
			}
			if (visualNovelContext.Assets.GetCharacterTexture(characterId) != null)
			{
				return this.AcquireTextureCharacter(visualNovelContext, characterId);
			}
			if (visualNovelContext.Assets.GetSpineAssets(characterId) == null)
			{
				return null;
			}
			if (this.IdleCharacterItems.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VisualNovel;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "AVG Spine 角色槽没有预先创建";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("characterId", characterId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SolarSchoolCharacterSpineItem solarSchoolCharacterSpineItem = this.IdleCharacterItems[this.IdleCharacterItems.Count - 1];
			this.IdleCharacterItems.RemoveAt(this.IdleCharacterItems.Count - 1);
			solarSchoolCharacterSpineItem.SetAssetCache(visualNovelContext.Assets);
			solarSchoolCharacterSpineItem.Character.SetBlinkEnabled(true);
			solarSchoolCharacterSpineItem.Character.ApplyInitialVisibility(false);
			this.SceneCharacterItems.Add(solarSchoolCharacterSpineItem);
			return solarSchoolCharacterSpineItem.Character;
		}

		// Token: 0x06038E8F RID: 233103 RVA: 0x00FEFDB4 File Offset: 0x00FEDFB4
		[return: Nullable(2)]
		private VisualNovelCharacter AcquireTextureCharacter(VisualNovelContext context, int characterId)
		{
			if (this.IdleTextureCharacterItems.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VisualNovel;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "AVG 图片角色槽没有预先创建";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("characterId", characterId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SolarSchoolCharacterTextureItem solarSchoolCharacterTextureItem = this.IdleTextureCharacterItems[this.IdleTextureCharacterItems.Count - 1];
			this.IdleTextureCharacterItems.RemoveAt(this.IdleTextureCharacterItems.Count - 1);
			solarSchoolCharacterTextureItem.SetAssetCache(context.Assets);
			this.SceneTextureCharacterItems.Add(solarSchoolCharacterTextureItem);
			return solarSchoolCharacterTextureItem.Character;
		}

		// Token: 0x06038E90 RID: 233104 RVA: 0x00FEFE50 File Offset: 0x00FEE050
		private void ApplyVisualNovelCharacterOrder(IReadOnlyList<VisualNovelCharacter> characters)
		{
			List<UUIItem> list = new List<UUIItem>(characters.Count);
			List<int> list2 = new List<int>(characters.Count);
			foreach (VisualNovelCharacter character in characters)
			{
				UUIItem visualNovelCharacterItem = this.GetVisualNovelCharacterItem(character);
				if (visualNovelCharacterItem != null)
				{
					list.Add(visualNovelCharacterItem);
					list2.Add(visualNovelCharacterItem.GetHierarchyIndex());
				}
			}
			list2.Sort();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetHierarchyIndex(list2[i]);
			}
		}

		// Token: 0x06038E91 RID: 233105 RVA: 0x00FEFEFC File Offset: 0x00FEE0FC
		[return: Nullable(2)]
		private UUIItem GetVisualNovelCharacterItem(VisualNovelCharacter character)
		{
			foreach (SolarSchoolCharacterSpineItem solarSchoolCharacterSpineItem in this.SceneCharacterItems)
			{
				if (solarSchoolCharacterSpineItem.Character == character)
				{
					return solarSchoolCharacterSpineItem.GetRootItem();
				}
			}
			foreach (SolarSchoolCharacterTextureItem solarSchoolCharacterTextureItem in this.SceneTextureCharacterItems)
			{
				if (solarSchoolCharacterTextureItem.Character == character)
				{
					return solarSchoolCharacterTextureItem.GetRootItem();
				}
			}
			return null;
		}

		// Token: 0x06038E92 RID: 233106 RVA: 0x00FEFFB0 File Offset: 0x00FEE1B0
		private UniTask ReleaseCharacterAsync(VisualNovelCharacter character)
		{
			SolarSchoolRootView.<ReleaseCharacterAsync>d__117 <ReleaseCharacterAsync>d__;
			<ReleaseCharacterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReleaseCharacterAsync>d__.<>4__this = this;
			<ReleaseCharacterAsync>d__.character = character;
			<ReleaseCharacterAsync>d__.<>1__state = -1;
			<ReleaseCharacterAsync>d__.<>t__builder.Start<SolarSchoolRootView.<ReleaseCharacterAsync>d__117>(ref <ReleaseCharacterAsync>d__);
			return <ReleaseCharacterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E93 RID: 233107 RVA: 0x00FEFFFC File Offset: 0x00FEE1FC
		private SolarSchoolVisualNovelView GetVisualNovelView()
		{
			SolarSchoolVisualNovelView solarSchoolVisualNovelView = base.GetCurChildView() as SolarSchoolVisualNovelView;
			if (solarSchoolVisualNovelView != null)
			{
				return solarSchoolVisualNovelView;
			}
			Log.Instance.Error(ELogModule.Plot, ELogAuthor.LZK, "SolarSchoolRootView 当前子页面不是视觉小说界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x06038E94 RID: 233108 RVA: 0x00FF0038 File Offset: 0x00FEE238
		internal void SetVisualNovelTime(VisualNovelDate date, bool isFullScreen)
		{
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext != null)
			{
				visualNovelContext.SetDate(date);
			}
			VisualNovelContext visualNovelContext2 = this.VisualNovelContext;
			if (visualNovelContext2 != null && visualNovelContext2.DateVisible)
			{
				SolarSchoolDateItem date2 = this.Date;
				if (date2 == null)
				{
					return;
				}
				date2.SetDate(date.Month, date.Day, date.PeriodId);
			}
		}

		// Token: 0x06038E95 RID: 233109 RVA: 0x00FF0090 File Offset: 0x00FEE290
		internal UniTask SetVisualNovelBackgroundAsync(int backgroundId)
		{
			SolarSchoolRootView.<SetVisualNovelBackgroundAsync>d__120 <SetVisualNovelBackgroundAsync>d__;
			<SetVisualNovelBackgroundAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetVisualNovelBackgroundAsync>d__.<>4__this = this;
			<SetVisualNovelBackgroundAsync>d__.backgroundId = backgroundId;
			<SetVisualNovelBackgroundAsync>d__.<>1__state = -1;
			<SetVisualNovelBackgroundAsync>d__.<>t__builder.Start<SolarSchoolRootView.<SetVisualNovelBackgroundAsync>d__120>(ref <SetVisualNovelBackgroundAsync>d__);
			return <SetVisualNovelBackgroundAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E96 RID: 233110 RVA: 0x00FF00DC File Offset: 0x00FEE2DC
		private UniTask PlayVisualNovelBackgroundSequenceAsync(string sequenceName)
		{
			SolarSchoolRootView.<PlayVisualNovelBackgroundSequenceAsync>d__121 <PlayVisualNovelBackgroundSequenceAsync>d__;
			<PlayVisualNovelBackgroundSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayVisualNovelBackgroundSequenceAsync>d__.<>4__this = this;
			<PlayVisualNovelBackgroundSequenceAsync>d__.sequenceName = sequenceName;
			<PlayVisualNovelBackgroundSequenceAsync>d__.<>1__state = -1;
			<PlayVisualNovelBackgroundSequenceAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlayVisualNovelBackgroundSequenceAsync>d__121>(ref <PlayVisualNovelBackgroundSequenceAsync>d__);
			return <PlayVisualNovelBackgroundSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E97 RID: 233111 RVA: 0x00FF0128 File Offset: 0x00FEE328
		internal void FinishVisualNovelBackground()
		{
			this.VisualNovelBackgroundCompleted = true;
			string visualNovelBackgroundSequence = this.VisualNovelBackgroundSequence;
			if (visualNovelBackgroundSequence == null)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopSequenceByKey(visualNovelBackgroundSequence, true, true);
		}

		// Token: 0x06038E98 RID: 233112 RVA: 0x00FF015C File Offset: 0x00FEE35C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		internal UniTask<UTexture> LoadVisualNovelBackgroundAsync(int backgroundId, VisualNovelDate date)
		{
			bool useNightPic = SolarSchoolTimeData.UseNightPic((ESolarSchoolTimeSlot)date.PeriodId);
			string avgBackgroundPath = this.GetAvgBackgroundPath(backgroundId, useNightPic);
			if (string.IsNullOrEmpty(avgBackgroundPath))
			{
				return UniTask.FromResult<UTexture>(null);
			}
			if (avgBackgroundPath == this.BackgroundPath)
			{
				return UniTask.FromResult<UTexture>(base.GetTexture(5).GetTexture());
			}
			return this.LoadVisualNovelBackgroundAsync(avgBackgroundPath);
		}

		// Token: 0x06038E99 RID: 233113 RVA: 0x00FF01B8 File Offset: 0x00FEE3B8
		internal void SetVisualNovelBackground(int backgroundId, VisualNovelDate date, UTexture texture)
		{
			this.HideBackgroundSpine();
			UUITexture texture2 = base.GetTexture(5);
			texture2.SetTexture(texture);
			texture2.SetUIActive(true);
			this.BackgroundId = backgroundId;
			bool useNightPic = SolarSchoolTimeData.UseNightPic((ESolarSchoolTimeSlot)date.PeriodId);
			this.BackgroundPath = this.GetAvgBackgroundPath(backgroundId, useNightPic);
			VisualNovelContext visualNovelContext = this.VisualNovelContext;
			if (visualNovelContext != null)
			{
				visualNovelContext.SetBackground(backgroundId);
			}
			UniTaskCompletionSource backgroundReady = this.BackgroundReady;
			if (backgroundReady == null)
			{
				return;
			}
			backgroundReady.TrySetResult();
		}

		// Token: 0x06038E9A RID: 233114 RVA: 0x00FF0224 File Offset: 0x00FEE424
		public UniTask WaitBackgroundReadyAsync()
		{
			UniTask[] array = new UniTask[2];
			int num = 0;
			UniTaskCompletionSource backgroundReady = this.BackgroundReady;
			array[num] = ((backgroundReady != null) ? backgroundReady.Task : UniTask.CompletedTask);
			int num2 = 1;
			UniTaskCompletionSource backgroundSpineReady = this.BackgroundSpineReady;
			array[num2] = ((backgroundSpineReady != null) ? backgroundSpineReady.Task : UniTask.CompletedTask);
			return UniTask.WhenAll(array);
		}

		// Token: 0x06038E9B RID: 233115 RVA: 0x00FF0276 File Offset: 0x00FEE476
		public UniTask WaitBackgroundSwitchStartedAsync()
		{
			UniTaskCompletionSource backgroundSwitchStarted = this.BackgroundSwitchStarted;
			if (backgroundSwitchStarted == null)
			{
				return UniTask.CompletedTask;
			}
			return backgroundSwitchStarted.Task;
		}

		// Token: 0x06038E9C RID: 233116 RVA: 0x00FF028D File Offset: 0x00FEE48D
		protected override void OnChildViewSwitch([Nullable(2)] CommonChildViewBase lastView, CommonChildViewBase curView)
		{
			this.HideBackgroundSpine();
			this.ClearRootUi();
			this.ApplyBackgroundOnChildViewSwitch(lastView, curView);
			this.ApplySeasonFxOnChildViewSwitch(lastView, curView);
		}

		// Token: 0x06038E9D RID: 233117 RVA: 0x00FF02AC File Offset: 0x00FEE4AC
		private void ApplyBackgroundOnChildViewSwitch([Nullable(2)] CommonChildViewBase lastView, CommonChildViewBase curView)
		{
			SolarSchoolChildViewBase solarSchoolChildViewBase = lastView as SolarSchoolChildViewBase;
			bool flag = solarSchoolChildViewBase == null || solarSchoolChildViewBase.BackgroundVisible;
			SolarSchoolChildViewBase solarSchoolChildViewBase2 = curView as SolarSchoolChildViewBase;
			bool flag2 = solarSchoolChildViewBase2 == null || solarSchoolChildViewBase2.BackgroundVisible;
			if (flag == flag2)
			{
				return;
			}
			if (flag2)
			{
				this.BackgroundEnterPending = true;
				return;
			}
			this.BackgroundEnterPending = false;
			this.PlayBackgroundSequenceAsync("Bg_Out", 1f, false).Forget();
		}

		// Token: 0x06038E9E RID: 233118 RVA: 0x00FF030C File Offset: 0x00FEE50C
		private void ApplySeasonFxOnChildViewSwitch([Nullable(2)] CommonChildViewBase lastView, CommonChildViewBase curView)
		{
			SolarSchoolChildViewBase solarSchoolChildViewBase = lastView as SolarSchoolChildViewBase;
			bool flag = solarSchoolChildViewBase == null || solarSchoolChildViewBase.SeasonFxVisible;
			SolarSchoolChildViewBase solarSchoolChildViewBase2 = curView as SolarSchoolChildViewBase;
			bool flag2 = solarSchoolChildViewBase2 == null || solarSchoolChildViewBase2.SeasonFxVisible;
			if (flag == flag2)
			{
				return;
			}
			if (flag2)
			{
				this.ApplySeasonFx(true);
				return;
			}
			this.PlaySeasonFxSequenceAsync("Fx_Out").Forget();
		}

		// Token: 0x06038E9F RID: 233119 RVA: 0x00FF0360 File Offset: 0x00FEE560
		private UniTask PlayBackgroundSequenceAsync(string sequenceName, float playbackRate = 1f, bool skipSequence = false)
		{
			SolarSchoolRootView.<PlayBackgroundSequenceAsync>d__130 <PlayBackgroundSequenceAsync>d__;
			<PlayBackgroundSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackgroundSequenceAsync>d__.<>4__this = this;
			<PlayBackgroundSequenceAsync>d__.sequenceName = sequenceName;
			<PlayBackgroundSequenceAsync>d__.playbackRate = playbackRate;
			<PlayBackgroundSequenceAsync>d__.skipSequence = skipSequence;
			<PlayBackgroundSequenceAsync>d__.<>1__state = -1;
			<PlayBackgroundSequenceAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlayBackgroundSequenceAsync>d__130>(ref <PlayBackgroundSequenceAsync>d__);
			return <PlayBackgroundSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EA0 RID: 233120 RVA: 0x00FF03BB File Offset: 0x00FEE5BB
		private void OnSeasonTimeChanged()
		{
			this.ApplySeasonFx(false);
		}

		// Token: 0x06038EA1 RID: 233121 RVA: 0x00FF03C4 File Offset: 0x00FEE5C4
		private string GetSeasonFxResId()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolTimeData timeData = instance.TimeData;
			if (timeData == null)
			{
				return string.Empty;
			}
			SolarSchoolDatePeriod? datePeriod = SolarSchoolConfig.Instance.GetDatePeriod(instance.ActivityId, timeData.DayIndex);
			return ((datePeriod != null) ? datePeriod.GetValueOrDefault().SeasonFxRes : null) ?? string.Empty;
		}

		// Token: 0x06038EA2 RID: 233122 RVA: 0x00FF0424 File Offset: 0x00FEE624
		private void ApplySeasonFx(bool playEnter)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(11);
			if (uiNiagara == null)
			{
				return;
			}
			string seasonFxResId = this.GetSeasonFxResId();
			if (seasonFxResId == this.SeasonFxResId)
			{
				if (!playEnter || string.IsNullOrEmpty(seasonFxResId))
				{
					return;
				}
				if (this.PendingSeasonFxResId == seasonFxResId)
				{
					this.PendingSeasonFxResId = string.Empty;
					this.PlaySeasonFxEnterAsync(seasonFxResId, uiNiagara).Forget();
					return;
				}
				this.PlaySeasonFxSequenceAsync("Fx_In").Forget();
				return;
			}
			else
			{
				if (string.IsNullOrEmpty(seasonFxResId))
				{
					this.SeasonFxResId = string.Empty;
					this.PendingSeasonFxResId = string.Empty;
					uiNiagara.SetUIActive(false);
					return;
				}
				this.SeasonFxResId = seasonFxResId;
				uiNiagara.SetUIActive(true);
				if (playEnter)
				{
					this.PendingSeasonFxResId = string.Empty;
					this.PlaySeasonFxEnterAsync(seasonFxResId, uiNiagara).Forget();
					return;
				}
				this.PendingSeasonFxResId = seasonFxResId;
				this.PlaySeasonFxSequenceAsync("Fx_Switch").Forget();
				return;
			}
		}

		// Token: 0x06038EA3 RID: 233123 RVA: 0x00FF0500 File Offset: 0x00FEE700
		private void ApplyPendingSeasonFxSystem()
		{
			string pendingSeasonFxResId = this.PendingSeasonFxResId;
			if (string.IsNullOrEmpty(pendingSeasonFxResId))
			{
				return;
			}
			this.PendingSeasonFxResId = string.Empty;
			UUINiagara uiNiagara = base.GetUiNiagara(11);
			if (uiNiagara == null)
			{
				return;
			}
			base.SetNiagaraSystemByPath(pendingSeasonFxResId, uiNiagara, null);
		}

		// Token: 0x06038EA4 RID: 233124 RVA: 0x00FF0540 File Offset: 0x00FEE740
		private UniTask PlaySeasonFxEnterAsync(string resId, UUINiagara niagara)
		{
			SolarSchoolRootView.<PlaySeasonFxEnterAsync>d__135 <PlaySeasonFxEnterAsync>d__;
			<PlaySeasonFxEnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySeasonFxEnterAsync>d__.<>4__this = this;
			<PlaySeasonFxEnterAsync>d__.resId = resId;
			<PlaySeasonFxEnterAsync>d__.niagara = niagara;
			<PlaySeasonFxEnterAsync>d__.<>1__state = -1;
			<PlaySeasonFxEnterAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlaySeasonFxEnterAsync>d__135>(ref <PlaySeasonFxEnterAsync>d__);
			return <PlaySeasonFxEnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EA5 RID: 233125 RVA: 0x00FF0594 File Offset: 0x00FEE794
		private UniTask PlaySeasonFxSequenceAsync(string sequenceName)
		{
			SolarSchoolRootView.<PlaySeasonFxSequenceAsync>d__136 <PlaySeasonFxSequenceAsync>d__;
			<PlaySeasonFxSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySeasonFxSequenceAsync>d__.<>4__this = this;
			<PlaySeasonFxSequenceAsync>d__.sequenceName = sequenceName;
			<PlaySeasonFxSequenceAsync>d__.<>1__state = -1;
			<PlaySeasonFxSequenceAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlaySeasonFxSequenceAsync>d__136>(ref <PlaySeasonFxSequenceAsync>d__);
			return <PlaySeasonFxSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EA6 RID: 233126 RVA: 0x00FF05E0 File Offset: 0x00FEE7E0
		private unsafe void SetBackgroundSpine([TupleElementNames(new string[]
		{
			"AtlasResourceId",
			"SkeletonDataResourceId"
		})] [Nullable(new byte[]
		{
			0,
			1,
			1
		})] ValueTuple<string, string>? resourceIds)
		{
			if (resourceIds == null || this.WaitToDestroy || base.IsDestroyOrDestroying)
			{
				this.HideBackgroundSpine();
				return;
			}
			ValueTuple<string, string> value = resourceIds.Value;
			string item = value.Item1;
			string item2 = value.Item2;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(item);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(item2);
			if (string.IsNullOrEmpty(resourcePath) || string.IsNullOrEmpty(resourcePath2))
			{
				this.HideBackgroundSpine();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "第二索拉学院主界面背景 Spine 未配置资源";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("atlasResourceId", item);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skeletonDataResourceId", item2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (resourcePath == this.PendingBackgroundSpineAtlasPath && resourcePath2 == this.PendingBackgroundSpineSkeletonDataPath)
			{
				return;
			}
			if (this.BackgroundSpineShown && resourcePath == this.BackgroundSpineAtlasPath && resourcePath2 == this.BackgroundSpineSkeletonDataPath)
			{
				return;
			}
			this.HideBackgroundSpine();
			USpineSkeletonAnimationComponent spine = base.GetSpine(14);
			if (spine == null || !spine.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "第二索拉学院主界面缺少背景 Spine 组件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", 14);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (resourcePath == this.BackgroundSpineAtlasPath && resourcePath2 == this.BackgroundSpineSkeletonDataPath && spine.Atlas != null && spine.Atlas.IsValid() && spine.SkeletonData != null && spine.SkeletonData.IsValid())
			{
				this.ShowBackgroundSpine(spine);
				return;
			}
			this.PendingBackgroundSpineAtlasPath = resourcePath;
			this.PendingBackgroundSpineSkeletonDataPath = resourcePath2;
			UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
			this.BackgroundSpineReady = uniTaskCompletionSource;
			this.LoadBackgroundSpineAsync(resourcePath, resourcePath2, this.BackgroundSpineRequestVersion, spine, uniTaskCompletionSource).Forget();
		}

		// Token: 0x06038EA7 RID: 233127 RVA: 0x00FF07C0 File Offset: 0x00FEE9C0
		private UniTask LoadBackgroundSpineAsync(string atlasPath, string skeletonDataPath, int requestVersion, USpineSkeletonAnimationComponent spine, UniTaskCompletionSource ready)
		{
			SolarSchoolRootView.<LoadBackgroundSpineAsync>d__138 <LoadBackgroundSpineAsync>d__;
			<LoadBackgroundSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBackgroundSpineAsync>d__.<>4__this = this;
			<LoadBackgroundSpineAsync>d__.atlasPath = atlasPath;
			<LoadBackgroundSpineAsync>d__.skeletonDataPath = skeletonDataPath;
			<LoadBackgroundSpineAsync>d__.requestVersion = requestVersion;
			<LoadBackgroundSpineAsync>d__.spine = spine;
			<LoadBackgroundSpineAsync>d__.ready = ready;
			<LoadBackgroundSpineAsync>d__.<>1__state = -1;
			<LoadBackgroundSpineAsync>d__.<>t__builder.Start<SolarSchoolRootView.<LoadBackgroundSpineAsync>d__138>(ref <LoadBackgroundSpineAsync>d__);
			return <LoadBackgroundSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EA8 RID: 233128 RVA: 0x00FF0830 File Offset: 0x00FEEA30
		private void ShowBackgroundSpine(USpineSkeletonAnimationComponent spine)
		{
			AActor owner = spine.GetOwner();
			UUIItem uuiitem = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
			if (uuiitem == null || !uuiitem.IsValid())
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "第二索拉学院背景 Spine 缺少 UI 节点", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			spine.SetActive(true, false);
			spine.ClearTracks();
			spine.SetToSetupPose();
			spine.SetAnimation(0, "idle", true);
			spine.SetTimeScale(1f);
			uuiitem.SetUIActive(true);
			this.BackgroundSpineShown = true;
		}

		// Token: 0x06038EA9 RID: 233129 RVA: 0x00FF08C8 File Offset: 0x00FEEAC8
		private void HideBackgroundSpine()
		{
			this.BackgroundSpineShown = false;
			this.BackgroundSpineRequestVersion++;
			this.PendingBackgroundSpineAtlasPath = string.Empty;
			this.PendingBackgroundSpineSkeletonDataPath = string.Empty;
			LoadAsyncPromise<USpineAtlasAsset> backgroundSpineAtlasLoad = this.BackgroundSpineAtlasLoad;
			LoadAsyncPromise<USpineSkeletonDataAsset> backgroundSpineSkeletonLoad = this.BackgroundSpineSkeletonLoad;
			UniTaskCompletionSource backgroundSpineReady = this.BackgroundSpineReady;
			this.BackgroundSpineAtlasLoad = null;
			this.BackgroundSpineSkeletonLoad = null;
			this.BackgroundSpineReady = null;
			USpineSkeletonAnimationComponent spine = base.GetSpine(14);
			if (spine != null && spine.IsValid())
			{
				AActor owner = spine.GetOwner();
				UUIItem uuiitem = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
				if (uuiitem != null && uuiitem.IsValid())
				{
					uuiitem.SetUIActive(false);
				}
				spine.SetActive(false, false);
			}
			if (backgroundSpineAtlasLoad != null)
			{
				backgroundSpineAtlasLoad.CancelAsyncLoad();
			}
			if (backgroundSpineSkeletonLoad != null)
			{
				backgroundSpineSkeletonLoad.CancelAsyncLoad();
			}
			if (backgroundSpineReady != null)
			{
				backgroundSpineReady.TrySetResult();
			}
		}

		// Token: 0x06038EAA RID: 233130 RVA: 0x00FF0998 File Offset: 0x00FEEB98
		private void SetBackground(int backgroundId, string backgroundPath, string switchSequence = "Bg_Switch")
		{
			UUITexture backgroundTexture = base.GetTexture(5);
			if (backgroundTexture == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LZK, "SolarSchoolRootView 缺少背景 Texture 组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool entering = this.BackgroundEnterPending || this.BackgroundId == 0;
			this.BackgroundEnterPending = false;
			if (backgroundPath == this.BackgroundPath)
			{
				backgroundTexture.SetUIActive(true);
				if (entering)
				{
					this.PlayBackgroundSequenceAsync("Bg_In", 1f, false).Forget();
				}
				return;
			}
			UTexture previousTexture = backgroundTexture.GetTexture();
			UniTaskCompletionSource backgroundReady = this.BackgroundReady;
			if (backgroundReady != null)
			{
				backgroundReady.TrySetResult();
			}
			UniTaskCompletionSource backgroundSwitchStarted = this.BackgroundSwitchStarted;
			if (backgroundSwitchStarted != null)
			{
				backgroundSwitchStarted.TrySetResult();
			}
			UniTaskCompletionSource promise = new UniTaskCompletionSource();
			UniTaskCompletionSource startedPromise = new UniTaskCompletionSource();
			this.BackgroundReady = promise;
			this.BackgroundSwitchStarted = startedPromise;
			base.SetTextureByPath(backgroundPath, backgroundTexture, null, delegate(bool loaded)
			{
				if (!loaded)
				{
					startedPromise.TrySetResult();
					promise.TrySetResult();
					return;
				}
				this.BackgroundId = backgroundId;
				this.BackgroundPath = backgroundPath;
				backgroundTexture.SetUIActive(true);
				this.PlayBackgroundSwitchAsync(entering, previousTexture, promise, startedPromise, switchSequence).Forget();
			});
		}

		// Token: 0x06038EAB RID: 233131 RVA: 0x00FF0AE8 File Offset: 0x00FEECE8
		private UniTask PlayBackgroundSwitchAsync(bool entering, [Nullable(2)] UTexture previousTexture, UniTaskCompletionSource promise, UniTaskCompletionSource startedPromise, string switchSequence)
		{
			SolarSchoolRootView.<PlayBackgroundSwitchAsync>d__142 <PlayBackgroundSwitchAsync>d__;
			<PlayBackgroundSwitchAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackgroundSwitchAsync>d__.<>4__this = this;
			<PlayBackgroundSwitchAsync>d__.entering = entering;
			<PlayBackgroundSwitchAsync>d__.previousTexture = previousTexture;
			<PlayBackgroundSwitchAsync>d__.promise = promise;
			<PlayBackgroundSwitchAsync>d__.startedPromise = startedPromise;
			<PlayBackgroundSwitchAsync>d__.switchSequence = switchSequence;
			<PlayBackgroundSwitchAsync>d__.<>1__state = -1;
			<PlayBackgroundSwitchAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlayBackgroundSwitchAsync>d__142>(ref <PlayBackgroundSwitchAsync>d__);
			return <PlayBackgroundSwitchAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EAC RID: 233132 RVA: 0x00FF0B58 File Offset: 0x00FEED58
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UTexture> LoadVisualNovelBackgroundAsync(string backgroundPath)
		{
			SolarSchoolRootView.<LoadVisualNovelBackgroundAsync>d__143 <LoadVisualNovelBackgroundAsync>d__;
			<LoadVisualNovelBackgroundAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture>.Create();
			<LoadVisualNovelBackgroundAsync>d__.<>4__this = this;
			<LoadVisualNovelBackgroundAsync>d__.backgroundPath = backgroundPath;
			<LoadVisualNovelBackgroundAsync>d__.<>1__state = -1;
			<LoadVisualNovelBackgroundAsync>d__.<>t__builder.Start<SolarSchoolRootView.<LoadVisualNovelBackgroundAsync>d__143>(ref <LoadVisualNovelBackgroundAsync>d__);
			return <LoadVisualNovelBackgroundAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EAD RID: 233133 RVA: 0x00FF0BA4 File Offset: 0x00FEEDA4
		[NullableContext(2)]
		private void SetActivityBackgroundByLocation(int locationId, string switchSequence)
		{
			SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(locationId);
			if (location == null || location.Value.BackgroundId == 0)
			{
				return;
			}
			this.SetBackgroundByAvgBackgroundId(location.Value.BackgroundId, switchSequence);
		}

		// Token: 0x06038EAE RID: 233134 RVA: 0x00FF0BEE File Offset: 0x00FEEDEE
		private void SetBackgroundByAvgBackgroundId(int backgroundId)
		{
			this.SetBackgroundByAvgBackgroundId(backgroundId, null);
		}

		// Token: 0x06038EAF RID: 233135 RVA: 0x00FF0BF8 File Offset: 0x00FEEDF8
		[NullableContext(2)]
		private void SetBackgroundByAvgBackgroundId(int backgroundId, string switchSequence)
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			ESolarSchoolTimeSlot slot = (timeData != null) ? timeData.DisplaySlot : ESolarSchoolTimeSlot.Day;
			string avgBackgroundPath = this.GetAvgBackgroundPath(backgroundId, SolarSchoolTimeData.UseNightPic(slot));
			if (string.IsNullOrEmpty(avgBackgroundPath))
			{
				return;
			}
			this.SetBackground(backgroundId, avgBackgroundPath, switchSequence ?? "Bg_Switch");
		}

		// Token: 0x06038EB0 RID: 233136 RVA: 0x00FF0C48 File Offset: 0x00FEEE48
		private unsafe string GetAvgBackgroundPath(int backgroundId, bool useNightPic)
		{
			if (backgroundId == 0)
			{
				return string.Empty;
			}
			AvgBackground? config = ConfigAvgBackgroundById.GetConfig(backgroundId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "第二索拉学院找不到 AVG 背景配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("backgroundId", backgroundId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return string.Empty;
			}
			string text = useNightPic ? config.Value.NightPicPath : config.Value.DayPicPath;
			if (string.IsNullOrEmpty(text))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "第二索拉学院 AVG 背景资源路径为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("backgroundId", backgroundId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("useNightPic", useNightPic);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return text;
		}

		// Token: 0x06038EB1 RID: 233137 RVA: 0x00FF0D30 File Offset: 0x00FEEF30
		private void ApplyLocationRole()
		{
			SolarSchoolRootView.<>c__DisplayClass148_0 CS$<>8__locals1 = new SolarSchoolRootView.<>c__DisplayClass148_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.roleSpineId = this.ViewModel.LocationRoleSpineId;
			if (CS$<>8__locals1.roleSpineId == 0)
			{
				this.HideLocationRole();
				return;
			}
			CS$<>8__locals1.playVoice = this.ViewModel.LocationRolePlayVoice;
			SolarSchoolRootView.<>c__DisplayClass148_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.LocationRoleRequestVersion + 1;
			this.LocationRoleRequestVersion = num;
			CS$<>8__locals2.version = num;
			UiAsyncTask task = new UiAsyncTask("SolarSchoolLocationRole", delegate()
			{
				SolarSchoolRootView.<>c__DisplayClass148_0.<<ApplyLocationRole>b__0>d <<ApplyLocationRole>b__0>d;
				<<ApplyLocationRole>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ApplyLocationRole>b__0>d.<>4__this = CS$<>8__locals1;
				<<ApplyLocationRole>b__0>d.<>1__state = -1;
				<<ApplyLocationRole>b__0>d.<>t__builder.Start<SolarSchoolRootView.<>c__DisplayClass148_0.<<ApplyLocationRole>b__0>d>(ref <<ApplyLocationRole>b__0>d);
				return <<ApplyLocationRole>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06038EB2 RID: 233138 RVA: 0x00FF0DB4 File Offset: 0x00FEEFB4
		private void HideLocationRole()
		{
			SolarSchoolRootView.<>c__DisplayClass149_0 CS$<>8__locals1 = new SolarSchoolRootView.<>c__DisplayClass149_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.spineItem = this.LocationCharacterSpineItem;
			if (CS$<>8__locals1.spineItem == null || !this.LocationRoleShown)
			{
				return;
			}
			this.LocationRoleShown = false;
			this.LocationRoleRequestVersion++;
			UiAsyncTask task = new UiAsyncTask("SolarSchoolLocationRole", delegate()
			{
				SolarSchoolRootView.<>c__DisplayClass149_0.<<HideLocationRole>b__0>d <<HideLocationRole>b__0>d;
				<<HideLocationRole>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<HideLocationRole>b__0>d.<>4__this = CS$<>8__locals1;
				<<HideLocationRole>b__0>d.<>1__state = -1;
				<<HideLocationRole>b__0>d.<>t__builder.Start<SolarSchoolRootView.<>c__DisplayClass149_0.<<HideLocationRole>b__0>d>(ref <<HideLocationRole>b__0>d);
				return <<HideLocationRole>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06038EB3 RID: 233139 RVA: 0x00FF0E20 File Offset: 0x00FEF020
		private UniTask HideLocationRoleForVisualNovelAsync()
		{
			SolarSchoolRootView.<HideLocationRoleForVisualNovelAsync>d__150 <HideLocationRoleForVisualNovelAsync>d__;
			<HideLocationRoleForVisualNovelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideLocationRoleForVisualNovelAsync>d__.<>4__this = this;
			<HideLocationRoleForVisualNovelAsync>d__.<>1__state = -1;
			<HideLocationRoleForVisualNovelAsync>d__.<>t__builder.Start<SolarSchoolRootView.<HideLocationRoleForVisualNovelAsync>d__150>(ref <HideLocationRoleForVisualNovelAsync>d__);
			return <HideLocationRoleForVisualNovelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EB4 RID: 233140 RVA: 0x00FF0E64 File Offset: 0x00FEF064
		private UniTask PlayLocationRoleSequenceAsync(string sequenceName, bool blockClick = false, bool skipSequence = false)
		{
			SolarSchoolRootView.<PlayLocationRoleSequenceAsync>d__151 <PlayLocationRoleSequenceAsync>d__;
			<PlayLocationRoleSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayLocationRoleSequenceAsync>d__.<>4__this = this;
			<PlayLocationRoleSequenceAsync>d__.sequenceName = sequenceName;
			<PlayLocationRoleSequenceAsync>d__.blockClick = blockClick;
			<PlayLocationRoleSequenceAsync>d__.skipSequence = skipSequence;
			<PlayLocationRoleSequenceAsync>d__.<>1__state = -1;
			<PlayLocationRoleSequenceAsync>d__.<>t__builder.Start<SolarSchoolRootView.<PlayLocationRoleSequenceAsync>d__151>(ref <PlayLocationRoleSequenceAsync>d__);
			return <PlayLocationRoleSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EB5 RID: 233141 RVA: 0x00FF0EC0 File Offset: 0x00FEF0C0
		[NullableContext(0)]
		private UniTask<bool> ShowLocationRoleAsync(int roleSpineId, bool playVoice)
		{
			SolarSchoolRootView.<ShowLocationRoleAsync>d__152 <ShowLocationRoleAsync>d__;
			<ShowLocationRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowLocationRoleAsync>d__.<>4__this = this;
			<ShowLocationRoleAsync>d__.roleSpineId = roleSpineId;
			<ShowLocationRoleAsync>d__.playVoice = playVoice;
			<ShowLocationRoleAsync>d__.<>1__state = -1;
			<ShowLocationRoleAsync>d__.<>t__builder.Start<SolarSchoolRootView.<ShowLocationRoleAsync>d__152>(ref <ShowLocationRoleAsync>d__);
			return <ShowLocationRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EB6 RID: 233142 RVA: 0x00FF0F13 File Offset: 0x00FEF113
		private void OnCaptionBack()
		{
			base.CloseCurChildView();
		}

		// Token: 0x06038EB7 RID: 233143 RVA: 0x00FF0F1B File Offset: 0x00FEF11B
		private void ClearRootUi()
		{
			this.ApplyRootUiParams(new SolarSchoolRootUiParams());
		}

		// Token: 0x06038EB8 RID: 233144 RVA: 0x00FF0F28 File Offset: 0x00FEF128
		private void ApplyRootUiParams(SolarSchoolRootUiParams uiParams)
		{
			this.ApplyCaption(uiParams.Caption);
			this.ApplyFestivalTips(uiParams.FestivalTips);
			this.ApplyShopButton(uiParams.ShopButtonVisible);
			this.ApplyLocationName(uiParams.LocationName);
			this.ApplyInvitationTag(uiParams.InvitationTagVisible);
		}

		// Token: 0x06038EB9 RID: 233145 RVA: 0x00FF0F68 File Offset: 0x00FEF168
		[NullableContext(2)]
		private void ApplyCaption(SolarSchoolCaptionParams uiParams)
		{
			if (this.Caption == null)
			{
				return;
			}
			this.CaptionDesiredVisible = (uiParams != null);
			this.Caption.SetUiActive(this.CaptionDesiredVisible && this.HudVisible);
			if (uiParams == null)
			{
				return;
			}
			this.Caption.SetBackVisible(uiParams.BackVisible);
			this.Caption.SetCloseVisible(uiParams.CloseVisible);
			this.Caption.SetSetVisible(uiParams.SetVisible);
			this.Caption.SetTipCostVisible(uiParams.TipCostVisible);
			this.Caption.SetOverviewVisible(uiParams.OverviewVisible);
			this.Caption.SetBackpackVisible(uiParams.BackpackVisible);
			this.Caption.SetHelpGroupId(uiParams.HelpGroupId);
		}

		// Token: 0x06038EBA RID: 233146 RVA: 0x00FF101F File Offset: 0x00FEF21F
		private void ApplyFatiguePreview(int fatigue)
		{
			SolarSchoolCaptionItem caption = this.Caption;
			if (caption == null)
			{
				return;
			}
			caption.SetFatiguePreview(fatigue);
		}

		// Token: 0x06038EBB RID: 233147 RVA: 0x00FF1032 File Offset: 0x00FEF232
		private void ApplyClearFatiguePreview()
		{
			SolarSchoolCaptionItem caption = this.Caption;
			if (caption == null)
			{
				return;
			}
			caption.ClearFatiguePreview();
		}

		// Token: 0x06038EBC RID: 233148 RVA: 0x00FF1044 File Offset: 0x00FEF244
		private void ApplyHoldFatigueUntilSettled(int fatigue)
		{
			SolarSchoolCaptionItem caption = this.Caption;
			if (caption == null)
			{
				return;
			}
			caption.HoldFatigueUntilSettled(fatigue);
		}

		// Token: 0x06038EBD RID: 233149 RVA: 0x00FF1058 File Offset: 0x00FEF258
		[NullableContext(2)]
		private void ApplyFestivalTips(SolarSchoolFestivalTipsParams uiParams)
		{
			if (this.FestivalTips == null)
			{
				return;
			}
			this.FestivalTipsDesiredVisible = (uiParams != null);
			if (uiParams == null)
			{
				this.FestivalTips.SetUiActive(false);
				return;
			}
			this.FestivalTips.SetTipsText(uiParams.TextId);
			if (this.HudVisible)
			{
				this.FestivalTips.PlayShow();
				return;
			}
			this.FestivalTips.SetUiActive(false);
		}

		// Token: 0x06038EBE RID: 233150 RVA: 0x00FF10B9 File Offset: 0x00FEF2B9
		private void ApplyShopButton(bool visible)
		{
			this.ShopButtonDesiredVisible = visible;
			if (this.ShopButtonDesiredVisible && this.HudVisible)
			{
				SolarSchoolShopButtonItem shopButton = this.ShopButton;
				if (shopButton == null)
				{
					return;
				}
				shopButton.PlayShow();
				return;
			}
			else
			{
				SolarSchoolShopButtonItem shopButton2 = this.ShopButton;
				if (shopButton2 == null)
				{
					return;
				}
				shopButton2.SetUiActive(false);
				return;
			}
		}

		// Token: 0x06038EBF RID: 233151 RVA: 0x00FF10F4 File Offset: 0x00FEF2F4
		private void OnShopButtonClick()
		{
			if (!SolarSchoolGamePlayModel.Instance.TryOpenAvailableShop())
			{
				return;
			}
			this.ApplyShopButton(false);
		}

		// Token: 0x06038EC0 RID: 233152 RVA: 0x00FF110C File Offset: 0x00FEF30C
		[NullableContext(2)]
		private void ApplyLocationName(SolarSchoolLocationNameParams uiParams)
		{
			if (this.LocationName == null)
			{
				return;
			}
			this.LocationNameDesiredVisible = (uiParams != null);
			this.LocationName.SetUiActive(this.LocationNameDesiredVisible && this.HudVisible);
			if (uiParams == null)
			{
				return;
			}
			this.LocationName.SetLocationName(uiParams.TextId);
		}

		// Token: 0x17006C7F RID: 27775
		// (get) Token: 0x06038EC1 RID: 233153 RVA: 0x00FF115D File Offset: 0x00FEF35D
		private bool HudVisible
		{
			get
			{
				return this.HudHideCount == 0;
			}
		}

		// Token: 0x06038EC2 RID: 233154 RVA: 0x00FF1168 File Offset: 0x00FEF368
		private void ApplyHudVisible()
		{
			SolarSchoolCaptionItem caption = this.Caption;
			if (caption != null)
			{
				caption.SetUiActive(this.CaptionDesiredVisible && this.HudVisible);
			}
			if (this.FestivalTipsDesiredVisible && this.HudVisible)
			{
				SolarSchoolFestivalTips festivalTips = this.FestivalTips;
				if (festivalTips != null)
				{
					festivalTips.PlayShow();
				}
			}
			else
			{
				SolarSchoolFestivalTips festivalTips2 = this.FestivalTips;
				if (festivalTips2 != null)
				{
					festivalTips2.SetUiActive(false);
				}
			}
			if (this.ShopButtonDesiredVisible && this.HudVisible)
			{
				SolarSchoolShopButtonItem shopButton = this.ShopButton;
				if (shopButton != null)
				{
					shopButton.PlayShow();
				}
			}
			else
			{
				SolarSchoolShopButtonItem shopButton2 = this.ShopButton;
				if (shopButton2 != null)
				{
					shopButton2.SetUiActive(false);
				}
			}
			SolarSchoolLocationNameItem locationName = this.LocationName;
			if (locationName != null)
			{
				locationName.SetUiActive(this.LocationNameDesiredVisible && this.HudVisible);
			}
			this.ApplyDateVisible();
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.InvitationTagDesiredVisible && this.HudVisible);
		}

		// Token: 0x06038EC3 RID: 233155 RVA: 0x00FF124C File Offset: 0x00FEF44C
		private void ApplyInvitationTag(bool visible)
		{
			this.InvitationTagDesiredVisible = visible;
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.InvitationTagDesiredVisible && this.HudVisible);
		}

		// Token: 0x06038EC4 RID: 233156 RVA: 0x00FF1278 File Offset: 0x00FEF478
		private void ApplyDateVisible()
		{
			bool flag = this.DateVisible && this.VisualNovelDateVisible && this.HudVisible && !SolarSchoolGamePlayModel.Instance.IsDateHiddenByEnding;
			SolarSchoolDateItem date = this.Date;
			if (date != null)
			{
				date.SetUiActive(flag);
			}
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag);
		}

		// Token: 0x0401DF08 RID: 122632
		private const string BackgroundSwitchSequence = "Bg_Switch";

		// Token: 0x0401DF09 RID: 122633
		public const string BehaviorBackgroundSwitchSequence = "Bg_Switch01";

		// Token: 0x0401DF0A RID: 122634
		private const string BackgroundEnterSequence = "Bg_In";

		// Token: 0x0401DF0B RID: 122635
		private const string BackgroundExitSequence = "Bg_Out";

		// Token: 0x0401DF0C RID: 122636
		private const string SeasonFxSwitchSequence = "Fx_Switch";

		// Token: 0x0401DF0D RID: 122637
		private const string SeasonFxEnterSequence = "Fx_In";

		// Token: 0x0401DF0E RID: 122638
		private const string SeasonFxExitSequence = "Fx_Out";

		// Token: 0x0401DF0F RID: 122639
		private const string SeasonFxSwitchEvent = "Switch";

		// Token: 0x0401DF10 RID: 122640
		private const string LocationRoleStartSequence = "Role_Start";

		// Token: 0x0401DF11 RID: 122641
		private const string LocationRoleCloseSequence = "Role_Close";

		// Token: 0x0401DF12 RID: 122642
		private const string VisualNovelShakeSequence = "Shake";

		// Token: 0x0401DF13 RID: 122643
		private const string BackgroundSpineAnimation = "idle";

		// Token: 0x0401DF14 RID: 122644
		private const string LocationRoleTaskName = "SolarSchoolLocationRole";

		// Token: 0x0401DF15 RID: 122645
		private readonly List<SolarSchoolCharacterSpineItem> SceneCharacterItems = new List<SolarSchoolCharacterSpineItem>();

		// Token: 0x0401DF16 RID: 122646
		private readonly List<SolarSchoolCharacterTextureItem> SceneTextureCharacterItems = new List<SolarSchoolCharacterTextureItem>();

		// Token: 0x0401DF17 RID: 122647
		private readonly List<SolarSchoolCharacterSpineItem> IdleCharacterItems = new List<SolarSchoolCharacterSpineItem>();

		// Token: 0x0401DF18 RID: 122648
		private readonly List<SolarSchoolCharacterTextureItem> IdleTextureCharacterItems = new List<SolarSchoolCharacterTextureItem>();

		// Token: 0x0401DF19 RID: 122649
		[Nullable(2)]
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DF1A RID: 122650
		[Nullable(2)]
		private SolarSchoolDateItem Date;

		// Token: 0x0401DF1B RID: 122651
		[Nullable(2)]
		private SolarSchoolLocationNameItem LocationName;

		// Token: 0x0401DF1C RID: 122652
		[Nullable(2)]
		private SolarSchoolFestivalTips FestivalTips;

		// Token: 0x0401DF1D RID: 122653
		[Nullable(2)]
		private SolarSchoolShopButtonItem ShopButton;

		// Token: 0x0401DF1E RID: 122654
		[Nullable(2)]
		private SolarSchoolCharacterSpineItem LocationCharacterSpineItem;

		// Token: 0x0401DF1F RID: 122655
		[Nullable(2)]
		private UniTaskCompletionSource BackgroundReady;

		// Token: 0x0401DF20 RID: 122656
		[Nullable(2)]
		private UniTaskCompletionSource BackgroundSwitchStarted;

		// Token: 0x0401DF21 RID: 122657
		[Nullable(2)]
		private UniTaskCompletionSource BackgroundSpineReady;

		// Token: 0x0401DF22 RID: 122658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> BackgroundSpineAtlasLoad;

		// Token: 0x0401DF23 RID: 122659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> BackgroundSpineSkeletonLoad;

		// Token: 0x0401DF24 RID: 122660
		private int BackgroundSpineRequestVersion;

		// Token: 0x0401DF25 RID: 122661
		private bool BackgroundSpineShown;

		// Token: 0x0401DF26 RID: 122662
		private string BackgroundSpineAtlasPath = string.Empty;

		// Token: 0x0401DF27 RID: 122663
		private string BackgroundSpineSkeletonDataPath = string.Empty;

		// Token: 0x0401DF28 RID: 122664
		private string PendingBackgroundSpineAtlasPath = string.Empty;

		// Token: 0x0401DF29 RID: 122665
		private string PendingBackgroundSpineSkeletonDataPath = string.Empty;

		// Token: 0x0401DF2A RID: 122666
		private int BackgroundId;

		// Token: 0x0401DF2B RID: 122667
		private string BackgroundPath = string.Empty;

		// Token: 0x0401DF2C RID: 122668
		private bool BackgroundEnterPending;

		// Token: 0x0401DF2D RID: 122669
		private string SeasonFxResId = string.Empty;

		// Token: 0x0401DF2E RID: 122670
		private string PendingSeasonFxResId = string.Empty;

		// Token: 0x0401DF2F RID: 122671
		[Nullable(2)]
		private AUIBaseActor SeasonFxActor;

		// Token: 0x0401DF30 RID: 122672
		[Nullable(2)]
		private string VisualNovelBackgroundSequence;

		// Token: 0x0401DF31 RID: 122673
		private bool VisualNovelBackgroundCompleted;

		// Token: 0x0401DF32 RID: 122674
		[Nullable(2)]
		private CustomPromise<bool> VisualNovelShakePromise;

		// Token: 0x0401DF33 RID: 122675
		private int VisualNovelShakeVersion;

		// Token: 0x0401DF34 RID: 122676
		private float? VisualNovelPlaybackRate;

		// Token: 0x0401DF35 RID: 122677
		private bool VisualNovelPaused;

		// Token: 0x0401DF36 RID: 122678
		[Nullable(2)]
		private string DayTransitionSeqName;

		// Token: 0x0401DF37 RID: 122679
		[Nullable(2)]
		private Action DayTransitionFinish;

		// Token: 0x0401DF38 RID: 122680
		private bool DateVisible = true;

		// Token: 0x0401DF39 RID: 122681
		private bool VisualNovelDateVisible = true;

		// Token: 0x0401DF3A RID: 122682
		private bool VisualNovelRoleShown;

		// Token: 0x0401DF3B RID: 122683
		private bool LocationRoleShown;

		// Token: 0x0401DF3C RID: 122684
		private int LocationRoleRequestVersion;

		// Token: 0x0401DF3D RID: 122685
		private int HudHideCount;

		// Token: 0x0401DF3E RID: 122686
		private bool CaptionDesiredVisible;

		// Token: 0x0401DF3F RID: 122687
		private bool FestivalTipsDesiredVisible;

		// Token: 0x0401DF40 RID: 122688
		private bool ShopButtonDesiredVisible;

		// Token: 0x0401DF41 RID: 122689
		private bool LocationNameDesiredVisible;

		// Token: 0x0401DF42 RID: 122690
		private bool InvitationTagDesiredVisible;

		// Token: 0x0200B61F RID: 46623
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403851A RID: 230682
			public const int Caption = 0;

			// Token: 0x0403851B RID: 230683
			public const int Date = 1;

			// Token: 0x0403851C RID: 230684
			public const int Location = 2;

			// Token: 0x0403851D RID: 230685
			public const int ContentItem = 3;

			// Token: 0x0403851E RID: 230686
			public const int RoleRootItem = 4;

			// Token: 0x0403851F RID: 230687
			public const int BackgroundTex = 5;

			// Token: 0x04038520 RID: 230688
			public const int PanelFestival = 6;

			// Token: 0x04038521 RID: 230689
			public const int ShopItem = 7;

			// Token: 0x04038522 RID: 230690
			public const int DateBg = 8;

			// Token: 0x04038523 RID: 230691
			public const int TextureCharacterItem = 9;

			// Token: 0x04038524 RID: 230692
			public const int PreviousTex = 10;

			// Token: 0x04038525 RID: 230693
			public const int SeasonNiagara = 11;

			// Token: 0x04038526 RID: 230694
			public const int InvitationTag = 13;

			// Token: 0x04038527 RID: 230695
			public const int BackgroundSpine = 14;
		}
	}
}
