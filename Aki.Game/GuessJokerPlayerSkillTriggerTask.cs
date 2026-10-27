using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001038 RID: 4152
public class GuessJokerPlayerSkillTriggerTask : GuessJokerTaskBase
{
	// Token: 0x06006A95 RID: 27285 RVA: 0x00157094 File Offset: 0x00155294
	[NullableContext(1)]
	public GuessJokerPlayerSkillTriggerTask(JokerGuessSkillTriggerAction data)
	{
		this.TaskType = EGuessJokerTaskType.Interactive;
		this.SkillId = data.JokerSkillId;
		this.SkillRemindCount = data.RemainingSkillNum;
		this.HasPlayerChosen = false;
		this.FinishTime = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerPlayerSkillConsiderTime.ToString());
	}

	// Token: 0x06006A96 RID: 27286 RVA: 0x001570EC File Offset: 0x001552EC
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

	// Token: 0x06006A97 RID: 27287 RVA: 0x001571E4 File Offset: 0x001553E4
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

	// Token: 0x06006A98 RID: 27288 RVA: 0x00157244 File Offset: 0x00155444
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

	// Token: 0x0400311B RID: 12571
	private readonly int SkillId;

	// Token: 0x0400311C RID: 12572
	private readonly int SkillRemindCount;

	// Token: 0x0400311D RID: 12573
	private bool HasPlayerChosen;

	// Token: 0x0400311E RID: 12574
	private bool IsAutoAbandoning;

	// Token: 0x0400311F RID: 12575
	private float ThinkTime;
}
