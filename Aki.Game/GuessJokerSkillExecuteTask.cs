using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200103B RID: 4155
public class GuessJokerSkillExecuteTask : GuessJokerTaskBase
{
	// Token: 0x06006A9D RID: 27293 RVA: 0x00157440 File Offset: 0x00155640
	[NullableContext(1)]
	public GuessJokerSkillExecuteTask(JokerGuessSkillExecAction data)
	{
		this.Data = data;
		this.SkillId = data.JokerSkillId;
		this.PlayerType = GuessJokerUtils.ServerPlayerTransToClient(data.Owner);
		this.IsUseSkill = GuessJokerUtils.ServerUseSkillTransToClient(data.Result);
		this.FinishTime = 1500f;
	}

	// Token: 0x06006A9E RID: 27294 RVA: 0x0015749C File Offset: 0x0015569C
	protected override void OnExecute()
	{
		if (this.Data == null)
		{
			return;
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("技能执行：玩家类型{0} 技能ID{1} 是否使用{2}", this.PlayerType, this.SkillId, this.IsUseSkill), default(ReadOnlySpan<ValueTuple<string, object>>));
		bool isJokerReturnFlagForGuide = false;
		if (this.Data.PlayerHandCards != null && this.Data.PlayerHandCards.CardIds != null)
		{
			List<int> list = new List<int>();
			foreach (int item in this.Data.PlayerHandCards.CardIds)
			{
				list.Add(item);
			}
			GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
			if (instance != null)
			{
				instance.UpdateCardBelongPlayerType(list.ToArray(), new EGuessJokerPlayerType?(EGuessJokerPlayerType.Me));
			}
			foreach (int cardId in this.Data.PlayerHandCards.CardIds)
			{
				GuessJokerGamePlayModel instance2 = GuessJokerGamePlayModel.Instance;
				GuessJokerCardData guessJokerCardData = (instance2 != null) ? instance2.GetCardDataById(cardId) : null;
				if (guessJokerCardData != null && guessJokerCardData.Type == EGuessJokerCardType.Joker)
				{
					isJokerReturnFlagForGuide = true;
					break;
				}
			}
		}
		if (this.Data.AiHandCards != null && this.Data.AiHandCards.CardIds != null)
		{
			List<int> list2 = new List<int>();
			foreach (int item2 in this.Data.AiHandCards.CardIds)
			{
				list2.Add(item2);
			}
			GuessJokerGamePlayModel instance3 = GuessJokerGamePlayModel.Instance;
			if (instance3 != null)
			{
				instance3.UpdateCardBelongPlayerType(list2.ToArray(), new EGuessJokerPlayerType?(EGuessJokerPlayerType.Ai));
			}
		}
		if (this.IsUseSkill)
		{
			this.DoUseSkill(isJokerReturnFlagForGuide);
			return;
		}
		this.DoNotUseSkill();
	}

	// Token: 0x06006A9F RID: 27295 RVA: 0x00157698 File Offset: 0x00155898
	private void DoUseSkill(bool isJokerReturnFlagForGuide)
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		GuessJokerGamePlayView guessJokerGamePlayView = (instance != null) ? instance.GetGamePlayView() : null;
		if (guessJokerGamePlayView != null)
		{
			guessJokerGamePlayView.UpdateSkill(this.PlayerType);
			if (GuessJokerGamePlayModel.Instance.ShouldPlaySkillEffect(this.SkillId))
			{
				List<GuessJokerPlotAction> list = new List<GuessJokerPlotAction>();
				list.Add(new GuessJokerPlotAction(this.PlayerType, EGuessJokerPlotTiming.ExecuteSkill, new int?(this.SkillId)));
				list.Add(new GuessJokerPlotAction(GuessJokerUtils.GetOtherPlayerType(this.PlayerType), EGuessJokerPlotTiming.ExecuteSkill, new int?(this.SkillId)));
				GuessJokerGamePlayModel.Instance.PushPlotActions(list.ToArray());
				guessJokerGamePlayView.PlaySkillEffect(this.SkillId, delegate
				{
					if (isJokerReturnFlagForGuide)
					{
						EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "GuessJokerJokerReturn");
					}
					this.FinishTask();
				});
				return;
			}
			if (isJokerReturnFlagForGuide)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "GuessJokerJokerReturn");
			}
			base.FinishTask();
		}
	}

	// Token: 0x06006AA0 RID: 27296 RVA: 0x00157784 File Offset: 0x00155984
	private void DoNotUseSkill()
	{
		if (GuessJokerGamePlayModel.Instance.ShowPlayGiveUpSkillTip(this.SkillId))
		{
			JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(this.SkillId);
			string text = (jokerSkill != null) ? jokerSkill.GetValueOrDefault().SkillName : null;
			if (text != null)
			{
				string text2 = ConfigMultiTextLang.GetLocalTextNew(text, null) ?? text;
				GuessJokerController.Instance.OpenGuessJokerFloatTipsView("GuessJoker_NotUseSkill", new string[]
				{
					text2
				});
			}
		}
		base.FinishTask();
	}

	// Token: 0x04003122 RID: 12578
	[Nullable(2)]
	private readonly JokerGuessSkillExecAction Data;

	// Token: 0x04003123 RID: 12579
	public int SkillId;

	// Token: 0x04003124 RID: 12580
	public EGuessJokerPlayerType PlayerType = EGuessJokerPlayerType.Ai;

	// Token: 0x04003125 RID: 12581
	public bool IsUseSkill;
}
