using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E8 RID: 25832
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeTrailEffectView : UiPanelBase
	{
		// Token: 0x06040D7A RID: 265594 RVA: 0x00FB50BB File Offset: 0x00FB32BB
		public void SetCurves(UCurveFloat curveX, UCurveFloat curveY)
		{
			this.CurveX = curveX;
			this.CurveY = curveY;
		}

		// Token: 0x06040D7B RID: 265595 RVA: 0x00FB50CB File Offset: 0x00FB32CB
		public void BindBoard(float originX, float originY, float stepX, float stepY)
		{
			this.BoardOriginX = originX;
			this.BoardOriginY = originY;
			this.CellStepX = stepX;
			this.CellStepY = stepY;
		}

		// Token: 0x06040D7C RID: 265596 RVA: 0x00FB50EC File Offset: 0x00FB32EC
		public void ResetForReuse(GridPosition origin)
		{
			this.KillTween();
			this.MoveToAbs(this.BoardOriginX + (float)origin.Col * this.CellStepX, this.BoardOriginY - (float)origin.Row * this.CellStepY);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x06040D7D RID: 265597 RVA: 0x00FB5140 File Offset: 0x00FB3340
		[NullableContext(1)]
		public void ResetForReuseAt(UUIItem from)
		{
			this.KillTween();
			FVector lguispaceCenterAbsolutePosition = from.GetLGUISpaceCenterAbsolutePosition();
			this.MoveToAbs(lguispaceCenterAbsolutePosition.X, lguispaceCenterAbsolutePosition.Y);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x06040D7E RID: 265598 RVA: 0x00FB517D File Offset: 0x00FB337D
		public void RecycleToPool()
		{
			this.KillTween();
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x06040D7F RID: 265599 RVA: 0x00FB5196 File Offset: 0x00FB3396
		public UniTask FlyToAsync(GridPosition target, int extraMs = 0)
		{
			return this.FlyToAbsAsync(this.BoardOriginX + (float)target.Col * this.CellStepX, this.BoardOriginY - (float)target.Row * this.CellStepY, extraMs);
		}

		// Token: 0x06040D80 RID: 265600 RVA: 0x00FB51CC File Offset: 0x00FB33CC
		[NullableContext(1)]
		public UniTask FlyToAsync(UUIItem target)
		{
			FVector lguispaceCenterAbsolutePosition = target.GetLGUISpaceCenterAbsolutePosition();
			return this.FlyToAbsAsync(lguispaceCenterAbsolutePosition.X, lguispaceCenterAbsolutePosition.Y, 0);
		}

		// Token: 0x06040D81 RID: 265601 RVA: 0x00FB51F4 File Offset: 0x00FB33F4
		private UniTask FlyToAbsAsync(float centerAbsX, float centerAbsY, int extraMs = 0)
		{
			this.KillTween();
			if (this.RootItem == null)
			{
				return UniTask.CompletedTask;
			}
			float toX;
			float toY;
			this.AbsToOffset(centerAbsX, centerAbsY, out toX, out toY);
			return this.FlyToOffsetAsync(this.RootItem.GetAnchorOffsetX(), this.RootItem.GetAnchorOffsetY(), toX, toY, extraMs);
		}

		// Token: 0x06040D82 RID: 265602 RVA: 0x00FB5240 File Offset: 0x00FB3440
		private UniTask FlyToOffsetAsync(float fromX, float fromY, float toX, float toY, int extraMs)
		{
			int num = MatchThreeTrailEffectView.FlyMs(fromX, fromY, toX, toY) + extraMs;
			if (num <= 0)
			{
				this.SetLocalOffset(toX, toY);
				return UniTask.CompletedTask;
			}
			this.Tweener = ((this.CurveX != null && this.CurveY != null) ? this.StartCurveTween(fromX, fromY, toX, toY, num) : this.StartLineTween(fromX, fromY, toX, toY, num));
			if (this.Tweener == null)
			{
				this.SetLocalOffset(toX, toY);
				return UniTask.CompletedTask;
			}
			this.Tcs = AutoResetUniTaskCompletionSource.Create();
			FLTweenerDynamicDelegate onCompleteCallBack = this.Tweener.OnCompleteCallBack;
			Action callback;
			if ((callback = this.CompleteAction) == null)
			{
				callback = (this.CompleteAction = new Action(this.OnTweenComplete));
			}
			onCompleteCallBack.Bind(callback);
			return this.Tcs.Task;
		}

		// Token: 0x06040D83 RID: 265603 RVA: 0x00FB52FC File Offset: 0x00FB34FC
		private ULTweener StartLineTween(float fromX, float fromY, float toX, float toY, int durationMs)
		{
			if (this.MoveSetter == null)
			{
				this.MoveSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenLocation));
			}
			this.TempFrom.Set((double)fromX, (double)fromY);
			this.TempLocation.Set((double)toX, (double)toY);
			return ULTweenBPLibrary.Vector2To(GlobalData.World, this.MoveSetter, this.TempFrom.ToUeVector2D(true), this.TempLocation.ToUeVector2D(true), (float)durationMs / 1000f, 0f, LTweenEase.InQuad);
		}

		// Token: 0x06040D84 RID: 265604 RVA: 0x00FB5380 File Offset: 0x00FB3580
		private ULTweener StartCurveTween(float fromX, float fromY, float toX, float toY, int durationMs)
		{
			this.FromX = fromX;
			this.FromY = fromY;
			this.ToX = toX;
			this.ToY = toY;
			if (this.ProgressSetter == null)
			{
				this.ProgressSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnTweenProgress));
			}
			return ULTweenBPLibrary.FloatTo(GlobalData.World, this.ProgressSetter, 0f, 1f, (float)durationMs / 1000f, 0f, LTweenEase.Linear);
		}

		// Token: 0x06040D85 RID: 265605 RVA: 0x00FB53F4 File Offset: 0x00FB35F4
		private void MoveToAbs(float centerAbsX, float centerAbsY)
		{
			if (this.RootItem == null)
			{
				return;
			}
			float x;
			float y;
			this.AbsToOffset(centerAbsX, centerAbsY, out x, out y);
			this.SetLocalOffset(x, y);
		}

		// Token: 0x06040D86 RID: 265606 RVA: 0x00FB5420 File Offset: 0x00FB3620
		private void AbsToOffset(float centerAbsX, float centerAbsY, out float offsetX, out float offsetY)
		{
			FVector relativeLocation = this.RootItem.RelativeLocation;
			float num = 0f;
			float num2 = 0f;
			UUIItem parentAsUIItem = this.RootItem.GetParentAsUIItem();
			if (parentAsUIItem != null)
			{
				FVector lguispaceAbsolutePosition = parentAsUIItem.GetLGUISpaceAbsolutePosition();
				num = lguispaceAbsolutePosition.X;
				num2 = lguispaceAbsolutePosition.Y;
			}
			FVector2D pivot = this.RootItem.GetPivot();
			offsetX = centerAbsX - (0.5f - pivot.X) * this.RootItem.GetWidth() - num - (relativeLocation.X - this.RootItem.GetAnchorOffsetX());
			offsetY = centerAbsY - (0.5f - pivot.Y) * this.RootItem.GetHeight() - num2 - (relativeLocation.Y - this.RootItem.GetAnchorOffsetY());
		}

		// Token: 0x06040D87 RID: 265607 RVA: 0x00FB54D9 File Offset: 0x00FB36D9
		private void SetLocalOffset(float x, float y)
		{
			this.TempLocation.Set((double)x, (double)y);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(this.TempLocation.ToUeVector2D(true));
		}

		// Token: 0x06040D88 RID: 265608 RVA: 0x00FB5506 File Offset: 0x00FB3706
		private static int FlyMs(float fromX, float fromY, float toX, float toY)
		{
			return (int)((Math.Abs(toX - fromX) + Math.Abs(toY - fromY)) / 2500f * 1000f);
		}

		// Token: 0x06040D89 RID: 265609 RVA: 0x00FB5526 File Offset: 0x00FB3726
		private void OnTweenLocation(FVector2D value)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(value);
		}

		// Token: 0x06040D8A RID: 265610 RVA: 0x00FB553C File Offset: 0x00FB373C
		private void OnTweenProgress(float t)
		{
			this.SetLocalOffset(this.FromX + (this.ToX - this.FromX) * this.CurveX.GetFloatValue(t), this.FromY + (this.ToY - this.FromY) * this.CurveY.GetFloatValue(t));
		}

		// Token: 0x06040D8B RID: 265611 RVA: 0x00FB5591 File Offset: 0x00FB3791
		private void OnTweenComplete()
		{
			this.Tweener = null;
			AutoResetUniTaskCompletionSource tcs = this.Tcs;
			this.Tcs = null;
			if (tcs == null)
			{
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06040D8C RID: 265612 RVA: 0x00FB55B4 File Offset: 0x00FB37B4
		private void KillTween()
		{
			ULTweener tweener = this.Tweener;
			if (tweener != null && tweener.IsValid())
			{
				this.Tweener.Kill(false);
			}
			this.Tweener = null;
			AutoResetUniTaskCompletionSource tcs = this.Tcs;
			this.Tcs = null;
			if (tcs == null)
			{
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06040D8D RID: 265613 RVA: 0x00FB5600 File Offset: 0x00FB3800
		protected override void OnBeforeDestroy()
		{
			this.KillTween();
			FLTweenVector2SetterDynamic moveSetter = this.MoveSetter;
			if (moveSetter != null && moveSetter.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenLocation));
			}
			this.MoveSetter = null;
			FLTweenFloatSetterDynamic progressSetter = this.ProgressSetter;
			if (progressSetter != null && progressSetter.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnTweenProgress));
			}
			this.ProgressSetter = null;
		}

		// Token: 0x04021C7F RID: 138367
		[Nullable(1)]
		private readonly Vector2D TempLocation = Vector2D.Create();

		// Token: 0x04021C80 RID: 138368
		[Nullable(1)]
		private readonly Vector2D TempFrom = Vector2D.Create();

		// Token: 0x04021C81 RID: 138369
		private ULTweener Tweener;

		// Token: 0x04021C82 RID: 138370
		private AutoResetUniTaskCompletionSource Tcs;

		// Token: 0x04021C83 RID: 138371
		private FLTweenVector2SetterDynamic MoveSetter;

		// Token: 0x04021C84 RID: 138372
		private FLTweenFloatSetterDynamic ProgressSetter;

		// Token: 0x04021C85 RID: 138373
		private Action CompleteAction;

		// Token: 0x04021C86 RID: 138374
		private UCurveFloat CurveX;

		// Token: 0x04021C87 RID: 138375
		private UCurveFloat CurveY;

		// Token: 0x04021C88 RID: 138376
		private float FromX;

		// Token: 0x04021C89 RID: 138377
		private float FromY;

		// Token: 0x04021C8A RID: 138378
		private float ToX;

		// Token: 0x04021C8B RID: 138379
		private float ToY;

		// Token: 0x04021C8C RID: 138380
		private float BoardOriginX;

		// Token: 0x04021C8D RID: 138381
		private float BoardOriginY;

		// Token: 0x04021C8E RID: 138382
		private float CellStepX;

		// Token: 0x04021C8F RID: 138383
		private float CellStepY;
	}
}
