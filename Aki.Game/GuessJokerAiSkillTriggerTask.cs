using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001035 RID: 4149
public class GuessJokerAiSkillTriggerTask : GuessJokerTaskBase
{
	// Token: 0x06006A87 RID: 27271 RVA: 0x001568BF File Offset: 0x00154ABF
	[NullableContext(1)]
	public GuessJokerAiSkillTriggerTask(JokerGuessSkillTriggerAction data)
	{
		this.SkillId = data.JokerSkillId;
		this.SkillRemindCount = data.RemainingSkillNum;
	}

	// Token: 0x06006A88 RID: 27272 RVA: 0x001568E0 File Offset: 0x00154AE0
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

	// Token: 0x06006A89 RID: 27273 RVA: 0x00156A48 File Offset: 0x00154C48
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

	// Token: 0x06006A8A RID: 27274 RVA: 0x00156AA4 File Offset: 0x00154CA4
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

	// Token: 0x04003116 RID: 12566
	private readonly int SkillId;

	// Token: 0x04003117 RID: 12567
	private readonly int SkillRemindCount;

	// Token: 0x04003118 RID: 12568
	private bool IsStartCountDown;

	// Token: 0x04003119 RID: 12569
	private float ThinkTime;
}
