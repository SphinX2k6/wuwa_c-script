using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004D1 RID: 1233
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCheckCardAction : GuessJokerActionBase
{
	// Token: 0x06003D9A RID: 15770 RVA: 0x0015C936 File Offset: 0x0015AB36
	public GuessJokerCheckCardAction(List<int> cardIdList)
	{
		this.CardIdList = cardIdList;
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x0015C948 File Offset: 0x0015AB48
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		List<GuessJokerCardItem> cardItemList = new List<GuessJokerCardItem>();
		for (int i = 0; i < this.CardIdList.Count; i++)
		{
			int cardId = this.CardIdList[i];
			GuessJokerCardItem cardItemById = gamePlayView.GetCardItemById(cardId);
			if (cardItemById != null)
			{
				cardItemList.Add(cardItemById);
			}
		}
		if (cardItemList.Count == 0)
		{
			this.Done = true;
			return;
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "check card id list: " + string.Join<int>(",", this.CardIdList), default(ReadOnlySpan<ValueTuple<string, object>>));
		int currentIndex = 0;
		Action processNext = null;
		Action <>9__3;
		processNext = delegate()
		{
			if (currentIndex >= cardItemList.Count)
			{
				this.Done = true;
				return;
			}
			GuessJokerCardItem cardItem = cardItemList[currentIndex];
			bool isLast = currentIndex == cardItemList.Count - 1;
			Action <>9__2;
			cardItem.PlayCardSequence("EvilSle", delegate
			{
				GuessJokerCardItem cardItem;
				if (isLast)
				{
					cardItem = cardItem;
					string sequenceName = "EvilPress";
					Action finishCallback;
					if ((finishCallback = <>9__2) == null)
					{
						finishCallback = (<>9__2 = delegate()
						{
							cardItem.SetChecking();
							this.Done = true;
						});
					}
					cardItem.PlayCardSequence(sequenceName, finishCallback);
					return;
				}
				GuessJokerCardItem cardItem2 = cardItem;
				string sequenceName2 = "EvilUnsle";
				Action finishCallback2;
				if ((finishCallback2 = <>9__3) == null)
				{
					finishCallback2 = (<>9__3 = delegate()
					{
						int currentIndex = currentIndex;
						currentIndex++;
						processNext();
					});
				}
				cardItem2.PlayCardSequence(sequenceName2, finishCallback2);
			});
		};
		processNext();
	}

	// Token: 0x04003173 RID: 12659
	private readonly List<int> CardIdList;
}
