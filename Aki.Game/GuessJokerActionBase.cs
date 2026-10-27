using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200101A RID: 4122
public abstract class GuessJokerActionBase
{
	// Token: 0x060069F5 RID: 27125 RVA: 0x00153DFD File Offset: 0x00151FFD
	public GuessJokerActionBase()
	{
		this.ActionId = GuessJokerActionBase.SelfIncrementId++;
	}

	// Token: 0x060069F6 RID: 27126 RVA: 0x00153E18 File Offset: 0x00152018
	public void Start()
	{
		this.Done = false;
		this.Elapsed = 0f;
		this.OnAddEventListener();
		this.OnStart();
	}

	// Token: 0x060069F7 RID: 27127 RVA: 0x00153E38 File Offset: 0x00152038
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

	// Token: 0x060069F8 RID: 27128 RVA: 0x00153E86 File Offset: 0x00152086
	public void Finish()
	{
		this.OnFinish();
		this.OnRemoveEventListener();
	}

	// Token: 0x060069F9 RID: 27129 RVA: 0x00153E94 File Offset: 0x00152094
	public bool IsDone()
	{
		return this.Done;
	}

	// Token: 0x060069FA RID: 27130 RVA: 0x00153E9C File Offset: 0x0015209C
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x060069FB RID: 27131 RVA: 0x00153E9E File Offset: 0x0015209E
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x060069FC RID: 27132 RVA: 0x00153EA0 File Offset: 0x001520A0
	protected virtual void OnStart()
	{
	}

	// Token: 0x060069FD RID: 27133 RVA: 0x00153EA2 File Offset: 0x001520A2
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x060069FE RID: 27134 RVA: 0x00153EA4 File Offset: 0x001520A4
	protected virtual void OnFinish()
	{
	}

	// Token: 0x060069FF RID: 27135 RVA: 0x00153EA8 File Offset: 0x001520A8
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

	// Token: 0x040030D3 RID: 12499
	public readonly int ActionId;

	// Token: 0x040030D4 RID: 12500
	[StaticVariableRuleIgnore]
	private static int SelfIncrementId = 0;

	// Token: 0x040030D5 RID: 12501
	protected bool Done;

	// Token: 0x040030D6 RID: 12502
	private float Elapsed;

	// Token: 0x040030D7 RID: 12503
	protected float Duration;
}
