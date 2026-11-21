using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004CE RID: 1230
public abstract class GuessJokerActionBase
{
	// Token: 0x06003D8A RID: 15754 RVA: 0x0015C725 File Offset: 0x0015A925
	public GuessJokerActionBase()
	{
		this.ActionId = GuessJokerActionBase.SelfIncrementId++;
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x0015C740 File Offset: 0x0015A940
	public void Start()
	{
		this.Done = false;
		this.Elapsed = 0f;
		this.OnAddEventListener();
		this.OnStart();
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x0015C760 File Offset: 0x0015A960
	public void Tick(float delta)
	{
		if (this.Done)
		{
			return;
		}
		this.OnTick(delta);
		if (this.Duration <= 0f)
		{
			return;
		}
		this.Elapsed += delta;
		if (this.Elapsed >= this.Duration)
		{
			this.Done = true;
		}
	}

	// Token: 0x06003D8D RID: 15757 RVA: 0x0015C7AE File Offset: 0x0015A9AE
	public void Finish()
	{
		this.OnFinish();
		this.OnRemoveEventListener();
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x0015C7BC File Offset: 0x0015A9BC
	public bool IsDone()
	{
		return this.Done;
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x0015C7C4 File Offset: 0x0015A9C4
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06003D90 RID: 15760 RVA: 0x0015C7C6 File Offset: 0x0015A9C6
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x0015C7C8 File Offset: 0x0015A9C8
	protected virtual void OnStart()
	{
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x0015C7CA File Offset: 0x0015A9CA
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x0015C7CC File Offset: 0x0015A9CC
	protected virtual void OnFinish()
	{
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x0015C7D0 File Offset: 0x0015A9D0
	[NullableContext(1)]
	protected void AnimateCardsToTarget(ECardPositionType targetPosition, [Nullable(2)] GuessJokerPositionPanelBase targetPanel, Action onComplete)
	{
		if (targetPanel == null)
		{
			onComplete();
			return;
		}
		List<GuessJokerCardItem> cardItemList = targetPanel.CardItemList;
		if (cardItemList.Count == 0)
		{
			onComplete();
			return;
		}
		ICardLayoutInfo[] array = GuessJokerUtils.CalculateCardLayoutInfo(cardItemList.Count, targetPosition);
		bool[] completedFlags = new bool[cardItemList.Count];
		for (int i = 0; i < cardItemList.Count; i++)
		{
			completedFlags[i] = false;
		}
		for (int j = 0; j < cardItemList.Count; j++)
		{
			int capturedIndex = j;
			GuessJokerCardItem guessJokerCardItem = cardItemList[j];
			ICardLayoutInfo cardLayoutInfo = array[j];
			Vector2D targetPosition2 = new Vector2D((double)cardLayoutInfo.X, (double)cardLayoutInfo.Y);
			guessJokerCardItem.SetAlpha(cardLayoutInfo.Alpha);
			guessJokerCardItem.SmoothMoveTo(targetPosition2, delegate
			{
				completedFlags[capturedIndex] = true;
				bool flag = true;
				for (int k = 0; k < completedFlags.Length; k++)
				{
					if (!completedFlags[k])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					onComplete();
				}
			}, new float?(cardLayoutInfo.Scale), new float?(cardLayoutInfo.Rotation), -1f);
		}
	}

	// Token: 0x0400316C RID: 12652
	public readonly int ActionId;

	// Token: 0x0400316D RID: 12653
	[StaticVariableRuleIgnore]
	private static int SelfIncrementId = 0;

	// Token: 0x0400316E RID: 12654
	protected bool Done;

	// Token: 0x0400316F RID: 12655
	private float Elapsed;

	// Token: 0x04003170 RID: 12656
	protected float Duration;
}
