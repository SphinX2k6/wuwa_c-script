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
	// Token: 0x0200563F RID: 22079
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayProxy
	{
		// Token: 0x060368CF RID: 223439 RVA: 0x00F38E61 File Offset: 0x00F37061
		[NullableContext(1)]
		public void RegisterView(DropCatchGameplayView view)
		{
			this.GameplayView = view;
		}

		// Token: 0x060368D0 RID: 223440 RVA: 0x00F38E6C File Offset: 0x00F3706C
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

		// Token: 0x060368D1 RID: 223441 RVA: 0x00F38EB8 File Offset: 0x00F370B8
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

		// Token: 0x060368D2 RID: 223442 RVA: 0x00F38F94 File Offset: 0x00F37194
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

		// Token: 0x060368D3 RID: 223443 RVA: 0x00F39074 File Offset: 0x00F37274
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

		// Token: 0x060368D4 RID: 223444 RVA: 0x00F390F4 File Offset: 0x00F372F4
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

		// Token: 0x060368D5 RID: 223445 RVA: 0x00F39122 File Offset: 0x00F37322
		public void EndGameplay()
		{
			if (this.GameplayView != null)
			{
				UiManager.Instance.CloseView(EUiViewName.DropCatchGameplayView, null);
				this.GameplayView = null;
			}
		}

		// Token: 0x060368D6 RID: 223446 RVA: 0x00F39143 File Offset: 0x00F37343
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

		// Token: 0x060368D7 RID: 223447 RVA: 0x00F39168 File Offset: 0x00F37368
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

		// Token: 0x060368D8 RID: 223448 RVA: 0x00F391A5 File Offset: 0x00F373A5
		public float GetCurScore()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return 0f;
			}
			return gameplayViewModel.GetCurScore();
		}

		// Token: 0x060368D9 RID: 223449 RVA: 0x00F391BC File Offset: 0x00F373BC
		public int GetCurGameplayId()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return 0;
			}
			return gameplayViewModel.GetCurGameplayId();
		}

		// Token: 0x060368DA RID: 223450 RVA: 0x00F391CF File Offset: 0x00F373CF
		public Dictionary<int, int> GetDropItemRecord()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return null;
			}
			return gameplayViewModel.GetDropItemRecord();
		}

		// Token: 0x060368DB RID: 223451 RVA: 0x00F391E2 File Offset: 0x00F373E2
		public void AddDropItemRecord(int itemId)
		{
			DropCatchGameplayViewModel gameplayViewModel = this.GameplayViewModel;
			if (gameplayViewModel == null)
			{
				return;
			}
			gameplayViewModel.AddDropItemRecord(itemId);
		}

		// Token: 0x060368DC RID: 223452 RVA: 0x00F391F8 File Offset: 0x00F373F8
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

		// Token: 0x060368DD RID: 223453 RVA: 0x00F39261 File Offset: 0x00F37461
		public DropCatchGameplayLogic GetGameplayLogic()
		{
			return this.GameplayLogic;
		}

		// Token: 0x060368DE RID: 223454 RVA: 0x00F39269 File Offset: 0x00F37469
		public DropCatchGameplayViewModel GetGameplayViewModel()
		{
			return this.GameplayViewModel;
		}

		// Token: 0x060368DF RID: 223455 RVA: 0x00F39271 File Offset: 0x00F37471
		public DropCatchGameplayView GetGameplayView()
		{
			return this.GameplayView;
		}

		// Token: 0x060368E0 RID: 223456 RVA: 0x00F39279 File Offset: 0x00F37479
		public bool GetEnableDebug()
		{
			return DropCatchGameplayController.Instance.EnableDebug;
		}

		// Token: 0x060368E1 RID: 223457 RVA: 0x00F39288 File Offset: 0x00F37488
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

		// Token: 0x060368E2 RID: 223458 RVA: 0x00F393D8 File Offset: 0x00F375D8
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

		// Token: 0x060368E3 RID: 223459 RVA: 0x00F396A4 File Offset: 0x00F378A4
		private UniTask WaitAllPausePromises()
		{
			DropCatchGameplayProxy.<WaitAllPausePromises>d__25 <WaitAllPausePromises>d__;
			<WaitAllPausePromises>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitAllPausePromises>d__.<>4__this = this;
			<WaitAllPausePromises>d__.<>1__state = -1;
			<WaitAllPausePromises>d__.<>t__builder.Start<DropCatchGameplayProxy.<WaitAllPausePromises>d__25>(ref <WaitAllPausePromises>d__);
			return <WaitAllPausePromises>d__.<>t__builder.Task;
		}

		// Token: 0x060368E4 RID: 223460 RVA: 0x00F396E8 File Offset: 0x00F378E8
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

		// Token: 0x060368E5 RID: 223461 RVA: 0x00F397A0 File Offset: 0x00F379A0
		private void OnGuideGroupOpening(int groupId, bool isPreExecute)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Guide_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupId);
			this.PauseGameplay(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060368E6 RID: 223462 RVA: 0x00F397D8 File Offset: 0x00F379D8
		private void OnGuideGroupFinished(int groupId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Guide_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupId);
			this.ResumeGameplay(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060368E7 RID: 223463 RVA: 0x00F39810 File Offset: 0x00F37A10
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

		// Token: 0x060368E8 RID: 223464 RVA: 0x00F398D0 File Offset: 0x00F37AD0
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

		// Token: 0x060368E9 RID: 223465 RVA: 0x00F39988 File Offset: 0x00F37B88
		[NullableContext(1)]
		public void PlayFlow(string[] flowId)
		{
			ChatPopViewData param = new ChatPopViewData
			{
				FlowId = new List<string>(flowId)
			};
			UiManager.Instance.OpenView(EUiViewName.DropCatchChatPopView, param, null);
		}

		// Token: 0x0401CD1E RID: 118046
		private DropCatchGameplayLogic GameplayLogic;

		// Token: 0x0401CD1F RID: 118047
		private DropCatchGameplayView GameplayView;

		// Token: 0x0401CD20 RID: 118048
		private DropCatchGameplayViewModel GameplayViewModel;

		// Token: 0x0401CD21 RID: 118049
		[Nullable(1)]
		private readonly HashSet<string> PauseReason = new HashSet<string>();

		// Token: 0x0401CD22 RID: 118050
		private CustomPromise PauseGate;
	}
}
