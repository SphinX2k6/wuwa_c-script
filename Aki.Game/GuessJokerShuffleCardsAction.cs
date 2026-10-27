using System;

// Token: 0x02001027 RID: 4135
public class GuessJokerShuffleCardsAction : GuessJokerActionBase
{
	// Token: 0x06006A2F RID: 27183 RVA: 0x00154DB6 File Offset: 0x00152FB6
	public GuessJokerShuffleCardsAction(ECardPositionType targetPosition)
	{
		this.TargetPosition = targetPosition;
	}

	// Token: 0x06006A30 RID: 27184 RVA: 0x00154DC8 File Offset: 0x00152FC8
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

	// Token: 0x040030EF RID: 12527
	private readonly ECardPositionType TargetPosition;
}
