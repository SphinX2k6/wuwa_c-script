using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200106F RID: 4207
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCheckItem : UiPanelBase
{
	// Token: 0x06006C9E RID: 27806 RVA: 0x0015F39A File Offset: 0x0015D59A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06006C9F RID: 27807 RVA: 0x0015F3BD File Offset: 0x0015D5BD
	protected override void OnBeforeShow()
	{
		base.SetUiActive(false);
	}

	// Token: 0x06006CA0 RID: 27808 RVA: 0x0015F3C6 File Offset: 0x0015D5C6
	protected override void OnStart()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.UpdateMoveProgress));
	}

	// Token: 0x06006CA1 RID: 27809 RVA: 0x0015F3DF File Offset: 0x0015D5DF
	protected override void OnBeforeDestroy()
	{
		this.StopMove();
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.UpdateMoveProgress));
			this.Delegate = null;
		}
	}

	// Token: 0x06006CA2 RID: 27810 RVA: 0x0015F408 File Offset: 0x0015D608
	public void ShowAndMoveToCards(List<GuessJokerCardItem> cardItemList, [Nullable(2)] Action onComplete = null)
	{
		if (cardItemList.Count == 0)
		{
			Action onComplete2 = onComplete;
			if (onComplete2 == null)
			{
				return;
			}
			onComplete2();
			return;
		}
		else
		{
			this.StopMove();
			this.ClearStayTimer();
			GuessJokerCardItem guessJokerCardItem = cardItemList[0];
			if (guessJokerCardItem == null)
			{
				Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "第一张卡牌不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action onComplete3 = onComplete;
				if (onComplete3 == null)
				{
					return;
				}
				onComplete3();
				return;
			}
			else
			{
				FVector2D currentPosition = guessJokerCardItem.GetCurrentPosition();
				Vector2D vector2D = new Vector2D((double)currentPosition.X, (double)(currentPosition.Y + 200f));
				this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
				base.SetUiActive(true);
				if (cardItemList.Count == 1)
				{
					this.StayAndComplete(cardItemList[0], onComplete);
					return;
				}
				this.StayAndMoveToNext(cardItemList, 1, delegate
				{
					Action onComplete4 = onComplete;
					if (onComplete4 == null)
					{
						return;
					}
					onComplete4();
				});
				return;
			}
		}
	}

	// Token: 0x06006CA3 RID: 27811 RVA: 0x0015F4F0 File Offset: 0x0015D6F0
	private void StayAndMoveToNext(List<GuessJokerCardItem> cardItemList, int currentIndex, [Nullable(2)] Action onComplete = null)
	{
		this.ClearStayTimer();
		this.StayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.MoveToNextCard(cardItemList, currentIndex, onComplete);
		}, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCheckItemStayTime.ToString()), null, null, true, 1f);
	}

	// Token: 0x06006CA4 RID: 27812 RVA: 0x0015F560 File Offset: 0x0015D760
	private void MoveToNextCard(List<GuessJokerCardItem> cardItemList, int currentIndex, [Nullable(2)] Action onComplete = null)
	{
		if (currentIndex >= cardItemList.Count)
		{
			this.StayAndComplete(cardItemList[cardItemList.Count - 1], onComplete);
			return;
		}
		GuessJokerCardItem guessJokerCardItem = cardItemList[currentIndex];
		if (guessJokerCardItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("卡牌索引");
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentIndex);
			defaultInterpolatedStringHandler.AppendLiteral("不存在");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StayAndComplete(cardItemList[cardItemList.Count - 1], onComplete);
			return;
		}
		FVector2D currentPosition = guessJokerCardItem.GetCurrentPosition();
		Vector2D targetPosition = new Vector2D((double)currentPosition.X, (double)(currentPosition.Y + 200f));
		this.SmoothMoveTo(targetPosition, delegate
		{
			this.StayAndMoveToNext(cardItemList, currentIndex + 1, onComplete);
		}, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCheckItemMoveTime.ToString()));
	}

	// Token: 0x06006CA5 RID: 27813 RVA: 0x0015F69C File Offset: 0x0015D89C
	private void SmoothMoveTo(Vector2D targetPosition, [Nullable(2)] Action onComplete = null, float duration = 0f)
	{
		if (duration == 0f)
		{
			duration = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCheckItemMoveTime.ToString());
		}
		if (this.IsMoving)
		{
			this.StopMove();
		}
		this.MoveCompleteCallback = onComplete;
		this.IsMoving = true;
		FVector2D currentPosition = this.GetCurrentPosition();
		FVector2D fvector2D = targetPosition.ToUeVector2D(false);
		if (Math.Abs(currentPosition.X - fvector2D.X) < 0.01f && Math.Abs(currentPosition.Y - fvector2D.Y) < 0.01f)
		{
			this.OnMoveComplete();
			return;
		}
		this.StartPosition.X = currentPosition.X;
		this.StartPosition.Y = currentPosition.Y;
		this.TargetPosition.X = fvector2D.X;
		this.TargetPosition.Y = fvector2D.Y;
		this.CurrentTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, 0f, 1f, duration / 1000f, 0f, LTweenEase.InOutCubic);
		if (this.CurrentTweener != null)
		{
			this.CurrentTweener.OnCompleteCallBack.Bind(new Action(this.OnMoveComplete));
		}
	}

	// Token: 0x06006CA6 RID: 27814 RVA: 0x0015F7C4 File Offset: 0x0015D9C4
	private void UpdateMoveProgress(float progress)
	{
		if (this.RootItem != null)
		{
			float inX = this.StartPosition.X + (this.TargetPosition.X - this.StartPosition.X) * progress;
			float inY = this.StartPosition.Y + (this.TargetPosition.Y - this.StartPosition.Y) * progress;
			this.RootItem.SetAnchorOffset(new FVector2D(inX, inY));
		}
	}

	// Token: 0x06006CA7 RID: 27815 RVA: 0x0015F838 File Offset: 0x0015DA38
	private void StayAndComplete(GuessJokerCardItem cardItem, [Nullable(2)] Action onComplete = null)
	{
		this.ClearStayTimer();
		FVector2D currentPosition = cardItem.GetCurrentPosition();
		Vector2D targetPos = new Vector2D((double)currentPosition.X, (double)currentPosition.Y);
		Action <>9__1;
		this.StayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			GuessJokerCheckItem <>4__this = this;
			Vector2D targetPos = targetPos;
			Action onComplete2;
			if ((onComplete2 = <>9__1) == null)
			{
				onComplete2 = (<>9__1 = delegate()
				{
					Action onComplete3 = onComplete;
					if (onComplete3 != null)
					{
						onComplete3();
					}
					cardItem.SetCheckCardItem(true);
					this.HideItem();
				});
			}
			<>4__this.SmoothMoveTo(targetPos, onComplete2, 0f);
		}, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCheckItemStayTime.ToString()), null, null, true, 1f);
	}

	// Token: 0x06006CA8 RID: 27816 RVA: 0x0015F8C5 File Offset: 0x0015DAC5
	private void OnMoveComplete()
	{
		this.IsMoving = false;
		Action moveCompleteCallback = this.MoveCompleteCallback;
		if (moveCompleteCallback == null)
		{
			return;
		}
		moveCompleteCallback();
	}

	// Token: 0x06006CA9 RID: 27817 RVA: 0x0015F8DE File Offset: 0x0015DADE
	public void StopMove()
	{
		if (this.CurrentTweener != null)
		{
			this.CurrentTweener.Kill(false);
			this.CurrentTweener.OnCompleteCallBack.Unbind();
			this.CurrentTweener = null;
		}
		this.IsMoving = false;
		this.MoveCompleteCallback = null;
	}

	// Token: 0x06006CAA RID: 27818 RVA: 0x0015F919 File Offset: 0x0015DB19
	private FVector2D GetCurrentPosition()
	{
		if (this.RootItem != null)
		{
			return this.RootItem.GetAnchorOffset();
		}
		return new FVector2D(0f, 0f);
	}

	// Token: 0x06006CAB RID: 27819 RVA: 0x0015F93E File Offset: 0x0015DB3E
	public void HideItem()
	{
		this.StopMove();
		this.ClearStayTimer();
		base.SetUiActive(false);
	}

	// Token: 0x06006CAC RID: 27820 RVA: 0x0015F953 File Offset: 0x0015DB53
	private void ClearStayTimer()
	{
		if (this.StayTimerHandle != null)
		{
			if (TimerSystem.Instance.Has(this.StayTimerHandle))
			{
				TimerSystem.Instance.Remove(this.StayTimerHandle);
			}
			this.StayTimerHandle = null;
		}
	}

	// Token: 0x0400324C RID: 12876
	[Nullable(2)]
	private ULTweener CurrentTweener;

	// Token: 0x0400324D RID: 12877
	[Nullable(2)]
	private TimerHandle StayTimerHandle;

	// Token: 0x0400324E RID: 12878
	private bool IsMoving;

	// Token: 0x0400324F RID: 12879
	[Nullable(2)]
	private Action MoveCompleteCallback;

	// Token: 0x04003250 RID: 12880
	[Nullable(2)]
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003251 RID: 12881
	private FVector2D StartPosition = new FVector2D();

	// Token: 0x04003252 RID: 12882
	private FVector2D TargetPosition = new FVector2D();
}
