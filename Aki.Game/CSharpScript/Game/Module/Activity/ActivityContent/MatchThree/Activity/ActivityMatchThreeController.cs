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
	// Token: 0x02006541 RID: 25921
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMatchThreeController : ActivityControllerBase
	{
		// Token: 0x06040F5F RID: 266079 RVA: 0x00FBDBCA File Offset: 0x00FBBDCA
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06040F60 RID: 266080 RVA: 0x00FBDBCC File Offset: 0x00FBBDCC
		protected override void OnRegisterNetEvent()
		{
		}

		// Token: 0x06040F61 RID: 266081 RVA: 0x00FBDBCE File Offset: 0x00FBBDCE
		protected override void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x06040F62 RID: 266082 RVA: 0x00FBDBD0 File Offset: 0x00FBBDD0
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add(EEventName.OnResetToBattleView, new Action(this.OnResetToBattleView));
		}

		// Token: 0x06040F63 RID: 266083 RVA: 0x00FBDC0A File Offset: 0x00FBBE0A
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove(EEventName.OnResetToBattleView, new Action(this.OnResetToBattleView));
		}

		// Token: 0x06040F64 RID: 266084 RVA: 0x00FBDC44 File Offset: 0x00FBBE44
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_Match3GameActivityMain";
		}

		// Token: 0x06040F65 RID: 266085 RVA: 0x00FBDC4B File Offset: 0x00FBBE4B
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMatchThreeSubView();
		}

		// Token: 0x06040F66 RID: 266086 RVA: 0x00FBDC52 File Offset: 0x00FBBE52
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityMatchThreeData();
		}

		// Token: 0x06040F67 RID: 266087 RVA: 0x00FBDC68 File Offset: 0x00FBBE68
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeSelectLevelView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeLevelDetailView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreePopupInfoView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeGameplayView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeTargetPopView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeSuccessPopView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeFailPopView) || UiManager.Instance.IsViewOpen(EUiViewName.MatchThreeConfirmBoxView);
		}

		// Token: 0x06040F68 RID: 266088 RVA: 0x00FBDD14 File Offset: 0x00FBBF14
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

		// Token: 0x06040F69 RID: 266089 RVA: 0x00FBDD58 File Offset: 0x00FBBF58
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

		// Token: 0x06040F6A RID: 266090 RVA: 0x00FBDD89 File Offset: 0x00FBBF89
		public IReadOnlyList<MatchThreeChapterSelectData> GetAllLevelSelectData()
		{
			ActivityMatchThreeData matchThreeData = this.GetMatchThreeData();
			return ((matchThreeData != null) ? matchThreeData.GetChapterSelectDataList() : null) ?? Array.Empty<MatchThreeChapterSelectData>();
		}

		// Token: 0x06040F6B RID: 266091 RVA: 0x00FBDDA8 File Offset: 0x00FBBFA8
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

		// Token: 0x06040F6C RID: 266092 RVA: 0x00FBDDE9 File Offset: 0x00FBBFE9
		public static int ResolveDefaultDifficultyIndex(MatchThreeChapterSelectData chapterData, ActivityMatchThreeData activityData)
		{
			if (chapterData.IsEndless || chapterData.HardLevelId <= 0 || chapterData.NormalLevelId <= 0 || !activityData.CheckChallengeComplete(chapterData.NormalLevelId) || activityData.CheckChallengeComplete(chapterData.HardLevelId))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06040F6D RID: 266093 RVA: 0x00FBDE24 File Offset: 0x00FBC024
		[NullableContext(2)]
		public void OpenPopupInfo(MatchThreePopupInfoViewParams param = null)
		{
			UiManager.Instance.OpenView(EUiViewName.MatchThreePopupInfoView, param ?? new MatchThreePopupInfoViewParams(), null);
		}

		// Token: 0x06040F6E RID: 266094 RVA: 0x00FBDE40 File Offset: 0x00FBC040
		public void OpenPopupInfoByLevel(int levelId, int roleId = 0, bool includeTiles = true, int focusTileId = 0, int focusEnvId = 0)
		{
			MatchThreePopupInfoViewParams matchThreePopupInfoViewParams = ActivityMatchThreeConfig.Instance.BuildPopupInfoParams(levelId, roleId, includeTiles, focusTileId, focusEnvId);
			if (!matchThreePopupInfoViewParams.HasAny)
			{
				return;
			}
			this.OpenPopupInfo(matchThreePopupInfoViewParams);
		}

		// Token: 0x06040F6F RID: 266095 RVA: 0x00FBDE6F File Offset: 0x00FBC06F
		public void OpenRoleSelect(MatchThreeRoleSelectViewParams param)
		{
			UiManager.Instance.OpenView(EUiViewName.MatchThreeRoleSelectView, param, null);
		}

		// Token: 0x06040F70 RID: 266096 RVA: 0x00FBDE82 File Offset: 0x00FBC082
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

		// Token: 0x06040F71 RID: 266097 RVA: 0x00FBDEA9 File Offset: 0x00FBC0A9
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

		// Token: 0x06040F72 RID: 266098 RVA: 0x00FBDED0 File Offset: 0x00FBC0D0
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

		// Token: 0x06040F73 RID: 266099 RVA: 0x00FBDF14 File Offset: 0x00FBC114
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

		// Token: 0x06040F74 RID: 266100 RVA: 0x00FBDFA8 File Offset: 0x00FBC1A8
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

		// Token: 0x06040F75 RID: 266101 RVA: 0x00FBE038 File Offset: 0x00FBC238
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
						ErrorCodeController.Instance.OpenErrorCodeTipView(matchThreeStarResponse.ErrorCode, 19999, null, true, true);
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

		// Token: 0x06040F76 RID: 266102 RVA: 0x00FBE0B0 File Offset: 0x00FBC2B0
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

		// Token: 0x06040F77 RID: 266103 RVA: 0x00FBE0E4 File Offset: 0x00FBC2E4
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

		// Token: 0x06040F78 RID: 266104 RVA: 0x00FBE150 File Offset: 0x00FBC350
		private void InvalidateStartRequest()
		{
			this.StartRequestGeneration++;
			this.StartRequestPending = false;
		}

		// Token: 0x06040F79 RID: 266105 RVA: 0x00FBE168 File Offset: 0x00FBC368
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

		// Token: 0x06040F7A RID: 266106 RVA: 0x00FBE1E8 File Offset: 0x00FBC3E8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(matchThreeEndResponse.ErrorCode, 28958, null, true, true);
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

		// Token: 0x06040F7B RID: 266107 RVA: 0x00FBE2A8 File Offset: 0x00FBC4A8
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

		// Token: 0x17009536 RID: 38198
		// (get) Token: 0x06040F7C RID: 266108 RVA: 0x00FBE333 File Offset: 0x00FBC533
		public static ActivityMatchThreeController Instance
		{
			get
			{
				return ActivityMatchThreeController._Instance;
			}
		}

		// Token: 0x06040F7D RID: 266109 RVA: 0x00FBE33A File Offset: 0x00FBC53A
		public static ActivityMatchThreeController GetOrCreateInstance()
		{
			if (ActivityMatchThreeController._Instance == null)
			{
				ActivityMatchThreeController.CreateInstance();
			}
			return ActivityMatchThreeController._Instance;
		}

		// Token: 0x06040F7E RID: 266110 RVA: 0x00FBE34E File Offset: 0x00FBC54E
		public static bool CreateInstance()
		{
			if (ActivityMatchThreeController._Instance != null)
			{
				return true;
			}
			ActivityMatchThreeController._Instance = new ActivityMatchThreeController();
			return true;
		}

		// Token: 0x06040F7F RID: 266111 RVA: 0x00FBE364 File Offset: 0x00FBC564
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040F80 RID: 266112 RVA: 0x00FBE366 File Offset: 0x00FBC566
		public static void ResetStaticDefaultValue()
		{
			ActivityMatchThreeController._Instance = null;
		}

		// Token: 0x06040F81 RID: 266113 RVA: 0x00FBE36E File Offset: 0x00FBC56E
		static ActivityMatchThreeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMatchThreeController.CreateStaticDefaultValue), new Action(ActivityMatchThreeController.ResetStaticDefaultValue));
		}

		// Token: 0x04021E0D RID: 138765
		public int ActivityId;

		// Token: 0x04021E0E RID: 138766
		private bool StartRequestPending;

		// Token: 0x04021E0F RID: 138767
		private int StartRequestGeneration;

		// Token: 0x04021E10 RID: 138768
		[Nullable(2)]
		private static ActivityMatchThreeController _Instance;
	}
}
