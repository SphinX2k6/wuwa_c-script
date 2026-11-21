using System;

// Token: 0x020004DB RID: 1243
public class GuessJokerShuffleCardsAction : GuessJokerActionBase
{
	// Token: 0x06003DC4 RID: 15812 RVA: 0x0015D6DE File Offset: 0x0015B8DE
	public GuessJokerShuffleCardsAction(ECardPositionType targetPosition)
	{
		this.TargetPosition = targetPosition;
	}

	// Token: 0x06003DC5 RID: 15813 RVA: 0x0015D6F0 File Offset: 0x0015B8F0
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		GuessJokerPositionPanelBase positionPanel = gamePlayView.GetPositionPanel(this.TargetPosition);
		if (positionPanel == null || positionPanel.CardItemList.Count <= 1)
		{
			this.Done = true;
			return;
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "【action】开始洗牌动画：" + this.TargetPosition.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		gamePlayView.ClearAllCardsChecking();
		positionPanel.ShuffleCardsWithAnimation(delegate
		{
			gamePlayView.UpdateCardItemsHierarchyIndex();
			Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "【action】洗牌动画完成", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Done = true;
		});
	}

	// Token: 0x04003188 RID: 12680
	private readonly ECardPositionType TargetPosition;
}
