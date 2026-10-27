using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001021 RID: 4129
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerMoveCardsAction : GuessJokerActionBase
{
	// Token: 0x06006A10 RID: 27152 RVA: 0x001543F0 File Offset: 0x001525F0
	public GuessJokerMoveCardsAction(int[] cardIdList, ECardPositionType toPosition)
	{
		this.CardIdList.AddRange(cardIdList);
		this.TargetPosition = toPosition;
	}

	// Token: 0x06006A11 RID: 27153 RVA: 0x00154418 File Offset: 0x00152618
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

	// Token: 0x040030E0 RID: 12512
	private readonly List<int> CardIdList = new List<int>();

	// Token: 0x040030E1 RID: 12513
	private readonly ECardPositionType TargetPosition;
}
