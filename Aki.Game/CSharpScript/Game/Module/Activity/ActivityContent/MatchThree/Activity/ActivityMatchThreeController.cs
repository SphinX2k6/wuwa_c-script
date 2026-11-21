using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054BF RID: 21695
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMatchThreeController : ActivityControllerBase
	{
		// Token: 0x06035C24 RID: 220196 RVA: 0x00F04BB2 File Offset: 0x00F02DB2
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06035C25 RID: 220197 RVA: 0x00F04BB4 File Offset: 0x00F02DB4
		protected override void OnRegisterNetEvent()
		{
		}

		// Token: 0x06035C26 RID: 220198 RVA: 0x00F04BB6 File Offset: 0x00F02DB6
		protected override void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x06035C27 RID: 220199 RVA: 0x00F04BB8 File Offset: 0x00F02DB8
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add(EEventName.OnResetToBattleView, new Action(this.OnResetToBattleView));
		}

		// Token: 0x06035C28 RID: 220200 RVA: 0x00F04BF2 File Offset: 0x00F02DF2
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove(EEventName.OnResetToBattleView, new Action(this.OnResetToBattleView));
		}

		// Token: 0x06035C29 RID: 220201 RVA: 0x00F04C2C File Offset: 0x00F02E2C
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_Match3GameActivityMain";
		}

		// Token: 0x06035C2A RID: 220202 RVA: 0x00F04C33 File Offset: 0x00F02E33
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMatchThreeSubView();
		}

		// Token: 0x06035C2B RID: 220203 RVA: 0x00F04C3A File Offset: 0x00F02E3A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityMatchThreeData();
		}

		// Token: 0x06035C2C RID: 220204 RVA: 0x00F04C50 File Offset: 0x00F02E50
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeSelectLevelView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeLevelDetailView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreePopupInfoView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeGameplayView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeTargetPopView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeSuccessPopView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeFailPopView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeConfirmBoxView);
		}

		// Token: 0x06035C2D RID: 220205 RVA: 0x00F04CFC File Offset: 0x00F02EFC
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityMatchThreeController.<OnOpenSubView>d__12 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityMatchThreeController.<OnOpenSubView>d__12>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06035C2E RID: 220206 RVA: 0x00F04D40 File Offset: 0x00F02F40
		[NullableContext(2)]
		public ActivityMatchThreeData GetMatchThreeData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.MatchThreeActivity);
			if (currentActivitiesByType.Count > 0)
			{
				return currentActivitiesByType[0] as ActivityMatchThreeData;
			}
			return null;
		}

		// Token: 0x06035C2F RID: 220207 RVA: 0x00F04D71 File Offset: 0x00F02F71
		public IReadOnlyList<MatchThreeChapterSelectData> GetAllLevelSelectData()
		{
			ActivityMatchThreeData matchThreeData = this.GetMatchThreeData();
			return ((matchThreeData != null) ? matchThreeData.GetChapterSelectDataList() : null) ?? Array.Empty<MatchThreeChapterSelectData>();
		}

		// Token: 0x06035C30 RID: 220208 RVA: 0x00F04D90 File Offset: 0x00F02F90
		public void OpenLevelDetail(MatchThreeChapterSelectData chapterData)
		{
			ActivityMatchThreeData matchThreeData = this.GetMatchThreeData();
			if (matchThreeData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MatchThreeLevelDetailView, new MatchThreeLevelDetailViewModel
			{
				ChapterData = chapterData,
				DifficultyIndex = ActivityMatchThreeController.ResolveDefaultDifficultyIndex(chapterData, matchThreeData)
			}, null);
		}

		// Token: 0x06035C31 RID: 220209 RVA: 0x00F04DD1 File Offset: 0x00F02FD1
		public static int ResolveDefaultDifficultyIndex(MatchThreeChapterSelectData chapterData, ActivityMatchThreeData activityData)
		{
			if (chapterData.IsEndless || chapterData.HardLevelId <= 0 || chapterData.NormalLevelId <= 0 || !activityData.CheckChallengeComplete(chapterData.NormalLevelId) || activityData.CheckChallengeComplete(chapterData.HardLevelId))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06035C32 RID: 220210 RVA: 0x00F04E0C File Offset: 0x00F0300C
		[NullableContext(2)]
		public void OpenPopupInfo(MatchThreePopupInfoViewParams param = null)
		{
			UiManager.Instance.OpenView(EUiViewName.MatchThreePopupInfoView, param ?? new MatchThreePopupInfoViewParams(), null);
		}

		// Token: 0x06035C33 RID: 220211 RVA: 0x00F04E28 File Offset: 0x00F03028
		public void OpenPopupInfoByLevel(int levelId, int roleId = 0, bool includeTiles = true, int focusTileId = 0, int focusEnvId = 0)
		{
			MatchThreePopupInfoViewParams matchThreePopupInfoViewParams = ActivityMatchThreeConfig.Instance.BuildPopupInfoParams(levelId, roleId, includeTiles, focusTileId, focusEnvId);
			if (!matchThreePopupInfoViewParams.HasAny)
			{
				return;
			}
			this.OpenPopupInfo(matchThreePopupInfoViewParams);
		}

		// Token: 0x06035C34 RID: 220212 RVA: 0x00F04E57 File Offset: 0x00F03057
		public void OpenRoleSelect(MatchThreeRoleSelectViewParams param)
		{
			UiManager.Instance.OpenView(EUiViewName.MatchThreeRoleSelectView, param, null);
		}

		// Token: 0x06035C35 RID: 220213 RVA: 0x00F04E6A File Offset: 0x00F0306A
		[NullableContext(2)]
		public void OpenRoleInfo(int roleId, Action onClosed = null)
		{
			if (roleId <= 0)
			{
				return;
			}
			this.OpenRoleSelect(new MatchThreeRoleSelectViewParams
			{
				Mode = EMatchThreeRolePopupMode.Info,
				FocusRoleId = roleId,
				OnClosed = onClosed
			});
		}

		// Token: 0x06035C36 RID: 220214 RVA: 0x00F04E91 File Offset: 0x00F03091
		[NullableContext(2)]
		public void OpenRoleUnlock(int roleId, Action onClosed = null)
		{
			if (roleId <= 0)
			{
				return;
			}
			this.OpenRoleSelect(new MatchThreeRoleSelectViewParams
			{
				Mode = EMatchThreeRolePopupMode.Unlock,
				FocusRoleId = roleId,
				OnClosed = onClosed
			});
		}

		// Token: 0x06035C37 RID: 220215 RVA: 0x00F04EB8 File Offset: 0x00F030B8
		[NullableContext(2)]
		public void TryShowPendingRoleUnlockTips(Action onAllClosed = null)
		{
			ActivityMatchThreeData matchThreeData = this.GetMatchThreeData();
			if (matchThreeData == null)
			{
				if (onAllClosed != null)
				{
					onAllClosed();
				}
				return;
			}
			IReadOnlyList<int> pendingUnlockTipRoleIds = matchThreeData.GetPendingUnlockTipRoleIds();
			if (pendingUnlockTipRoleIds.Count == 0)
			{
				if (onAllClosed != null)
				{
					onAllClosed();
				}
				return;
			}
			this.ShowUnlockTipAt(matchThreeData, pendingUnlockTipRoleIds, 0, onAllClosed);
		}

		// Token: 0x06035C38 RID: 220216 RVA: 0x00F04EFC File Offset: 0x00F030FC
		private void ShowUnlockTipAt(ActivityMatchThreeData data, IReadOnlyList<int> pending, int index, [Nullable(2)] Action onAllClosed)
		{
			if (index >= 0 && index < pending.Count)
			{
				int roleId = pending[index];
				this.OpenRoleUnlock(roleId, delegate
				{
					data.MarkRoleUnlockTipShown(roleId);
					this.ShowUnlockTipAt(data, pending, index + 1, onAllClosed);
				});
				return;
			}
			Action onAllClosed2 = onAllClosed;
			if (onAllClosed2 == null)
			{
				return;
			}
			onAllClosed2();
		}

		// Token: 0x06035C39 RID: 220217 RVA: 0x00F04F90 File Offset: 0x00F03190
		[NullableContext(2)]
		public void TryEnterLevel(int levelId, int roleId, Action<bool> onFinished = null)
		{
			if (levelId > 0 && !this.StartRequestPending && MatchThreeController.Instance.CurrentPresenter == null)
			{
				int requestGeneration = this.StartRequestGeneration;
				this.StartRequestPending = true;
				this.SendStartRequest(levelId, roleId, delegate(string traceId)
				{
					if (requestGeneration != this.StartRequestGeneration)
					{
						return;
					}
					this.StartRequestPending = false;
					if (string.IsNullOrEmpty(traceId))
					{
						Action<bool> onFinished3 = onFinished;
						if (onFinished3 == null)
						{
							return;
						}
						onFinished3(false);
						return;
					}
					else
					{
						MatchThreeController.Instance.Start(new MatchThreeGameplayContext(levelId, traceId, roleId, false));
						Action<bool> onFinished4 = onFinished;
						if (onFinished4 == null)
						{
							return;
						}
						onFinished4(true);
						return;
					}
				});
				return;
			}
			Action<bool> onFinished2 = onFinished;
			if (onFinished2 == null)
			{
				return;
			}
			onFinished2(false);
		}

		// Token: 0x06035C3A RID: 220218 RVA: 0x00F05020 File Offset: 0x00F03220
		public void SendStartRequest(int levelId, int roleId, [Nullable(new byte[]
		{
			1,
			2
		})] Action<string> callback)
		{
			int requestGeneration = this.StartRequestGeneration;
			MatchThreeStarRequest matchThreeStarRequest = MatchThreeStarRequest.Create();
			matchThreeStarRequest.LevelId = levelId;
			matchThreeStarRequest.JoinRole = roleId;
			Net.Instance.Call(ERequestMessageId.MatchThreeStarRequest, matchThreeStarRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if (requestGeneration != this.StartRequestGeneration)
				{
					Action<string> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(null);
					return;
				}
				else
				{
					MatchThreeStarResponse matchThreeStarResponse = (MatchThreeStarResponse)msg;
					if (matchThreeStarResponse == null)
					{
						Action<string> callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3(null);
						return;
					}
					else
					{
						if (matchThreeStarResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
						{
							Action<string> callback4 = callback;
							if (callback4 != null)
							{
								callback4(matchThreeStarResponse.TraceId);
							}
							this.ReportLevelEnterLog(levelId, roleId, matchThreeStarResponse.TraceId);
							return;
						}
						ErrorCodeController.Instance.OpenErrorCodeTipView(matchThreeStarResponse.ErrorCode, 28482, null, true, true);
						Action<string> callback5 = callback;
						if (callback5 == null)
						{
							return;
						}
						callback5(null);
						return;
					}
				}
			}, 0);
		}

		// Token: 0x06035C3B RID: 220219 RVA: 0x00F05098 File Offset: 0x00F03298
		private void OnResetToBattleView()
		{
			this.InvalidateStartRequest();
			MatchThreeController instance = MatchThreeController.Instance;
			if (instance.CurrentPresenter == null && instance.Context == null)
			{
				return;
			}
			instance.End(false);
		}

		// Token: 0x06035C3C RID: 220220 RVA: 0x00F050CC File Offset: 0x00F032CC
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			foreach (int id in closeActivities)
			{
				ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(id);
				if (activityById != null && activityById.Type == ActivityType.MatchThreeActivity)
				{
					this.InvalidateStartRequest();
					break;
				}
			}
		}

		// Token: 0x06035C3D RID: 220221 RVA: 0x00F05138 File Offset: 0x00F03338
		private void InvalidateStartRequest()
		{
			this.StartRequestGeneration++;
			this.StartRequestPending = false;
		}

		// Token: 0x06035C3E RID: 220222 RVA: 0x00F05150 File Offset: 0x00F03350
		[NullableContext(2)]
		private void ReportLevelEnterLog(int levelId, int roleId, string traceId)
		{
			if (string.IsNullOrEmpty(traceId))
			{
				return;
			}
			MatchThreeLevelEnterLogData matchThreeLevelEnterLogData = new MatchThreeLevelEnterLogData();
			matchThreeLevelEnterLogData.i_activity_id = this.ActivityId;
			matchThreeLevelEnterLogData.i_activity_type = 116;
			matchThreeLevelEnterLogData.i_level_id = levelId;
			matchThreeLevelEnterLogData.i_inst_diff = ActivityMatchThreeConfig.Instance.GetReportDifficulty(levelId);
			matchThreeLevelEnterLogData.s_trace_id = traceId;
			matchThreeLevelEnterLogData.i_role_id = roleId;
			ActivityMatchThreeData matchThreeData = this.GetMatchThreeData();
			matchThreeLevelEnterLogData.i_i_first_pass = (((matchThreeData != null && matchThreeData.CheckChallengeComplete(levelId)) > false) ? 1 : 0);
			MatchThreeLevelEnterLogData logData = matchThreeLevelEnterLogData;
			LogReportController.Instance.LogReport(logData);
		}

		// Token: 0x06035C3F RID: 220223 RVA: 0x00F051D0 File Offset: 0x00F033D0
		public void SendCompleteRequest(int levelId, string traceId, Dictionary<EGoalCondType, int> results, [Nullable(2)] Action<bool> callback = null)
		{
			MatchThreeEndRequest matchThreeEndRequest = MatchThreeEndRequest.Create();
			matchThreeEndRequest.LevelId = levelId;
			matchThreeEndRequest.TraceId = traceId;
			foreach (KeyValuePair<EGoalCondType, int> keyValuePair in results)
			{
				matchThreeEndRequest.Results[(int)keyValuePair.Key] = keyValuePair.Value;
			}
			Net.Instance.Call(ERequestMessageId.MatchThreeEndRequest, matchThreeEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MatchThreeEndResponse matchThreeEndResponse = (MatchThreeEndResponse)msg;
				if (matchThreeEndResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (matchThreeEndResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(matchThreeEndResponse.ErrorCode, 20119, null, true, true);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
				else
				{
					if (matchThreeEndResponse.Success)
					{
						this.ApplyLevelCompleteLocalState(levelId, results);
					}
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(matchThreeEndResponse.Success);
					return;
				}
			}, 0);
		}

		// Token: 0x06035C40 RID: 220224 RVA: 0x00F05290 File Offset: 0x00F03490
		private void ApplyLevelCompleteLocalState(int levelId, Dictionary<EGoalCondType, int> results)
		{
			ActivityMatchThreeData matchThreeData = this.GetMatchThreeData();
			if (matchThreeData == null)
			{
				return;
			}
			matchThreeData.UpdateChallengeFirstPass(levelId, true);
			MatchThreeLevel? levelConfig = matchThreeData.GetLevelConfig(levelId);
			int num;
			if (levelConfig != null && levelConfig.GetValueOrDefault().EndLess && results.TryGetValue(EGoalCondType.Score, out num))
			{
				MatchThreeLevelInfo levelInfo = matchThreeData.GetLevelInfo(levelId);
				if (levelInfo == null || !levelInfo.HasScore || num > levelInfo.Score)
				{
					matchThreeData.UpdateEndlessScore(levelId, num);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, matchThreeData.Id);
		}

		// Token: 0x17006898 RID: 26776
		// (get) Token: 0x06035C41 RID: 220225 RVA: 0x00F0531B File Offset: 0x00F0351B
		public static ActivityMatchThreeController Instance
		{
			get
			{
				return ActivityMatchThreeController._Instance;
			}
		}

		// Token: 0x06035C42 RID: 220226 RVA: 0x00F05322 File Offset: 0x00F03522
		public static ActivityMatchThreeController GetOrCreateInstance()
		{
			if (ActivityMatchThreeController._Instance == null)
			{
				ActivityMatchThreeController.CreateInstance();
			}
			return ActivityMatchThreeController._Instance;
		}

		// Token: 0x06035C43 RID: 220227 RVA: 0x00F05336 File Offset: 0x00F03536
		public static bool CreateInstance()
		{
			if (ActivityMatchThreeController._Instance != null)
			{
				return true;
			}
			ActivityMatchThreeController._Instance = new ActivityMatchThreeController();
			return true;
		}

		// Token: 0x06035C44 RID: 220228 RVA: 0x00F0534C File Offset: 0x00F0354C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035C45 RID: 220229 RVA: 0x00F0534E File Offset: 0x00F0354E
		public static void ResetStaticDefaultValue()
		{
			ActivityMatchThreeController._Instance = null;
		}

		// Token: 0x06035C46 RID: 220230 RVA: 0x00F05356 File Offset: 0x00F03556
		static ActivityMatchThreeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMatchThreeController.CreateStaticDefaultValue), new Action(ActivityMatchThreeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C73E RID: 116542
		public int ActivityId;

		// Token: 0x0401C73F RID: 116543
		private bool StartRequestPending;

		// Token: 0x0401C740 RID: 116544
		private int StartRequestGeneration;

		// Token: 0x0401C741 RID: 116545
		[Nullable(2)]
		private static ActivityMatchThreeController _Instance;
	}
}
