using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020004EC RID: 1260
public class GuessJokerPlayerSkillTriggerTask : GuessJokerTaskBase
{
	// Token: 0x06003E2A RID: 15914 RVA: 0x0015F9BC File Offset: 0x0015DBBC
	[NullableContext(1)]
	public GuessJokerPlayerSkillTriggerTask(JokerGuessSkillTriggerAction data)
	{
		this.TaskType = EGuessJokerTaskType.Interactive;
		this.SkillId = data.JokerSkillId;
		this.SkillRemindCount = data.RemainingSkillNum;
		this.HasPlayerChosen = false;
		this.FinishTime = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerPlayerSkillConsiderTime.ToString());
	}

	// Token: 0x06003E2B RID: 15915 RVA: 0x0015FA14 File Offset: 0x0015DC14
	protected override void OnExecute()
	{
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("玩家技能触发：{0} 剩余次数：{1}", this.SkillId, this.SkillRemindCount), default(ReadOnlySpan<ValueTuple<string, object>>));
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			base.FinishTask();
			return;
		}
		GuessJokerGamePlayModel.Instance.SetNpcEnterInteractiveStage(true);
		gamePlayView.SetCurrentSkillInfo(this.SkillId, this.SkillRemindCount);
		gamePlayView.ShowSkillInteractivePanel(true);
		gamePlayView.SetSkillProgress(EGuessJokerPlayerType.Me, 0f);
		GuessJokerController controller = GuessJokerController.Instance;
		Action <>9__1;
		gamePlayView.SetPlayerSkillRequestCallback(delegate(bool isUse)
		{
			if (this.IsFinished() || this.IsAutoAbandoning)
			{
				Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "任务已完成或正在自动放弃，忽略玩家点击", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!this.CanSendRequest())
			{
				Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "技能请求进行中，忽略重复点击", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SetRequestFinished(true);
			GuessJokerController controller = controller;
			int skillId = this.SkillId;
			Action callback;
			if ((callback = <>9__1) == null)
			{
				callback = (<>9__1 = delegate()
				{
					this.HasPlayerChosen = true;
					gamePlayView.ShowSkillInteractivePanel(false);
					this.FinishTask();
				});
			}
			controller.JokerGuessUseSkillRequest(skillId, isUse, callback);
		});
		GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
		{
			new GuessJokerPlotAction(EGuessJokerPlayerType.Me, EGuessJokerPlotTiming.TriggerSkill, null)
		});
	}

	// Token: 0x06003E2C RID: 15916 RVA: 0x0015FB0C File Offset: 0x0015DD0C
	protected override void OnTick(float deltaTime)
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		GuessJokerGamePlayView guessJokerGamePlayView = (instance != null) ? instance.GetGamePlayView() : null;
		if (guessJokerGamePlayView == null || this.FinishTime <= 0f)
		{
			return;
		}
		this.ThinkTime += deltaTime;
		float progress = Math.Min(1f, this.ThinkTime / this.FinishTime);
		guessJokerGamePlayView.SetSkillProgress(EGuessJokerPlayerType.Me, progress);
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x0015FB6C File Offset: 0x0015DD6C
	protected override void OnComplete()
	{
		GuessJokerPlayerSkillTriggerTask.<>c__DisplayClass8_0 CS$<>8__locals1 = new GuessJokerPlayerSkillTriggerTask.<>c__DisplayClass8_0();
		GuessJokerPlayerSkillTriggerTask.<>c__DisplayClass8_0 CS$<>8__locals2 = CS$<>8__locals1;
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		CS$<>8__locals2.gamePlayView = ((instance != null) ? instance.GetGamePlayView() : null);
		if (CS$<>8__locals1.gamePlayView != null)
		{
			this.IsAutoAbandoning = true;
			if (!this.HasPlayerChosen)
			{
				GuessJokerController.Instance.JokerGuessUseSkillRequest(this.SkillId, false, delegate
				{
					CS$<>8__locals1.gamePlayView.ShowSkillInteractivePanel(false);
					CS$<>8__locals1.gamePlayView.SetSkillProgress(EGuessJokerPlayerType.Me, 0f);
				});
			}
			else
			{
				CS$<>8__locals1.gamePlayView.ShowSkillInteractivePanel(false);
				CS$<>8__locals1.gamePlayView.SetSkillProgress(EGuessJokerPlayerType.Me, 0f);
			}
		}
		GuessJokerGamePlayModel.Instance.SetNpcEnterInteractiveStage(false);
	}

	// Token: 0x040031B4 RID: 12724
	private readonly int SkillId;

	// Token: 0x040031B5 RID: 12725
	private readonly int SkillRemindCount;

	// Token: 0x040031B6 RID: 12726
	private bool HasPlayerChosen;

	// Token: 0x040031B7 RID: 12727
	private bool IsAutoAbandoning;

	// Token: 0x040031B8 RID: 12728
	private float ThinkTime;
}
