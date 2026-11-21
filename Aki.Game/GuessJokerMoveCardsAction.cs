using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004D5 RID: 1237
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerMoveCardsAction : GuessJokerActionBase
{
	// Token: 0x06003DA5 RID: 15781 RVA: 0x0015CD18 File Offset: 0x0015AF18
	public GuessJokerMoveCardsAction(int[] cardIdList, ECardPositionType toPosition)
	{
		this.CardIdList.AddRange(cardIdList);
		this.TargetPosition = toPosition;
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x0015CD40 File Offset: 0x0015AF40
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		if (this.CardIdList.Count == 0)
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
		List<GuessJokerCardItem> list = new List<GuessJokerCardItem>();
		for (int i = 0; i < this.CardIdList.Count; i++)
		{
			int cardId = this.CardIdList[i];
			GuessJokerCardItem cardItemById = gamePlayView.GetCardItemById(cardId);
			if (cardItemById != null)
			{
				ECardPositionType positionType = cardItemById.GetPositionType();
				if (positionType != this.TargetPosition)
				{
					GuessJokerPositionPanelBase positionPanel2 = gamePlayView.GetPositionPanel(positionType);
					if (positionPanel2 != null)
					{
						positionPanel2.RemoveCardByCardId(cardId);
					}
					list.Add(cardItemById);
				}
			}
		}
		list.Sort((GuessJokerCardItem a, GuessJokerCardItem b) => a.GetGlobalIndex() - b.GetGlobalIndex());
		positionPanel.AddCardByItemList(list);
		gamePlayView.UpdateCardItemsHierarchyIndex();
		if (positionPanel.Position == ECardPositionType.Middle)
		{
			AudioSystem.Instance.PostEvent("play_ui_springfestival_ghostcard_card_discard");
		}
		base.AnimateCardsToTarget(this.TargetPosition, positionPanel, delegate
		{
			this.Done = true;
		});
	}

	// Token: 0x04003179 RID: 12665
	private readonly List<int> CardIdList = new List<int>();

	// Token: 0x0400317A RID: 12666
	private readonly ECardPositionType TargetPosition;
}
