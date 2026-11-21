using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000523 RID: 1315
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCheckItem : UiPanelBase
{
	// Token: 0x06004033 RID: 16435 RVA: 0x00167CCE File Offset: 0x00165ECE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06004034 RID: 16436 RVA: 0x00167CF1 File Offset: 0x00165EF1
	protected override void OnBeforeShow()
	{
		base.SetUiActive(false);
	}

	// Token: 0x06004035 RID: 16437 RVA: 0x00167CFA File Offset: 0x00165EFA
	protected override void OnStart()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.UpdateMoveProgress));
	}

	// Token: 0x06004036 RID: 16438 RVA: 0x00167D13 File Offset: 0x00165F13
	protected override void OnBeforeDestroy()
	{
		this.StopMove();
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.UpdateMoveProgress));
			this.Delegate = null;
		}
	}

	// Token: 0x06004037 RID: 16439 RVA: 0x00167D3C File Offset: 0x00165F3C
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

	// Token: 0x06004038 RID: 16440 RVA: 0x00167E24 File Offset: 0x00166024
	private void StayAndMoveToNext(List<GuessJokerCardItem> cardItemList, int currentIndex, [Nullable(2)] Action onComplete = null)
	{
		this.ClearStayTimer();
		this.StayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.MoveToNextCard(cardItemList, currentIndex, onComplete);
		}, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCheckItemStayTime.ToString()), null, null, true, 1f);
	}

	// Token: 0x06004039 RID: 16441 RVA: 0x00167E94 File Offset: 0x00166094
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

	// Token: 0x0600403A RID: 16442 RVA: 0x00167FD0 File Offset: 0x001661D0
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

	// Token: 0x0600403B RID: 16443 RVA: 0x001680F8 File Offset: 0x001662F8
	private void UpdateMoveProgress(float progress)
	{
		if (this.RootItem != null)
		{
			float inX = this.StartPosition.X + (this.TargetPosition.X - this.StartPosition.X) * progress;
			float inY = this.StartPosition.Y + (this.TargetPosition.Y - this.StartPosition.Y) * progress;
			this.RootItem.SetAnchorOffset(new FVector2D(inX, inY));
		}
	}

	// Token: 0x0600403C RID: 16444 RVA: 0x0016816C File Offset: 0x0016636C
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

	// Token: 0x0600403D RID: 16445 RVA: 0x001681F9 File Offset: 0x001663F9
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

	// Token: 0x0600403E RID: 16446 RVA: 0x00168212 File Offset: 0x00166412
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

	// Token: 0x0600403F RID: 16447 RVA: 0x0016824D File Offset: 0x0016644D
	private FVector2D GetCurrentPosition()
	{
		if (this.RootItem != null)
		{
			return this.RootItem.GetAnchorOffset();
		}
		return new FVector2D(0f, 0f);
	}

	// Token: 0x06004040 RID: 16448 RVA: 0x00168272 File Offset: 0x00166472
	public void HideItem()
	{
		this.StopMove();
		this.ClearStayTimer();
		base.SetUiActive(false);
	}

	// Token: 0x06004041 RID: 16449 RVA: 0x00168287 File Offset: 0x00166487
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

	// Token: 0x040032E5 RID: 13029
	[Nullable(2)]
	private ULTweener CurrentTweener;

	// Token: 0x040032E6 RID: 13030
	[Nullable(2)]
	private TimerHandle StayTimerHandle;

	// Token: 0x040032E7 RID: 13031
	private bool IsMoving;

	// Token: 0x040032E8 RID: 13032
	[Nullable(2)]
	private Action MoveCompleteCallback;

	// Token: 0x040032E9 RID: 13033
	[Nullable(2)]
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x040032EA RID: 13034
	private FVector2D StartPosition = new FVector2D();

	// Token: 0x040032EB RID: 13035
	private FVector2D TargetPosition = new FVector2D();
}
