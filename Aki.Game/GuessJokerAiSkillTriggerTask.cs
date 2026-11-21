using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020004E9 RID: 1257
public class GuessJokerAiSkillTriggerTask : GuessJokerTaskBase
{
	// Token: 0x06003E1C RID: 15900 RVA: 0x0015F1E7 File Offset: 0x0015D3E7
	[NullableContext(1)]
	public GuessJokerAiSkillTriggerTask(JokerGuessSkillTriggerAction data)
	{
		this.SkillId = data.JokerSkillId;
		this.SkillRemindCount = data.RemainingSkillNum;
	}

	// Token: 0x06003E1D RID: 15901 RVA: 0x0015F208 File Offset: 0x0015D408
	protected override void OnExecute()
	{
		GuessJokerAiSkillTriggerTask.<>c__DisplayClass5_0 CS$<>8__locals1 = new GuessJokerAiSkillTriggerTask.<>c__DisplayClass5_0();
		CS$<>8__locals1.<>4__this = this;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GuessJokerCard;
		ELogAuthor author = ELogAuthor.LRC;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Ai技能触发：");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillId);
		defaultInterpolatedStringHandler.AppendLiteral(" 剩余次数：");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillRemindCount);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		GuessJokerAiSkillTriggerTask.<>c__DisplayClass5_0 CS$<>8__locals2 = CS$<>8__locals1;
		GuessJokerGamePlayModel instance2 = GuessJokerGamePlayModel.Instance;
		CS$<>8__locals2.gamePlayView = ((instance2 != null) ? instance2.GetGamePlayView() : null);
		if (CS$<>8__locals1.gamePlayView == null)
		{
			base.FinishTask();
			return;
		}
		CS$<>8__locals1.gamePlayView.UpdateCurrentPlayer(EGuessJokerPlayerType.Ai);
		if (this.SkillId == 120801 || this.SkillId == 151001)
		{
			list.Add(new GuessJokerRoundStartTipAction(EGuessJokerPlayerType.Ai));
		}
		if (GuessJokerGamePlayModel.Instance.ShouldPlaySkillEffect(this.SkillId))
		{
			list.Add(new GuessJokerCallbackAction(delegate()
			{
				CS$<>8__locals1.<>4__this.IsStartCountDown = true;
				CS$<>8__locals1.<>4__this.FinishTime = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerAiSkillConsiderTime.ToString());
				CS$<>8__locals1.gamePlayView.SetSkillProgress(EGuessJokerPlayerType.Ai, 0f);
				CS$<>8__locals1.gamePlayView.ShowAiSkillProgress(true);
				CS$<>8__locals1.gamePlayView.SetPositionPanelCardsDark(ECardPositionType.PlayerHand, true, null);
			}));
			GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
			{
				new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.TriggerSkill, null)
			});
		}
		if (list.Count > 0)
		{
			if (!GuessJokerGamePlayModel.Instance.ShouldPlaySkillEffect(this.SkillId))
			{
				list.Add(new GuessJokerCallbackAction(new Action(base.FinishTask)));
			}
			GuessJokerGamePlayModel.Instance.PushActions(list);
			return;
		}
		base.FinishTask();
	}

	// Token: 0x06003E1E RID: 15902 RVA: 0x0015F370 File Offset: 0x0015D570
	protected override void OnTick(float deltaTime)
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		GuessJokerGamePlayView guessJokerGamePlayView = (instance != null) ? instance.GetGamePlayView() : null;
		if (guessJokerGamePlayView == null || this.FinishTime <= 0f || !this.IsStartCountDown)
		{
			return;
		}
		this.ThinkTime += deltaTime;
		float progress = this.ThinkTime / this.FinishTime;
		guessJokerGamePlayView.SetSkillProgress(EGuessJokerPlayerType.Ai, progress);
	}

	// Token: 0x06003E1F RID: 15903 RVA: 0x0015F3CC File Offset: 0x0015D5CC
	protected override void OnComplete()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		GuessJokerGamePlayView guessJokerGamePlayView = (instance != null) ? instance.GetGamePlayView() : null;
		if (guessJokerGamePlayView != null)
		{
			guessJokerGamePlayView.ShowAiSkillProgress(false);
			guessJokerGamePlayView.SetPositionPanelCardsDark(ECardPositionType.PlayerHand, false, null);
		}
	}

	// Token: 0x040031AF RID: 12719
	private readonly int SkillId;

	// Token: 0x040031B0 RID: 12720
	private readonly int SkillRemindCount;

	// Token: 0x040031B1 RID: 12721
	private bool IsStartCountDown;

	// Token: 0x040031B2 RID: 12722
	private float ThinkTime;
}
