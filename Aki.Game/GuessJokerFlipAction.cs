using System;

// Token: 0x020004D3 RID: 1235
public class GuessJokerFlipAction : GuessJokerActionBase
{
	// Token: 0x06003D9F RID: 15775 RVA: 0x0015CBA8 File Offset: 0x0015ADA8
	public GuessJokerFlipAction(int cardId, bool isShowFront)
	{
		this.CardId = cardId;
		this.IsShowFront = isShowFront;
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x0015CBC0 File Offset: 0x0015ADC0
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		GuessJokerCardItem cardItemById = gamePlayView.GetCardItemById(this.CardId);
		if (cardItemById != null)
		{
			cardItemById.CardFlip(this.IsShowFront, true);
		}
		this.Done = true;
	}

	// Token: 0x04003176 RID: 12662
	private readonly int CardId;

	// Token: 0x04003177 RID: 12663
	private readonly bool IsShowFront;
}
