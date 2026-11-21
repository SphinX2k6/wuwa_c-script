using System;
using System.Collections.Generic;

// Token: 0x020004D2 RID: 1234
public class GuessJokerCollectCardsAction : GuessJokerActionBase
{
	// Token: 0x06003D9C RID: 15772 RVA: 0x0015CA35 File Offset: 0x0015AC35
	public GuessJokerCollectCardsAction(EGuessJokerPlayerType playerType, ECardPositionType targetPosition)
	{
		this.PlayerType = playerType;
		this.TargetPosition = targetPosition;
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x0015CA4C File Offset: 0x0015AC4C
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		GuessJokerPositionPanelBase positionPanel = gamePlayView.GetPositionPanel(this.TargetPosition);
		if (positionPanel == null)
		{
			this.Done = true;
			return;
		}
		List<GuessJokerCardData> allCardsByPlayer = GuessJokerGamePlayModel.Instance.GetAllCardsByPlayer(this.PlayerType);
		if (allCardsByPlayer.Count == 0)
		{
			this.Done = true;
			return;
		}
		List<GuessJokerCardItem> list = new List<GuessJokerCardItem>();
		for (int i = 0; i < allCardsByPlayer.Count; i++)
		{
			int id = allCardsByPlayer[i].Id;
			GuessJokerCardItem cardItemById = gamePlayView.GetCardItemById(id);
			if (cardItemById != null)
			{
				ECardPositionType positionType = cardItemById.GetPositionType();
				if (positionType != this.TargetPosition)
				{
					GuessJokerPositionPanelBase positionPanel2 = gamePlayView.GetPositionPanel(positionType);
					if (positionPanel2 != null)
					{
						positionPanel2.RemoveCardByCardId(id);
					}
					list.Add(cardItemById);
				}
			}
		}
		list.Sort((GuessJokerCardItem a, GuessJokerCardItem b) => a.GetGlobalIndex() - b.GetGlobalIndex());
		positionPanel.AddCardByItemList(list);
		gamePlayView.UpdateCardItemsHierarchyIndex();
		for (int j = 0; j < list.Count; j++)
		{
			GuessJokerCardItem guessJokerCardItem = list[j];
			GuessJokerCardData data = guessJokerCardItem.Data;
			guessJokerCardItem.CardFlip(data.GetBelongPlayerType().GetValueOrDefault() != EGuessJokerPlayerType.Ai, true);
		}
		base.AnimateCardsToTarget(this.TargetPosition, positionPanel, delegate
		{
			this.Done = true;
		});
	}

	// Token: 0x04003174 RID: 12660
	private readonly EGuessJokerPlayerType PlayerType;

	// Token: 0x04003175 RID: 12661
	private readonly ECardPositionType TargetPosition;
}
