using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay
{
	// Token: 0x020066EF RID: 26351
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayProxy
	{
		// Token: 0x06041D83 RID: 269699 RVA: 0x00FF7A6D File Offset: 0x00FF5C6D
		[NullableContext(1)]
		public void RegisterView(DropCatchGameplayView view)
		{
			this.GameplayView = view;
		}

		// Token: 0x06041D84 RID: 269700 RVA: 0x00FF7A78 File Offset: 0x00FF5C78
		public UniTask StartGameplay(int gameplayId)
		{
			DropCatchGameplayProxy.<StartGameplay>d__6 <StartGameplay>d__;
			<StartGameplay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartGameplay>d__.<>4__this = this;
			<StartGameplay>d__.gameplayId = gameplayId;
			<StartGameplay>d__.<>1__state = -1;
			<StartGameplay>d__.<>t__builder.Start<DropCatchGameplayProxy.<StartGameplay>d__6>(ref <StartGameplay>d__);
			return <StartGameplay>d__.<>t__builder.Task;
		}

		// Token: 0x06041D85 RID: 269701 RVA: 0x00FF7AC4 File Offset: 0x00FF5CC4
		[NullableContext(1)]
		public unsafe void PauseGameplay(string reason)
		{
			this.PauseReason.Add(reason);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DropCatch;
			ELogAuthor author = ELogAuthor.CB;
			string message = "外部调用暂停游戏";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PauseCount", this.PauseReason.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.PauseReason.Count == 1)
			{
				this.PauseGate = new CustomPromise();
				DropCatchGameplayLogic gameplayLogic = this.GameplayLogic;
				if (gameplayLogic != null)
				{
					gameplayLogic.Pause();
				}
				DropCatchGameplayView gameplayView = this.GameplayView;
				if (gameplayView != null)
				{
					gameplayView.Pause();
				}
				Log.Instance.Info(ELogModule.DropCatch, ELogAuthor.CB, "暂停游戏逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06041D86 RID: 269702 RVA: 0x00FF7BA0 File Offset: 0x00FF5DA0
		[NullableContext(1)]
		public unsafe void ResumeGameplay(string reason)
		{
			this.PauseReason.Remove(reason);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DropCatch;
			ELogAuthor author = ELogAuthor.CB;
			string message = "外部调用恢复游戏";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PauseCount", this.PauseReason.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.PauseReason.Count == 0)
			{
				CustomPromise pauseGate = this.PauseGate;
				if (pauseGate != null)
				{
					pauseGate.SetResult();
				}
				DropCatchGameplayLogic gameplayLogic = this.GameplayLogic;
				if (gameplayLogic != null)
				{
					gameplayLogic.Resume();
				}
				DropCatchGameplayView gameplayView = this.GameplayView;
				if (gameplayView != null)
				{
					gameplayView.Resume();
				}
				Log.Instance.Info(ELogModule.DropCatch, ELogAuthor.CB, "恢复游戏逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06041D87 RID: 269703 RVA: 0x00FF7C80 File Offset: 0x00FF5E80
		public void SettleGameplay(EDropCatchGameplaySettleReason reason)
		{
			DropCatchGameplayLogic gameplayLogic = this.GameplayLogic;
			if (gameplayLogic != null)
			{
				gameplayLogic.End();
			}
			UiManager.Instance.OpenView(EUiViewName.DropCatchGameplayResultView, this, null);
			DropCatchGameplayController.Instance.SettleGameplay(new IDropCatchSettleGameplay
			{
				GameplayId = this.GameplayViewModel.GetCurGameplayId(),
				Score = this.GameplayViewModel.GetCurScore()
			}, delegate
			{
				this.LogEndReport(reason);
			});
		}

		// Token: 0x06041D88 RID: 269704 RVA: 0x00FF7D00 File Offset: 0x00FF5F00
		public void OnGameplayViewDestroyed()
		{
			this.RemoveEvents();
			DropCatchGameplayLogic gameplayLogic = this.GameplayLogic;
			if (gameplayLogic != null)
			{
				gameplayLogic.Destroy();
			}
			this.GameplayLogic = null;
			this.GameplayViewModel = null;
			this.GameplayView = null;
		}

		// Token: 0x06041D89 RID: 269705 RVA: 0x00FF7D2E File Offset: 0x00FF5F2E
		public void EndGameplay()
		{
			if (this.GameplayView != null)
			{
				UiManager.Instance.CloseView(EUiViewName.DropCatchGameplayView, null);
				this.GameplayView = null;
			}
		}

		// Token: 0x06041D8A RID: 269706 RVA: 0x00FF7D4F File Offset: 0x00FF5F4F
		public void UseRoleSkill()
		{
			DropCatchGameplayLogic gameplayLogic = this.GameplayLogic;
			if (gameplayLogic != null)
			{
				gameplayLogic.UseRoleSkill();
			}
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return;
			}
			gameplayViewModel.AddSkillTimes();
		}

		// Token: 0x06041D8B RID: 269707 RVA: 0x00FF7D74 File Offset: 0x00FF5F74
		public void AddScore(float score)
		{
			float score2 = score * this.GameplayLogic.GetAddScoreRate();
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel != null)
			{
				gameplayViewModel.AddScore(score2);
			}
			DropCatchGameplayView gameplayView = this.GameplayView;
			if (gameplayView == null)
			{
				return;
			}
			gameplayView.UpdateScore();
		}

		// Token: 0x06041D8C RID: 269708 RVA: 0x00FF7DB1 File Offset: 0x00FF5FB1
		public float GetCurScore()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return 0f;
			}
			return gameplayViewModel.GetCurScore();
		}

		// Token: 0x06041D8D RID: 269709 RVA: 0x00FF7DC8 File Offset: 0x00FF5FC8
		public int GetCurGameplayId()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return 0;
			}
			return gameplayViewModel.GetCurGameplayId();
		}

		// Token: 0x06041D8E RID: 269710 RVA: 0x00FF7DDB File Offset: 0x00FF5FDB
		public Dictionary<int, int> GetDropItemRecord()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return null;
			}
			return gameplayViewModel.GetDropItemRecord();
		}

		// Token: 0x06041D8F RID: 269711 RVA: 0x00FF7DEE File Offset: 0x00FF5FEE
		public void AddDropItemRecord(int itemId)
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return;
			}
			gameplayViewModel.AddDropItemRecord(itemId);
		}

		// Token: 0x06041D90 RID: 269712 RVA: 0x00FF7E04 File Offset: 0x00FF6004
		public DropCatchGameplay? GetGameplayConfig()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			int? num = (gameplayViewModel != null) ? new int?(gameplayViewModel.GetCurGameplayId()) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					return DropCatchConfig.Instance.GetDropCatchGameplayById(num.Value);
				}
			}
			return null;
		}

		// Token: 0x06041D91 RID: 269713 RVA: 0x00FF7E6D File Offset: 0x00FF606D
		public DropCatchGameplayLogic GetGameplayLogic()
		{
			return this.GameplayLogic;
		}

		// Token: 0x06041D92 RID: 269714 RVA: 0x00FF7E75 File Offset: 0x00FF6075
		public DropCatchGameplayViewModel GetGameplayViewModel()
		{
			return this.GameplayViewModel;
		}

		// Token: 0x06041D93 RID: 269715 RVA: 0x00FF7E7D File Offset: 0x00FF607D
		public DropCatchGameplayView GetGameplayView()
		{
			return this.GameplayView;
		}

		// Token: 0x06041D94 RID: 269716 RVA: 0x00FF7E85 File Offset: 0x00FF6085
		public bool GetEnableDebug()
		{
			return DropCatchGameplayController.Instance.EnableDebug;
		}

		// Token: 0x06041D95 RID: 269717 RVA: 0x00FF7E94 File Offset: 0x00FF6094
		private void LogStartReport()
		{
			if (this.GameplayViewModel == null)
			{
				return;
			}
			int curGameplayId = this.GameplayViewModel.GetCurGameplayId();
			DropCatchGameplay? dropCatchGameplay;
			int? num = (DropCatchConfig.Instance.GetDropCatchGameplayById(curGameplayId) != null) ? new int?(dropCatchGameplay.GetValueOrDefault().ActivityId) : null;
			if (num == null)
			{
				return;
			}
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(num.Value) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			DropCatchLevelData levelData = dropCatchActivityData.GetLevelData(curGameplayId);
			if (levelData == null)
			{
				return;
			}
			DropCatchGameplayStartReport dropCatchGameplayStartReport = new DropCatchGameplayStartReport();
			dropCatchGameplayStartReport.i_activity_id = num.Value;
			dropCatchGameplayStartReport.i_inst_id = curGameplayId;
			if (ActivityModel.Instance.GetActivityCacheData(dropCatchActivityData.Id, 0, curGameplayId, 0, 0) == 0)
			{
				dropCatchGameplayStartReport.i_first_pass = -1;
			}
			else
			{
				int highestScore = levelData.HighestScore;
				int num2 = 0;
				foreach (float num3 in this.GameplayViewModel.GetScoreLevels())
				{
					if ((float)highestScore >= num3)
					{
						num2++;
					}
				}
				dropCatchGameplayStartReport.i_first_pass = num2;
			}
			dropCatchGameplayStartReport.s_trace_id = this.GameplayViewModel.GetGameplayTimeStamp();
			LogReportController.Instance.LogReport(dropCatchGameplayStartReport);
		}

		// Token: 0x06041D96 RID: 269718 RVA: 0x00FF7FE4 File Offset: 0x00FF61E4
		private void LogEndReport(EDropCatchGameplaySettleReason reason)
		{
			if (this.GameplayViewModel == null || this.GameplayLogic == null)
			{
				return;
			}
			int curGameplayId = this.GameplayViewModel.GetCurGameplayId();
			DropCatchGameplay? dropCatchGameplay;
			int? num = (DropCatchConfig.Instance.GetDropCatchGameplayById(curGameplayId) != null) ? new int?(dropCatchGameplay.GetValueOrDefault().ActivityId) : null;
			if (num == null)
			{
				return;
			}
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(num.Value) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			DropCatchLevelData levelData = dropCatchActivityData.GetLevelData(curGameplayId);
			if (levelData == null)
			{
				return;
			}
			DropCatchGameplayEndReport dropCatchGameplayEndReport = new DropCatchGameplayEndReport();
			dropCatchGameplayEndReport.i_activity_id = num.Value;
			dropCatchGameplayEndReport.i_inst_id = curGameplayId;
			int highestScore = levelData.HighestScore;
			float curScore = this.GameplayViewModel.GetCurScore();
			int num2 = 0;
			int num3 = 0;
			foreach (float num4 in this.GameplayViewModel.GetScoreLevels())
			{
				if ((float)highestScore >= num4)
				{
					num2++;
				}
				if (curScore >= num4)
				{
					num3++;
				}
			}
			dropCatchGameplayEndReport.i_first_pass = ((num3 > num2) ? 1 : 0);
			dropCatchGameplayEndReport.s_trace_id = this.GameplayViewModel.GetGameplayTimeStamp();
			dropCatchGameplayEndReport.i_result = num3;
			dropCatchGameplayEndReport.i_reason = (int)reason;
			dropCatchGameplayEndReport.i_get_score = (int)curScore;
			dropCatchGameplayEndReport.i_skill_times = (int)this.GameplayViewModel.GetSkillTimes();
			dropCatchGameplayEndReport.i_cost_time = (int)((double)this.GameplayLogic.GetGameplayTimeMgr().GetTime() * TimeUtil.Instance.Millisecond);
			dropCatchGameplayEndReport.i_add_time = (int)this.GameplayViewModel.GetAddTime();
			Dictionary<int, int> dropItemRecord = this.GameplayViewModel.GetDropItemRecord();
			dropCatchGameplayEndReport.o_item_report = new List<int>
			{
				0,
				0,
				0,
				0
			};
			foreach (KeyValuePair<int, int> keyValuePair in dropItemRecord)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (key == 1)
				{
					dropCatchGameplayEndReport.o_item_report[0] = value;
				}
				else if (key == 2)
				{
					dropCatchGameplayEndReport.o_item_report[1] = value;
				}
				else
				{
					DropCatchDropItem? dropCatchDropItemById = DropCatchConfig.Instance.GetDropCatchDropItemById(key);
					if (dropCatchDropItemById != null && dropCatchDropItemById.GetValueOrDefault().EffectType == 0)
					{
						dropCatchGameplayEndReport.o_item_report[2] = value;
					}
					else
					{
						dropCatchGameplayEndReport.o_item_report[3] = value;
					}
				}
			}
			LogReportController.Instance.LogReport(dropCatchGameplayEndReport);
			ActivityModel.Instance.SaveActivityData(dropCatchActivityData.Id, curGameplayId, 0, 0, 1);
		}

		// Token: 0x06041D97 RID: 269719 RVA: 0x00FF82B0 File Offset: 0x00FF64B0
		private UniTask WaitAllPausePromises()
		{
			DropCatchGameplayProxy.<WaitAllPausePromises>d__25 <WaitAllPausePromises>d__;
			<WaitAllPausePromises>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitAllPausePromises>d__.<>4__this = this;
			<WaitAllPausePromises>d__.<>1__state = -1;
			<WaitAllPausePromises>d__.<>t__builder.Start<DropCatchGameplayProxy.<WaitAllPausePromises>d__25>(ref <WaitAllPausePromises>d__);
			return <WaitAllPausePromises>d__.<>t__builder.Task;
		}

		// Token: 0x06041D98 RID: 269720 RVA: 0x00FF82F4 File Offset: 0x00FF64F4
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has(EEventName.GuideGroupOpening, new Action<int, bool>(this.OnGuideGroupOpening)))
			{
				EventSystem.Instance.Add<int, bool>(EEventName.GuideGroupOpening, new Action<int, bool>(this.OnGuideGroupOpening));
			}
			if (!EventSystem.Instance.Has(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinished)))
			{
				EventSystem.Instance.Add<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinished));
			}
			if (!EventSystem.Instance.Has(EEventName.GuideGroupRest, new Action<int>(this.OnGuideGroupRest)))
			{
				EventSystem.Instance.Add<int>(EEventName.GuideGroupRest, new Action<int>(this.OnGuideGroupRest));
			}
		}

		// Token: 0x06041D99 RID: 269721 RVA: 0x00FF83AC File Offset: 0x00FF65AC
		private void OnGuideGroupOpening(int groupId, bool isPreExecute)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Guide_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupId);
			this.PauseGameplay(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06041D9A RID: 269722 RVA: 0x00FF83E4 File Offset: 0x00FF65E4
		private void OnGuideGroupFinished(int groupId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Guide_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupId);
			this.ResumeGameplay(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06041D9B RID: 269723 RVA: 0x00FF841C File Offset: 0x00FF661C
		private void OnGuideGroupRest(int groupId)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.GuideTutorialView) || UiManager.Instance.IsViewOpen(EUiViewName.GuideTutorialPopView))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "引导组重置,需要等待引导界面关闭";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				EventSystem.Instance.Once<EUiViewName, int>(EEventName.CloseView, delegate(EUiViewName viewName, int viewId)
				{
					if (viewName == EUiViewName.GuideTutorialView || viewName == EUiViewName.GuideTutorialPopView)
					{
						DropCatchGameplayProxy <>4__this = this;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("Guide_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(groupId);
						<>4__this.ResumeGameplay(defaultInterpolatedStringHandler2.ToStringAndClear());
					}
				});
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Guide_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupId);
			this.ResumeGameplay(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06041D9C RID: 269724 RVA: 0x00FF84DC File Offset: 0x00FF66DC
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has(EEventName.GuideGroupOpening, new Action<int, bool>(this.OnGuideGroupOpening)))
			{
				EventSystem.Instance.Remove(EEventName.GuideGroupOpening, new Action<int, bool>(this.OnGuideGroupOpening));
			}
			if (EventSystem.Instance.Has(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinished)))
			{
				EventSystem.Instance.Remove(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideGroupFinished));
			}
			if (EventSystem.Instance.Has(EEventName.GuideGroupRest, new Action<int>(this.OnGuideGroupRest)))
			{
				EventSystem.Instance.Remove(EEventName.GuideGroupRest, new Action<int>(this.OnGuideGroupRest));
			}
		}

		// Token: 0x06041D9D RID: 269725 RVA: 0x00FF8594 File Offset: 0x00FF6794
		[NullableContext(1)]
		public void PlayFlow(string[] flowId)
		{
			ChatPopViewData param = new ChatPopViewData
			{
				FlowId = new List<string>(flowId)
			};
			UiManager.Instance.OpenView(EUiViewName.DropCatchChatPopView, param, null);
		}

		// Token: 0x040224C5 RID: 140485
		private DropCatchGameplayLogic GameplayLogic;

		// Token: 0x040224C6 RID: 140486
		private DropCatchGameplayView GameplayView;

		// Token: 0x040224C7 RID: 140487
		private DropCatchGameplayViewModel GameplayViewModel;

		// Token: 0x040224C8 RID: 140488
		[Nullable(1)]
		private readonly HashSet<string> PauseReason = new HashSet<string>();

		// Token: 0x040224C9 RID: 140489
		private CustomPromise PauseGate;
	}
}
