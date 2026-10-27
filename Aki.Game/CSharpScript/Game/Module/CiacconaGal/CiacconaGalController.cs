using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005BB1 RID: 23473
	[NullableContext(2)]
	[Nullable(0)]
	[TickController(0)]
	public class CiacconaGalController : ControllerBase
	{
		// Token: 0x17008CFB RID: 36091
		// (get) Token: 0x0603B5E2 RID: 243170 RVA: 0x00E29388 File Offset: 0x00E27588
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17008CFC RID: 36092
		// (get) Token: 0x0603B5E3 RID: 243171 RVA: 0x00E2938B File Offset: 0x00E2758B
		public CiacconaGalPlayer GalPlayer
		{
			get
			{
				return this.InternalGalPlayer;
			}
		}

		// Token: 0x0603B5E4 RID: 243172 RVA: 0x00E29393 File Offset: 0x00E27593
		protected override bool OnInit()
		{
			this.InternalGalPlayer = CiacconaGalPlayer.Instance;
			this.AddNetListeners();
			return true;
		}

		// Token: 0x0603B5E5 RID: 243173 RVA: 0x00E293A7 File Offset: 0x00E275A7
		protected override bool OnClear()
		{
			this.AvgDataUpdateDelegates = new List<Action<int>>();
			this.InternalGalPlayer.Release();
			this.RemoveNetListeners();
			return true;
		}

		// Token: 0x0603B5E6 RID: 243174 RVA: 0x00E293C6 File Offset: 0x00E275C6
		protected override void OnTick(float delta)
		{
			this.TickAvg(delta);
			this.TickDataUpdate(delta);
		}

		// Token: 0x0603B5E7 RID: 243175 RVA: 0x00E293D6 File Offset: 0x00E275D6
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

		// Token: 0x0603B5E8 RID: 243176 RVA: 0x00E2940B File Offset: 0x00E2760B
		private void TickDataUpdate(float delta)
		{
			if (CiacconaGalModel.Instance.DataUpdateMask != 0)
			{
				this.NotifyActivityDataUpdate(CiacconaGalModel.Instance.DataUpdateMask);
				CiacconaGalModel.Instance.DataUpdateMask = 0;
			}
		}

		// Token: 0x0603B5E9 RID: 243177 RVA: 0x00E29434 File Offset: 0x00E27634
		private void AddNetListeners()
		{
			Net.Instance.Register(ENotifyMessageId.ChapterUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnProtoChapterUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InspirationUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInspirationDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.ScheduleRewardUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnProgressRewardUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.ActivityResultUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityResultUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.CiacconaActivityStateUnlockUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityStateUpdateNotify));
		}

		// Token: 0x0603B5EA RID: 243178 RVA: 0x00E294D0 File Offset: 0x00E276D0
		private void RemoveNetListeners()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ChapterUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InspirationUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ScheduleRewardUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ActivityResultUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.CiacconaActivityStateUnlockUpdateNotify);
		}

		// Token: 0x0603B5EB RID: 243179 RVA: 0x00E29530 File Offset: 0x00E27730
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

		// Token: 0x0603B5EC RID: 243180 RVA: 0x00E295CC File Offset: 0x00E277CC
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

		// Token: 0x0603B5ED RID: 243181 RVA: 0x00E2960C File Offset: 0x00E2780C
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

		// Token: 0x0603B5EE RID: 243182 RVA: 0x00E29668 File Offset: 0x00E27868
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

		// Token: 0x0603B5EF RID: 243183 RVA: 0x00E296BC File Offset: 0x00E278BC
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

		// Token: 0x0603B5F0 RID: 243184 RVA: 0x00E29707 File Offset: 0x00E27907
		public void OpenEndingView()
		{
			UiManager.Instance.OpenView(EUiViewName.CiacconaGalEndingView, null, null);
		}

		// Token: 0x0603B5F1 RID: 243185 RVA: 0x00E2971C File Offset: 0x00E2791C
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

		// Token: 0x0603B5F2 RID: 243186 RVA: 0x00E29768 File Offset: 0x00E27968
		public void OpenChapterEntryView(int activityId, ECiacconaEntryType from = ECiacconaEntryType.None)
		{
			CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(activityId);
			if (activityDataById != null)
			{
				UiManager.Instance.OpenView(EUiViewName.CiacconaGalChapterEntryView, activityDataById, null);
				this.ReportEnterChapterEntryView(from);
			}
		}

		// Token: 0x0603B5F3 RID: 243187 RVA: 0x00E2979C File Offset: 0x00E2799C
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

		// Token: 0x0603B5F4 RID: 243188 RVA: 0x00E297F0 File Offset: 0x00E279F0
		public void OpenRewardViewByActivityId(int activityId)
		{
			CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(activityId);
			if (activityDataById != null && activityDataById.IsInRewardTime)
			{
				UiManager.Instance.OpenView(EUiViewName.CiacconaActivityRewardView, activityDataById, null);
			}
		}

		// Token: 0x0603B5F5 RID: 243189 RVA: 0x00E29828 File Offset: 0x00E27A28
		public UniTask ExitAvg()
		{
			CiacconaGalController.<ExitAvg>d__24 <ExitAvg>d__;
			<ExitAvg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitAvg>d__.<>4__this = this;
			<ExitAvg>d__.<>1__state = -1;
			<ExitAvg>d__.<>t__builder.Start<CiacconaGalController.<ExitAvg>d__24>(ref <ExitAvg>d__);
			return <ExitAvg>d__.<>t__builder.Task;
		}

		// Token: 0x0603B5F6 RID: 243190 RVA: 0x00E2986B File Offset: 0x00E27A6B
		[NullableContext(1)]
		public void AddOnStepDataUpdate(Action<int> @delegate)
		{
			this.AvgDataUpdateDelegates.Add(@delegate);
		}

		// Token: 0x0603B5F7 RID: 243191 RVA: 0x00E2987C File Offset: 0x00E27A7C
		[NullableContext(1)]
		public void RemoveOnStepDataUpdate(Action<int> @delegate)
		{
			int num = this.AvgDataUpdateDelegates.IndexOf(@delegate);
			if (num != -1)
			{
				this.AvgDataUpdateDelegates.RemoveAt(num);
			}
		}

		// Token: 0x0603B5F8 RID: 243192 RVA: 0x00E298A6 File Offset: 0x00E27AA6
		public void SetGalViewReady(bool isReady)
		{
			this.IsViewReady = isReady;
			if (!isReady)
			{
				this.InternalGalPlayer.Reset();
			}
		}

		// Token: 0x0603B5F9 RID: 243193 RVA: 0x00E298C0 File Offset: 0x00E27AC0
		private void NotifyDataUpdate()
		{
			foreach (Action<int> action in this.AvgDataUpdateDelegates)
			{
				action(this.GalPlayer.CurHandlingStepId);
			}
			CiacconaGalModel.Instance.IsCurStepDataListDirty = false;
		}

		// Token: 0x0603B5FA RID: 243194 RVA: 0x00E29928 File Offset: 0x00E27B28
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
			CiacconaGalChapterData ciacconaGalChapterData = allChapterData.Find((CiacconaGalChapterData data) => data.StepIds.Contains(targetStepId));
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

		// Token: 0x0603B5FB RID: 243195 RVA: 0x00E299F8 File Offset: 0x00E27BF8
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

		// Token: 0x0603B5FC RID: 243196 RVA: 0x00E29A4C File Offset: 0x00E27C4C
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

		// Token: 0x0603B5FD RID: 243197 RVA: 0x00E29AA0 File Offset: 0x00E27CA0
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

		// Token: 0x0603B5FE RID: 243198 RVA: 0x00E29AF4 File Offset: 0x00E27CF4
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

		// Token: 0x0603B5FF RID: 243199 RVA: 0x00E29B40 File Offset: 0x00E27D40
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

		// Token: 0x0603B600 RID: 243200 RVA: 0x00E29B8C File Offset: 0x00E27D8C
		private void OnProtoChapterUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			ChapterUpdateNotify chapterUpdateNotify = (ChapterUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateAllChapterData(chapterUpdateNotify.ChapterDatas.ToArray<CiacconaChapterPbData>());
		}

		// Token: 0x0603B601 RID: 243201 RVA: 0x00E29BB8 File Offset: 0x00E27DB8
		private void OnInspirationDataUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			InspirationUpdateNotify inspirationUpdateNotify = (InspirationUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateInspirationData(inspirationUpdateNotify.InspirationData);
		}

		// Token: 0x0603B602 RID: 243202 RVA: 0x00E29BDC File Offset: 0x00E27DDC
		private void OnProgressRewardUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			ScheduleRewardUpdateNotify scheduleRewardUpdateNotify = (ScheduleRewardUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateProgressRewardData(scheduleRewardUpdateNotify.ScheduleRewardDatas.ToArray<CiacconaScheduleRewardPbData>());
		}

		// Token: 0x0603B603 RID: 243203 RVA: 0x00E29C08 File Offset: 0x00E27E08
		private void OnActivityResultUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			ActivityResultUpdateNotify activityResultUpdateNotify = (ActivityResultUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateAllEndingData(activityResultUpdateNotify.ActivityResultDatas.ToArray<CiacconaActivityResultPbData>());
		}

		// Token: 0x0603B604 RID: 243204 RVA: 0x00E29C34 File Offset: 0x00E27E34
		private void OnActivityStateUpdateNotify(IMessage __msg, Net.CallbackStatus _)
		{
			CiacconaActivityStateUnlockUpdateNotify data = (CiacconaActivityStateUnlockUpdateNotify)__msg;
			CiacconaGalModel.Instance.UpdateActivityState(data);
		}

		// Token: 0x0603B605 RID: 243205 RVA: 0x00E29C54 File Offset: 0x00E27E54
		public void ReportEnterChapterEntryView(ECiacconaEntryType from)
		{
			if (from != ECiacconaEntryType.None)
			{
				CiacconaEnterMainViewLogEvent logData = new CiacconaEnterMainViewLogEvent((int)from);
				LogReportController.Instance.LogReport(logData);
			}
		}

		// Token: 0x17008CFD RID: 36093
		// (get) Token: 0x0603B606 RID: 243206 RVA: 0x00E29C76 File Offset: 0x00E27E76
		[Nullable(1)]
		public static CiacconaGalController Instance
		{
			[NullableContext(1)]
			get
			{
				return CiacconaGalController._Instance;
			}
		}

		// Token: 0x0603B607 RID: 243207 RVA: 0x00E29C7D File Offset: 0x00E27E7D
		[NullableContext(1)]
		public static CiacconaGalController GetOrCreateInstance()
		{
			if (CiacconaGalController._Instance == null)
			{
				CiacconaGalController.CreateInstance();
			}
			return CiacconaGalController._Instance;
		}

		// Token: 0x0603B608 RID: 243208 RVA: 0x00E29C91 File Offset: 0x00E27E91
		public static bool CreateInstance()
		{
			if (CiacconaGalController._Instance != null)
			{
				return true;
			}
			CiacconaGalController._Instance = new CiacconaGalController();
			return true;
		}

		// Token: 0x0603B609 RID: 243209 RVA: 0x00E29CA7 File Offset: 0x00E27EA7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B60A RID: 243210 RVA: 0x00E29CA9 File Offset: 0x00E27EA9
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalController._Instance = null;
		}

		// Token: 0x0603B60B RID: 243211 RVA: 0x00E29CB1 File Offset: 0x00E27EB1
		static CiacconaGalController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalController.CreateStaticDefaultValue), new Action(CiacconaGalController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EF03 RID: 126723
		private CiacconaGalPlayer InternalGalPlayer;

		// Token: 0x0401EF04 RID: 126724
		private bool IsViewReady;

		// Token: 0x0401EF05 RID: 126725
		[Nullable(1)]
		private List<Action<int>> AvgDataUpdateDelegates = new List<Action<int>>();

		// Token: 0x0401EF06 RID: 126726
		private static CiacconaGalController _Instance;
	}
}
