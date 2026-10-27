using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;

// Token: 0x02001032 RID: 4146
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerAiCheckCardTask : GuessJokerTaskBase
{
	// Token: 0x06006A79 RID: 27257 RVA: 0x00155DB8 File Offset: 0x00153FB8
	public GuessJokerAiCheckCardTask(JokerGuessDisPlayCardAction data)
	{
		this.CardId = data.CardId;
	}

	// Token: 0x06006A7A RID: 27258 RVA: 0x00155DCC File Offset: 0x00153FCC
	protected override void OnExecute()
	{
		if (GuessJokerGamePlayModel.Instance.GetGamePlayView() == null)
		{
			base.FinishTask();
			return;
		}
		List<int> hesitationCardList = this.GetHesitationCardList();
		int cardId = this.CardId;
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		list.Add(new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerBeDrawCard));
		list.Add(new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.ChooseCard, cardId, 0f));
		list.Add(new GuessJokerCheckCardAction(hesitationCardList));
		list.Add(new GuessJokerCallbackAction(new Action(base.FinishTask)));
		GuessJokerGamePlayModel.Instance.PushActions(list);
	}

	// Token: 0x06006A7B RID: 27259 RVA: 0x00155E50 File Offset: 0x00154050
	private unsafe List<int> GetHesitationCardList()
	{
		List<GuessJokerCardData> handCardsByPlayer = GuessJokerGamePlayModel.Instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Me);
		int cardId = this.CardId;
		int num = -1;
		for (int i = 0; i < handCardsByPlayer.Count; i++)
		{
			if (handCardsByPlayer[i].Id == cardId)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("检查卡牌：{0}不存在", cardId), default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<int>();
		}
		int count = handCardsByPlayer.Count;
		int num2 = Math.Min(3, count);
		int num3 = (int)Math.Floor(Random.Shared.NextDouble() * (double)num2) + 1;
		int num4 = num - (num3 - 1);
		int num5 = num + (num3 - 1);
		bool flag = num4 >= 0;
		bool flag2 = num5 < count;
		bool flag3;
		int num6;
		if (flag && flag2)
		{
			flag3 = (Random.Shared.NextDouble() < 0.5);
			num6 = (flag3 ? num4 : num5);
		}
		else if (flag)
		{
			flag3 = true;
			num6 = num4;
		}
		else
		{
			if (!flag2)
			{
				int num7 = 1;
				List<int> list = new List<int>(num7);
				CollectionsMarshal.SetCount<int>(list, num7);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = cardId;
				return list;
			}
			flag3 = false;
			num6 = num5;
		}
		List<int> list2 = new List<int>();
		if (flag3)
		{
			for (int j = num6; j <= num; j++)
			{
				list2.Add(handCardsByPlayer[j].Id);
			}
		}
		else
		{
			for (int k = num6; k >= num; k--)
			{
				list2.Add(handCardsByPlayer[k].Id);
			}
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "Ai检查卡牌：" + string.Join<int>(",", list2), default(ReadOnlySpan<ValueTuple<string, object>>));
		return list2;
	}

	// Token: 0x04003112 RID: 12562
	private readonly int CardId;
}
