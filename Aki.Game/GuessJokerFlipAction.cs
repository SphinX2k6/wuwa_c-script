using System;

// Token: 0x0200101F RID: 4127
public class GuessJokerFlipAction : GuessJokerActionBase
{
	// Token: 0x06006A0A RID: 27146 RVA: 0x00154280 File Offset: 0x00152480
	public GuessJokerFlipAction(int cardId, bool isShowFront)
	{
		this.CardId = cardId;
		this.IsShowFront = isShowFront;
	}

	// Token: 0x06006A0B RID: 27147 RVA: 0x00154298 File Offset: 0x00152498
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

	// Token: 0x040030DD RID: 12509
	private readonly int CardId;

	// Token: 0x040030DE RID: 12510
	private readonly bool IsShowFront;
}
