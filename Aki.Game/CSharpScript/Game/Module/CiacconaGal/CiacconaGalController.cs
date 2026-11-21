using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004B91 RID: 19345
	[NullableContext(2)]
	[Nullable(0)]
	[TickController(0)]
	public class CiacconaGalController : ControllerBase
	{
		// Token: 0x170060CD RID: 24781
		// (get) Token: 0x0603052F RID: 197935 RVA: 0x00D796EC File Offset: 0x00D778EC
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170060CE RID: 24782
		// (get) Token: 0x06030530 RID: 197936 RVA: 0x00D796EF File Offset: 0x00D778EF
		public CiacconaGalPlayer GalPlayer
		{
			get
			{
				return this.InternalGalPlayer;
			}
		}

		// Token: 0x06030531 RID: 197937 RVA: 0x00D796F7 File Offset: 0x00D778F7
		protected override bool OnInit()
		{
			this.InternalGalPlayer = CiacconaGalPlayer.Instance;
			this.AddNetListeners();
			return true;
		}

		// Token: 0x06030532 RID: 197938 RVA: 0x00D7970B File Offset: 0x00D7790B
		protected override bool OnClear()
		{
			this.AvgDataUpdateDelegates = new List<Action<int>>();
			this.InternalGalPlayer.Release();
			this.RemoveNetListeners();
			return true;
		}

		// Token: 0x06030533 RID: 197939 RVA: 0x00D7972A File Offset: 0x00D7792A
		protected override void OnTick(float delta)
		{
			this.TickAvg(delta);
			this.TickDataUpdate(delta);
		}

		// Token: 0x06030534 RID: 197940 RVA: 0x00D7973A File Offset: 0x00D7793A
		private void TickAvg(float delta)
		{
			if (!this.IsViewReady)
			{
				return;
			}
			if (CiacconaGalModel.Instance.IsCurStepDataListDirty)
			{
				this.NotifyDataUpdate();
			}
			if (this.InternalGalPlayer.StatePendingToSwitch != ECiacconaGalPlayerState.Initializing)
			{
				this.InternalGalPlayer.SwitchState();
			}
		}

		// Token: 0x06030535 RID: 197941 RVA: 0x00D7976F File Offset: 0x00D7796F
		private void TickDataUpdate(float delta)
		{
			if (CiacconaGalModel.Instance.DataUpdateMask != 0)
			{
				this.NotifyActivityDataUpdate(CiacconaGalModel.Instance.DataUpdateMask);
				CiacconaGalModel.Instance.DataUpdateMask = 0;
			}
		}

		// Token: 0x06030536 RID: 197942 RVA: 0x00D79798 File Offset: 0x00D77998
		private void AddNetListeners()
		{
			Net.Instance.Register(ENotifyMessageId.ChapterUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnProtoChapterUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InspirationUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInspirationDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.ScheduleRewardUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnProgressRewardUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.ActivityResultUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityResultUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.CiacconaActivityStateUnlockUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityStateUpdateNotify));
		}

		// Token: 0x06030537 RID: 197943 RVA: 0x00D79834 File Offset: 0x00D77A34
		private void RemoveNetListeners()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ChapterUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InspirationUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ScheduleRewardUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ActivityResultUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.CiacconaActivityStateUnlockUpdateNotify);
		}

		// Token: 0x06030538 RID: 197944 RVA: 0x00D79894 File Offset: 0x00D77A94
		private void NotifyActivityDataUpdate(int mask)
		{
			if ((mask & 1) != 0)
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaChapterDataUpdate);
			}
			if ((mask & 2) != 0)
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaInspirationDataUpdate);
			}
			if ((mask & 4) != 0)
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaRewardDataUpdate);
			}
			if ((mask & 8) != 0)
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaEndingDataUpdate);
			}
			if ((mask & 16) != 0)
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaActivityStateUpdate);
			}
			CiacconaGalActivityData activityData = CiacconaGalModel.Instance.ActivityData;
			if (activityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
		}

		// Token: 0x06030539 RID: 197945 RVA: 0x00D79930 File Offset: 0x00D77B30
		public void OpenGalViewByChapterId(int chapterId, EUiViewName? lastView = null)
		{
			CiacconaGalChapterData chapterDataById = CiacconaGalModel.Instance.GetChapterDataById(chapterId);
			if (chapterDataById != null)
			{
				int stepId = chapterDataById.StepIds[0];
				this.GalPlayer.CurHandlingChapterId = chapterId;
				this.OpenGalViewByStepId(stepId, new int?(chapterId), lastView);
			}
		}

		// Token: 0x0603053A RID: 197946 RVA: 0x00D79970 File Offset: 0x00D77B70
		public void OpenGalViewByStepId(int stepId, int? chapterId = null, EUiViewName? lastView = null)
		{
			bool flag = this.InitGalData(stepId);
			if (chapterId != null)
			{
				this.GalPlayer.CurHandlingChapterId = chapterId.Value;
			}
			if (flag)
			{
				UiManager.Instance.OpenView(EUiViewName.CiacconaGalView, null, delegate(bool _, int _)
				{
					if (lastView != null)
					{
						UiManager.Instance.CloseView(lastView.Value, null);
					}
				});
			}
		}

		// Token: 0x0603053B RID: 197947 RVA: 0x00D799CC File Offset: 0x00D77BCC
		public void OpenChapterViewById(int chapterId, EUiViewName? lastView = null)
		{
			CiacconaGalChapterData chapterDataById = CiacconaGalModel.Instance.GetChapterDataById(chapterId);
			if (chapterDataById != null)
			{
				this.GalPlayer.CurHandlingChapterId = chapterId;
				UiManager.Instance.OpenView(EUiViewName.CiacconaGalChapterView, chapterDataById, delegate(bool _, int _)
				{
					if (lastView != null)
					{
						UiManager.Instance.CloseView(lastView.Value, null);
					}
				});
			}
		}

		// Token: 0x0603053C RID: 197948 RVA: 0x00D79A20 File Offset: 0x00D77C20
		[NullableContext(0)]
		public UniTask<bool> OpenChapterViewAsync(int chapterId)
		{
			CiacconaGalController.<OpenChapterViewAsync>d__18 <OpenChapterViewAsync>d__;
			<OpenChapterViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenChapterViewAsync>d__.<>4__this = this;
			<OpenChapterViewAsync>d__.chapterId = chapterId;
			<OpenChapterViewAsync>d__.<>1__state = -1;
			<OpenChapterViewAsync>d__.<>t__builder.Start<CiacconaGalController.<OpenChapterViewAsync>d__18>(ref <OpenChapterViewAsync>d__);
			return <OpenChapterViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603053D RID: 197949 RVA: 0x00D79A6B File Offset: 0x00D77C6B
		public void OpenEndingView()
		{
			UiManager.Instance.OpenView(EUiViewName.CiacconaGalEndingView, null, null);
		}

		// Token: 0x0603053E RID: 197950 RVA: 0x00D79A80 File Offset: 0x00D77C80
		public void OpenEndingDetailView(int endingId, string labelTextId = null)
		{
			CiacconaGalEndingData endingDataById = CiacconaGalModel.Instance.GetEndingDataById(endingId);
			if (endingDataById != null && endingDataById.IsFinished)
			{
				CiacconaEndingViewParam param = new CiacconaEndingViewParam
				{
					EndingData = endingDataById,
					LabelTextId = labelTextId
				};
				UiManager.Instance.OpenView(EUiViewName.CiacconaGalEndingDetailView, param, null);
			}
		}

		// Token: 0x0603053F RID: 197951 RVA: 0x00D79ACC File Offset: 0x00D77CCC
		public void OpenChapterEntryView(int activityId, ECiacconaEntryType from = ECiacconaEntryType.None)
		{
			CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(activityId);
			if (activityDataById != null)
			{
				UiManager.Instance.OpenView(EUiViewName.CiacconaGalChapterEntryView, activityDataById, null);
				this.ReportEnterChapterEntryView(from);
			}
		}

		// Token: 0x06030540 RID: 197952 RVA: 0x00D79B00 File Offset: 0x00D77D00
		[NullableContext(0)]
		public UniTask<bool> OpenChapterEntryViewAsync(int activityId, ECiacconaEntryType from = ECiacconaEntryType.None)
		{
			CiacconaGalController.<OpenChapterEntryViewAsync>d__22 <OpenChapterEntryViewAsync>d__;
			<OpenChapterEntryViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenChapterEntryViewAsync>d__.<>4__this = this;
			<OpenChapterEntryViewAsync>d__.activityId = activityId;
			<OpenChapterEntryViewAsync>d__.from = from;
			<OpenChapterEntryViewAsync>d__.<>1__state = -1;
			<OpenChapterEntryViewAsync>d__.<>t__builder.Start<CiacconaGalController.<OpenChapterEntryViewAsync>d__22>(ref <OpenChapterEntryViewAsync>d__);
			return <OpenChapterEntryViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030541 RID: 197953 RVA: 0x00D79B54 File Offset: 0x00D77D54
		public void OpenRewardViewByActivityId(int activityId)
		{
			CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(activityId);
			if (activityDataById != null && activityDataById.IsInRewardTime)
			{
				UiManager.Instance.OpenView(EUiViewName.CiacconaActivityRewardView, activityDataById, null);
			}
		}

		// Token: 0x06030542 RID: 197954 RVA: 0x00D79B8C File Offset: 0x00D77D8C
		public UniTask ExitAvg()
		{
			CiacconaGalController.<ExitAvg>d__24 <ExitAvg>d__;
			<ExitAvg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitAvg>d__.<>4__this = this;
			<ExitAvg>d__.<>1__state = -1;
			<ExitAvg>d__.<>t__builder.Start<CiacconaGalController.<ExitAvg>d__24>(ref <ExitAvg>d__);
			return <ExitAvg>d__.<>t__builder.Task;
		}

		// Token: 0x06030543 RID: 197955 RVA: 0x00D79BCF File Offset: 0x00D77DCF
		[NullableContext(1)]
		public void AddOnStepDataUpdate(Action<int> @delegate)
		{
			this.AvgDataUpdateDelegates.Add(@delegate);
		}

		// Token: 0x06030544 RID: 197956 RVA: 0x00D79BE0 File Offset: 0x00D77DE0
		[NullableContext(1)]
		public void RemoveOnStepDataUpdate(Action<int> @delegate)
		{
			int num = this.AvgDataUpdateDelegates.IndexOf(@delegate);
			if (num != -1)
			{
				this.AvgDataUpdateDelegates.RemoveAt(num);
			}
		}

		// Token: 0x06030545 RID: 197957 RVA: 0x00D79C0A File Offset: 0x00D77E0A
		public void SetGalViewReady(bool isReady)
		{
			this.IsViewReady = isReady;
			if (!isReady)
			{
				this.InternalGalPlayer.Reset();
			}
		}

		// Token: 0x06030546 RID: 197958 RVA: 0x00D79C24 File Offset: 0x00D77E24
		private void NotifyDataUpdate()
		{
			foreach (Action<int> action in this.AvgDataUpdateDelegates)
			{
				action(this.GalPlayer.CurHandlingStepId);
			}
			CiacconaGalModel.Instance.IsCurStepDataListDirty = false;
		}

		// Token: 0x06030547 RID: 197959 RVA: 0x00D79C8C File Offset: 0x00D77E8C
		private bool InitGalData(int targetStepId)
		{
			if (CiacconaGalModel.Instance.GetStepDataById(targetStepId) == null)
			{
				return false;
			}
			CiacconaGalModel.Instance.ClearCurStepData();
			List<CiacconaGalChapterData> allChapterData = CiacconaGalModel.Instance.GetAllChapterData();
			if (allChapterData == null)
			{
				return false;
			}
			CiacconaGalChapterData ciacconaGalChapterData = allChapterData.Find((CiacconaGalChapterData data) => Array.IndexOf<int>(data.StepIds, targetStepId) >= 0);
			if (ciacconaGalChapterData == null)
			{
				return false;
			}
			foreach (int num in ciacconaGalChapterData.StepIds)
			{
				if (num == targetStepId)
				{
					break;
				}
				CiacconaGalStepData stepDataById = CiacconaGalModel.Instance.GetStepDataById(num);
				if (stepDataById.Type == ECiacconaGalStepType.Choice)
				{
					stepDataById.ChosenId = stepDataById.ChoiceIds[0];
				}
				CiacconaGalModel.Instance.PushCurStepData(stepDataById);
			}
			this.InternalGalPlayer.TryContinue(targetStepId);
			return true;
		}

		// Token: 0x06030548 RID: 197960 RVA: 0x00D79D5C File Offset: 0x00D77F5C
		public UniTask RequestFinishChapterSubEnding(int activityId, int chapterId, int subEndingId)
		{
			CiacconaGalController.<RequestFinishChapterSubEnding>d__30 <RequestFinishChapterSubEnding>d__;
			<RequestFinishChapterSubEnding>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestFinishChapterSubEnding>d__.activityId = activityId;
			<RequestFinishChapterSubEnding>d__.chapterId = chapterId;
			<RequestFinishChapterSubEnding>d__.subEndingId = subEndingId;
			<RequestFinishChapterSubEnding>d__.<>1__state = -1;
			<RequestFinishChapterSubEnding>d__.<>t__builder.Start<CiacconaGalController.<RequestFinishChapterSubEnding>d__30>(ref <RequestFinishChapterSubEnding>d__);
			return <RequestFinishChapterSubEnding>d__.<>t__builder.Task;
		}

		// Token: 0x06030549 RID: 197961 RVA: 0x00D79DB0 File Offset: 0x00D77FB0
		public UniTask RequestUnlockChoice(int activityId, int chapterId, int choiceId)
		{
			CiacconaGalController.<RequestUnlockChoice>d__31 <RequestUnlockChoice>d__;
			<RequestUnlockChoice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestUnlockChoice>d__.activityId = activityId;
			<RequestUnlockChoice>d__.chapterId = chapterId;
			<RequestUnlockChoice>d__.choiceId = choiceId;
			<RequestUnlockChoice>d__.<>1__state = -1;
			<RequestUnlockChoice>d__.<>t__builder.Start<CiacconaGalController.<RequestUnlockChoice>d__31>(ref <RequestUnlockChoice>d__);
			return <RequestUnlockChoice>d__.<>t__builder.Task;
		}

		// Token: 0x0603054A RID: 197962 RVA: 0x00D79E04 File Offset: 0x00D78004
		public UniTask RequestGetSubEndingReward(int activityId, int chapterId, int subEndingId)
		{
			CiacconaGalController.<RequestGetSubEndingReward>d__32 <RequestGetSubEndingReward>d__;
			<RequestGetSubEndingReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestGetSubEndingReward>d__.activityId = activityId;
			<RequestGetSubEndingReward>d__.chapterId = chapterId;
			<RequestGetSubEndingReward>d__.subEndingId = subEndingId;
			<RequestGetSubEndingReward>d__.<>1__state = -1;
			<RequestGetSubEndingReward>d__.<>t__builder.Start<CiacconaGalController.<RequestGetSubEndingReward>d__32>(ref <RequestGetSubEndingReward>d__);
			return <RequestGetSubEndingReward>d__.<>t__builder.Task;
		}

		// Token: 0x0603054B RID: 197963 RVA: 0x00D79E58 File Offset: 0x00D78058
		public UniTask RequestGetActivityEndingReward(int activityId, int endingId)
		{
			CiacconaGalController.<RequestGetActivityEndingReward>d__33 <RequestGetActivityEndingReward>d__;
			<RequestGetActivityEndingReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestGetActivityEndingReward>d__.activityId = activityId;
			<RequestGetActivityEndingReward>d__.endingId = endingId;
			<RequestGetActivityEndingReward>d__.<>1__state = -1;
			<RequestGetActivityEndingReward>d__.<>t__builder.Start<CiacconaGalController.<RequestGetActivityEndingReward>d__33>(ref <RequestGetActivityEndingReward>d__);
			return <RequestGetActivityEndingReward>d__.<>t__builder.Task;
		}

		// Token: 0x0603054C RID: 197964 RVA: 0x00D79EA4 File Offset: 0x00D780A4
		public UniTask RequestGetActivityProgressReward(int activityId, int rewardId)
		{
			CiacconaGalController.<RequestGetActivityProgressReward>d__34 <RequestGetActivityProgressReward>d__;
			<RequestGetActivityProgressReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestGetActivityProgressReward>d__.activityId = activityId;
			<RequestGetActivityProgressReward>d__.rewardId = rewardId;
			<RequestGetActivityProgressReward>d__.<>1__state = -1;
			<RequestGetActivityProgressReward>d__.<>t__builder.Start<CiacconaGalController.<RequestGetActivityProgressReward>d__34>(ref <RequestGetActivityProgressReward>d__);
			return <RequestGetActivityProgressReward>d__.<>t__builder.Task;
		}

		// Token: 0x0603054D RID: 197965 RVA: 0x00D79EF0 File Offset: 0x00D780F0
		private void OnProtoChapterUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			ChapterUpdateNotify chapterUpdateNotify = (ChapterUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateAllChapterData(chapterUpdateNotify.ChapterDatas);
		}

		// Token: 0x0603054E RID: 197966 RVA: 0x00D79F14 File Offset: 0x00D78114
		private void OnInspirationDataUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			InspirationUpdateNotify inspirationUpdateNotify = (InspirationUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateInspirationData(inspirationUpdateNotify.InspirationData);
		}

		// Token: 0x0603054F RID: 197967 RVA: 0x00D79F38 File Offset: 0x00D78138
		private void OnProgressRewardUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			ScheduleRewardUpdateNotify scheduleRewardUpdateNotify = (ScheduleRewardUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateProgressRewardData(scheduleRewardUpdateNotify.ScheduleRewardDatas);
		}

		// Token: 0x06030550 RID: 197968 RVA: 0x00D79F5C File Offset: 0x00D7815C
		private void OnActivityResultUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			ActivityResultUpdateNotify activityResultUpdateNotify = (ActivityResultUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateAllEndingData(activityResultUpdateNotify.ActivityResultDatas);
		}

		// Token: 0x06030551 RID: 197969 RVA: 0x00D79F80 File Offset: 0x00D78180
		private void OnActivityStateUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			CiacconaActivityStateUnlockUpdateNotify data = (CiacconaActivityStateUnlockUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateActivityState(data);
		}

		// Token: 0x06030552 RID: 197970 RVA: 0x00D79FA0 File Offset: 0x00D781A0
		public void ReportEnterChapterEntryView(ECiacconaEntryType from)
		{
			if (from != ECiacconaEntryType.None)
			{
				CiacconaEnterMainViewLogEvent logData = new CiacconaEnterMainViewLogEvent((int)from);
				LogReportController.Instance.LogReport(logData);
			}
		}

		// Token: 0x170060CF RID: 24783
		// (get) Token: 0x06030553 RID: 197971 RVA: 0x00D79FC2 File Offset: 0x00D781C2
		[Nullable(1)]
		public static CiacconaGalController Instance
		{
			[NullableContext(1)]
			get
			{
				return CiacconaGalController._Instance;
			}
		}

		// Token: 0x06030554 RID: 197972 RVA: 0x00D79FC9 File Offset: 0x00D781C9
		[NullableContext(1)]
		public static CiacconaGalController GetOrCreateInstance()
		{
			if (CiacconaGalController._Instance == null)
			{
				CiacconaGalController.CreateInstance();
			}
			return CiacconaGalController._Instance;
		}

		// Token: 0x06030555 RID: 197973 RVA: 0x00D79FDD File Offset: 0x00D781DD
		public static bool CreateInstance()
		{
			if (CiacconaGalController._Instance != null)
			{
				return true;
			}
			CiacconaGalController._Instance = new CiacconaGalController();
			return true;
		}

		// Token: 0x06030556 RID: 197974 RVA: 0x00D79FF3 File Offset: 0x00D781F3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030557 RID: 197975 RVA: 0x00D79FF5 File Offset: 0x00D781F5
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalController._Instance = null;
		}

		// Token: 0x06030558 RID: 197976 RVA: 0x00D79FFD File Offset: 0x00D781FD
		static CiacconaGalController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalController.CreateStaticDefaultValue), new Action(CiacconaGalController.ResetStaticDefaultValue));
		}

		// Token: 0x040199B4 RID: 104884
		private CiacconaGalPlayer InternalGalPlayer;

		// Token: 0x040199B5 RID: 104885
		private bool IsViewReady;

		// Token: 0x040199B6 RID: 104886
		[Nullable(1)]
		private List<Action<int>> AvgDataUpdateDelegates = new List<Action<int>>();

		// Token: 0x040199B7 RID: 104887
		private static CiacconaGalController _Instance;
	}
}
